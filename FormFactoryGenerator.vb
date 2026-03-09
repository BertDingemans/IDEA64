Namespace DLAFormfactory

    ''' <summary>
    ''' Class for generating source code for the forfactory ASP.Net application.
    ''' (Specific routines not further documented)
    ''' </summary>
    Public Class FormFactoryGenerator
        Private blnCommit As Boolean = True
        Private Repository As EA.Repository = DLA2EAHelper.GetRepository()
        Private oDB As DLADatabase

        ''' <summary>
        ''' Process the enumerations and transform it to rows in the codelist table in the formfactory
        ''' </summary>
        ''' <param name="EnumDT"></param>
        ''' <param name="Delete"></param>
        ''' <param name="Insert"></param>
        Public Sub ProcessEnumerations(EnumDT As DataTable, Delete As Boolean, Insert As Boolean)
            Dim ListOfEnumerations As DataTable
            Dim oDV As New DataView(EnumDT)
            Try
                ListOfEnumerations = oDV.ToTable(True, {"EnumName"})
                For Each Row As DataRow In ListOfEnumerations.Rows
                    'Deletes verwerken
                    Dim Name As String = Row("EnumName")
                    Dim strDeleteSQL As String = String.Format("DELETE FROM WEBCODELIST WHERE [Section] = '{0}' ", Name)
                    If Not oDB.ExecuteModify(strDeleteSQL) Then
                        blnCommit = False
                    End If
                    Dim oDVList As New DataView(EnumDT)
                    oDVList.RowFilter = String.Format("EnumName = '{0}' ", Name)
                    For Each LRow As DataRow In oDVList.ToTable().Rows
                        Dim strInsertSQL As String = String.Format("INSERT INTO [dbo].[WEBCODELIST] ([searchcode],[description],[section],[blocked],[languagecode]) VALUES ('{1}','{1}','{0}',0,'AL')", Name, LRow("EnumValue"))
                        If Not oDB.ExecuteModify(strInsertSQL) Then
                            blnCommit = False
                        End If
                    Next
                Next
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
        End Sub
        ''' <summary>
        ''' Create a webform entity in the form factory based on the name
        ''' First delete all the rows in the table and the child table based on a list name
        ''' </summary>
        ''' <param name="Name"></param>
        ''' <param name="Delete"></param>
        ''' <param name="Insert"></param>
        ''' <param name="CommandDT"></param>
        Public Sub ProcessListForm(Name As String, Delete As Boolean, Insert As Boolean, CommandDT As DataTable)
            Try
                If Delete = True Then
                    'Deletes verwerken
                    Dim strDeleteControlSQL As String = String.Format("DELETE FROM WEBCONTROL WHERE webformid IN(SELECT webformid FROM WEBFORM WHERE [FormTitle] = 'Search_{0}' ) ", Name)
                    Dim strDeleteSQL As String = String.Format("DELETE FROM WEBFORM WHERE [FormTitle] = 'Search_{0}' ", Name)
                    If Not oDB.ExecuteModify(strDeleteControlSQL) Then
                        blnCommit = False
                    End If
                    If Not oDB.ExecuteModify(strDeleteSQL) Then
                        blnCommit = False
                    End If
                End If
                If Insert = True Then
                    'Insert uitvoeren alleen voor formulieren
                    Dim strInsertSQL As String = String.Format("INSERT INTO WEBFORM (webformid, formtitle, formtype ) SELECT Max(webformid) + 1, 'Search_{0}', 'Entry form' FROM WEBFORM ", Name)
                    If Not oDB.ExecuteModify(strInsertSQL) Then
                        blnCommit = False
                    End If
                    'Create ListControl
                    Dim strLookup = Lookup2Statement("Lookup_" + Name, CommandDT)
                    If strLookup.Length = 0 Then
                        strLookup = String.Format("'SELECT {0}ID, ''Click for Detail'' as description FROM {0} '", Name)
                    End If
                    Dim strInsertControlSql = String.Format("
Insert INTO [dbo].[WEBCONTROL] ([webformid],
[controlname],
[controllabel],
[controlorder],
[colspan],
[controlheight],
[controlrequired],
[controlsql],
[controltype],
[controlwidth],
[weblevelid],
[languagecode],
[controlconnection],
[Linkname]) 
VALUES
((SELECT webformid FROM WEBFORM WHERE formtitle = 'Search_{0}'),
'list{0}',
'{0}',
100,
1,
NULL,
0,
{1},
'Listview',
NULL,
(SELECT Min(weblevelid) FROM WEBLEVEL),
'AL',
'CONNECTIONSTRING',
'frmEntry.aspx?webformid={0}&Mode=DISPLAY&id=')",
Name,
strLookup)
                    If Not oDB.ExecuteModify(strInsertControlSql) Then
                        blnCommit = False
                    End If
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
        End Sub
        ''' <summary>
        ''' Process parent relation for an added linked table
        ''' Unfortunately not yety possible with the relevant lookups
        ''' </summary>
        ''' <param name="Parent"></param>
        ''' <param name="RelationDT"></param>
        ''' <param name="Insert"></param>
        Public Sub ProcessParentRelation(Parent As String, RelationDT As DataTable, Insert As Boolean)
            Try
                If Insert Then
                    'Create ListControl
                    Dim oDV As New DataView(RelationDT)
                    oDV.RowFilter = String.Format("parentname = '{0}' ", Parent)
                    Dim oRelDT As DataTable = oDV.ToTable()
                    For Each Row In oRelDT.Rows
                        Dim Lookup = Row("parentlookup").ToString().Replace("'", "''")
                        If Lookup.Length = 0 Then
                            Lookup = String.Format("SELECT {1}id, ''Click for {0} Details'' as Description FROM {0} WHERE {1}id = @@id@@ ", Row("ChildName"), Row("ParentName"))
                        End If
                        Dim strInsertControlSql = String.Format("
                    Insert INTO [dbo].[WEBCONTROL] ([webformid],
                    [controlname],
                    [controllabel],
                    [controlorder],
                    [colspan],
                    [controlheight],
                    [controlrequired],
                    [controlsql],
                    [controltype],
                    [controlwidth],
                    [weblevelid],
                    [languagecode],
                    [controlconnection],
                    [Linkname]) 
                    VALUES
                    ((SELECT webformid FROM WEBFORM WHERE formtitle = '{0}'),
                    'list{1}',
                    '{3}',
                    500,
                    1,
                    NULL,
                    0,
                    '{2}',
                    'Listview',
                    NULL,
                    (SELECT Min(weblevelid) FROM WEBLEVEL),
                    'AL',
                    'CONNECTIONSTRING',
                    'frmEntry.aspx?webformid={1}&Mode=DISPLAY&id=')",
                        Row("ParentName"), Row("Childname"), Lookup, Row("RelationName"))
                        If Not oDB.ExecuteModify(strInsertControlSql) Then
                            blnCommit = False
                        End If
                    Next
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
        End Sub
        ''' <summary>
        ''' First delete all the rows in the table and the child table based on a entity name
        ''' </summary>
        ''' <param name="Name"></param>
        ''' <param name="Delete"></param>
        ''' <param name="Insert"></param>
        Public Sub ProcessForm(Name As String, Delete As Boolean, Insert As Boolean)
            Try
                If Delete = True Then
                    'Deletes verwerken
                    Dim strDeleteControlSQL As String = String.Format("DELETE FROM WEBCONTROL WHERE webformid IN(SELECT webformid FROM WEBFORM WHERE [FormTitle] IN('{0}', 'Search_{0}') ) ", Name)
                    Dim strDeleteConditionSQL As String = String.Format("DELETE FROM WEBCONDITION WHERE webformid IN(SELECT webformid FROM WEBFORM WHERE [FormTitle] IN('{0}', 'Search_{0}') ) ", Name)
                    Dim strDeleteSQL As String = String.Format("DELETE FROM WEBFORM WHERE [FormTitle]IN('{0}', 'Search_{0}') ", Name)
                    If Not oDB.ExecuteModify(strDeleteControlSQL) Then
                        blnCommit = False
                    End If
                    If Not oDB.ExecuteModify(strDeleteConditionSQL) Then
                        blnCommit = False
                    End If
                    If Not oDB.ExecuteModify(strDeleteSQL) Then
                        blnCommit = False
                    End If
                End If
                If Insert = True Then
                    'Insert uitvoeren alleen voor formulieren
                    Dim strInsertSQL As String = String.Format("INSERT INTO WEBFORM (webformid, formtitle, formtype ) SELECT Max(webformid) + 1, '{0}', 'Entry form' FROM WEBFORM ", Name)
                    If Not oDB.ExecuteModify(strInsertSQL) Then
                        blnCommit = False
                    End If
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
        End Sub
        ''' <summary>
        ''' Process a menu item in the form factory based on the entity name
        ''' </summary>
        ''' <param name="Name"></param>
        ''' <param name="Delete"></param>
        ''' <param name="Insert"></param>
        Public Sub ProcessMenu(Name As String, Delete As Boolean, Insert As Boolean)
            Try
                If Delete = True Then
                    'Deletes verwerken
                    Dim strDeleteSQL As String = String.Format("DELETE FROM WEBMENU WHERE menu_name='Overzichtmenu' AND [menu_caption] = '{0}' ", Name)
                    If Not oDB.ExecuteModify(strDeleteSQL) Then
                        blnCommit = False
                    End If
                End If
                If Insert = True Then
                    'Insert uitvoeren alleen voor formulieren
                    Dim strInsertSQL As String =
                        String.Format("INSERT INTO [dbo].[WEBMENU]
                                        ([linkname],[menu_caption] ,[menu_name]  ,[menuorder],[weblevelid],[weblevelid_max],[languagecode])
                                        VALUES 
                                        ('frmSearchList.aspx?module={0}&mode=direct','{0}','Overzichtmenu',{1},(SELECT min(weblevelid) FROM WEBLEVEL),(SELECT max(weblevelid) FROM WEBLEVEL),'AL')", Name, 100)
                    If Not oDB.ExecuteModify(strInsertSQL) Then
                        blnCommit = False
                    End If
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
        End Sub
        ''' <summary>
        ''' Transform a lookup statement to a SQL statement in the Formfactory tables
        ''' </summary>
        ''' <param name="Name"></param>
        ''' <param name="CommandDT"></param>
        ''' <returns></returns>
        Shared Function Lookup2Statement(Name As String, CommandDT As DataTable) As String
            Dim CommandDV As New DataView(CommandDT)
            Dim CommandPart As String() = Name.ToString().Split("_")
            Try
                CommandDV.RowFilter = String.Format("TableName='{0}' And CommandName = 'LOOKUP' ", CommandPart(1))
                Dim LookupDT As DataTable = CommandDV.ToTable()
                If LookupDT.Rows.Count = 1 Then
                    Dim LookupRow As DataRow = LookupDT.Rows(0)
                    Return "'" + LookupRow("Statement").ToString().Replace("'", "''") + "'"
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return ""

        End Function
        ''' <summary>
        ''' Transform attributes in a sql statement used in comboboxes to an sql statement in the form factory tables
        ''' </summary>
        ''' <param name="ControlDT"></param>
        ''' <param name="CommandDT"></param>
        ''' <param name="Name"></param>
        ''' <param name="Insert"></param>
        Public Sub ProcessControl(ControlDT As DataTable, CommandDT As DataTable, Name As String, Insert As Boolean)
            Try
                'Deletes zijn al verwerkt ivm foreign keys
                'Insert uitvoeren voor Controls en Commands
                If Insert = True Then
                    Dim oDVList As New DataView(ControlDT)
                    oDVList.RowFilter = String.Format("TableName = '{0}' ", Name)
                    Dim intTeller As Int32 = 100
                    For Each LRow As DataRow In oDVList.ToTable().Rows
                        Dim LookupSQL As String = "NULL"
                        Dim LookupName As String = LRow("ControlLookup").ToString()
                        If LookupName.Contains("Lookup") Then
                            LookupSQL = Lookup2Statement(LookupName, CommandDT)
                        End If
                        If LookupName.Contains("Enum") Then
                            LookupSQL = String.Format("'" + "SELECT searchcode, description From webcodelist Where section = ''{0}'' ORDER BY 2 " + "' ", LookupName)
                        End If
                        Dim strInsertSql = String.Format("
Insert INTO [dbo].[WEBCONTROL] ([webformid],
[controlname],
[controllabel],
[controlorder],
[colspan],
[controlheight],
[controlrequired],
[controlsql],
[controltype],
[controlwidth],
[weblevelid],
[languagecode],
[controlconnection]) 
VALUES
((SELECT webformid FROM WEBFORM WHERE formtitle = '{0}'),
'{1}',
'{2}',
{3},
1,
{4},
{7},
{8},
'{5}',
{6},
(SELECT Min(weblevelid) FROM WEBLEVEL),
'AL',
'CONNECTIONSTRING')",
    Name,
    LRow("controlname"),
    LRow("controlcaption"),
    intTeller,
    IIf(LRow("controltype").ToString().Contains("MultiLineEdit"), 150, 25),
    LRow("controltype").Replace("HiddenSLE", "Hidden"),
    IIf(LRow("controltype").ToString().Contains("Calendar") Or LRow("controltype").ToString().Contains("Number"), 250, 500),
    IIf(LRow("controlrequired") = True, 1, 0),
    LookupSQL)
                        If Not oDB.ExecuteModify(strInsertSql) Then
                            blnCommit = False
                        End If
                        intTeller += 10
                    Next

                    'Commandos verwerken
                    Dim oDVComList As New DataView(CommandDT)
                    oDVComList.RowFilter = String.Format("TableName = '{0}' ", Name)

                    For Each LComRow As DataRow In oDVComList.ToTable().Rows
                        Dim strCommand As String = LComRow("statement").ToString().Replace("'", "''")
                        If LComRow("commandname").ToString().Contains("DETAIL") Then
                            strCommand = strCommand.Replace("@@" + Name.ToLower() + "id@@", "@@id@@")
                        End If
                        Dim strInsertCommandSql = String.Format("
Insert INTO [dbo].[WEBCONTROL] ([webformid],
[controlname],
[controllabel],
[controlorder],
[colspan],
[controlheight],
[controlrequired],
[controlsql],
[controltype],
[controlwidth],
[weblevelid],
[languagecode],
[controlconnection]) 
VALUES
((SELECT webformid FROM WEBFORM WHERE formtitle = '{0}'),
'{1}',
'{1}',
999,
1,
NULL,
0,
'{2}',
'{1}Command',
NULL,
(SELECT Min(weblevelid) FROM WEBLEVEL),
'AL',
'CONNECTIONSTRING')",
    Name,
    LComRow("commandname").ToString().Replace("DETAIL", "SELECT"),
strCommand)
                        If Not oDB.ExecuteModify(strInsertCommandSql) Then
                            blnCommit = False
                        End If
                    Next
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
        End Sub
        ''' <summary>
        ''' Open the database to the form factory database
        ''' </summary>
        Sub OpenDataBase()
            Me.oDB = New DLADatabase(My.Settings.ConnectionString)
            oDB.OpenConnection(True)
        End Sub
        ''' <summary>
        ''' Close the database to the form factory database
        ''' </summary>
        Sub CloseDataBase()
            '           oDB.CloseConnection(blnCommit)
            oDB.CloseConnection(True)
        End Sub
        ''' <summary>
        ''' Transform the content of a package in the repo to a dataset that is the metamodel for the simulator
        ''' </summary>
        ''' <param name="Package"></param>
        ''' <param name="name"></param>
        ''' <returns></returns>
        Public Function Package2SimulatorDataset(Package As EA.Package, name As String) As SimulatorContainer
            Dim strPrimaryKey As String = ""
            Dim SimDataSet As New SimulatorContainer()
            Try
                SimDataSet.Repository = Me.Repository
                Me.ProcessPackage2DataSet(Package, SimDataSet)
                Me.ProcessPackageRelation2DataSet(Package, SimDataSet)
                SimDataSet.DataTable2Command()
                SimDataSet.AddExtraTable()
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return SimDataSet
        End Function
        ''' <summary>
        ''' Transform the content of a package to the dataset for the simulator
        ''' </summary>
        ''' <param name="Package"></param>
        ''' <param name="SimDataSet"></param>
        ''' <returns></returns>
        Function ProcessPackage2DataSet(Package As EA.Package, SimDataSet As SimulatorContainer) As Boolean
            Dim DT As DataTable
            Dim Element As EA.Element
            Dim Attribute As EA.Attribute

            Try
                For Each Element In Package.Elements
                    Select Case Element.Type.ToUpper()
                        Case "CLASS"
                            If Element.Stereotype.Length = 0 And Element.Abstract = False Then
                                DT = SimDataSet.AddTable(Element.Name)
                                'aanmaken velden en controls voor table
                                SimDataSet.Inheritance2DataSet(Element, DT)
                                SimDataSet.Attributes2Dataset(Element, DT)
                                ' aanmaken primaire sleutels
                                SimDataSet.AddPrimaryKey(DT, Element.Name)
                                SimDataSet.AddControl(Element.Name, Element.Name + "ID", "HiddenSLE", "", True, Element.Name)
                                SimDataSet.AddConditions(Element, DT)
                                'commandos aanmaken
                            End If
                        Case "INTERFACE"
                            If Element.Name.ToUpper().Contains("LOOKUP") Then
                                Dim strLookup As String = ""
                                For Each Attribute In Element.Attributes
                                    If Not Attribute.IsID Then
                                        If strLookup.Length > 0 Then
                                            strLookup += " + ' ' + "
                                        End If
                                        strLookup += Attribute.Name.Replace(" ", "_")
                                    End If
                                Next
                                'Nog niet af datatable name moet anders
                                SimDataSet.AddCalculatedColumn(SimDataSet.ContainerDataSet.Tables(Element.Name.Replace("Lookup_", "")), "Lookup", Element.Name, "String", strLookup)
                                SimDataSet.LookupToCommand(Element.Name.Replace("Lookup_", ""), strLookup)
                            End If
                        Case "ENUMERATION"
                            If Element.Name.ToUpper().Contains("ENUM") Then
                                For Each Attribute In Element.Attributes
                                    SimDataSet.AddEnumeration(Element.Name, Attribute.Name)
                                Next
                            End If
                    End Select
                Next
                'extra system tables for extended simulation
                For Each SubPack As EA.Package In Package.Packages
                    Me.ProcessPackage2DataSet(SubPack, SimDataSet)
                Next
                Return True
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try

        End Function
        ''' <summary>
        ''' Process the content of a package in the repository to the relevant relationships for the simulator
        ''' </summary>
        ''' <param name="Package"></param>
        ''' <param name="SimDataSet"></param>
        ''' <returns></returns>
        Function ProcessPackageRelation2DataSet(Package As EA.Package, SimDataSet As SimulatorContainer)
            For Each Element As EA.Element In Package.Elements
                SimDataSet.DefaultLookup(Element)
                SimDataSet.Connectors2DataSet(Element, Package.PackageID)
            Next
            For Each SubPack As EA.Package In Package.Packages
                Me.ProcessPackageRelation2DataSet(SubPack, SimDataSet)
            Next
            Return True
        End Function

    End Class

End Namespace
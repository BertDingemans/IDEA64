Imports System.Windows.Forms
Imports System.Xml
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports System.Data
Imports EA

Namespace DLAFormfactory
    ''' <summary>
    ''' Class for all kinds of helper routines, it is the base for all the other
    ''' routines and classes in the library
    ''' When possible shared functions are used so this functions like a function library
    ''' </summary>
    Public Class DLA2EAHelper
        'make this true to create assertions, not relevant any more since we can use the debugger
        Const AssertionOn As Boolean = False
        Public Shared Property SuppressWarningDialog As Boolean

        ''' <summary>
        ''' Recursively build a list of package ids from the package tree under a rootpackage
        ''' </summary>
        ''' <param name="oPackage">Rootpackage for constructing a list of package ids</param>
        ''' <returns>List of packageids in een comma separated text string</returns>
        Public Shared Function PackageTree2String(oPackage As EA.Package) As String
            Dim strRet As String
            strRet = ", " + oPackage.PackageID.ToString()
            Dim oSubPack As EA.Package
            For Each oSubPack In oPackage.Packages
                strRet += PackageTree2String(oSubPack)
            Next
            Return strRet
        End Function

        Public Shared Function IsSqLite() As Boolean
            Return DLA2EAHelper.GetRepository().ConnectionString.Contains(".qea")
        End Function

        ''' <summary>
        ''' Transform a list of selected rows in a datagrid to a datatable
        ''' </summary>
        ''' <param name="DG">DataGrid</param>
        ''' <returns>Datatable with only selected items as rows</returns>
        Public Shared Function SelectedGridRows2DataTable(DG As DataGridView) As DataTable
            Dim oResultDT As DataTable
            Dim oDT As DataTable = DG.DataSource
            oResultDT = oDT.Clone()
            For Each orow As DataGridViewRow In DG.SelectedRows
                oResultDT.ImportRow(oDT.Rows(orow.Index))
            Next
            Return oResultDT
        End Function
        ''' <summary>
        ''' Get an instance of the repository the IDEA addon is currently connected to
        ''' </summary>
        ''' <returns>Curenty Open Repository object</returns>
        Public Shared Function GetRepository() As EA.Repository
            Return GetObject(, "EA.App").Repository
        End Function
        ''' <summary>
        ''' Transform a name to a name with an initial capital character
        ''' </summary>
        ''' <param name="val">Value to transform</param>
        ''' <returns></returns>
        Shared Function InitCap(ByVal val As String) As String
            ' Test for nothing or empty.
            If String.IsNullOrEmpty(val) Then
                Return val
            Else
                Return val.Substring(0, 1).ToUpper() + val.Substring(1).ToLower()
            End If
        End Function

        ''' <summary>
        ''' Initialize the progressbar with a min and max value
        ''' </summary>
        ''' <param name="Bar"></param>
        ''' <param name="Count">Max value</param>
        Public Shared Sub SetProgressBarInit(Bar As System.Windows.Forms.ProgressBar, Count As Int32)
            Bar.Minimum = 0
            Bar.Maximum = Count
            Bar.Value = 0
        End Sub
        ''' <summary>
        ''' Insert a text to the windows clipboard
        ''' </summary>
        ''' <param name="Text">Text to add to clipboard</param>
        Public Shared Sub Text2ClipBoard(Text As String)
            System.Windows.Forms.Clipboard.SetText(Text)
        End Sub
        ''' <summary>
        ''' Write a SQL statement to the logfile
        ''' </summary>
        ''' <param name="strComments"></param>
        ''' <param name="strError"></param>
        Public Shared Sub SQL2Log(ByVal strComments As String, strError As String)
            Dim fileStream As FileStream
            Dim streamWriter As StreamWriter
            Dim strPath As String
            strPath = "c:\idea\sql.log"
            If System.IO.File.Exists(strPath) And Not strComments.Contains("IDEAConfig") Then
                fileStream = New FileStream(strPath, FileMode.Append, FileAccess.Write)
                '            Else
                '                fileStream = New FileStream(strPath, FileMode.Create, FileAccess.Write)
                streamWriter = New StreamWriter(fileStream)
                streamWriter.WriteLine(System.DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"))
                streamWriter.WriteLine("SQL: " & strComments)
                streamWriter.WriteLine("Error: " & strError)
                streamWriter.WriteLine("User: " & "")
                streamWriter.WriteLine("")
                streamWriter.Close()
                fileStream.Close()

            End If
        End Sub
        ''' <summary>
        ''' Write an error message to the error log
        ''' </summary>
        ''' <param name="ex">Exception</param>
        Public Shared Sub Error2Log(ByVal ex As Exception)
            Error2Log(ex.ToString())
        End Sub
        ''' <summary>
        ''' Make a popup of a specific message
        ''' </summary>
        ''' <param name="Message">Message to display</param>
        Public Shared Sub DebugAssertion(Message As String)
            If AssertionOn Then
                Text2ClipBoard(Message)
                ' MsgBox(Message, MsgBoxStyle.Question)
            End If
        End Sub
        ''' <summary>
        ''' Transform a selectstatement to a datatable object
        ''' </summary>
        ''' <param name="strStatement">SQL selectstatement</param>
        ''' <param name="objRepo">Repository is neccessary for executing the command to an EA repository </param>
        ''' <returns>A filled datatable</returns>
        Public Shared Function SQL2DataTable(ByVal strStatement As String, ByVal objRepo As EA.Repository) As DataTable
            Dim strVal As String
            Try
                strStatement = DLA2EAHelper.SQLForEAP(strStatement, objRepo)
                DLA2EAHelper.DebugAssertion(strStatement)
                strVal = objRepo.SQLQuery(strStatement)
                DLA2EAHelper.SQL2Log(strStatement, "OK")
                Return EAString2DataTable(strVal)
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
                DLA2EAHelper.SQL2Log(strStatement, ex.Message)

            End Try
            Return Nothing
        End Function
        ''' <summary>
        ''' Error message to the error logfile
        ''' </summary>
        ''' <param name="msg">The message to add to the log file</param>
        Public Shared Sub Error2Log(ByVal msg As String)
            Dim oDef As New IDEADefinitions()
            Dim strPath As String
            strPath = oDef.GetSettingValue("LogFile")
            String2File(System.DateTime.Now.ToString() + msg + vbCrLf, strPath)
            If AssertionOn Then
                MsgBox(msg)
            End If
        End Sub

        ''' <summary>
        ''' Convert a stereotype to an objecttype for creating an element of the right type for the stereotype
        ''' </summary>
        ''' <param name="stereotype"></param>
        ''' <returns></returns>
        'Public Shared Function ConvertStereotype2Type(ByVal stereotype As String) As String
        '    Dim strRet As String = "Class"
        '    Select Case stereotype.ToUpper()
        '        Case "ARCHIMATE_APPLICATIONCOMPONENT"
        '            strRet = "Component"
        '        Case "ARCHIMATE_APPLICATIONINTERFACE"
        '            strRet = "Interface"
        '        Case "ARCHIMATE_BUSINESSFUNCTION"
        '            strRet = "Activity"
        '        Case "ARCHIMATE_APPLICATIONFUNCTION"
        '            strRet = "ApplicationFunction"
        '        Case "ARCHIMATE_LOCATION"
        '            strRet = "Class"
        '        Case Else
        '            strRet = "Class"
        '    End Select
        '    Return strRet
        'End Function

        ''' <summary>
        ''' Create a list of tagged values for the element based on the tagged value defined in the repository
        ''' This makes it possible to create the tagged values based on this routine
        ''' It makes use of a config setting that you can define to limit the tagged values created
        ''' </summary>
        ''' <param name="Element"></param>
        ''' <param name="Repository"></param>
        ''' <returns></returns>
        Public Shared Function DefaultTaggedValues(Element As EA.Element, Repository As EA.Repository) As Boolean
            Dim Tag, oTV As EA.TaggedValue
            Dim oDef As New IDEADefinitions()
            Dim Prefix As String
            Dim oPT As EA.PropertyType
            Dim strPTTag As String
            Dim strNames As String = ";"
            Try
                Prefix = oDef.GetSettingValue("TaggedValuePrefix")
                If Prefix.Length > 0 Then
                    For Each oTV In Element.TaggedValues
                        strNames += oTV.Name + ";"
                    Next
                    For Each oPT In Repository.PropertyTypes

                        Dim blnCreateTag As Boolean = False
                        strPTTag = oPT.Tag.ToString()
                        If strNames.Contains(strPTTag) Then
                            blnCreateTag = False
                        Else
                            If strPTTag.Contains(Prefix) Then
                                If oPT.Detail.ToString().Contains("BaseStereotype") = False And Element.Stereotype.Length > 0 Then
                                    blnCreateTag = True
                                End If
                                If (oPT.Detail.ToString().Contains("BaseStereotype") And oPT.Detail.ToString().ToUpper().Contains(Element.Stereotype.ToUpper())) Then
                                    blnCreateTag = True
                                End If
                                If oPT.Detail.ToString().Contains("AppliesTo=" + Element.Type) Then
                                    blnCreateTag = True
                                End If
                                If blnCreateTag Then
                                    Tag = Element.TaggedValues.AddNew(oPT.Tag, "")
                                    Tag.Update()
                                End If
                            End If
                        End If
                    Next
                    Element.Update()
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return False
        End Function
        ''' <summary>
        ''' Export a diagram to a file based on the definition in the idea settings artifact
        ''' </summary>
        ''' <param name="diagram_id">Diagram id for opening and closing the diagram</param>
        ''' <param name="blnOpen">Check if the diagram is already open</param>
        ''' <param name="blnRecentModified">Check if the file is recently modified to prevent an extra write</param>
        ''' <param name="blnBatch">Batch export to open a diagram, check for existance and close the diagram after the batch export</param>
        ''' <returns></returns>
        Public Shared Function ExportDiagram(diagram_id As Int32, Optional blnOpen As Boolean = True, Optional blnRecentModified As Boolean = False, Optional blnBatch As Boolean = False) As Boolean
            Dim oDef As New IDEADefinitions()
            Dim Repository As EA.Repository = GetRepository()
            Try
                Dim strFile As String = oDef.GetSettingValue("WPP_Diagram_File")
                If strFile.Length > 1 Then
                    Dim oDiagram As EA.Diagram
                    oDiagram = Repository.GetDiagramByID(diagram_id)
                    Dim blnSave As Boolean = True
                    Dim Diff As TimeSpan = System.DateTime.Now - oDiagram.ModifiedDate
                    If blnRecentModified = True Then
                        If (Diff.Days <= 1 And Diff.Hours < 10) Then
                            blnSave = True
                        Else
                            blnSave = False
                        End If
                    End If

                    If blnSave Then
                        strFile = strFile.Replace("#diagram_id#", diagram_id.ToString())
                        strFile = strFile.Replace("#diagram_guid#", oDiagram.DiagramGUID)
                        If Not IO.File.Exists(strFile) Or blnBatch = False Then
                            If blnOpen = False Then
                                Repository.OpenDiagram(diagram_id)
                            End If
                            Repository.GetProjectInterface().SaveDiagramImageToFile(strFile)
                        End If
                        If blnBatch = True Then
                            Repository.CloseDiagram(diagram_id)
                        End If
                    End If
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
                Return False
            End Try
            Return True
        End Function
        ''' <summary>
        ''' Export a diagram in Sparx to a png file so it can be retrieved via WPP
        ''' </summary>
        ''' <param name="oPackage">Package from which the diagrams are exported</param>
        ''' <returns></returns>
        Public Shared Function Diagrams2WPP(oPackage As EA.Package) As Boolean
            Dim blnResult As Boolean = True
            Dim Rep As EA.Repository = GetRepository()
            Dim oDiagram As EA.Diagram
            Dim oSubPackage As EA.Package
            Try

                For Each oDiagram In oPackage.Diagrams
                    ExportDiagram(oDiagram.DiagramID, blnOpen:=False, blnBatch:=True)
                Next
                For Each oSubPackage In oPackage.Packages
                    Diagrams2WPP(oSubPackage)
                Next

            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
                blnResult = False
            End Try

            Return blnResult
        End Function

        ''' <summary>
        ''' Export a diagram in Sparx to a png file so it can be retrieved via WPP
        ''' </summary>
        ''' <param name="oPackage">Package from which the diagrams are exported</param>
        ''' <returns></returns>
        Public Shared Function LinkedDocument2WPP(oPackage As EA.Package) As Boolean
            Dim blnResult As Boolean = True
            Dim Rep As EA.Repository = GetRepository()
            Dim oDef As New IDEADefinitions()
            Dim oElement As EA.Element
            Dim oSubPackage As EA.Package
            Dim strDir As String = oDef.GetSettingValue("ReleaseDirectory") + "\"

            Try
                For Each oElement In oPackage.Elements
                    If oElement.GetLinkedDocument().Length > 200 Then
                        oElement.SaveLinkedDocument(strDir + oElement.ElementGUID + ".docx")
                    End If
                Next
                For Each oSubPackage In oPackage.Packages
                    LinkedDocument2WPP(oSubPackage)
                Next

            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
                blnResult = False
            End Try

            Return blnResult
        End Function
        ''' <summary>
        ''' Create a list of tagged values for the attribute based on the tagged value defined in the repository
        ''' This makes it possible to create the tagged values based on this routine
        ''' It makes use of a config setting that you can define to limit the tagged values created
        ''' </summary>
        ''' <param name="Attribute"></param>
        ''' <param name="Repository"></param>
        ''' <returns></returns>
        Public Shared Function DefaultTaggedValues(Attribute As EA.Attribute, Repository As EA.Repository) As Boolean
            Dim Tag As EA.AttributeTag
            Dim oDef As New IDEADefinitions()
            Dim Prefix As String
            Try
                Prefix = oDef.GetSettingValue("TaggedValuePrefix")
                If Prefix.Length > 0 Then
                    If Attribute.TaggedValues.Count = 0 Then
                        For Each oPT In Repository.PropertyTypes
                            Dim blnCreateTag As Boolean = False
                            If oPT.Tag.ToString().Contains(Prefix) Then
                                If oPT.Detail.ToString().Contains("AppliesTo=Attribute") Then
                                    blnCreateTag = True
                                End If
                                If blnCreateTag Then
                                    Tag = Attribute.TaggedValues.AddNew(oPT.Tag, "")
                                    Tag.Update()
                                End If
                            End If
                        Next
                        'Attribute.Update()
                        Return True
                    End If
                Else
                    Return False
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return False
        End Function

        ''' <summary>
        ''' Create a list of tagged values for the attribute based on the tagged value defined in the repository
        ''' This makes it possible to create the tagged values based on this routine
        ''' It makes use of a config setting that you can define to limit the tagged values created
        ''' </summary>
        ''' <param name="Connector"></param>
        ''' <param name="Repository"></param>
        ''' <returns></returns>
        Public Shared Function DefaultTaggedValues(Connector As EA.Connector, Repository As EA.Repository) As Boolean
            Dim Tag, oTV As EA.ConnectorTag
            Dim oDef As New IDEADefinitions()
            Dim Prefix As String
            Dim oPT As EA.PropertyType
            Dim strPTTag As String
            Dim strNames As String = ";"
            Try
                Prefix = oDef.GetSettingValue("TaggedValuePrefix")
                If Prefix.Length > 0 Then
                    For Each oTV In Connector.TaggedValues
                        strNames += oTV.Name + ";"
                    Next
                    For Each oPT In Repository.PropertyTypes

                        Dim blnCreateTag As Boolean = False
                        strPTTag = oPT.Tag.ToString()
                        If strNames.Contains(strPTTag) Then
                            blnCreateTag = False
                        Else
                            If strPTTag.Contains(Prefix) Then
                                If oPT.Detail.ToString().Contains("BaseStereotype") = False And Connector.Stereotype.Length > 0 Then
                                    blnCreateTag = True
                                End If
                                If (oPT.Detail.ToString().Contains("BaseStereotype") And oPT.Detail.ToString().ToUpper().Contains(Connector.Stereotype.ToUpper())) Then
                                    blnCreateTag = True
                                End If
                                If oPT.Detail.ToString().Contains("AppliesTo=" + Connector.Type) Then
                                    blnCreateTag = True
                                End If
                                If blnCreateTag Then
                                    Tag = Connector.TaggedValues.AddNew(oPT.Tag, "")
                                    Tag.Update()
                                End If
                            End If
                        End If
                    Next
                    Connector.Update()
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return False
        End Function
        ''' <summary>
        ''' Write a string to a textfile
        ''' </summary>
        ''' <param name="text">Text to write</param>
        ''' <param name="strPath">Path of the file</param>
        ''' <returns>Success or not</returns>
        Public Shared Function String2File(ByVal text As String, ByVal strPath As String, Optional Mode As FileMode = FileMode.Append) As Boolean
            Dim fileStream As FileStream
            Dim streamWriter As StreamWriter
            Try
                System.IO.File.WriteAllText(strPath, text, Encoding.UTF8)
                Return True
            Catch ex As Exception
                'this must be handled differently because this is also used for the errorhandling self
                GetRepository().WriteOutput("IDEA", text, 0)
                Clipboard.SetText(ex.ToString())
            End Try
            Return False
        End Function
        ''' <summary>
        ''' Transform a datatable to a CSV text
        ''' </summary>
        ''' <param name="dTable">Datatable to transform</param>
        ''' <returns>CSV string</returns>
        Public Shared Function Table2CSV(ByVal dTable As DataTable) As String
            Dim sb As StringBuilder = New StringBuilder()
            Dim intClmn As Integer = dTable.Columns.Count
            Dim i As Integer = 0
            Dim objColumn As DataColumn
            Dim blnFirst As Boolean = True
            For Each objColumn In dTable.Columns
                If objColumn.ColumnName.ToString().ToUpper() <> "DATA_ID" Then
                    If blnFirst = True Then
                        blnFirst = False
                    Else
                        sb.Append(",")
                    End If
                    sb.Append("""" + objColumn.ColumnName.ToString().Replace("-", " ").Trim() + """")
                End If
            Next
            sb.Append(vbNewLine)
            Dim row As DataRow
            For Each row In dTable.Rows
                Dim ir As Integer = 0
                blnFirst = True
                For Each objColumn In dTable.Columns
                    If objColumn.ColumnName.ToString().ToUpper() <> "DATA_ID" Then
                        If blnFirst = True Then
                            blnFirst = False
                        Else
                            sb.Append(",")
                        End If
                        sb.Append("""" + row.Item(objColumn.ColumnName).ToString().Replace("""", """""") + """")
                    End If
                Next
                sb.Append(vbNewLine)
            Next
            Return sb.ToString()
        End Function
        ''' <summary>
        ''' Execute a modify statement (insert update delete etc)
        ''' </summary>
        ''' <param name="SQL">SQL statement to execute</param>
        ''' <returns>Success or not</returns>
        Public Shared Function ExecuteModifySQL(ByVal SQL As String)
            Dim objDB As DLADatabase
            Dim blnOk As Boolean = False
            objDB = New DLADatabase()
            Try
                objDB.OpenConnection(True)
                DLA2EAHelper.DebugAssertion(SQL)
                blnOk = objDB.ExecuteModify(SQL)
                objDB.CloseConnection(True)
            Catch ex As Exception
                DLA2EAHelper.Error2Log(SQL)
                DLA2EAHelper.Error2Log(ex)
                blnOk = False
            Finally
                'objDB.CloseConnection(False)
            End Try
            Return blnOk
        End Function
        ''' <summary>
        ''' Is current login user member of a security group
        ''' </summary>
        ''' <param name="Repo">Currenty active repository</param>
        ''' <param name="Group">Security group name</param>
        ''' <returns>True when login is groupmember</returns>
        Public Shared Function IsUserGroupMember(ByVal Repo As EA.Repository, ByVal Group As String) As Boolean
            Dim blnAuthorized As Boolean = True
            If Repo.IsSecurityEnabled Then
                Dim strUserId As String
                strUserId = Repo.GetCurrentLoginUser(True)
                Dim strSql As String = "SELECT t_secgroup.groupname FROM t_secgroup, t_secusergroup WHERE t_secgroup.groupid = t_secusergroup.groupid AND t_secusergroup.userid = '" + strUserId + "'"
                blnAuthorized = Repo.SQLQuery(strSql).IndexOf(Group) > 0
                If blnAuthorized = False Then
                    MessageBox.Show("You are not authorized to execute this action, please contact your administrator")
                End If
            End If
            Return blnAuthorized
        End Function
        ''' <summary>
        ''' Check if an element is unique or not based on the name and stereotype
        ''' </summary>
        ''' <param name="strName">Name of the element</param>
        ''' <param name="strType">Stereotype of the element</param>
        ''' <param name="oRepo">Repository to run the query in</param>
        ''' <returns>True for unique</returns>
        'Public Shared Function CheckUniqueElement(ByVal strName As String, ByVal strType As String, ByVal oRepo As EA.Repository) As Boolean
        '    Dim sSql As String
        '    sSql = "SELECT Count(*) as aantal FROM t_object WHERE t_object.name = '#name#' And t_object.Stereotype='#stereotype#' "
        '    sSql = Replace(sSql, "#name#", strName.Replace("'", "''"))
        '    sSql = Replace(sSql, "#stereotype#", strType)

        '    Dim strVal As String
        '    strVal = oRepo.SQLQuery(sSql)
        '    Return strVal.Contains("<aantal>0</aantal>")
        'End Function

        ''' <summary>
        ''' Transform a statement to a dataset
        ''' Preferably use the sql2datatable command
        ''' </summary>
        ''' <param name="strStatement"></param>
        ''' <param name="objRepo"></param>
        ''' <returns></returns>
        Public Shared Function SQL2DataSet(ByVal strStatement As String, ByVal objRepo As EA.Repository) As System.Data.DataSet
            Dim strVal As String
            If objRepo.RepositoryType = "JET" Then
                strStatement = strStatement.Replace("+", "&")
                strStatement = strStatement.Replace("%", "*")
            End If
            DLA2EAHelper.DebugAssertion(strStatement)
            strVal = objRepo.SQLQuery(strStatement)
            Return EAString2DataSet(strVal)
        End Function
        ''' <summary>
        ''' Transform a statement and make it relevant for an eap file (is an access sql statement)
        ''' </summary>
        ''' <param name="strStatement">SQL statement to process</param>
        ''' <param name="objRepo">Repository currently active</param>
        ''' <returns></returns>
        Public Shared Function SQLForEAP(ByVal strStatement As String, ByVal objRepo As EA.Repository) As String
            If objRepo.RepositoryType().ToUpper() = "JET" Then
                strStatement = strStatement.Replace("+", "&")
                strStatement = strStatement.Replace("%", "*")
            End If
            Return strStatement
        End Function
        ''' <summary>
        ''' Transform a Sparx dataset string to a usable dataset in VB
        ''' </summary>
        ''' <param name="strVal"></param>
        ''' <returns></returns>
        Public Shared Function EAString2DataSet(ByVal strVal As String) As System.Data.DataSet
            Dim oDataset As New System.Data.DataSet()
            Try
                If strVal.IndexOf("Dataset_0") > 0 Then
                    strVal = strVal.Replace("<EADATA version=""1.0"" exporter=""Enterprise Architect"">", "")
                    strVal = strVal.Replace("</EADATA>", "")
                    oDataset.ReadXml(New StringReader(strVal))
                Else
                    oDataset.Tables.Add(New DataTable())
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return oDataset
        End Function
        ''' <summary>
        ''' Transform an sql resultset string to a datatable
        ''' </summary>
        ''' <param name="strVal">XML string resultset from the sql statement transformed to a datatable</param>
        ''' <returns>Datatable filled with datarows</returns>
        Public Shared Function EAString2DataTable(ByVal strVal As String) As DataTable
            Dim oDataset As New System.Data.DataSet()
            Try
                oDataset = DLA2EAHelper.EAString2DataSet(strVal)
                If oDataset.Tables.Count >= 2 Then
                    Return oDataset.Tables(1)
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return New DataTable("ERROR")
        End Function
        ''' <summary>
        ''' Read a csv file and transform it to a datatable
        ''' </summary>
        ''' <param name="cFile"></param>
        ''' <returns></returns>
        Public Shared Function ReadCsvFile(cFile As String) As DataTable
            Dim dtCsv As DataTable = New DataTable()
            Dim Fulltext As String
            Try
                Using sr As StreamReader = New StreamReader(cFile)
                    While Not sr.EndOfStream
                        Fulltext = sr.ReadToEnd().ToString()
                        Dim rows As String() = Fulltext.Split(vbLf)

                        For i As Integer = 0 To rows.Count() - 1 - 1
                            Dim rowValues As String() = rows(i).Split(","c)
                            If True Then
                                If i = 0 Then
                                    For j As Integer = 0 To rowValues.Count() - 1
                                        dtCsv.Columns.Add(rowValues(j))
                                    Next
                                Else
                                    Dim dr As DataRow = dtCsv.NewRow()
                                    For k As Integer = 0 To rowValues.Count() - 1
                                        dr(k) = rowValues(k).ToString()
                                    Next
                                    dtCsv.Rows.Add(dr)
                                End If
                            End If
                        Next
                    End While
                End Using
                Return dtCsv
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return Nothing
        End Function
    End Class
End Namespace
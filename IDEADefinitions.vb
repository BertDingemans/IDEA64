Imports System.IO
Imports IDEA.DLAFormfactory
Imports System.Threading

''' <summary>
''' Class for processing definitions, such as connections, queries, etc.
''' Is done based on a Dataset that is stored via XML in the config file
''' </summary>
Public Class IDEADefinitions
    Public IDEADefinitions As New DataSet("IDEADefinitions")
    '("SELECT object_id FROM t_object WHERE object_type = 'Artifact' AND name = 'IDEAConfig' AND [version] >= '{0}' "
    Protected Repository As EA.Repository = DLA2EAHelper.GetRepository()
    Sub New()
        Me.LoadTableDefinitions()
        Me.LoadFromSettings(DLA2EAHelper.GetRepository())
        Me.LoadDefaultSettings()
    End Sub
    ''' <summary>
    ''' Check for version number when the version nummber in the settings is higher you can not use the AddOn
    ''' </summary>
    ''' <returns></returns>
    Function CheckVersion() As Boolean
        'Return Me.GetSettingValue("IDEAVERSION") <= My.Application.Info.Version.ToString().Substring(0, 3)
        Return True
    End Function
    ''' <summary>
    ''' Loading the metamodel of the definitions in the form of a dataset with datatables
    ''' </summary>
    Sub LoadTableDefinitions()
        Try
            Dim objSettings As DataTable
            objSettings = New DataTable("Settings")
            objSettings.Columns.Add(New DataColumn("Name", System.Type.GetType("System.String")))
            objSettings.Columns.Add(New DataColumn("Type", System.Type.GetType("System.String")))
            objSettings.Columns.Add(New DataColumn("Value", System.Type.GetType("System.String")))
            objSettings.Columns.Add(New DataColumn("Documentation", System.Type.GetType("System.String")))
            Me.IDEADefinitions.Tables.Add(objSettings)

            Dim objSQL As DataTable
            objSQL = New DataTable("SQL-Statement")
            objSQL.Columns.Add(New DataColumn("Name", System.Type.GetType("System.String")))
            objSQL.Columns.Add(New DataColumn("Type", System.Type.GetType("System.String")))
            objSQL.Columns.Add(New DataColumn("Statement", System.Type.GetType("System.String")))
            objSQL.Columns.Add(New DataColumn("Template", System.Type.GetType("System.String")))
            objSQL.Columns.Add(New DataColumn("Documentation", System.Type.GetType("System.String")))
            Me.IDEADefinitions.Tables.Add(objSQL)


            Dim objTranslations As DataTable
            objTranslations = New DataTable("Translations")
            objTranslations.Columns.Add(New DataColumn("FormName", System.Type.GetType("System.String")))
            objTranslations.Columns.Add(New DataColumn("ControlName", System.Type.GetType("System.String")))
            objTranslations.Columns.Add(New DataColumn("Translation", System.Type.GetType("System.String")))
            objTranslations.Columns.Add(New DataColumn("Documentation", System.Type.GetType("System.String")))
            Me.IDEADefinitions.Tables.Add(objTranslations)

            Dim objArchiMaid As DataTable
            objArchiMaid = New DataTable("ArchiMaid")
            objArchiMaid.Columns.Add(New DataColumn("StereoType", System.Type.GetType("System.String")))
            objArchiMaid.Columns.Add(New DataColumn("Layer", System.Type.GetType("System.String")))
            objArchiMaid.Columns.Add(New DataColumn("Column", System.Type.GetType("System.String")))
            objArchiMaid.Columns.Add(New DataColumn("Package_guid", System.Type.GetType("System.String")))
            objArchiMaid.Columns.Add(New DataColumn("Active", System.Type.GetType("System.Boolean")))
            objArchiMaid.Columns.Add(New DataColumn("LanguageType", System.Type.GetType("System.String")))
            objArchiMaid.Columns.Add(New DataColumn("Documentation", System.Type.GetType("System.String")))

            Me.IDEADefinitions.Tables.Add(objArchiMaid)
            Dim objDataAnalyser As DataTable
            objDataAnalyser = New DataTable("DataAnalyser")
            Dim objTitle As DataColumn = New DataColumn("GraphTitle", System.Type.GetType("System.String"))
            objTitle.AllowDBNull = False
            objTitle.Unique = True
            objDataAnalyser.Columns.Add(objTitle)
            objDataAnalyser.Columns.Add(New DataColumn("GraphType", System.Type.GetType("System.String")))
            objDataAnalyser.Columns.Add(New DataColumn("GraphStatement", System.Type.GetType("System.String")))
            Dim objTotal As DataColumn = New DataColumn("GraphTotal", System.Type.GetType("System.String"))
            objTotal.DefaultValue = "Total"
            objTotal.AllowDBNull = False
            objDataAnalyser.Columns.Add(objTotal)
            Dim objGrouping As DataColumn = New DataColumn("GraphGrouping", System.Type.GetType("System.String"))
            objGrouping.DefaultValue = "Grouping"
            objGrouping.AllowDBNull = False
            objDataAnalyser.Columns.Add(objGrouping)
            Dim objCat As DataColumn = New DataColumn("GraphCategory", System.Type.GetType("System.String"))
            objCat.DefaultValue = "Total"
            objCat.AllowDBNull = False
            objDataAnalyser.Columns.Add(objCat)
            objDataAnalyser.Columns.Add(New DataColumn("Graph3D", System.Type.GetType("System.Boolean")))
            objDataAnalyser.Columns.Add(New DataColumn("Chapter", System.Type.GetType("System.String")))
            objDataAnalyser.Columns.Add(New DataColumn("Description", System.Type.GetType("System.String")))

            Me.IDEADefinitions.Tables.Add(objDataAnalyser)
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Save the definitions to the users setting or to an artifact (IDEAConfig) in the current repository
    ''' </summary>
    ''' <param name="Settings"></param>
    ''' <param name="statements"></param>
    ''' <returns></returns>
    Public Function SaveSettings() As Boolean
        Try
            Dim streamsettings As New StringWriter()
            Me.IDEADefinitions.WriteXml(streamsettings, True)

            Select Case My.Settings.SettingsMode
                Case "File"
                    Me.IDEADefinitions.WriteXml(My.Settings.SettingsFile)
                Case "User"
                    My.Settings.SettingsTable = streamsettings.ToString()
                    My.Settings.Save()
                Case "Repo"
                    Dim oDT As DataTable
                    oDT = DLA2EAHelper.SQL2DataTable("SELECT [TABLE_NAME] FROM [INFORMATION_SCHEMA].[TABLES] WHERE [TABLE_NAME] = 'IDEAConfig'", DLA2EAHelper.GetRepository())
                    If oDT.Rows.Count = 0 Then
                        DLA2EAHelper.GetRepository().Execute("CREATE TABLE IDEAConfig (Config varchar(max) NOT NULL, lastdate Date Default GetDate() NULL) ")
                    End If
                    DLA2EAHelper.GetRepository().Execute("DELETE FROM IDEAConfig ")
                    Dim strInsert As String = String.Format("INSERT INTO IDEAConfig (config) VALUES ('{0}') ", streamsettings.ToString().Replace("'", "''"))
                    DLA2EAHelper.GetRepository().Execute(strInsert)
            End Select
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Function

    ''' <summary>
    ''' Save the translations datatable to either a setting or to a tagged value of the ideaconfig artifact
    ''' </summary>
    ''' <returns></returns>
    Public Function SaveTranslations() As Boolean
        Dim streamtranslations As New StringWriter()
        Try
            If Not "NONE ".Contains(Me.GetSettingValue("Translations").ToUpper()) Then
                If My.Settings.SettingsMode = "User" Then
                    Me.IDEADefinitions.WriteXml(streamtranslations, True)
                    My.Settings.SettingsTable = streamtranslations.ToString()
                    My.Settings.Save()
                Else
                    Me.IDEADefinitions.WriteXml(My.Settings.SettingsFile)
                End If
            End If
            Return True
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
        Return False
    End Function
    ''' <summary>
    ''' Sava dataanalyzer definition to the IDEA datadefinitions
    ''' </summary>
    ''' <returns>Success or not</returns>
    Public Function SaveDataAnalyser() As Boolean
        Dim oDT As DataTable
        Dim oElement As EA.Element
        Dim streamdataanalysers As New StringWriter()
        Dim odataanalysers = Me.IDEADefinitions.Tables("DataAnalyser")
        Dim Repository As EA.Repository
        Try
            'Repository = DLA2EAHelper.GetRepository()
            'odataanalysers.WriteXml(streamdataanalysers, True)
            'oDT = DLA2EAHelper.SQL2DataTable(Me.ConfigSQL, Repository)
            'If oDT.Rows.Count > 0 Then
            '    Dim oDR As DataRow
            '    oDR = oDT.Rows(0)
            '    oElement = Repository.GetElementByID(oDR("object_id"))
            '    Dim objDS As New DataSet2Repository()
            '    objDS.AddOrUpdateTaggedValue(oElement, "DataAnalyser", streamdataanalysers.ToString(), True)
            '    oElement.Update()
            'Else
            '    My.Settings.DataAnalyser = streamdataanalysers.ToString()
            '    My.Settings.Save()
            'End If
            Return True
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Function
    ''' <summary>
    ''' Load from settings this can be an IDEASettings artifact in the repository or via the user settings
    ''' </summary>
    Sub LoadFromSettings(Repository As EA.Repository)
        Dim oDT As DataTable
        Try
            If Not IO.Directory.Exists("c:\idea") Then
                System.IO.Directory.CreateDirectory("c:\idea")
            End If
            System.IO.Directory.CreateDirectory("c:\idea\publ")
            Select Case My.Settings.SettingsMode
                Case "File"
                    If IO.File.Exists(My.Settings.SettingsFile) Then
                        Me.IDEADefinitions.ReadXml(My.Settings.SettingsFile)
                    End If
                Case "User"
                    LoadDataSetXML(My.Settings.SettingsTable, "")
                Case "Repo"
                    oDT = DLA2EAHelper.SQL2DataTable("SELECT Config FROM IDEAConfig", DLA2EAHelper.GetRepository())
                    If oDT.Rows.Count = 1 Then
                        Dim strConfig As String = oDT.Rows(0)("Config").ToString()
                        LoadDataSetXML(strConfig, "")
                    End If
            End Select
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Loading the dataset with definitions from the configuration file f from the fill of the result tab.
    ''' If no material is found, a few sample items will be made
    ''' </summary>
    ''' <param name="xmlstring">Dataset definities uit de config file</param>
    ''' <param name="importstring">Dataset afkomstig vanuit het result scherm</param>
    Sub LoadDataSetXML(xmlstring As String, importstring As String)
        Try
            If xmlstring.Length > 0 Or importstring.Length > 0 Then
                Dim oSR As New StringReader(IIf(importstring.Length > 10, importstring, xmlstring))
                Me.IDEADefinitions.ReadXml(oSR, XmlReadMode.IgnoreSchema)
            End If
        Catch ex As Exception
            Me.Repository.session.output(ex.ToString())
        End Try

    End Sub
    Sub LoadDefaultSettings()
        Try
            If Me.IDEADefinitions.Tables("Settings").Rows.Count = 0 Then
                Me.AddInitialSetting("PDFPackageTemplate", "Diagram Report", "HTML", "Template report for packages in the reporting module of IDEA")
                Me.AddInitialSetting("PDFDiagramTemplate", "Diagram Report", "HTML", "Template report for diagrams in the reporting module of IDEA")
                Me.AddInitialSetting("AuthorizationGroup", "Administrators", "CONFIG", "Name of the authorization group for starting duplication in IDEA")
                Me.AddInitialSetting("PDFElementTemplate", "Element Report", "HTML", "Template report for elements in the reporting module of IDEA")
                Me.AddInitialSetting("LogFile", "c:\idea\error.log", "FILES", "Logfile to write all the error and warning messages to")
                Me.AddInitialSetting("ReleaseDirectory", "c:\idea\publ", "FILES", "Directory where all the publications like the helpers and the simple query screen are writing to")
                Me.AddInitialSetting("HTMLPath", "c:\idea\publ", "HTML", "Path for the HTML reporter, all html files will be created there")
                'path for the WPP diagram name for direct export when saving ther diagram
                Me.AddInitialSetting("WPP_Diagram_File", "?", "HTML", "When closing a diagram this is the path where a diagram png file is exported to, used in combination with the WPP")
                Me.AddInitialSetting("HTMLTemplate", "c:\idea\templates\basis_template.html", "HTML", "Basic template for the HTML reporter module")
                Me.AddInitialSetting("TemplateReplaceValue", "DEFAULT", "AID", "Replace value for the ArchiMAID and DatAid screens")
                Me.AddInitialSetting("Translations", "NONE", "CONFIG", "Use NONE, READ, WRITE or BOTH for translating the IDEA screens")

                Me.AddInitialSetting("ExcelConnection", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=[FILE];Extended Properties=""Excel 12.0 Xml;HDR=YES"";", "EXCEL", "Oledb driver for opening Excel files in the assistent of IDEA. Please note that the driver must be installed first")
                'Currently not in use relevant for the IDEA reporting helper
                '           Me.AddInitialSetting("ElementPackageSQL", "SELECT * FROM t_object where package_id = #package_id# ORDER BY name", "RTF")
                '           Me.AddInitialSetting("DiagramPackageSQL", "SELECT * FROM t_diagram where package_id = #package_id# ORDER BY name", "RTF")
                '           Me.AddInitialSetting("ElementDiagramSQL", "SELECT * FROM t_diagramobjects where diagram_id = #diagram_id# ORDER BY RectTop, RectLeft", "RTF")
                Me.AddInitialSetting("ConnectionString", "Provider=SQLOLEDB;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DLAdministratie2018;Data Source=DESKTOP-HNMVP79;Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=DESKTOP-HNMVP79;Use Encryption for Data=False;Tag with column collation when possible=False;", "FORMFACTORY", "Connection string for the database link to the form factory repository")
                Me.AddInitialSetting("DeduplicateElementsPackage", "Select orig.name, 
                orig.stereotype, 
                orig.author, 
                orig.version, 
                dupl.name as duplicate_name, 
                t_package.name as package_name, 
                dupl.author as duplicate_author, 
                orig.object_id as origid, 
                dupl.object_id as duplid 
                From t_object orig, t_package, t_object dupl 
                where dupl.package_id = t_package.package_id 
                and orig.name = dupl.name 
                and orig.object_id <> dupl.object_id 
                and (orig.stereotype = dupl.stereotype 
                or (orig.stereotype IS NULL AND dupl.stereotype IS NULL)) 
                and orig.object_type = dupl.object_type 
                and orig.object_type NOT IN('Package', 'Diagram', 'Note', 'Text', 'ProxyConnector') 
                and orig.name IS NOT NULL and orig.name <> '' 
                and orig.version = dupl.version 
                and orig.package_id IN(#package_id#) order by 1 ",
                    "DEDUPL", "SQL statement for deduplication elements in a defined package")
                Me.AddInitialSetting("DeduplicateElementElement",
                    "Select dupl.name as duplicate_name, 
                t_package.name as package_name, 
                dupl.author as duplicate_author, 
                orig.object_id as origid, 
                dupl.object_id as duplid 
                From t_object orig, t_package, t_object dupl 
                where dupl.package_id = t_package.package_id 
                and orig.name = dupl.name 
                and orig.object_id <> dupl.object_id 
                and orig.stereotype = dupl.stereotype 
                and orig.version = dupl.version 
                and orig.object_id = #object_id#
                union
                Select dupl.name as duplicate_name, 
                t_package.name as package_name, 
                dupl.author as duplicate_author, 
                orig.object_id as origid, 
                dupl.object_id as duplid 
                From t_object orig, t_package, t_object dupl 
                where dupl.package_id = t_package.package_id 
                and orig.name = dupl.name 
                and orig.object_id <> dupl.object_id 
		        and orig.object_type = dupl.object_type
                and orig.stereotype IS NULL 
                and dupl.stereotype IS NULL
                and orig.version = dupl.version 
                and orig.object_id = #object_id#
                order by 1 ",
                    "DEDUPL",
                    "Deduplication of a single element used in the element deduplicator screens")
                Me.AddInitialSetting("DeduplicateConnectorsPackage",
                    "Select distinct startobj.name As object_name, 
                orig.name, 
                orig.connector_type, 
                dupl.name As dupl_name, 
                destobj.name as dupl_object_name, 
                destobj.author as dupl_author, 
                dupl.direction, 
                orig.connector_id as origid, 
                dupl.connector_id as duplid 
                From t_connector orig, t_connector dupl, t_object startobj, t_object destobj 
                Where ((orig.name = dupl.name) 
                Or (orig.name Is null And dupl.name Is null)) 
                And orig.connector_type = dupl.connector_type 
                And orig.end_object_id = dupl.end_object_id 
                And orig.start_object_id = dupl.start_object_id 
                And orig.start_object_id = startobj.Object_ID 
                And orig.end_object_ID = destobj.object_id 
                And Orig.direction = dupl.direction 
                And (orig.styleex IS NULL 
                OR orig.styleex not like '%LFSP=%') 
                And (orig.stereotype = dupl.stereotype 
                Or orig.stereotype Is NULL) 
                And orig.Connector_ID <> dupl.connector_id 
                And startobj.package_id IN(#package_id#) ",
                    "DEDUPL",
                    "SQL statement for deduplicating connectors based on a package, it makes use a tree 2 list of package ids so it is recursive. It displays a list of associations that exist multiple times in the repository")
                Me.AddInitialSetting("DeduplicateConnectorsDiagram",
                    "Select orig.name, 
                orig.stereotype, 
                orig.author, 
                orig.version, 
                dupl.name as duplicate_name, 
                t_package.name as package_name, 
                dupl.author as duplicate_author, 
                orig.object_id as origid, 
                dupl.object_id as duplid 
                From t_object orig, t_package, t_object dupl, t_diagramobjects
                where dupl.package_id = t_package.package_id 
                and orig.name = dupl.name 
                and orig.object_id <> dupl.object_id 
                and (orig.stereotype = dupl.stereotype or (orig.stereotype IS NULL AND dupl.stereotype IS NULL)) 
                and orig.object_type = dupl.object_type 
                and orig.object_type NOT IN('Package', 'Diagram', 'Note', 'Text', 'ProxyConnector', 'Grouping', 'Boundary') 
                and orig.name IS NOT NULL and orig.name <> '' 
                and orig.version = dupl.version 
                and orig.object_id = t_diagramobjects.object_id
                and t_diagramobjects.Diagram_ID = #diagram_id# 
                order by 1  ",
                    "DEDUPL",
                    "SQL statement for deduplicating connectors based on a diagram. It displays a list of associations that exist multiple times in the repository")
                Me.AddInitialSetting("DeduplicateElementsDiagram",
                    "Select orig.name, 
                orig.stereotype, 
                orig.author, 
                orig.version, 
                dupl.name as duplicate_name, 
                t_package.name as package_name, 
                dupl.author as duplicate_author, 
                orig.object_id as origid, dupl.object_id as duplid 
                From t_object orig, t_package, t_object dupl, t_diagramobjects 
                where dupl.package_id = t_package.package_id 
                and orig.name = dupl.name and orig.object_id <> dupl.object_id 
                and (orig.stereotype = dupl.stereotype or (orig.stereotype IS NULL AND dupl.stereotype IS NULL)) 
                and orig.object_type = dupl.object_type and orig.object_type NOT IN('Package', 'Diagram', 'Note', 'Text', 'ProxyConnector') 
                and orig.name IS NOT NULL and orig.name <> '' 
                and orig.version = dupl.version 
                and orig.object_id = t_diagramobjects.object_id
                and t_diagramobjects.diagram_id IN(#diagram_id#) order by 1 ",
                    "DEDUPL",
                    "SQL statement for deduplicating elements based on a diagram. It displays a list of associations that exist multiple times in the repository")
                Me.AddInitialSetting("WasteBinPackage_id", "-999", "WASTEBIN", "ID (not the guid of a wastebin package. Prevents from deleting elements in the repository but move it to a wastebin package before final delete")
                Me.AddInitialSetting("IDEAVersion", My.Application.Info.Version.ToString().Substring(0, 3), "VERSION", "Add Version number to IDEA so users with a lower version are not able to use the add on any more")
                Me.AddInitialSetting("TaggedValuePrefix", "_IDEA", "CONFIG", "When an element is created it first creates all the tagged values based on the prefix. This helps to create tagged values that can be edited later")
                Me.AddInitialSetting("ArchiMateRegisterPackageSQL",
                                     "SELECT package_id as package_guid, name FROM t_package ORDER BY name", "AID",
                                    "Load a listbox of packages for the register setup for the package helper")
                'Wizard elementen
                Me.AddInitialSetting("WizardTemplateSQL",
                                     "select child.package_id, child.name
                                from t_package parent, t_package child, t_object, t_diagramobjects
                                where parent.ea_guid = '{C44D8B99-E93D-480b-9DC1-D3846F9CEBDF}'
                                and child.parent_id = parent.package_id
                                and t_object.pdata1 like '%' + cast(child.package_id as varchar) + '%'
                                and t_diagramobjects.object_id = t_object.object_id
                                and t_diagramobjects.Diagram_ID = {0}
                                order by child.name", "WIZARD",
                                    "Retrieve all the template package ids and names relevant for in the template combobox in the wizard")
                Me.AddInitialSetting("WizardDiagramListSQL",
                                     "select t_diagram.diagram_id, t_diagram.name
                                from t_diagram 
                                inner join t_package on t_package.package_id = t_diagram.package_id
                                where t_package.ea_guid = '{C44D8B99-E93D-480b-9DC1-D3846F9CEBDF}' 
                                and t_diagram.name like '%Template%'
                                and t_diagram.name not like '%Navigat%'
                                order by t_diagram.name", "WIZARD",
                                    "Retrieve the list of template diagrams, there is a little trick in the statement with a union for a select diagram dialog items to force the user to select a diagram")

                Me.AddInitialSetting("WizardWorkPackageSQL",
                                     "select child.package_id, child.name
                                 from t_package parent 
                                 inner join t_package child on child.parent_id = parent.package_id
                                 where parent.name = 'Persoonlijke mappen'
                                 order by child.name", "WIZARD",
                                    "Retrieve a list of workpackages where the newly generated solution is created")

                Me.AddInitialSetting("WizardDiagramObjectsSQL",
                                     "UPDATE t_diagramobjects 
                                SET t_diagramobjects.object_id = WorkObject.Object_id 
                                FROM t_diagramobjects INNER JOIN  t_object TemplateObject ON  t_diagramobjects.Object_ID = TemplateObject.Object_ID
                                INNER JOIN t_object WorkObject ON TemplateObject.Name = WorkObject.Name
                                INNER JOIN t_diagram ON   t_diagramobjects.diagram_id = t_diagram.diagram_id
                                WHERE t_diagram.package_id = {1}
                                AND TemplateObject.Package_ID = {0}
                                AND WorkObject.Package_ID = {1} ", "WIZARD",
                                    "Update the relevant elements in the project package with the name entered in the wizard")

                Me.AddInitialSetting("WizardUnusedPatternsSQL",
                                     "DELETE FROM t_diagramobjects 
                                    WHERE object_id IN({0}) AND diagram_id = {1}", "WIZARD",
                                     "Delete the unused patterns from the newly created package based on the selected pattern in the dialog screen")

                Me.AddInitialSetting("WizardPreceedingModulesSQL",
                                        "SELECT DISTINCT PreceedingModule.Name as PreceedingModuleName, 
                                    PreceedingModule.Note as PreceedingModuleDescription, 
                                    PreceedingModule.Author as PreceedingModuleAuthor, 
                                    PreceedingModule.status, PreceedingParent.Name as PreceedingParentName,
                                    ParentEntity.Name as ParentName,
                                    ActiveEntity.Name as ActiveEntityName,
                                    PreceedingModule.Object_id
                                    FROM t_object as ActiveEntity
                                    , t_object as ParentEntity
                                    , t_object as PreceedingParent
                                    , t_object as PreceedingModule
                                    , t_connector as Active_Parent
                                    , t_connector as Parent_PreceedingParent
                                    , t_connector as PreceedingParent_PreceedingModule
                                    WHERE ActiveEntity.object_id IN({0})
                                    AND ActiveEntity.object_id = Active_Parent.Start_Object_ID
                                    AND ParentEntity.object_id = Active_Parent.End_Object_ID
                                    AND Active_Parent.Stereotype = 'ArchiMate_Specialization'
                                    AND ParentEntity.Name LIKE '%#DIA%'
                                    AND ParentEntity.object_id = Parent_PreceedingParent.End_Object_ID
                                    AND PreceedingParent.object_id = Parent_PreceedingParent.Start_Object_ID
                                    AND PreceedingParent.Stereotype = 'ArchiMate_ApplicationService'
                                    AND (PreceedingParent.Name LIKE '%#DIA%' OR PreceedingParent.Name LIKE '%#NS%')
                                    AND Parent_PreceedingParent.Stereotype = 'ArchiMate_Triggering'
                                    AND PreceedingParent_PreceedingModule.Stereotype = 'ArchiMate_Specialization'
                                    AND PreceedingParent.object_id =PreceedingParent_PreceedingModule.End_Object_ID
                                    AND PreceedingModule.object_id = PreceedingParent_PreceedingModule.Start_Object_ID
                                    AND PreceedingModule.Stereotype = 'ArchiMate_ApplicationService'
                                    AND PreceedingModule.Name LIKE '%#Module%' 
                                    AND PreceedingParent.object_id IN(SELECT object_id FROM t_diagramobjects WHERE diagram_id = #diagram_id#)
                                    AND PreceedingModule.status IN('Referentie architectuur', 'Solution architectuur', '#werkmap#')", "WIZARD",
                                        "Retrieve the relevant patterns in the previous module, based on the sequence diagram. Please note the little trick with the #werkmap# ")

                Me.AddInitialSetting("WizardPatternsSQL",
                                    "SELECT DISTINCT Pattern.Name as PatternName
                                , ParentEntity.Name as ParentName
                                , ActiveEntity.Name as ActiveEntityName
                                , Pattern.Object_id
                                FROM t_object as ActiveEntity
                                , t_object as ParentEntity
                                , t_object as Pattern
                                , t_connector as Active_Parent
                                , t_connector as Parent_Pattern
                                WHERE ActiveEntity.object_id in({0})
		                        AND ActiveEntity.object_id = Active_Parent.Start_Object_ID
                                AND ParentEntity.object_id = Active_Parent.End_Object_ID
                                AND Active_Parent.Stereotype = 'ArchiMate_Specialization'
                                AND (ParentEntity.Name LIKE '%#DIA%' OR ParentEntity.Name LIKE '%#NS%')
                                AND ParentEntity.object_id = Parent_Pattern.Start_Object_ID
                                AND Pattern.object_id = Parent_Pattern.End_Object_ID
                                AND Pattern.Stereotype = 'ArchiMate_ApplicationService'
                                AND Pattern.Name LIKE '%#Patroon%' 
                                AND Parent_Pattern.Stereotype = 'ArchiMate_Aggregation' 
                                AND Pattern.Name NOT LIKE '%#DIA%'", "WIZARD",
                                    "Get a list of relevant patterns based on the selected module in the wizard")
            End If

            'vullen van de sql statements configs
            If Me.IDEADefinitions.Tables("SQL-Statement").Rows.Count <= 1 Then
                'DMF raamwerk
                Me.AddInitialSQL("MappingColumn", "DMF",
                                       "SELECT DISTINCT t_connector.name
, t_connector.direction
, classsource.name as sourcetable
, attrsource.name AS sourcecolumn 
, classtarget.name as targettable
, attrtarget.name as targetcolumn
, t_diagram.name AS diagram_name
, targetprops.value AS tableType 
FROM t_connector
, t_diagramlinks
, t_diagram
, t_object AS classsource
,t_attribute AS attrsource
, t_object AS classtarget
, t_attribute AS attrtarget
, t_objectproperties AS targetprops
WHERE t_diagram.diagram_id = #diagram_id# 
AND t_connector.styleex LIKE '%LFSP=' + attrsource.ea_guid + '%' AND t_connector.styleex LIKE '%LFEP=' + attrtarget.ea_guid + '%' 
AND t_diagramlinks.ConnectorID = t_connector.connector_id 
AND t_diagram.Diagram_ID = t_diagramlinks.DiagramID 
AND classsource.object_id = t_connector.start_object_id 
AND attrsource.object_id = classsource.object_id 
AND classtarget.object_id = t_connector.end_object_id 
AND attrtarget.object_id = classtarget.object_id 
AND targetprops.Object_ID = classtarget.Object_ID  ",
                                       "INSERT INTO #[targettable]# (name, direction, sourcecolumn, targetcolumn 
                                       VALUES ('#[name]#', '#[direction]#', SELECT max(#[sourcecolumn]#) FROM #[sourcetable]#),'#[targetcolumn]#') ")
            End If

            If Me.IDEADefinitions.Tables("ArchiMaid").Rows.Count = 0 Then
                Me.AddInitialArchiMaid("ArchiMate_Grouping", "Common", "Other", "The Grouping element aggregates or composes concepts that belong together based on some common characteristic. The Grouping element is used to aggregate or compose an arbitrary group of concepts, which can be elements and/or relationships of the same or of different types. An Aggregation or Composition relationship is used to link the Grouping element to the grouped concepts.")
                Me.AddInitialArchiMaid("ArchiMate_Junction", "Common", "Other", "A Junction is used to connect relationships of the same type. A Junction may have multiple incoming relationships and one outgoing relationship, one incoming relationship and multiple outgoing relationships, or multiple incoming and outgoing relationships. The relationships that can be used in combination with a Junction are all the dynamic relationships, as well as Assignment, Realization, and Association. A Junction is used to explicitly express that several elements together participate in the relationship (and Junction) or that one of the elements participates in the relationship (or Junction).")
                Me.AddInitialArchiMaid("ArchiMate_Location", "Common", "Other", "A Location represents a conceptual or physical place or position where concepts are located (e.g., structure elements) or performed (e.g., behavior elements).The Location element is used to model the places where (active and passive) structure elements such as business actors, application components, and devices are located. This is modeled by means of an aggregation relationship from a location to structure element. A location can also aggregate a behavior element, to indicate where the behavior is performed.")

                Me.AddInitialArchiMaid("ArchiMate_ApplicationComponent", "Application", "Active", "An Application Component represents an encapsulation of application functionality aligned to implementation structure, which is modular and replaceable. An Application Component is a self-contained unit. As such, it is independently deployable, re-usable, and replaceable. An Application Component performs one or more Application Functions. It encapsulates its contents: its functionality is only accessible through a set of Application Interfaces. Cooperating Application Components are connected via Application Collaborations.")
                Me.AddInitialArchiMaid("ArchiMate_ApplicationCollaboration", "Application", "Active", "An Application Collaboration represents an aggregate of two or more application internal active structure elements that work together to perform collective application behavior. An Application Collaboration specifies which Application Components or other Application Collaborations cooperate to perform some task. The collaborative behavior, including, for example, the communication pattern of these components, is modeled by an Application Interaction. An Application Collaboration typically models a logical or temporary collaboration of Application Components, and does not exist as a separate entity in the enterprise.")
                Me.AddInitialArchiMaid("ArchiMate_ApplicationFunction", "Application", "Behaviour", "An Application Function represents automated behavior that can be performed by an Application Component. An Application Function describes the internal behaviour of an Application Component. If this behaviour is exposed externally, this is done through one or more services. An Application Function may realize one or more Application Services. Application Services of other Application Functions and Technology Services may serve an Application Function. An Application Function may access Data Objects. An Application Component may be assigned to an Application Function (which means that the Application Component performs the Application Function).")
                Me.AddInitialArchiMaid("ArchiMate_ApplicationInterface", "Application", "Active", "An Application Interface represents a point of access where application services are made available to a user, another application component, or a Node. An Application Interface specifies how the functionality of a Component can be accessed by other elements. An Application Interface exposes Application Services to the environment. ")
                Me.AddInitialArchiMaid("ArchiMate_ApplicationService", "Application", "Behaviour", "An Application Service represents an explicitly defined exposed application behaviour. An Application Service exposes the functionality of components to their environment. This functionality is accessed through one or more Application Interfaces. An Application Service is realized by one or more Application Functions that are performed by the component. It may require, use, and produce Data Objects. An Application Service should provide a unit of behaviour that is, in itself, useful to its users. It has a purpose, which states this utility to the environment.")
                Me.AddInitialArchiMaid("ArchiMate_ApplicationEvent", "Application", "Behaviour", "An Application Event represents an application state change. Application Functions and other application behaviour may be triggered or interrupted by an Application Event. Also, application behaviour may raise events that trigger other application behaviour. An event is instantaneous; it does not have duration. Events may originate from the environment of the organization (e.g., from an external application), but also internal events may occur generated by, for example, other applications within the organization.")
                Me.AddInitialArchiMaid("ArchiMate_ApplicationInteraction", "Application", "Behaviour", "An Application Interaction represents a unit of collective application behavior performed by (a collaboration of) two or more Application Components. An Application Interaction describes the collective behaviour that is performed by the components that participate in an Application Collaboration. An Application Interaction can also specify the externally visible behaviour needed to realize an Application Service.")
                Me.AddInitialArchiMaid("ArchiMate_DataObject", "Application", "Passive", "A Data Object represents data structured for automated processing. A Data Object should be a self-contained piece of information with a clear meaning to the business, not just to the application level. A Data Object typically models an object type of which multiple instances may exist in operational applications.")
                Me.AddInitialArchiMaid("ArchiMate_ApplicationProcess", "Application", "Behaviour", "An Application Process represents a sequence of application behaviors that achieves a specific result. An Application Process describes the internal behaviour performed by an Application Component that is required to realize a set of services. An Application Process may realize Application Services. Other Application Services may serve (be used by) an Application Process. An Application Process may access Data Objects. An Application Component may be assigned to an Application Process (which means that this component performs the process).")

                Me.AddInitialArchiMaid("ArchiMate_BusinessActor", "Business", "Active", "A Business Actor represents a business entity that is capable of performing behavior. Typically, a Business Actor performs the behaviour assigned to one or more Business Roles. It is important to separate the actor from the role because a Business Actor can perform more than one Business Role, and a Business Role can be performed by more than one Business Actor. Business Actors are humans, departments, and business units. They may be individuals or groups.")
                Me.AddInitialArchiMaid("ArchiMate_BusinessEvent", "Business", "Behaviour", "A Business Event represents an organizational state change. Business Processes and other business behaviour may be triggered or interrupted by a Business Event. Also, Business Processes may raise events that trigger other Business Processes, Functions, or Interactions. A Business Event is most commonly used to model something that triggers behaviour.")
                Me.AddInitialArchiMaid("ArchiMate_BusinessFunction", "Business", "Behaviour", "A Business Function represents a collection of business behavior based on a chosen set of criteria (typically required business resources and/or competencies), closely aligned to an organization, but not necessarily explicitly governed by the organization. Business Processes describe a flow of activities. Business Functions group activities according to their required skills, knowledge, and resources. A Business Process forms a string of Business Functions. ")
                Me.AddInitialArchiMaid("ArchiMate_BusinessInterface", "Business", "Active", "A Business Interface represents a point of access where a business service is made available to the environment. A Business Interface exposes the functionality of a business service to other business roles or actors. It is often referred to as a channel (telephone, Internet, local office, etc.). The same business service may be exposed through different interfaces. A Business Interface may be part of a business role or actor through a Composition relationship, and a Business Interface may serve a Business Role.")
                Me.AddInitialArchiMaid("ArchiMate_BusinessObject", "Business", "Passive", "A Business Object represents a concept used within a particular business domain. A Business Object is used to model an object type of which several instances may exist within the organization. In this case, it may be realised as a Data Object or Representation. It may also be specialised by another Business Object. Business Objects are passive. They do not trigger or perform processes.")
                Me.AddInitialArchiMaid("ArchiMate_BusinessProcess", "Business", "Behaviour", "A Business Process represents a sequence of business behaviors that achieves a specific result such as a defined set of products or business services. A Business Process describes the internal behaviour performed by a Business Role that is required to produce a set of products and services. For a consumer the required behaviour is not of interest so a process is designated Internal.")
                Me.AddInitialArchiMaid("ArchiMate_BusinessRole", "Business", "Active", "A Business Role represents the responsibility for performing specific behavior, to which an actor can be assigned, or the part an actor plays in a particular action or event. A Business Role can be fulfilled by more than one Business Actor. Conversely, a Business Actor may fulfil more than one Business Role. For example, given a named teacher, their roles may include those in the domains. A Business Role will usually exist in an organisation whether or not a given actor fulfils it or not.")
                Me.AddInitialArchiMaid("ArchiMate_BusinessCollaboration", "Business", "Active", "A Business Collaboration represents an aggregate of two or more business internal active structure elements that work together to perform collective behavior. Unlike a single Business Role, a Business Collaboration does not necessarily have a permanent status in an organisation. Thus it may be a temporary collaboration. It may not require a special name and can be regarded as a virtual role. A Business Collaboration can occur when two or more Business Roles need to fulfil specific interaction requirements. Business Collaborations represent the collective effort of combined Business Roles. ")
                Me.AddInitialArchiMaid("ArchiMate_BusinessInteraction", "Business", "Behaviour", "A Business Interaction represents a unit of collective business behavior performed by (a collaboration of) two or more Business Actors, Business Roles, or Business Collaborations. A Business Interaction is similar to a Business Process or Business Function, but while a process/function may be performed by a single role, an interaction is performed by multiple roles in collaboration. A Business Interaction may be triggered by, or trigger, any other business behaviour element (Business Event, Business Process, Business Function, or Business Interaction).")
                Me.AddInitialArchiMaid("ArchiMate_BusinessService", "Business", "Behaviour", "A Business Service represents explicitly defined behavior that a Business Role, Business Actor, or Business Collaboration exposes to its environment. A Business Service is defined as the externally visible (logical) functionality, which is meaningful to the environment and is realized by business behaviour (Business Process, Business Function, or Business Interaction). A Business Service exposes the functionality of Business Roles or Collaborations to their environment. This functionality is accessed through one or more business interfaces.")
                Me.AddInitialArchiMaid("ArchiMate_Representation", "Business", "Passive", "A Representation represents a perceptible form of the information carried by a Business Object. Representations (for example, messages or documents) are the perceptible carriers of information that are related to Business Objects. A single Business Object can have a number of different Representations. A Representation may realize one or more Business Objects. A Meaning can be associated with a Representation that carries this Meaning. ")
                Me.AddInitialArchiMaid("ArchiMate_Contract", "Business", "Passive", "A Contract represents a formal or informal specification of an agreement between a provider and a consumer that specifies the rights and obligations associated with a product and establishes functional and non-functional parameters for interaction. A Contract may also be or include a Service Level Agreement (SLA), describing an agreement about the functionality and quality of the services that are part of a Product. A Contract is a specialization of a Business Object. ")


                Me.AddInitialArchiMaid("ArchiMate_Deliverable", "Implementation", "Other", "A Deliverable represents a precisely-defined outcome of a Work Package. Work Packages produce Deliverables. These may be results of any kind; e.g., reports, papers, services, software, physical products, etc., or intangible results such as organizational change. A Deliverable may also be the implementation of (a part of) an architecture.")
                Me.AddInitialArchiMaid("ArchiMate_Gap", "Implementation", "Other", "A Gap represents a statement of difference between two Plateaus. The Gap element is associated with two Plateaus (e.g., Baseline and Target Architectures, or two subsequent Transition Architectures), and represents the differences between these Plateaus.")
                Me.AddInitialArchiMaid("ArchiMate_Plateau", "Implementation", "Other", "A Plateau represents a relatively stable state of the architecture that exists during a limited period of time.")
                Me.AddInitialArchiMaid("ArchiMate_WorkPackage", "Implementation", "Active", "A Work Package represents a series of actions identified and designed to achieve specific results within specified time and resource constraints. The central behavioural element is a Work Package. A Work Package is a behaviour element that has a clearly defined start and end date, and realizes a well-defined set of Goals or Deliverables. The Work Package element can be used to model sub-projects or tasks within a project, complete projects, programs, or project portfolios.")

                Me.AddInitialArchiMaid("ArchiMate_Product", "Business", "Passive", "A Product represents a coherent collection of services and/or passive structure elements, accompanied by a contract/set of agreements, which is offered as a whole to (internal or external) customers. A Product consists of a collection of Services, and a Contract that specifies the characteristics, rights, and requirements associated with the Product. A Product may aggregate Business Services or Application Services, as well as a Contract. ")
                Me.AddInitialArchiMaid("ArchiMate_Requirement", "Motivation", "Other", "A Requirement represents a statement of need defining a property that applies to a specific system as described by the architecture.  Requirements model the properties of these elements that are needed to achieve the ends that are modelled by the goals. In this respect, requirements represent the means to realize goals. ")
                Me.AddInitialArchiMaid("ArchiMate_Stakeholder", "Motivation", "Active", "A Stakeholder represents the role of an individual, team, or organization (or classes thereof) that represents their interests in the effects of the architecture. A Stakeholder has one or more interests in, or concerns about, the organization and its enterprise architecture. In order to direct efforts to these interests and concerns, stakeholders change, set, and emphasize goals.")
                Me.AddInitialArchiMaid("ArchiMate_Assessment", "Motivation", "Other", "An Assessment represents the result of an analysis of the state of affairs of the enterprise with respect to some driver. An Assessment may reveal strengths, weaknesses, opportunities, or threats for some area of interest. These outcomes need to be addressed by adjusting existing goals or setting new ones, which may trigger changes to the enterprise architecture.")
                Me.AddInitialArchiMaid("ArchiMate_Constraint", "Motivation", "Other", "A Constraint represents a factor that limits the realization of goals. In contrast to a requirement, a constraint does not prescribe some intended functionality of the system to be realized but imposes a restriction on the way it operates or may be realized. This may be a restriction on the implementation of the system (e.g., specific technology that is to be used), or a restriction on the implementation process (e.g., time or budget constraints).")
                Me.AddInitialArchiMaid("ArchiMate_Outcome", "Motivation", "Other", "An Outcome represents an end result. Outcomes are high-level, business-oriented results produced by capabilities of an organization Outcomes are closely related to requirements, goals, and other intentions. Outcomes are the end results, and goals or requirements are often formulated in terms of outcomes that should be realized. Capabilities are designed to achieve such outcomes.")
                Me.AddInitialArchiMaid("ArchiMate_Principle", "Motivation", "Other", "A Principle represents a statement of intent defining a general property that applies to any system in a certain context in the architecture. Principles define intended properties of systems. A Principle defines a general property that applies to any system in a certain context. A Principle is motivated by some goal or driver. Organizational values, best practices, and design knowledge may be reflected and made applicable in terms of principles.")
                Me.AddInitialArchiMaid("ArchiMate_Goal", "Motivation", "Other", "A Goal represents a high-level statement of intent, direction, or desired end state for an organization and its stakeholders. An end can represent anything a stakeholder may desire, such as a state of affairs, or a produced value. Goals are typically used to measure success of an organization.")
                Me.AddInitialArchiMaid("ArchiMate_Driver", "Motivation", "Other", "A Driver represents an external or internal condition that motivates an organization to define its goals and implement the changes necessary to achieve them. Drivers may be internal, in which case they are usually associated with a Stakeholder. They may also be external, e.g., economic changes or changing legislation.")
                Me.AddInitialArchiMaid("ArchiMate_Resource", "Strategy", "Active", "A Resource represents an asset owned or controlled by an individual or organization. Resources are a central concept in the field of strategic management, economics, computer science, portfolio management, and more. They are often considered, together with capabilities, to be sources of competitive advantage for organizations.")
                Me.AddInitialArchiMaid("ArchiMate_Capability", "Strategy", "Behaviour", "A Capability represents an ability that an active structure element, such as an organization, person, or system, possesses. A Capability focuses on business outcomes. It provides a high-level view of the current and desired abilities of an organization, in relation to its strategy and its environment. They are realized by various elements (people, processes, systems). Capabilities may also have serving relationships; for example, to denote that one capability contributes to another. ")
                Me.AddInitialArchiMaid("ArchiMate_CourseOfAction", "Strategy", "Behaviour", "A Course of Action is an approach or plan for configuring some capabilities and resources of the enterprise, undertaken to achieve a goal. A Course of Action represents what an enterprise has decided to do. Courses of action can be categorized as strategies (long-term) and tactics (short-term).")
                Me.AddInitialArchiMaid("ArchiMate_ValueStream", "Strategy", "Behaviour", "A Value Stream represents a sequence of activities that create an overall result for a customer, stakeholder, or end user. A value stream describes how an enterprise organizes its activities to create value. Value streams are typically realized by business processes and possibly other core behavior elements.")
                Me.AddInitialArchiMaid("ArchiMate_Meaning", "Motivation", "Other", "Meaning represents the knowledge or expertise present in, or the interpretation given to, a concept in a particular context. A Meaning represents the interpretation of an element of the architecture. It is a description that expresses the intent of that element; i.e., how it informs the external user. A Meaning can be associated with any core element. To denote that a Meaning is specific to a particular Stakeholder, this Stakeholder can also be associated to the Meaning.")
                Me.AddInitialArchiMaid("ArchiMate_Value", "Motivation", "Other", "Value represents the relative worth, utility, or importance of a concept. Value may apply to what a party gets by selling or making available some product or service, or it may apply to what a party gets by buying or obtaining access to it. Value may be expressed in terms of money, but non-monetary value is also essential to business - for example, practical/functional value (including the right to use a service), and the value of information or knowledge. Though Value can hold internally for some system or organisational unit, it is most typically applied to external appreciation of goods, services, information, knowledge, or money, normally as part of some sort of customer-provider relationship.")


                Me.AddInitialArchiMaid("ArchiMate_SystemSoftware", "Technology", "Active", "System Software represents software that provides or contributes to an environment for storing, executing, and using software or data deployed within it. System Software is a specialization of a Node that is used to model the software environment in which Artifacts run. Usually, System Software is combined with a Device representing the hardware environment to form a general Node.")
                Me.AddInitialArchiMaid("ArchiMate_TechnologyEvent", "Technology", "Behaviour", "A Technology Event represents a technology state change. Technology Functions and other technology behaviour may be triggered or interrupted by a Technology Event. Also, Technology Functions may raise events that trigger other infrastructure behaviour. An event is instantaneous: it does not have duration. Events may originate from the environment of the organization, but also internal events may occur generated by, for example, other devices within the organization.")
                Me.AddInitialArchiMaid("ArchiMate_TechnologyProcess", "Technology", "Behaviour", "A Technology Process represents a sequence of technology behaviours that achieves a specific result. A Technology Process describes internal behaviour of a Node. If its behaviour is exposed externally, this is done through one or more Technology Services. A Technology Process abstracts from the way it is implemented.")
                Me.AddInitialArchiMaid("ArchiMate_TechnologyFunction", "Technology", "Behaviour", "A Technology Function represents a collection of technology behaviour that can be performed by a Node. A Technology Function describes the internal behaviour of a Node; for the user of a Node that performs a Technology Function, this function is invisible. If its behaviour is exposed externally, this is done through one or more Technology Services. A Technology Function abstracts from the way it is implemented.")
                Me.AddInitialArchiMaid("ArchiMate_TechnologyInterface", "Technology", "Active", "A Technology Interface represents a point of access where technology services offered by a Node can be accessed. A Technology Interface specifies how the technology services of a Node can be accessed by other Nodes. A Technology Interface exposes a Technology Service to the environment.")
                Me.AddInitialArchiMaid("ArchiMate_TechnologyService", "Technology", "Behaviour", "A Technology Service represents an explicitly defined exposed technology behaviour. A Technology Service exposes the functionality of a Node to its environment. This functionality is accessed through one or more Technology Interfaces. It may require, use, and produce Artifacts. Typical Technology Services may, for example, include messaging, storage, naming, and directory services. It may access Artifacts; e.g., a file containing a message.")
                Me.AddInitialArchiMaid("ArchiMate_CommunicationNetwork", "Technology", "Active", "A Technology Service represents an explicitly defined exposed technology behaviour. A Technology Service exposes the functionality of a Node to its environment. This functionality is accessed through one or more Technology Interfaces. It may require, use, and produce Artifacts. Typical Technology Services may, for example, include messaging, storage, naming, and directory services. It may access Artifacts; e.g., a file containing a message.")
                Me.AddInitialArchiMaid("ArchiMate_Device", "Technology", "Active", "A Device represents a physical IT resource upon which system software and artifacts may be stored or deployed for execution. A Device is a specialization of a Node that represents a physical IT resource with processing capability. It is typically used to model hardware systems such as mainframes, PCs, or routers. Usually, they are part of a node together with system software. Devices may be composite; i.e., consist of sub-devices. ")
                Me.AddInitialArchiMaid("ArchiMate_Node", "Technology", "Active", "A Node represents a computational or physical resource that hosts, manipulates, or interacts with other computational or physical resources. Nodes are elements that perform technology behaviour and execute, store, and process technology objects such as Artifacts. For instance, Nodes are used to model application platforms. ")
                Me.AddInitialArchiMaid("ArchiMate_Artifact", "Technology", "Passive", "An Artifact represents a piece of data that is used or produced in a software development process, or by deployment and operation of an IT system. An Artifact represents a tangible element in the IT world. It is typically used to model (software) products such as source files, executables, scripts, database tables, messages, documents, specifications, and model files.")
                Me.AddInitialArchiMaid("ArchiMate_Path", "Technology", "Active", "A Path represents a link between two or more Nodes, through which these nodes can exchange data, energy, or material. A Path is used to model the logical communication (or distribution) relations between Nodes. It is realized by one or more Networks, which represent the physical communication (or distribution) links. A Path connects two or more Nodes. A Path is realized by one or more Networks. A Path can aggregate Nodes.")

                Me.AddInitialArchiMaid("ArchiMate_Material", "Physical", "Passive", "Material represents tangible physical matter or energy. Material can have attributes such as size and weight. It is typically used to model raw materials and physical products, and also energy sources such as fuel. Material can be accessed by physical processes.")
                Me.AddInitialArchiMaid("ArchiMate_Equipment", "Physical", "Active", "Equipment represents one or more physical machines, tools, or instruments that can create, use, store, move, or transform materials. Equipment comprises all active processing elements that carry out physical processes in which materials are used or transformed. Equipment is a specialization of the Node element. Therefore, it is possible to model nodes that are formed by a combination of IT infrastructure (devices, system software) and physical infrastructure (equipment); e.g., an MRI scanner at a hospital, a production plant with its control systems, etc. ")
                Me.AddInitialArchiMaid("ArchiMate_Facility", "Physical", "Active", "A Facility represents a physical structure or environment. A Facility is a specialization of a Node. It represents a physical resource that has the capability of facilitating (e.g., housing or locating) the use of equipment. It is typically used to model factories, buildings, or outdoor constructions that have an important role in production or distribution processes. Facilities can be interconnected by Distribution Networks. Material can be accessed (e.g., created, used, stored, moved, or transformed) by Equipment. A Facility can serve other Facilities, and also Business Roles and Actors. Locations can be assigned to Facilities. A Facility can be composed of other Facilities and can be aggregated in a Location.")
                Me.AddInitialArchiMaid("ArchiMate_DistributionNetwork", "Physical", "Active", "A Distribution Network represents a physical network used to transport materials or energy. A Distribution Network represents the physical distribution or transportation infrastructure. It embodies the physical realization of the logical paths between Nodes. A Distribution Network connects two or more Nodes. A Distribution Network may realize one or more Paths. A Distribution Network can consist of sub-networks and can aggregate Facilities and Equipment.")

            End If
        Catch ex As Exception

        End Try
    End Sub


    ''' <summary>
    ''' Search in a dataset collection for a filter, activate it and return the filtered subset
    ''' </summary>
    ''' <param name="table">Name of the datatable to retrieve data from</param>
    ''' <param name="filter">Filterstring in the datatable</param>
    ''' <returns></returns>
    Function GetFilteredTable(table As String, filter As String) As DataTable
        Dim oDV As DataView
        Try
            oDV = New DataView(Me.IDEADefinitions.Tables(table))
            oDV.RowFilter = filter
            Return oDV.ToTable()
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
        Return Nothing
    End Function

    ''' <summary>
    ''' utility routine to get the value of a configitem based on its name
    ''' If the name is not found, an empty string is returned
    ''' </summary>
    ''' <param name="name">Name of configuration item</param>
    ''' <returns>Value of the configuration item</returns>
    Function GetSettingValue(name As String) As String
        Dim DT As DataTable
        DT = Me.GetFilteredTable("SETTINGS", String.Format("name = '{0}' ", name))
                If DT.Rows.Count > 0 Then
            Dim Row As DataRow
            Row = DT.Rows(0)
            Return Row("Value")
        End If
        Return ""
    End Function
    ''' <summary>
    ''' Retrieve datatable based on the configuration datatable name
    ''' </summary>
    ''' <param name="table"></param>
    ''' <returns></returns>
    Function GetTable(table As String) As DataTable
        Try
            Return Me.IDEADefinitions.Tables(table)
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
        Return Nothing
    End Function
    ''' <summary>
    ''' Create the initial settings for the IDEA AddOn so later the user can modify it via the settings window
    ''' </summary>
    ''' <param name="Name"></param>
    ''' <param name="Value"></param>
    ''' <param name="Type"></param>
    Sub AddInitialSetting(Name As String, Value As String, Optional Type As String = "Config", Optional Documentation As String = "")
        If Me.GetSettingValue(Name).Length = 0 Then
            Me.AddSetting(Name, Value, Type, Documentation)
        End If
    End Sub
    ''' <summary>
    ''' Create an initial SQL statement for the diagram helper screen
    ''' </summary>
    ''' <param name="Name"></param>
    ''' <param name="Type"></param>
    ''' <param name="Statement"></param>
    ''' <param name="Template"></param>
    Sub AddInitialSQL(Name As String, Type As String, Statement As String, Template As String)
        If Me.GetFilteredTable("SQL-Statement", String.Format(" Name = '{0}' ", Name)).Rows.Count = 0 Then
            Me.AddStatement(Name, Type, Statement, Template)
        End If
    End Sub
    ''' <summary>
    ''' Add initial values of the datatable with archimate elements for the new archimaid helper
    ''' </summary>
    ''' <param name="StereoType"></param>
    ''' <param name="Layer"></param>
    ''' <param name="Column"></param>
    Sub AddInitialArchiMaid(StereoType As String, Layer As String, Column As String, Optional Documentation As String = "")
        Me.AddArchiMaid(StereoType, Layer, Column, Documentation)
    End Sub
    ''' <summary>
    ''' Create a translations table based on the controls in a form. Please note the recursive approach
    ''' </summary>
    ''' <param name="FormName"></param>
    ''' <param name="col"></param>
    ''' <param name="Check"></param>
    ''' <returns></returns>
    Public Function FormControls2TransLations(FormName As String, col As System.Windows.Forms.Control.ControlCollection, Check As Boolean) As Boolean
        Dim blnContinue As Boolean = True
        If Check = True Then
            Dim oDTCheck As DataTable = Me.GetFilteredTable("TRANSLATIONS", String.Format("FormName = '{0}'", FormName))
            If oDTCheck.Rows.Count > 0 And "BOTH,WRITE".Contains(Me.GetSettingValue("Translations").ToUpper()) Then
                blnContinue = False
            End If
        End If
        If blnContinue Then
            Dim control As System.Windows.Forms.Control
            For Each control In col
                Me.AddTransLation(FormName, control.Name, control.Text)
                FormControls2TransLations(FormName, control.Controls, False)
            Next
        End If
        If Check = True Then
            Me.SaveTranslations()
        End If
        Return True
    End Function
    ''' <summary>
    ''' Read the translations datatable and transfer it to the control labels in the form based on the name. Please note the recursive approach
    ''' </summary>
    ''' <param name="FormName"></param>
    ''' <param name="col"></param>
    ''' <param name="Check"></param>
    ''' <returns></returns>
    Public Function Translations2FormControls(FormName As String, col As System.Windows.Forms.Control.ControlCollection, Check As Boolean) As Boolean
        Dim blnContinue As Boolean = True
        If Check = True Then
            If Not "BOTH,READ ".Contains(Me.GetSettingValue("Translations").ToUpper()) Then
                blnContinue = False
            End If
        End If
        If blnContinue Then
            Dim control As System.Windows.Forms.Control
            For Each control In col
                Dim oDTCheck As DataTable = Me.GetFilteredTable("TRANSLATIONS", String.Format("FormName = '{0}' And ControlName = '{1}'", FormName, control.Name))
                If oDTCheck.Rows.Count = 1 Then
                    Dim oRow As DataRow = oDTCheck.Rows(0)
                    control.Text = oRow("Translation")
                    control.Refresh()
                    control.Update()
                End If
                Translations2FormControls(FormName, control.Controls, False)
            Next
        End If
        If Check = True Then
        End If
        Return True

    End Function
    ''' <summary>
    ''' Add a translation for a form and control to the datatable of translations
    ''' </summary>
    ''' <param name="FormName"></param>
    ''' <param name="ControlName"></param>
    ''' <param name="Translation"></param>
    ''' <param name="Documentation"></param>
    Sub AddTransLation(FormName As String, ControlName As String, Translation As String, Optional Documentation As String = "")
        Try
            Dim oRow As DataRow
            oRow = Me.IDEADefinitions.Tables("Translations").NewRow()
            oRow("FormName") = FormName
            oRow("ControlName") = ControlName
            oRow("Translation") = Translation
            oRow("Documentation") = Documentation
            Me.IDEADefinitions.Tables("Translations").Rows.Add(oRow)
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Add a setting to the table settings
    ''' </summary>
    ''' <param name="Name"></param>
    ''' <param name="Value"></param>
    ''' <param name="Type"></param>
    Sub AddSetting(Name As String, Value As String, Optional Type As String = "Config", Optional Documentation As String = "")
        Try
            Dim oRow As DataRow
            oRow = Me.IDEADefinitions.Tables("Settings").NewRow()
            oRow("Name") = Name
            oRow("Value") = Value
            oRow("Type") = Type
            oRow("Documentation") = Documentation
            Me.IDEADefinitions.Tables("Settings").Rows.Add(oRow)
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Add an item to the datatable with statements
    ''' </summary>
    ''' <param name="Name"></param>
    ''' <param name="Type"></param>
    ''' <param name="Statement"></param>
    ''' <param name="Template"></param>
    Sub AddStatement(Name As String, Type As String, Statement As String, Template As String)
        Try
            Dim oRow As DataRow
            oRow = Me.IDEADefinitions.Tables("SQL-Statement").NewRow()
            oRow("Name") = Name
            oRow("Type") = Type
            oRow("Statement") = Statement
            oRow("Template") = Template
            Me.IDEADefinitions.Tables("SQL-Statement").Rows.Add(oRow)
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Add an archimate element to the datatable for the archimaid
    ''' </summary>
    ''' <param name="StereoType"></param>
    ''' <param name="Layer"></param>
    ''' <param name="Column"></param>
    Sub AddArchiMaid(StereoType As String, Layer As String, Column As String, Optional Documentation As String = "")
        Try
            Dim oRow As DataRow
            oRow = Me.IDEADefinitions.Tables("ArchiMaid").NewRow()
            oRow("Stereotype") = StereoType
            oRow("Layer") = Layer
            oRow("Column") = Column
            oRow("Active") = True
            oRow("LanguageType") = "Element"
            oRow("Documentation") = Documentation

            Me.IDEADefinitions.Tables("ArchiMaid").Rows.Add(oRow)
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
End Class

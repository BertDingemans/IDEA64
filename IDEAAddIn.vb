Imports System.Data
Imports System.IO
Imports System.Xml
Imports System
Imports IDEA.DLAFormfactory

Namespace IDEA
    ''' <summary>
    ''' Connector class for the menu options etcetera for the AddOn the functions are called from the EA application
    ''' Here all the connection points from the EA application are defined
    ''' </summary>
    ''' 
    Public Class IDEAAddIn
        ' define menu constants
        Const menuDeduplicator As String = "Deduplicator "
        Const menuPackageDeduplicator As String = "Package Deduplicator "
        Const menuElementDeduplicator As String = "Element Deduplicator "
        Const menuDiagramDeduplicator As String = "Diagram Deduplicator "
        Const menuAssistant As String = "Assistant"
        Const menuFormFactory As String = "Logical Data Model Simulator"
        Const menuModelAnalyse As String = "Model Analyser"
        Const menuDocumentImport As String = "Document Importer"
        Const menuGitConnect As String = "Git Connector"
        Const menuArchiMAID As String = "ArchimAID"
        Const menuNoDataFault As String = "DatAID"
        Const menuSolutionWizard As String = "Solution Wizard"
        Const menuSettings As String = "Settings"
        Const menuPackageReporter As String = "Package generator"
        Const menuElement As String = "Browser Helper "
        Const diagramElement As String = "Diagram Helper "
        Const diagramDeduplicator As String = "Deduplicate on diagram "
        Const menuText2ArchiMate As String = "Text 2 ArchiMate "

        Const menuHelper As String = "-IDEA"

        Protected oArchiAid As FrmArchiMaid3

        Public Function EA_Connect(ByVal Repository As EA.Repository) As [String]
            DLA2EAHelper.SuppressWarningDialog = False
            Repository.CreateOutputTab("IDEA")
            oArchiAid = Repository.AddWindow("ArchiMaid", "FrmArchiMaid3")
            Return ""
        End Function

        ''' <summary>
        ''' When an element is deleted first check for the wastebin function in IDEA
        ''' </summary>
        ''' <param name="Repository"></param>
        ''' <param name="Info"></param>
        ''' <returns></returns>
        Function EA_OnPreDeleteElement(Repository As EA.Repository, Info As EA.EventProperties) As Boolean
            Dim blnRet As Boolean = False
            Dim intTeller As Int32 = 0
            Dim blnContinue As Boolean = True
            Dim FrmRelEntity As New FrmRelatedEntityChecker()
            While intTeller < Info.Count
                If My.Settings.EntityChecker And FrmRelEntity.SetElement(Repository.GetElementByID(Convert.ToInt32(Info.Get(intTeller).Value))) Then
                    FrmRelEntity.ShowDialog()
                    blnContinue = FrmRelEntity.ContinueOperation
                End If
                blnRet = (blnContinue And WasteBin.WasteBinElement(Repository, Info.Get(intTeller).Value))
                intTeller += 1
            End While
            Return blnRet
        End Function

        ''' <summary>
        ''' When a package is deleted first check for the wastebin function in IDEA
        ''' </summary>
        ''' <param name="Repository"></param>
        ''' <param name="Info"></param>
        ''' <returns></returns>
        Function EA_OnPreDeletePackage(Repository As EA.Repository, Info As EA.EventProperties) As Boolean
            Dim blnRet As Boolean = True
            Dim blnContinue As Boolean = True
            Dim intTeller As Int32 = 0
            Dim FrmRelEntity As New FrmRelatedEntityChecker()
            While intTeller < Info.Count
                If My.Settings.EntityChecker And FrmRelEntity.SetPackage(Repository.GetPackageByID(Convert.ToInt32(Info.Get(intTeller).Value))) Then
                    FrmRelEntity.ShowDialog()
                    blnContinue = FrmRelEntity.ContinueOperation
                End If
                blnRet = (blnContinue And WasteBin.WasteBinPackage(Repository, Info.Get(intTeller).Value))
                intTeller += 1
            End While
            Return blnRet
        End Function

        ''' <summary>
        ''' Give a message when someone creates a connector to a deleted or obsolete element
        ''' Specific for the NS
        ''' </summary>
        ''' <param name="Repository"></param>
        ''' <param name="Info"></param>
        ''' <returns></returns>
        Public Overridable Function EA_OnPostNewConnector(ByVal Repository As EA.Repository, ByVal Info As EA.EventProperties) As Boolean

            'Dim strSQL As String = String.Format("SELECT start_object.name, start_object.status 
            'FROM t_object as start_object , t_object as end_object , t_connector
            'WHERE t_connector.Start_Object_ID = start_object.object_id AND t_connector.End_Object_ID =  End_Object.object_ID AND start_object.status IN('Obsolete', 'Deleted') AND t_connector.connector_id = {0}
            'UNION
            'SELECT end_object.name, end_object.status
            'FROM t_object as start_object, t_object as end_object, t_connector
            'WHERE t_connector.Start_Object_ID = start_object.object_id AND t_connector.End_Object_ID =  End_Object.object_ID AND end_object.status IN('Obsolete', 'Deleted') AND t_connector.connector_id = {0}", Info(0).Value.ToString())
            'Dim objDT As DataTable = DLA2EAHelper.SQL2DataTable(strSQL, Repository)
            'If objDT.Rows.Count > 0 Then
            '    Dim oRow As DataRow = objDT.Rows(0)
            '    MsgBox(String.Format("Warning!!" + vbCrLf + "The entity {0} has the status {1},please remove this connection!!", oRow(0), oRow(1)))
            'End If
            Return True
        End Function

        ''' <summary>
        ''' Check for the diagram helpers to see if they need to be opened
        ''' See ArchimAid and DatAid
        ''' </summary>
        ''' <param name="Repository"></param>
        ''' <param name="DiagramID"></param>
        Public Overridable Sub EA_OnPostOpenDiagram(ByVal Repository As EA.Repository, ByVal DiagramID As Integer)
            Try
                If My.Settings.ShowAidOnDiagramOpen = True Then
                    If Repository.GetCurrentDiagram().StyleEx.ToUpper().Contains("ARCHIMATE") Then
                        Dim FrmAM As New FrmArchiMaid3()
                        FrmAM.Show()
                    Else
                        Dim FrmDV As New FrmDataVault()
                        FrmDV.LoadTemplates()
                        FrmDV.Show()
                    End If
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
        End Sub
        ''' <summary>
        ''' Save the diagram direct to a file
        ''' </summary>
        ''' <param name="Repository"></param>
        ''' <param name="DiagramID"></param>
        Public Overridable Sub EA_OnPostCloseDiagram(ByVal Repository As EA.Repository, ByVal DiagramID As Integer)
            Try
                DLA2EAHelper.ExportDiagram(DiagramID, blnOpen:=False, blnRecentModified:=True, blnBatch:=False)
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
        End Sub
        ''' <summary>
        ''' true if a project is opened in EA
        ''' Based on this the menu is shown
        ''' </summary>
        ''' <param name="Repository"></param>
        ''' <returns></returns>
        Private Function IsProjectOpen(ByVal Repository As EA.Repository) As Boolean
            Try
                Dim c As EA.Collection = Repository.Models
                Return True
            Catch
                Return False
            End Try
        End Function
        ''' <summary>
        ''' check of the IDEA menu needs to be enabled (when a project is opened) or not
        ''' </summary>
        ''' <param name="Repository"></param>
        ''' <param name="Location"></param>
        ''' <param name="MenuName"></param>
        ''' <param name="ItemName"></param>
        ''' <param name="IsEnabled"></param>
        ''' <param name="IsChecked"></param>
        Public Sub EA_GetMenuState(ByVal Repository As EA.Repository, ByVal Location As String, ByVal MenuName As String, ByVal ItemName As String, ByRef IsEnabled As Boolean, ByRef IsChecked As Boolean)
            If Not IsProjectOpen(Repository) Then
                ' If no open project, disable all menu options
                IsEnabled = False
            End If
        End Sub
        ''' <summary>
        ''' Activate the specific helper window based on the stereotype of the active element
        ''' </summary>
        ''' <param name="Repository"></param>
        ''' <param name="Element"></param>
        Private Sub OpenFormForElement(ByVal Repository As EA.Repository, ByVal Element As EA.Element)
            Try
                Select Case Element.Stereotype.ToUpper
                    Case "TABLE"
                        If My.Settings.TableHelper Then
                            Dim objFrmTable As New FrmIDEATable()
                            objFrmTable.Element = Element
                            objFrmTable.LoadElement()
                            objFrmTable.Show()
                        End If
                    Case "XSDCOMPLEXTYPE"
                        If My.Settings.XSDHelper Then
                            Dim objFrmTable As New FrmIDEATable()
                            objFrmTable.Text = "IDEA XSD Helper"
                            objFrmTable.Element = Element
                            objFrmTable.LoadElement()
                            objFrmTable.Show()
                        End If
                    Case Else
                        If Element.Stereotype.Length = 0 And My.Settings.ClassHelper Then
                            Dim objFrmClass As New FrmIDEAClass()
                            objFrmClass.Element = Element
                            objFrmClass.LoadElement()
                            objFrmClass.Show()
                        Else
                            MsgBox("No helper available for this element type", MsgBoxStyle.OkOnly)
                        End If
                End Select
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try

        End Sub
        ''' <summary>
        ''' Create the menu's for the IDEA AddOn menu, the explorer and the diagram canvas
        ''' the array of options is dynamically created based on the user settings
        ''' </summary>
        ''' <param name="Repository"></param>
        ''' <param name="Location"></param>
        ''' <param name="MenuName"></param>
        ''' <returns></returns>
        Public Function EA_GetMenuItems(ByVal Repository As EA.Repository, ByVal Location As String, ByVal MenuName As String) As Object
            Dim menuList As New List(Of String)

            Try
                If Me.IsProjectOpen(Repository) Then
                    Select Case Location.ToUpper()
                        Case "MAINMENU"
                            Select Case MenuName
                                Case ""
                                    Return menuHelper

                                Case menuHelper
                                    If My.Settings.Assistant Then
                                        menuList.Add(menuAssistant)
                                    End If
                                    If My.Settings.Deduplicator Then
                                        menuList.Add(menuPackageDeduplicator)
                                        menuList.Add(menuDiagramDeduplicator)
                                    End If
                                    If My.Settings.FormFactory Then
                                        menuList.Add(menuFormFactory)
                                    End If
                                    If My.Settings.ArchimAid Then
                                        menuList.Add(menuArchiMAID)
                                    End If
                                    If My.Settings.DatAid Then
                                        menuList.Add(menuNoDataFault)
                                    End If
                                    If My.Settings.SolutionWizard Then
                                        menuList.Add(menuSolutionWizard)
                                    End If
                                    If My.Settings.AnalyserWindow Then
                                        menuList.Add(menuModelAnalyse)
                                    End If
                                    If Repository.RepositoryType().ToUpper() <> "JET" Then
                                        menuList.Add(menuText2ArchiMate)
                                    End If
                                    If My.Settings.DocumentImport Then
                                        menuList.Add(menuDocumentImport)
                                    End If
                                    Dim oID As New IDEADefinitions()
                                    If oID.GetSettingValue("GITCONNECT").Length > 0 And File.Exists(oID.GetSettingValue("GITCONNECT")) Then
                                        menuList.Add(menuGitConnect)
                                    End If
                                    menuList.Add(menuPackageReporter)
                                    menuList.Add(menuSettings)
                                    Return menuList.ToArray()
                            End Select
                        Case "TREEVIEW"
                            Select Case MenuName
                                Case ""
                                    Return "-IDEA"
                                Case "-IDEA"
                                    menuList.Add(menuElement)
                                    If My.Settings.Deduplicator Then
                                        menuList.Add(menuDeduplicator)
                                    End If
                                    Return menuList.ToArray()
                            End Select
                        Case "DIAGRAM"
                            Select Case MenuName
                                Case ""
                                    Return "-IDEA"
                                Case "-IDEA"
                                    menuList.Add(diagramElement)
                                    If My.Settings.Deduplicator Then
                                        menuList.Add(menuDeduplicator)
                                    End If
                                    If My.Settings.ArchimAid Then
                                        menuList.Add(menuArchiMAID)
                                    End If
                                    If My.Settings.DatAid Then
                                        menuList.Add(menuNoDataFault)
                                    End If
                                    Return menuList.ToArray()
                            End Select
                        Case Else
                            Return ""
                    End Select
                End If
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return ""
        End Function
        ''' <summary>
        ''' Handle the click of a menu item and call the relevant underlying routine
        ''' </summary>
        ''' <param name="Repository"></param>
        ''' <param name="Location"></param>
        ''' <param name="MenuName"></param>
        ''' <param name="ItemName"></param>
        Public Sub EA_MenuClick(ByVal Repository As EA.Repository, ByVal Location As String, ByVal MenuName As String, ByVal ItemName As String)
            Try
                Select Case ItemName
                    Case diagramElement
                        If Repository.GetCurrentDiagram.SelectedObjects.Count = 1 Then
                            Dim objDO As EA.DiagramObject
                            objDO = Repository.GetCurrentDiagram.SelectedObjects(0)
                            Dim objElement As EA.Element = Repository.GetElementByID(objDO.ElementID)
                            OpenFormForElement(Repository, objElement)
                        Else
                            Dim objWndDiagram As New FrmIdeaDiagram()
                            objWndDiagram.Diagram = Repository.GetCurrentDiagram
                            'Repository.CloseDiagram(objWndDiagram.Diagram.DiagramID)
                            objWndDiagram.Show()
                            If Not objWndDiagram.LoadElements() Then
                                objWndDiagram.Close()
                            End If

                        End If
                    Case menuElement
                        If Location.ToUpper() = "TREEVIEW" Then
                            If Repository.GetTreeSelectedItemType() = EA.ObjectType.otElement Then
                                OpenFormForElement(Repository, Repository.GetTreeSelectedObject())
                            End If

                            If Repository.GetTreeSelectedItemType() = EA.ObjectType.otDiagram And My.Settings.DiagramHelper Then
                                Dim objDiagram As EA.Diagram
                                objDiagram = Repository.GetTreeSelectedObject()
                                Dim objFrmDiagram As New FrmIdeaDiagram()
                                objFrmDiagram.Diagram = objDiagram
                                objFrmDiagram.LoadElements()
                                objFrmDiagram.Show()
                            End If
                            If Repository.GetTreeSelectedItemType() = EA.ObjectType.otPackage And My.Settings.PackageHelper Then
                                Dim objPackage As EA.Package
                                objPackage = Repository.GetTreeSelectedObject()
                                Dim WndPackage = New FrmIDEAPackage()
                                WndPackage.oPackage = objPackage
                                WndPackage.Show()
                            End If
                        End If
                    Case menuDeduplicator, menuPackageDeduplicator
                        Select Case Location.ToUpper()
                            Case "DIAGRAM"
                                Try
                                    If Repository.GetCurrentDiagram.SelectedObjects.Count = 1 Then
                                        Dim objFrmED As New FrmElementDeduplicator()
                                        Dim objDO As EA.DiagramObject
                                        objDO = DirectCast(Repository.GetCurrentDiagram.SelectedObjects.GetAt(0), EA.DiagramObject)
                                        objFrmED.Element = Repository.GetElementByID(objDO.ElementID)
                                        objFrmED.Show()
                                    Else
                                        Dim objFrmDD As New FrmDiagramDuplicator()
                                        objFrmDD.Diagram = Repository.GetTreeSelectedObject()
                                        objFrmDD.Show()
                                    End If
                                Catch ex As Exception
                                    DLA2EAHelper.Error2Log(ex)
                                End Try
                            Case "TREEVIEW"
                                If Repository.GetTreeSelectedItemType() = EA.ObjectType.otElement Then
                                    Dim objFrmED As New FrmElementDeduplicator()
                                    objFrmED.Element = Repository.GetTreeSelectedObject()
                                    objFrmED.Show()
                                End If

                                If Repository.GetTreeSelectedItemType() = EA.ObjectType.otDiagram Then
                                    Dim objFrmDD As New FrmDiagramDuplicator()
                                    objFrmDD.Diagram = Repository.GetTreeSelectedObject()
                                    objFrmDD.Show()
                                End If

                                If Repository.GetTreeSelectedItemType() = EA.ObjectType.otPackage Then
                                    Dim objFrmDD As New FrmPackageDeduplicator()
                                    objFrmDD.Show()
                                End If
                            Case "MAINMENU"
                                Dim objFrmDD As New FrmPackageDeduplicator()
                                objFrmDD.Show()
                        End Select
                    Case menuDiagramDeduplicator
                        Select Case Location.ToUpper()
                            Case "MAINMENU"
                                Dim objFrmDD As New FrmPackageDeduplicator()
                                objFrmDD.isDiagram = True
                                objFrmDD.Show()
                        End Select
                    Case menuFormFactory
                        Dim objFrmFF As New FrmIDEAFormFactory()
                        objFrmFF.Package = Repository.GetTreeSelectedPackage()
                        objFrmFF.LoadPackage()
                        objFrmFF.Show()
                    Case menuModelAnalyse
                        Dim objFrmMA As New FrmModelAnalyser()
                        objFrmMA.Show()
                    Case menuDocumentImport
                        Dim objFrmID As New FrmImportDocument()
                        objFrmID.Repository = Repository
                        objFrmID.Package = Repository.GetTreeSelectedPackage()
                        objFrmID.Show()
                    Case menuGitConnect
                        Dim proc As New System.Diagnostics.Process()
                        Dim oID As New IDEADefinitions()
                        proc = Process.Start(oID.GetSettingValue("GITCONNECT"), "")
                    Case menuArchiMAID
                        '                       Repository.ShowAddinWindow("ArchiMAid")
                        Dim Frm As New FrmArchiMaid3()
                        Frm.Show()
                    Case menuSolutionWizard
                        Dim FrmWiz As New FrmArchitectureWizard()
                        FrmWiz.Show()
                    Case menuNoDataFault
                        Dim oFrmDV As New FrmDataVault()
                        oFrmDV.LoadTemplates()
                        oFrmDV.Show()
                    Case menuText2ArchiMate
                        Dim oFrmT2A As New FrmText2ArchiMate()
                        oFrmT2A.Show()
                    Case menuSettings
                        Dim oWnd As New FrmSettings()
                        oWnd.Show()
                    Case menuPackageReporter
                        Dim oWnd As New frmIDEAPackageReporter()
                        oWnd.Show()
                    Case Else
                        Dim oWnd As New WndWelcome()
                        oWnd.Show()
                End Select
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try

        End Sub
        ''' <summary>
        ''' Call the deduplicator check screen when this is activated
        ''' </summary>
        ''' <param name="Repository"></param>
        ''' <param name="sGuid"></param>
        ''' <param name="oType"></param>
        Public Sub EA_OnNotifyContextItemModified(ByVal Repository As EA.Repository, ByVal sGuid As String, ByVal oType As EA.ObjectType)
            Dim oElement As EA.Element
            Dim oAttribute As EA.Attribute
            Dim oConnector As EA.Connector

            Try
                If oType = EA.ObjectType.otElement Then
                    Repository = DLA2EAHelper.GetRepository()
                    oElement = Repository.GetElementByGuid(sGuid)
                    If Not IsNothing(oElement) Then
                        'Alleen bij archimate elementen valideren
                        '                       If oElement.Stereotype.Contains("ArchiMate") Then
                        'Alleen een scherm tonen als de gebruiker dat heeft aangezet in de settings
                        If My.Settings.SuppresWarningDialog = False Then
                                Dim oWnd As New FrmUniqueElement()
                                If oWnd.SetElement(oElement, Repository) Then
                                    oWnd.Show()
                                End If
                            End If
                        '                        End If
                        DLA2EAHelper.DefaultTaggedValues(oElement, Repository)
                        'deze uitgezet ivm een infinite loop
                        'For Each oAttribute In oElement.Attributes
                        '    DLA2EAHelper.DefaultTaggedValues(oAttribute, Repository)
                        'Next
                    End If

                End If
                If oType = EA.ObjectType.otAttribute Then
                    oAttribute = Repository.GetAttributeByGuid(sGuid)
                    DLA2EAHelper.DefaultTaggedValues(oAttribute, Repository)
                End If
                If oType = EA.ObjectType.otConnector Then
                    oConnector = Repository.GetConnectorByGuid(sGuid)
                    DLA2EAHelper.DefaultTaggedValues(oConnector, Repository)
                End If

            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
        End Sub

        Public Sub EA_OnPostNewElement(ByVal Repository As EA.Repository, ByVal Info As EA.EventProperties)
            Dim oElement As EA.Element

            Try
                If Info.Count > 0 Then
                    Dim intId As Integer = Convert.ToInt32(Info.Get(0).Value)
                    oElement = Repository.GetElementByID(intId)
                    If Not IsNothing(oElement) Then
                        'Alleen bij archimate elementen valideren

                        DLA2EAHelper.DefaultTaggedValues(oElement, Repository)
                    End If
                End If

            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
        End Sub
        Public Sub EA_Disconnect()
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Sub
    End Class
End Namespace
Namespace IDEA64
    Public Class IDEA64AddIn
        Inherits IDEA.IDEAAddIn

    End Class
End Namespace


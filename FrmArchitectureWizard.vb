Imports System.Windows.Forms
Imports IDEA.DLAFormfactory
Public Class FrmArchitectureWizard

    Private Repository As EA.Repository = DLA2EAHelper.GetRepository()
    Private oTemplatePackage As EA.Package
    Private oProjectPackage As EA.Package
    Private intDiagramTeller As Int32 = 0
    Private oDefinities As New IDEADefinitions()
    Private ids As String = "-999"
    Private Finished As Boolean = False
    ''' <summary>
    ''' Load the wizard form an set the relevant comboboxes etc with data from the select statements
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmArchitectureWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DTDiagram As DataTable = DLA2EAHelper.SQL2DataTable(oDefinities.GetSettingValue("WizardDiagramListSQL"), Repository)
            If DTDiagram.Rows.Count > 0 Then
                Me.ComboBoxDiagram.DataSource = DTDiagram
                Me.ComboBoxDiagram.DisplayMember = "name"
                Me.ComboBoxDiagram.ValueMember = "diagram_id"
                Me.ComboBoxDiagram.SelectedIndex = 0
                LoadTemplatesCombo()
            End If

            Dim DTWorkPackage As DataTable = DLA2EAHelper.SQL2DataTable(oDefinities.GetSettingValue("WizardWorkPackageSQL"), Repository)
            If DTWorkPackage.Rows.Count > 0 Then
                Me.ComboBoxWorkPackage.DataSource = DTWorkPackage
                Me.ComboBoxWorkPackage.DisplayMember = "name"
                Me.ComboBoxWorkPackage.ValueMember = "package_id"
                If My.Settings.MRUPackageID <> -999 Then
                    Me.ComboBoxWorkPackage.SelectedValue = My.Settings.MRUPackageID
                End If
            End If
            DataGridViewPreceedingModules.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridViewPreceedingModules.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            DataGridViewPreceedingModules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            DataGridViewPatterns.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridViewPatterns.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            DataGridViewPatterns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Me.Text = "Architecture Wizard " + ProductVersion

            Me.Savetranslations()
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Handle the activities for the tabpage selected
    ''' Loading the next tabages and creating a package etc
    ''' </summary>
    ''' <param name="Tabname"></param>
    Private Function ProcessButtonNext(Tabname As String) As Boolean
        Dim oDT As DataTable
        Dim blnDoorgaan As Boolean = True
        Try
            Select Case Tabname
                Case "TABPAGETEMPLATE"
                    Me.oTemplatePackage = Repository.GetPackageByID(Convert.ToInt32(Me.ComboBoxTemplatePackage.SelectedValue))
                    If String.IsNullOrEmpty(Me.TextBoxProject.Text) Then
                        MsgBox("A Module name is required, please enter a name", MsgBoxStyle.OkOnly)
                        blnDoorgaan = False
                    End If
                    If Not IsNothing(Me.oProjectPackage) Then
                        If MsgBox("There is already a package created, create a new package?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            blnDoorgaan = False
                        End If
                    End If
                    If Not IsNothing(Me.ComboBoxDiagram.SelectedValue) Then
                        'eerst alles sluiten
                        While Not IsNothing(Repository.GetCurrentDiagram())
                            Repository.CloseDiagram(Repository.GetCurrentDiagram().DiagramID)
                        End While
                        Me.Repository.OpenDiagram(Convert.ToInt32(Me.ComboBoxDiagram.SelectedValue))
                    End If
                    ids = "-999"
                    For Each Element As EA.Element In Me.oTemplatePackage.Elements
                        ids += ", " + Element.ElementID.ToString()
                    Next
                    LoadPrecedingGrid()

                    Dim strPatternSQL As String = String.Format(oDefinities.GetSettingValue("WizardPatternsSQL"), Me.ids)
                    oDT = DLA2EAHelper.SQL2DataTable(strPatternSQL, Me.Repository)
                    Me.DataGridViewPatterns.DataSource = oDT
                    DataGridViewPatterns.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
                    DataGridViewPatterns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                    My.Settings.MRUPackageID = Me.ComboBoxWorkPackage.SelectedValue
                    My.Settings.Save()

                Case "TABPAGEPRECEEDINGMODULE"
                    'nu nog niets
                Case "TABPAGEPATTERN"
                    'nu nog niets
            End Select
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
        Return blnDoorgaan
    End Function
    ''' <summary>
    ''' Process the selected options in the wizard. Called via the Finish button at the end of the wizard
    ''' </summary>
    ''' <returns></returns>
    Private Function ProcessWizard() As Boolean
        Dim strPackageName As String = Me.oTemplatePackage.Name
        Dim blnDoorgaan As Boolean = True
        Dim oResultDT As DataTable
        Try
            ' eerste tabblad verwerken
            strPackageName = strPackageName.Replace("Template", "").Replace("#Module", Me.TextBoxProject.Text + " #Module")
            For Each oSubPackage In Me.Repository.GetPackageByID(Me.ComboBoxWorkPackage.SelectedValue).Packages
                If oSubPackage.name = strPackageName Then
                    If MsgBox("There is already a package with this name, create a new package with the same name?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        blnDoorgaan = False
                    End If
                End If
            Next

            If blnDoorgaan = True Then
                Me.oProjectPackage = Me.oTemplatePackage.Clone()
                Me.oProjectPackage.ParentID = Convert.ToInt32(Me.ComboBoxWorkPackage.SelectedValue)
                Me.oProjectPackage.Notes = TextBoxNotes.Text
                Me.oProjectPackage.Name = strPackageName
                Me.oProjectPackage.Update()
                Dim strSQL As String = String.Format(oDefinities.GetSettingValue("WizardDiagramObjectsSQL"), oTemplatePackage.PackageID, oProjectPackage.PackageID)
                Me.Repository.Execute(strSQL)
                Me.CheckBoxTemplateSelected.Text += " " + oTemplatePackage.Name
                Me.CheckBoxTemplateSelected.Checked = True

                SearchReplace()
                For Each Element As EA.Element In Me.oProjectPackage.Elements
                    Element.Notes = TextBoxNotes.Text
                    Element.Status = "Werkmap architect"
                    Element.Update()
                Next
                Me.CheckBoxModuleCreated.Text += " " + oProjectPackage.Name
                Me.CheckBoxModuleCreated.Checked = True
                Repository.ShowInProjectView(Me.oProjectPackage)
            End If
            'tweede tabblad verwerken
            oResultDT = DLA2EAHelper.SelectedGridRows2DataTable(Me.DataGridViewPreceedingModules)
            For Each preceedingrow As DataRow In oResultDT.Rows
                For Each ModElement As EA.Element In Me.oProjectPackage.Elements
                    Dim PreceedingElement As EA.Element = Me.Repository.GetElementByID(Convert.ToInt32(preceedingrow("object_id")))
                    CreateConnector(ModElement, PreceedingElement, "ArchiMate_Triggering")
                    For Each Diagram As EA.Diagram In oProjectPackage.Diagrams
                        Me.CreateDiagramObject(ModElement, Diagram, 300)
                        Me.CreateDiagramObject(PreceedingElement, Diagram, 10)
                    Next
                Next
            Next
            Me.CheckBoxModulesSelected.Checked = True
            'derde tabblad verwerken
            oResultDT = DLA2EAHelper.SelectedGridRows2DataTable(Me.DataGridViewPatterns)
            For Each patternrow As DataRow In oResultDT.Rows
                For Each ModElement As EA.Element In Me.oProjectPackage.Elements
                    Dim PatternElement As EA.Element = Me.Repository.GetElementByID(Convert.ToInt32(patternrow("object_id")))
                    CreateConnector(ModElement, PatternElement, "ArchiMate_Realization")
                    For Each Diagram As EA.Diagram In oProjectPackage.Diagrams
                        Me.CreateDiagramObject(ModElement, Diagram, 300)
                        Me.CreateDiagramObject(PatternElement, Diagram, 300)
                        Dim strIds As String = "-999"
                        Dim unusedDT As DataTable = Me.DataGridViewPatterns.DataSource
                        For Each oUnUsedRow As DataRow In unusedDT.Rows
                            If oUnUsedRow("object_id") <> patternrow("object_id") Then
                                strIds += ", " + oUnUsedRow("object_id")
                            End If
                        Next
                        If CheckBoxCreateInterfaces.Checked Then
                            Dim InterFaceid As Int32
                            For Each oCon As EA.Connector In PatternElement.Connectors
                                If oCon.Stereotype = "ArchiMate_Serving" Then
                                    If oCon.SupplierID = PatternElement.ElementID Then
                                        InterFaceid = oCon.ClientID
                                    Else
                                        InterFaceid = oCon.SupplierID
                                    End If
                                    Dim oConElement As EA.Element = Repository.GetElementByID(InterFaceid)
                                    If oConElement.Stereotype = "ArchiMate_ApplicationInterface" Then
                                        CreateDiagramObject(oConElement, Diagram, 500)
                                        Me.CheckBoxPatternInterface.Checked = True
                                    End If
                                End If
                            Next
                        End If
                        Me.DeleteUnusedPatterns(strIds, Diagram.DiagramID.ToString())
                    Next
                Next
            Next
            Me.CheckBoxPatternSelected.Checked = True
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
        Return blnDoorgaan
    End Function
    ''' <summary>
    ''' Create a connector between two elements including the relevant stereotype
    ''' You have to handle the direction yourself by selecting the source and targetg
    ''' </summary>
    ''' <param name="Source"></param>
    ''' <param name="Target"></param>
    ''' <param name="StereoType"></param>
    Private Sub CreateConnector(Source As EA.Element, Target As EA.Element, StereoType As String)
        Dim objCon As EA.Connector
        Try
            objCon = Source.Connectors.AddNew("", StereoType.Replace("ArchiMate_", ""))
            objCon.Stereotype = StereoType
            objCon.SupplierID = Source.ElementID
            objCon.ClientID = Target.ElementID
            objCon.Direction = "Destination to Source"
            objCon.Update()
            Source.Update()
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Routine to delete the unused patterns from the newly created diagrams in the project package
    ''' </summary>
    ''' <param name="unusedpatternids"></param>
    ''' <param name="diagramid"></param>
    Private Sub DeleteUnusedPatterns(unusedpatternids As String, diagramid As String)
        Try
            Dim strSql As String = String.Format(oDefinities.GetSettingValue("WizardUnusedPatternsSQL"), unusedpatternids, diagramid)
            Me.Repository.Execute(strSql)
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub
    ''' <summary>
    ''' Create a diagram object for the source and the target elements on the diagram if they do not yet exist
    ''' </summary>
    ''' <param name="Source"></param>
    ''' <param name="objDiagram"></param>
    Private Sub CreateDiagramObject(Source As EA.Element, objDiagram As EA.Diagram, Optional intleft As Int32 = 10)
        Dim Rnd As New Random()
        Try
            Dim intTop As Int32 = (Rnd.Next(500) * -1)
            Dim strIds As String = ""
            Dim objDON As EA.DiagramObject
            For Each objDON In objDiagram.DiagramObjects
                strIds += " " + objDON.ElementID.ToString()
            Next
            If Not strIds.Contains(Source.ElementID.ToString()) Then
                objDON = objDiagram.DiagramObjects.AddNew("", "")
                objDON.ElementID = Source.ElementID
                objDON.top = intTop
                objDON.bottom = intTop - 50
                objDON.left = intleft
                objDON.right = intleft + 120
                objDON.ShowNotes = False
                objDON.Update()
            End If
            objDiagram.Update()
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Handle the click event for the next button in the wizard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        Try
            'deze gaan achteraf af
            If Me.ProcessButtonNext(Me.TabControl1.SelectedTab.Name.ToUpper()) Then
                Me.HandleButtons(True)
                If Not IsNothing(oProjectPackage) Then
                    If Me.TabControl1.SelectedTab.Name = "TabPageValidate" Then
                        Dim objDiagram As EA.Diagram
                        If intDiagramTeller >= 0 And intDiagramTeller < oProjectPackage.Diagrams.Count Then
                            objDiagram = oProjectPackage.Diagrams(intDiagramTeller)
                            Me.Repository.OpenDiagram(objDiagram.DiagramID)
                            intDiagramTeller += 1
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Take care of the previous and next button for the wizard
    ''' </summary>
    ''' <param name="blnNext"></param>
    ''' <returns></returns>
    Private Function HandleButtons(blnNext As Boolean) As Boolean
        Try
            If blnNext = True Then
                Me.TabControl1.SelectTab(Me.TabControl1.SelectedIndex + 1)
            Else
                Me.TabControl1.SelectTab(Me.TabControl1.SelectedIndex - 1)
            End If
            If Me.TabControl1.SelectedIndex = 0 Then
                Me.ButtonPrevious.Enabled = False
            Else
                Me.ButtonPrevious.Enabled = True
            End If
            If Me.TabControl1.SelectedIndex = Me.TabControl1.TabCount - 1 Then
                Me.ButtonFinish.Enabled = True
                Me.ButtonNext.Enabled = False
            Else
                Me.ButtonFinish.Enabled = False
                Me.ButtonNext.Enabled = True
            End If
            Return Me.ButtonNext.Enabled
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
        Return False
    End Function

    ''' <summary>
    ''' Search and replace parts of the text in a package. 
    ''' Works both for elements and diagrams
    ''' currently not for connectors
    ''' </summary>
    Private Function SearchReplace() As String
        Try
            For Each Diagram As EA.Diagram In Me.oProjectPackage.Diagrams
                Diagram.Name = Diagram.Name.Replace("Template", "").Replace("#Module", Me.TextBoxProject.Text + " #Module")
                Diagram.Update()
            Next
            For Each Element As EA.Element In Me.oProjectPackage.Elements
                Element.Name = Element.Name.Replace("Template", "").Replace("#Module", Me.TextBoxProject.Text + " #Module")
                Element.Update()
            Next
            oProjectPackage.Update()
            Return oProjectPackage.Name
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
        Return ""
    End Function
    ''' <summary>
    ''' Process the activities after the previous button is pressed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        Me.HandleButtons(False)
    End Sub
    ''' <summary>
    ''' Process clicking the finish button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonFinish_Click(sender As Object, e As EventArgs) Handles ButtonFinish.Click
        If Finished Then
            MsgBox("Wizard already processed", MsgBoxStyle.OkOnly)
        Else
            Finished = ProcessWizard()
        End If
        If Me.CheckBoxCloseFinish.Checked Then
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' Load the grid with the elements of the preceding modules available in the repository
    ''' </summary>
    Sub LoadPrecedingGrid()
        Dim oDT As DataTable
        'load the preceeding grid
        If Not IsNothing(Me.ComboBoxDiagram.SelectedValue) Then
            Dim strPreceedingSQL As String = String.Format(oDefinities.GetSettingValue("WizardPreceedingModulesSQL"), Me.ids)
            strPreceedingSQL = strPreceedingSQL.Replace("#diagram_id#", Me.ComboBoxDiagram.SelectedValue)
            'This is necessary for adding the elements currently under construction
            If CheckBoxIncludeWerkmap.Checked Then
                strPreceedingSQL = strPreceedingSQL.Replace("#werkmap#", "Werkmap architect")
            End If
            oDT = DLA2EAHelper.SQL2DataTable(strPreceedingSQL, Me.Repository)
            Me.DataGridViewPreceedingModules.DataSource = oDT
            DataGridViewPreceedingModules.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            DataGridViewPreceedingModules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If
    End Sub
    ''' <summary>
    ''' Handling of the include werkmap function to load the grid with extra elements
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CheckBoxIncludeWerkmap_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxIncludeWerkmap.CheckedChanged
        LoadPrecedingGrid()
    End Sub
    ''' <summary>
    ''' loading of the combobox with with templates of processing steps based on the sample diagrams
    ''' </summary>
    Private Sub LoadTemplatesCombo()
        Try
            'let op afhankelijk vansql statement met een dummy rij op de eerste regel
            If Me.ComboBoxDiagram.SelectedIndex >= 0 Then
                Dim intDiagramId As Int32
                Dim strDiagramid As String = Convert.ToString(Me.ComboBoxDiagram.SelectedValue)
                If Int32.TryParse(strDiagramid, intDiagramID) Then
                    Dim strDef As String = oDefinities.GetSettingValue("WizardTemplateSQL")
                    Dim strSql As String = strDef.Replace("{0}", strDiagramid)
                    Dim DTTemplate As DataTable = DLA2EAHelper.SQL2DataTable(strSql, Repository)
                    If DTTemplate.Rows.Count > 0 Then
                        Me.ComboBoxTemplatePackage.DataSource = DTTemplate
                        Me.ComboBoxTemplatePackage.DisplayMember = "name"
                        Me.ComboBoxTemplatePackage.ValueMember = "package_id"
                    End If
                Else
                    Me.ComboBoxTemplatePackage.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    Private Sub ComboBoxDiagram_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxDiagram.SelectedValueChanged
        LoadTemplatesCombo()
    End Sub
    Public Sub Savetranslations()
        oDefinities.FormControls2TransLations(Me.Name, Me.Controls, True)
        oDefinities.Translations2FormControls(Me.Name, Me.Controls, True)
        Me.Update()
    End Sub

    Private Sub ComboBoxDiagram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDiagram.SelectedIndexChanged

    End Sub
End Class
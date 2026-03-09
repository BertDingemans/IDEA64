Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms
Imports IDEA.DLAFormfactory
Imports System.Drawing

Public Class FrmSettings
    Private Repository As EA.Repository = DLA2EAHelper.GetRepository()
    Private oDefinitions As IDEADefinitions

    ''' <summary>
    ''' Load various elements in the settings window, especially the two grids with settings data for the IDEA addon
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.oDefinitions = New IDEADefinitions()
        If oDefinitions.CheckVersion Then
            Me.DataGridViewSettings.DataSource = oDefinitions.GetTable("SETTINGS")
            DataGridViewSettings.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridViewSettings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            DataGridViewSettings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            Me.DataGridViewStatement.DataSource = oDefinitions.GetTable("SQL-STATEMENT")
            DataGridViewStatement.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridViewStatement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            DataGridViewStatement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            Me.DataGridViewTranslations.DataSource = oDefinitions.GetTable("TRANSLATIONS")
            DataGridViewTranslations.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridViewTranslations.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            DataGridViewTranslations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            Me.DataGridViewArchiMaid.DataSource = oDefinitions.GetTable("ARCHIMAID")
            DataGridViewArchiMaid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridViewArchiMaid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            DataGridViewArchiMaid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            Me.DataGridViewDataAnalyser.DataSource = oDefinitions.GetTable("DATAANALYSER")
            DataGridViewDataAnalyser.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridViewDataAnalyser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            DataGridViewDataAnalyser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            LoadUserSettings()
        Else
            MsgBox("You use an old version of the IDEA AddOn, install a new version")
            Me.Close()
        End If

    End Sub
    ''' <summary>
    ''' Load all user settings from the user config setttings to the form controls
    ''' </summary>
    Private Sub LoadUserSettings()

        'Default instellen
        Me.ComboBoxSettingMode.SelectedItem = "User"
        Me.CheckBoxAssistant.Checked = My.Settings.Assistant
        Me.CheckBoxArchimAid.Checked = My.Settings.ArchimAid
        Me.CheckBoxDatAid.Checked = My.Settings.DatAid
        Me.CheckBoxDeduplicator.Checked = My.Settings.Deduplicator
        Me.CheckBoxFormFactory.Checked = My.Settings.FormFactory
        Me.CheckBoxDocumentImport.Checked = My.Settings.DocumentImport
        Me.CheckBoxSolutionWizard.Checked = My.Settings.SolutionWizard
        Me.CheckBoxPackageHelper.Checked = My.Settings.PackageHelper
        Me.CheckBoxDiagramHelper.Checked = My.Settings.DiagramHelper
        Me.CheckBoxClassHelper.Checked = My.Settings.ClassHelper
        Me.CheckBoxTableHelper.Checked = My.Settings.TableHelper
        Me.CheckBoxArchiMateHelper.Checked = My.Settings.ArchiMateHelper
        Me.CheckBoxXSDHelper.Checked = My.Settings.XSDHelper
        Me.CheckBoxShowAidOnDiagramOpen.Checked = My.Settings.ShowAidOnDiagramOpen
        Me.CheckBoxEntityChecker.Checked = My.Settings.EntityChecker
        Me.CheckBoxAnalyserWindow.Checked = My.Settings.AnalyserWindow
        Me.TextBoxSettingFile.Text = My.Settings.SettingsFile
        Me.CheckBoxSuppressValidationWarning.Checked = My.Settings.SuppresWarningDialog

        Me.ComboBoxSettingMode.SelectedItem = My.Settings.SettingsMode

    End Sub

    ''' <summary>
    ''' Save the defied settings in the form controls to the user settings in the appdat section of the computer
    ''' </summary>
    Private Sub SaveUserSettings()
        My.Settings.Assistant = Me.CheckBoxAssistant.Checked
        My.Settings.ArchimAid = Me.CheckBoxArchimAid.Checked
        My.Settings.DatAid = Me.CheckBoxDatAid.Checked
        My.Settings.Deduplicator = Me.CheckBoxDeduplicator.Checked
        My.Settings.FormFactory = Me.CheckBoxFormFactory.Checked
        My.Settings.DocumentImport = Me.CheckBoxDocumentImport.Checked
        My.Settings.PackageHelper = Me.CheckBoxPackageHelper.Checked
        My.Settings.DiagramHelper = Me.CheckBoxDiagramHelper.Checked
        My.Settings.ClassHelper = Me.CheckBoxClassHelper.Checked
        My.Settings.TableHelper = Me.CheckBoxTableHelper.Checked
        My.Settings.ArchiMateHelper = Me.CheckBoxArchiMateHelper.Checked
        My.Settings.XSDHelper = Me.CheckBoxXSDHelper.Checked
        My.Settings.SolutionWizard = Me.CheckBoxSolutionWizard.Checked
        My.Settings.ShowAidOnDiagramOpen = Me.CheckBoxShowAidOnDiagramOpen.Checked
        My.Settings.EntityChecker = Me.CheckBoxEntityChecker.Checked
        My.Settings.AnalyserWindow = Me.CheckBoxAnalyserWindow.Checked
        My.Settings.SettingsMode = Me.ComboBoxSettingMode.SelectedItem
        My.Settings.SettingsFile = Me.TextBoxSettingFile.Text
        My.Settings.SuppresWarningDialog = Me.CheckBoxSuppressValidationWarning.Checked

        My.Settings.Save()

    End Sub
    ''' <summary>
    ''' Save the settings in this screen to various sections for example the user settings to the app data
    ''' For the system settings there are two options one is to an artifact in the database named IDEAconfig and the second is to the user data 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmSettings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            SaveUserSettings()
            If MsgBox("Save settings modifications?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                oDefinitions.SaveSettings()
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub DataGridViewDataAnalyser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDataAnalyser.CellContentClick

    End Sub

    Private Sub DataGridViewDataAnalyser_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridViewDataAnalyser.DataError
        MessageBox.Show("Error happened " _
             & e.Context.ToString() & vbCrLf & e.Exception.ToString())
    End Sub

    Private Sub DataGridViewDataAnalyser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDataAnalyser.CellClick
        Try
            If e.ColumnIndex > -1 Then
                Dim objGraphTypeDropBox As System.Windows.Forms.DataGridViewComboBoxCell = New System.Windows.Forms.DataGridViewComboBoxCell()

                If DataGridViewDataAnalyser.Columns(e.ColumnIndex).Name.Contains("GraphType") Then
                    objGraphTypeDropBox.Items.Add("Bar")
                    objGraphTypeDropBox.Items.Add("Column")
                    objGraphTypeDropBox.Items.Add("Pie")
                    objGraphTypeDropBox.Items.Add("StackedBar")
                    objGraphTypeDropBox.Items.Add("StackedColumn")

                    objGraphTypeDropBox.Style.BackColor = Color.White
                    objGraphTypeDropBox.Style.SelectionBackColor = Color.White
                    DataGridViewDataAnalyser(e.ColumnIndex, e.RowIndex) = objGraphTypeDropBox
                End If
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub


    Private Sub DataGridViewArchiMaid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewArchiMaid.CellClick
        Try
            If e.ColumnIndex > -1 Then
                Dim objDataTableDropbox As System.Windows.Forms.DataGridViewComboBoxCell = New System.Windows.Forms.DataGridViewComboBoxCell()
                Dim oID As New IDEADefinitions()
                Dim strSQL As String = oID.GetSettingValue("ArchiMateRegisterPackageSQL")
                If DataGridViewArchiMaid.Columns(e.ColumnIndex).Name.Contains("Package_guid") Then
                    objDataTableDropbox.DataSource = DLA2EAHelper.SQL2DataTable(strSQL, Me.Repository)
                    objDataTableDropbox.ValueMember = "package_guid"
                    objDataTableDropbox.DisplayMember = "name"
                    objDataTableDropbox.Style.BackColor = Color.White
                    objDataTableDropbox.Style.SelectionBackColor = Color.White
                    DataGridViewArchiMaid(e.ColumnIndex, e.RowIndex) = objDataTableDropbox
                End If
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        My.Settings.Reset()
        My.Settings.Reload()
        My.Settings.Save()
        LoadUserSettings()
    End Sub

    Private Sub CheckBoxShowAidOnDiagramOpen_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowAidOnDiagramOpen.CheckedChanged

    End Sub
End Class
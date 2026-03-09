Imports IDEA.DLAFormfactory

''' <summary>
''' Welcome screen of the IDEA AddOn
''' Including versioning information
''' </summary>
Public Class WndWelcome
    Private repository As EA.Repository = DLA2EAHelper.getrepository()
    ''' <summary>
    ''' Open the releasemanager window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub ButtonReleaseManager_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonReleaseManager.Click
        Dim oWnd As New frmReleaseManager()
        oWnd.LoadPackage()
        oWnd.Show()
        Me.Close()
    End Sub
    ''' <summary>
    ''' Import screen for importing and normalizing data from an excel file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonImportNorm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSimpleQuery.Click
        Dim oWnd As New FrmQueryExport()
        oWnd.Show()
        Me.Close()
    End Sub
    ''' <summary>
    ''' Open the settings window of the IDEA AddOn
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonSettings_Click(sender As Object, e As EventArgs) Handles ButtonSettings.Click
        Dim oWnd As New FrmSettings()
        oWnd.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub WndWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.Text = Me.Label1.Text
        Me.TextBoxVersion.Text = "Version " + ProductVersion
    End Sub

    Private Sub TextBoxVersion_TextChanged(sender As Object, e As EventArgs) Handles TextBoxVersion.TextChanged

    End Sub
    ''' <summary>
    ''' Export all the diagrams to a file in a directory. There is an extra check for if the file does already exist before writing it to a file. This is necessary for a gpf message from internal sparx
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonDiagram2WPP_Click(sender As Object, e As EventArgs) Handles ButtonDiagram2WPP.Click
        Dim oPackage As EA.Package
        For Each oPackage In repository.Models
            DLA2EAHelper.Diagrams2WPP(oPackage)
            DLA2EAHelper.LinkedDocument2WPP(oPackage)
        Next
    End Sub


    ''' <summary>
    ''' Open the window for displaying the orphans window for diagram and relation orphans
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonOrphan_Click(sender As Object, e As EventArgs) Handles ButtonOrphan.Click
        Dim oWnd As New frmOrphans()
        oWnd.Show()

    End Sub

    Private Sub ButtonExcelImporter_Click(sender As Object, e As EventArgs) Handles ButtonExcelImporter.Click
        Dim oWnd As New FrmImportExcel()
        oWnd.Show()

    End Sub


End Class
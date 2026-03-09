Imports IDEA.DLAFormfactory
Imports System.Windows.Forms

Public Class frmIDEAPackageReporter
    Private Repository As EA.Repository = DLA2EAHelper.GetRepository()
    Private oTemplates As New HTMLTemplates()
    Private oDef As New IDEADefinitions()
    Private oPackage As EA.Package = Repository.GetTreeSelectedPackage()

    Private Sub frmIDEAPackageReporter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridViewTemplate.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewTemplate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.ToolStripTextBoxPublish.Text = oDef.GetSettingValue("ReleaseDirectory")
        Me.oTemplates.DefaultTemplates()
        Me.DataGridViewTemplate.DataSource = oTemplates.Templates
        Me.Savetranslations()
    End Sub
    Public Sub Savetranslations()
        oDef.FormControls2TransLations(Me.Name, Me.Controls, True)
    End Sub
    Private Sub ToolStripButtonExecute_Click(sender As Object, e As EventArgs) Handles ToolStripButtonExecute.Click
        Dim oPublisher As New HTMLPublicator()
        'store the current settings for reuse
        Try
            'set the properties for the publisher
            oPublisher.Templates = Me.oTemplates
            oPublisher.Path = Me.ToolStripTextBoxPublish.Text
            oPublisher.Generate(Me.oPackage)
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
        Me.Close()
    End Sub

    Private Sub ToolStripButtonLoadTemplate_Click(sender As Object, e As EventArgs) Handles ToolStripButtonLoadTemplate.Click
        If Me.OpenXMLFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.oTemplates.LoadTemplates(Me.OpenXMLFileDialog.FileName)
            Me.ToolStripTextBoxTemplate.Text = Me.OpenXMLFileDialog.FileName
        End If
    End Sub

    Private Sub ToolStripButtonSaveTemplate_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSaveTemplate.Click
        If Me.SaveXMLFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.oTemplates.SaveTemplates(Me.SaveXMLFileDialog.FileName)
            Me.ToolStripTextBoxTemplate.Text = Me.SaveXMLFileDialog.FileName
        End If
    End Sub

    Private Sub ToolStripButtonGrid2Text_Click(sender As Object, e As EventArgs) Handles ToolStripButtonGrid2Text.Click
        Me.TextBoxTemplate.Text = Me.DataGridViewTemplate.CurrentCell.Value
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.DataGridViewTemplate.CurrentCell.Value = Me.TextBoxTemplate.Text
    End Sub
End Class
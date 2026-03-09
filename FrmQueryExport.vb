Imports System.Data.OleDb
Imports IDEA.DLAFormfactory

''' <summary>
''' Helper screen for an advanced user to do some advanced things with the database
''' with SQL queries. You can retrieve data but also manipulate the data in the
''' repository.
''' </summary>
Public Class FrmQueryExport
    Protected strTable As String
    Protected Repository As EA.Repository = DLA2EAHelper.GetRepository()
    Protected objDT As DataTable
    Private Sub ToolStripButtonLoad_Click_1(sender As Object, e As EventArgs) Handles ToolStripButtonLoad.Click
        Try
            System.Windows.Forms.Clipboard.SetText(Me.TextBoxSQL.Text)
            Me.Repository.SuppressEADialogs = True
            Me.objDT = DLA2EAHelper.EAString2DataTable(Me.Repository.SQLQuery(Me.TextBoxSQL.Text))
            Me.DataGridViewExcel.DataSource = objDT
            Me.Repository.SuppressEADialogs = False
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub ToolStripButtonExecute_Click_1(sender As Object, e As EventArgs) Handles ToolStripButtonExecute.Click
        Try
            System.Windows.Forms.Clipboard.SetText(Me.TextBoxSQL.Text)
            If DLA2EAHelper.IsUserGroupMember(Repository, "Administrators") Then
                Me.Repository.Execute(Me.TextBoxSQL.Text)
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub ToolStripButtonExport_Click(sender As Object, e As EventArgs) Handles ToolStripButtonExport.Click
        If Me.SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.SaveFileDialog1.RestoreDirectory = True
            Dim csv As String
            csv = DLA2EAHelper.Table2CSV(Me.DataGridViewExcel.DataSource)
            DLA2EAHelper.String2File(csv, Me.SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub ToolStripButtonCopy_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCopy.Click
        System.Windows.Forms.Clipboard.SetText(Me.TextBoxSQL.Text)
    End Sub

    Private Sub ToolStripButtonPaste_Click(sender As Object, e As EventArgs) Handles ToolStripButtonPaste.Click
        Me.TextBoxSQL.Text = System.Windows.Forms.Clipboard.GetText()
    End Sub

    Private Sub FrmQueryExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Savetranslations()
    End Sub
    Public Sub Savetranslations()
        Dim oDefinities As New IDEADefinitions()
        oDefinities.FormControls2TransLations(Me.Name, Me.Controls, True)
    End Sub
End Class

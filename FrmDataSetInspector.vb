Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms
Imports IDEA.DLAFormfactory
Public Class FrmDataSetInspector
    Protected DataSet As DataSet
    Private Sub FrmDataSetInspector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DataGridViewDataTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridViewDataTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.Savetranslations()
    End Sub

    Public Sub Savetranslations()
        Dim oDefinities As New IDEADefinitions()
        oDefinities.FormControls2TransLations(Me.Name, Me.Controls, True)
    End Sub

    Public Sub SetDataSet(DS As DataSet)
        Me.DataSet = DS
        For Each oTable As DataTable In DS.Tables
            Me.ComboBoxDataTable.Items.Add(oTable.TableName)
        Next
    End Sub

    Private Sub ButtonDisplayTable_Click(sender As Object, e As EventArgs) Handles ButtonDisplayTable.Click
        If Not IsNothing(Me.ComboBoxDataTable.Text) Then
            Me.DataGridViewDataTable.DataSource = Me.DataSet.Tables(Me.ComboBoxDataTable.Text)
        End If
    End Sub

    Private Sub ComboBoxDataTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDataTable.SelectedIndexChanged
        If Not IsNothing(Me.ComboBoxDataTable.Text) Then
            Me.DataGridViewDataTable.DataSource = Me.DataSet.Tables(Me.ComboBoxDataTable.Text)
        End If
    End Sub
End Class
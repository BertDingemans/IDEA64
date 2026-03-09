Imports System.Windows.Forms
Imports EA
Imports IDEA.DLAFormfactory

Public Class frmOrphans
    Private Sub frmOrphans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

    End Sub

    Sub LoadData()
        Dim strSqlD As String = "SELECT t_object.name, t_object.stereotype, t_object.object_type, t_object.author, t_object.version, t_object.object_id " +
            "FROM t_object WHERE t_object.object_id NOT IN(SELECT object_id FROM t_diagramobjects) ORDER BY 3,1"

        Dim strSqlC As String = "SELECT t_object.name, t_object.stereotype, t_object.object_type, t_object.author, t_object.version, t_object.object_id FROM t_object " +
            "WHERE t_object.object_id NOT IN(SELECT end_object_id FROM t_connector) " +
            "AND t_object.object_id NOT IN( SELECT start_object_id FROM t_connector) ORDER BY 3, 1 "
        Try
            DataGridViewDiagramOrphans.DataSource = DLA2EAHelper.SQL2DataTable(strSqlD, DLA2EAHelper.GetRepository())
            DataGridViewConnectorOrphans.DataSource = DLA2EAHelper.SQL2DataTable(strSqlC, DLA2EAHelper.GetRepository())
            DataGridViewDiagramOrphans.Columns("object_id").Visible = False
            DataGridViewConnectorOrphans.Columns("object_id").Visible = False

            Dim objDT As DataTable
            objDT = DLA2EAHelper.SQL2DataTable("SELECT package_id, name FROM t_package WHERE parent_id <> 0 ORDER BY name", DLA2EAHelper.GetRepository())
            ToolStripPackageComboBox.ComboBox.DataSource = objDT
            ToolStripPackageComboBox.ComboBox.DisplayMember = "name"
            ToolStripPackageComboBox.ComboBox.ValueMember = "package_id"

        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub ToolStripButtonMove_Click(sender As Object, e As EventArgs) Handles ToolStripButtonMove.Click
        Dim oRow As DataRow
        Dim strIds As String = "-999"
        Try
            If DLA2EAHelper.IsUserGroupMember(DLA2EAHelper.GetRepository(), "Administrators") Then
                For Each oRow In Me.DataGridViewDiagramOrphans.DataSource.Rows
                    strIds += ", " + oRow("object_id")
                Next

                For Each oRow In Me.DataGridViewConnectorOrphans.DataSource.Rows
                    strIds += ", " + oRow("object_id")
                Next
                Dim strSql As String = String.Format("UPDATE t_object SET package_id = {0} WHERE object_id IN({1}) ", ToolStripPackageComboBox.ComboBox.SelectedValue, strIds)
                DLA2EAHelper.GetRepository().Execute(strSql)
            End If

        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub
End Class
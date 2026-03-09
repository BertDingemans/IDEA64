Imports System.Data.OleDb
Imports IDEA.DLAFormfactory
Imports System.Drawing

''' <summary>
''' Import data from excel sheets with helper routines for to make advanced import
''' routines with associations and other entities
''' </summary>
Public Class FrmImportExcel
    Protected strTable As String
    Protected Repository As EA.Repository = DLA2EAHelper.GetRepository()
    Protected objDT As DataTable
    Protected objDS As DataSet
    Protected Normalizer As DLANormalizeDataTable
    Private Sub CreateExcelDataSet()
        Try
            Me.objDS = New DataSet("EXCEL")
            Dim objMappings As DataTable = New DataTable("Mappings")
            'validaties voor de verschillende interfaces in de integreator
            objMappings.Columns.Add(New DataColumn("MappingType", System.Type.GetType("System.String")))
            objMappings.Columns.Add(New DataColumn("MappingOrder", System.Type.GetType("System.Int16")))
            'objMappings.Columns.Add(New DataColumn("SourceTable", System.Type.GetType("System.String")))
            objMappings.Columns.Add(New DataColumn("SourceColumn", System.Type.GetType("System.String")))
            objMappings.Columns.Add(New DataColumn("SourceFilter", System.Type.GetType("System.String")))
            '        objMappings.Columns.Add(New DataColumn("TargetTable", System.Type.GetType("System.String")))
            objMappings.Columns.Add(New DataColumn("TargetColumn", System.Type.GetType("System.String")))
            objMappings.Columns.Add(New DataColumn("TargetFilter", System.Type.GetType("System.String")))
            objMappings.Columns.Add(New DataColumn("ObjectStereoType", System.Type.GetType("System.String")))
            objMappings.Columns.Add(New DataColumn("ConnectorStereoType", System.Type.GetType("System.String")))
            objMappings.Columns.Add(New DataColumn("ConnectorDirection", System.Type.GetType("System.String")))
            objMappings.Columns.Add(New DataColumn("Postfix", System.Type.GetType("System.String")))
            objMappings.Columns.Add(New DataColumn("Active", System.Type.GetType("System.Boolean")))
            objMappings.Columns.Add(New DataColumn("Description", System.Type.GetType("System.String")))
            Me.objDS.Tables.Add(objMappings)

            Dim objKeuzelijsten As DataTable = New DataTable("Keuzelijsten")
            objKeuzelijsten.Columns.Add(New DataColumn("Listname", System.Type.GetType("System.String")))
            objKeuzelijsten.Columns.Add(New DataColumn("Search", System.Type.GetType("System.String")))
            objKeuzelijsten.Columns.Add(New DataColumn("Description", System.Type.GetType("System.String")))
            Me.objDS.Tables.Add(objKeuzelijsten)
            'Fill in the defaults
            Me.AddCodelijst("MappingType", "FO", "Find Object")
            Me.AddCodelijst("MappingType", "FON", "Find Object by name")
            Me.AddCodelijst("MappingType", "FOT", "Find Object by Tagged value")
            Me.AddCodelijst("MappingType", "FPN", "Find Package by name")
            Me.AddCodelijst("MappingType", "PRO", "Element Property")
            Me.AddCodelijst("MappingType", "LPR", "Last Element Property")
            Me.AddCodelijst("MappingType", "TV", "Tagged Value")
            Me.AddCodelijst("MappingType", "OBJ", "Object")
            Me.AddCodelijst("MappingType", "LNK", "Connector")
            Me.AddCodelijst("MappingType", "OCO", "Object and Connector")
            Me.AddCodelijst("MappingType", "LCO", "Last Object and Connector")
            Me.AddCodelijst("MappingType", "ATT", "Attribute")
            Me.AddCodelijst("MappingType", "OBA", "Find Object and attribute")
            Me.AddCodelijst("MappingType", "FIL", "Linked file")
            Me.AddCodelijst("Direction", "Unspecified", "Unspecified")
            Me.AddCodelijst("Direction", "Bi-Directional", "Bi-Directional")
            Me.AddCodelijst("Direction", "Source -> Destination", "Source -> Destination")
            Me.AddCodelijst("Direction", "Destination -> Source", "Destination -> Source")

            Me.DataGridViewMappings.DataSource = Me.objDS
            Me.DataGridViewMappings.DataMember = "Mappings"
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Voeg een codelijst item toe zodat die gebruikt kunnen worden in de grids om het werk van de beheerder iets makkelijker te maken
    ''' </summary>
    ''' <param name="Name"></param>
    ''' <param name="Search"></param>
    ''' <param name="Description"></param>
    Sub AddCodelijst(Name As String, Search As String, Description As String)
        Try
            Dim oRow As DataRow
            oRow = Me.objDS.Tables("Keuzelijsten").NewRow()
            oRow("ListName") = Name
            oRow("Search") = Search
            oRow("Description") = Description
            Me.objDS.Tables("Keuzelijsten").Rows.Add(oRow)
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    Private Sub ButtonSelect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSelect.Click
        If RadioButtonExcel.Checked Then
            Me.OpenExcelFileDialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        Else
            Me.OpenExcelFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
        End If
        If OpenExcelFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.TextBoxExcelFile.Text = OpenExcelFileDialog.FileName
            Me.TextBoxClassName.Text = System.IO.Path.GetFileName(OpenExcelFileDialog.FileName).Replace(System.IO.Path.GetExtension(OpenExcelFileDialog.FileName), "")

            Dim strConnect As String = Me.TextBoxConnection.Text
            Me.TextBoxConnection.Text = strConnect.Replace("[FILE]", Me.TextBoxExcelFile.Text)
            CreateExcelDataSet()
            LoadData()
            LoadColumns2Mapping()

        End If
    End Sub

    Private Sub FrmImportExcel_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.OpenExcelFileDialog.FileName = ""
        Me.TextBoxConnection.Text = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=[FILE];Extended Properties=""Excel 12.0 Xml;HDR=YES"";"
        Me.Savetranslations()
    End Sub
    Public Sub Savetranslations()
        Dim oDefinities As New IDEADefinitions()
        oDefinities.FormControls2TransLations(Me.Name, Me.Controls, True)
    End Sub
    Private Sub LoadTableName()
        Dim objCon As OleDb.OleDbConnection

        Try
            objCon = New OleDb.OleDbConnection(Me.TextBoxConnection.Text)
            objCon.Open()

            Dim DT As DataTable
            DT = objCon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            Me.strTable = "[" & DT.Rows(Convert.ToInt16(Me.TextBoxTableNo.Text)).Item("TABLE_NAME").ToString() & "]"
            objCon.Close()
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub LoadData(ByVal sSql As String)
        Dim objCon As OleDb.OleDbConnection
        Try
            objCon = New OleDb.OleDbConnection(Me.TextBoxConnection.Text)
            objCon.Open()
            Dim objDA As New OleDb.OleDbDataAdapter(sSql, objCon)
            objDA.Fill(Me.objDS, "Objecten")
            Me.objDT = objDS.Tables("Objecten")
            DataGridViewExcel.DataSource = objDT
            '           DataGridViewExcel.DataMember = "Objecten"
            objCon.Close()
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    Private Sub LoadData()
        LoadTableName()
        LoadData("SELECT * FROM " & strTable)
    End Sub


    Sub LoadColumns2Mapping()
        Try
            For Each Col As DataColumn In Me.objDT.Columns
                Dim Row As DataRow
                Row = Me.objDS.Tables("Mappings").NewRow()
                Row("SourceColumn") = Col.ColumnName
                Row("Active") = True
                Me.objDS.Tables("Mappings").Rows.Add(Row)
            Next
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub LoadCSV()
        Me.objDT = DLA2EAHelper.ReadCsvFile(TextBoxExcelFile.Text)
    End Sub



    Private Sub ButtonLoad_Click(sender As Object, e As EventArgs)
        If RadioButtonExcel.Checked Then
            LoadTableName()
            LoadData()
        Else
            LoadCSV()
        End If

    End Sub

    Function GetFilteredTable(table As String, filter As String, Optional sort As String = "") As DataTable
        Dim oDV As DataView
        Try
            oDV = New DataView(Me.objDS.Tables(table))
            If sort.Length > 0 Then
                oDV.Sort = sort
            End If
            If filter.Length > 0 Then
                oDV.RowFilter = filter
            End If
            Return oDV.ToTable()
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
        Return Nothing
    End Function

    Private Sub DataGridViewMappings_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewMappings.CellClick
        Try
            If e.ColumnIndex > -1 Then
                Dim objDataTableDropbox As System.Windows.Forms.DataGridViewComboBoxCell = New System.Windows.Forms.DataGridViewComboBoxCell()

                If DataGridViewMappings.Columns(e.ColumnIndex).Name.Contains("MappingType") Then
                    objDataTableDropbox.DataSource = GetFilteredTable("Keuzelijsten", "ListName ='MappingType' ", "Description")
                    objDataTableDropbox.ValueMember = "Search"
                    objDataTableDropbox.DisplayMember = "Description"
                    objDataTableDropbox.Style.BackColor = Color.White
                    objDataTableDropbox.Style.SelectionBackColor = Color.White
                    DataGridViewMappings(e.ColumnIndex, e.RowIndex) = objDataTableDropbox
                End If
                If DataGridViewMappings.Columns(e.ColumnIndex).Name.Contains("ConnectorDirection") Then
                    objDataTableDropbox.DataSource = GetFilteredTable("Keuzelijsten", "ListName ='Direction' ", "Description")
                    objDataTableDropbox.ValueMember = "Search"
                    objDataTableDropbox.DisplayMember = "Description"
                    objDataTableDropbox.Style.BackColor = Color.White
                    objDataTableDropbox.Style.SelectionBackColor = Color.White
                    DataGridViewMappings(e.ColumnIndex, e.RowIndex) = objDataTableDropbox
                End If
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub ButtonExecute_Click(sender As Object, e As EventArgs) Handles ButtonExecute.Click
        'losse import repo
        Dim intTeller As Int16 = 0
        Dim blnFound As Boolean = False
        Dim objProces As New DataSet2Repository()

        Try
            If DLA2EAHelper.IsUserGroupMember(Repository, "Administrators") Then

                Me.ProgressBar.Value = 0
                ProgressBar.Minimum = 0
                ProgressBar.Maximum = Me.objDT.Rows.Count - 1
                ProgressBar.Step = 1
                objProces.Repository = Me.Repository
                objProces.Package_Id = Me.Repository.GetTreeSelectedPackage().PackageID
                Dim oRow As DataRow
                Dim blnFirst As Boolean = True
                Dim strMetaModel As String = ""
                Dim MappingDV As New DataView(objDS.Tables("Mappings"))
                MappingDV.RowFilter = "Active = TRUE"
                MappingDV.Sort = "MappingOrder, MappingType"
                For Each oRow In Me.objDT.Rows
                    Dim objDomein As EA.Element
                    For Each objMapRow As DataRow In MappingDV.ToTable.Rows
                        objDomein = objProces.ProcessMappingDefinitions(objMapRow, oRow, objDomein)
                    Next
                    Me.ProgressBar.PerformStep()
                Next
                objProces.CorrectArchiMateConnectors()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            DLA2EAHelper.Error2Log(ex)
        End Try
        Me.Repository.EnableUIUpdates = True
    End Sub

    Private Sub ButtonLoadDefinitions_Click(sender As Object, e As EventArgs) Handles ButtonLoadDefinitions.Click
        Me.OpenExcelFileDialog.Filter = "All files (*.*)|*.*"
        If OpenExcelFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.objDS.Clear()
            Me.objDS.ReadXml(OpenExcelFileDialog.FileName)
            Me.objDS.Tables("Objecten").Rows.Clear()
            LoadData()
        End If
    End Sub

    Private Sub ButtonSaveDefinitions_Click(sender As Object, e As EventArgs) Handles ButtonSaveDefinitions.Click
        Me.SaveFileDialogDef.Filter = "All files (*.*)|*.*"
        If SaveFileDialogDef.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.objDS.WriteXml(SaveFileDialogDef.FileName)
        End If
    End Sub

    Private Sub ButtonNormalizer_Click(sender As Object, e As EventArgs) Handles ButtonNormalizer.Click
        Me.Normalizer = New DLANormalizeDataTable()
        Me.Normalizer.Repository = Me.Repository
        Me.Normalizer.Percentage = Convert.ToInt32(Me.NumericUpDownPercentage.Value)
        Me.Normalizer.DataTable = Me.objDT
        Me.Normalizer.Optimize = Me.CheckBoxOptimize.Checked
        Me.DataGridViewNormalizer.DataSource = Normalizer.EvaluateDataTable(Me.ProgressBarNormalizer)
        Me.ComboBoxFields.DataSource = Me.DataGridViewNormalizer.DataSource
        Me.ComboBoxFields.DisplayMember = "FieldNames"
        Me.ComboBoxFields.ValueMember = "FieldNames"
        Me.ButtonCreateModel.Enabled = True
    End Sub

    Private Sub ComboBoxFields_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxFields.SelectedValueChanged
        Dim DV As New DataView(Me.objDT)
        Dim DistinctDT As DataTable
        Dim strVeldnaam As String
        Try
            strVeldnaam = Me.ComboBoxFields.SelectedValue
            DV.Sort = strVeldnaam
            DistinctDT = DV.ToTable(True, strVeldnaam.Split(","))
            Me.DataGridViewDistinctField.DataSource = DistinctDT
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ButtonCreateModel_Click(sender As Object, e As EventArgs) Handles ButtonCreateModel.Click
        Dim FieldNames As New List(Of String)
        Me.ProgressBarNormalizer.Maximum = 4
        Me.ProgressBarNormalizer.Value = 0
        Me.Normalizer.CreateRootElement(Me.TextBoxClassName.Text)
        Me.ProgressBarNormalizer.PerformStep()
        Me.Normalizer.CreateEnumerations()
        Me.ProgressBarNormalizer.PerformStep()
        Me.Normalizer.CreateFieldCombinations()
        Me.ProgressBarNormalizer.PerformStep()
        Me.Normalizer.CreateRootAttributes()
        Me.ProgressBarNormalizer.PerformStep()
    End Sub
End Class
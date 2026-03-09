Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports IDEA.DLAFormfactory


Public Class FrmModelAnalyser
    Protected ListofTitles As String = ""
    Protected oID As New IDEADefinitions()
    Private Sub ButtonAnalyse_Click(sender As Object, e As EventArgs) Handles ButtonAnalyse.Click
        ResetGraph()
        If RadioButtonManualstatement.Checked Then
            CreateGraph(TextBoxTitle.Text, ComboBoxGraphType.SelectedItem.ToString(), TextBoxSQL.Text, TextBoxTotal.Text, TextBoxGrouping.Text, TextBoxCategory.Text, CheckBox3DEnabled.Checked)
        Else
            ResetGraph()
            Dim strTitles As String = ""
            For Each oDGRow As DataGridViewRow In DataGridViewDefinedStatement.SelectedRows
                strTitles += ", " + oDGRow.Cells("GraphTitle").Value.ToString()
            Next
            Dim oDT As DataTable = oID.GetTable("DataAnalyser")
            For Each oRow As DataRow In oDT.Rows
                If strTitles.Contains(oRow("GraphTitle").ToString()) Then
                    CreateGraph(oRow("GraphTitle"), oRow("GraphType"), oRow("GraphStatement"), oRow("GraphTotal"), oRow("GraphGrouping"), oRow("GraphCategory"), IIf(IsDBNull(oRow("Graph3D")), False, oRow("Graph3D")))
                End If
            Next
        End If

    End Sub

    Sub ResetGraph()
        If CheckBoxReset.Checked = True Then
            Me.ChartAnalyse.Series.Clear()
            Me.ChartAnalyse.ChartAreas.Clear()
            Me.ListofTitles = ""
        End If

    End Sub

    Sub CreateGraph(Title As String, Type As String, Statement As String, Calculation As String, Grouping As String, Category As String, MultiDEnabled As Boolean)
        Dim oDT As DataTable = DLA2EAHelper.SQL2DataTable(Statement, DLA2EAHelper.GetRepository())
        Me.DataGridViewAnalyse.DataSource = oDT
        If Me.ListofTitles.Contains(Title) Then
            MsgBox("Title already in use, please rename title", MsgBoxStyle.OkOnly)
        Else
            If oDT.Columns.Count <= 3 Then
                CreateSimpleGraph(Title, Type, Statement, Calculation, Grouping, Category, MultiDEnabled)
            Else
                CreateMultiGraph(Title, Type, Statement, Calculation, Grouping, Category, MultiDEnabled)
            End If
        End If

    End Sub

    Sub CreateSimpleGraph(Title As String, Type As String, Statement As String, Calculation As String, Grouping As String, Category As String, MultiDEnabled As Boolean)
        Dim xVals(Me.DataGridViewAnalyse.DataSource.Rows.Count) As String
        Dim yVals(Me.DataGridViewAnalyse.DataSource.Rows.Count) As Int16
        Dim intTeller As Int16 = 0
        Dim ser As New Series(Title)
        Dim area As New ChartArea(Title)
        Try
            ser.ChartArea = Title
            area.Area3DStyle.Enable3D = MultiDEnabled
            Me.ChartAnalyse.ChartAreas.Add(area)
            Me.ListofTitles += " , " + Title
            Select Case Type.ToUpper()
                Case "PIE"
                    ser.ChartType = SeriesChartType.Pie
                Case "COLUMN"
                    ser.ChartType = SeriesChartType.Column
                Case Else
                    ser.ChartType = SeriesChartType.Bar
            End Select
            For Each oRow As DataRow In Me.DataGridViewAnalyse.DataSource.Rows
                xVals(intTeller) = oRow(Grouping).ToString()
                yVals(intTeller) = Convert.ToInt32(oRow(Calculation))
                intTeller += 1
            Next
            ser.Points.DataBindXY(xVals, yVals)
            ser.IsValueShownAsLabel = True
            ser.IsVisibleInLegend = True
            Me.ChartAnalyse.Series.Add(ser)
            Me.ChartAnalyse.Legends(0).Enabled = True
            Me.TabControlAnalyse.SelectTab(1)
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub

    Sub CreateMultiGraph(Title As String, Type As String, Statement As String, Calculation As String, Grouping As String, Category As String, MultiDEnabled As Boolean)
        Try
            Dim DV As New DataView(Me.DataGridViewAnalyse.DataSource)
            Dim area As New ChartArea(Title)
            Try
                area.Area3DStyle.Enable3D = MultiDEnabled
                Me.ChartAnalyse.ChartAreas.Add(area)

                Dim DistinctDT As DataTable
                DistinctDT = DV.ToTable(True, {Category})
                Dim GroupingDT As DataTable
                GroupingDT = DV.ToTable(True, {Grouping})

                For Each CatRow As DataRow In DistinctDT.Rows
                    Dim strCat As String = CatRow(Category)
                    Dim DVSubCat As New DataView(Me.DataGridViewAnalyse.DataSource)
                    DVSubCat.RowFilter = String.Format(" [{0}] = '{1}' ", Category, strCat)
                    Dim SubCatDT As DataTable = DVSubCat.ToTable()
                    Dim xVals(GroupingDT.Rows.Count) As String
                    Dim yVals(GroupingDT.Rows.Count) As Int16

                    Dim intTeller As Int16 = 0
                    Dim ser As New Series(strCat)

                    For Each oRow As DataRow In SubCatDT.Rows
                        xVals(intTeller) = oRow(Grouping).ToString()
                        yVals(intTeller) = Convert.ToInt32(oRow(Calculation))
                        intTeller += 1
                    Next

                    Me.ListofTitles += " , " + Title
                    'Dim area As New ChartArea(strCat)
                    'ChartAnalyse.ChartAreas.Add(area)
                    'ser.ChartArea = strCat
                    Select Case Type.ToUpper()
                        Case "STACKEDCOLUMN"
                            ser.ChartType = SeriesChartType.StackedColumn
                        Case "STACKEDBAR"
                            ser.ChartType = SeriesChartType.StackedBar
                        Case Else
                            ser.ChartType = SeriesChartType.StackedBar
                    End Select
                    ser.ChartType = SeriesChartType.StackedColumn
                    area.Axes(0).TextOrientation = TextOrientation.Rotated270
                    area.Axes(0).Interval = 1.0
                    'area.Axes(0).Title = "Demo"
                    ser.Points.DataBindXY(xVals, yVals)

                    ser.IsValueShownAsLabel = True
                    ser.IsVisibleInLegend = True
                    Me.ChartAnalyse.Series.Add(ser)
                Next
                Me.TabControlAnalyse.SelectTab(1)
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try


        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub
    Private Sub FrmModelAnalyser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBoxSQL.Text = "select count(*) as Total
, stereotype as grouping
, author as category
FROM t_object
GROUP BY stereotype, author"

        Dim GrapTypes As String() = {"Bar", "Column", "Pie", "StackedBar", "StackedColumn"}
        For Each type As String In GrapTypes
            ComboBoxGraphType.Items.Add(type)
        Next
        ComboBoxGraphType.SelectedIndex = 0

        Dim oDV As New DataView(oID.GetTable("DataAnalyser"))

        Me.DataGridViewDefinedStatement.DataSource = oDV.ToTable(False, {"GraphTitle", "Chapter", "Description"})
        Me.DataGridViewDefinedStatement.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewDefinedStatement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewDefinedStatement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub DataGridViewAnalyse_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewAnalyse.CellContentClick
        'Dim messageBoxVB As New System.Text.StringBuilder()
        'Dim oCol As DataGridViewColumn = DataGridViewAnalyse.Columns(e.ColumnIndex)
        'messageBoxVB.AppendFormat("{0} = {1}", "ColumnIndex", oCol.DataPropertyName)
        'messageBoxVB.AppendLine()
        'messageBoxVB.AppendFormat("{0} = {1}", "RowIndex", e.RowIndex)
        'messageBoxVB.AppendLine()
        'Dim oRow As DataGridViewRow = DataGridViewAnalyse.Rows(e.RowIndex)
        'messageBoxVB.AppendFormat("{0} = {1}", "RowValue", oRow.Cells(e.ColumnIndex).Value)
        'messageBoxVB.AppendLine()

        'MessageBox.Show(messageBoxVB.ToString(), "CellContentDoubleClick Event")
    End Sub

    Private Sub ButtonTableModel_Click(sender As Object, e As EventArgs) Handles ButtonTableModel.Click
        Dim oID As New IDEADefinitions()
        Dim oDT As DataTable = oID.GetTable("ArchiMaid")
        Dim strColumns As String = ""
        Dim strValues As String = ""
        Dim strCreateTable As String = ""
        Dim strText As String
        For Each oCol As DataColumn In oDT.Columns
            If strCreateTable.Length > 0 Then
                strCreateTable += ", " + vbCrLf
            End If
            strCreateTable += "[" + oCol.ColumnName + "]"
            strCreateTable += " varchar(250)"
            strCreateTable += " NULL"
            If strColumns.Length > 0 Then
                strColumns += ", "
            End If
            strColumns += "[" + oCol.ColumnName + "]"
        Next
        strText = "CREATE TABLE IDEA_METAMODEL ( " + vbCrLf + strCreateTable + " )"
        Dim strTotRows As String = ""
        For Each oRow As DataRow In oDT.Rows
            strValues = ""
            For Each oCol As DataColumn In oDT.Columns
                If strValues.Length > 0 Then
                    strValues += ", "
                End If
                strValues += "'" + oRow(oCol.ColumnName).ToString() + "'"
            Next
            strTotRows += IIf(strTotRows.Length > 0, ", ", "")
            strTotRows += "( " + strValues + " )" + vbCrLf
        Next
        strTotRows = strTotRows.Replace("''", "NULL")
        strText += vbCrLf + vbCrLf + "INSERT INTO IDEA_METAMODEL ( " + strColumns + " )" + vbCrLf + " VALUES " + strTotRows

        Clipboard.Clear()
        Clipboard.SetText(strText)
        MsgBox("Statements added to clipboard", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub RadioButtonDefinedStatement_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDefinedStatement.CheckedChanged
        EnablePanel()
    End Sub

    Sub EnablePanel()
        Me.PanelSelectStatement.Enabled = RadioButtonDefinedStatement.Checked
        Me.PanelManualStatement.Enabled = RadioButtonManualstatement.Checked
    End Sub

    Private Sub ButtonAddDefined_Click(sender As Object, e As EventArgs) Handles ButtonAddDefined.Click
        Dim oDT As DataTable = Me.oID.GetTable("DataAnalyser")
        Dim oRow As DataRow = oDT.NewRow()
        oRow("GraphTitle") = Me.TextBoxTitle.Text
        oRow("GraphType") = Me.ComboBoxGraphType.SelectedItem.ToString()
        oRow("GraphStatement") = Me.TextBoxSQL.Text
        oRow("GraphTotal") = Me.TextBoxTotal.Text
        oRow("GraphGrouping") = Me.TextBoxGrouping.Text
        oRow("GraphCategory") = Me.TextBoxCategory.Text
        oRow("Graph3D") = Me.CheckBox3DEnabled.Enabled
        oDT.Rows.Add(oRow)
        Me.oID.SaveDataAnalyser()
    End Sub
End Class

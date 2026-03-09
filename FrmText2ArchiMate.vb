Imports System.Windows.Forms
Imports IDEA.DLAFormfactory
Public Class FrmText2ArchiMate
    Private Repository As EA.Repository = DLA2EAHelper.GetRepository()
    Private Sub FrmText2ArchiMate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewArchitectureResult.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridViewArchitectureResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewArchitectureResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    Private Sub ButtonAnalyseText_Click(sender As Object, e As EventArgs) Handles ButtonAnalyseText.Click
        Try
            Dim DisplayKeywords As String = "0"
            If CheckBoxDisplayKeywords.Checked Then
                DisplayKeywords = "1"
            End If
            If CheckBoxRebuild.Checked Then
                Repository.Execute("EXECUTE [dbo].[IDEA_Architecture2Keywords]")
            End If
            Dim strSQL As String = String.Format("SELECT * FROM [dbo].[IDEA_Text2Table] ('{0}', {1})  WHERE hitcount > 1 ORDER BY hitcount desc", TextBoxArchitectureText.Text, DisplayKeywords)
            Dim ResultTable As DataTable = DLAFormfactory.DLA2EAHelper.SQL2DataTable(strSQL, Me.Repository)
            Dim oCol As DataColumn = New DataColumn("SelectItem", System.Type.GetType("System.Boolean"))
            oCol.DefaultValue = False
            oCol.Caption = "Select Item"
            ResultTable.Columns.Add(oCol)
            DataGridViewArchitectureResult.DataSource = ResultTable
            Dim strPivotSQL As String = String.Format("SELECT * FROM (SELECT value as keyword, t_object.name, Replace(t_object.stereotype, '_', '') as stereotype, count(t_object.object_id) as hitcount FROM  STRING_SPLIT(lower('{0}'), ' ') INNER JOIN IDEA_TAG ON value = IDEA_TAG.tagname INNER JOIN IDEA_TAGOBJECT ON IDEA_TAG.tag_id = IDEA_TAGOBJECT.tag_id INNER JOIN t_object ON IDEA_TAGOBJECT.ea_guid = t_object.ea_guid WHERE value NOT IN(SELECT IDEA_STOPWORD.stopword  FROM IDEA_STOPWORD) GROUP BY value, t_object.name, t_object.stereotype HAVING count(t_object.object_id) IS NOT NULL) As Keywordresult PIVOT (SUM(hitcount) FOR stereotype IN(ArchiMateBusinessRole,ArchiMateBusinessService,	ArchiMateBusinessProcess,ArchiMateBusinessObject,ArchiMateApplicationComponent,ArchiMateApplicationService,ArchiMateApplicationFunction,ArchiMateDataObject,ArchiMateTechnologyService,ArchiMateTechnologyFunction,ArchiMateNode,ArchiMateArtifact)  ) as PivotTable", TextBoxArchitectureText.Text, DisplayKeywords)
            Dim PivotResultTable As DataTable = DLAFormfactory.DLA2EAHelper.SQL2DataTable(strPivotSQL, Me.Repository)
            Me.DataGridViewPivotTable.DataSource = PivotResultTable
        Catch ex As Exception
            DLAFormfactory.DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub

    Private Sub ButtonAdd2Diagram_Click(sender As Object, e As EventArgs) Handles ButtonAdd2Diagram.Click
        Dim oDVRTX As System.Windows.Forms.DataGridViewTextBoxCell
        Dim objDiagram As EA.Diagram
        Dim intTop As Integer = -100
        Dim intLeft As Integer = 100
        Dim Generator As System.Random = New System.Random()
        Try

            objDiagram = Me.Repository.GetCurrentDiagram()
            If IsNothing(objDiagram) Or Me.DataGridViewArchitectureResult.Rows.Count = 0 Then
                MsgBox("Please select diagram or keywords first", MsgBoxStyle.OkOnly)
            Else
                Repository.CloseDiagram(objDiagram.DiagramID)
                For Each oDVR In Me.DataGridViewArchitectureResult.Rows
                    intTop = Generator.Next(-200, 0)
                    intLeft = Generator.Next(0, 200)
                    If Not IsDBNull(oDVR.Cells("SelectItem").Value) And oDVR.Cells("SelectItem").Value = True Then
                        oDVRTX = oDVR.Cells("object_id")
                        Dim objDON As EA.DiagramObject
                        Repository.WriteOutput("IDEA", oDVRTX.Value, 0)
                        objDON = objDiagram.DiagramObjects.AddNew("", "")
                        objDON.ElementID = oDVRTX.Value
                        objDON.top = intTop
                        objDON.bottom = intTop - 50
                        objDON.left = intLeft
                        objDON.right = intLeft + 120
                        objDON.ShowNotes = False
                        objDON.Update()
                        objDiagram.Update()
                        intLeft += 20
                        intTop -= 20
                    End If
                Next
                Repository.OpenDiagram(objDiagram.DiagramID)
                '            Repository.ReloadDiagram(objDiagram.DiagramID)
            End If
        Catch ex As Exception
            DLAFormfactory.DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
End Class
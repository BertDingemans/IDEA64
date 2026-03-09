Imports System.Windows.Forms
Imports System.Drawing
Imports IDEA.DLAFormfactory

''' <summary>
''' Form for displaying the elements that are duplicate in the repository. Give a
''' warning and eventually add the duplicate element to the diagram.
''' </summary>
Public Class FrmUniqueElement
    Protected Repository As EA.Repository
    Protected Element As EA.Element
    ''' <summary>
    ''' Set the element and do a check if the element is unique
    ''' </summary>
    ''' <param name="oElement"></param>
    ''' <param name="oRepo"></param>
    ''' <returns></returns>
    Public Function SetElement(ByVal oElement As EA.Element, ByVal oRepo As EA.Repository) As Boolean
        Dim sSql As String
        Dim HasData As Boolean = False
        Dim oDef As New IDEADefinitions()

        Me.Repository = oRepo
        Me.Element = oElement
        If My.Settings.SuppresWarningDialog = False Then
            sSql = oDef.GetSettingValue("DeduplicateElementElement")
            sSql = Replace(sSql, "#object_id#", oElement.ElementID)
            Dim oDT As DataTable
            oDT = DLA2EAHelper.EAString2DataTable(oRepo.SQLQuery(sSql))
            If oDT.Rows.Count < 1 Then
                HasData = False
            Else
                Me.UniqueDataGridView.DataSource = oDT
                Me.UniqueDataGridView.AutoResizeColumns()
                HasData = True
                Dim column As New DataGridViewCheckBoxColumn()
                With column
                    .HeaderText = "Add to diagram"
                    .Name = "Add2Diagram"
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .FlatStyle = FlatStyle.Standard
                    .CellTemplate = New DataGridViewCheckBoxCell()
                End With
                Me.UniqueDataGridView.Columns.Insert(0, column)
                Me.UniqueDataGridView.Columns("origid").Visible = False
                Me.UniqueDataGridView.Columns("duplid").Visible = False
            End If
            If Me.Element.Stereotype.Contains("Archi") Then
                Dim oArchiDT As DataTable
                oArchiDT = oDef.GetTable("ArchiMaid")

                Me.DataGridViewMetamodel.DataSource = oArchiDT
                Me.DataGridViewMetamodel.Columns("package_guid").Visible = False

                Me.DataGridViewMetamodel.AutoResizeColumns()
                Dim oStereoTypeView As New DataView(oArchiDT)
                oStereoTypeView.RowFilter = String.Format("Stereotype ='{0}' And Active = True ", Element.Stereotype)
                If oStereoTypeView.ToTable().Rows.Count = 0 Then
                    Me.LabelMetaModel.Visible = True
                    Me.ColorDiagramObject(505)
                    Me.TabControlValidator.SelectTab("Metamodel")
                    HasData = True
                Else
                    Me.LabelMetaModel.Visible = False
                End If
            End If

        End If
        Return HasData
    End Function
    ''' <summary>
    ''' Color a duplicate element background to read to give a warning color
    ''' </summary>
    ''' <param name="color"></param>
    Private Sub ColorDiagramObject(color As Int32)
        Dim objDO As EA.DiagramObject
        Dim objDiagram As EA.Diagram

        objDiagram = Repository.GetCurrentDiagram()
        For Each objDO In objDiagram.DiagramObjects
            If objDO.ElementID = Me.Element.ElementID Then
                objDO.BackgroundColor = color
            End If
            objDO.Update()
        Next

    End Sub
    ''
    Private Sub ButtonAdd2Diagram_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAdd2Diagram.Click
        Dim objDiagram As EA.Diagram
        Dim oDVRTX As System.Windows.Forms.DataGridViewTextBoxCell
        Dim intTop As Integer = -100
        Dim intLeft As Integer = 100
        Try
            objDiagram = Me.Repository.GetCurrentDiagram()
            If Not IsNothing(objDiagram) Then
                Me.ColorDiagramObject(500)
                For Each oDVR In Me.UniqueDataGridView.Rows
                    If oDVR.Cells("Add2Diagram").Value = True Then
                        intLeft += 150
                        intTop -= 70
                        oDVRTX = oDVR.Cells("duplid")
                        Dim objDON As EA.DiagramObject
                        objDON = objDiagram.DiagramObjects.AddNew("", "")
                        objDON.ElementID = oDVRTX.Value
                        objDON.top = intTop
                        objDON.bottom = intTop - 50
                        objDON.left = intLeft - 50
                        objDON.right = intLeft + 120
                        objDON.ShowNotes = False
                        objDON.Update()
                        objDiagram.Update()

                    End If
                Next
                Repository.SaveDiagram(objDiagram.DiagramID)
                Repository.ReloadDiagram(objDiagram.DiagramID)
            End If
            Me.Close()
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Execute a deduplication action in the current diagram
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonDeduplicate_Click(sender As Object, e As EventArgs)
        Dim oDVRTX As System.Windows.Forms.DataGridViewTextBoxCell
        For Each oDVR In Me.UniqueDataGridView.Rows
            Dim oWnd As New FrmElementDeduplicator()
            If oDVR.Cells("Add2Diagram").Value = True Then
                oDVRTX = oDVR.Cells("origid")
                oWnd.Element = Me.Element
                oWnd.SetDuplicateValue(oDVR.Cells("duplid").ToString())
                oWnd.Show()
                Me.Close()
            End If
        Next
    End Sub
    ''' <summary>
    ''' Find the original element in the browser
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub ButtonFindOriginal_Click(sender As Object, e As EventArgs) Handles ButtonFindOriginal.Click
        Dim oDVRTX As System.Windows.Forms.DataGridViewTextBoxCell
        Try
            oDVRTX = Me.UniqueDataGridView.CurrentRow.Cells("origid")
            Repository.ShowInProjectView(Me.Repository.GetElementByID(oDVRTX.Value))
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Find the duplicate element in the browser
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonFindDuplicate_Click(sender As Object, e As EventArgs) Handles ButtonFindDuplicate.Click
        Dim oDVRTX As System.Windows.Forms.DataGridViewTextBoxCell
        Try
            oDVRTX = Me.UniqueDataGridView.CurrentRow.Cells("duplid")
            Repository.ShowInProjectView(Me.Repository.GetElementByID(oDVRTX.Value))
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub FrmUniqueElement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
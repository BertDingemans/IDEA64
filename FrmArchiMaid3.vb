Imports IDEA.DLAFormfactory
Imports System.Windows.Forms
Imports System.Drawing
Imports EA
Imports System.Reflection.Emit
Imports System.Security.Cryptography.X509Certificates

Public Class FrmArchiMaid3
    Protected oDefinitions As IDEADefinitions = New IDEADefinitions()
    Protected oRepository As EA.Repository = DLA2EAHelper.GetRepository()
    Protected EmbedDT As New DataTable("Embed")
    Protected PathDT As New DataTable("Paths")
    Protected Diagram_id As Int16 = -999


    Private Sub FrmArchiMaid3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDT As DataTable = Me.oDefinitions.GetFilteredTable("ArchiMaid", "Active = True")
        Dim DV As New DataView(oDT)
        Dim DistinctColumn As DataTable

        If IsNothing(DLA2EAHelper.GetRepository().GetCurrentDiagram()) Then
            Me.ToolStripButtonAddDiagram.Enabled = False
            MsgBox("No diagram open, limited functionality", vbOK)
        Else
            Me.Diagram_id = DLA2EAHelper.GetRepository().GetCurrentDiagram().DiagramID
        End If

        LoadImageList()
        DistinctColumn = DV.ToTable(True, {"Column"})
        Me.ComboBoxColumn.Items.Add("{ All }")
        For Each Row As DataRow In DistinctColumn.Rows
            Me.ComboBoxColumn.Items.Add(Row("Column"))
        Next
        Dim DistinctLayer As DataTable
        Me.ComboBoxLayer.Items.Add("{ All }")
        DistinctLayer = DV.ToTable(True, {"Layer"})
        For Each Row As DataRow In DistinctLayer.Rows
            Me.ComboBoxLayer.Items.Add(Row("Layer"))
        Next
        Me.ComboBoxColumn.SelectedText = "{ All }"
        Me.ComboBoxLayer.SelectedText = "{ All }"
        LoadListView()
        Me.ToolStripButtonSearch.Select()
        If Me.Diagram_id > 0 Then
            Me.ListBoxEnd.DataSource = DLA2EAHelper.EAString2DataTable(oRepository.SQLQuery(String.Format("SELECT t_object.object_id, t_object.name FROM t_object, t_diagramobjects WHERE t_object.object_id = t_diagramobjects.object_id AND t_diagramobjects.diagram_id = {0} ORDER BY name", Diagram_id)))
            Me.ListBoxEnd.DisplayMember = "name"
            Me.ListBoxEnd.ValueMember = "object_id"
            Me.ListBoxStart.DataSource = DLA2EAHelper.EAString2DataTable(oRepository.SQLQuery(String.Format("SELECT t_object.object_id, t_object.name FROM t_object, t_diagramobjects WHERE t_object.object_id = t_diagramobjects.object_id AND t_diagramobjects.diagram_id = {0} ORDER BY name", Diagram_id)))
            Me.ListBoxStart.DisplayMember = "name"
            Me.ListBoxStart.ValueMember = "object_id"
        End If

    End Sub

    ''' <summary>
    ''' Load the imagelist of the archimate symbols with a trick from the resources of the addon
    ''' </summary>
    Sub LoadImageList()
        Dim oDT As DataTable = Me.oDefinitions.GetFilteredTable("ArchiMaid", "Active = True")
        Dim stereotype As String

        For Each row As DataRow In oDT.Rows

            Try
                stereotype = row("Stereotype").ToString().Trim()
                Me.ImageListStereoType.Images.Add(stereotype, My.Resources.ResourceManager.GetObject(stereotype))
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
        Next
    End Sub
    ''' <summary>
    ''' Load the listview of selected archimate element stereotypes for the search window
    ''' </summary>
    Sub LoadListView()
        Dim oDT As DataTable = Me.oDefinitions.GetFilteredTable("ArchiMaid", "Active = True")
        Dim DV As New DataView(oDT)
        'Me.ListViewStereoType.View = View.List
        Dim StereoTypeDT As DataTable
        Dim strFilter = ""
        ListViewStereoType.Items.Clear()
        If Me.ComboBoxColumn.Text <> "{ All }" Then
            strFilter = String.Format(" Column = '{0}' ", ComboBoxColumn.Text)
        End If
        If Me.ComboBoxLayer.Text <> "{ All }" Then
            If strFilter.Length > 0 Then
                strFilter += " And "
            End If
            strFilter += String.Format(" Layer = '{0}' ", ComboBoxLayer.Text)
        End If
        DV.RowFilter = strFilter
        StereoTypeDT = DV.ToTable
        For Each Row As DataRow In StereoTypeDT.Rows
            Dim oLI As ListViewItem = New ListViewItem(Row("Stereotype").ToString())
            oLI.Checked = True
            oLI.ToolTipText = Row("Documentation").ToString()
            Me.ListViewStereoType.SmallImageList = Me.ImageListStereoType
            Me.ListViewStereoType.LargeImageList = Me.ImageListStereoType

            oLI.ImageKey = Row("Stereotype").ToString()
            Me.ListViewStereoType.Items.Add(oLI)
        Next
        Me.TabControl1.SelectTab(0)

    End Sub
    Private Sub ComboBoxLayer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLayer.SelectedIndexChanged
        LoadListView()
    End Sub
    Private Sub ComboBoxColumn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxColumn.SelectedIndexChanged
        LoadListView()
    End Sub
    Private Sub ToolStripMenuILargeIcon_Click(sender As Object, e As EventArgs) Handles ToolStripMenuILargeIcon.Click
        Me.ListViewStereoType.View = View.LargeIcon
    End Sub
    Private Sub ToolStripMenuItemList_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemList.Click
        Me.ListViewStereoType.View = View.List
    End Sub
    Private Sub ToolStripMenuItemSmallIcon_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSmallIcon.Click
        Me.ListViewStereoType.View = View.SmallIcon
    End Sub
    Private Sub ToolStripButtonSearch_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSearch.Click
        DoSearch()
        Me.TabControl1.SelectTab(0)

    End Sub
    ''' <summary>
    ''' Construct the sql statement for the search based on the various controls and selected values in the aid screen
    ''' </summary>
    Private Sub DoSearch()
        Dim strSql As String
        oRepository.CreateOutputTab("IDEA")
        strSql = "Select t_object.name as object_name, t_object.alias, t_package.name as package, t_object.stereotype, t_object.status, t_object.author, t_object.object_id " +
        "FROM t_object, t_package " +
        "WHERE t_object.package_id = t_package.package_id " +
        "AND t_object.stereotype IN(#stereotypes#) "
        If Me.ToolStripTextBoxSearch.Text.Length > 0 Then
            strSql += "AND ( t_object.name Like '%#search#%' OR  t_object.alias Like '%#search#%' ) "
        End If
        strSql += "ORDER BY t_object.stereotype, t_object.name "
        If oRepository.RepositoryType.ToUpper() = "JET" Then
            strSql = strSql.Replace("%", "*")
        End If
        Dim strStereo As String = "'-999'"
        For Each item As ListViewItem In Me.ListViewStereoType.Items
            If item.Checked Then
                strStereo += ", '" + item.Text + "'"
            End If
        Next
        strSql = strSql.Replace("#stereotypes#", strStereo).Replace("#search#", Me.ToolStripTextBoxSearch.Text)
        oRepository.WriteOutput("IDEA", strSql, 0)
        Dim oDataTable As DataTable
        Me.DataGridViewResult.DataSource = Nothing
        oDataTable = DLA2EAHelper.EAString2DataTable(oRepository.SQLQuery(strSql))
        DataGridViewResult.DataSource = oDataTable
        If DataGridViewResult.Columns.Count() > 0 Then
            DataGridViewResult.Columns("object_id").Visible = False
            DataGridViewResult.AutoResizeColumns()
        End If

        Me.ToolStripButtonAddDiagram.Enabled = True
    End Sub
    ''' <summary>
    ''' Add the selected elements in the grid to the currently active diagram
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolStripButtonAddDiagram_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAddDiagram.Click
        Add2Diagram()
    End Sub

    Private Sub ToolStripTextBoxSearch_Enter(sender As Object, e As EventArgs) Handles ToolStripTextBoxSearch.Enter
        Add2Diagram()
    End Sub
    Private Sub Add2Diagram()
        Dim oDVRTX As System.Windows.Forms.DataGridViewTextBoxCell
        Dim objDiagram As EA.Diagram
        Dim intTop As Integer = -100
        Dim intLeft As Integer = 100
        Dim Generator As System.Random = New System.Random()
        Try
            If Me.Diagram_id > 0 Then
                objDiagram = Me.oRepository.GetCurrentDiagram()
                Me.oRepository.EnableUIUpdates = False
                For Each oDVR In Me.DataGridViewResult.SelectedRows
                    intTop = Generator.Next(-200, 0)
                    intLeft = Generator.Next(0, 200)
                    oDVRTX = oDVR.Cells("object_id")
                    Dim objDON As EA.DiagramObject
                    oRepository.WriteOutput("IDEA", oDVRTX.Value, 0)
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
                Next
                oRepository.SaveDiagram(objDiagram.DiagramID)
                Me.oRepository.EnableUIUpdates = True
                oRepository.ReloadDiagram(objDiagram.DiagramID)
            End If

        Catch ex As Exception
            oRepository.WriteOutput("IDEA", ex.Message, 0)
        End Try
    End Sub
    Private Sub ToolStripTextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBoxSearch.TextChanged
        DoSearch()
    End Sub

    Private Sub ToolStripButtonDisplayEmbed_Click(sender As Object, e As EventArgs) Handles ToolStripButtonDisplayEmbed.Click
        Dim Diagram As EA.Diagram
        Dim objDL As EA.DiagramLink
        Dim objDOTarget, objDOSource As EA.DiagramObject
        Dim blnOpenDiagram As Boolean = False
        Dim selectedConnector As EA.Connector
        Dim targetID, sourceID
        Dim strElementIDs As String = ""
        Try

            If Me.EmbedDT.Columns.Count = 0 Then
                EmbedDT.Columns.Add(New DataColumn("Parent"))
                EmbedDT.Columns.Add(New DataColumn("Child"))
                EmbedDT.Columns.Add(New DataColumn("ConnectorType"))
                EmbedDT.Columns.Add(New DataColumn("ParentID"))
                EmbedDT.Columns.Add(New DataColumn("ChildID"))
            Else
                EmbedDT.Rows.Clear()
            End If
            Dim strObjects As String = ""

            Diagram = Me.oRepository.GetCurrentDiagram()
            Me.oRepository.SaveDiagram(Diagram.DiagramID)
            If Not Diagram Is Nothing Then
                ' Get a reference to any selected connector/objects
                TabControl1.SelectTab(1)
                For Each objDOTarget In Diagram.DiagramObjects
                    If Not strElementIDs.Contains(objDOTarget.ElementID.ToString()) Then
                        strElementIDs += objDOTarget.ElementID.ToString() + ";"
                        For Each objDOSource In Diagram.DiagramObjects
                            If objDOSource.ElementID <> objDOTarget.ElementID Then
                                If (objDOTarget.top >= objDOSource.top And objDOTarget.bottom <= objDOSource.bottom And objDOTarget.left <= objDOSource.left And objDOTarget.right >= objDOSource.right) Then
                                    Dim oRow As DataRow = EmbedDT.NewRow()
                                    oRow("Parent") = oRepository.GetElementByID(objDOTarget.ElementID).Name
                                    oRow("ParentID") = objDOTarget.ElementID
                                    oRow("Child") = oRepository.GetElementByID(objDOSource.ElementID).Name
                                    oRow("ChildID") = objDOSource.ElementID
                                    For Each objDL In Diagram.DiagramLinks
                                        selectedConnector = oRepository.GetConnectorByID(objDL.ConnectorID)
                                        If ((objDOSource.ElementID = selectedConnector.SupplierID And objDOTarget.ElementID = selectedConnector.ClientID) Or
                                        (objDOTarget.ElementID = selectedConnector.SupplierID And objDOSource.ElementID = selectedConnector.ClientID)) Then
                                            oRow("ConnectorType") = selectedConnector.Stereotype
                                        End If
                                    Next
                                    EmbedDT.Rows.Add(oRow)
                                End If
                            End If
                        Next
                    End If
                Next
                oRepository.WriteOutput("IDEA", "Assocations Processed!! ", 0)
                Me.DataGridViewEmbed.DataSource = EmbedDT
                Me.DataGridViewEmbed.Columns("parentid").Visible = False
                Me.DataGridViewEmbed.Columns("childid").Visible = False
            End If

        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub ToolStripButtonCreateEmbedded_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCreateEmbedded.Click
        Dim objCon As EA.Connector
        Dim objEle As EA.Element
        Dim strNaam As String = ""
        Dim Diagram As EA.Diagram
        Dim strType, strStereotype As String
        Dim strSourceIsAggregate As String = "0"

        Diagram = Me.oRepository.GetCurrentDiagram()
        Try
            For Each oRow In Me.EmbedDT.Rows
                If oRow("ConnectorType").ToString().Length = 0 Then
                    If RadioButtonAggregation.Checked Then
                        strType = "Association"
                        strSourceIsAggregate = "1"
                        strStereotype = "ArchiMate_Aggregation"
                    ElseIf RadioButtonComposition.Checked Then
                        strType = "Association"
                        strSourceIsAggregate = "2"
                        strStereotype = "ArchiMate_Composition"
                    ElseIf RadioButtonAssignment.Checked Or RadioButtonAssignmentfrom.Checked Then
                        strType = "Association"
                        strStereotype = "ArchiMate_Assignment"
                    ElseIf RadioButtonSpecialization.Checked Then
                        strType = "Generalization"
                        strStereotype = "ArchiMate_Specialization"
                    End If
                    objEle = oRepository.GetElementByID(oRow("ChildID"))
                    objCon = objEle.Connectors.AddNew(strNaam, strType)
                    If Me.RadioButtonAssignmentfrom.Checked Then
                        objCon.SupplierID = oRow("ChildID")
                        objCon.ClientID = oRow("ParentID")
                    Else
                        objCon.SupplierID = oRow("ParentID")
                        objCon.ClientID = oRow("ChildID")
                    End If
                    objCon.Direction = "Unspecified"
                    objCon.Stereotype = strStereotype
                    objCon.Update()
                    If strSourceIsAggregate <> "0" Then
                        Dim strUpdate As String = String.Format("Update t_connector set DestIsAggregate = {0} where connector_id = {1}", strSourceIsAggregate, objCon.ConnectorID.ToString())
                        DLA2EAHelper.GetRepository().Execute(strUpdate)
                    End If
                End If
            Next
            Me.oRepository.ReloadDiagram(Diagram.DiagramID)
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
        Me.Close()
    End Sub
    Private Sub DeriveArchiMate()

        PathDT = New DataTable("Path")
        PathDT.Columns.Add(New DataColumn("path"))
        PathDT.Columns.Add(New DataColumn("relationship"))
        PathDT.Columns.Add(New DataColumn("documentation"))
        PathDT.Columns.Add(New DataColumn("connectorpath"))

        PathDT.Columns.Add(New DataColumn("status"))

        DataGridViewDerive.DataSource = PathDT
        If Not IsNothing(ListBoxStart.SelectedValue) And Not IsNothing(ListBoxEnd.SelectedValue) Then
            Dim oPathStartRow As DataRow = Me.PathDT.NewRow()
            oPathStartRow("Path") = ListBoxStart.SelectedValue
            oPathStartRow("Relationship") = ""
            oPathStartRow("Connectorpath") = "-999"

            oPathStartRow("Documentation") = Me.oRepository.GetElementByID(ListBoxStart.SelectedValue).Name
            Dim strPath As String = oPathStartRow("Path")
            If ProcessPath(oPathStartRow, ListBoxStart.SelectedValue) Then

            End If
            If Me.DataGridViewDerive.Columns.Count > 0 Then
                Me.DataGridViewDerive.Columns("path").Visible = False
                Me.DataGridViewDerive.Columns("connectorpath").Visible = False

            End If
        Else
            MsgBox("Please select a start and end entity", MsgBoxStyle.OkOnly)
        End If

    End Sub

    Private Function ProcessPath(ParentRow As DataRow, object_id As String) As Boolean
        Dim blnTraverse As Boolean = True
        Dim ArchiMateConnectors As String() =
        {"ArchiMate_Association",
        "ArchiMate_Flow",
        "ArchiMate_Triggering",
        "ArchiMate_Influence",
        "ArchiMate_Access",
        "ArchiMate_Serving",
        "ArchiMate_Realization",
        "ArchiMate_Assignment",
        "ArchiMate_Aggregation",
        "ArchiMate_Composition",
        "ArchiMate_Specialization"}

        Dim strSql As String = "SELECT t_object.name, t_connector.stereotype, t_object.object_id, t_connector.connector_id
                                FROM t_object, t_diagramlinks, t_connector
                                WHERE t_diagramlinks.diagramid = {1}
                                AND t_diagramlinks.connectorid = t_connector.connector_id
                                AND t_diagramlinks.hidden = 0
                                AND t_connector.start_object_id = t_object.object_id
                                AND t_connector.end_object_id = {0}
                                UNION
                                SELECT t_object.name, t_connector.stereotype, t_object.object_id, t_connector.connector_id
                                FROM t_object, t_diagramlinks, t_connector
                                WHERE t_diagramlinks.diagramid = {1}
                                AND t_diagramlinks.connectorid = t_connector.connector_id
                                AND t_diagramlinks.hidden = 0
                                AND t_connector.end_object_id = t_object.object_id
                                AND t_connector.start_object_id = {0} "

        Dim strCurrentSQL As String = String.Format(strSql, object_id, Me.Diagram_id)
        Dim oDT As DataTable = DLA2EAHelper.SQL2DataTable(strCurrentSQL, Me.oRepository)
        Dim oRow As DataRow
        Dim FirstStereotype As String
        For Each oRow In oDT.Rows
            FirstStereotype = ParentRow("relationship")
            Dim strStereoType As String = oRow("StereoType")
            Dim NewRow As DataRow = Me.PathDT.NewRow()
            Dim strPath As String = ParentRow("Path")
            If strPath.Contains(oRow("object_id")) = False Then
                NewRow("Path") = strPath + ", " + oRow("object_id")
                NewRow("Documentation") = ParentRow("Documentation") + " - " + oRow("stereotype") + " - " + oRow("name")
                NewRow("ConnectorPath") = ParentRow("ConnectorPath") + ", " + oRow("connector_id")
                If FirstStereotype.Length = 0 Then
                    NewRow("Relationship") = oRow("stereotype")
                    FirstStereotype = oRow("stereotype")
                Else
                    Dim intCurrent As Int16 = Array.IndexOf(ArchiMateConnectors, FirstStereotype)
                    Dim intNext As Int16 = Array.IndexOf(ArchiMateConnectors, strStereoType)
                    If intCurrent > intNext Then
                        NewRow("Relationship") = oRow("stereotype")
                        FirstStereotype = oRow("stereotype")
                    Else
                        NewRow("Relationship") = FirstStereotype
                    End If
                End If
                Me.PathDT.Rows.Add(NewRow)
                If oRow("object_id") = Me.ListBoxEnd.SelectedValue Then
                    NewRow("status") = "Complete"
                    Return True
                Else
                    NewRow("Status") = "Incomplete"
                End If
                ProcessPath(NewRow, oRow("object_id"))
            End If
        Next
        Return True
    End Function
    Private Sub ToolStripButtonDerive_Click(sender As Object, e As EventArgs) Handles ToolStripButtonDerive.Click
        TabControl1.SelectTab(2)
        DeriveArchiMate()
        If Me.CheckBoxShowInComplete.Checked = False Then
            Dim DV As New DataView(Me.PathDT)
            DV.RowFilter = "status = 'Complete' "
            Me.DataGridViewDerive.DataSource = DV.ToTable()
        End If
    End Sub

    Private Sub ToolStripButtonProcessDerive_Click(sender As Object, e As EventArgs) Handles ToolStripButtonProcessDerive.Click
        ProcessDerive()
    End Sub

    Sub ProcessDerive()
        For Each oDVR In Me.DataGridViewDerive.SelectedRows
            Dim strConnectors As String = oDVR.Cells("connectorpath").Value
            Dim strStereotype As String = oDVR.Cells("relationship").Value
            Dim strUpdate As String = String.Format("UPDATE t_diagramlinks SET hidden = -1
                                      WHERE connectorid IN({0}) AND diagramid = {1} ", strConnectors, Me.Diagram_id)
            Me.oRepository.Execute(strUpdate)
            Dim oElement As EA.Element
            oElement = Me.oRepository.GetElementByID(Me.ListBoxStart.SelectedValue)
            Dim oConnector As EA.Connector
            oConnector = oElement.Connectors.AddNew("Derive", Me.StereoType2ConnectorType(strStereotype))
            oConnector.SupplierID = Me.ListBoxEnd.SelectedValue
            oConnector.ClientID = Me.ListBoxStart.SelectedValue
            oConnector.Stereotype = strStereotype
            oConnector.Direction = "Source -> Destination"
            oConnector.Update()
        Next
        Me.oRepository.RefreshOpenDiagrams(True)

    End Sub

    Function StereoType2ConnectorType(StereoType As String) As String

        Select Case StereoType.ToUpper().Replace("ARCHIMATE_", "")
            Case "TRIGGERING", "FLOW"
                Return "ControlFlow"
            Case "SPECIALIZATION"
                Return "Generalization"
            Case "ACCESS", "REALIZATION", "INFLUENCE"
                Return "Dependency"
            Case Else
                Return "Association"
        End Select
    End Function
End Class



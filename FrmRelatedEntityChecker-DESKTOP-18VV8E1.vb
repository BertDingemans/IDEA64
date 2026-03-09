Imports IDEA.DLAFormfactory
Imports System.Drawing
Imports System.Windows.Forms
Public Class FrmRelatedEntityChecker
    Private Repository As EA.Repository = DLA2EAHelper.GetRepository()
    Protected strPackageSQL As String =
        "SELECT 'Element'as EntityType
    , Original.name as original_name
    , Related.name as related_element
    , Related.status as status_related
    , t_package.name as related_package
    FROM t_object as Original 
    ,t_connector 
    ,t_object as Related 
    ,t_package
    WHERE original.Package_ID IN({0})
    AND related.Package_ID NOT IN({0})
    AND t_connector.Start_Object_ID = original.Object_ID
    AND t_connector.End_Object_ID = related.Object_ID
    AND related.Package_ID = t_package.Package_ID
    UNION
    SELECT 'Element'as EntityType
    , Original.name as original_name
    , Related.name as related_element
    , Related.status as status_related
    , t_package.name as related_package
    FROM t_object as Original 
    ,t_connector 
    ,t_object as Related 
    ,t_package
    WHERE original.Package_ID IN({0})
    AND related.Package_ID NOT IN({0})
    AND t_connector.End_Object_ID = original.Object_ID
    AND t_connector.Start_Object_ID = related.Object_ID
    AND related.Package_ID = t_package.Package_ID
	UNION
    SELECT 'Diagram'as EntityType
    , Original.name as original_name
    , t_diagram.name as related_element
    , 'unknown' as status_related
    , t_package.name as related_package
    FROM t_object as Original 
    ,t_diagramobjects 
    ,t_diagram  
    ,t_package 
    WHERE original.Package_ID IN({0})
    AND t_diagram.Package_ID NOT IN({0})
    AND t_diagramobjects.diagram_ID = t_diagram.diagram_ID
    AND t_diagram.Package_ID = t_package.Package_ID
    AND t_diagramobjects.Object_ID = original.Object_ID
    ORDER BY 4,1,2,3"

    Protected strElementSQL As String =
        "SELECT 'Element'as EntityType
    , Original.name as original_name
    , Related.name as related_element
    , Related.status as status_related
    , t_package.name as related_package
    FROM t_object as Original 
    , t_connector 
    , t_object as Related 
    , t_package 
    WHERE original.Object_ID IN({0})
    AND related.object_ID NOT IN({0})
    AND t_connector.Start_Object_ID = original.Object_ID
    AND t_connector.End_Object_ID = related.Object_ID
    AND related.Package_ID = t_package.Package_ID
    UNION
    SELECT 'Element'as EntityType
    , Original.name as original_name
    , Related.name as related_element
    , Related.status as status_related
    , t_package.name as related_package
    FROM t_object as Original 
    , t_connector 
    , t_object as Related 
    , t_package 
    WHERE original.Object_ID IN({0})
    AND related.Object_ID NOT IN({0})
    AND t_connector.End_Object_ID = original.Object_ID
    AND t_connector.Start_Object_ID = related.Object_ID
    AND related.Package_ID = t_package.Package_ID
	UNION
    SELECT 'Diagram'as EntityType
    , Original.name as original_name
    , t_diagram.name as related_element
    , 'Unknown' as status_related
    , t_package.name as related_package
    FROM t_object as Original 
    , t_diagramobjects 
    , t_diagram 
    , t_package 
    WHERE original.Object_ID IN({0})
    AND t_diagram.Package_ID <> original.package_ID
    AND t_diagramobjects.Object_ID = original.Object_ID
    AND t_diagramobjects.diagram_ID = t_diagram.diagram_ID
    AND t_diagram.Package_ID = t_package.Package_ID
    ORDER BY 4,1,2,3"
    Public ReadOnly Property ContinueOperation
        Get
            Return CheckBoxContinue.Checked
        End Get

    End Property
    Function SetPackage(oPackage As EA.Package) As Boolean
        Dim strPackages As String = "-999" + DLA2EAHelper.PackageTree2String(oPackage)
        Dim strSql As String = String.Format(Me.strPackageSQL, strPackages)
        Dim oDT As DataTable = DLA2EAHelper.SQL2DataTable(strSql, Me.Repository)
        Dim blnDataFound As Boolean = False
        If oDT.Rows.Count > 0 Then
            Me.Text = Me.Text + " for " + oPackage.Name
            Me.DataGridViewEntityChecker.DataSource = oDT
            ColorGrid(DataGridViewEntityChecker)
            blnDataFound = True
        End If
        Return blnDataFound
    End Function

    Function SetElement(oElement As EA.Element) As Boolean
        Dim strElements As String = "-999, " + oElement.ElementID.ToString()
        Dim strSql As String = String.Format(Me.strElementSQL, strElements)
        Dim oDT As DataTable = DLA2EAHelper.SQL2DataTable(strSql, Me.Repository)
        Dim blnDataFound As Boolean = False
        If Not IsNothing(oDT) Then
            If oDT.Rows.Count > 0 Then
                Me.Text = Me.Text + " for " + oElement.Name
                Me.DataGridViewEntityChecker.DataSource = oDT
                ColorGrid(DataGridViewEntityChecker)
                blnDataFound = True
                Me.DataGridViewEntityChecker.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        End If

        Return blnDataFound
    End Function
    Private Sub ColorGrid(ByVal Grid As DataGridView)

        Dim strStatus As String
        Dim oRow As System.Windows.Forms.DataGridViewRow
        Try
            For Each oRow In Grid.Rows
                If Not IsNothing(oRow.Cells("status_related").Value) Then
                    strStatus = oRow.Cells("status_related").Value.ToString().ToUpper()
                    Select Case strStatus
                        Case "REFERENTIE ARCHITECTUUR", "IMPLEMENTED"
                            oRow.Cells("status_related").Style.BackColor = Color.IndianRed
                            Me.CheckBoxContinue.Checked = False
                           ' oRow.DefaultCellStyle.BackColor = Color.PaleVioletRed
                        Case "SOLUTION ARCHITECTUUR", "APPROVED"
                            oRow.Cells("status_related").Style.BackColor = Color.LightSalmon
                            'oRow.DefaultCellStyle.BackColor = Color.LightSalmon
                        Case "WERKMAP ARCHITECT", "PROPOSED"
                            oRow.Cells("status_related").Style.BackColor = Color.LightGreen
                            ' oRow.DefaultCellStyle.BackColor = Color.LightGreen
                        Case Else
                            oRow.DefaultCellStyle.BackColor = Color.Yellow
                    End Select
                End If
            Next
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ColorGrid(DataGridViewEntityChecker)
    End Sub
    Private Sub FrmRelatedEntityChecker_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ColorGrid(DataGridViewEntityChecker)
    End Sub

    Private Sub DataGridViewEntityChecker_GotFocus(sender As Object, e As EventArgs) Handles DataGridViewEntityChecker.GotFocus
        ColorGrid(DataGridViewEntityChecker)
    End Sub

    Private Sub FrmRelatedEntityChecker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Savetranslations()
    End Sub
    Public Sub Savetranslations()
        Dim oDefinities As New IDEADefinitions()
        oDefinities.FormControls2TransLations(Me.Name, Me.Controls, True)
    End Sub
End Class
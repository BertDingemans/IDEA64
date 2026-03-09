Imports System.IO
Imports EA
Imports IDEA.DLAFormfactory

Public Class FrmIDEAPackage
    Public oPackage As EA.Package
    Private oTemplates As New HTMLTemplates()
    Private oDef As New IDEADefinitions()
    Private oSearchReplace As New DataTable("SEARCHREPLACE")

    Private Sub FrmIDEAPackage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.oSearchReplace.Columns.Add(New DataColumn("Search"))
        Me.oSearchReplace.Columns.Add(New DataColumn("Replace"))
        Me.DataGridViewSearchReplace.DataSource = Me.oSearchReplace
        Me.TopMost = True
        Me.Savetranslations()
        Me.ComboBoxSelectedPackage.DataSource = DLA2EAHelper.EAString2DataTable(Repository.SQLQuery("select package_id, name from t_package order by name"))
        Me.ComboBoxSelectedPackage.DisplayMember = "name"
        Me.ComboBoxSelectedPackage.ValueMember = "package_id"

    End Sub
    Public Sub Savetranslations()
        oDef.FormControls2TransLations(Me.Name, Me.Controls, True)
    End Sub
    Public Property Package() As EA.Package
        Get
            Return oPackage
        End Get
        Set(ByVal value As EA.Package)
            oPackage = value
            Me.LabelPackage.Text = oPackage.Name
        End Set
    End Property

    Private Repository As EA.Repository = DLA2EAHelper.GetRepository()
    Private Sub UpdateStatus(oPackage As EA.Package)
        Try
            If Me.CheckBoxUpdateStatus.Checked Then
                DLA2EAHelper.SetProgressBarInit(Me.ProgressBar1, oPackage.Packages.Count)
                Dim Sql As String = String.Format("UPDATE t_object 
                                                       SET [status] = '{1}' 
                                                       WHERE t_object.package_id IN({2} {0}) ",
                                                   DLA2EAHelper.PackageTree2String(oPackage), oPackage.Element.Status, oPackage.PackageID)
                If DLA2EAHelper.IsSqLite() Then
                    Sql = Sql.Replace("[", "").Replace("]", "")
                End If
                Repository.Execute(Sql)
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub MoveToSelectedPackage(oPackage As EA.Package)
        Dim oChild As EA.Package
        Try
            Dim SelectedPackageID As Int32 = Convert.ToInt32(Me.ComboBoxSelectedPackage.SelectedValue)
            If Me.CheckBoxSelectedPackage.Checked Then
                For Each oElement As EA.Element In oPackage.Elements
                    oElement.PackageID = SelectedPackageID
                    oElement.Update()
                Next
                DLA2EAHelper.SetProgressBarInit(Me.ProgressBar1, oPackage.Packages.Count)
                For Each oChild In oPackage.Packages
                    MoveToSelectedPackage(oChild)
                    Me.ProgressBar1.PerformStep()
                Next
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    Private Sub MoveToArchiMate(oPackage As EA.Package)
        Dim oChild As EA.Package
        Try
            If Me.CheckBoxMoveArchiMate.Checked Then
                For Each oElement As EA.Element In oPackage.Elements
                    Dim oTbl As DataTable

                    oTbl = Me.oDef.GetFilteredTable("ArchiMaid", String.Format(" stereotype = '{0} ' ", IIf(oElement.Stereotype.Length = 0, oElement.Type, oElement.Stereotype)))
                    If oTbl.Rows.Count > 0 Then
                        Dim oRow As DataRow = oTbl.Rows(0)
                        If Not IsDBNull(oRow("Package_guid")) Then
                            oElement.PackageID = Convert.ToInt32(oRow("Package_guid"))
                            oElement.Update()
                        End If
                    End If

                Next
                DLA2EAHelper.SetProgressBarInit(Me.ProgressBar1, oPackage.Packages.Count)
                For Each oChild In oPackage.Packages
                    MoveToArchiMate(oChild)
                    Me.ProgressBar1.PerformStep()
                Next
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    Private Sub SortPackage(Package As EA.Package)
        Dim strSql As String = "select object_id FROM t_object where t_object.package_id = {0} order by {1} "
        Dim oDT As DataTable
        Dim intTeller As Int32 = 1
        Dim oRow As DataRow

        Try
            If Me.CheckBoxSortPackage.Checked Then
                Repository.EnableUIUpdates = False
                If RadioButtonStereotype.Checked Then
                    strSql = String.Format(strSql, Package.PackageID, "stereotype, object_type, name")
                End If
                If RadioButtonName.Checked Then
                    strSql = String.Format(strSql, Package.PackageID, "name")
                End If
                If RadioButtonAlias.Checked Then
                    strSql = String.Format(strSql, oPackage.PackageID, "alias")
                End If
                If RadioButtonDataVault.Checked Then
                    strSql = String.Format(strSql, oPackage.PackageID, "case when right(name, 1)='H' then '1' when right(name, 1)='S' then '2' when right(name, 1)='L' then '3' else '9' end, name ")
                End If
                oDT = DLA2EAHelper.SQL2DataTable(strSql, Me.Repository)
                Dim oElement As EA.Element
                DLA2EAHelper.SetProgressBarInit(Me.ProgressBar1, oDT.Rows.Count)
                For Each oRow In oDT.Rows
                    oElement = Repository.GetElementByID(oRow("object_id"))
                    oElement.TreePos = intTeller
                    intTeller += 1
                    oElement.Update()
                    Me.ProgressBar1.PerformStep()
                Next
                Repository.RefreshModelView(oPackage.PackageID)
                Repository.EnableUIUpdates = True
                If Me.CheckBoxRecursive.Checked Then
                    For Each oSubPack As EA.Package In Package.Packages
                        SortPackage(oSubPack)
                    Next
                End If
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub RemoveNesting(Package As EA.Package)
        Try
            If CheckBoxRemoveNesting.Checked Then
                Dim strSql As String = "UPDATE t_object SET parentid = 0 WHERE parentid > 0 AND package_id = " + oPackage.PackageID.ToString()
                Me.Repository.Execute(strSql)
                strSql = "UPDATE t_diagram SET parentid = 0 WHERE parentid > 0 AND package_id = " + oPackage.PackageID.ToString()
                Me.Repository.Execute(strSql)
                Package.Update()

                If Me.CheckBoxRecursive.Checked Then
                    For Each oSubPack As EA.Package In Package.Packages
                        RemoveNesting(oSubPack)
                    Next
                End If
                Me.Repository.RefreshModelView(Package.PackageID)
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub
    Private Sub UpdateOrphans(Package As EA.Package)
        Dim OrphansPackage As EA.Package
        Try
            If Me.CheckBoxOrphans.Checked Then
                OrphansPackage = Me.oPackage.Packages.AddNew("Orphans", "")
                OrphansPackage.Update()
                UpdateOrphans(Package, OrphansPackage)
            End If

        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub

    Private Sub UpdateOrphans(Package As EA.Package, OrphanPackage As EA.Package)
        Try
            If Me.CheckBoxOrphans.Checked Then
                Dim strOrphan As String = OrphanPackage.PackageID.ToString()
                Dim strPackage As String = Package.PackageID.ToString

                Dim strSQL As String = String.Format("UPDATE t_object SET package_id = {1} WHERE package_id = {0} AND object_id NOT IN(SELECT DISTINCT object_id FROM t_diagramobjects) AND object_type NOT IN('package', 'text') ", strPackage, strOrphan)
                Me.Repository.Execute(strSQL)
                Repository.RefreshModelView(oPackage.PackageID)
            End If
            If Me.CheckBoxRecursive.Checked Then
                For Each oSubPack As EA.Package In Package.Packages
                    UpdateOrphans(oSubPack, OrphanPackage)
                Next
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub

    Private Sub UpdateTaggedValue(Package As EA.Package)

        If Me.CheckBoxTaggedValue.Checked Then
            For Each oElement As EA.Element In oPackage.Elements
                Dim objDS As New DataSet2Repository()
                objDS.AddOrUpdateTaggedValue(oElement, TextBoxTVName.Text, TextBoxTVValue.Text, False)
                oElement.Update()
            Next
            If Me.CheckBoxRecursive.Checked Then
                For Each SubPack As EA.Package In Package.Packages
                    UpdateTaggedValue(SubPack)
                Next
            End If
        End If
    End Sub

    Private Sub SearchandReplace(Package As EA.Package)
        Dim intCount As Int32 = 1
        If Me.CheckBoxSearchReplace.Checked Then
            Try


                For Each oRow As DataRow In Me.oSearchReplace.Rows
                    If CheckBoxReplaceName.Checked Then
                        Package.Name = Package.Name.Replace(oRow("Search"), oRow("Replace"))
                    End If
                    If CheckBoxReplaceAlias.Checked Then
                        Package.Alias = Package.Alias.Replace(oRow("Search"), oRow("Replace"))
                    End If
                    If CheckBoxReplaceNotes.Checked Then
                        Package.Notes = Package.Notes.Replace(oRow("Search"), oRow("Replace"))
                    End If
                    If CheckBoxKeywords.Checked Then
                        Package.Element.Tag = Package.Element.Tag.Replace(oRow("Search"), oRow("Replace"))
                    End If

                    intCount += Package.Elements.Count + Package.Diagrams.Count
                    DLA2EAHelper.SetProgressBarInit(Me.ProgressBar1, intCount)
                    ProgressBar1.PerformStep()
                    For Each Element As EA.Element In Package.Elements
                        If CheckBoxReplaceName.Checked Then
                            Element.Name = Element.Name.Replace(oRow("Search"), oRow("Replace"))
                        End If
                        If CheckBoxReplaceAlias.Checked Then
                            Element.Alias = Element.Alias.Replace(oRow("Search"), oRow("Replace"))
                        End If
                        If CheckBoxReplaceNotes.Checked Then
                            Element.Notes = Element.Notes.Replace(oRow("Search"), oRow("Replace"))
                        End If
                        If CheckBoxKeywords.Checked Then
                            Element.Tag = Element.Tag.Replace(oRow("Search"), oRow("Replace"))
                        End If
                        If Not Element.Locked Then
                            Element.Update()
                        End If
                        ProgressBar1.PerformStep()
                    Next
                    For Each Diagram As EA.Diagram In Package.Diagrams
                        If CheckBoxReplaceName.Checked Then
                            Diagram.Name = Diagram.Name.Replace(oRow("Search"), oRow("Replace"))
                        End If

                        If CheckBoxReplaceNotes.Checked Then
                            Diagram.Notes = Diagram.Notes.Replace(oRow("Search"), oRow("Replace"))
                        End If
                        Diagram.Update()
                        ProgressBar1.PerformStep()
                    Next
                Next
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Package.Update()
            If Me.CheckBoxRecursive.Checked Then
                For Each SubPack As EA.Package In Package.Packages
                    SearchandReplace(SubPack)
                Next
            End If
        End If
    End Sub

    Private Sub CollectElementsForDiagram(Package As EA.Package)

        Dim theDO As EA.DiagramObject
        Try
            If Me.CheckBoxCollectDiagramElements.Checked Then
                For Each diagram As EA.Diagram In Package.Diagrams
                    For Each theDO In Diagram.DiagramObjects
                        Dim theElement As EA.Element
                        theElement = Repository.GetElementByID(theDO.ElementID)
                        theElement.PackageID = diagram.PackageID
                        theElement.Update()
                    Next
                Next
                If Me.CheckBoxRecursive.Checked Then
                    For Each SubPack As EA.Package In Package.Packages
                        CollectElementsForDiagram(SubPack)
                    Next
                End If
                Repository.ReloadPackage(Package.PackageID)
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub
    Private Sub ButtonProcess_Click_1(sender As Object, e As EventArgs) Handles ButtonProcess.Click
        If DLA2EAHelper.IsUserGroupMember(Repository, "Administrators") Then
            SearchandReplace(Me.oPackage)
            RemoveNesting(Me.oPackage)
            UpdateStatus(Me.oPackage)
            MoveToArchiMate(Me.oPackage)
            MoveToSelectedPackage(Me.oPackage)
            UpdateOrphans(Me.oPackage)
            UpdateTaggedValue(Me.oPackage)
            CollectElementsForDiagram(Me.oPackage)
            SortPackage(Me.oPackage)
        End If

        If CheckBoxCloseWindow.Checked Then
            Me.Close()
        End If
    End Sub
End Class
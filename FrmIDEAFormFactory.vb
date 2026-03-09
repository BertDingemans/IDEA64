Imports IDEA.DLAFormfactory
Imports System.Windows.Forms
Public Class FrmIDEAFormFactory
    Protected FFDataset As SimulatorContainer
    Protected FFGenerator As FormFactoryGenerator
    Private Sub SelectDeSelect(ByVal state As Boolean)
        Dim i As Int16 = 0
        While i < ListBoxElements.Items.Count
            ListBoxElements.SetItemChecked(i, state)
            i += 1
        End While
    End Sub
    Private Sub ButtonUnselectAll_Click(ByVal sender As Object, ByVal e As EventArgs)
        SelectDeSelect(False)
    End Sub

    Private Sub ButtonToggleAll_Click(ByVal sender As Object, ByVal e As EventArgs)
        'SelectToggle()
    End Sub
    Private Sub LoadFFDataSet()
        Dim oFFGenerator As New FormFactoryGenerator()

        Me.FFDataset = oFFGenerator.Package2SimulatorDataset(Me.Package, "Simulator")
    End Sub
    Private Sub LoadElements()
        Dim objDT As DataTable
        Dim strSql As String
        Try
            Me.Package = Me.Repository.GetPackageByID(Convert.ToInt32(Me.ComboBoxPackage.SelectedValue))
            LoadFFDataSet()
            strSql = String.Format("SELECT diagram_id, name FROM t_diagram WHERE package_id IN(-999 {0}) ", DLA2EAHelper.PackageTree2String(Me.Package))
            objDT = DLA2EAHelper.SQL2DataTable(strSql, Me.Repository)
            If Not IsNothing(objDT) Then
                Me.ListBoxDiagrams.DataSource = objDT
                Me.ListBoxDiagrams.DisplayMember = "name"
                Me.ListBoxDiagrams.ValueMember = "diagram_id"
                Dim i As Int16 = 0
                While i < ListBoxDiagrams.Items.Count
                    ListBoxDiagrams.SetItemChecked(i, (Not ListBoxDiagrams.GetItemChecked(i)))
                    i += 1
                End While
            End If
            strSql = String.Format("SELECT object_id, name FROM t_object WHERE object_type = 'Class' AND abstract='0' AND t_object.package_id IN(-999 {0}) UNION SELECT t_object.object_id, t_object.name FROM t_object, t_diagramobjects, t_diagram WHERE t_object.object_id = t_diagramobjects.object_id AND t_diagramobjects.diagram_id = t_diagram.diagram_id AND t_object.object_type = 'Class' AND abstract='0' AND t_diagram.package_id ={1} order by 2 ", DLA2EAHelper.PackageTree2String(Me.Package), Me.Package.PackageID.ToString())
            objDT = DLA2EAHelper.SQL2DataTable(strSql, Me.Repository)
            If Not IsNothing(objDT) Then
                For Each oTable As DataTable In FFDataset.ContainerDataSet.Tables
                    If Not oTable.TableName.Contains("SYS") Then
                        ListBoxElements.Items.Add(oTable.TableName)
                    End If

                Next
                Dim i As Int16 = 0
                While i < ListBoxElements.Items.Count
                    ListBoxElements.SetItemChecked(i, (Not ListBoxElements.GetItemChecked(i)))
                    i += 1
                End While
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Public Sub LoadPackage()
        Dim objDT As DataTable
        Try
            objDT = DLA2EAHelper.SQL2DataTable("SELECT package_id, name FROM t_package ORDER BY 2 ", Me.Repository)
            Me.ComboBoxPackage.DataSource = objDT
            Me.ComboBoxPackage.DisplayMember = "name"
            Me.ComboBoxPackage.ValueMember = "package_id"
            Me.ComboBoxPackage.SelectedValue = Me.Package.PackageID
            Me.LabelDatabaseConnection.Text = My.Settings.ConnectionString
            Me.LoadElements()
            Me.LabelXMLFile.Text = My.Settings.XMLFile
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub
    Private Repository As EA.Repository = DLA2EAHelper.GetRepository()
    Private _Package As EA.Package
    Public Property Package As EA.Package
        Get
            Return _Package
        End Get
        Set(ByVal value As EA.Package)
            _Package = value
        End Set
    End Property
    Private Sub ButtonLoad_Click(sender As Object, e As EventArgs) Handles ButtonLoad.Click
        Me.LoadElements()
    End Sub
    Private Sub ButtonGenerate_Click_1(sender As Object, e As EventArgs) Handles ButtonGenerate.Click
        If IsNothing(Me.FFGenerator) Then
            Me.FFGenerator = New FormFactoryGenerator()
        End If
        Me.FFGenerator.OpenDataBase()
        Me.FFGenerator.ProcessEnumerations(Me.FFDataset.GetDataTable("SYS_ENUMERATION"), CheckBoxDeleteEnumeration.Checked, CheckBoxCreateEnumeration.Checked)
        For Each item In Me.ListBoxElements.CheckedItems
            Dim Name As String = item.ToString()
            Me.FFGenerator.ProcessForm(Name, CheckBoxDeleteClass.Checked, CheckBoxCreateClass.Checked)
            Me.FFGenerator.ProcessControl(Me.FFDataset.GetDataTable("SYS_CONTROLS"), Me.FFDataset.GetDataTable("SYS_COMMAND"), Name, CheckBoxCreateClass.Checked)
            Me.FFGenerator.ProcessListForm(Name, CheckBoxDeleteLookup.Checked, CheckBoxCreateLookup.Checked, Me.FFDataset.GetDataTable("SYS_COMMAND"))
            Me.FFGenerator.ProcessMenu(Name, CheckBoxDeleteMenu.Checked, CheckBoxCreateMenu.Checked)
            Me.FFGenerator.ProcessParentRelation(Name, Me.FFDataset.GetDataTable("SYS_RELATION"), CheckBoxCreateClass.Checked)
        Next
        Me.FFGenerator.CloseDataBase()
        If CheckBoxClose.Checked Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonGenerateDataSet_Click(sender As Object, e As EventArgs) Handles ButtonGenerateDataSet.Click
        Try
            Dim DS2SQL As New Dataset2DDL()
            If CheckBoxSaveDataSet.Checked Then
                Me.FFDataset.SaveDataToXML(XmlWriteMode.WriteSchema)
            End If
            If DS2SQL.Dataset2SQL(Me.FFDataset.ContainerDataSet, CheckBoxSystemTables.Checked, CheckBoxModelTables.Checked, CheckBoxForeignKeys.Checked) Then
                Me.TextBoxDatasetCode.Text = DS2SQL.SQL
                If Me.CheckBoxClipBoard.Checked And Me.TextBoxDatasetCode.Text.Length > 0 Then
                    System.Windows.Forms.Clipboard.SetText(Me.TextBoxDatasetCode.Text)
                End If
                If Me.CheckBoxToSQL.Checked Then
                    DLA2EAHelper.String2File(Me.TextBoxDatasetCode.Text, "C:\idea\formfactory.sql", IO.FileMode.CreateNew)
                End If
                'direct command execute in the database
                If Me.CheckBoxCreateDirect.Checked And My.Settings.ConnectionString.Length > 0 Then
                    Dim Statements As String() = DS2SQL.SQL.Split(";")
                    Dim oDB As New DLADatabase(My.Settings.ConnectionString)
                    oDB.OpenConnection(True)
                    For Each Statement As String In Statements
                        If oDB.ExecuteModify(Statement) = False Then
                            oDB.CloseConnection(False)
                        End If
                    Next
                    oDB.CloseConnection(True)
                End If
            Else
                MsgBox("SQL generating NOT successful")
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try

    End Sub

    Private Sub ButtonSimulator_Click(sender As Object, e As EventArgs) Handles ButtonSimulator.Click
        Dim FrmSimulator As New Interactory_Simulator()
        Dim aElementen As New DataTable
        Dim strIn As String = "-999"

        Try
            For Each item In Me.ListBoxDiagrams.CheckedItems
                strIn += "," + item("diagram_id").ToString()
            Next
            FrmSimulator.DataSetContainer = Me.FFDataset
            Dim strSql As String = String.Format("SELECT t_object.name FROM t_object, t_diagramobjects WHERE t_object.object_id = t_diagramobjects.object_id AND t_diagramobjects.diagram_id IN({0}) ", strIn)
            aElementen = DLA2EAHelper.SQL2DataTable(strSql, Me.Repository)
            FrmSimulator.TableNames = aElementen
            FrmSimulator.LoadData()
            FrmSimulator.Show()
            Me.Close()
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub ButtonSelectAll_Click_1(sender As Object, e As EventArgs) Handles ButtonSelectAll.Click
        SelectDeSelect(True)
    End Sub

    Private Sub ButtonUnselectAll_Click_1(sender As Object, e As EventArgs) Handles ButtonUnselectAll.Click
        SelectDeSelect(True)
    End Sub

    Private Sub ButtonToggleAll_Click_1(sender As Object, e As EventArgs) Handles ButtonToggleAll.Click
        Dim i As Int16 = 0
        While i < ListBoxElements.Items.Count
            ListBoxElements.SetItemChecked(i, (Not ListBoxElements.GetItemChecked(i)))
            i += 1
        End While
    End Sub

    Private Sub ButtonInspector_Click(sender As Object, e As EventArgs) Handles ButtonInspector.Click
        Dim frmDI As New FrmDataSetInspector()
        frmDI.SetDataSet(Me.FFDataset.ContainerDataSet)
        frmDI.Show()

    End Sub
    Sub MakeConnectionString()
        Dim dcd As New Microsoft.Data.ConnectionUI.DataConnectionDialog()

        Microsoft.Data.ConnectionUI.DataSource.AddStandardDataSources(dcd)
        If Microsoft.Data.ConnectionUI.DataConnectionDialog.Show(dcd) = DialogResult.OK Then
            My.Settings.ConnectionString = dcd.ConnectionString
            My.Settings.ConnectionType = "SQL"
            MsgBox(My.Settings.ConnectionString)
        Else
            My.Settings.ConnectionString = ""
            My.Settings.ConnectionType = "XML"
        End If
        My.Settings.Save()

    End Sub
    Function MakeXMLFile() As String
        Dim strFileName As String = ""

        Me.FileDialog.Title = "Open XML file"
        Me.FileDialog.InitialDirectory = "C:\idea\"
        Me.FileDialog.Filter = "XML files (*.xml)|*.xml"
        Me.FileDialog.FilterIndex = 2
        Me.FileDialog.RestoreDirectory = True
        If Me.FileDialog.ShowDialog() = DialogResult.OK Then
            strFileName = Me.FileDialog.FileName
            My.Settings.ConnectionType = "XML"
        Else
            My.Settings.ConnectionType = ""
        End If
        My.Settings.XMLFile = strFileName
        My.Settings.Save()
        Return strFileName
    End Function
    Private Sub ButtonDatabaseConnection_Click(sender As Object, e As EventArgs) Handles ButtonDatabaseConnection.Click
        MakeConnectionString()
        Me.ButtonDatabaseConnection.Tag = Me.LabelDatabaseConnection.Text = My.Settings.ConnectionString
    End Sub

    Private Sub ButtonXMLFile_Click(sender As Object, e As EventArgs) Handles ButtonXMLFile.Click
        Me.LabelXMLFile.Text = MakeXMLFile()
    End Sub

    Private Sub FrmIDEAFormFactory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.TopMost = True
        Me.Savetranslations()
    End Sub
    Public Sub Savetranslations()
        Dim oDefinities As New IDEADefinitions()
        oDefinities.FormControls2TransLations(Me.Name, Me.Controls, True)
    End Sub
End Class
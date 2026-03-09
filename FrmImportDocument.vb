Imports DLAFormfactory
Public Class FrmImportDocument
    Private Sub ButtonSelect_Click(sender As Object, e As EventArgs) Handles ButtonSelect.Click
        If Me.FolderBrowserDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.TextBoxDirectory.Text = Me.FolderBrowserDialog.SelectedPath
        End If
    End Sub
    Private _Repository As EA.Repository

    Public Property Repository() As EA.Repository
        Get
            Return _Repository
        End Get
        Set(ByVal value As EA.Repository)
            _Repository = value
        End Set
    End Property

    Private _Package As EA.Package
    Public Property Package As EA.Package
        Get
            Return _Package
        End Get
        Set(ByVal value As EA.Package)
            _Package = value
            Me.TextBoxPackage.Text = _Package.Name
        End Set
    End Property

    Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
        Try
            Dim blnDoorgaan As Boolean = True
            If Me.TextBoxDirectory.Text.Length = 0 Then
                MsgBox("Please fill in the directory")
                blnDoorgaan = False
            End If
            If Me.TextBoxStereotype.Text.Length = 0 Then
                MsgBox("Please fill in a stereotype")
                blnDoorgaan = False
            End If
            If blnDoorgaan Then
                Dim strFiles As String() = System.IO.Directory.GetFiles(Me.TextBoxDirectory.Text, "*.docx")
                For Each strFile As String In strFiles
                    Dim oElement As EA.Element
                    Dim oFile As New System.IO.FileInfo(strFile)
                    oElement = Me.Package.Elements.AddNew(oFile.Name, Me.TextBoxStereotype.Text)
                    oElement.LoadLinkedDocument(strFile)
                    oElement.Update()
                    Me.TextBoxResult.Text += strFile + vbCrLf
                    Me.TextBoxResult.Refresh()
                Next
                Me.TextBoxResult.Text += vbCrLf + vbCrLf + "IMPORT READY!!"
            End If

        Catch ex As Exception
            DLAFormfactory.DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub FrmImportDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Savetranslations()
    End Sub
    Public Sub Savetranslations()
        Dim oDefinities As New IDEADefinitions()
        oDefinities.FormControls2TransLations(Me.Name, Me.Controls, True)
    End Sub
End Class
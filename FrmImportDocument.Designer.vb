<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportDocument
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonImport = New System.Windows.Forms.Button()
        Me.TextBoxDirectory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextBoxStereotype = New System.Windows.Forms.TextBox()
        Me.TextBoxPackage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonSelect = New System.Windows.Forms.Button()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonImport
        '
        Me.ButtonImport.Location = New System.Drawing.Point(628, 214)
        Me.ButtonImport.Name = "ButtonImport"
        Me.ButtonImport.Size = New System.Drawing.Size(75, 23)
        Me.ButtonImport.TabIndex = 0
        Me.ButtonImport.Text = "Import"
        Me.ButtonImport.UseVisualStyleBackColor = True
        '
        'TextBoxDirectory
        '
        Me.TextBoxDirectory.Location = New System.Drawing.Point(153, 21)
        Me.TextBoxDirectory.Name = "TextBoxDirectory"
        Me.TextBoxDirectory.Size = New System.Drawing.Size(487, 20)
        Me.TextBoxDirectory.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Directory of documents"
        '
        'TextBoxStereotype
        '
        Me.TextBoxStereotype.Location = New System.Drawing.Point(154, 52)
        Me.TextBoxStereotype.Name = "TextBoxStereotype"
        Me.TextBoxStereotype.Size = New System.Drawing.Size(549, 20)
        Me.TextBoxStereotype.TabIndex = 3
        '
        'TextBoxPackage
        '
        Me.TextBoxPackage.Location = New System.Drawing.Point(153, 87)
        Me.TextBoxPackage.Name = "TextBoxPackage"
        Me.TextBoxPackage.ReadOnly = True
        Me.TextBoxPackage.Size = New System.Drawing.Size(550, 20)
        Me.TextBoxPackage.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Stereotype"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Package"
        '
        'ButtonSelect
        '
        Me.ButtonSelect.Location = New System.Drawing.Point(648, 21)
        Me.ButtonSelect.Name = "ButtonSelect"
        Me.ButtonSelect.Size = New System.Drawing.Size(55, 20)
        Me.ButtonSelect.TabIndex = 7
        Me.ButtonSelect.Text = "Select"
        Me.ButtonSelect.UseVisualStyleBackColor = True
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Location = New System.Drawing.Point(27, 116)
        Me.TextBoxResult.Multiline = True
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.ReadOnly = True
        Me.TextBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxResult.Size = New System.Drawing.Size(675, 92)
        Me.TextBoxResult.TabIndex = 8
        '
        'FrmImportDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 249)
        Me.Controls.Add(Me.TextBoxResult)
        Me.Controls.Add(Me.ButtonSelect)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxPackage)
        Me.Controls.Add(Me.TextBoxStereotype)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxDirectory)
        Me.Controls.Add(Me.ButtonImport)
        Me.Name = "FrmImportDocument"
        Me.Text = "Import Document"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonImport As System.Windows.Forms.Button
    Friend WithEvents TextBoxDirectory As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TextBoxStereotype As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPackage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonSelect As System.Windows.Forms.Button
    Friend WithEvents TextBoxResult As System.Windows.Forms.TextBox
End Class

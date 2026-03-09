<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRelatedEntityChecker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridViewEntityChecker = New System.Windows.Forms.DataGridView()
        Me.CheckBoxContinue = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridViewEntityChecker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewEntityChecker
        '
        Me.DataGridViewEntityChecker.AllowUserToAddRows = False
        Me.DataGridViewEntityChecker.AllowUserToDeleteRows = False
        Me.DataGridViewEntityChecker.AllowUserToOrderColumns = True
        Me.DataGridViewEntityChecker.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewEntityChecker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DataGridViewEntityChecker.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewEntityChecker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEntityChecker.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridViewEntityChecker.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridViewEntityChecker.Location = New System.Drawing.Point(1, 41)
        Me.DataGridViewEntityChecker.MultiSelect = False
        Me.DataGridViewEntityChecker.Name = "DataGridViewEntityChecker"
        Me.DataGridViewEntityChecker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewEntityChecker.Size = New System.Drawing.Size(536, 338)
        Me.DataGridViewEntityChecker.TabIndex = 0
        '
        'CheckBoxContinue
        '
        Me.CheckBoxContinue.AutoSize = True
        Me.CheckBoxContinue.Checked = True
        Me.CheckBoxContinue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxContinue.Location = New System.Drawing.Point(8, 9)
        Me.CheckBoxContinue.Name = "CheckBoxContinue"
        Me.CheckBoxContinue.Size = New System.Drawing.Size(170, 17)
        Me.CheckBoxContinue.TabIndex = 1
        Me.CheckBoxContinue.Text = "Continue your delete operation"
        Me.CheckBoxContinue.UseVisualStyleBackColor = True
        '
        'FrmRelatedEntityChecker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 377)
        Me.Controls.Add(Me.CheckBoxContinue)
        Me.Controls.Add(Me.DataGridViewEntityChecker)
        Me.Name = "FrmRelatedEntityChecker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Related Entity Checker"
        CType(Me.DataGridViewEntityChecker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewEntityChecker As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBoxContinue As System.Windows.Forms.CheckBox
End Class

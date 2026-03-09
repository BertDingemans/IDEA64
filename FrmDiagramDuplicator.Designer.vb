''' <summary>
''' Form for the deduplication of diagrams. This is actually a duplicator since it
''' duplicates all the elements in the diagram. This is the generated code by
''' Visual Studio
''' </summary>
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmDiagramDuplicator
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
        Me.ButtonClone = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelDiagram = New System.Windows.Forms.Label()
        Me.CheckBoxKeepOriginal = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBaseline = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTrace = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCloneDiagram = New System.Windows.Forms.CheckBox()
        Me.ProgressBarClone = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'ButtonClone
        '
        Me.ButtonClone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClone.Location = New System.Drawing.Point(382, 140)
        Me.ButtonClone.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClone.Name = "ButtonClone"
        Me.ButtonClone.Size = New System.Drawing.Size(100, 30)
        Me.ButtonClone.TabIndex = 0
        Me.ButtonClone.Text = "Clone Diagram"
        Me.ButtonClone.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Diagram"
        '
        'LabelDiagram
        '
        Me.LabelDiagram.AutoSize = True
        Me.LabelDiagram.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDiagram.Location = New System.Drawing.Point(8, 31)
        Me.LabelDiagram.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDiagram.Name = "LabelDiagram"
        Me.LabelDiagram.Size = New System.Drawing.Size(24, 24)
        Me.LabelDiagram.TabIndex = 29
        Me.LabelDiagram.Text = "--"
        '
        'CheckBoxKeepOriginal
        '
        Me.CheckBoxKeepOriginal.AutoSize = True
        Me.CheckBoxKeepOriginal.Checked = True
        Me.CheckBoxKeepOriginal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxKeepOriginal.Location = New System.Drawing.Point(11, 73)
        Me.CheckBoxKeepOriginal.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxKeepOriginal.Name = "CheckBoxKeepOriginal"
        Me.CheckBoxKeepOriginal.Size = New System.Drawing.Size(132, 17)
        Me.CheckBoxKeepOriginal.TabIndex = 31
        Me.CheckBoxKeepOriginal.Text = "Keep original package"
        Me.CheckBoxKeepOriginal.UseVisualStyleBackColor = True
        '
        'CheckBoxBaseline
        '
        Me.CheckBoxBaseline.AutoSize = True
        Me.CheckBoxBaseline.Checked = True
        Me.CheckBoxBaseline.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxBaseline.Location = New System.Drawing.Point(11, 95)
        Me.CheckBoxBaseline.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxBaseline.Name = "CheckBoxBaseline"
        Me.CheckBoxBaseline.Size = New System.Drawing.Size(209, 17)
        Me.CheckBoxBaseline.TabIndex = 32
        Me.CheckBoxBaseline.Text = "Baseline original package before clone"
        Me.CheckBoxBaseline.UseVisualStyleBackColor = True
        '
        'CheckBoxTrace
        '
        Me.CheckBoxTrace.AutoSize = True
        Me.CheckBoxTrace.Checked = True
        Me.CheckBoxTrace.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxTrace.Location = New System.Drawing.Point(11, 119)
        Me.CheckBoxTrace.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxTrace.Name = "CheckBoxTrace"
        Me.CheckBoxTrace.Size = New System.Drawing.Size(231, 17)
        Me.CheckBoxTrace.TabIndex = 33
        Me.CheckBoxTrace.Text = "Create trace between original and duplicate"
        Me.CheckBoxTrace.UseVisualStyleBackColor = True
        '
        'CheckBoxCloneDiagram
        '
        Me.CheckBoxCloneDiagram.AutoSize = True
        Me.CheckBoxCloneDiagram.Checked = True
        Me.CheckBoxCloneDiagram.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCloneDiagram.Location = New System.Drawing.Point(11, 140)
        Me.CheckBoxCloneDiagram.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxCloneDiagram.Name = "CheckBoxCloneDiagram"
        Me.CheckBoxCloneDiagram.Size = New System.Drawing.Size(93, 17)
        Me.CheckBoxCloneDiagram.TabIndex = 34
        Me.CheckBoxCloneDiagram.Text = "Clone diagram"
        Me.CheckBoxCloneDiagram.UseVisualStyleBackColor = True
        '
        'ProgressBarClone
        '
        Me.ProgressBarClone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarClone.Location = New System.Drawing.Point(-1, 184)
        Me.ProgressBarClone.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBarClone.Name = "ProgressBarClone"
        Me.ProgressBarClone.Size = New System.Drawing.Size(491, 26)
        Me.ProgressBarClone.TabIndex = 35
        '
        'FrmDiagramDuplicator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 207)
        Me.Controls.Add(Me.ProgressBarClone)
        Me.Controls.Add(Me.CheckBoxCloneDiagram)
        Me.Controls.Add(Me.CheckBoxTrace)
        Me.Controls.Add(Me.CheckBoxBaseline)
        Me.Controls.Add(Me.CheckBoxKeepOriginal)
        Me.Controls.Add(Me.ButtonClone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelDiagram)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmDiagramDuplicator"
        Me.Text = "Diagram Duplicator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonClone As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelDiagram As System.Windows.Forms.Label
    Friend WithEvents CheckBoxKeepOriginal As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxBaseline As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTrace As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCloneDiagram As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBarClone As System.Windows.Forms.ProgressBar
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmText2ArchiMate
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonAdd2Diagram = New System.Windows.Forms.Button()
        Me.CheckBoxDisplayKeywords = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRebuild = New System.Windows.Forms.CheckBox()
        Me.ButtonAnalyseText = New System.Windows.Forms.Button()
        Me.TextBoxArchitectureText = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridViewArchitectureResult = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridViewPivotTable = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewArchitectureResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewPivotTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonAdd2Diagram)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBoxDisplayKeywords)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBoxRebuild)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonAnalyseText)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxArchitectureText)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 276
        Me.SplitContainer1.TabIndex = 0
        '
        'ButtonAdd2Diagram
        '
        Me.ButtonAdd2Diagram.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdd2Diagram.Location = New System.Drawing.Point(636, 228)
        Me.ButtonAdd2Diagram.Name = "ButtonAdd2Diagram"
        Me.ButtonAdd2Diagram.Size = New System.Drawing.Size(161, 37)
        Me.ButtonAdd2Diagram.TabIndex = 4
        Me.ButtonAdd2Diagram.Text = "Add 2 Diagram"
        Me.ButtonAdd2Diagram.UseVisualStyleBackColor = True
        '
        'CheckBoxDisplayKeywords
        '
        Me.CheckBoxDisplayKeywords.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxDisplayKeywords.AutoSize = True
        Me.CheckBoxDisplayKeywords.Location = New System.Drawing.Point(151, 239)
        Me.CheckBoxDisplayKeywords.Name = "CheckBoxDisplayKeywords"
        Me.CheckBoxDisplayKeywords.Size = New System.Drawing.Size(109, 17)
        Me.CheckBoxDisplayKeywords.TabIndex = 3
        Me.CheckBoxDisplayKeywords.Text = "Display Keywords"
        Me.CheckBoxDisplayKeywords.UseVisualStyleBackColor = True
        '
        'CheckBoxRebuild
        '
        Me.CheckBoxRebuild.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxRebuild.AutoSize = True
        Me.CheckBoxRebuild.Location = New System.Drawing.Point(12, 239)
        Me.CheckBoxRebuild.Name = "CheckBoxRebuild"
        Me.CheckBoxRebuild.Size = New System.Drawing.Size(133, 17)
        Me.CheckBoxRebuild.TabIndex = 2
        Me.CheckBoxRebuild.Text = "Rebuild keyword index"
        Me.CheckBoxRebuild.UseVisualStyleBackColor = True
        '
        'ButtonAnalyseText
        '
        Me.ButtonAnalyseText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAnalyseText.Location = New System.Drawing.Point(469, 228)
        Me.ButtonAnalyseText.Name = "ButtonAnalyseText"
        Me.ButtonAnalyseText.Size = New System.Drawing.Size(158, 37)
        Me.ButtonAnalyseText.TabIndex = 1
        Me.ButtonAnalyseText.Text = "Analyse Text"
        Me.ButtonAnalyseText.UseVisualStyleBackColor = True
        '
        'TextBoxArchitectureText
        '
        Me.TextBoxArchitectureText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxArchitectureText.Location = New System.Drawing.Point(3, 0)
        Me.TextBoxArchitectureText.Multiline = True
        Me.TextBoxArchitectureText.Name = "TextBoxArchitectureText"
        Me.TextBoxArchitectureText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxArchitectureText.Size = New System.Drawing.Size(794, 222)
        Me.TextBoxArchitectureText.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 170)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridViewArchitectureResult)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(792, 144)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List in Diagram"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridViewArchitectureResult
        '
        Me.DataGridViewArchitectureResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewArchitectureResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewArchitectureResult.Location = New System.Drawing.Point(2, 2)
        Me.DataGridViewArchitectureResult.Name = "DataGridViewArchitectureResult"
        Me.DataGridViewArchitectureResult.RowHeadersWidth = 51
        Me.DataGridViewArchitectureResult.Size = New System.Drawing.Size(788, 140)
        Me.DataGridViewArchitectureResult.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridViewPivotTable)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(792, 143)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ArchiMate Table"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewPivotTable
        '
        Me.DataGridViewPivotTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPivotTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewPivotTable.Location = New System.Drawing.Point(2, 2)
        Me.DataGridViewPivotTable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewPivotTable.Name = "DataGridViewPivotTable"
        Me.DataGridViewPivotTable.RowHeadersWidth = 51
        Me.DataGridViewPivotTable.RowTemplate.Height = 24
        Me.DataGridViewPivotTable.Size = New System.Drawing.Size(788, 139)
        Me.DataGridViewPivotTable.TabIndex = 0
        '
        'FrmText2ArchiMate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmText2ArchiMate"
        Me.Text = "Text 2 ArchiMate"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridViewArchitectureResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewPivotTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ButtonAnalyseText As System.Windows.Forms.Button
    Friend WithEvents TextBoxArchitectureText As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewArchitectureResult As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBoxRebuild As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDisplayKeywords As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonAdd2Diagram As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewPivotTable As System.Windows.Forms.DataGridView
End Class

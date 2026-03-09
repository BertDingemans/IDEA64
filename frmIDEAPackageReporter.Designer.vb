<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIDEAPackageReporter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIDEAPackageReporter))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonLoadTemplate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonSaveTemplate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBoxPublish = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonGrid2Text = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButtonExecute = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBoxTemplate = New System.Windows.Forms.ToolStripTextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridViewTemplate = New System.Windows.Forms.DataGridView()
        Me.TextBoxTemplate = New System.Windows.Forms.TextBox()
        Me.OpenXMLFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveXMLFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonLoadTemplate, Me.ToolStripButtonSaveTemplate, Me.ToolStripTextBoxPublish, Me.ToolStripSeparator1, Me.ToolStripButtonGrid2Text, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.ToolStripButtonExecute, Me.ToolStripSeparator3, Me.ToolStripTextBoxTemplate})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonLoadTemplate
        '
        Me.ToolStripButtonLoadTemplate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStripButtonLoadTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonLoadTemplate.Image = CType(resources.GetObject("ToolStripButtonLoadTemplate.Image"), System.Drawing.Image)
        Me.ToolStripButtonLoadTemplate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonLoadTemplate.Margin = New System.Windows.Forms.Padding(3, 1, 3, 2)
        Me.ToolStripButtonLoadTemplate.Name = "ToolStripButtonLoadTemplate"
        Me.ToolStripButtonLoadTemplate.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ToolStripButtonLoadTemplate.Size = New System.Drawing.Size(96, 22)
        Me.ToolStripButtonLoadTemplate.Text = "Load templates"
        Me.ToolStripButtonLoadTemplate.ToolTipText = "Load templates from XML file"
        '
        'ToolStripButtonSaveTemplate
        '
        Me.ToolStripButtonSaveTemplate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStripButtonSaveTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonSaveTemplate.Image = CType(resources.GetObject("ToolStripButtonSaveTemplate.Image"), System.Drawing.Image)
        Me.ToolStripButtonSaveTemplate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSaveTemplate.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.ToolStripButtonSaveTemplate.Name = "ToolStripButtonSaveTemplate"
        Me.ToolStripButtonSaveTemplate.Size = New System.Drawing.Size(86, 25)
        Me.ToolStripButtonSaveTemplate.Text = "Save Template"
        Me.ToolStripButtonSaveTemplate.ToolTipText = "Save Template to XML file"
        '
        'ToolStripTextBoxPublish
        '
        Me.ToolStripTextBoxPublish.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBoxPublish.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripTextBoxPublish.Name = "ToolStripTextBoxPublish"
        Me.ToolStripTextBoxPublish.Size = New System.Drawing.Size(150, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonGrid2Text
        '
        Me.ToolStripButtonGrid2Text.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripButtonGrid2Text.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonGrid2Text.Image = CType(resources.GetObject("ToolStripButtonGrid2Text.Image"), System.Drawing.Image)
        Me.ToolStripButtonGrid2Text.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonGrid2Text.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.ToolStripButtonGrid2Text.Name = "ToolStripButtonGrid2Text"
        Me.ToolStripButtonGrid2Text.Size = New System.Drawing.Size(27, 25)
        Me.ToolStripButtonGrid2Text.Text = ">>"
        Me.ToolStripButtonGrid2Text.ToolTipText = "Move cell data to textbox"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(27, 22)
        Me.ToolStripButton1.Text = "<<"
        Me.ToolStripButton1.ToolTipText = "Move text from textbox to gridcell"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(31, 22)
        Me.ToolStripLabel1.Text = "==>"
        '
        'ToolStripButtonExecute
        '
        Me.ToolStripButtonExecute.BackColor = System.Drawing.Color.LightCoral
        Me.ToolStripButtonExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonExecute.Image = CType(resources.GetObject("ToolStripButtonExecute.Image"), System.Drawing.Image)
        Me.ToolStripButtonExecute.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonExecute.Name = "ToolStripButtonExecute"
        Me.ToolStripButtonExecute.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButtonExecute.Text = "Execute"
        Me.ToolStripButtonExecute.ToolTipText = "Generate content"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBoxTemplate
        '
        Me.ToolStripTextBoxTemplate.Enabled = False
        Me.ToolStripTextBoxTemplate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBoxTemplate.Name = "ToolStripTextBoxTemplate"
        Me.ToolStripTextBoxTemplate.Size = New System.Drawing.Size(250, 25)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridViewTemplate)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxTemplate)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 425)
        Me.SplitContainer1.SplitterDistance = 213
        Me.SplitContainer1.TabIndex = 1
        '
        'DataGridViewTemplate
        '
        Me.DataGridViewTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewTemplate.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewTemplate.Name = "DataGridViewTemplate"
        Me.DataGridViewTemplate.Size = New System.Drawing.Size(800, 213)
        Me.DataGridViewTemplate.TabIndex = 0
        '
        'TextBoxTemplate
        '
        Me.TextBoxTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxTemplate.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTemplate.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxTemplate.Multiline = True
        Me.TextBoxTemplate.Name = "TextBoxTemplate"
        Me.TextBoxTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxTemplate.Size = New System.Drawing.Size(800, 208)
        Me.TextBoxTemplate.TabIndex = 0
        '
        'OpenXMLFileDialog
        '
        Me.OpenXMLFileDialog.FileName = "Reporter.xml"
        '
        'SaveXMLFileDialog
        '
        Me.SaveXMLFileDialog.FileName = "Reporter.XML"
        '
        'frmIDEAPackageReporter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmIDEAPackageReporter"
        Me.Text = "frmIDEAPackageReporter"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridViewTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonLoadTemplate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonSaveTemplate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBoxPublish As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButtonExecute As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridViewTemplate As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxTemplate As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButtonGrid2Text As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenXMLFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveXMLFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripTextBoxTemplate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As Windows.Forms.ToolStripSeparator
End Class

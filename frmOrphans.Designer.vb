<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrphans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrphans))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TextBoxDiagram = New System.Windows.Forms.TextBox()
        Me.DataGridViewDiagramOrphans = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridViewConnectorOrphans = New System.Windows.Forms.DataGridView()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripPackageComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButtonMove = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewDiagramOrphans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewConnectorOrphans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripPackageComboBox, Me.ToolStripSeparator1, Me.ToolStripButtonMove})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxDiagram)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridViewDiagramOrphans)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridViewConnectorOrphans)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 425)
        Me.SplitContainer1.SplitterDistance = 205
        Me.SplitContainer1.TabIndex = 2
        '
        'TextBoxDiagram
        '
        Me.TextBoxDiagram.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDiagram.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxDiagram.Location = New System.Drawing.Point(704, 189)
        Me.TextBoxDiagram.Name = "TextBoxDiagram"
        Me.TextBoxDiagram.ReadOnly = True
        Me.TextBoxDiagram.Size = New System.Drawing.Size(96, 20)
        Me.TextBoxDiagram.TabIndex = 1
        Me.TextBoxDiagram.Text = "Diagram Orhans"
        Me.TextBoxDiagram.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridViewDiagramOrphans
        '
        Me.DataGridViewDiagramOrphans.AllowUserToAddRows = False
        Me.DataGridViewDiagramOrphans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDiagramOrphans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewDiagramOrphans.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewDiagramOrphans.Name = "DataGridViewDiagramOrphans"
        Me.DataGridViewDiagramOrphans.Size = New System.Drawing.Size(800, 205)
        Me.DataGridViewDiagramOrphans.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(699, 200)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(101, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Connector Orhans"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridViewConnectorOrphans
        '
        Me.DataGridViewConnectorOrphans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewConnectorOrphans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewConnectorOrphans.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewConnectorOrphans.Name = "DataGridViewConnectorOrphans"
        Me.DataGridViewConnectorOrphans.Size = New System.Drawing.Size(800, 216)
        Me.DataGridViewConnectorOrphans.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripLabel1.Text = "Move to package"
        '
        'ToolStripPackageComboBox
        '
        Me.ToolStripPackageComboBox.Name = "ToolStripPackageComboBox"
        Me.ToolStripPackageComboBox.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripButtonMove
        '
        Me.ToolStripButtonMove.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripButtonMove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonMove.Image = CType(resources.GetObject("ToolStripButtonMove.Image"), System.Drawing.Image)
        Me.ToolStripButtonMove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonMove.Name = "ToolStripButtonMove"
        Me.ToolStripButtonMove.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripButtonMove.Text = "Move"
        Me.ToolStripButtonMove.ToolTipText = "Move to the selected package"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'frmOrphans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmOrphans"
        Me.Text = "Orphans"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridViewDiagramOrphans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewConnectorOrphans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents TextBoxDiagram As Windows.Forms.TextBox
    Friend WithEvents DataGridViewDiagramOrphans As Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents DataGridViewConnectorOrphans As Windows.Forms.DataGridView
    Friend WithEvents ToolStripLabel1 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripPackageComboBox As Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButtonMove As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
End Class

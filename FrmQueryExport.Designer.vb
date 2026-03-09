''' <summary>
''' Helper screen for an advanced user to do some advanced things with the database
''' with SQL queries. You can retrieve data but also manipulate the data in the
''' repository.
''' </summary>
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class FrmQueryExport
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQueryExport))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TextBoxSQL = New System.Windows.Forms.TextBox()
        Me.DataGridViewExcel = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonLoad = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonExecute = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonExport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCopy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonPaste = New System.Windows.Forms.ToolStripButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 27)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxSQL)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridViewExcel)
        Me.SplitContainer1.Size = New System.Drawing.Size(988, 445)
        Me.SplitContainer1.SplitterDistance = 172
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 35
        '
        'TextBoxSQL
        '
        Me.TextBoxSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSQL.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSQL.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxSQL.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSQL.Multiline = True
        Me.TextBoxSQL.Name = "TextBoxSQL"
        Me.TextBoxSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxSQL.Size = New System.Drawing.Size(988, 172)
        Me.TextBoxSQL.TabIndex = 31
        '
        'DataGridViewExcel
        '
        Me.DataGridViewExcel.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridViewExcel.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewExcel.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewExcel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridViewExcel.Name = "DataGridViewExcel"
        Me.DataGridViewExcel.RowHeadersWidth = 51
        Me.DataGridViewExcel.RowTemplate.Height = 24
        Me.DataGridViewExcel.Size = New System.Drawing.Size(988, 270)
        Me.DataGridViewExcel.TabIndex = 28
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonLoad, Me.ToolStripButtonExecute, Me.ToolStripSeparator1, Me.ToolStripButtonExport, Me.ToolStripButtonCopy, Me.ToolStripButtonPaste})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(988, 27)
        Me.ToolStrip1.TabIndex = 36
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonLoad
        '
        Me.ToolStripButtonLoad.Image = CType(resources.GetObject("ToolStripButtonLoad.Image"), System.Drawing.Image)
        Me.ToolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonLoad.Name = "ToolStripButtonLoad"
        Me.ToolStripButtonLoad.Size = New System.Drawing.Size(83, 24)
        Me.ToolStripButtonLoad.Text = "Load data"
        '
        'ToolStripButtonExecute
        '
        Me.ToolStripButtonExecute.Image = CType(resources.GetObject("ToolStripButtonExecute.Image"), System.Drawing.Image)
        Me.ToolStripButtonExecute.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonExecute.Name = "ToolStripButtonExecute"
        Me.ToolStripButtonExecute.Size = New System.Drawing.Size(72, 24)
        Me.ToolStripButtonExecute.Text = "Execute"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButtonExport
        '
        Me.ToolStripButtonExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonExport.Image = CType(resources.GetObject("ToolStripButtonExport.Image"), System.Drawing.Image)
        Me.ToolStripButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonExport.Name = "ToolStripButtonExport"
        Me.ToolStripButtonExport.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButtonExport.Text = "Export"
        '
        'ToolStripButtonCopy
        '
        Me.ToolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCopy.Image = CType(resources.GetObject("ToolStripButtonCopy.Image"), System.Drawing.Image)
        Me.ToolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCopy.Name = "ToolStripButtonCopy"
        Me.ToolStripButtonCopy.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButtonCopy.Text = "Copy"
        '
        'ToolStripButtonPaste
        '
        Me.ToolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPaste.Image = CType(resources.GetObject("ToolStripButtonPaste.Image"), System.Drawing.Image)
        Me.ToolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPaste.Name = "ToolStripButtonPaste"
        Me.ToolStripButtonPaste.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButtonPaste.Text = "Paste"
        '
        'FrmQueryExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 472)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmQueryExport"
        Me.Text = "Query on repository"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridViewExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBoxSQL As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewExcel As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonLoad As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonExecute As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonExport As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripButtonCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonPaste As System.Windows.Forms.ToolStripButton
End Class

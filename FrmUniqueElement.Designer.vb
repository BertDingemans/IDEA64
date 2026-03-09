''' <summary>
''' Form for displaying the elements that are duplicate in the repository. Give a
''' warning and eventually add the duplicate element to the diagram.
''' </summary>
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmUniqueElement
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAdd2Diagram = New System.Windows.Forms.Button()
        Me.ButtonFindOriginal = New System.Windows.Forms.Button()
        Me.ButtonFindDuplicate = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControlValidator = New System.Windows.Forms.TabControl()
        Me.TabPageDuplicate = New System.Windows.Forms.TabPage()
        Me.UniqueDataGridView = New System.Windows.Forms.DataGridView()
        Me.Metamodel = New System.Windows.Forms.TabPage()
        Me.LabelMetaModel = New System.Windows.Forms.Label()
        Me.DataGridViewMetamodel = New System.Windows.Forms.DataGridView()
        Me.TabControlValidator.SuspendLayout()
        Me.TabPageDuplicate.SuspendLayout()
        CType(Me.UniqueDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Metamodel.SuspendLayout()
        CType(Me.DataGridViewMetamodel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 1
        '
        'ButtonAdd2Diagram
        '
        Me.ButtonAdd2Diagram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdd2Diagram.Location = New System.Drawing.Point(497, 6)
        Me.ButtonAdd2Diagram.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAdd2Diagram.Name = "ButtonAdd2Diagram"
        Me.ButtonAdd2Diagram.Size = New System.Drawing.Size(86, 35)
        Me.ButtonAdd2Diagram.TabIndex = 2
        Me.ButtonAdd2Diagram.Text = "Add2Diagram"
        Me.ButtonAdd2Diagram.UseVisualStyleBackColor = True
        '
        'ButtonFindOriginal
        '
        Me.ButtonFindOriginal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFindOriginal.Location = New System.Drawing.Point(324, 6)
        Me.ButtonFindOriginal.Name = "ButtonFindOriginal"
        Me.ButtonFindOriginal.Size = New System.Drawing.Size(75, 32)
        Me.ButtonFindOriginal.TabIndex = 4
        Me.ButtonFindOriginal.Text = "Find Original"
        Me.ButtonFindOriginal.UseVisualStyleBackColor = True
        '
        'ButtonFindDuplicate
        '
        Me.ButtonFindDuplicate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFindDuplicate.Location = New System.Drawing.Point(405, 6)
        Me.ButtonFindDuplicate.Name = "ButtonFindDuplicate"
        Me.ButtonFindDuplicate.Size = New System.Drawing.Size(87, 32)
        Me.ButtonFindDuplicate.TabIndex = 5
        Me.ButtonFindDuplicate.Text = "Find Duplicate"
        Me.ButtonFindDuplicate.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(493, 245)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(101, 20)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "Duplicate elements"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabControlValidator
        '
        Me.TabControlValidator.Controls.Add(Me.TabPageDuplicate)
        Me.TabControlValidator.Controls.Add(Me.Metamodel)
        Me.TabControlValidator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlValidator.Location = New System.Drawing.Point(0, 0)
        Me.TabControlValidator.Name = "TabControlValidator"
        Me.TabControlValidator.SelectedIndex = 0
        Me.TabControlValidator.Size = New System.Drawing.Size(598, 297)
        Me.TabControlValidator.TabIndex = 8
        '
        'TabPageDuplicate
        '
        Me.TabPageDuplicate.Controls.Add(Me.TextBox1)
        Me.TabPageDuplicate.Controls.Add(Me.ButtonFindOriginal)
        Me.TabPageDuplicate.Controls.Add(Me.ButtonFindDuplicate)
        Me.TabPageDuplicate.Controls.Add(Me.ButtonAdd2Diagram)
        Me.TabPageDuplicate.Controls.Add(Me.UniqueDataGridView)
        Me.TabPageDuplicate.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDuplicate.Name = "TabPageDuplicate"
        Me.TabPageDuplicate.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDuplicate.Size = New System.Drawing.Size(590, 271)
        Me.TabPageDuplicate.TabIndex = 0
        Me.TabPageDuplicate.Text = "Duplicate"
        Me.TabPageDuplicate.UseVisualStyleBackColor = True
        '
        'UniqueDataGridView
        '
        Me.UniqueDataGridView.AllowUserToAddRows = False
        Me.UniqueDataGridView.AllowUserToDeleteRows = False
        Me.UniqueDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UniqueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UniqueDataGridView.Location = New System.Drawing.Point(-4, 45)
        Me.UniqueDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.UniqueDataGridView.Name = "UniqueDataGridView"
        Me.UniqueDataGridView.RowHeadersWidth = 51
        Me.UniqueDataGridView.RowTemplate.Height = 24
        Me.UniqueDataGridView.Size = New System.Drawing.Size(598, 221)
        Me.UniqueDataGridView.TabIndex = 1
        '
        'Metamodel
        '
        Me.Metamodel.BackColor = System.Drawing.Color.Gainsboro
        Me.Metamodel.Controls.Add(Me.LabelMetaModel)
        Me.Metamodel.Controls.Add(Me.DataGridViewMetamodel)
        Me.Metamodel.Location = New System.Drawing.Point(4, 22)
        Me.Metamodel.Name = "Metamodel"
        Me.Metamodel.Padding = New System.Windows.Forms.Padding(3)
        Me.Metamodel.Size = New System.Drawing.Size(590, 271)
        Me.Metamodel.TabIndex = 1
        Me.Metamodel.Text = "Metamodel"
        '
        'LabelMetaModel
        '
        Me.LabelMetaModel.AutoSize = True
        Me.LabelMetaModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMetaModel.ForeColor = System.Drawing.Color.Red
        Me.LabelMetaModel.Location = New System.Drawing.Point(11, 12)
        Me.LabelMetaModel.Name = "LabelMetaModel"
        Me.LabelMetaModel.Size = New System.Drawing.Size(549, 20)
        Me.LabelMetaModel.TabIndex = 1
        Me.LabelMetaModel.Text = "The stereotype of this element is not in the organisation metamodel"
        '
        'DataGridViewMetamodel
        '
        Me.DataGridViewMetamodel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewMetamodel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMetamodel.Location = New System.Drawing.Point(3, 43)
        Me.DataGridViewMetamodel.Name = "DataGridViewMetamodel"
        Me.DataGridViewMetamodel.ReadOnly = True
        Me.DataGridViewMetamodel.Size = New System.Drawing.Size(587, 221)
        Me.DataGridViewMetamodel.TabIndex = 0
        '
        'FrmUniqueElement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 297)
        Me.Controls.Add(Me.TabControlValidator)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmUniqueElement"
        Me.Text = "Element validator"
        Me.TopMost = True
        Me.TabControlValidator.ResumeLayout(False)
        Me.TabPageDuplicate.ResumeLayout(False)
        Me.TabPageDuplicate.PerformLayout()
        CType(Me.UniqueDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Metamodel.ResumeLayout(False)
        Me.Metamodel.PerformLayout()
        CType(Me.DataGridViewMetamodel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonAdd2Diagram As System.Windows.Forms.Button
    Friend WithEvents ButtonFindOriginal As System.Windows.Forms.Button
    Friend WithEvents ButtonFindDuplicate As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents TabControlValidator As Windows.Forms.TabControl
    Friend WithEvents TabPageDuplicate As Windows.Forms.TabPage
    Friend WithEvents UniqueDataGridView As Windows.Forms.DataGridView
    Friend WithEvents Metamodel As Windows.Forms.TabPage
    Friend WithEvents DataGridViewMetamodel As Windows.Forms.DataGridView
    Friend WithEvents LabelMetaModel As Windows.Forms.Label
End Class

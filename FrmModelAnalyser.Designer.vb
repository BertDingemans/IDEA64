<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModelAnalyser
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridViewAnalyse = New System.Windows.Forms.DataGridView()
        Me.ChartAnalyse = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ButtonAddDefined = New System.Windows.Forms.Button()
        Me.RadioButtonManualstatement = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDefinedStatement = New System.Windows.Forms.RadioButton()
        Me.PanelSelectStatement = New System.Windows.Forms.Panel()
        Me.DataGridViewDefinedStatement = New System.Windows.Forms.DataGridView()
        Me.PanelManualStatement = New System.Windows.Forms.Panel()
        Me.CheckBox3DEnabled = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxGraphType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCategory = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxGrouping = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxTitle = New System.Windows.Forms.TextBox()
        Me.TextBoxSQL = New System.Windows.Forms.TextBox()
        Me.CheckBoxReset = New System.Windows.Forms.CheckBox()
        Me.ButtonTableModel = New System.Windows.Forms.Button()
        Me.ButtonAnalyse = New System.Windows.Forms.Button()
        Me.TabControlAnalyse = New System.Windows.Forms.TabControl()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewAnalyse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartAnalyse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.PanelSelectStatement.SuspendLayout()
        CType(Me.DataGridViewDefinedStatement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelManualStatement.SuspendLayout()
        Me.TabControlAnalyse.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(619, 480)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Result"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 2)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridViewAnalyse)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChartAnalyse)
        Me.SplitContainer1.Size = New System.Drawing.Size(615, 476)
        Me.SplitContainer1.SplitterDistance = 332
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 0
        '
        'DataGridViewAnalyse
        '
        Me.DataGridViewAnalyse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAnalyse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewAnalyse.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewAnalyse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewAnalyse.Name = "DataGridViewAnalyse"
        Me.DataGridViewAnalyse.ReadOnly = True
        Me.DataGridViewAnalyse.RowHeadersWidth = 51
        Me.DataGridViewAnalyse.RowTemplate.Height = 24
        Me.DataGridViewAnalyse.Size = New System.Drawing.Size(332, 476)
        Me.DataGridViewAnalyse.TabIndex = 1
        '
        'ChartAnalyse
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartAnalyse.ChartAreas.Add(ChartArea1)
        Me.ChartAnalyse.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.ChartAnalyse.Legends.Add(Legend1)
        Me.ChartAnalyse.Location = New System.Drawing.Point(0, 0)
        Me.ChartAnalyse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChartAnalyse.Name = "ChartAnalyse"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartAnalyse.Series.Add(Series1)
        Me.ChartAnalyse.Size = New System.Drawing.Size(280, 476)
        Me.ChartAnalyse.TabIndex = 1
        Me.ChartAnalyse.Text = "ChartAnalyse"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.Controls.Add(Me.ButtonAddDefined)
        Me.TabPage1.Controls.Add(Me.RadioButtonManualstatement)
        Me.TabPage1.Controls.Add(Me.RadioButtonDefinedStatement)
        Me.TabPage1.Controls.Add(Me.PanelSelectStatement)
        Me.TabPage1.Controls.Add(Me.PanelManualStatement)
        Me.TabPage1.Controls.Add(Me.CheckBoxReset)
        Me.TabPage1.Controls.Add(Me.ButtonTableModel)
        Me.TabPage1.Controls.Add(Me.ButtonAnalyse)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(619, 480)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Statement"
        '
        'ButtonAddDefined
        '
        Me.ButtonAddDefined.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonAddDefined.Location = New System.Drawing.Point(6, 418)
        Me.ButtonAddDefined.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonAddDefined.Name = "ButtonAddDefined"
        Me.ButtonAddDefined.Size = New System.Drawing.Size(142, 26)
        Me.ButtonAddDefined.TabIndex = 18
        Me.ButtonAddDefined.Text = "Add to defined"
        Me.ButtonAddDefined.UseVisualStyleBackColor = True
        '
        'RadioButtonManualstatement
        '
        Me.RadioButtonManualstatement.AutoSize = True
        Me.RadioButtonManualstatement.Location = New System.Drawing.Point(155, 5)
        Me.RadioButtonManualstatement.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButtonManualstatement.Name = "RadioButtonManualstatement"
        Me.RadioButtonManualstatement.Size = New System.Drawing.Size(109, 17)
        Me.RadioButtonManualstatement.TabIndex = 17
        Me.RadioButtonManualstatement.Text = "Manual statement"
        Me.RadioButtonManualstatement.UseVisualStyleBackColor = True
        '
        'RadioButtonDefinedStatement
        '
        Me.RadioButtonDefinedStatement.AutoSize = True
        Me.RadioButtonDefinedStatement.Checked = True
        Me.RadioButtonDefinedStatement.Location = New System.Drawing.Point(6, 5)
        Me.RadioButtonDefinedStatement.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButtonDefinedStatement.Name = "RadioButtonDefinedStatement"
        Me.RadioButtonDefinedStatement.Size = New System.Drawing.Size(142, 17)
        Me.RadioButtonDefinedStatement.TabIndex = 16
        Me.RadioButtonDefinedStatement.TabStop = True
        Me.RadioButtonDefinedStatement.Text = "Select defined statement"
        Me.RadioButtonDefinedStatement.UseVisualStyleBackColor = True
        '
        'PanelSelectStatement
        '
        Me.PanelSelectStatement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSelectStatement.BackColor = System.Drawing.Color.Silver
        Me.PanelSelectStatement.Controls.Add(Me.DataGridViewDefinedStatement)
        Me.PanelSelectStatement.Location = New System.Drawing.Point(6, 26)
        Me.PanelSelectStatement.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelSelectStatement.Name = "PanelSelectStatement"
        Me.PanelSelectStatement.Size = New System.Drawing.Size(600, 110)
        Me.PanelSelectStatement.TabIndex = 15
        '
        'DataGridViewDefinedStatement
        '
        Me.DataGridViewDefinedStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDefinedStatement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewDefinedStatement.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewDefinedStatement.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewDefinedStatement.Name = "DataGridViewDefinedStatement"
        Me.DataGridViewDefinedStatement.ReadOnly = True
        Me.DataGridViewDefinedStatement.RowHeadersWidth = 51
        Me.DataGridViewDefinedStatement.RowTemplate.Height = 24
        Me.DataGridViewDefinedStatement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewDefinedStatement.Size = New System.Drawing.Size(600, 110)
        Me.DataGridViewDefinedStatement.TabIndex = 0
        '
        'PanelManualStatement
        '
        Me.PanelManualStatement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelManualStatement.BackColor = System.Drawing.Color.Silver
        Me.PanelManualStatement.Controls.Add(Me.CheckBox3DEnabled)
        Me.PanelManualStatement.Controls.Add(Me.Label5)
        Me.PanelManualStatement.Controls.Add(Me.ComboBoxGraphType)
        Me.PanelManualStatement.Controls.Add(Me.Label4)
        Me.PanelManualStatement.Controls.Add(Me.TextBoxCategory)
        Me.PanelManualStatement.Controls.Add(Me.Label3)
        Me.PanelManualStatement.Controls.Add(Me.TextBoxGrouping)
        Me.PanelManualStatement.Controls.Add(Me.Label2)
        Me.PanelManualStatement.Controls.Add(Me.TextBoxTotal)
        Me.PanelManualStatement.Controls.Add(Me.Label1)
        Me.PanelManualStatement.Controls.Add(Me.TextBoxTitle)
        Me.PanelManualStatement.Controls.Add(Me.TextBoxSQL)
        Me.PanelManualStatement.Location = New System.Drawing.Point(6, 141)
        Me.PanelManualStatement.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelManualStatement.Name = "PanelManualStatement"
        Me.PanelManualStatement.Size = New System.Drawing.Size(600, 272)
        Me.PanelManualStatement.TabIndex = 14
        '
        'CheckBox3DEnabled
        '
        Me.CheckBox3DEnabled.AutoSize = True
        Me.CheckBox3DEnabled.Location = New System.Drawing.Point(132, 138)
        Me.CheckBox3DEnabled.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox3DEnabled.Name = "CheckBox3DEnabled"
        Me.CheckBox3DEnabled.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox3DEnabled.TabIndex = 25
        Me.CheckBox3DEnabled.Text = "3D Enabled"
        Me.CheckBox3DEnabled.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 110)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Graph type"
        '
        'ComboBoxGraphType
        '
        Me.ComboBoxGraphType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxGraphType.FormattingEnabled = True
        Me.ComboBoxGraphType.Location = New System.Drawing.Point(132, 110)
        Me.ComboBoxGraphType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxGraphType.Name = "ComboBoxGraphType"
        Me.ComboBoxGraphType.Size = New System.Drawing.Size(445, 21)
        Me.ComboBoxGraphType.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 87)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Name category"
        '
        'TextBoxCategory
        '
        Me.TextBoxCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCategory.Location = New System.Drawing.Point(132, 88)
        Me.TextBoxCategory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxCategory.Name = "TextBoxCategory"
        Me.TextBoxCategory.Size = New System.Drawing.Size(445, 20)
        Me.TextBoxCategory.TabIndex = 21
        Me.TextBoxCategory.Text = "Category"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Name grouping"
        '
        'TextBoxGrouping
        '
        Me.TextBoxGrouping.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGrouping.Location = New System.Drawing.Point(132, 65)
        Me.TextBoxGrouping.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxGrouping.Name = "TextBoxGrouping"
        Me.TextBoxGrouping.Size = New System.Drawing.Size(445, 20)
        Me.TextBoxGrouping.TabIndex = 19
        Me.TextBoxGrouping.Text = "Grouping"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Name calculation"
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTotal.Location = New System.Drawing.Point(132, 40)
        Me.TextBoxTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(445, 20)
        Me.TextBoxTotal.TabIndex = 17
        Me.TextBoxTotal.Text = "Total"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Graph title"
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTitle.Location = New System.Drawing.Point(132, 15)
        Me.TextBoxTitle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.Size = New System.Drawing.Size(445, 20)
        Me.TextBoxTitle.TabIndex = 15
        '
        'TextBoxSQL
        '
        Me.TextBoxSQL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSQL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSQL.Location = New System.Drawing.Point(23, 159)
        Me.TextBoxSQL.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxSQL.Multiline = True
        Me.TextBoxSQL.Name = "TextBoxSQL"
        Me.TextBoxSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxSQL.Size = New System.Drawing.Size(554, 96)
        Me.TextBoxSQL.TabIndex = 14
        '
        'CheckBoxReset
        '
        Me.CheckBoxReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxReset.AutoSize = True
        Me.CheckBoxReset.Checked = True
        Me.CheckBoxReset.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxReset.Location = New System.Drawing.Point(414, 455)
        Me.CheckBoxReset.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBoxReset.Name = "CheckBoxReset"
        Me.CheckBoxReset.Size = New System.Drawing.Size(84, 17)
        Me.CheckBoxReset.TabIndex = 9
        Me.CheckBoxReset.Text = "Reset graph"
        Me.CheckBoxReset.UseVisualStyleBackColor = True
        '
        'ButtonTableModel
        '
        Me.ButtonTableModel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonTableModel.Location = New System.Drawing.Point(6, 446)
        Me.ButtonTableModel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonTableModel.Name = "ButtonTableModel"
        Me.ButtonTableModel.Size = New System.Drawing.Size(142, 26)
        Me.ButtonTableModel.TabIndex = 2
        Me.ButtonTableModel.Text = "Create Table for Model"
        Me.ButtonTableModel.UseVisualStyleBackColor = True
        '
        'ButtonAnalyse
        '
        Me.ButtonAnalyse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAnalyse.Location = New System.Drawing.Point(509, 418)
        Me.ButtonAnalyse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonAnalyse.Name = "ButtonAnalyse"
        Me.ButtonAnalyse.Size = New System.Drawing.Size(97, 58)
        Me.ButtonAnalyse.TabIndex = 1
        Me.ButtonAnalyse.Text = "Analyse"
        Me.ButtonAnalyse.UseVisualStyleBackColor = True
        '
        'TabControlAnalyse
        '
        Me.TabControlAnalyse.Controls.Add(Me.TabPage1)
        Me.TabControlAnalyse.Controls.Add(Me.TabPage2)
        Me.TabControlAnalyse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlAnalyse.Location = New System.Drawing.Point(0, 0)
        Me.TabControlAnalyse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControlAnalyse.Name = "TabControlAnalyse"
        Me.TabControlAnalyse.SelectedIndex = 0
        Me.TabControlAnalyse.Size = New System.Drawing.Size(627, 506)
        Me.TabControlAnalyse.TabIndex = 0
        '
        'FrmModelAnalyser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 506)
        Me.Controls.Add(Me.TabControlAnalyse)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmModelAnalyser"
        Me.Text = "Model Analyser"
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridViewAnalyse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartAnalyse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.PanelSelectStatement.ResumeLayout(False)
        CType(Me.DataGridViewDefinedStatement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelManualStatement.ResumeLayout(False)
        Me.PanelManualStatement.PerformLayout()
        Me.TabControlAnalyse.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridViewAnalyse As System.Windows.Forms.DataGridView
    Friend WithEvents ChartAnalyse As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonAnalyse As System.Windows.Forms.Button
    Friend WithEvents TabControlAnalyse As System.Windows.Forms.TabControl
    Friend WithEvents ButtonTableModel As System.Windows.Forms.Button
    Friend WithEvents CheckBoxReset As System.Windows.Forms.CheckBox
    Friend WithEvents PanelSelectStatement As System.Windows.Forms.Panel
    Friend WithEvents PanelManualStatement As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxGraphType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCategory As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxGrouping As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTitle As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSQL As System.Windows.Forms.TextBox
    Friend WithEvents RadioButtonManualstatement As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDefinedStatement As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox3DEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewDefinedStatement As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonAddDefined As System.Windows.Forms.Button
End Class

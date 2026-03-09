''' <summary>
''' Import data from excel sheets with helper routines for to make advanced import
''' routines with associations and other entities
''' </summary>
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmImportExcel
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
        Me.TextBoxConnection = New System.Windows.Forms.TextBox()
        Me.OpenExcelFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxExcelFile = New System.Windows.Forms.TextBox()
        Me.ButtonSelect = New System.Windows.Forms.Button()
        Me.DataGridViewExcel = New System.Windows.Forms.DataGridView()
        Me.TextBoxTableNo = New System.Windows.Forms.TextBox()
        Me.RadioButtonExcel = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCSV = New System.Windows.Forms.RadioButton()
        Me.TabControlExcel = New System.Windows.Forms.TabControl()
        Me.TabPageLoadExcel = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ButtonSaveDefinitions = New System.Windows.Forms.Button()
        Me.ButtonLoadDefinitions = New System.Windows.Forms.Button()
        Me.ButtonExecute = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.DataGridViewMappings = New System.Windows.Forms.DataGridView()
        Me.TabPageNormalizer = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxClassName = New System.Windows.Forms.TextBox()
        Me.ButtonCreateModel = New System.Windows.Forms.Button()
        Me.CheckBoxOptimize = New System.Windows.Forms.CheckBox()
        Me.SplitContainerNormalizer = New System.Windows.Forms.SplitContainer()
        Me.DataGridViewNormalizer = New System.Windows.Forms.DataGridView()
        Me.DataGridViewDistinctField = New System.Windows.Forms.DataGridView()
        Me.ComboBoxFields = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownPercentage = New System.Windows.Forms.NumericUpDown()
        Me.ButtonNormalizer = New System.Windows.Forms.Button()
        Me.ProgressBarNormalizer = New System.Windows.Forms.ProgressBar()
        Me.SaveFileDialogDef = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridViewExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlExcel.SuspendLayout()
        Me.TabPageLoadExcel.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewMappings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageNormalizer.SuspendLayout()
        CType(Me.SplitContainerNormalizer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerNormalizer.Panel1.SuspendLayout()
        Me.SplitContainerNormalizer.Panel2.SuspendLayout()
        Me.SplitContainerNormalizer.SuspendLayout()
        CType(Me.DataGridViewNormalizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDistinctField, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxConnection
        '
        Me.TextBoxConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxConnection.Location = New System.Drawing.Point(567, 30)
        Me.TextBoxConnection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxConnection.Multiline = True
        Me.TextBoxConnection.Name = "TextBoxConnection"
        Me.TextBoxConnection.Size = New System.Drawing.Size(275, 57)
        Me.TextBoxConnection.TabIndex = 0
        '
        'OpenExcelFileDialog
        '
        Me.OpenExcelFileDialog.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(564, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Connectionstring"
        '
        'TextBoxExcelFile
        '
        Me.TextBoxExcelFile.Location = New System.Drawing.Point(15, 34)
        Me.TextBoxExcelFile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxExcelFile.Name = "TextBoxExcelFile"
        Me.TextBoxExcelFile.Size = New System.Drawing.Size(360, 22)
        Me.TextBoxExcelFile.TabIndex = 2
        '
        'ButtonSelect
        '
        Me.ButtonSelect.Location = New System.Drawing.Point(381, 30)
        Me.ButtonSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonSelect.Name = "ButtonSelect"
        Me.ButtonSelect.Size = New System.Drawing.Size(155, 32)
        Me.ButtonSelect.TabIndex = 4
        Me.ButtonSelect.Text = "Select Excel file"
        Me.ButtonSelect.UseVisualStyleBackColor = True
        '
        'DataGridViewExcel
        '
        Me.DataGridViewExcel.AllowUserToAddRows = False
        Me.DataGridViewExcel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewExcel.Location = New System.Drawing.Point(0, 95)
        Me.DataGridViewExcel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewExcel.Name = "DataGridViewExcel"
        Me.DataGridViewExcel.RowHeadersWidth = 51
        Me.DataGridViewExcel.RowTemplate.Height = 24
        Me.DataGridViewExcel.Size = New System.Drawing.Size(837, 428)
        Me.DataGridViewExcel.TabIndex = 6
        '
        'TextBoxTableNo
        '
        Me.TextBoxTableNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTableNo.Location = New System.Drawing.Point(743, 4)
        Me.TextBoxTableNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxTableNo.Name = "TextBoxTableNo"
        Me.TextBoxTableNo.Size = New System.Drawing.Size(57, 22)
        Me.TextBoxTableNo.TabIndex = 11
        Me.TextBoxTableNo.Text = "0"
        '
        'RadioButtonExcel
        '
        Me.RadioButtonExcel.AutoSize = True
        Me.RadioButtonExcel.Checked = True
        Me.RadioButtonExcel.Location = New System.Drawing.Point(15, 9)
        Me.RadioButtonExcel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonExcel.Name = "RadioButtonExcel"
        Me.RadioButtonExcel.Size = New System.Drawing.Size(61, 20)
        Me.RadioButtonExcel.TabIndex = 38
        Me.RadioButtonExcel.TabStop = True
        Me.RadioButtonExcel.Text = "Excel"
        Me.RadioButtonExcel.UseVisualStyleBackColor = True
        '
        'RadioButtonCSV
        '
        Me.RadioButtonCSV.AutoSize = True
        Me.RadioButtonCSV.Location = New System.Drawing.Point(83, 9)
        Me.RadioButtonCSV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonCSV.Name = "RadioButtonCSV"
        Me.RadioButtonCSV.Size = New System.Drawing.Size(55, 20)
        Me.RadioButtonCSV.TabIndex = 39
        Me.RadioButtonCSV.TabStop = True
        Me.RadioButtonCSV.Text = "CSV"
        Me.RadioButtonCSV.UseVisualStyleBackColor = True
        Me.RadioButtonCSV.Visible = False
        '
        'TabControlExcel
        '
        Me.TabControlExcel.Controls.Add(Me.TabPageLoadExcel)
        Me.TabControlExcel.Controls.Add(Me.TabPage2)
        Me.TabControlExcel.Controls.Add(Me.TabPageNormalizer)
        Me.TabControlExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlExcel.Location = New System.Drawing.Point(0, 0)
        Me.TabControlExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControlExcel.Name = "TabControlExcel"
        Me.TabControlExcel.SelectedIndex = 0
        Me.TabControlExcel.Size = New System.Drawing.Size(851, 559)
        Me.TabControlExcel.TabIndex = 40
        '
        'TabPageLoadExcel
        '
        Me.TabPageLoadExcel.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageLoadExcel.Controls.Add(Me.DataGridViewExcel)
        Me.TabPageLoadExcel.Controls.Add(Me.RadioButtonCSV)
        Me.TabPageLoadExcel.Controls.Add(Me.TextBoxExcelFile)
        Me.TabPageLoadExcel.Controls.Add(Me.RadioButtonExcel)
        Me.TabPageLoadExcel.Controls.Add(Me.TextBoxConnection)
        Me.TabPageLoadExcel.Controls.Add(Me.Label1)
        Me.TabPageLoadExcel.Controls.Add(Me.ButtonSelect)
        Me.TabPageLoadExcel.Controls.Add(Me.TextBoxTableNo)
        Me.TabPageLoadExcel.Location = New System.Drawing.Point(4, 25)
        Me.TabPageLoadExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageLoadExcel.Name = "TabPageLoadExcel"
        Me.TabPageLoadExcel.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageLoadExcel.Size = New System.Drawing.Size(843, 530)
        Me.TabPageLoadExcel.TabIndex = 0
        Me.TabPageLoadExcel.Text = "Load Excel data"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.ButtonSaveDefinitions)
        Me.TabPage2.Controls.Add(Me.ButtonLoadDefinitions)
        Me.TabPage2.Controls.Add(Me.ButtonExecute)
        Me.TabPage2.Controls.Add(Me.ProgressBar)
        Me.TabPage2.Controls.Add(Me.DataGridViewMappings)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(843, 530)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Import Definitions"
        '
        'ButtonSaveDefinitions
        '
        Me.ButtonSaveDefinitions.Location = New System.Drawing.Point(189, 7)
        Me.ButtonSaveDefinitions.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSaveDefinitions.Name = "ButtonSaveDefinitions"
        Me.ButtonSaveDefinitions.Size = New System.Drawing.Size(171, 28)
        Me.ButtonSaveDefinitions.TabIndex = 41
        Me.ButtonSaveDefinitions.Text = "Save definitions"
        Me.ButtonSaveDefinitions.UseVisualStyleBackColor = True
        '
        'ButtonLoadDefinitions
        '
        Me.ButtonLoadDefinitions.Location = New System.Drawing.Point(11, 7)
        Me.ButtonLoadDefinitions.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonLoadDefinitions.Name = "ButtonLoadDefinitions"
        Me.ButtonLoadDefinitions.Size = New System.Drawing.Size(171, 28)
        Me.ButtonLoadDefinitions.TabIndex = 40
        Me.ButtonLoadDefinitions.Text = "Load definitions"
        Me.ButtonLoadDefinitions.UseVisualStyleBackColor = True
        '
        'ButtonExecute
        '
        Me.ButtonExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonExecute.Location = New System.Drawing.Point(676, 7)
        Me.ButtonExecute.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonExecute.Name = "ButtonExecute"
        Me.ButtonExecute.Size = New System.Drawing.Size(160, 28)
        Me.ButtonExecute.TabIndex = 39
        Me.ButtonExecute.Text = "Execute Import"
        Me.ButtonExecute.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(3, 41)
        Me.ProgressBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(837, 23)
        Me.ProgressBar.TabIndex = 38
        '
        'DataGridViewMappings
        '
        Me.DataGridViewMappings.AllowUserToOrderColumns = True
        Me.DataGridViewMappings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewMappings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewMappings.ColumnHeadersHeight = 29
        Me.DataGridViewMappings.Location = New System.Drawing.Point(4, 70)
        Me.DataGridViewMappings.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewMappings.MultiSelect = False
        Me.DataGridViewMappings.Name = "DataGridViewMappings"
        Me.DataGridViewMappings.RowHeadersWidth = 51
        Me.DataGridViewMappings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewMappings.Size = New System.Drawing.Size(836, 457)
        Me.DataGridViewMappings.StandardTab = True
        Me.DataGridViewMappings.TabIndex = 0
        '
        'TabPageNormalizer
        '
        Me.TabPageNormalizer.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageNormalizer.Controls.Add(Me.Label3)
        Me.TabPageNormalizer.Controls.Add(Me.TextBoxClassName)
        Me.TabPageNormalizer.Controls.Add(Me.ButtonCreateModel)
        Me.TabPageNormalizer.Controls.Add(Me.CheckBoxOptimize)
        Me.TabPageNormalizer.Controls.Add(Me.SplitContainerNormalizer)
        Me.TabPageNormalizer.Controls.Add(Me.Label2)
        Me.TabPageNormalizer.Controls.Add(Me.NumericUpDownPercentage)
        Me.TabPageNormalizer.Controls.Add(Me.ButtonNormalizer)
        Me.TabPageNormalizer.Controls.Add(Me.ProgressBarNormalizer)
        Me.TabPageNormalizer.Location = New System.Drawing.Point(4, 25)
        Me.TabPageNormalizer.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageNormalizer.Name = "TabPageNormalizer"
        Me.TabPageNormalizer.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageNormalizer.Size = New System.Drawing.Size(843, 530)
        Me.TabPageNormalizer.TabIndex = 2
        Me.TabPageNormalizer.Text = "Normalizer"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(467, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Classname"
        '
        'TextBoxClassName
        '
        Me.TextBoxClassName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxClassName.Location = New System.Drawing.Point(549, 9)
        Me.TextBoxClassName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxClassName.Name = "TextBoxClassName"
        Me.TextBoxClassName.Size = New System.Drawing.Size(159, 22)
        Me.TextBoxClassName.TabIndex = 49
        '
        'ButtonCreateModel
        '
        Me.ButtonCreateModel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCreateModel.Enabled = False
        Me.ButtonCreateModel.Location = New System.Drawing.Point(715, 7)
        Me.ButtonCreateModel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonCreateModel.Name = "ButtonCreateModel"
        Me.ButtonCreateModel.Size = New System.Drawing.Size(120, 27)
        Me.ButtonCreateModel.TabIndex = 48
        Me.ButtonCreateModel.Text = "Create Model"
        Me.ButtonCreateModel.UseVisualStyleBackColor = True
        '
        'CheckBoxOptimize
        '
        Me.CheckBoxOptimize.AutoSize = True
        Me.CheckBoxOptimize.Checked = True
        Me.CheckBoxOptimize.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxOptimize.Location = New System.Drawing.Point(335, 10)
        Me.CheckBoxOptimize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxOptimize.Name = "CheckBoxOptimize"
        Me.CheckBoxOptimize.Size = New System.Drawing.Size(81, 20)
        Me.CheckBoxOptimize.TabIndex = 47
        Me.CheckBoxOptimize.Text = "Optimize"
        Me.CheckBoxOptimize.UseVisualStyleBackColor = True
        '
        'SplitContainerNormalizer
        '
        Me.SplitContainerNormalizer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerNormalizer.Location = New System.Drawing.Point(0, 69)
        Me.SplitContainerNormalizer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainerNormalizer.Name = "SplitContainerNormalizer"
        '
        'SplitContainerNormalizer.Panel1
        '
        Me.SplitContainerNormalizer.Panel1.Controls.Add(Me.DataGridViewNormalizer)
        '
        'SplitContainerNormalizer.Panel2
        '
        Me.SplitContainerNormalizer.Panel2.Controls.Add(Me.DataGridViewDistinctField)
        Me.SplitContainerNormalizer.Panel2.Controls.Add(Me.ComboBoxFields)
        Me.SplitContainerNormalizer.Size = New System.Drawing.Size(840, 458)
        Me.SplitContainerNormalizer.SplitterDistance = 608
        Me.SplitContainerNormalizer.TabIndex = 46
        '
        'DataGridViewNormalizer
        '
        Me.DataGridViewNormalizer.AllowUserToAddRows = False
        Me.DataGridViewNormalizer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewNormalizer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewNormalizer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewNormalizer.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewNormalizer.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewNormalizer.Name = "DataGridViewNormalizer"
        Me.DataGridViewNormalizer.RowHeadersWidth = 51
        Me.DataGridViewNormalizer.Size = New System.Drawing.Size(608, 458)
        Me.DataGridViewNormalizer.TabIndex = 39
        '
        'DataGridViewDistinctField
        '
        Me.DataGridViewDistinctField.AllowUserToAddRows = False
        Me.DataGridViewDistinctField.AllowUserToOrderColumns = True
        Me.DataGridViewDistinctField.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDistinctField.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewDistinctField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDistinctField.Location = New System.Drawing.Point(5, 33)
        Me.DataGridViewDistinctField.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewDistinctField.Name = "DataGridViewDistinctField"
        Me.DataGridViewDistinctField.RowHeadersWidth = 51
        Me.DataGridViewDistinctField.RowTemplate.Height = 24
        Me.DataGridViewDistinctField.Size = New System.Drawing.Size(224, 425)
        Me.DataGridViewDistinctField.TabIndex = 44
        '
        'ComboBoxFields
        '
        Me.ComboBoxFields.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxFields.FormattingEnabled = True
        Me.ComboBoxFields.Location = New System.Drawing.Point(3, 2)
        Me.ComboBoxFields.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxFields.Name = "ComboBoxFields"
        Me.ComboBoxFields.Size = New System.Drawing.Size(227, 24)
        Me.ComboBoxFields.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Percentage"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDownPercentage
        '
        Me.NumericUpDownPercentage.Location = New System.Drawing.Point(232, 7)
        Me.NumericUpDownPercentage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumericUpDownPercentage.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownPercentage.Name = "NumericUpDownPercentage"
        Me.NumericUpDownPercentage.Size = New System.Drawing.Size(91, 22)
        Me.NumericUpDownPercentage.TabIndex = 42
        Me.NumericUpDownPercentage.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'ButtonNormalizer
        '
        Me.ButtonNormalizer.Location = New System.Drawing.Point(8, 7)
        Me.ButtonNormalizer.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonNormalizer.Name = "ButtonNormalizer"
        Me.ButtonNormalizer.Size = New System.Drawing.Size(131, 27)
        Me.ButtonNormalizer.TabIndex = 41
        Me.ButtonNormalizer.Text = "Evaluate model"
        Me.ButtonNormalizer.UseVisualStyleBackColor = True
        '
        'ProgressBarNormalizer
        '
        Me.ProgressBarNormalizer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarNormalizer.Location = New System.Drawing.Point(3, 41)
        Me.ProgressBarNormalizer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBarNormalizer.Name = "ProgressBarNormalizer"
        Me.ProgressBarNormalizer.Size = New System.Drawing.Size(837, 23)
        Me.ProgressBarNormalizer.TabIndex = 40
        '
        'FrmImportExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 559)
        Me.Controls.Add(Me.TabControlExcel)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmImportExcel"
        Me.Text = "IDEA Excel Importer"
        CType(Me.DataGridViewExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlExcel.ResumeLayout(False)
        Me.TabPageLoadExcel.ResumeLayout(False)
        Me.TabPageLoadExcel.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewMappings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageNormalizer.ResumeLayout(False)
        Me.TabPageNormalizer.PerformLayout()
        Me.SplitContainerNormalizer.Panel1.ResumeLayout(False)
        Me.SplitContainerNormalizer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerNormalizer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerNormalizer.ResumeLayout(False)
        CType(Me.DataGridViewNormalizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDistinctField, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxConnection As System.Windows.Forms.TextBox
    Friend WithEvents OpenExcelFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxExcelFile As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSelect As System.Windows.Forms.Button
    Friend WithEvents DataGridViewExcel As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxTableNo As System.Windows.Forms.TextBox
    Friend WithEvents RadioButtonExcel As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCSV As System.Windows.Forms.RadioButton
    Friend WithEvents TabControlExcel As System.Windows.Forms.TabControl
    Friend WithEvents TabPageLoadExcel As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewMappings As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonExecute As System.Windows.Forms.Button
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents SaveFileDialogDef As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ButtonLoadDefinitions As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveDefinitions As System.Windows.Forms.Button
    Friend WithEvents TabPageNormalizer As System.Windows.Forms.TabPage
    Friend WithEvents ButtonNormalizer As System.Windows.Forms.Button
    Friend WithEvents ProgressBarNormalizer As System.Windows.Forms.ProgressBar
    Friend WithEvents DataGridViewNormalizer As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownPercentage As System.Windows.Forms.NumericUpDown
    Friend WithEvents ComboBoxFields As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewDistinctField As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainerNormalizer As System.Windows.Forms.SplitContainer
    Friend WithEvents CheckBoxOptimize As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonCreateModel As System.Windows.Forms.Button
    Friend WithEvents TextBoxClassName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArchitectureWizard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArchitectureWizard))
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.TabPagePattern = New System.Windows.Forms.TabPage()
        Me.CheckBoxCreateInterfaces = New System.Windows.Forms.CheckBox()
        Me.DataGridViewPatterns = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPagePreceedingModule = New System.Windows.Forms.TabPage()
        Me.CheckBoxIncludeWerkmap = New System.Windows.Forms.CheckBox()
        Me.DataGridViewPreceedingModules = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPageTemplate = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBoxDiagram = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonConfidencialHigh = New System.Windows.Forms.RadioButton()
        Me.RadioButtonConfidenceMedium = New System.Windows.Forms.RadioButton()
        Me.RadioButtonConfidenceLow = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxNotes = New System.Windows.Forms.TextBox()
        Me.TextBoxProject = New System.Windows.Forms.TextBox()
        Me.TextBoxInfo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxWorkPackage = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTemplatePackage = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageValidate = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxPatternInterface = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPatternSelected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxModulesSelected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTemplateSelected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCIAClassification = New System.Windows.Forms.CheckBox()
        Me.CheckBoxModuleCreated = New System.Windows.Forms.CheckBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ButtonFinish = New System.Windows.Forms.Button()
        Me.CheckBoxCloseFinish = New System.Windows.Forms.CheckBox()
        Me.TabPagePattern.SuspendLayout()
        CType(Me.DataGridViewPatterns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePreceedingModule.SuspendLayout()
        CType(Me.DataGridViewPreceedingModules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageTemplate.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageValidate.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPrevious.Enabled = False
        Me.ButtonPrevious.Location = New System.Drawing.Point(261, 536)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(84, 31)
        Me.ButtonPrevious.TabIndex = 10
        Me.ButtonPrevious.Text = "Previous"
        Me.ButtonPrevious.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonNext.Location = New System.Drawing.Point(354, 536)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(86, 31)
        Me.ButtonNext.TabIndex = 9
        Me.ButtonNext.Text = "Next"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'TabPagePattern
        '
        Me.TabPagePattern.BackColor = System.Drawing.SystemColors.Control
        Me.TabPagePattern.Controls.Add(Me.CheckBoxCreateInterfaces)
        Me.TabPagePattern.Controls.Add(Me.DataGridViewPatterns)
        Me.TabPagePattern.Controls.Add(Me.TextBox2)
        Me.TabPagePattern.Controls.Add(Me.Label5)
        Me.TabPagePattern.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePattern.Name = "TabPagePattern"
        Me.TabPagePattern.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePattern.Size = New System.Drawing.Size(535, 503)
        Me.TabPagePattern.TabIndex = 2
        Me.TabPagePattern.Text = "Select pattern"
        '
        'CheckBoxCreateInterfaces
        '
        Me.CheckBoxCreateInterfaces.AutoSize = True
        Me.CheckBoxCreateInterfaces.Checked = True
        Me.CheckBoxCreateInterfaces.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCreateInterfaces.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.CheckBoxCreateInterfaces.Location = New System.Drawing.Point(7, 75)
        Me.CheckBoxCreateInterfaces.Name = "CheckBoxCreateInterfaces"
        Me.CheckBoxCreateInterfaces.Size = New System.Drawing.Size(320, 21)
        Me.CheckBoxCreateInterfaces.TabIndex = 20
        Me.CheckBoxCreateInterfaces.Text = "Include creating interfaces for selected pattern"
        Me.CheckBoxCreateInterfaces.UseVisualStyleBackColor = True
        '
        'DataGridViewPatterns
        '
        Me.DataGridViewPatterns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewPatterns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPatterns.Location = New System.Drawing.Point(2, 134)
        Me.DataGridViewPatterns.MultiSelect = False
        Me.DataGridViewPatterns.Name = "DataGridViewPatterns"
        Me.DataGridViewPatterns.ReadOnly = True
        Me.DataGridViewPatterns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPatterns.Size = New System.Drawing.Size(533, 366)
        Me.DataGridViewPatterns.TabIndex = 19
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(2, 0)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(533, 60)
        Me.TextBox2.TabIndex = 18
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "In this wizard select the relevant patterns for the current active module"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label5.Location = New System.Drawing.Point(6, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Select the relevant pattern"
        '
        'TabPagePreceedingModule
        '
        Me.TabPagePreceedingModule.BackColor = System.Drawing.SystemColors.Control
        Me.TabPagePreceedingModule.Controls.Add(Me.CheckBoxIncludeWerkmap)
        Me.TabPagePreceedingModule.Controls.Add(Me.DataGridViewPreceedingModules)
        Me.TabPagePreceedingModule.Controls.Add(Me.TextBox1)
        Me.TabPagePreceedingModule.Controls.Add(Me.Label7)
        Me.TabPagePreceedingModule.Controls.Add(Me.Label6)
        Me.TabPagePreceedingModule.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePreceedingModule.Name = "TabPagePreceedingModule"
        Me.TabPagePreceedingModule.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePreceedingModule.Size = New System.Drawing.Size(535, 503)
        Me.TabPagePreceedingModule.TabIndex = 1
        Me.TabPagePreceedingModule.Text = "Select Preceding Modules"
        '
        'CheckBoxIncludeWerkmap
        '
        Me.CheckBoxIncludeWerkmap.AutoSize = True
        Me.CheckBoxIncludeWerkmap.Checked = True
        Me.CheckBoxIncludeWerkmap.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxIncludeWerkmap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.CheckBoxIncludeWerkmap.Location = New System.Drawing.Point(6, 69)
        Me.CheckBoxIncludeWerkmap.Name = "CheckBoxIncludeWerkmap"
        Me.CheckBoxIncludeWerkmap.Size = New System.Drawing.Size(329, 21)
        Me.CheckBoxIncludeWerkmap.TabIndex = 18
        Me.CheckBoxIncludeWerkmap.Text = "Including preceding modules under construction"
        Me.CheckBoxIncludeWerkmap.UseVisualStyleBackColor = True
        '
        'DataGridViewPreceedingModules
        '
        Me.DataGridViewPreceedingModules.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewPreceedingModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPreceedingModules.Location = New System.Drawing.Point(2, 131)
        Me.DataGridViewPreceedingModules.Name = "DataGridViewPreceedingModules"
        Me.DataGridViewPreceedingModules.ReadOnly = True
        Me.DataGridViewPreceedingModules.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridViewPreceedingModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPreceedingModules.Size = New System.Drawing.Size(533, 372)
        Me.DataGridViewPreceedingModules.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(0, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(533, 60)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(611, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Select new elements for the diagram"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label6.Location = New System.Drawing.Point(6, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Select  one or more of the existing modules"
        '
        'TabPageTemplate
        '
        Me.TabPageTemplate.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageTemplate.Controls.Add(Me.Label3)
        Me.TabPageTemplate.Controls.Add(Me.Label8)
        Me.TabPageTemplate.Controls.Add(Me.ComboBoxDiagram)
        Me.TabPageTemplate.Controls.Add(Me.GroupBox1)
        Me.TabPageTemplate.Controls.Add(Me.Label4)
        Me.TabPageTemplate.Controls.Add(Me.TextBoxNotes)
        Me.TabPageTemplate.Controls.Add(Me.TextBoxProject)
        Me.TabPageTemplate.Controls.Add(Me.TextBoxInfo)
        Me.TabPageTemplate.Controls.Add(Me.Label2)
        Me.TabPageTemplate.Controls.Add(Me.Label1)
        Me.TabPageTemplate.Controls.Add(Me.ComboBoxWorkPackage)
        Me.TabPageTemplate.Controls.Add(Me.ComboBoxTemplatePackage)
        Me.TabPageTemplate.Location = New System.Drawing.Point(4, 22)
        Me.TabPageTemplate.Name = "TabPageTemplate"
        Me.TabPageTemplate.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTemplate.Size = New System.Drawing.Size(535, 503)
        Me.TabPageTemplate.TabIndex = 0
        Me.TabPageTemplate.Text = "Select template and target package"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "#Module Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label8.Location = New System.Drawing.Point(6, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Select the template diagram"
        '
        'ComboBoxDiagram
        '
        Me.ComboBoxDiagram.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxDiagram.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboBoxDiagram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDiagram.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxDiagram.FormattingEnabled = True
        Me.ComboBoxDiagram.Location = New System.Drawing.Point(3, 73)
        Me.ComboBoxDiagram.Name = "ComboBoxDiagram"
        Me.ComboBoxDiagram.Size = New System.Drawing.Size(532, 26)
        Me.ComboBoxDiagram.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonConfidencialHigh)
        Me.GroupBox1.Controls.Add(Me.RadioButtonConfidenceMedium)
        Me.GroupBox1.Controls.Add(Me.RadioButtonConfidenceLow)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 275)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 46)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "#Confidentiality level"
        Me.GroupBox1.Visible = False
        '
        'RadioButtonConfidencialHigh
        '
        Me.RadioButtonConfidencialHigh.AutoSize = True
        Me.RadioButtonConfidencialHigh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.RadioButtonConfidencialHigh.Location = New System.Drawing.Point(6, 18)
        Me.RadioButtonConfidencialHigh.Name = "RadioButtonConfidencialHigh"
        Me.RadioButtonConfidencialHigh.Size = New System.Drawing.Size(78, 22)
        Me.RadioButtonConfidencialHigh.TabIndex = 5
        Me.RadioButtonConfidencialHigh.Text = "High (3)"
        Me.RadioButtonConfidencialHigh.UseVisualStyleBackColor = True
        Me.RadioButtonConfidencialHigh.Visible = False
        '
        'RadioButtonConfidenceMedium
        '
        Me.RadioButtonConfidenceMedium.AutoSize = True
        Me.RadioButtonConfidenceMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.RadioButtonConfidenceMedium.Location = New System.Drawing.Point(106, 18)
        Me.RadioButtonConfidenceMedium.Name = "RadioButtonConfidenceMedium"
        Me.RadioButtonConfidenceMedium.Size = New System.Drawing.Size(101, 22)
        Me.RadioButtonConfidenceMedium.TabIndex = 6
        Me.RadioButtonConfidenceMedium.Text = "Medium (2)"
        Me.RadioButtonConfidenceMedium.UseVisualStyleBackColor = True
        Me.RadioButtonConfidenceMedium.Visible = False
        '
        'RadioButtonConfidenceLow
        '
        Me.RadioButtonConfidenceLow.AutoSize = True
        Me.RadioButtonConfidenceLow.Checked = True
        Me.RadioButtonConfidenceLow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.RadioButtonConfidenceLow.Location = New System.Drawing.Point(213, 18)
        Me.RadioButtonConfidenceLow.Name = "RadioButtonConfidenceLow"
        Me.RadioButtonConfidenceLow.Size = New System.Drawing.Size(76, 22)
        Me.RadioButtonConfidenceLow.TabIndex = 7
        Me.RadioButtonConfidenceLow.TabStop = True
        Me.RadioButtonConfidenceLow.Text = "Low (1)"
        Me.RadioButtonConfidenceLow.UseVisualStyleBackColor = True
        Me.RadioButtonConfidenceLow.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label4.Location = New System.Drawing.Point(6, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "#Module Description"
        '
        'TextBoxNotes
        '
        Me.TextBoxNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNotes.Location = New System.Drawing.Point(3, 355)
        Me.TextBoxNotes.Multiline = True
        Me.TextBoxNotes.Name = "TextBoxNotes"
        Me.TextBoxNotes.Size = New System.Drawing.Size(532, 142)
        Me.TextBoxNotes.TabIndex = 8
        '
        'TextBoxProject
        '
        Me.TextBoxProject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProject.Location = New System.Drawing.Point(3, 234)
        Me.TextBoxProject.Name = "TextBoxProject"
        Me.TextBoxProject.Size = New System.Drawing.Size(532, 24)
        Me.TextBoxProject.TabIndex = 4
        '
        'TextBoxInfo
        '
        Me.TextBoxInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInfo.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxInfo.Location = New System.Drawing.Point(2, 0)
        Me.TextBoxInfo.Multiline = True
        Me.TextBoxInfo.Name = "TextBoxInfo"
        Me.TextBoxInfo.ReadOnly = True
        Me.TextBoxInfo.Size = New System.Drawing.Size(533, 49)
        Me.TextBoxInfo.TabIndex = 2
        Me.TextBoxInfo.Text = "In this wizard you can create a new solution architecture structure based on a te" &
    "mplate. After creating the solution package you can define extra elements for fi" &
    "lling your solution. "
        Me.TextBoxInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label2.Location = New System.Drawing.Point(6, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select the working package"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label1.Location = New System.Drawing.Point(6, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select the template package"
        '
        'ComboBoxWorkPackage
        '
        Me.ComboBoxWorkPackage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxWorkPackage.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ComboBoxWorkPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxWorkPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxWorkPackage.FormattingEnabled = True
        Me.ComboBoxWorkPackage.Location = New System.Drawing.Point(3, 181)
        Me.ComboBoxWorkPackage.Name = "ComboBoxWorkPackage"
        Me.ComboBoxWorkPackage.Size = New System.Drawing.Size(532, 26)
        Me.ComboBoxWorkPackage.TabIndex = 3
        '
        'ComboBoxTemplatePackage
        '
        Me.ComboBoxTemplatePackage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxTemplatePackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTemplatePackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTemplatePackage.FormattingEnabled = True
        Me.ComboBoxTemplatePackage.Location = New System.Drawing.Point(3, 123)
        Me.ComboBoxTemplatePackage.Name = "ComboBoxTemplatePackage"
        Me.ComboBoxTemplatePackage.Size = New System.Drawing.Size(532, 26)
        Me.ComboBoxTemplatePackage.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPageTemplate)
        Me.TabControl1.Controls.Add(Me.TabPagePreceedingModule)
        Me.TabControl1.Controls.Add(Me.TabPagePattern)
        Me.TabControl1.Controls.Add(Me.TabPageValidate)
        Me.TabControl1.Location = New System.Drawing.Point(-4, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(543, 529)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'TabPageValidate
        '
        Me.TabPageValidate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPageValidate.Controls.Add(Me.GroupBox3)
        Me.TabPageValidate.Controls.Add(Me.GroupBox2)
        Me.TabPageValidate.Controls.Add(Me.TextBox3)
        Me.TabPageValidate.Location = New System.Drawing.Point(4, 22)
        Me.TabPageValidate.Name = "TabPageValidate"
        Me.TabPageValidate.Size = New System.Drawing.Size(535, 503)
        Me.TabPageValidate.TabIndex = 3
        Me.TabPageValidate.Text = "Validate architecture"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(510, 176)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Press Finish to complete the wizard"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.CheckBoxPatternInterface)
        Me.GroupBox2.Controls.Add(Me.CheckBoxPatternSelected)
        Me.GroupBox2.Controls.Add(Me.CheckBoxModulesSelected)
        Me.GroupBox2.Controls.Add(Me.CheckBoxTemplateSelected)
        Me.GroupBox2.Controls.Add(Me.CheckBoxCIAClassification)
        Me.GroupBox2.Controls.Add(Me.CheckBoxModuleCreated)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(12, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(510, 230)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Wizard result"
        '
        'CheckBoxPatternInterface
        '
        Me.CheckBoxPatternInterface.AutoSize = True
        Me.CheckBoxPatternInterface.Location = New System.Drawing.Point(17, 205)
        Me.CheckBoxPatternInterface.Name = "CheckBoxPatternInterface"
        Me.CheckBoxPatternInterface.Size = New System.Drawing.Size(269, 17)
        Me.CheckBoxPatternInterface.TabIndex = 5
        Me.CheckBoxPatternInterface.Text = "Interface for Pattern selected and shown in diagram"
        Me.CheckBoxPatternInterface.UseVisualStyleBackColor = True
        '
        'CheckBoxPatternSelected
        '
        Me.CheckBoxPatternSelected.AutoSize = True
        Me.CheckBoxPatternSelected.Enabled = False
        Me.CheckBoxPatternSelected.Location = New System.Drawing.Point(17, 169)
        Me.CheckBoxPatternSelected.Name = "CheckBoxPatternSelected"
        Me.CheckBoxPatternSelected.Size = New System.Drawing.Size(227, 17)
        Me.CheckBoxPatternSelected.TabIndex = 4
        Me.CheckBoxPatternSelected.Text = "Pattern selected and connected to module"
        Me.CheckBoxPatternSelected.UseVisualStyleBackColor = True
        '
        'CheckBoxModulesSelected
        '
        Me.CheckBoxModulesSelected.AutoSize = True
        Me.CheckBoxModulesSelected.Enabled = False
        Me.CheckBoxModulesSelected.Location = New System.Drawing.Point(17, 133)
        Me.CheckBoxModulesSelected.Name = "CheckBoxModulesSelected"
        Me.CheckBoxModulesSelected.Size = New System.Drawing.Size(234, 17)
        Me.CheckBoxModulesSelected.TabIndex = 3
        Me.CheckBoxModulesSelected.Text = "Preceding modules selected and connected"
        Me.CheckBoxModulesSelected.UseVisualStyleBackColor = True
        '
        'CheckBoxTemplateSelected
        '
        Me.CheckBoxTemplateSelected.AutoSize = True
        Me.CheckBoxTemplateSelected.Enabled = False
        Me.CheckBoxTemplateSelected.Location = New System.Drawing.Point(17, 25)
        Me.CheckBoxTemplateSelected.Name = "CheckBoxTemplateSelected"
        Me.CheckBoxTemplateSelected.Size = New System.Drawing.Size(113, 17)
        Me.CheckBoxTemplateSelected.TabIndex = 2
        Me.CheckBoxTemplateSelected.Text = "Template selected"
        Me.CheckBoxTemplateSelected.UseVisualStyleBackColor = True
        '
        'CheckBoxCIAClassification
        '
        Me.CheckBoxCIAClassification.AutoSize = True
        Me.CheckBoxCIAClassification.Enabled = False
        Me.CheckBoxCIAClassification.Location = New System.Drawing.Point(17, 97)
        Me.CheckBoxCIAClassification.Name = "CheckBoxCIAClassification"
        Me.CheckBoxCIAClassification.Size = New System.Drawing.Size(254, 17)
        Me.CheckBoxCIAClassification.TabIndex = 1
        Me.CheckBoxCIAClassification.Text = "CIA Classification defined and used in the wizard"
        Me.CheckBoxCIAClassification.UseVisualStyleBackColor = True
        '
        'CheckBoxModuleCreated
        '
        Me.CheckBoxModuleCreated.AutoSize = True
        Me.CheckBoxModuleCreated.Enabled = False
        Me.CheckBoxModuleCreated.Location = New System.Drawing.Point(17, 61)
        Me.CheckBoxModuleCreated.Name = "CheckBoxModuleCreated"
        Me.CheckBoxModuleCreated.Size = New System.Drawing.Size(156, 17)
        Me.CheckBoxModuleCreated.TabIndex = 0
        Me.CheckBoxModuleCreated.Text = "Module created in package"
        Me.CheckBoxModuleCreated.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TextBox3.Location = New System.Drawing.Point(0, 3)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(533, 60)
        Me.TextBox3.TabIndex = 19
        Me.TextBox3.TabStop = False
        Me.TextBox3.Text = "In the last step of the wizard you can validate your diagram(s) to see if the cor" &
    "rect elements and connectors are created after the Finish button is pressed"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonFinish
        '
        Me.ButtonFinish.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFinish.Enabled = False
        Me.ButtonFinish.Location = New System.Drawing.Point(449, 536)
        Me.ButtonFinish.Name = "ButtonFinish"
        Me.ButtonFinish.Size = New System.Drawing.Size(86, 31)
        Me.ButtonFinish.TabIndex = 12
        Me.ButtonFinish.Text = "Finish"
        Me.ButtonFinish.UseVisualStyleBackColor = True
        '
        'CheckBoxCloseFinish
        '
        Me.CheckBoxCloseFinish.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxCloseFinish.AutoSize = True
        Me.CheckBoxCloseFinish.Location = New System.Drawing.Point(7, 549)
        Me.CheckBoxCloseFinish.Name = "CheckBoxCloseFinish"
        Me.CheckBoxCloseFinish.Size = New System.Drawing.Size(103, 17)
        Me.CheckBoxCloseFinish.TabIndex = 13
        Me.CheckBoxCloseFinish.Text = "Close after finish"
        Me.CheckBoxCloseFinish.UseVisualStyleBackColor = True
        '
        'FrmArchitectureWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 579)
        Me.Controls.Add(Me.CheckBoxCloseFinish)
        Me.Controls.Add(Me.ButtonFinish)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmArchitectureWizard"
        Me.Text = "Architecture Wizard"
        Me.TopMost = True
        Me.TabPagePattern.ResumeLayout(False)
        Me.TabPagePattern.PerformLayout()
        CType(Me.DataGridViewPatterns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePreceedingModule.ResumeLayout(False)
        Me.TabPagePreceedingModule.PerformLayout()
        CType(Me.DataGridViewPreceedingModules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageTemplate.ResumeLayout(False)
        Me.TabPageTemplate.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageValidate.ResumeLayout(False)
        Me.TabPageValidate.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonPrevious As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents TabPagePattern As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewPatterns As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPagePreceedingModule As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewPreceedingModules As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabPageTemplate As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonConfidencialHigh As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonConfidenceMedium As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonConfidenceLow As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNotes As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxProject As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxWorkPackage As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxTemplatePackage As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageValidate As System.Windows.Forms.TabPage
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonFinish As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxPatternSelected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxModulesSelected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTemplateSelected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCIAClassification As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxModuleCreated As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCreateInterfaces As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxPatternInterface As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxIncludeWerkmap As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDiagram As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxCloseFinish As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

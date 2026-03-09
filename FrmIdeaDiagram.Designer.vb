''' <summary>
''' Form for IDEA routines specific for UML class entities. For every type of
''' element a specific form is generated. This makes working with the IDEA AddOn
''' easier.
''' </summary>
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class FrmIdeaDiagram
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIdeaDiagram))
        Me.ButtonUnselectAll = New System.Windows.Forms.Button()
        Me.ButtonToggleAll = New System.Windows.Forms.Button()
        Me.ButtonSelectAll = New System.Windows.Forms.Button()
        Me.ListBoxElements = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelDiagramName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPrefix = New System.Windows.Forms.TextBox()
        Me.ListBoxType = New System.Windows.Forms.ListBox()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.CheckBoxAttributeAssociation = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.RadioButtonOneOne = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOneMany = New System.Windows.Forms.RadioButton()
        Me.RadioButtonManyToMany = New System.Windows.Forms.RadioButton()
        Me.ButtonCardinality = New System.Windows.Forms.Button()
        Me.CheckBoxRestoreColor = New System.Windows.Forms.CheckBox()
        Me.ButtonArchiMateColoring = New System.Windows.Forms.Button()
        Me.ButtonElement2Original = New System.Windows.Forms.Button()
        Me.CheckBoxOriginalPackage = New System.Windows.Forms.CheckBox()
        Me.ComboBoxSecGroup = New System.Windows.Forms.ComboBox()
        Me.CheckBoxUserLock = New System.Windows.Forms.CheckBox()
        Me.ButtonLockElements = New System.Windows.Forms.Button()
        Me.CheckBoxMakeHidden = New System.Windows.Forms.CheckBox()
        Me.ButtonShowHidden = New System.Windows.Forms.Button()
        Me.ButtonCollectElements = New System.Windows.Forms.Button()
        Me.CheckBoxCloseWindowExtraReady = New System.Windows.Forms.CheckBox()
        Me.ButtonHideEmbedded = New System.Windows.Forms.Button()
        Me.RadioButtonOrthogonalRounded = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLateralVertical = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTreeVertical = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAutoroute = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDirect = New System.Windows.Forms.RadioButton()
        Me.ButtonMappingStyle = New System.Windows.Forms.Button()
        Me.CheckBoxIsHidden = New System.Windows.Forms.CheckBox()
        Me.ButtonSwitchMapping = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CheckBoxCreateAll = New System.Windows.Forms.CheckBox()
        Me.TextBoxFilter = New System.Windows.Forms.TextBox()
        Me.DataGridViewSQL = New System.Windows.Forms.DataGridView()
        Me.TextBoxTemplate = New System.Windows.Forms.TextBox()
        Me.TextBoxStatement = New System.Windows.Forms.TextBox()
        Me.DataGridViewStatement = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ButtonMakeSQL = New System.Windows.Forms.Button()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBoxStereoType = New System.Windows.Forms.TextBox()
        Me.CheckBoxGenerateName = New System.Windows.Forms.CheckBox()
        Me.ButtonMatchNames = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBoxLoadData = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMapTarget = New System.Windows.Forms.CheckBox()
        Me.ButtonLoadMappings = New System.Windows.Forms.Button()
        Me.ButtonGenerateMapping = New System.Windows.Forms.Button()
        Me.ButtonMappingTarget = New System.Windows.Forms.Button()
        Me.ButtonMappingSource = New System.Windows.Forms.Button()
        Me.DataGridViewMapping = New System.Windows.Forms.DataGridView()
        Me.ListBoxMappingElement = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelMappingDiagramName = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBoxFullModelCopy = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ComboBoxTargetPackage = New System.Windows.Forms.ComboBox()
        Me.ButtonUnselectGenerate = New System.Windows.Forms.Button()
        Me.ButtonToggleGenerate = New System.Windows.Forms.Button()
        Me.ButtonSelectAllGenerate = New System.Windows.Forms.Button()
        Me.ButtonGenerateItems = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SaveSQLFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTipSwitch = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridViewSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewStatement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonUnselectAll
        '
        Me.ButtonUnselectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonUnselectAll.Location = New System.Drawing.Point(265, 593)
        Me.ButtonUnselectAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonUnselectAll.Name = "ButtonUnselectAll"
        Me.ButtonUnselectAll.Size = New System.Drawing.Size(100, 28)
        Me.ButtonUnselectAll.TabIndex = 21
        Me.ButtonUnselectAll.Text = "Unselect All"
        Me.ButtonUnselectAll.UseVisualStyleBackColor = True
        '
        'ButtonToggleAll
        '
        Me.ButtonToggleAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonToggleAll.Location = New System.Drawing.Point(141, 593)
        Me.ButtonToggleAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonToggleAll.Name = "ButtonToggleAll"
        Me.ButtonToggleAll.Size = New System.Drawing.Size(100, 28)
        Me.ButtonToggleAll.TabIndex = 20
        Me.ButtonToggleAll.Text = "Toggle"
        Me.ButtonToggleAll.UseVisualStyleBackColor = True
        '
        'ButtonSelectAll
        '
        Me.ButtonSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSelectAll.Location = New System.Drawing.Point(20, 593)
        Me.ButtonSelectAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSelectAll.Name = "ButtonSelectAll"
        Me.ButtonSelectAll.Size = New System.Drawing.Size(100, 28)
        Me.ButtonSelectAll.TabIndex = 19
        Me.ButtonSelectAll.Text = "Select All"
        Me.ButtonSelectAll.UseVisualStyleBackColor = True
        '
        'ListBoxElements
        '
        Me.ListBoxElements.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxElements.FormattingEnabled = True
        Me.ListBoxElements.Location = New System.Drawing.Point(20, 87)
        Me.ListBoxElements.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxElements.Name = "ListBoxElements"
        Me.ListBoxElements.Size = New System.Drawing.Size(511, 429)
        Me.ListBoxElements.TabIndex = 18
        Me.ToolTipSwitch.SetToolTip(Me.ListBoxElements, "Available elements in the diagram that can be used for transformation to a new ta" &
        "rget type")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Selected elements"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Selected diagram"
        '
        'LabelDiagramName
        '
        Me.LabelDiagramName.AutoSize = True
        Me.LabelDiagramName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDiagramName.Location = New System.Drawing.Point(147, 18)
        Me.LabelDiagramName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDiagramName.Name = "LabelDiagramName"
        Me.LabelDiagramName.Size = New System.Drawing.Size(148, 24)
        Me.LabelDiagramName.TabIndex = 22
        Me.LabelDiagramName.Text = "Diagram Name"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(573, 50)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Prefix"
        '
        'TextBoxPrefix
        '
        Me.TextBoxPrefix.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPrefix.Location = New System.Drawing.Point(575, 75)
        Me.TextBoxPrefix.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxPrefix.Name = "TextBoxPrefix"
        Me.TextBoxPrefix.Size = New System.Drawing.Size(367, 22)
        Me.TextBoxPrefix.TabIndex = 24
        Me.ToolTipSwitch.SetToolTip(Me.TextBoxPrefix, "Use a prefix when you want to rename the elements with a prefix")
        '
        'ListBoxType
        '
        Me.ListBoxType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxType.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ListBoxType.FormattingEnabled = True
        Me.ListBoxType.ItemHeight = 16
        Me.ListBoxType.Items.AddRange(New Object() {"Class", "Interface", "Table", "XSD", "ArchiMate_BusinessObject", "ArchiMate_DataObject"})
        Me.ListBoxType.Location = New System.Drawing.Point(576, 122)
        Me.ListBoxType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxType.Name = "ListBoxType"
        Me.ListBoxType.Size = New System.Drawing.Size(363, 100)
        Me.ListBoxType.TabIndex = 25
        Me.ToolTipSwitch.SetToolTip(Me.ListBoxType, "Select what element type to generate based on the selected elements in the listbo" &
        "x")
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGenerate.Location = New System.Drawing.Point(656, 583)
        Me.ButtonGenerate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(285, 39)
        Me.ButtonGenerate.TabIndex = 26
        Me.ButtonGenerate.Text = "Generate elements and attributes"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'CheckBoxAttributeAssociation
        '
        Me.CheckBoxAttributeAssociation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxAttributeAssociation.AutoSize = True
        Me.CheckBoxAttributeAssociation.Checked = True
        Me.CheckBoxAttributeAssociation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxAttributeAssociation.Location = New System.Drawing.Point(584, 243)
        Me.CheckBoxAttributeAssociation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxAttributeAssociation.Name = "CheckBoxAttributeAssociation"
        Me.CheckBoxAttributeAssociation.Size = New System.Drawing.Size(191, 20)
        Me.CheckBoxAttributeAssociation.TabIndex = 27
        Me.CheckBoxAttributeAssociation.Text = "Create attribute association"
        Me.CheckBoxAttributeAssociation.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(575, 487)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(363, 63)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "With this option you can generate new items of a type based on the elements found" &
    " in the selected diagram in one easy step."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(964, 599)
        Me.TabControl1.TabIndex = 29
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightGray
        Me.TabPage3.Controls.Add(Me.RadioButtonOneOne)
        Me.TabPage3.Controls.Add(Me.RadioButtonOneMany)
        Me.TabPage3.Controls.Add(Me.RadioButtonManyToMany)
        Me.TabPage3.Controls.Add(Me.ButtonCardinality)
        Me.TabPage3.Controls.Add(Me.CheckBoxRestoreColor)
        Me.TabPage3.Controls.Add(Me.ButtonArchiMateColoring)
        Me.TabPage3.Controls.Add(Me.ButtonElement2Original)
        Me.TabPage3.Controls.Add(Me.CheckBoxOriginalPackage)
        Me.TabPage3.Controls.Add(Me.ComboBoxSecGroup)
        Me.TabPage3.Controls.Add(Me.CheckBoxUserLock)
        Me.TabPage3.Controls.Add(Me.ButtonLockElements)
        Me.TabPage3.Controls.Add(Me.CheckBoxMakeHidden)
        Me.TabPage3.Controls.Add(Me.ButtonShowHidden)
        Me.TabPage3.Controls.Add(Me.ButtonCollectElements)
        Me.TabPage3.Controls.Add(Me.CheckBoxCloseWindowExtraReady)
        Me.TabPage3.Controls.Add(Me.ButtonHideEmbedded)
        Me.TabPage3.Controls.Add(Me.RadioButtonOrthogonalRounded)
        Me.TabPage3.Controls.Add(Me.RadioButtonLateralVertical)
        Me.TabPage3.Controls.Add(Me.RadioButtonTreeVertical)
        Me.TabPage3.Controls.Add(Me.RadioButtonAutoroute)
        Me.TabPage3.Controls.Add(Me.RadioButtonDirect)
        Me.TabPage3.Controls.Add(Me.ButtonMappingStyle)
        Me.TabPage3.Controls.Add(Me.CheckBoxIsHidden)
        Me.TabPage3.Controls.Add(Me.ButtonSwitchMapping)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Size = New System.Drawing.Size(956, 570)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Helper"
        '
        'RadioButtonOneOne
        '
        Me.RadioButtonOneOne.AutoSize = True
        Me.RadioButtonOneOne.Location = New System.Drawing.Point(891, 176)
        Me.RadioButtonOneOne.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButtonOneOne.Name = "RadioButtonOneOne"
        Me.RadioButtonOneOne.Size = New System.Drawing.Size(48, 20)
        Me.RadioButtonOneOne.TabIndex = 56
        Me.RadioButtonOneOne.TabStop = True
        Me.RadioButtonOneOne.Text = "1..1"
        Me.RadioButtonOneOne.UseVisualStyleBackColor = True
        '
        'RadioButtonOneMany
        '
        Me.RadioButtonOneMany.AutoSize = True
        Me.RadioButtonOneMany.Location = New System.Drawing.Point(825, 176)
        Me.RadioButtonOneMany.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButtonOneMany.Name = "RadioButtonOneMany"
        Me.RadioButtonOneMany.Size = New System.Drawing.Size(46, 20)
        Me.RadioButtonOneMany.TabIndex = 55
        Me.RadioButtonOneMany.TabStop = True
        Me.RadioButtonOneMany.Text = "1..*"
        Me.RadioButtonOneMany.UseVisualStyleBackColor = True
        '
        'RadioButtonManyToMany
        '
        Me.RadioButtonManyToMany.AutoSize = True
        Me.RadioButtonManyToMany.Checked = True
        Me.RadioButtonManyToMany.Location = New System.Drawing.Point(760, 176)
        Me.RadioButtonManyToMany.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButtonManyToMany.Name = "RadioButtonManyToMany"
        Me.RadioButtonManyToMany.Size = New System.Drawing.Size(44, 20)
        Me.RadioButtonManyToMany.TabIndex = 54
        Me.RadioButtonManyToMany.TabStop = True
        Me.RadioButtonManyToMany.Text = "*..*"
        Me.RadioButtonManyToMany.UseVisualStyleBackColor = True
        '
        'ButtonCardinality
        '
        Me.ButtonCardinality.Location = New System.Drawing.Point(20, 133)
        Me.ButtonCardinality.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCardinality.Name = "ButtonCardinality"
        Me.ButtonCardinality.Size = New System.Drawing.Size(724, 39)
        Me.ButtonCardinality.TabIndex = 52
        Me.ButtonCardinality.Text = "Cardinality default"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonCardinality, "Set alle the connectors to a default cardinality")
        Me.ButtonCardinality.UseVisualStyleBackColor = True
        '
        'CheckBoxRestoreColor
        '
        Me.CheckBoxRestoreColor.AutoSize = True
        Me.CheckBoxRestoreColor.Location = New System.Drawing.Point(760, 411)
        Me.CheckBoxRestoreColor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxRestoreColor.Name = "CheckBoxRestoreColor"
        Me.CheckBoxRestoreColor.Size = New System.Drawing.Size(112, 20)
        Me.CheckBoxRestoreColor.TabIndex = 50
        Me.CheckBoxRestoreColor.Text = "Restore Color"
        Me.ToolTipSwitch.SetToolTip(Me.CheckBoxRestoreColor, "Set to default coloring of the ArchiMate elements in the diagram")
        Me.CheckBoxRestoreColor.UseVisualStyleBackColor = True
        '
        'ButtonArchiMateColoring
        '
        Me.ButtonArchiMateColoring.Location = New System.Drawing.Point(20, 411)
        Me.ButtonArchiMateColoring.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonArchiMateColoring.Name = "ButtonArchiMateColoring"
        Me.ButtonArchiMateColoring.Size = New System.Drawing.Size(724, 36)
        Me.ButtonArchiMateColoring.TabIndex = 49
        Me.ButtonArchiMateColoring.Text = "ArchiMate Coloring"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonArchiMateColoring, "Show elements border in ArchiMate aspect color")
        Me.ButtonArchiMateColoring.UseVisualStyleBackColor = True
        '
        'ButtonElement2Original
        '
        Me.ButtonElement2Original.Location = New System.Drawing.Point(20, 313)
        Me.ButtonElement2Original.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonElement2Original.Name = "ButtonElement2Original"
        Me.ButtonElement2Original.Size = New System.Drawing.Size(724, 34)
        Me.ButtonElement2Original.TabIndex = 47
        Me.ButtonElement2Original.Text = "Elements to original"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonElement2Original, "Return all the elements to the original package")
        Me.ButtonElement2Original.UseVisualStyleBackColor = True
        '
        'CheckBoxOriginalPackage
        '
        Me.CheckBoxOriginalPackage.AutoSize = True
        Me.CheckBoxOriginalPackage.Location = New System.Drawing.Point(756, 270)
        Me.CheckBoxOriginalPackage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxOriginalPackage.Name = "CheckBoxOriginalPackage"
        Me.CheckBoxOriginalPackage.Size = New System.Drawing.Size(165, 20)
        Me.CheckBoxOriginalPackage.TabIndex = 46
        Me.CheckBoxOriginalPackage.Text = "Store original package"
        Me.CheckBoxOriginalPackage.UseVisualStyleBackColor = True
        '
        'ComboBoxSecGroup
        '
        Me.ComboBoxSecGroup.FormattingEnabled = True
        Me.ComboBoxSecGroup.Location = New System.Drawing.Point(20, 511)
        Me.ComboBoxSecGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxSecGroup.Name = "ComboBoxSecGroup"
        Me.ComboBoxSecGroup.Size = New System.Drawing.Size(723, 24)
        Me.ComboBoxSecGroup.TabIndex = 45
        '
        'CheckBoxUserLock
        '
        Me.CheckBoxUserLock.AutoSize = True
        Me.CheckBoxUserLock.Location = New System.Drawing.Point(760, 474)
        Me.CheckBoxUserLock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxUserLock.Name = "CheckBoxUserLock"
        Me.CheckBoxUserLock.Size = New System.Drawing.Size(86, 20)
        Me.CheckBoxUserLock.TabIndex = 44
        Me.CheckBoxUserLock.Text = "User lock"
        Me.ToolTipSwitch.SetToolTip(Me.CheckBoxUserLock, "Generate a userlock of the current logged in user")
        Me.CheckBoxUserLock.UseVisualStyleBackColor = True
        '
        'ButtonLockElements
        '
        Me.ButtonLockElements.Location = New System.Drawing.Point(20, 465)
        Me.ButtonLockElements.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonLockElements.Name = "ButtonLockElements"
        Me.ButtonLockElements.Size = New System.Drawing.Size(724, 36)
        Me.ButtonLockElements.TabIndex = 42
        Me.ButtonLockElements.Text = "Lock elements on diagram"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonLockElements, "Lock the elements displayed on the diagram")
        Me.ButtonLockElements.UseVisualStyleBackColor = True
        '
        'CheckBoxMakeHidden
        '
        Me.CheckBoxMakeHidden.AutoSize = True
        Me.CheckBoxMakeHidden.Location = New System.Drawing.Point(760, 352)
        Me.CheckBoxMakeHidden.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxMakeHidden.Name = "CheckBoxMakeHidden"
        Me.CheckBoxMakeHidden.Size = New System.Drawing.Size(169, 20)
        Me.CheckBoxMakeHidden.TabIndex = 41
        Me.CheckBoxMakeHidden.Text = "Make connector hidden"
        Me.CheckBoxMakeHidden.UseVisualStyleBackColor = True
        '
        'ButtonShowHidden
        '
        Me.ButtonShowHidden.Location = New System.Drawing.Point(20, 359)
        Me.ButtonShowHidden.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonShowHidden.Name = "ButtonShowHidden"
        Me.ButtonShowHidden.Size = New System.Drawing.Size(724, 34)
        Me.ButtonShowHidden.TabIndex = 39
        Me.ButtonShowHidden.Text = "Show hidden connectors"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonShowHidden, "Show connectors on this diagram that are not visible in bold and in red")
        Me.ButtonShowHidden.UseVisualStyleBackColor = True
        '
        'ButtonCollectElements
        '
        Me.ButtonCollectElements.Location = New System.Drawing.Point(20, 261)
        Me.ButtonCollectElements.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonCollectElements.Name = "ButtonCollectElements"
        Me.ButtonCollectElements.Size = New System.Drawing.Size(724, 34)
        Me.ButtonCollectElements.TabIndex = 37
        Me.ButtonCollectElements.Text = "Collect Elements for Diagram"
        Me.ButtonCollectElements.UseVisualStyleBackColor = True
        '
        'CheckBoxCloseWindowExtraReady
        '
        Me.CheckBoxCloseWindowExtraReady.AutoSize = True
        Me.CheckBoxCloseWindowExtraReady.Checked = True
        Me.CheckBoxCloseWindowExtraReady.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCloseWindowExtraReady.Location = New System.Drawing.Point(20, 544)
        Me.CheckBoxCloseWindowExtraReady.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxCloseWindowExtraReady.Name = "CheckBoxCloseWindowExtraReady"
        Me.CheckBoxCloseWindowExtraReady.Size = New System.Drawing.Size(183, 20)
        Me.CheckBoxCloseWindowExtraReady.TabIndex = 36
        Me.CheckBoxCloseWindowExtraReady.Text = "Close window when ready"
        Me.CheckBoxCloseWindowExtraReady.UseVisualStyleBackColor = True
        '
        'ButtonHideEmbedded
        '
        Me.ButtonHideEmbedded.Location = New System.Drawing.Point(20, 206)
        Me.ButtonHideEmbedded.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonHideEmbedded.Name = "ButtonHideEmbedded"
        Me.ButtonHideEmbedded.Size = New System.Drawing.Size(724, 39)
        Me.ButtonHideEmbedded.TabIndex = 34
        Me.ButtonHideEmbedded.Text = "Hide embedded associations"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonHideEmbedded, "Hide assocations for entities that are  included in the borders of another entity" &
        ", otherwise show the association")
        Me.ButtonHideEmbedded.UseVisualStyleBackColor = True
        '
        'RadioButtonOrthogonalRounded
        '
        Me.RadioButtonOrthogonalRounded.AutoSize = True
        Me.RadioButtonOrthogonalRounded.Location = New System.Drawing.Point(767, 101)
        Me.RadioButtonOrthogonalRounded.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonOrthogonalRounded.Name = "RadioButtonOrthogonalRounded"
        Me.RadioButtonOrthogonalRounded.Size = New System.Drawing.Size(153, 20)
        Me.RadioButtonOrthogonalRounded.TabIndex = 33
        Me.RadioButtonOrthogonalRounded.Tag = "3"
        Me.RadioButtonOrthogonalRounded.Text = "Orthogonal Rounded"
        Me.RadioButtonOrthogonalRounded.UseVisualStyleBackColor = True
        '
        'RadioButtonLateralVertical
        '
        Me.RadioButtonLateralVertical.AutoSize = True
        Me.RadioButtonLateralVertical.Location = New System.Drawing.Point(636, 101)
        Me.RadioButtonLateralVertical.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonLateralVertical.Name = "RadioButtonLateralVertical"
        Me.RadioButtonLateralVertical.Size = New System.Drawing.Size(115, 20)
        Me.RadioButtonLateralVertical.TabIndex = 32
        Me.RadioButtonLateralVertical.Tag = "3"
        Me.RadioButtonLateralVertical.Text = "Lateral vertical"
        Me.RadioButtonLateralVertical.UseVisualStyleBackColor = True
        '
        'RadioButtonTreeVertical
        '
        Me.RadioButtonTreeVertical.AutoSize = True
        Me.RadioButtonTreeVertical.Location = New System.Drawing.Point(511, 101)
        Me.RadioButtonTreeVertical.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonTreeVertical.Name = "RadioButtonTreeVertical"
        Me.RadioButtonTreeVertical.Size = New System.Drawing.Size(103, 20)
        Me.RadioButtonTreeVertical.TabIndex = 31
        Me.RadioButtonTreeVertical.Tag = "3"
        Me.RadioButtonTreeVertical.Text = "Tree vertical"
        Me.RadioButtonTreeVertical.UseVisualStyleBackColor = True
        '
        'RadioButtonAutoroute
        '
        Me.RadioButtonAutoroute.AutoSize = True
        Me.RadioButtonAutoroute.Location = New System.Drawing.Point(411, 101)
        Me.RadioButtonAutoroute.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonAutoroute.Name = "RadioButtonAutoroute"
        Me.RadioButtonAutoroute.Size = New System.Drawing.Size(85, 20)
        Me.RadioButtonAutoroute.TabIndex = 4
        Me.RadioButtonAutoroute.Tag = "3"
        Me.RadioButtonAutoroute.Text = "Autoroute"
        Me.RadioButtonAutoroute.UseVisualStyleBackColor = True
        '
        'RadioButtonDirect
        '
        Me.RadioButtonDirect.AutoSize = True
        Me.RadioButtonDirect.Location = New System.Drawing.Point(332, 101)
        Me.RadioButtonDirect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonDirect.Name = "RadioButtonDirect"
        Me.RadioButtonDirect.Size = New System.Drawing.Size(63, 20)
        Me.RadioButtonDirect.TabIndex = 3
        Me.RadioButtonDirect.Tag = "1"
        Me.RadioButtonDirect.Text = "Direct"
        Me.RadioButtonDirect.UseVisualStyleBackColor = True
        '
        'ButtonMappingStyle
        '
        Me.ButtonMappingStyle.Location = New System.Drawing.Point(20, 54)
        Me.ButtonMappingStyle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonMappingStyle.Name = "ButtonMappingStyle"
        Me.ButtonMappingStyle.Size = New System.Drawing.Size(724, 39)
        Me.ButtonMappingStyle.TabIndex = 2
        Me.ButtonMappingStyle.Text = "Set linestyle for all connectors"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonMappingStyle, "Helper to switch association style")
        Me.ButtonMappingStyle.UseVisualStyleBackColor = True
        '
        'CheckBoxIsHidden
        '
        Me.CheckBoxIsHidden.AutoSize = True
        Me.CheckBoxIsHidden.Location = New System.Drawing.Point(756, 22)
        Me.CheckBoxIsHidden.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxIsHidden.Name = "CheckBoxIsHidden"
        Me.CheckBoxIsHidden.Size = New System.Drawing.Size(139, 20)
        Me.CheckBoxIsHidden.TabIndex = 1
        Me.CheckBoxIsHidden.Text = "Mapping is hidden"
        Me.CheckBoxIsHidden.UseVisualStyleBackColor = True
        '
        'ButtonSwitchMapping
        '
        Me.ButtonSwitchMapping.Location = New System.Drawing.Point(20, 14)
        Me.ButtonSwitchMapping.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSwitchMapping.Name = "ButtonSwitchMapping"
        Me.ButtonSwitchMapping.Size = New System.Drawing.Size(724, 36)
        Me.ButtonSwitchMapping.TabIndex = 0
        Me.ButtonSwitchMapping.Text = "Switch visibility mapping"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonSwitchMapping, "Helper to toggle the visibility for attribute associations")
        Me.ButtonSwitchMapping.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.LightGray
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.CheckBoxCreateAll)
        Me.TabPage4.Controls.Add(Me.TextBoxFilter)
        Me.TabPage4.Controls.Add(Me.DataGridViewSQL)
        Me.TabPage4.Controls.Add(Me.TextBoxTemplate)
        Me.TabPage4.Controls.Add(Me.TextBoxStatement)
        Me.TabPage4.Controls.Add(Me.DataGridViewStatement)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.ButtonMakeSQL)
        Me.TabPage4.Controls.Add(Me.ButtonLoad)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage4.Size = New System.Drawing.Size(956, 570)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "SQL generator"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(159, 218)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 16)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Filter"
        '
        'CheckBoxCreateAll
        '
        Me.CheckBoxCreateAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxCreateAll.AutoSize = True
        Me.CheckBoxCreateAll.Checked = True
        Me.CheckBoxCreateAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCreateAll.Location = New System.Drawing.Point(489, 217)
        Me.CheckBoxCreateAll.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxCreateAll.Name = "CheckBoxCreateAll"
        Me.CheckBoxCreateAll.Size = New System.Drawing.Size(86, 20)
        Me.CheckBoxCreateAll.TabIndex = 59
        Me.CheckBoxCreateAll.Text = "Create all"
        Me.CheckBoxCreateAll.UseVisualStyleBackColor = True
        '
        'TextBoxFilter
        '
        Me.TextBoxFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxFilter.Location = New System.Drawing.Point(203, 214)
        Me.TextBoxFilter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxFilter.Name = "TextBoxFilter"
        Me.TextBoxFilter.Size = New System.Drawing.Size(252, 22)
        Me.TextBoxFilter.TabIndex = 58
        Me.ToolTipSwitch.SetToolTip(Me.TextBoxFilter, "Filter the available select statements based on a group value")
        '
        'DataGridViewSQL
        '
        Me.DataGridViewSQL.AllowUserToAddRows = False
        Me.DataGridViewSQL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSQL.Location = New System.Drawing.Point(5, 26)
        Me.DataGridViewSQL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewSQL.Name = "DataGridViewSQL"
        Me.DataGridViewSQL.ReadOnly = True
        Me.DataGridViewSQL.RowHeadersWidth = 51
        Me.DataGridViewSQL.RowTemplate.Height = 24
        Me.DataGridViewSQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewSQL.Size = New System.Drawing.Size(941, 177)
        Me.DataGridViewSQL.TabIndex = 57
        Me.ToolTipSwitch.SetToolTip(Me.DataGridViewSQL, "See the already present statements and template combination available in the conf" &
        "iguratation")
        '
        'TextBoxTemplate
        '
        Me.TextBoxTemplate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTemplate.Location = New System.Drawing.Point(0, 347)
        Me.TextBoxTemplate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxTemplate.Multiline = True
        Me.TextBoxTemplate.Name = "TextBoxTemplate"
        Me.TextBoxTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxTemplate.Size = New System.Drawing.Size(952, 88)
        Me.TextBoxTemplate.TabIndex = 56
        Me.ToolTipSwitch.SetToolTip(Me.TextBoxTemplate, "Template to fill based on the SQL statement columns in the select")
        '
        'TextBoxStatement
        '
        Me.TextBoxStatement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxStatement.Location = New System.Drawing.Point(0, 251)
        Me.TextBoxStatement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxStatement.Multiline = True
        Me.TextBoxStatement.Name = "TextBoxStatement"
        Me.TextBoxStatement.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxStatement.Size = New System.Drawing.Size(952, 88)
        Me.TextBoxStatement.TabIndex = 55
        Me.ToolTipSwitch.SetToolTip(Me.TextBoxStatement, "SQL statement connected to the diagram active")
        '
        'DataGridViewStatement
        '
        Me.DataGridViewStatement.AllowUserToAddRows = False
        Me.DataGridViewStatement.AllowUserToDeleteRows = False
        Me.DataGridViewStatement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStatement.Location = New System.Drawing.Point(0, 439)
        Me.DataGridViewStatement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridViewStatement.Name = "DataGridViewStatement"
        Me.DataGridViewStatement.RowHeadersWidth = 51
        Me.DataGridViewStatement.Size = New System.Drawing.Size(953, 127)
        Me.DataGridViewStatement.TabIndex = 54
        Me.ToolTipSwitch.SetToolTip(Me.DataGridViewStatement, "Display  the example resultset in the grid")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 6)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 16)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Statement"
        '
        'ButtonMakeSQL
        '
        Me.ButtonMakeSQL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMakeSQL.Location = New System.Drawing.Point(593, 208)
        Me.ButtonMakeSQL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonMakeSQL.Name = "ButtonMakeSQL"
        Me.ButtonMakeSQL.Size = New System.Drawing.Size(355, 36)
        Me.ButtonMakeSQL.TabIndex = 47
        Me.ButtonMakeSQL.Text = "Make SQL"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonMakeSQL, "Generate the SQL file based on the SQL statement and the template")
        Me.ButtonMakeSQL.UseVisualStyleBackColor = True
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Location = New System.Drawing.Point(3, 208)
        Me.ButtonLoad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(151, 37)
        Me.ButtonLoad.TabIndex = 45
        Me.ButtonLoad.Text = "Load Grid"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonLoad, "Load grid to display results of the SQL statement")
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.TextBoxStereoType)
        Me.TabPage2.Controls.Add(Me.CheckBoxGenerateName)
        Me.TabPage2.Controls.Add(Me.ButtonMatchNames)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.CheckBoxLoadData)
        Me.TabPage2.Controls.Add(Me.CheckBoxMapTarget)
        Me.TabPage2.Controls.Add(Me.ButtonLoadMappings)
        Me.TabPage2.Controls.Add(Me.ButtonGenerateMapping)
        Me.TabPage2.Controls.Add(Me.ButtonMappingTarget)
        Me.TabPage2.Controls.Add(Me.ButtonMappingSource)
        Me.TabPage2.Controls.Add(Me.DataGridViewMapping)
        Me.TabPage2.Controls.Add(Me.ListBoxMappingElement)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.LabelMappingDiagramName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TabPage2.Size = New System.Drawing.Size(956, 570)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mapping"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 229)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(135, 16)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Connector stereotype"
        '
        'TextBoxStereoType
        '
        Me.TextBoxStereoType.Location = New System.Drawing.Point(11, 251)
        Me.TextBoxStereoType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxStereoType.Name = "TextBoxStereoType"
        Me.TextBoxStereoType.Size = New System.Drawing.Size(235, 22)
        Me.TextBoxStereoType.TabIndex = 36
        '
        'CheckBoxGenerateName
        '
        Me.CheckBoxGenerateName.AutoSize = True
        Me.CheckBoxGenerateName.Location = New System.Drawing.Point(13, 206)
        Me.CheckBoxGenerateName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxGenerateName.Name = "CheckBoxGenerateName"
        Me.CheckBoxGenerateName.Size = New System.Drawing.Size(122, 20)
        Me.CheckBoxGenerateName.TabIndex = 35
        Me.CheckBoxGenerateName.Text = "Generate name"
        Me.CheckBoxGenerateName.UseVisualStyleBackColor = True
        '
        'ButtonMatchNames
        '
        Me.ButtonMatchNames.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMatchNames.Enabled = False
        Me.ButtonMatchNames.Location = New System.Drawing.Point(692, 206)
        Me.ButtonMatchNames.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.ButtonMatchNames.Name = "ButtonMatchNames"
        Me.ButtonMatchNames.Size = New System.Drawing.Size(125, 33)
        Me.ButtonMatchNames.TabIndex = 34
        Me.ButtonMatchNames.Text = "Match names"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonMatchNames, "Create mappings for colums with the same name in the source and target columns in" &
        " the grid")
        Me.ButtonMatchNames.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(253, 171)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(429, 102)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = resources.GetString("Label7.Text")
        Me.ToolTipSwitch.SetToolTip(Me.Label7, resources.GetString("Label7.ToolTip"))
        '
        'CheckBoxLoadData
        '
        Me.CheckBoxLoadData.AutoSize = True
        Me.CheckBoxLoadData.Checked = True
        Me.CheckBoxLoadData.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxLoadData.Location = New System.Drawing.Point(13, 171)
        Me.CheckBoxLoadData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxLoadData.Name = "CheckBoxLoadData"
        Me.CheckBoxLoadData.Size = New System.Drawing.Size(90, 20)
        Me.CheckBoxLoadData.TabIndex = 32
        Me.CheckBoxLoadData.Text = "Load data"
        Me.ToolTipSwitch.SetToolTip(Me.CheckBoxLoadData, "Load the present elements into the data grid")
        Me.CheckBoxLoadData.UseVisualStyleBackColor = True
        '
        'CheckBoxMapTarget
        '
        Me.CheckBoxMapTarget.AutoSize = True
        Me.CheckBoxMapTarget.Checked = True
        Me.CheckBoxMapTarget.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxMapTarget.Location = New System.Drawing.Point(13, 190)
        Me.CheckBoxMapTarget.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxMapTarget.Name = "CheckBoxMapTarget"
        Me.CheckBoxMapTarget.Size = New System.Drawing.Size(107, 20)
        Me.CheckBoxMapTarget.TabIndex = 31
        Me.CheckBoxMapTarget.Text = "Map to target"
        Me.ToolTipSwitch.SetToolTip(Me.CheckBoxMapTarget, "Do a mapping to a target unselected is map to source")
        Me.CheckBoxMapTarget.UseVisualStyleBackColor = True
        '
        'ButtonLoadMappings
        '
        Me.ButtonLoadMappings.Location = New System.Drawing.Point(692, 242)
        Me.ButtonLoadMappings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonLoadMappings.Name = "ButtonLoadMappings"
        Me.ButtonLoadMappings.Size = New System.Drawing.Size(125, 31)
        Me.ButtonLoadMappings.TabIndex = 30
        Me.ButtonLoadMappings.Text = "Load Mappings"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonLoadMappings, "Load the already present mappings in the diagram in the grid")
        Me.ButtonLoadMappings.UseVisualStyleBackColor = True
        '
        'ButtonGenerateMapping
        '
        Me.ButtonGenerateMapping.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGenerateMapping.Location = New System.Drawing.Point(823, 206)
        Me.ButtonGenerateMapping.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.ButtonGenerateMapping.Name = "ButtonGenerateMapping"
        Me.ButtonGenerateMapping.Size = New System.Drawing.Size(125, 68)
        Me.ButtonGenerateMapping.TabIndex = 29
        Me.ButtonGenerateMapping.Text = "Generate mappings"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonGenerateMapping, "Generate the mappings based on the selected elements in the grid")
        Me.ButtonGenerateMapping.UseVisualStyleBackColor = True
        '
        'ButtonMappingTarget
        '
        Me.ButtonMappingTarget.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMappingTarget.Location = New System.Drawing.Point(692, 123)
        Me.ButtonMappingTarget.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.ButtonMappingTarget.Name = "ButtonMappingTarget"
        Me.ButtonMappingTarget.Size = New System.Drawing.Size(101, 33)
        Me.ButtonMappingTarget.TabIndex = 28
        Me.ButtonMappingTarget.Text = "To target"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonMappingTarget, "Move the selected elements to the target section (rightt) of the mapping grid")
        Me.ButtonMappingTarget.UseVisualStyleBackColor = True
        '
        'ButtonMappingSource
        '
        Me.ButtonMappingSource.Location = New System.Drawing.Point(144, 123)
        Me.ButtonMappingSource.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.ButtonMappingSource.Name = "ButtonMappingSource"
        Me.ButtonMappingSource.Size = New System.Drawing.Size(103, 33)
        Me.ButtonMappingSource.TabIndex = 27
        Me.ButtonMappingSource.Text = "To source"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonMappingSource, "Move the selected elements to the source section (left) of the mapping grid")
        Me.ButtonMappingSource.UseVisualStyleBackColor = True
        '
        'DataGridViewMapping
        '
        Me.DataGridViewMapping.AllowUserToOrderColumns = True
        Me.DataGridViewMapping.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMapping.Location = New System.Drawing.Point(-4, 276)
        Me.DataGridViewMapping.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.DataGridViewMapping.Name = "DataGridViewMapping"
        Me.DataGridViewMapping.RowHeadersWidth = 51
        Me.DataGridViewMapping.RowTemplate.Height = 24
        Me.DataGridViewMapping.Size = New System.Drawing.Size(964, 293)
        Me.DataGridViewMapping.TabIndex = 26
        '
        'ListBoxMappingElement
        '
        Me.ListBoxMappingElement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxMappingElement.FormattingEnabled = True
        Me.ListBoxMappingElement.Location = New System.Drawing.Point(253, 33)
        Me.ListBoxMappingElement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxMappingElement.Name = "ListBoxMappingElement"
        Me.ListBoxMappingElement.Size = New System.Drawing.Size(429, 89)
        Me.ListBoxMappingElement.TabIndex = 24
        Me.ToolTipSwitch.SetToolTip(Me.ListBoxMappingElement, "Availalbe elements available in the diagram")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 5)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Selected diagram"
        '
        'LabelMappingDiagramName
        '
        Me.LabelMappingDiagramName.AutoSize = True
        Me.LabelMappingDiagramName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMappingDiagramName.Location = New System.Drawing.Point(140, 5)
        Me.LabelMappingDiagramName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMappingDiagramName.Name = "LabelMappingDiagramName"
        Me.LabelMappingDiagramName.Size = New System.Drawing.Size(148, 24)
        Me.LabelMappingDiagramName.TabIndex = 25
        Me.LabelMappingDiagramName.Text = "Diagram Name"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.Controls.Add(Me.CheckBoxFullModelCopy)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.ComboBoxTargetPackage)
        Me.TabPage1.Controls.Add(Me.ButtonUnselectGenerate)
        Me.TabPage1.Controls.Add(Me.ButtonToggleGenerate)
        Me.TabPage1.Controls.Add(Me.ButtonSelectAllGenerate)
        Me.TabPage1.Controls.Add(Me.ButtonGenerateItems)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.ListBoxElements)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.CheckBoxAttributeAssociation)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ButtonGenerate)
        Me.TabPage1.Controls.Add(Me.ButtonSelectAll)
        Me.TabPage1.Controls.Add(Me.ListBoxType)
        Me.TabPage1.Controls.Add(Me.ButtonToggleAll)
        Me.TabPage1.Controls.Add(Me.TextBoxPrefix)
        Me.TabPage1.Controls.Add(Me.ButtonUnselectAll)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.LabelDiagramName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TabPage1.Size = New System.Drawing.Size(956, 570)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generate"
        '
        'CheckBoxFullModelCopy
        '
        Me.CheckBoxFullModelCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxFullModelCopy.AutoSize = True
        Me.CheckBoxFullModelCopy.Checked = True
        Me.CheckBoxFullModelCopy.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxFullModelCopy.Location = New System.Drawing.Point(584, 271)
        Me.CheckBoxFullModelCopy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxFullModelCopy.Name = "CheckBoxFullModelCopy"
        Me.CheckBoxFullModelCopy.Size = New System.Drawing.Size(124, 20)
        Me.CheckBoxFullModelCopy.TabIndex = 36
        Me.CheckBoxFullModelCopy.Text = "Full model copy"
        Me.CheckBoxFullModelCopy.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(576, 309)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 16)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Target package"
        '
        'ComboBoxTargetPackage
        '
        Me.ComboBoxTargetPackage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxTargetPackage.FormattingEnabled = True
        Me.ComboBoxTargetPackage.Location = New System.Drawing.Point(576, 334)
        Me.ComboBoxTargetPackage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxTargetPackage.Name = "ComboBoxTargetPackage"
        Me.ComboBoxTargetPackage.Size = New System.Drawing.Size(361, 24)
        Me.ComboBoxTargetPackage.TabIndex = 34
        Me.ToolTipSwitch.SetToolTip(Me.ComboBoxTargetPackage, "Select the package where to store the newly created elements")
        '
        'ButtonUnselectGenerate
        '
        Me.ButtonUnselectGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonUnselectGenerate.Location = New System.Drawing.Point(431, 524)
        Me.ButtonUnselectGenerate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonUnselectGenerate.Name = "ButtonUnselectGenerate"
        Me.ButtonUnselectGenerate.Size = New System.Drawing.Size(100, 28)
        Me.ButtonUnselectGenerate.TabIndex = 33
        Me.ButtonUnselectGenerate.Text = "Unselect All"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonUnselectGenerate, "Unselect all elements in the listbox")
        Me.ButtonUnselectGenerate.UseVisualStyleBackColor = True
        '
        'ButtonToggleGenerate
        '
        Me.ButtonToggleGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonToggleGenerate.Location = New System.Drawing.Point(223, 524)
        Me.ButtonToggleGenerate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonToggleGenerate.Name = "ButtonToggleGenerate"
        Me.ButtonToggleGenerate.Size = New System.Drawing.Size(100, 28)
        Me.ButtonToggleGenerate.TabIndex = 32
        Me.ButtonToggleGenerate.Text = "Toggle"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonToggleGenerate, "Switch from selected to unselected and vice versa")
        Me.ButtonToggleGenerate.UseVisualStyleBackColor = True
        '
        'ButtonSelectAllGenerate
        '
        Me.ButtonSelectAllGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSelectAllGenerate.Location = New System.Drawing.Point(23, 524)
        Me.ButtonSelectAllGenerate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSelectAllGenerate.Name = "ButtonSelectAllGenerate"
        Me.ButtonSelectAllGenerate.Size = New System.Drawing.Size(100, 28)
        Me.ButtonSelectAllGenerate.TabIndex = 31
        Me.ButtonSelectAllGenerate.Text = "Select All"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonSelectAllGenerate, "Select all elements in the listbox")
        Me.ButtonSelectAllGenerate.UseVisualStyleBackColor = True
        '
        'ButtonGenerateItems
        '
        Me.ButtonGenerateItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGenerateItems.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonGenerateItems.Location = New System.Drawing.Point(575, 409)
        Me.ButtonGenerateItems.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonGenerateItems.Name = "ButtonGenerateItems"
        Me.ButtonGenerateItems.Size = New System.Drawing.Size(363, 76)
        Me.ButtonGenerateItems.TabIndex = 30
        Me.ButtonGenerateItems.Text = "Generate elements"
        Me.ToolTipSwitch.SetToolTip(Me.ButtonGenerateItems, "Generate the elements based on the selection in the listbox")
        Me.ButtonGenerateItems.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(572, 101)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Target type"
        '
        'SaveSQLFileDialog
        '
        Me.SaveSQLFileDialog.FileName = "mapping.sql"
        Me.SaveSQLFileDialog.InitialDirectory = "c:\werkmap"
        '
        'ToolTipSwitch
        '
        Me.ToolTipSwitch.IsBalloon = True
        Me.ToolTipSwitch.ToolTipTitle = "Tooltip helper info"
        '
        'FrmIdeaDiagram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 599)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(85, 65)
        Me.Name = "FrmIdeaDiagram"
        Me.Text = "IDEA Diagram Helper"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridViewSQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewStatement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridViewMapping, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonUnselectAll As System.Windows.Forms.Button
    Friend WithEvents ButtonToggleAll As System.Windows.Forms.Button
    Friend WithEvents ButtonSelectAll As System.Windows.Forms.Button
    Friend WithEvents ListBoxElements As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelDiagramName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPrefix As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxType As System.Windows.Forms.ListBox
    Friend WithEvents ButtonGenerate As System.Windows.Forms.Button
    Friend WithEvents CheckBoxAttributeAssociation As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonGenerateMapping As System.Windows.Forms.Button
    Friend WithEvents ButtonMappingTarget As System.Windows.Forms.Button
    Friend WithEvents ButtonMappingSource As System.Windows.Forms.Button
    Friend WithEvents DataGridViewMapping As System.Windows.Forms.DataGridView
    Friend WithEvents ListBoxMappingElement As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelMappingDiagramName As System.Windows.Forms.Label
    Friend WithEvents ButtonLoadMappings As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxMapTarget As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoadData As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonSwitchMapping As System.Windows.Forms.Button
    Friend WithEvents CheckBoxIsHidden As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonMappingStyle As System.Windows.Forms.Button
    Friend WithEvents RadioButtonAutoroute As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDirect As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonGenerateItems As System.Windows.Forms.Button
    Friend WithEvents RadioButtonTreeVertical As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonLateralVertical As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonOrthogonalRounded As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonHideEmbedded As System.Windows.Forms.Button
    Friend WithEvents CheckBoxCloseWindowExtraReady As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonMatchNames As System.Windows.Forms.Button
    Friend WithEvents ButtonCollectElements As System.Windows.Forms.Button
    Friend WithEvents ButtonShowHidden As System.Windows.Forms.Button
    Friend WithEvents CheckBoxMakeHidden As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonLoad As System.Windows.Forms.Button
    Friend WithEvents ButtonMakeSQL As System.Windows.Forms.Button
    Friend WithEvents CheckBoxGenerateName As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBoxStereoType As System.Windows.Forms.TextBox
    Friend WithEvents SaveSQLFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ComboBoxSecGroup As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxUserLock As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonLockElements As System.Windows.Forms.Button
    Friend WithEvents CheckBoxOriginalPackage As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonElement2Original As System.Windows.Forms.Button
    Friend WithEvents ButtonUnselectGenerate As System.Windows.Forms.Button
    Friend WithEvents ButtonToggleGenerate As System.Windows.Forms.Button
    Friend WithEvents ButtonSelectAllGenerate As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTargetPackage As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonArchiMateColoring As System.Windows.Forms.Button
    Friend WithEvents CheckBoxRestoreColor As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewStatement As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxTemplate As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStatement As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewSQL As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxCreateAll As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFullModelCopy As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButtonOneOne As Windows.Forms.RadioButton
    Friend WithEvents RadioButtonOneMany As Windows.Forms.RadioButton
    Friend WithEvents RadioButtonManyToMany As Windows.Forms.RadioButton
    Friend WithEvents ButtonCardinality As Windows.Forms.Button
    Friend WithEvents ToolTipSwitch As Windows.Forms.ToolTip
End Class

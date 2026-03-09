''' <summary>
''' Deduplication of an package and all the elements in the package with a number
''' of subscreens in the tabpage to define the merging of the related elements and
''' their features
''' </summary>
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmPackageDeduplicator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPackageDeduplicator))
        Me.LabelPackage = New System.Windows.Forms.Label()
        Me.SaveFileDialogReport = New System.Windows.Forms.SaveFileDialog()
        Me.TabControlDeduplicator = New System.Windows.Forms.TabControl()
        Me.TabPageResult = New System.Windows.Forms.TabPage()
        Me.ResultSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.TextBoxDiagram = New System.Windows.Forms.TextBox()
        Me.DataGridViewElements = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridViewConnectors = New System.Windows.Forms.DataGridView()
        Me.TabPageDeduplicate = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxExtendedWarning = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSuppressValidationWarning = New System.Windows.Forms.CheckBox()
        Me.ButtonSaveValidation = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxDeduplicateConnector = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRename = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCreateTrace = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRecursion = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCloseWindow = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDuplicateFolder = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxMethod = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRequirements = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScenario = New System.Windows.Forms.CheckBox()
        Me.CheckBoxConnectors = New System.Windows.Forms.CheckBox()
        Me.CheckBoxNotes = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAttributes = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTaggedValues = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLinkedFiles = New System.Windows.Forms.CheckBox()
        Me.TabPageResultText = New System.Windows.Forms.TabPage()
        Me.ProgressBarDedupl = New System.Windows.Forms.ProgressBar()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonDeduplicate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonOriginal = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonDuplicate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonReload = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonDuplicateReport = New System.Windows.Forms.ToolStripButton()
        Me.CheckBoxBaseLine = New System.Windows.Forms.CheckBox()
        Me.TabControlDeduplicator.SuspendLayout()
        Me.TabPageResult.SuspendLayout()
        CType(Me.ResultSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResultSplitContainer.Panel1.SuspendLayout()
        Me.ResultSplitContainer.Panel2.SuspendLayout()
        Me.ResultSplitContainer.SuspendLayout()
        CType(Me.DataGridViewElements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewConnectors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageDeduplicate.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPageResultText.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelPackage
        '
        Me.LabelPackage.AutoSize = True
        Me.LabelPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPackage.Location = New System.Drawing.Point(9, 310)
        Me.LabelPackage.Name = "LabelPackage"
        Me.LabelPackage.Size = New System.Drawing.Size(31, 29)
        Me.LabelPackage.TabIndex = 11
        Me.LabelPackage.Text = "--"
        '
        'TabControlDeduplicator
        '
        Me.TabControlDeduplicator.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlDeduplicator.Controls.Add(Me.TabPageResult)
        Me.TabControlDeduplicator.Controls.Add(Me.TabPageDeduplicate)
        Me.TabControlDeduplicator.Controls.Add(Me.TabPageResultText)
        Me.TabControlDeduplicator.Location = New System.Drawing.Point(0, 41)
        Me.TabControlDeduplicator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlDeduplicator.Name = "TabControlDeduplicator"
        Me.TabControlDeduplicator.SelectedIndex = 0
        Me.TabControlDeduplicator.Size = New System.Drawing.Size(776, 474)
        Me.TabControlDeduplicator.TabIndex = 21
        '
        'TabPageResult
        '
        Me.TabPageResult.Controls.Add(Me.ResultSplitContainer)
        Me.TabPageResult.Location = New System.Drawing.Point(4, 25)
        Me.TabPageResult.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageResult.Name = "TabPageResult"
        Me.TabPageResult.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageResult.Size = New System.Drawing.Size(768, 445)
        Me.TabPageResult.TabIndex = 1
        Me.TabPageResult.Text = "Overview duplicates"
        Me.TabPageResult.UseVisualStyleBackColor = True
        '
        'ResultSplitContainer
        '
        Me.ResultSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultSplitContainer.Location = New System.Drawing.Point(3, 2)
        Me.ResultSplitContainer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResultSplitContainer.Name = "ResultSplitContainer"
        Me.ResultSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ResultSplitContainer.Panel1
        '
        Me.ResultSplitContainer.Panel1.Controls.Add(Me.TextBoxDiagram)
        Me.ResultSplitContainer.Panel1.Controls.Add(Me.DataGridViewElements)
        '
        'ResultSplitContainer.Panel2
        '
        Me.ResultSplitContainer.Panel2.Controls.Add(Me.TextBox1)
        Me.ResultSplitContainer.Panel2.Controls.Add(Me.DataGridViewConnectors)
        Me.ResultSplitContainer.Size = New System.Drawing.Size(762, 441)
        Me.ResultSplitContainer.SplitterDistance = 228
        Me.ResultSplitContainer.TabIndex = 0
        '
        'TextBoxDiagram
        '
        Me.TextBoxDiagram.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDiagram.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxDiagram.Location = New System.Drawing.Point(634, 201)
        Me.TextBoxDiagram.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxDiagram.Name = "TextBoxDiagram"
        Me.TextBoxDiagram.ReadOnly = True
        Me.TextBoxDiagram.Size = New System.Drawing.Size(127, 22)
        Me.TextBoxDiagram.TabIndex = 24
        Me.TextBoxDiagram.Text = "Element duplicates"
        Me.TextBoxDiagram.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridViewElements
        '
        Me.DataGridViewElements.AllowUserToAddRows = False
        Me.DataGridViewElements.AllowUserToOrderColumns = True
        Me.DataGridViewElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewElements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewElements.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewElements.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewElements.Name = "DataGridViewElements"
        Me.DataGridViewElements.ReadOnly = True
        Me.DataGridViewElements.RowHeadersWidth = 51
        Me.DataGridViewElements.RowTemplate.Height = 24
        Me.DataGridViewElements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewElements.Size = New System.Drawing.Size(762, 228)
        Me.DataGridViewElements.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(605, 185)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(156, 22)
        Me.TextBox1.TabIndex = 25
        Me.TextBox1.Text = "Connector Duplicates"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridViewConnectors
        '
        Me.DataGridViewConnectors.AllowUserToAddRows = False
        Me.DataGridViewConnectors.AllowUserToOrderColumns = True
        Me.DataGridViewConnectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewConnectors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewConnectors.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewConnectors.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewConnectors.Name = "DataGridViewConnectors"
        Me.DataGridViewConnectors.ReadOnly = True
        Me.DataGridViewConnectors.RowHeadersWidth = 51
        Me.DataGridViewConnectors.RowTemplate.Height = 24
        Me.DataGridViewConnectors.Size = New System.Drawing.Size(762, 209)
        Me.DataGridViewConnectors.TabIndex = 0
        '
        'TabPageDeduplicate
        '
        Me.TabPageDeduplicate.BackColor = System.Drawing.Color.LightGray
        Me.TabPageDeduplicate.Controls.Add(Me.GroupBox3)
        Me.TabPageDeduplicate.Controls.Add(Me.GroupBox2)
        Me.TabPageDeduplicate.Controls.Add(Me.LabelPackage)
        Me.TabPageDeduplicate.Controls.Add(Me.GroupBox1)
        Me.TabPageDeduplicate.Location = New System.Drawing.Point(4, 25)
        Me.TabPageDeduplicate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageDeduplicate.Name = "TabPageDeduplicate"
        Me.TabPageDeduplicate.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageDeduplicate.Size = New System.Drawing.Size(768, 445)
        Me.TabPageDeduplicate.TabIndex = 0
        Me.TabPageDeduplicate.Text = "Deduplicate settings"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.CheckBoxBaseLine)
        Me.GroupBox3.Controls.Add(Me.CheckBoxExtendedWarning)
        Me.GroupBox3.Controls.Add(Me.CheckBoxSuppressValidationWarning)
        Me.GroupBox3.Controls.Add(Me.ButtonSaveValidation)
        Me.GroupBox3.Location = New System.Drawing.Point(472, 14)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(248, 277)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Settings"
        '
        'CheckBoxExtendedWarning
        '
        Me.CheckBoxExtendedWarning.AutoSize = True
        Me.CheckBoxExtendedWarning.Location = New System.Drawing.Point(16, 26)
        Me.CheckBoxExtendedWarning.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxExtendedWarning.Name = "CheckBoxExtendedWarning"
        Me.CheckBoxExtendedWarning.Size = New System.Drawing.Size(182, 20)
        Me.CheckBoxExtendedWarning.TabIndex = 17
        Me.CheckBoxExtendedWarning.Text = "Extended Warning Dialog"
        Me.CheckBoxExtendedWarning.UseVisualStyleBackColor = True
        '
        'CheckBoxSuppressValidationWarning
        '
        Me.CheckBoxSuppressValidationWarning.AutoSize = True
        Me.CheckBoxSuppressValidationWarning.Location = New System.Drawing.Point(16, 50)
        Me.CheckBoxSuppressValidationWarning.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxSuppressValidationWarning.Name = "CheckBoxSuppressValidationWarning"
        Me.CheckBoxSuppressValidationWarning.Size = New System.Drawing.Size(197, 20)
        Me.CheckBoxSuppressValidationWarning.TabIndex = 14
        Me.CheckBoxSuppressValidationWarning.Text = "Suppress validation warning"
        Me.CheckBoxSuppressValidationWarning.UseVisualStyleBackColor = True
        '
        'ButtonSaveValidation
        '
        Me.ButtonSaveValidation.Location = New System.Drawing.Point(108, 231)
        Me.ButtonSaveValidation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSaveValidation.Name = "ButtonSaveValidation"
        Me.ButtonSaveValidation.Size = New System.Drawing.Size(119, 30)
        Me.ButtonSaveValidation.TabIndex = 15
        Me.ButtonSaveValidation.Text = "Save settings"
        Me.ButtonSaveValidation.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Controls.Add(Me.CheckBoxDeduplicateConnector)
        Me.GroupBox2.Controls.Add(Me.CheckBoxRename)
        Me.GroupBox2.Controls.Add(Me.CheckBoxCreateTrace)
        Me.GroupBox2.Controls.Add(Me.CheckBoxRecursion)
        Me.GroupBox2.Controls.Add(Me.CheckBoxCloseWindow)
        Me.GroupBox2.Controls.Add(Me.CheckBoxDuplicateFolder)
        Me.GroupBox2.Location = New System.Drawing.Point(231, 14)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(235, 277)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'CheckBoxDeduplicateConnector
        '
        Me.CheckBoxDeduplicateConnector.AutoSize = True
        Me.CheckBoxDeduplicateConnector.BackColor = System.Drawing.Color.DarkGray
        Me.CheckBoxDeduplicateConnector.Checked = True
        Me.CheckBoxDeduplicateConnector.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDeduplicateConnector.Location = New System.Drawing.Point(11, 197)
        Me.CheckBoxDeduplicateConnector.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxDeduplicateConnector.Name = "CheckBoxDeduplicateConnector"
        Me.CheckBoxDeduplicateConnector.Size = New System.Drawing.Size(171, 20)
        Me.CheckBoxDeduplicateConnector.TabIndex = 5
        Me.CheckBoxDeduplicateConnector.Text = "Deduplicate connectors"
        Me.CheckBoxDeduplicateConnector.UseVisualStyleBackColor = False
        '
        'CheckBoxRename
        '
        Me.CheckBoxRename.AutoSize = True
        Me.CheckBoxRename.BackColor = System.Drawing.Color.DarkGray
        Me.CheckBoxRename.Checked = True
        Me.CheckBoxRename.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxRename.Location = New System.Drawing.Point(11, 154)
        Me.CheckBoxRename.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxRename.Name = "CheckBoxRename"
        Me.CheckBoxRename.Size = New System.Drawing.Size(173, 20)
        Me.CheckBoxRename.TabIndex = 4
        Me.CheckBoxRename.Text = "Rename duplicate entity"
        Me.CheckBoxRename.UseVisualStyleBackColor = False
        '
        'CheckBoxCreateTrace
        '
        Me.CheckBoxCreateTrace.AutoSize = True
        Me.CheckBoxCreateTrace.BackColor = System.Drawing.Color.DarkGray
        Me.CheckBoxCreateTrace.Checked = True
        Me.CheckBoxCreateTrace.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCreateTrace.Location = New System.Drawing.Point(11, 68)
        Me.CheckBoxCreateTrace.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxCreateTrace.Name = "CheckBoxCreateTrace"
        Me.CheckBoxCreateTrace.Size = New System.Drawing.Size(102, 20)
        Me.CheckBoxCreateTrace.TabIndex = 3
        Me.CheckBoxCreateTrace.Text = "Create trace"
        Me.CheckBoxCreateTrace.UseVisualStyleBackColor = False
        '
        'CheckBoxRecursion
        '
        Me.CheckBoxRecursion.AutoSize = True
        Me.CheckBoxRecursion.BackColor = System.Drawing.Color.DarkGray
        Me.CheckBoxRecursion.Checked = True
        Me.CheckBoxRecursion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxRecursion.Location = New System.Drawing.Point(11, 111)
        Me.CheckBoxRecursion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxRecursion.Name = "CheckBoxRecursion"
        Me.CheckBoxRecursion.Size = New System.Drawing.Size(158, 20)
        Me.CheckBoxRecursion.TabIndex = 2
        Me.CheckBoxRecursion.Text = "Include subpackages"
        Me.CheckBoxRecursion.UseVisualStyleBackColor = False
        '
        'CheckBoxCloseWindow
        '
        Me.CheckBoxCloseWindow.AutoSize = True
        Me.CheckBoxCloseWindow.BackColor = System.Drawing.Color.DarkGray
        Me.CheckBoxCloseWindow.Checked = True
        Me.CheckBoxCloseWindow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCloseWindow.Location = New System.Drawing.Point(11, 240)
        Me.CheckBoxCloseWindow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxCloseWindow.Name = "CheckBoxCloseWindow"
        Me.CheckBoxCloseWindow.Size = New System.Drawing.Size(183, 20)
        Me.CheckBoxCloseWindow.TabIndex = 1
        Me.CheckBoxCloseWindow.Text = "Close window when ready"
        Me.CheckBoxCloseWindow.UseVisualStyleBackColor = False
        '
        'CheckBoxDuplicateFolder
        '
        Me.CheckBoxDuplicateFolder.AutoSize = True
        Me.CheckBoxDuplicateFolder.BackColor = System.Drawing.Color.DarkGray
        Me.CheckBoxDuplicateFolder.Checked = True
        Me.CheckBoxDuplicateFolder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDuplicateFolder.Location = New System.Drawing.Point(11, 25)
        Me.CheckBoxDuplicateFolder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxDuplicateFolder.Name = "CheckBoxDuplicateFolder"
        Me.CheckBoxDuplicateFolder.Size = New System.Drawing.Size(164, 20)
        Me.CheckBoxDuplicateFolder.TabIndex = 0
        Me.CheckBoxDuplicateFolder.Text = "Create duplicate folder"
        Me.CheckBoxDuplicateFolder.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.CheckBoxMethod)
        Me.GroupBox1.Controls.Add(Me.CheckBoxRequirements)
        Me.GroupBox1.Controls.Add(Me.CheckBoxScenario)
        Me.GroupBox1.Controls.Add(Me.CheckBoxConnectors)
        Me.GroupBox1.Controls.Add(Me.CheckBoxNotes)
        Me.GroupBox1.Controls.Add(Me.CheckBoxAttributes)
        Me.GroupBox1.Controls.Add(Me.CheckBoxTaggedValues)
        Me.GroupBox1.Controls.Add(Me.CheckBoxLinkedFiles)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(216, 277)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select features"
        '
        'CheckBoxMethod
        '
        Me.CheckBoxMethod.AutoSize = True
        Me.CheckBoxMethod.Checked = True
        Me.CheckBoxMethod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxMethod.Location = New System.Drawing.Point(15, 212)
        Me.CheckBoxMethod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxMethod.Name = "CheckBoxMethod"
        Me.CheckBoxMethod.Size = New System.Drawing.Size(81, 20)
        Me.CheckBoxMethod.TabIndex = 8
        Me.CheckBoxMethod.Text = "Methods"
        Me.CheckBoxMethod.UseVisualStyleBackColor = True
        '
        'CheckBoxRequirements
        '
        Me.CheckBoxRequirements.AutoSize = True
        Me.CheckBoxRequirements.Checked = True
        Me.CheckBoxRequirements.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxRequirements.Location = New System.Drawing.Point(15, 181)
        Me.CheckBoxRequirements.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxRequirements.Name = "CheckBoxRequirements"
        Me.CheckBoxRequirements.Size = New System.Drawing.Size(113, 20)
        Me.CheckBoxRequirements.TabIndex = 7
        Me.CheckBoxRequirements.Text = "Requirements"
        Me.CheckBoxRequirements.UseVisualStyleBackColor = True
        '
        'CheckBoxScenario
        '
        Me.CheckBoxScenario.AutoSize = True
        Me.CheckBoxScenario.Checked = True
        Me.CheckBoxScenario.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxScenario.Location = New System.Drawing.Point(15, 150)
        Me.CheckBoxScenario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxScenario.Name = "CheckBoxScenario"
        Me.CheckBoxScenario.Size = New System.Drawing.Size(90, 20)
        Me.CheckBoxScenario.TabIndex = 6
        Me.CheckBoxScenario.Text = "Scenarios"
        Me.CheckBoxScenario.UseVisualStyleBackColor = True
        '
        'CheckBoxConnectors
        '
        Me.CheckBoxConnectors.AutoSize = True
        Me.CheckBoxConnectors.BackColor = System.Drawing.Color.Silver
        Me.CheckBoxConnectors.Checked = True
        Me.CheckBoxConnectors.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxConnectors.Location = New System.Drawing.Point(15, 119)
        Me.CheckBoxConnectors.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxConnectors.Name = "CheckBoxConnectors"
        Me.CheckBoxConnectors.Size = New System.Drawing.Size(97, 20)
        Me.CheckBoxConnectors.TabIndex = 5
        Me.CheckBoxConnectors.Text = "Connectors"
        Me.CheckBoxConnectors.UseVisualStyleBackColor = False
        '
        'CheckBoxNotes
        '
        Me.CheckBoxNotes.AutoSize = True
        Me.CheckBoxNotes.BackColor = System.Drawing.Color.Silver
        Me.CheckBoxNotes.Checked = True
        Me.CheckBoxNotes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxNotes.Location = New System.Drawing.Point(15, 242)
        Me.CheckBoxNotes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxNotes.Name = "CheckBoxNotes"
        Me.CheckBoxNotes.Size = New System.Drawing.Size(65, 20)
        Me.CheckBoxNotes.TabIndex = 8
        Me.CheckBoxNotes.Text = "Notes"
        Me.CheckBoxNotes.UseVisualStyleBackColor = False
        '
        'CheckBoxAttributes
        '
        Me.CheckBoxAttributes.AutoSize = True
        Me.CheckBoxAttributes.BackColor = System.Drawing.Color.Silver
        Me.CheckBoxAttributes.Checked = True
        Me.CheckBoxAttributes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxAttributes.Location = New System.Drawing.Point(15, 89)
        Me.CheckBoxAttributes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxAttributes.Name = "CheckBoxAttributes"
        Me.CheckBoxAttributes.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxAttributes.TabIndex = 4
        Me.CheckBoxAttributes.Text = "Attributes"
        Me.CheckBoxAttributes.UseVisualStyleBackColor = False
        '
        'CheckBoxTaggedValues
        '
        Me.CheckBoxTaggedValues.AutoSize = True
        Me.CheckBoxTaggedValues.BackColor = System.Drawing.Color.Silver
        Me.CheckBoxTaggedValues.Checked = True
        Me.CheckBoxTaggedValues.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxTaggedValues.Location = New System.Drawing.Point(15, 26)
        Me.CheckBoxTaggedValues.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxTaggedValues.Name = "CheckBoxTaggedValues"
        Me.CheckBoxTaggedValues.Size = New System.Drawing.Size(123, 20)
        Me.CheckBoxTaggedValues.TabIndex = 1
        Me.CheckBoxTaggedValues.Text = "Tagged Values"
        Me.CheckBoxTaggedValues.UseVisualStyleBackColor = False
        '
        'CheckBoxLinkedFiles
        '
        Me.CheckBoxLinkedFiles.AutoSize = True
        Me.CheckBoxLinkedFiles.BackColor = System.Drawing.Color.Silver
        Me.CheckBoxLinkedFiles.Checked = True
        Me.CheckBoxLinkedFiles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxLinkedFiles.Location = New System.Drawing.Point(15, 57)
        Me.CheckBoxLinkedFiles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxLinkedFiles.Name = "CheckBoxLinkedFiles"
        Me.CheckBoxLinkedFiles.Size = New System.Drawing.Size(96, 20)
        Me.CheckBoxLinkedFiles.TabIndex = 3
        Me.CheckBoxLinkedFiles.Text = "Linked files"
        Me.CheckBoxLinkedFiles.UseVisualStyleBackColor = False
        '
        'TabPageResultText
        '
        Me.TabPageResultText.Controls.Add(Me.ProgressBarDedupl)
        Me.TabPageResultText.Controls.Add(Me.TextBoxResult)
        Me.TabPageResultText.Location = New System.Drawing.Point(4, 25)
        Me.TabPageResultText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPageResultText.Name = "TabPageResultText"
        Me.TabPageResultText.Size = New System.Drawing.Size(768, 445)
        Me.TabPageResultText.TabIndex = 2
        Me.TabPageResultText.Text = "Processing result"
        Me.TabPageResultText.UseVisualStyleBackColor = True
        '
        'ProgressBarDedupl
        '
        Me.ProgressBarDedupl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarDedupl.Location = New System.Drawing.Point(-3, 395)
        Me.ProgressBarDedupl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBarDedupl.Name = "ProgressBarDedupl"
        Me.ProgressBarDedupl.Size = New System.Drawing.Size(768, 44)
        Me.ProgressBarDedupl.TabIndex = 25
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxResult.Location = New System.Drawing.Point(0, 5)
        Me.TextBoxResult.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxResult.Multiline = True
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxResult.Size = New System.Drawing.Size(764, 393)
        Me.TextBoxResult.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonDeduplicate, Me.ToolStripSeparator1, Me.ToolStripButtonOriginal, Me.ToolStripButtonDuplicate, Me.ToolStripSeparator2, Me.ToolStripButtonReload, Me.ToolStripButtonDuplicateReport})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(776, 27)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonDeduplicate
        '
        Me.ToolStripButtonDeduplicate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonDeduplicate.Image = CType(resources.GetObject("ToolStripButtonDeduplicate.Image"), System.Drawing.Image)
        Me.ToolStripButtonDeduplicate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDeduplicate.Name = "ToolStripButtonDeduplicate"
        Me.ToolStripButtonDeduplicate.Size = New System.Drawing.Size(127, 24)
        Me.ToolStripButtonDeduplicate.Text = "Start deduplicate"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButtonOriginal
        '
        Me.ToolStripButtonOriginal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonOriginal.Image = CType(resources.GetObject("ToolStripButtonOriginal.Image"), System.Drawing.Image)
        Me.ToolStripButtonOriginal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonOriginal.Name = "ToolStripButtonOriginal"
        Me.ToolStripButtonOriginal.Size = New System.Drawing.Size(66, 24)
        Me.ToolStripButtonOriginal.Text = "Original"
        Me.ToolStripButtonOriginal.ToolTipText = "Original in browser"
        '
        'ToolStripButtonDuplicate
        '
        Me.ToolStripButtonDuplicate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonDuplicate.Image = CType(resources.GetObject("ToolStripButtonDuplicate.Image"), System.Drawing.Image)
        Me.ToolStripButtonDuplicate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDuplicate.Name = "ToolStripButtonDuplicate"
        Me.ToolStripButtonDuplicate.Size = New System.Drawing.Size(77, 24)
        Me.ToolStripButtonDuplicate.Text = "Duplicate"
        Me.ToolStripButtonDuplicate.ToolTipText = "Duplicate in browser"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButtonReload
        '
        Me.ToolStripButtonReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonReload.Image = CType(resources.GetObject("ToolStripButtonReload.Image"), System.Drawing.Image)
        Me.ToolStripButtonReload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonReload.Name = "ToolStripButtonReload"
        Me.ToolStripButtonReload.Size = New System.Drawing.Size(91, 24)
        Me.ToolStripButtonReload.Text = "Reload grid"
        '
        'ToolStripButtonDuplicateReport
        '
        Me.ToolStripButtonDuplicateReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonDuplicateReport.Image = CType(resources.GetObject("ToolStripButtonDuplicateReport.Image"), System.Drawing.Image)
        Me.ToolStripButtonDuplicateReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDuplicateReport.Name = "ToolStripButtonDuplicateReport"
        Me.ToolStripButtonDuplicateReport.Size = New System.Drawing.Size(58, 24)
        Me.ToolStripButtonDuplicateReport.Text = "Report"
        Me.ToolStripButtonDuplicateReport.ToolTipText = "Create Duplicate Report"
        '
        'CheckBoxBaseLine
        '
        Me.CheckBoxBaseLine.AutoSize = True
        Me.CheckBoxBaseLine.Checked = True
        Me.CheckBoxBaseLine.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxBaseLine.Location = New System.Drawing.Point(16, 89)
        Me.CheckBoxBaseLine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxBaseLine.Name = "CheckBoxBaseLine"
        Me.CheckBoxBaseLine.Size = New System.Drawing.Size(192, 20)
        Me.CheckBoxBaseLine.TabIndex = 18
        Me.CheckBoxBaseLine.Text = "Baseline before duplication"
        Me.CheckBoxBaseLine.UseVisualStyleBackColor = True
        '
        'FrmPackageDeduplicator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 514)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControlDeduplicator)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmPackageDeduplicator"
        Me.Text = "Package Deduplicator"
        Me.TabControlDeduplicator.ResumeLayout(False)
        Me.TabPageResult.ResumeLayout(False)
        Me.ResultSplitContainer.Panel1.ResumeLayout(False)
        Me.ResultSplitContainer.Panel1.PerformLayout()
        Me.ResultSplitContainer.Panel2.ResumeLayout(False)
        Me.ResultSplitContainer.Panel2.PerformLayout()
        CType(Me.ResultSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResultSplitContainer.ResumeLayout(False)
        CType(Me.DataGridViewElements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewConnectors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageDeduplicate.ResumeLayout(False)
        Me.TabPageDeduplicate.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPageResultText.ResumeLayout(False)
        Me.TabPageResultText.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelPackage As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialogReport As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabControlDeduplicator As System.Windows.Forms.TabControl
    Friend WithEvents TabPageDeduplicate As System.Windows.Forms.TabPage
    Friend WithEvents TabPageResult As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxExtendedWarning As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSuppressValidationWarning As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonSaveValidation As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxDeduplicateConnector As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRename As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCreateTrace As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRecursion As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCloseWindow As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDuplicateFolder As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxMethod As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRequirements As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScenario As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxConnectors As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxNotes As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAttributes As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTaggedValues As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLinkedFiles As System.Windows.Forms.CheckBox
    Friend WithEvents ResultSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridViewElements As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewConnectors As System.Windows.Forms.DataGridView
    Friend WithEvents TabPageResultText As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxResult As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBarDedupl As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBoxDiagram As Windows.Forms.TextBox
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonDeduplicate As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonOriginal As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonDuplicate As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonReload As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonDuplicateReport As Windows.Forms.ToolStripButton
    Friend WithEvents CheckBoxBaseLine As Windows.Forms.CheckBox
End Class

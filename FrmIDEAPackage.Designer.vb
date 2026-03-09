<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIDEAPackage
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
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBoxUpdateStatus = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMoveArchiMate = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRemoveNesting = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCollectDiagramElements = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxTVValue = New System.Windows.Forms.TextBox()
        Me.TextBoxTVName = New System.Windows.Forms.TextBox()
        Me.CheckBoxTaggedValue = New System.Windows.Forms.CheckBox()
        Me.CheckBoxKeywords = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOrphans = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCloseWindow = New System.Windows.Forms.CheckBox()
        Me.ButtonProcess = New System.Windows.Forms.Button()
        Me.CheckBoxSearchReplace = New System.Windows.Forms.CheckBox()
        Me.LabelPackage = New System.Windows.Forms.Label()
        Me.CheckBoxReplaceNotes = New System.Windows.Forms.CheckBox()
        Me.CheckBoxReplaceAlias = New System.Windows.Forms.CheckBox()
        Me.CheckBoxReplaceName = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRecursive = New System.Windows.Forms.CheckBox()
        Me.DataGridViewSearchReplace = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBoxSortPackage = New System.Windows.Forms.CheckBox()
        Me.RadioButtonStereotype = New System.Windows.Forms.RadioButton()
        Me.RadioButtonName = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAlias = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDataVault = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolTipPackage = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBoxSelectedPackage = New System.Windows.Forms.CheckBox()
        Me.ComboBoxSelectedPackage = New System.Windows.Forms.ComboBox()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewSearchReplace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(-2, 416)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(561, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(559, 427)
        Me.TabControl.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.ComboBoxSelectedPackage)
        Me.TabPage1.Controls.Add(Me.CheckBoxSelectedPackage)
        Me.TabPage1.Controls.Add(Me.CheckBoxUpdateStatus)
        Me.TabPage1.Controls.Add(Me.CheckBoxMoveArchiMate)
        Me.TabPage1.Controls.Add(Me.CheckBoxRemoveNesting)
        Me.TabPage1.Controls.Add(Me.CheckBoxCollectDiagramElements)
        Me.TabPage1.Controls.Add(Me.CheckBoxOrphans)
        Me.TabPage1.Controls.Add(Me.CheckBoxCloseWindow)
        Me.TabPage1.Controls.Add(Me.ButtonProcess)
        Me.TabPage1.Controls.Add(Me.CheckBoxSearchReplace)
        Me.TabPage1.Controls.Add(Me.LabelPackage)
        Me.TabPage1.Controls.Add(Me.CheckBoxRecursive)
        Me.TabPage1.Controls.Add(Me.DataGridViewSearchReplace)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(551, 401)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Actions"
        '
        'CheckBoxUpdateStatus
        '
        Me.CheckBoxUpdateStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxUpdateStatus.AutoSize = True
        Me.CheckBoxUpdateStatus.Location = New System.Drawing.Point(22, 281)
        Me.CheckBoxUpdateStatus.Name = "CheckBoxUpdateStatus"
        Me.CheckBoxUpdateStatus.Size = New System.Drawing.Size(94, 17)
        Me.CheckBoxUpdateStatus.TabIndex = 41
        Me.CheckBoxUpdateStatus.Text = "Update Status"
        Me.ToolTipPackage.SetToolTip(Me.CheckBoxUpdateStatus, "Update the status of the package content and set it to the status of the package")
        Me.CheckBoxUpdateStatus.UseVisualStyleBackColor = True
        '
        'CheckBoxMoveArchiMate
        '
        Me.CheckBoxMoveArchiMate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxMoveArchiMate.AutoSize = True
        Me.CheckBoxMoveArchiMate.Location = New System.Drawing.Point(22, 214)
        Me.CheckBoxMoveArchiMate.Name = "CheckBoxMoveArchiMate"
        Me.CheckBoxMoveArchiMate.Size = New System.Drawing.Size(147, 17)
        Me.CheckBoxMoveArchiMate.TabIndex = 45
        Me.CheckBoxMoveArchiMate.Text = "Move to register package"
        Me.ToolTipPackage.SetToolTip(Me.CheckBoxMoveArchiMate, "Move the elements in the package to the Enterprise level collections defined in t" &
        "he settings")
        Me.CheckBoxMoveArchiMate.UseVisualStyleBackColor = True
        '
        'CheckBoxRemoveNesting
        '
        Me.CheckBoxRemoveNesting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxRemoveNesting.AutoSize = True
        Me.CheckBoxRemoveNesting.Checked = True
        Me.CheckBoxRemoveNesting.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxRemoveNesting.Location = New System.Drawing.Point(22, 191)
        Me.CheckBoxRemoveNesting.Name = "CheckBoxRemoveNesting"
        Me.CheckBoxRemoveNesting.Size = New System.Drawing.Size(105, 17)
        Me.CheckBoxRemoveNesting.TabIndex = 39
        Me.CheckBoxRemoveNesting.Text = "Remove Nesting"
        Me.ToolTipPackage.SetToolTip(Me.CheckBoxRemoveNesting, "Toggle the remove nesting action for the package content")
        Me.CheckBoxRemoveNesting.UseVisualStyleBackColor = True
        '
        'CheckBoxCollectDiagramElements
        '
        Me.CheckBoxCollectDiagramElements.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxCollectDiagramElements.AutoSize = True
        Me.CheckBoxCollectDiagramElements.Location = New System.Drawing.Point(22, 324)
        Me.CheckBoxCollectDiagramElements.Name = "CheckBoxCollectDiagramElements"
        Me.CheckBoxCollectDiagramElements.Size = New System.Drawing.Size(158, 17)
        Me.CheckBoxCollectDiagramElements.TabIndex = 53
        Me.CheckBoxCollectDiagramElements.Text = "Collect elements for diagram"
        Me.ToolTipPackage.SetToolTip(Me.CheckBoxCollectDiagramElements, "Collect diagram elements for diagram")
        Me.CheckBoxCollectDiagramElements.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "TV value"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "TV name"
        '
        'TextBoxTVValue
        '
        Me.TextBoxTVValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTVValue.Location = New System.Drawing.Point(68, 59)
        Me.TextBoxTVValue.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTVValue.Name = "TextBoxTVValue"
        Me.TextBoxTVValue.Size = New System.Drawing.Size(226, 20)
        Me.TextBoxTVValue.TabIndex = 50
        Me.ToolTipPackage.SetToolTip(Me.TextBoxTVValue, "Set the new tagged value value")
        '
        'TextBoxTVName
        '
        Me.TextBoxTVName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTVName.Location = New System.Drawing.Point(69, 35)
        Me.TextBoxTVName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTVName.Name = "TextBoxTVName"
        Me.TextBoxTVName.Size = New System.Drawing.Size(227, 20)
        Me.TextBoxTVName.TabIndex = 49
        Me.ToolTipPackage.SetToolTip(Me.TextBoxTVName, "Set tagged value name")
        '
        'CheckBoxTaggedValue
        '
        Me.CheckBoxTaggedValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxTaggedValue.AutoSize = True
        Me.CheckBoxTaggedValue.Location = New System.Drawing.Point(9, 13)
        Me.CheckBoxTaggedValue.Name = "CheckBoxTaggedValue"
        Me.CheckBoxTaggedValue.Size = New System.Drawing.Size(165, 17)
        Me.CheckBoxTaggedValue.TabIndex = 48
        Me.CheckBoxTaggedValue.Text = "Add or Update Tagged Value"
        Me.ToolTipPackage.SetToolTip(Me.CheckBoxTaggedValue, "Add or update tagged value content of the package content")
        Me.CheckBoxTaggedValue.UseVisualStyleBackColor = True
        '
        'CheckBoxKeywords
        '
        Me.CheckBoxKeywords.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxKeywords.AutoSize = True
        Me.CheckBoxKeywords.Checked = True
        Me.CheckBoxKeywords.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxKeywords.Location = New System.Drawing.Point(200, 142)
        Me.CheckBoxKeywords.Name = "CheckBoxKeywords"
        Me.CheckBoxKeywords.Size = New System.Drawing.Size(72, 17)
        Me.CheckBoxKeywords.TabIndex = 47
        Me.CheckBoxKeywords.Text = "Keywords"
        Me.CheckBoxKeywords.UseVisualStyleBackColor = True
        '
        'CheckBoxOrphans
        '
        Me.CheckBoxOrphans.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxOrphans.AutoSize = True
        Me.CheckBoxOrphans.Location = New System.Drawing.Point(22, 303)
        Me.CheckBoxOrphans.Name = "CheckBoxOrphans"
        Me.CheckBoxOrphans.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxOrphans.TabIndex = 46
        Me.CheckBoxOrphans.Text = "Orphans"
        Me.ToolTipPackage.SetToolTip(Me.CheckBoxOrphans, "Define orphans of the package content and store them in a new Orphans package")
        Me.CheckBoxOrphans.UseVisualStyleBackColor = True
        '
        'CheckBoxCloseWindow
        '
        Me.CheckBoxCloseWindow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxCloseWindow.AutoSize = True
        Me.CheckBoxCloseWindow.Checked = True
        Me.CheckBoxCloseWindow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCloseWindow.Location = New System.Drawing.Point(22, 372)
        Me.CheckBoxCloseWindow.Name = "CheckBoxCloseWindow"
        Me.CheckBoxCloseWindow.Size = New System.Drawing.Size(91, 17)
        Me.CheckBoxCloseWindow.TabIndex = 44
        Me.CheckBoxCloseWindow.Text = "Close window"
        Me.ToolTipPackage.SetToolTip(Me.CheckBoxCloseWindow, "Close window after batch operation")
        Me.CheckBoxCloseWindow.UseVisualStyleBackColor = True
        '
        'ButtonProcess
        '
        Me.ButtonProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonProcess.Location = New System.Drawing.Point(248, 338)
        Me.ButtonProcess.Name = "ButtonProcess"
        Me.ButtonProcess.Size = New System.Drawing.Size(297, 50)
        Me.ButtonProcess.TabIndex = 42
        Me.ButtonProcess.Text = "Process actions"
        Me.ToolTipPackage.SetToolTip(Me.ButtonProcess, "Execute all the selected activities defined in the list of checkboxes")
        Me.ButtonProcess.UseVisualStyleBackColor = True
        '
        'CheckBoxSearchReplace
        '
        Me.CheckBoxSearchReplace.AutoSize = True
        Me.CheckBoxSearchReplace.Location = New System.Drawing.Point(259, 33)
        Me.CheckBoxSearchReplace.Name = "CheckBoxSearchReplace"
        Me.CheckBoxSearchReplace.Size = New System.Drawing.Size(119, 17)
        Me.CheckBoxSearchReplace.TabIndex = 40
        Me.CheckBoxSearchReplace.Text = "Search and replace"
        Me.ToolTipPackage.SetToolTip(Me.CheckBoxSearchReplace, "Search and replace the contents of the properties with values in the grid")
        Me.CheckBoxSearchReplace.UseVisualStyleBackColor = True
        '
        'LabelPackage
        '
        Me.LabelPackage.AutoSize = True
        Me.LabelPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPackage.Location = New System.Drawing.Point(30, 8)
        Me.LabelPackage.Name = "LabelPackage"
        Me.LabelPackage.Size = New System.Drawing.Size(17, 16)
        Me.LabelPackage.TabIndex = 37
        Me.LabelPackage.Text = "--"
        '
        'CheckBoxReplaceNotes
        '
        Me.CheckBoxReplaceNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxReplaceNotes.AutoSize = True
        Me.CheckBoxReplaceNotes.Checked = True
        Me.CheckBoxReplaceNotes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxReplaceNotes.Location = New System.Drawing.Point(131, 142)
        Me.CheckBoxReplaceNotes.Name = "CheckBoxReplaceNotes"
        Me.CheckBoxReplaceNotes.Size = New System.Drawing.Size(54, 17)
        Me.CheckBoxReplaceNotes.TabIndex = 36
        Me.CheckBoxReplaceNotes.Text = "Notes"
        Me.CheckBoxReplaceNotes.UseVisualStyleBackColor = True
        '
        'CheckBoxReplaceAlias
        '
        Me.CheckBoxReplaceAlias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxReplaceAlias.AutoSize = True
        Me.CheckBoxReplaceAlias.Checked = True
        Me.CheckBoxReplaceAlias.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxReplaceAlias.Location = New System.Drawing.Point(69, 142)
        Me.CheckBoxReplaceAlias.Name = "CheckBoxReplaceAlias"
        Me.CheckBoxReplaceAlias.Size = New System.Drawing.Size(48, 17)
        Me.CheckBoxReplaceAlias.TabIndex = 35
        Me.CheckBoxReplaceAlias.Text = "Alias"
        Me.CheckBoxReplaceAlias.UseVisualStyleBackColor = True
        '
        'CheckBoxReplaceName
        '
        Me.CheckBoxReplaceName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxReplaceName.AutoSize = True
        Me.CheckBoxReplaceName.Checked = True
        Me.CheckBoxReplaceName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxReplaceName.Location = New System.Drawing.Point(9, 142)
        Me.CheckBoxReplaceName.Name = "CheckBoxReplaceName"
        Me.CheckBoxReplaceName.Size = New System.Drawing.Size(54, 17)
        Me.CheckBoxReplaceName.TabIndex = 34
        Me.CheckBoxReplaceName.Text = "Name"
        Me.CheckBoxReplaceName.UseVisualStyleBackColor = True
        '
        'CheckBoxRecursive
        '
        Me.CheckBoxRecursive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxRecursive.AutoSize = True
        Me.CheckBoxRecursive.Checked = True
        Me.CheckBoxRecursive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxRecursive.Location = New System.Drawing.Point(22, 346)
        Me.CheckBoxRecursive.Name = "CheckBoxRecursive"
        Me.CheckBoxRecursive.Size = New System.Drawing.Size(74, 17)
        Me.CheckBoxRecursive.TabIndex = 30
        Me.CheckBoxRecursive.Text = "Recursive"
        Me.ToolTipPackage.SetToolTip(Me.CheckBoxRecursive, "Process the child packages")
        Me.CheckBoxRecursive.UseVisualStyleBackColor = True
        '
        'DataGridViewSearchReplace
        '
        Me.DataGridViewSearchReplace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewSearchReplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSearchReplace.Location = New System.Drawing.Point(259, 56)
        Me.DataGridViewSearchReplace.Name = "DataGridViewSearchReplace"
        Me.DataGridViewSearchReplace.RowHeadersWidth = 51
        Me.DataGridViewSearchReplace.Size = New System.Drawing.Size(284, 109)
        Me.DataGridViewSearchReplace.TabIndex = 29
        Me.ToolTipPackage.SetToolTip(Me.DataGridViewSearchReplace, "Add search and replace values, please note this is case sensitive")
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.CheckBoxSortPackage)
        Me.Panel1.Controls.Add(Me.RadioButtonStereotype)
        Me.Panel1.Controls.Add(Me.RadioButtonName)
        Me.Panel1.Controls.Add(Me.RadioButtonAlias)
        Me.Panel1.Controls.Add(Me.RadioButtonDataVault)
        Me.Panel1.Location = New System.Drawing.Point(22, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 152)
        Me.Panel1.TabIndex = 54
        '
        'CheckBoxSortPackage
        '
        Me.CheckBoxSortPackage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxSortPackage.AutoSize = True
        Me.CheckBoxSortPackage.Checked = True
        Me.CheckBoxSortPackage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxSortPackage.Location = New System.Drawing.Point(14, 13)
        Me.CheckBoxSortPackage.Name = "CheckBoxSortPackage"
        Me.CheckBoxSortPackage.Size = New System.Drawing.Size(90, 17)
        Me.CheckBoxSortPackage.TabIndex = 38
        Me.CheckBoxSortPackage.Text = "Sort package"
        Me.ToolTipPackage.SetToolTip(Me.CheckBoxSortPackage, "Toggle the sort action for the package content")
        Me.CheckBoxSortPackage.UseVisualStyleBackColor = True
        '
        'RadioButtonStereotype
        '
        Me.RadioButtonStereotype.AutoSize = True
        Me.RadioButtonStereotype.Checked = True
        Me.RadioButtonStereotype.Location = New System.Drawing.Point(13, 36)
        Me.RadioButtonStereotype.Name = "RadioButtonStereotype"
        Me.RadioButtonStereotype.Size = New System.Drawing.Size(126, 17)
        Me.RadioButtonStereotype.TabIndex = 31
        Me.RadioButtonStereotype.TabStop = True
        Me.RadioButtonStereotype.Text = "Stereotype and name"
        Me.ToolTipPackage.SetToolTip(Me.RadioButtonStereotype, "Sort package content based on the stereotype and name")
        Me.RadioButtonStereotype.UseVisualStyleBackColor = True
        '
        'RadioButtonName
        '
        Me.RadioButtonName.AutoSize = True
        Me.RadioButtonName.Location = New System.Drawing.Point(13, 64)
        Me.RadioButtonName.Name = "RadioButtonName"
        Me.RadioButtonName.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonName.TabIndex = 32
        Me.RadioButtonName.Text = "name"
        Me.ToolTipPackage.SetToolTip(Me.RadioButtonName, "Sort package content based on the name")
        Me.RadioButtonName.UseVisualStyleBackColor = True
        '
        'RadioButtonAlias
        '
        Me.RadioButtonAlias.AutoSize = True
        Me.RadioButtonAlias.Location = New System.Drawing.Point(13, 92)
        Me.RadioButtonAlias.Name = "RadioButtonAlias"
        Me.RadioButtonAlias.Size = New System.Drawing.Size(47, 17)
        Me.RadioButtonAlias.TabIndex = 33
        Me.RadioButtonAlias.Text = "Alias"
        Me.ToolTipPackage.SetToolTip(Me.RadioButtonAlias, "Sort package content based on the alias")
        Me.RadioButtonAlias.UseVisualStyleBackColor = True
        '
        'RadioButtonDataVault
        '
        Me.RadioButtonDataVault.AutoSize = True
        Me.RadioButtonDataVault.Location = New System.Drawing.Point(13, 120)
        Me.RadioButtonDataVault.Name = "RadioButtonDataVault"
        Me.RadioButtonDataVault.Size = New System.Drawing.Size(94, 17)
        Me.RadioButtonDataVault.TabIndex = 43
        Me.RadioButtonDataVault.TabStop = True
        Me.RadioButtonDataVault.Text = "Datavault type"
        Me.ToolTipPackage.SetToolTip(Me.RadioButtonDataVault, "Use the datavault syntax formsorting the package content")
        Me.RadioButtonDataVault.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.CheckBoxReplaceName)
        Me.Panel2.Controls.Add(Me.CheckBoxReplaceAlias)
        Me.Panel2.Controls.Add(Me.CheckBoxReplaceNotes)
        Me.Panel2.Controls.Add(Me.CheckBoxKeywords)
        Me.Panel2.Location = New System.Drawing.Point(248, 27)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 181)
        Me.Panel2.TabIndex = 55
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.TextBoxTVName)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TextBoxTVValue)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.CheckBoxTaggedValue)
        Me.Panel3.Location = New System.Drawing.Point(248, 218)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 103)
        Me.Panel3.TabIndex = 56
        '
        'ToolTipPackage
        '
        Me.ToolTipPackage.IsBalloon = True
        Me.ToolTipPackage.ToolTipTitle = "Helper Tooltip Info"
        '
        'CheckBoxSelectedPackage
        '
        Me.CheckBoxSelectedPackage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxSelectedPackage.AutoSize = True
        Me.CheckBoxSelectedPackage.Location = New System.Drawing.Point(22, 237)
        Me.CheckBoxSelectedPackage.Name = "CheckBoxSelectedPackage"
        Me.CheckBoxSelectedPackage.Size = New System.Drawing.Size(153, 17)
        Me.CheckBoxSelectedPackage.TabIndex = 57
        Me.CheckBoxSelectedPackage.Text = "Move to selected package"
        Me.ToolTipPackage.SetToolTip(Me.CheckBoxSelectedPackage, "Move the elements in the package to the selected package in the combobox")
        Me.CheckBoxSelectedPackage.UseVisualStyleBackColor = True
        '
        'ComboBoxSelectedPackage
        '
        Me.ComboBoxSelectedPackage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxSelectedPackage.DropDownWidth = 300
        Me.ComboBoxSelectedPackage.FormattingEnabled = True
        Me.ComboBoxSelectedPackage.Location = New System.Drawing.Point(22, 256)
        Me.ComboBoxSelectedPackage.Name = "ComboBoxSelectedPackage"
        Me.ComboBoxSelectedPackage.Size = New System.Drawing.Size(221, 21)
        Me.ComboBoxSelectedPackage.TabIndex = 48
        '
        'FrmIDEAPackage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 439)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "FrmIDEAPackage"
        Me.Text = "Package Helper"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridViewSearchReplace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TabControl As Windows.Forms.TabControl
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TextBoxTVValue As Windows.Forms.TextBox
    Friend WithEvents ToolTipPackage As Windows.Forms.ToolTip
    Friend WithEvents TextBoxTVName As Windows.Forms.TextBox
    Friend WithEvents CheckBoxTaggedValue As Windows.Forms.CheckBox
    Friend WithEvents CheckBoxKeywords As Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOrphans As Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCloseWindow As Windows.Forms.CheckBox
    Friend WithEvents RadioButtonDataVault As Windows.Forms.RadioButton
    Friend WithEvents ButtonProcess As Windows.Forms.Button
    Friend WithEvents CheckBoxSearchReplace As Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSortPackage As Windows.Forms.CheckBox
    Friend WithEvents LabelPackage As Windows.Forms.Label
    Friend WithEvents CheckBoxReplaceNotes As Windows.Forms.CheckBox
    Friend WithEvents CheckBoxReplaceAlias As Windows.Forms.CheckBox
    Friend WithEvents CheckBoxReplaceName As Windows.Forms.CheckBox
    Friend WithEvents RadioButtonAlias As Windows.Forms.RadioButton
    Friend WithEvents RadioButtonName As Windows.Forms.RadioButton
    Friend WithEvents RadioButtonStereotype As Windows.Forms.RadioButton
    Friend WithEvents CheckBoxRecursive As Windows.Forms.CheckBox
    Friend WithEvents DataGridViewSearchReplace As Windows.Forms.DataGridView
    Friend WithEvents CheckBoxCollectDiagramElements As Windows.Forms.CheckBox
    Friend WithEvents CheckBoxUpdateStatus As Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMoveArchiMate As Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRemoveNesting As Windows.Forms.CheckBox
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents ComboBoxSelectedPackage As Windows.Forms.ComboBox
    Friend WithEvents CheckBoxSelectedPackage As Windows.Forms.CheckBox
End Class

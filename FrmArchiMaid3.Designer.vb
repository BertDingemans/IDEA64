<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArchiMaid3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArchiMaid3))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListViewStereoType = New System.Windows.Forms.ListView()
        Me.DataGridViewResult = New System.Windows.Forms.DataGridView()
        Me.ImageListStereoType = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBoxSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButtonSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonAddDiagram = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonCreateEmbedded = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonProcessDerive = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageToolbox = New System.Windows.Forms.TabPage()
        Me.TabPageEmbed = New System.Windows.Forms.TabPage()
        Me.RadioButtonAssignmentfrom = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAssignment = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSpecialization = New System.Windows.Forms.RadioButton()
        Me.RadioButtonComposition = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAggregation = New System.Windows.Forms.RadioButton()
        Me.DataGridViewEmbed = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBoxShowInComplete = New System.Windows.Forms.CheckBox()
        Me.DataGridViewDerive = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxEnd = New System.Windows.Forms.ListBox()
        Me.ListBoxStart = New System.Windows.Forms.ListBox()
        Me.LabelLayer = New System.Windows.Forms.ToolStripLabel()
        Me.ComboBoxLayer = New System.Windows.Forms.ToolStripComboBox()
        Me.LabelColumn = New System.Windows.Forms.ToolStripLabel()
        Me.ComboBoxColumn = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButtonView = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItemList = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuILargeIcon = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemSmallIcon = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonDisplayEmbed = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonDerive = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageToolbox.SuspendLayout()
        Me.TabPageEmbed.SuspendLayout()
        CType(Me.DataGridViewEmbed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewDerive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListViewStereoType)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridViewResult)
        Me.SplitContainer1.Size = New System.Drawing.Size(580, 379)
        Me.SplitContainer1.SplitterDistance = 181
        Me.SplitContainer1.TabIndex = 1
        '
        'ListViewStereoType
        '
        Me.ListViewStereoType.CheckBoxes = True
        Me.ListViewStereoType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewStereoType.HideSelection = False
        Me.ListViewStereoType.Location = New System.Drawing.Point(0, 0)
        Me.ListViewStereoType.Name = "ListViewStereoType"
        Me.ListViewStereoType.ShowItemToolTips = True
        Me.ListViewStereoType.Size = New System.Drawing.Size(580, 181)
        Me.ListViewStereoType.TabIndex = 0
        Me.ListViewStereoType.UseCompatibleStateImageBehavior = False
        Me.ListViewStereoType.View = System.Windows.Forms.View.List
        '
        'DataGridViewResult
        '
        Me.DataGridViewResult.AllowUserToAddRows = False
        Me.DataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewResult.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewResult.Name = "DataGridViewResult"
        Me.DataGridViewResult.RowHeadersWidth = 51
        Me.DataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewResult.Size = New System.Drawing.Size(580, 194)
        Me.DataGridViewResult.TabIndex = 0
        '
        'ImageListStereoType
        '
        Me.ImageListStereoType.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListStereoType.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListStereoType.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripTextBoxSearch, Me.ToolStripButtonSearch, Me.ToolStripSeparator1, Me.ToolStripButtonAddDiagram, Me.ToolStripSeparator4, Me.ToolStripButtonCreateEmbedded, Me.ToolStripSeparator6, Me.ToolStripButtonProcessDerive})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 436)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(594, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel1.Text = "Search"
        '
        'ToolStripTextBoxSearch
        '
        Me.ToolStripTextBoxSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBoxSearch.Name = "ToolStripTextBoxSearch"
        Me.ToolStripTextBoxSearch.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButtonSearch
        '
        Me.ToolStripButtonSearch.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonSearch.Image = CType(resources.GetObject("ToolStripButtonSearch.Image"), System.Drawing.Image)
        Me.ToolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSearch.Name = "ToolStripButtonSearch"
        Me.ToolStripButtonSearch.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripButtonSearch.Text = "Search"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonAddDiagram
        '
        Me.ToolStripButtonAddDiagram.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripButtonAddDiagram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonAddDiagram.Image = CType(resources.GetObject("ToolStripButtonAddDiagram.Image"), System.Drawing.Image)
        Me.ToolStripButtonAddDiagram.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAddDiagram.Name = "ToolStripButtonAddDiagram"
        Me.ToolStripButtonAddDiagram.Size = New System.Drawing.Size(95, 22)
        Me.ToolStripButtonAddDiagram.Text = "Add to Diagram"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonCreateEmbedded
        '
        Me.ToolStripButtonCreateEmbedded.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripButtonCreateEmbedded.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonCreateEmbedded.Image = CType(resources.GetObject("ToolStripButtonCreateEmbedded.Image"), System.Drawing.Image)
        Me.ToolStripButtonCreateEmbedded.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCreateEmbedded.Name = "ToolStripButtonCreateEmbedded"
        Me.ToolStripButtonCreateEmbedded.Size = New System.Drawing.Size(105, 22)
        Me.ToolStripButtonCreateEmbedded.Text = "Create Embedded"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonProcessDerive
        '
        Me.ToolStripButtonProcessDerive.BackColor = System.Drawing.Color.PapayaWhip
        Me.ToolStripButtonProcessDerive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonProcessDerive.Image = CType(resources.GetObject("ToolStripButtonProcessDerive.Image"), System.Drawing.Image)
        Me.ToolStripButtonProcessDerive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonProcessDerive.Name = "ToolStripButtonProcessDerive"
        Me.ToolStripButtonProcessDerive.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripButtonProcessDerive.Text = "Process derive"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageToolbox)
        Me.TabControl1.Controls.Add(Me.TabPageEmbed)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(594, 411)
        Me.TabControl1.TabIndex = 3
        '
        'TabPageToolbox
        '
        Me.TabPageToolbox.Controls.Add(Me.SplitContainer1)
        Me.TabPageToolbox.Location = New System.Drawing.Point(4, 22)
        Me.TabPageToolbox.Name = "TabPageToolbox"
        Me.TabPageToolbox.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageToolbox.Size = New System.Drawing.Size(586, 385)
        Me.TabPageToolbox.TabIndex = 0
        Me.TabPageToolbox.Text = "Find ArchiMate Stereotypes"
        Me.TabPageToolbox.UseVisualStyleBackColor = True
        '
        'TabPageEmbed
        '
        Me.TabPageEmbed.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPageEmbed.Controls.Add(Me.RadioButtonAssignmentfrom)
        Me.TabPageEmbed.Controls.Add(Me.RadioButtonAssignment)
        Me.TabPageEmbed.Controls.Add(Me.RadioButtonSpecialization)
        Me.TabPageEmbed.Controls.Add(Me.RadioButtonComposition)
        Me.TabPageEmbed.Controls.Add(Me.RadioButtonAggregation)
        Me.TabPageEmbed.Controls.Add(Me.DataGridViewEmbed)
        Me.TabPageEmbed.Location = New System.Drawing.Point(4, 22)
        Me.TabPageEmbed.Name = "TabPageEmbed"
        Me.TabPageEmbed.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEmbed.Size = New System.Drawing.Size(586, 385)
        Me.TabPageEmbed.TabIndex = 1
        Me.TabPageEmbed.Text = "Embedded connectors"
        '
        'RadioButtonAssignmentfrom
        '
        Me.RadioButtonAssignmentfrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonAssignmentfrom.AutoSize = True
        Me.RadioButtonAssignmentfrom.Location = New System.Drawing.Point(365, 353)
        Me.RadioButtonAssignmentfrom.Name = "RadioButtonAssignmentfrom"
        Me.RadioButtonAssignmentfrom.Size = New System.Drawing.Size(102, 17)
        Me.RadioButtonAssignmentfrom.TabIndex = 5
        Me.RadioButtonAssignmentfrom.Text = "Assignment from"
        Me.RadioButtonAssignmentfrom.UseVisualStyleBackColor = True
        '
        'RadioButtonAssignment
        '
        Me.RadioButtonAssignment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonAssignment.AutoSize = True
        Me.RadioButtonAssignment.Location = New System.Drawing.Point(280, 353)
        Me.RadioButtonAssignment.Name = "RadioButtonAssignment"
        Me.RadioButtonAssignment.Size = New System.Drawing.Size(79, 17)
        Me.RadioButtonAssignment.TabIndex = 4
        Me.RadioButtonAssignment.Text = "Assignment"
        Me.RadioButtonAssignment.UseVisualStyleBackColor = True
        '
        'RadioButtonSpecialization
        '
        Me.RadioButtonSpecialization.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonSpecialization.AutoSize = True
        Me.RadioButtonSpecialization.Location = New System.Drawing.Point(184, 353)
        Me.RadioButtonSpecialization.Name = "RadioButtonSpecialization"
        Me.RadioButtonSpecialization.Size = New System.Drawing.Size(90, 17)
        Me.RadioButtonSpecialization.TabIndex = 3
        Me.RadioButtonSpecialization.Text = "Specialization"
        Me.RadioButtonSpecialization.UseVisualStyleBackColor = True
        '
        'RadioButtonComposition
        '
        Me.RadioButtonComposition.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonComposition.AutoSize = True
        Me.RadioButtonComposition.Location = New System.Drawing.Point(96, 353)
        Me.RadioButtonComposition.Name = "RadioButtonComposition"
        Me.RadioButtonComposition.Size = New System.Drawing.Size(82, 17)
        Me.RadioButtonComposition.TabIndex = 2
        Me.RadioButtonComposition.Text = "Composition"
        Me.RadioButtonComposition.UseVisualStyleBackColor = True
        '
        'RadioButtonAggregation
        '
        Me.RadioButtonAggregation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonAggregation.AutoSize = True
        Me.RadioButtonAggregation.Checked = True
        Me.RadioButtonAggregation.Location = New System.Drawing.Point(8, 353)
        Me.RadioButtonAggregation.Name = "RadioButtonAggregation"
        Me.RadioButtonAggregation.Size = New System.Drawing.Size(82, 17)
        Me.RadioButtonAggregation.TabIndex = 1
        Me.RadioButtonAggregation.TabStop = True
        Me.RadioButtonAggregation.Text = "Aggregation"
        Me.RadioButtonAggregation.UseVisualStyleBackColor = True
        '
        'DataGridViewEmbed
        '
        Me.DataGridViewEmbed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewEmbed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEmbed.Location = New System.Drawing.Point(0, 3)
        Me.DataGridViewEmbed.Name = "DataGridViewEmbed"
        Me.DataGridViewEmbed.Size = New System.Drawing.Size(586, 333)
        Me.DataGridViewEmbed.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.PapayaWhip
        Me.TabPage1.Controls.Add(Me.CheckBoxShowInComplete)
        Me.TabPage1.Controls.Add(Me.DataGridViewDerive)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ListBoxEnd)
        Me.TabPage1.Controls.Add(Me.ListBoxStart)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(586, 385)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Derived Relations"
        '
        'CheckBoxShowInComplete
        '
        Me.CheckBoxShowInComplete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxShowInComplete.AutoSize = True
        Me.CheckBoxShowInComplete.Location = New System.Drawing.Point(9, 361)
        Me.CheckBoxShowInComplete.Name = "CheckBoxShowInComplete"
        Me.CheckBoxShowInComplete.Size = New System.Drawing.Size(99, 17)
        Me.CheckBoxShowInComplete.TabIndex = 5
        Me.CheckBoxShowInComplete.Text = "Show all results"
        Me.CheckBoxShowInComplete.UseVisualStyleBackColor = True
        '
        'DataGridViewDerive
        '
        Me.DataGridViewDerive.AllowUserToAddRows = False
        Me.DataGridViewDerive.AllowUserToDeleteRows = False
        Me.DataGridViewDerive.AllowUserToOrderColumns = True
        Me.DataGridViewDerive.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDerive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDerive.Location = New System.Drawing.Point(8, 195)
        Me.DataGridViewDerive.Name = "DataGridViewDerive"
        Me.DataGridViewDerive.ReadOnly = True
        Me.DataGridViewDerive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewDerive.Size = New System.Drawing.Size(562, 158)
        Me.DataGridViewDerive.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(288, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "End entity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Start entity"
        '
        'ListBoxEnd
        '
        Me.ListBoxEnd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxEnd.FormattingEnabled = True
        Me.ListBoxEnd.Location = New System.Drawing.Point(291, 38)
        Me.ListBoxEnd.Name = "ListBoxEnd"
        Me.ListBoxEnd.Size = New System.Drawing.Size(279, 147)
        Me.ListBoxEnd.TabIndex = 1
        '
        'ListBoxStart
        '
        Me.ListBoxStart.FormattingEnabled = True
        Me.ListBoxStart.Location = New System.Drawing.Point(8, 38)
        Me.ListBoxStart.Name = "ListBoxStart"
        Me.ListBoxStart.Size = New System.Drawing.Size(279, 147)
        Me.ListBoxStart.TabIndex = 0
        '
        'LabelLayer
        '
        Me.LabelLayer.Name = "LabelLayer"
        Me.LabelLayer.Size = New System.Drawing.Size(35, 22)
        Me.LabelLayer.Text = "Layer"
        '
        'ComboBoxLayer
        '
        Me.ComboBoxLayer.Name = "ComboBoxLayer"
        Me.ComboBoxLayer.Size = New System.Drawing.Size(100, 25)
        Me.ComboBoxLayer.ToolTipText = "Select the ArchiMate layer or extension"
        '
        'LabelColumn
        '
        Me.LabelColumn.Name = "LabelColumn"
        Me.LabelColumn.Size = New System.Drawing.Size(50, 22)
        Me.LabelColumn.Text = "Column"
        '
        'ComboBoxColumn
        '
        Me.ComboBoxColumn.Name = "ComboBoxColumn"
        Me.ComboBoxColumn.Size = New System.Drawing.Size(100, 25)
        Me.ComboBoxColumn.ToolTipText = "Select the ArchiMate column"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButtonView
        '
        Me.ToolStripDropDownButtonView.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripDropDownButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButtonView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemList, Me.ToolStripMenuILargeIcon, Me.ToolStripMenuItemSmallIcon})
        Me.ToolStripDropDownButtonView.Image = CType(resources.GetObject("ToolStripDropDownButtonView.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButtonView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButtonView.Name = "ToolStripDropDownButtonView"
        Me.ToolStripDropDownButtonView.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripDropDownButtonView.Text = "View"
        '
        'ToolStripMenuItemList
        '
        Me.ToolStripMenuItemList.Name = "ToolStripMenuItemList"
        Me.ToolStripMenuItemList.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItemList.Text = "List"
        '
        'ToolStripMenuILargeIcon
        '
        Me.ToolStripMenuILargeIcon.Name = "ToolStripMenuILargeIcon"
        Me.ToolStripMenuILargeIcon.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuILargeIcon.Text = "Large icon"
        '
        'ToolStripMenuItemSmallIcon
        '
        Me.ToolStripMenuItemSmallIcon.Name = "ToolStripMenuItemSmallIcon"
        Me.ToolStripMenuItemSmallIcon.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItemSmallIcon.Text = "Small icon"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelLayer, Me.ComboBoxLayer, Me.LabelColumn, Me.ComboBoxColumn, Me.ToolStripSeparator2, Me.ToolStripDropDownButtonView, Me.ToolStripSeparator5, Me.ToolStripButtonDisplayEmbed, Me.ToolStripSeparator3, Me.ToolStripButtonDerive})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(594, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonDisplayEmbed
        '
        Me.ToolStripButtonDisplayEmbed.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripButtonDisplayEmbed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonDisplayEmbed.Image = CType(resources.GetObject("ToolStripButtonDisplayEmbed.Image"), System.Drawing.Image)
        Me.ToolStripButtonDisplayEmbed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDisplayEmbed.Name = "ToolStripButtonDisplayEmbed"
        Me.ToolStripButtonDisplayEmbed.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripButtonDisplayEmbed.Text = "Display Embed"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonDerive
        '
        Me.ToolStripButtonDerive.BackColor = System.Drawing.Color.PapayaWhip
        Me.ToolStripButtonDerive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonDerive.Image = CType(resources.GetObject("ToolStripButtonDerive.Image"), System.Drawing.Image)
        Me.ToolStripButtonDerive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDerive.Name = "ToolStripButtonDerive"
        Me.ToolStripButtonDerive.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripButtonDerive.Text = "Derive"
        '
        'FrmArchiMaid3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmArchiMaid3"
        Me.Text = "ArchiMaid"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridViewResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageToolbox.ResumeLayout(False)
        Me.TabPageEmbed.ResumeLayout(False)
        Me.TabPageEmbed.PerformLayout()
        CType(Me.DataGridViewEmbed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridViewDerive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListViewStereoType As System.Windows.Forms.ListView
    Friend WithEvents ImageListStereoType As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBoxSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButtonSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonAddDiagram As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewResult As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents TabPageToolbox As Windows.Forms.TabPage
    Friend WithEvents TabPageEmbed As Windows.Forms.TabPage
    Friend WithEvents LabelLayer As Windows.Forms.ToolStripLabel
    Friend WithEvents ComboBoxLayer As Windows.Forms.ToolStripComboBox
    Friend WithEvents LabelColumn As Windows.Forms.ToolStripLabel
    Friend WithEvents ComboBoxColumn As Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButtonView As Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItemList As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuILargeIcon As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemSmallIcon As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As Windows.Forms.ToolStrip
    Friend WithEvents DataGridViewEmbed As Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator3 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonDisplayEmbed As Windows.Forms.ToolStripButton
    Friend WithEvents RadioButtonAssignment As Windows.Forms.RadioButton
    Friend WithEvents RadioButtonSpecialization As Windows.Forms.RadioButton
    Friend WithEvents RadioButtonComposition As Windows.Forms.RadioButton
    Friend WithEvents RadioButtonAggregation As Windows.Forms.RadioButton
    Friend WithEvents ToolStripSeparator4 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonCreateEmbedded As Windows.Forms.ToolStripButton
    Friend WithEvents RadioButtonAssignmentfrom As Windows.Forms.RadioButton
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents ListBoxEnd As Windows.Forms.ListBox
    Friend WithEvents ListBoxStart As Windows.Forms.ListBox
    Friend WithEvents ToolStripSeparator5 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonDerive As Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewDerive As Windows.Forms.DataGridView
    Friend WithEvents ToolStripButtonProcessDerive As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckBoxShowInComplete As Windows.Forms.CheckBox
End Class

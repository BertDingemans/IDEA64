<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmIDEAFormFactory
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageDataSet = New System.Windows.Forms.TabPage()
        Me.CheckBoxCreateDirect = New System.Windows.Forms.CheckBox()
        Me.LabelXMLFile = New System.Windows.Forms.Label()
        Me.LabelDatabaseConnection = New System.Windows.Forms.Label()
        Me.ButtonXMLFile = New System.Windows.Forms.Button()
        Me.ButtonDatabaseConnection = New System.Windows.Forms.Button()
        Me.CheckBoxSaveDataSet = New System.Windows.Forms.CheckBox()
        Me.CheckBoxForeignKeys = New System.Windows.Forms.CheckBox()
        Me.CheckBoxModelTables = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSystemTables = New System.Windows.Forms.CheckBox()
        Me.ButtonInspector = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxDiagrams = New System.Windows.Forms.CheckedListBox()
        Me.ButtonSimulator = New System.Windows.Forms.Button()
        Me.CheckBoxClipBoard = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxDatasetCode = New System.Windows.Forms.TextBox()
        Me.ButtonGenerateDataSet = New System.Windows.Forms.Button()
        Me.TabPageFormFactory = New System.Windows.Forms.TabPage()
        Me.CheckBoxCreateMenu = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDeleteMenu = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCreateLookup = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDeleteLookup = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCreateClass = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDeleteClass = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCreateEnumeration = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDeleteEnumeration = New System.Windows.Forms.CheckBox()
        Me.CheckBoxClose = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.ButtonToggleAll = New System.Windows.Forms.Button()
        Me.ButtonSelectAll = New System.Windows.Forms.Button()
        Me.ListBoxElements = New System.Windows.Forms.CheckedListBox()
        Me.ButtonUnselectAll = New System.Windows.Forms.Button()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.ComboBoxPackage = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialogDataSet = New System.Windows.Forms.SaveFileDialog()
        Me.FileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.CheckBoxToSQL = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPageDataSet.SuspendLayout()
        Me.TabPageFormFactory.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPageDataSet)
        Me.TabControl1.Controls.Add(Me.TabPageFormFactory)
        Me.TabControl1.Location = New System.Drawing.Point(3, 39)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1035, 458)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageDataSet
        '
        Me.TabPageDataSet.BackColor = System.Drawing.Color.LightGray
        Me.TabPageDataSet.Controls.Add(Me.CheckBoxToSQL)
        Me.TabPageDataSet.Controls.Add(Me.CheckBoxCreateDirect)
        Me.TabPageDataSet.Controls.Add(Me.LabelXMLFile)
        Me.TabPageDataSet.Controls.Add(Me.LabelDatabaseConnection)
        Me.TabPageDataSet.Controls.Add(Me.ButtonXMLFile)
        Me.TabPageDataSet.Controls.Add(Me.ButtonDatabaseConnection)
        Me.TabPageDataSet.Controls.Add(Me.CheckBoxSaveDataSet)
        Me.TabPageDataSet.Controls.Add(Me.CheckBoxForeignKeys)
        Me.TabPageDataSet.Controls.Add(Me.CheckBoxModelTables)
        Me.TabPageDataSet.Controls.Add(Me.CheckBoxSystemTables)
        Me.TabPageDataSet.Controls.Add(Me.ButtonInspector)
        Me.TabPageDataSet.Controls.Add(Me.Label2)
        Me.TabPageDataSet.Controls.Add(Me.ListBoxDiagrams)
        Me.TabPageDataSet.Controls.Add(Me.ButtonSimulator)
        Me.TabPageDataSet.Controls.Add(Me.CheckBoxClipBoard)
        Me.TabPageDataSet.Controls.Add(Me.Label7)
        Me.TabPageDataSet.Controls.Add(Me.TextBoxDatasetCode)
        Me.TabPageDataSet.Controls.Add(Me.ButtonGenerateDataSet)
        Me.TabPageDataSet.Location = New System.Drawing.Point(4, 25)
        Me.TabPageDataSet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageDataSet.Name = "TabPageDataSet"
        Me.TabPageDataSet.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageDataSet.Size = New System.Drawing.Size(1027, 429)
        Me.TabPageDataSet.TabIndex = 2
        Me.TabPageDataSet.Text = "Dataset/Simulator"
        '
        'CheckBoxCreateDirect
        '
        Me.CheckBoxCreateDirect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxCreateDirect.AutoSize = True
        Me.CheckBoxCreateDirect.Location = New System.Drawing.Point(864, 341)
        Me.CheckBoxCreateDirect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxCreateDirect.Name = "CheckBoxCreateDirect"
        Me.CheckBoxCreateDirect.Size = New System.Drawing.Size(107, 20)
        Me.CheckBoxCreateDirect.TabIndex = 34
        Me.CheckBoxCreateDirect.Text = "Create Direct"
        Me.CheckBoxCreateDirect.UseVisualStyleBackColor = True
        '
        'LabelXMLFile
        '
        Me.LabelXMLFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelXMLFile.AutoSize = True
        Me.LabelXMLFile.Location = New System.Drawing.Point(459, 156)
        Me.LabelXMLFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelXMLFile.Name = "LabelXMLFile"
        Me.LabelXMLFile.Size = New System.Drawing.Size(33, 16)
        Me.LabelXMLFile.TabIndex = 33
        Me.LabelXMLFile.Text = "XML"
        '
        'LabelDatabaseConnection
        '
        Me.LabelDatabaseConnection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDatabaseConnection.AutoSize = True
        Me.LabelDatabaseConnection.Location = New System.Drawing.Point(459, 105)
        Me.LabelDatabaseConnection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDatabaseConnection.Name = "LabelDatabaseConnection"
        Me.LabelDatabaseConnection.Size = New System.Drawing.Size(74, 16)
        Me.LabelDatabaseConnection.TabIndex = 32
        Me.LabelDatabaseConnection.Text = "Connection"
        '
        'ButtonXMLFile
        '
        Me.ButtonXMLFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonXMLFile.Location = New System.Drawing.Point(460, 124)
        Me.ButtonXMLFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonXMLFile.Name = "ButtonXMLFile"
        Me.ButtonXMLFile.Size = New System.Drawing.Size(169, 28)
        Me.ButtonXMLFile.TabIndex = 31
        Me.ButtonXMLFile.Text = "XML File"
        Me.ButtonXMLFile.UseVisualStyleBackColor = True
        '
        'ButtonDatabaseConnection
        '
        Me.ButtonDatabaseConnection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDatabaseConnection.Location = New System.Drawing.Point(460, 73)
        Me.ButtonDatabaseConnection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonDatabaseConnection.Name = "ButtonDatabaseConnection"
        Me.ButtonDatabaseConnection.Size = New System.Drawing.Size(169, 28)
        Me.ButtonDatabaseConnection.TabIndex = 30
        Me.ButtonDatabaseConnection.Text = "Database connection"
        Me.ButtonDatabaseConnection.UseVisualStyleBackColor = True
        '
        'CheckBoxSaveDataSet
        '
        Me.CheckBoxSaveDataSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxSaveDataSet.AutoSize = True
        Me.CheckBoxSaveDataSet.Location = New System.Drawing.Point(864, 165)
        Me.CheckBoxSaveDataSet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxSaveDataSet.Name = "CheckBoxSaveDataSet"
        Me.CheckBoxSaveDataSet.Size = New System.Drawing.Size(109, 20)
        Me.CheckBoxSaveDataSet.TabIndex = 29
        Me.CheckBoxSaveDataSet.Text = "Save dataset"
        Me.CheckBoxSaveDataSet.UseVisualStyleBackColor = True
        '
        'CheckBoxForeignKeys
        '
        Me.CheckBoxForeignKeys.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxForeignKeys.AutoSize = True
        Me.CheckBoxForeignKeys.Checked = True
        Me.CheckBoxForeignKeys.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxForeignKeys.Location = New System.Drawing.Point(864, 256)
        Me.CheckBoxForeignKeys.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxForeignKeys.Name = "CheckBoxForeignKeys"
        Me.CheckBoxForeignKeys.Size = New System.Drawing.Size(107, 20)
        Me.CheckBoxForeignKeys.TabIndex = 28
        Me.CheckBoxForeignKeys.Text = "Foreign keys"
        Me.CheckBoxForeignKeys.UseVisualStyleBackColor = True
        '
        'CheckBoxModelTables
        '
        Me.CheckBoxModelTables.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxModelTables.AutoSize = True
        Me.CheckBoxModelTables.Checked = True
        Me.CheckBoxModelTables.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxModelTables.Location = New System.Drawing.Point(864, 225)
        Me.CheckBoxModelTables.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxModelTables.Name = "CheckBoxModelTables"
        Me.CheckBoxModelTables.Size = New System.Drawing.Size(107, 20)
        Me.CheckBoxModelTables.TabIndex = 27
        Me.CheckBoxModelTables.Text = "Model tables"
        Me.CheckBoxModelTables.UseVisualStyleBackColor = True
        '
        'CheckBoxSystemTables
        '
        Me.CheckBoxSystemTables.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxSystemTables.AutoSize = True
        Me.CheckBoxSystemTables.Location = New System.Drawing.Point(864, 195)
        Me.CheckBoxSystemTables.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxSystemTables.Name = "CheckBoxSystemTables"
        Me.CheckBoxSystemTables.Size = New System.Drawing.Size(114, 20)
        Me.CheckBoxSystemTables.TabIndex = 26
        Me.CheckBoxSystemTables.Text = "System tables"
        Me.CheckBoxSystemTables.UseVisualStyleBackColor = True
        '
        'ButtonInspector
        '
        Me.ButtonInspector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonInspector.Location = New System.Drawing.Point(460, 6)
        Me.ButtonInspector.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonInspector.Name = "ButtonInspector"
        Me.ButtonInspector.Size = New System.Drawing.Size(169, 28)
        Me.ButtonInspector.TabIndex = 25
        Me.ButtonInspector.Text = "Model inspector"
        Me.ButtonInspector.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Diagrams"
        '
        'ListBoxDiagrams
        '
        Me.ListBoxDiagrams.FormattingEnabled = True
        Me.ListBoxDiagrams.Location = New System.Drawing.Point(107, 6)
        Me.ListBoxDiagrams.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxDiagrams.Name = "ListBoxDiagrams"
        Me.ListBoxDiagrams.Size = New System.Drawing.Size(344, 140)
        Me.ListBoxDiagrams.TabIndex = 23
        '
        'ButtonSimulator
        '
        Me.ButtonSimulator.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSimulator.Location = New System.Drawing.Point(833, 6)
        Me.ButtonSimulator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSimulator.Name = "ButtonSimulator"
        Me.ButtonSimulator.Size = New System.Drawing.Size(181, 66)
        Me.ButtonSimulator.TabIndex = 9
        Me.ButtonSimulator.Text = "Simulator"
        Me.ButtonSimulator.UseVisualStyleBackColor = True
        '
        'CheckBoxClipBoard
        '
        Me.CheckBoxClipBoard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxClipBoard.AutoSize = True
        Me.CheckBoxClipBoard.Checked = True
        Me.CheckBoxClipBoard.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxClipBoard.Location = New System.Drawing.Point(864, 288)
        Me.CheckBoxClipBoard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxClipBoard.Name = "CheckBoxClipBoard"
        Me.CheckBoxClipBoard.Size = New System.Drawing.Size(108, 20)
        Me.CheckBoxClipBoard.TabIndex = 8
        Me.CheckBoxClipBoard.Text = "To Clipboard"
        Me.CheckBoxClipBoard.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "SQL code"
        '
        'TextBoxDatasetCode
        '
        Me.TextBoxDatasetCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDatasetCode.Location = New System.Drawing.Point(107, 183)
        Me.TextBoxDatasetCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxDatasetCode.Multiline = True
        Me.TextBoxDatasetCode.Name = "TextBoxDatasetCode"
        Me.TextBoxDatasetCode.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxDatasetCode.Size = New System.Drawing.Size(704, 235)
        Me.TextBoxDatasetCode.TabIndex = 6
        '
        'ButtonGenerateDataSet
        '
        Me.ButtonGenerateDataSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGenerateDataSet.Location = New System.Drawing.Point(832, 367)
        Me.ButtonGenerateDataSet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonGenerateDataSet.Name = "ButtonGenerateDataSet"
        Me.ButtonGenerateDataSet.Size = New System.Drawing.Size(189, 53)
        Me.ButtonGenerateDataSet.TabIndex = 5
        Me.ButtonGenerateDataSet.Text = "Generate SQL from dataset"
        Me.ButtonGenerateDataSet.UseVisualStyleBackColor = True
        '
        'TabPageFormFactory
        '
        Me.TabPageFormFactory.BackColor = System.Drawing.Color.LightGray
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxCreateMenu)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxDeleteMenu)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxCreateLookup)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxDeleteLookup)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxCreateClass)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxDeleteClass)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxCreateEnumeration)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxDeleteEnumeration)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxClose)
        Me.TabPageFormFactory.Controls.Add(Me.Label5)
        Me.TabPageFormFactory.Controls.Add(Me.ButtonGenerate)
        Me.TabPageFormFactory.Controls.Add(Me.ButtonToggleAll)
        Me.TabPageFormFactory.Controls.Add(Me.ButtonSelectAll)
        Me.TabPageFormFactory.Controls.Add(Me.ListBoxElements)
        Me.TabPageFormFactory.Controls.Add(Me.ButtonUnselectAll)
        Me.TabPageFormFactory.Location = New System.Drawing.Point(4, 25)
        Me.TabPageFormFactory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageFormFactory.Name = "TabPageFormFactory"
        Me.TabPageFormFactory.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageFormFactory.Size = New System.Drawing.Size(1027, 429)
        Me.TabPageFormFactory.TabIndex = 1
        Me.TabPageFormFactory.Text = "FormFactory"
        '
        'CheckBoxCreateMenu
        '
        Me.CheckBoxCreateMenu.AutoSize = True
        Me.CheckBoxCreateMenu.Checked = True
        Me.CheckBoxCreateMenu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCreateMenu.Location = New System.Drawing.Point(420, 271)
        Me.CheckBoxCreateMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxCreateMenu.Name = "CheckBoxCreateMenu"
        Me.CheckBoxCreateMenu.Size = New System.Drawing.Size(112, 20)
        Me.CheckBoxCreateMenu.TabIndex = 35
        Me.CheckBoxCreateMenu.Text = "Create Menus"
        Me.CheckBoxCreateMenu.UseVisualStyleBackColor = True
        '
        'CheckBoxDeleteMenu
        '
        Me.CheckBoxDeleteMenu.AutoSize = True
        Me.CheckBoxDeleteMenu.Checked = True
        Me.CheckBoxDeleteMenu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDeleteMenu.Location = New System.Drawing.Point(420, 244)
        Me.CheckBoxDeleteMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxDeleteMenu.Name = "CheckBoxDeleteMenu"
        Me.CheckBoxDeleteMenu.Size = New System.Drawing.Size(112, 20)
        Me.CheckBoxDeleteMenu.TabIndex = 34
        Me.CheckBoxDeleteMenu.Text = "Delete Menus"
        Me.CheckBoxDeleteMenu.UseVisualStyleBackColor = True
        '
        'CheckBoxCreateLookup
        '
        Me.CheckBoxCreateLookup.AutoSize = True
        Me.CheckBoxCreateLookup.Checked = True
        Me.CheckBoxCreateLookup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCreateLookup.Location = New System.Drawing.Point(420, 215)
        Me.CheckBoxCreateLookup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxCreateLookup.Name = "CheckBoxCreateLookup"
        Me.CheckBoxCreateLookup.Size = New System.Drawing.Size(124, 20)
        Me.CheckBoxCreateLookup.TabIndex = 33
        Me.CheckBoxCreateLookup.Text = "Create Lookups"
        Me.CheckBoxCreateLookup.UseVisualStyleBackColor = True
        '
        'CheckBoxDeleteLookup
        '
        Me.CheckBoxDeleteLookup.AutoSize = True
        Me.CheckBoxDeleteLookup.Checked = True
        Me.CheckBoxDeleteLookup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDeleteLookup.Location = New System.Drawing.Point(420, 188)
        Me.CheckBoxDeleteLookup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxDeleteLookup.Name = "CheckBoxDeleteLookup"
        Me.CheckBoxDeleteLookup.Size = New System.Drawing.Size(124, 20)
        Me.CheckBoxDeleteLookup.TabIndex = 32
        Me.CheckBoxDeleteLookup.Text = "Delete Lookups"
        Me.CheckBoxDeleteLookup.UseVisualStyleBackColor = True
        '
        'CheckBoxCreateClass
        '
        Me.CheckBoxCreateClass.AutoSize = True
        Me.CheckBoxCreateClass.Checked = True
        Me.CheckBoxCreateClass.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCreateClass.Location = New System.Drawing.Point(420, 160)
        Me.CheckBoxCreateClass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxCreateClass.Name = "CheckBoxCreateClass"
        Me.CheckBoxCreateClass.Size = New System.Drawing.Size(185, 20)
        Me.CheckBoxCreateClass.TabIndex = 31
        Me.CheckBoxCreateClass.Text = "Create Selected Classess"
        Me.CheckBoxCreateClass.UseVisualStyleBackColor = True
        '
        'CheckBoxDeleteClass
        '
        Me.CheckBoxDeleteClass.AutoSize = True
        Me.CheckBoxDeleteClass.Checked = True
        Me.CheckBoxDeleteClass.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDeleteClass.Location = New System.Drawing.Point(420, 133)
        Me.CheckBoxDeleteClass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxDeleteClass.Name = "CheckBoxDeleteClass"
        Me.CheckBoxDeleteClass.Size = New System.Drawing.Size(178, 20)
        Me.CheckBoxDeleteClass.TabIndex = 30
        Me.CheckBoxDeleteClass.Text = "Delete Selected Classes"
        Me.CheckBoxDeleteClass.UseVisualStyleBackColor = True
        '
        'CheckBoxCreateEnumeration
        '
        Me.CheckBoxCreateEnumeration.AutoSize = True
        Me.CheckBoxCreateEnumeration.Checked = True
        Me.CheckBoxCreateEnumeration.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCreateEnumeration.Location = New System.Drawing.Point(420, 102)
        Me.CheckBoxCreateEnumeration.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxCreateEnumeration.Name = "CheckBoxCreateEnumeration"
        Me.CheckBoxCreateEnumeration.Size = New System.Drawing.Size(154, 20)
        Me.CheckBoxCreateEnumeration.TabIndex = 29
        Me.CheckBoxCreateEnumeration.Text = "Create Enumerations"
        Me.CheckBoxCreateEnumeration.UseVisualStyleBackColor = True
        '
        'CheckBoxDeleteEnumeration
        '
        Me.CheckBoxDeleteEnumeration.AutoSize = True
        Me.CheckBoxDeleteEnumeration.Checked = True
        Me.CheckBoxDeleteEnumeration.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDeleteEnumeration.Location = New System.Drawing.Point(420, 75)
        Me.CheckBoxDeleteEnumeration.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxDeleteEnumeration.Name = "CheckBoxDeleteEnumeration"
        Me.CheckBoxDeleteEnumeration.Size = New System.Drawing.Size(154, 20)
        Me.CheckBoxDeleteEnumeration.TabIndex = 28
        Me.CheckBoxDeleteEnumeration.Text = "Delete Enumerations"
        Me.CheckBoxDeleteEnumeration.UseVisualStyleBackColor = True
        '
        'CheckBoxClose
        '
        Me.CheckBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxClose.AutoSize = True
        Me.CheckBoxClose.Checked = True
        Me.CheckBoxClose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxClose.Location = New System.Drawing.Point(772, 396)
        Me.CheckBoxClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxClose.Name = "CheckBoxClose"
        Me.CheckBoxClose.Size = New System.Drawing.Size(241, 20)
        Me.CheckBoxClose.TabIndex = 3
        Me.CheckBoxClose.Text = "Close window after generating code"
        Me.CheckBoxClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(655, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(345, 29)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "FormFactory code generator"
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGenerate.Location = New System.Drawing.Point(787, 326)
        Me.ButtonGenerate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(227, 62)
        Me.ButtonGenerate.TabIndex = 2
        Me.ButtonGenerate.Text = "Generate"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'ButtonToggleAll
        '
        Me.ButtonToggleAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonToggleAll.Location = New System.Drawing.Point(129, 377)
        Me.ButtonToggleAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonToggleAll.Name = "ButtonToggleAll"
        Me.ButtonToggleAll.Size = New System.Drawing.Size(100, 28)
        Me.ButtonToggleAll.TabIndex = 24
        Me.ButtonToggleAll.Text = "Toggle"
        Me.ButtonToggleAll.UseVisualStyleBackColor = True
        '
        'ButtonSelectAll
        '
        Me.ButtonSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSelectAll.Location = New System.Drawing.Point(8, 377)
        Me.ButtonSelectAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSelectAll.Name = "ButtonSelectAll"
        Me.ButtonSelectAll.Size = New System.Drawing.Size(100, 28)
        Me.ButtonSelectAll.TabIndex = 23
        Me.ButtonSelectAll.Text = "Select All"
        Me.ButtonSelectAll.UseVisualStyleBackColor = True
        '
        'ListBoxElements
        '
        Me.ListBoxElements.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBoxElements.FormattingEnabled = True
        Me.ListBoxElements.Location = New System.Drawing.Point(8, 21)
        Me.ListBoxElements.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxElements.Name = "ListBoxElements"
        Me.ListBoxElements.Size = New System.Drawing.Size(344, 310)
        Me.ListBoxElements.TabIndex = 22
        '
        'ButtonUnselectAll
        '
        Me.ButtonUnselectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonUnselectAll.Location = New System.Drawing.Point(253, 377)
        Me.ButtonUnselectAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonUnselectAll.Name = "ButtonUnselectAll"
        Me.ButtonUnselectAll.Size = New System.Drawing.Size(100, 28)
        Me.ButtonUnselectAll.TabIndex = 25
        Me.ButtonUnselectAll.Text = "Unselect All"
        Me.ButtonUnselectAll.UseVisualStyleBackColor = True
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Location = New System.Drawing.Point(405, 7)
        Me.ButtonLoad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(55, 28)
        Me.ButtonLoad.TabIndex = 23
        Me.ButtonLoad.Text = "Load"
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'ComboBoxPackage
        '
        Me.ComboBoxPackage.FormattingEnabled = True
        Me.ComboBoxPackage.Location = New System.Drawing.Point(13, 7)
        Me.ComboBoxPackage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxPackage.Name = "ComboBoxPackage"
        Me.ComboBoxPackage.Size = New System.Drawing.Size(385, 24)
        Me.ComboBoxPackage.TabIndex = 22
        '
        'CheckBoxToSQL
        '
        Me.CheckBoxToSQL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxToSQL.AutoSize = True
        Me.CheckBoxToSQL.Checked = True
        Me.CheckBoxToSQL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxToSQL.Location = New System.Drawing.Point(864, 317)
        Me.CheckBoxToSQL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxToSQL.Name = "CheckBoxToSQL"
        Me.CheckBoxToSQL.Size = New System.Drawing.Size(100, 20)
        Me.CheckBoxToSQL.TabIndex = 35
        Me.CheckBoxToSQL.Text = "To SQL File"
        Me.CheckBoxToSQL.UseVisualStyleBackColor = True
        '
        'FrmIDEAFormFactory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 497)
        Me.Controls.Add(Me.ButtonLoad)
        Me.Controls.Add(Me.ComboBoxPackage)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmIDEAFormFactory"
        Me.Text = "IDEA LDM Simulator"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageDataSet.ResumeLayout(False)
        Me.TabPageDataSet.PerformLayout()
        Me.TabPageFormFactory.ResumeLayout(False)
        Me.TabPageFormFactory.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageFormFactory As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxClose As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonGenerate As System.Windows.Forms.Button
    Friend WithEvents ButtonToggleAll As System.Windows.Forms.Button
    Friend WithEvents ButtonSelectAll As System.Windows.Forms.Button
    Friend WithEvents ListBoxElements As System.Windows.Forms.CheckedListBox
    Friend WithEvents ButtonUnselectAll As System.Windows.Forms.Button
    Friend WithEvents ButtonLoad As System.Windows.Forms.Button
    Friend WithEvents ComboBoxPackage As System.Windows.Forms.ComboBox
    Friend WithEvents TabPageDataSet As System.Windows.Forms.TabPage
    Friend WithEvents SaveFileDialogDataSet As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDatasetCode As System.Windows.Forms.TextBox
    Friend WithEvents ButtonGenerateDataSet As System.Windows.Forms.Button
    Friend WithEvents CheckBoxClipBoard As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonSimulator As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBoxDiagrams As System.Windows.Forms.CheckedListBox
    Friend WithEvents ButtonInspector As System.Windows.Forms.Button
    Friend WithEvents CheckBoxSaveDataSet As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxForeignKeys As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxModelTables As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSystemTables As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonXMLFile As System.Windows.Forms.Button
    Friend WithEvents ButtonDatabaseConnection As System.Windows.Forms.Button
    Friend WithEvents FileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LabelXMLFile As System.Windows.Forms.Label
    Friend WithEvents LabelDatabaseConnection As System.Windows.Forms.Label
    Friend WithEvents CheckBoxCreateDirect As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCreateLookup As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDeleteLookup As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCreateClass As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDeleteClass As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCreateEnumeration As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDeleteEnumeration As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCreateMenu As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDeleteMenu As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxToSQL As Windows.Forms.CheckBox
End Class

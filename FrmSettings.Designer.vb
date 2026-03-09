<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Me.DataGridViewSettings = New System.Windows.Forms.DataGridView()
        Me.TabControlSettings = New System.Windows.Forms.TabControl()
        Me.TabPageUser = New System.Windows.Forms.TabPage()
        Me.TextBoxSettingFile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxExtendedWarning = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSuppressValidationWarning = New System.Windows.Forms.CheckBox()
        Me.CheckBoxEntityChecker = New System.Windows.Forms.CheckBox()
        Me.CheckBoxShowAidOnDiagramOpen = New System.Windows.Forms.CheckBox()
        Me.CheckBoxXSDHelper = New System.Windows.Forms.CheckBox()
        Me.CheckBoxArchiMateHelper = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPackageHelper = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTableHelper = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDiagramHelper = New System.Windows.Forms.CheckBox()
        Me.CheckBoxClassHelper = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxAnalyserWindow = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSolutionWizard = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDocumentImport = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAssistant = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDeduplicator = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDatAid = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFormFactory = New System.Windows.Forms.CheckBox()
        Me.CheckBoxArchimAid = New System.Windows.Forms.CheckBox()
        Me.TabPageSystem = New System.Windows.Forms.TabPage()
        Me.TabPageStatements = New System.Windows.Forms.TabPage()
        Me.DataGridViewStatement = New System.Windows.Forms.DataGridView()
        Me.TabPageTranslations = New System.Windows.Forms.TabPage()
        Me.DataGridViewTranslations = New System.Windows.Forms.DataGridView()
        Me.TabPageArchiMaid = New System.Windows.Forms.TabPage()
        Me.DataGridViewArchiMaid = New System.Windows.Forms.DataGridView()
        Me.TabPageDataAnalyser = New System.Windows.Forms.TabPage()
        Me.DataGridViewDataAnalyser = New System.Windows.Forms.DataGridView()
        Me.ToolTipSettings = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComboBoxSettingMode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlSettings.SuspendLayout()
        Me.TabPageUser.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPageSystem.SuspendLayout()
        Me.TabPageStatements.SuspendLayout()
        CType(Me.DataGridViewStatement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageTranslations.SuspendLayout()
        CType(Me.DataGridViewTranslations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageArchiMaid.SuspendLayout()
        CType(Me.DataGridViewArchiMaid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageDataAnalyser.SuspendLayout()
        CType(Me.DataGridViewDataAnalyser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewSettings
        '
        Me.DataGridViewSettings.AllowUserToAddRows = False
        Me.DataGridViewSettings.AllowUserToOrderColumns = True
        Me.DataGridViewSettings.ColumnHeadersHeight = 29
        Me.DataGridViewSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewSettings.Location = New System.Drawing.Point(4, 4)
        Me.DataGridViewSettings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewSettings.Name = "DataGridViewSettings"
        Me.DataGridViewSettings.RowHeadersWidth = 51
        Me.DataGridViewSettings.RowTemplate.Height = 24
        Me.DataGridViewSettings.Size = New System.Drawing.Size(811, 432)
        Me.DataGridViewSettings.TabIndex = 0
        Me.ToolTipSettings.SetToolTip(Me.DataGridViewSettings, "List of system settings for the helpers and IDEA functionalities")
        '
        'TabControlSettings
        '
        Me.TabControlSettings.Controls.Add(Me.TabPageUser)
        Me.TabControlSettings.Controls.Add(Me.TabPageSystem)
        Me.TabControlSettings.Controls.Add(Me.TabPageStatements)
        Me.TabControlSettings.Controls.Add(Me.TabPageTranslations)
        Me.TabControlSettings.Controls.Add(Me.TabPageArchiMaid)
        Me.TabControlSettings.Controls.Add(Me.TabPageDataAnalyser)
        Me.TabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlSettings.Location = New System.Drawing.Point(0, 0)
        Me.TabControlSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControlSettings.Name = "TabControlSettings"
        Me.TabControlSettings.SelectedIndex = 0
        Me.TabControlSettings.Size = New System.Drawing.Size(827, 469)
        Me.TabControlSettings.TabIndex = 1
        '
        'TabPageUser
        '
        Me.TabPageUser.BackColor = System.Drawing.Color.LightGray
        Me.TabPageUser.Controls.Add(Me.Label2)
        Me.TabPageUser.Controls.Add(Me.ComboBoxSettingMode)
        Me.TabPageUser.Controls.Add(Me.TextBoxSettingFile)
        Me.TabPageUser.Controls.Add(Me.Label1)
        Me.TabPageUser.Controls.Add(Me.ButtonReset)
        Me.TabPageUser.Controls.Add(Me.TextBox1)
        Me.TabPageUser.Controls.Add(Me.GroupBox2)
        Me.TabPageUser.Controls.Add(Me.GroupBox1)
        Me.TabPageUser.Location = New System.Drawing.Point(4, 25)
        Me.TabPageUser.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageUser.Name = "TabPageUser"
        Me.TabPageUser.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageUser.Size = New System.Drawing.Size(819, 440)
        Me.TabPageUser.TabIndex = 1
        Me.TabPageUser.Text = "User"
        '
        'TextBoxSettingFile
        '
        Me.TextBoxSettingFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSettingFile.Location = New System.Drawing.Point(628, 166)
        Me.TextBoxSettingFile.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxSettingFile.Name = "TextBoxSettingFile"
        Me.TextBoxSettingFile.Size = New System.Drawing.Size(176, 22)
        Me.TextBoxSettingFile.TabIndex = 10
        Me.ToolTipSettings.SetToolTip(Me.TextBoxSettingFile, "Path of the config file for filebased settings")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(625, 136)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Config file"
        '
        'ButtonReset
        '
        Me.ButtonReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonReset.BackColor = System.Drawing.Color.Silver
        Me.ButtonReset.Location = New System.Drawing.Point(628, 20)
        Me.ButtonReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(180, 50)
        Me.ButtonReset.TabIndex = 8
        Me.ButtonReset.Text = "Reset usersettings"
        Me.ToolTipSettings.SetToolTip(Me.ButtonReset, "Return to default settings")
        Me.ButtonReset.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(13, 362)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(795, 65)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Settings in the system tab can be stored in a shared file named IDEAConfig.xml. T" &
    "he items under the usertab are stored in your userspecific data and are specific" &
    " for you as user"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxExtendedWarning)
        Me.GroupBox2.Controls.Add(Me.CheckBoxSuppressValidationWarning)
        Me.GroupBox2.Controls.Add(Me.CheckBoxEntityChecker)
        Me.GroupBox2.Controls.Add(Me.CheckBoxShowAidOnDiagramOpen)
        Me.GroupBox2.Controls.Add(Me.CheckBoxXSDHelper)
        Me.GroupBox2.Controls.Add(Me.CheckBoxArchiMateHelper)
        Me.GroupBox2.Controls.Add(Me.CheckBoxPackageHelper)
        Me.GroupBox2.Controls.Add(Me.CheckBoxTableHelper)
        Me.GroupBox2.Controls.Add(Me.CheckBoxDiagramHelper)
        Me.GroupBox2.Controls.Add(Me.CheckBoxClassHelper)
        Me.GroupBox2.Location = New System.Drawing.Point(291, 17)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(265, 329)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Helpers"
        '
        'CheckBoxExtendedWarning
        '
        Me.CheckBoxExtendedWarning.AutoSize = True
        Me.CheckBoxExtendedWarning.Location = New System.Drawing.Point(20, 260)
        Me.CheckBoxExtendedWarning.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxExtendedWarning.Name = "CheckBoxExtendedWarning"
        Me.CheckBoxExtendedWarning.Size = New System.Drawing.Size(182, 20)
        Me.CheckBoxExtendedWarning.TabIndex = 19
        Me.CheckBoxExtendedWarning.Text = "Extended Warning Dialog"
        Me.ToolTipSettings.SetToolTip(Me.CheckBoxExtendedWarning, "Display the extended warning dialog for the duplicator")
        Me.CheckBoxExtendedWarning.UseVisualStyleBackColor = True
        '
        'CheckBoxSuppressValidationWarning
        '
        Me.CheckBoxSuppressValidationWarning.AutoSize = True
        Me.CheckBoxSuppressValidationWarning.Location = New System.Drawing.Point(20, 286)
        Me.CheckBoxSuppressValidationWarning.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxSuppressValidationWarning.Name = "CheckBoxSuppressValidationWarning"
        Me.CheckBoxSuppressValidationWarning.Size = New System.Drawing.Size(197, 20)
        Me.CheckBoxSuppressValidationWarning.TabIndex = 18
        Me.CheckBoxSuppressValidationWarning.Text = "Suppress validation warning"
        Me.ToolTipSettings.SetToolTip(Me.CheckBoxSuppressValidationWarning, "Suppress the validation warnings ")
        Me.CheckBoxSuppressValidationWarning.UseVisualStyleBackColor = True
        '
        'CheckBoxEntityChecker
        '
        Me.CheckBoxEntityChecker.AutoSize = True
        Me.CheckBoxEntityChecker.Location = New System.Drawing.Point(20, 226)
        Me.CheckBoxEntityChecker.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxEntityChecker.Name = "CheckBoxEntityChecker"
        Me.CheckBoxEntityChecker.Size = New System.Drawing.Size(154, 20)
        Me.CheckBoxEntityChecker.TabIndex = 7
        Me.CheckBoxEntityChecker.Text = "Delete entity checker"
        Me.ToolTipSettings.SetToolTip(Me.CheckBoxEntityChecker, "Display the extra dialog when you delete an element")
        Me.CheckBoxEntityChecker.UseVisualStyleBackColor = True
        '
        'CheckBoxShowAidOnDiagramOpen
        '
        Me.CheckBoxShowAidOnDiagramOpen.AutoSize = True
        Me.CheckBoxShowAidOnDiagramOpen.Location = New System.Drawing.Point(20, 199)
        Me.CheckBoxShowAidOnDiagramOpen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxShowAidOnDiagramOpen.Name = "CheckBoxShowAidOnDiagramOpen"
        Me.CheckBoxShowAidOnDiagramOpen.Size = New System.Drawing.Size(196, 20)
        Me.CheckBoxShowAidOnDiagramOpen.TabIndex = 6
        Me.CheckBoxShowAidOnDiagramOpen.Text = "Show Aid On Diagram Open"
        Me.ToolTipSettings.SetToolTip(Me.CheckBoxShowAidOnDiagramOpen, "Open the archimaid helper when you open an ArchiMate diagram")
        Me.CheckBoxShowAidOnDiagramOpen.UseVisualStyleBackColor = True
        '
        'CheckBoxXSDHelper
        '
        Me.CheckBoxXSDHelper.AutoSize = True
        Me.CheckBoxXSDHelper.Location = New System.Drawing.Point(20, 172)
        Me.CheckBoxXSDHelper.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxXSDHelper.Name = "CheckBoxXSDHelper"
        Me.CheckBoxXSDHelper.Size = New System.Drawing.Size(97, 20)
        Me.CheckBoxXSDHelper.TabIndex = 5
        Me.CheckBoxXSDHelper.Text = "XSD helper"
        Me.CheckBoxXSDHelper.UseVisualStyleBackColor = True
        '
        'CheckBoxArchiMateHelper
        '
        Me.CheckBoxArchiMateHelper.AutoSize = True
        Me.CheckBoxArchiMateHelper.Location = New System.Drawing.Point(20, 144)
        Me.CheckBoxArchiMateHelper.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxArchiMateHelper.Name = "CheckBoxArchiMateHelper"
        Me.CheckBoxArchiMateHelper.Size = New System.Drawing.Size(130, 20)
        Me.CheckBoxArchiMateHelper.TabIndex = 4
        Me.CheckBoxArchiMateHelper.Text = "ArchiMate helper"
        Me.CheckBoxArchiMateHelper.UseVisualStyleBackColor = True
        '
        'CheckBoxPackageHelper
        '
        Me.CheckBoxPackageHelper.AutoSize = True
        Me.CheckBoxPackageHelper.Location = New System.Drawing.Point(20, 34)
        Me.CheckBoxPackageHelper.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxPackageHelper.Name = "CheckBoxPackageHelper"
        Me.CheckBoxPackageHelper.Size = New System.Drawing.Size(125, 20)
        Me.CheckBoxPackageHelper.TabIndex = 0
        Me.CheckBoxPackageHelper.Text = "Package helper"
        Me.CheckBoxPackageHelper.UseVisualStyleBackColor = True
        '
        'CheckBoxTableHelper
        '
        Me.CheckBoxTableHelper.AutoSize = True
        Me.CheckBoxTableHelper.Location = New System.Drawing.Point(20, 116)
        Me.CheckBoxTableHelper.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxTableHelper.Name = "CheckBoxTableHelper"
        Me.CheckBoxTableHelper.Size = New System.Drawing.Size(106, 20)
        Me.CheckBoxTableHelper.TabIndex = 3
        Me.CheckBoxTableHelper.Text = "Table helper"
        Me.CheckBoxTableHelper.UseVisualStyleBackColor = True
        '
        'CheckBoxDiagramHelper
        '
        Me.CheckBoxDiagramHelper.AutoSize = True
        Me.CheckBoxDiagramHelper.Location = New System.Drawing.Point(20, 59)
        Me.CheckBoxDiagramHelper.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxDiagramHelper.Name = "CheckBoxDiagramHelper"
        Me.CheckBoxDiagramHelper.Size = New System.Drawing.Size(122, 20)
        Me.CheckBoxDiagramHelper.TabIndex = 1
        Me.CheckBoxDiagramHelper.Text = "Diagram helper"
        Me.CheckBoxDiagramHelper.UseVisualStyleBackColor = True
        '
        'CheckBoxClassHelper
        '
        Me.CheckBoxClassHelper.AutoSize = True
        Me.CheckBoxClassHelper.Location = New System.Drawing.Point(20, 87)
        Me.CheckBoxClassHelper.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxClassHelper.Name = "CheckBoxClassHelper"
        Me.CheckBoxClassHelper.Size = New System.Drawing.Size(104, 20)
        Me.CheckBoxClassHelper.TabIndex = 2
        Me.CheckBoxClassHelper.Text = "Class helper"
        Me.CheckBoxClassHelper.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxAnalyserWindow)
        Me.GroupBox1.Controls.Add(Me.CheckBoxSolutionWizard)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDocumentImport)
        Me.GroupBox1.Controls.Add(Me.CheckBoxAssistant)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDeduplicator)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDatAid)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFormFactory)
        Me.GroupBox1.Controls.Add(Me.CheckBoxArchimAid)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(265, 329)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'CheckBoxAnalyserWindow
        '
        Me.CheckBoxAnalyserWindow.AutoSize = True
        Me.CheckBoxAnalyserWindow.Location = New System.Drawing.Point(21, 246)
        Me.CheckBoxAnalyserWindow.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxAnalyserWindow.Name = "CheckBoxAnalyserWindow"
        Me.CheckBoxAnalyserWindow.Size = New System.Drawing.Size(133, 20)
        Me.CheckBoxAnalyserWindow.TabIndex = 7
        Me.CheckBoxAnalyserWindow.Text = "Analyser Window"
        Me.ToolTipSettings.SetToolTip(Me.CheckBoxAnalyserWindow, "Activate the data analyses and data visualization in context menu")
        Me.CheckBoxAnalyserWindow.UseVisualStyleBackColor = True
        '
        'CheckBoxSolutionWizard
        '
        Me.CheckBoxSolutionWizard.AutoSize = True
        Me.CheckBoxSolutionWizard.Location = New System.Drawing.Point(21, 218)
        Me.CheckBoxSolutionWizard.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxSolutionWizard.Name = "CheckBoxSolutionWizard"
        Me.CheckBoxSolutionWizard.Size = New System.Drawing.Size(122, 20)
        Me.CheckBoxSolutionWizard.TabIndex = 6
        Me.CheckBoxSolutionWizard.Text = "Solution Wizard"
        Me.ToolTipSettings.SetToolTip(Me.CheckBoxSolutionWizard, "Activate  the Solution wizard in contextmenu")
        Me.CheckBoxSolutionWizard.UseVisualStyleBackColor = True
        '
        'CheckBoxDocumentImport
        '
        Me.CheckBoxDocumentImport.AutoSize = True
        Me.CheckBoxDocumentImport.Location = New System.Drawing.Point(21, 190)
        Me.CheckBoxDocumentImport.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxDocumentImport.Name = "CheckBoxDocumentImport"
        Me.CheckBoxDocumentImport.Size = New System.Drawing.Size(142, 20)
        Me.CheckBoxDocumentImport.TabIndex = 5
        Me.CheckBoxDocumentImport.Text = "Document Importer"
        Me.ToolTipSettings.SetToolTip(Me.CheckBoxDocumentImport, "Activate  the Document importer in contextmenu")
        Me.CheckBoxDocumentImport.UseVisualStyleBackColor = True
        '
        'CheckBoxAssistant
        '
        Me.CheckBoxAssistant.AutoSize = True
        Me.CheckBoxAssistant.Location = New System.Drawing.Point(20, 158)
        Me.CheckBoxAssistant.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxAssistant.Name = "CheckBoxAssistant"
        Me.CheckBoxAssistant.Size = New System.Drawing.Size(83, 20)
        Me.CheckBoxAssistant.TabIndex = 4
        Me.CheckBoxAssistant.Text = "Assistant"
        Me.CheckBoxAssistant.UseVisualStyleBackColor = True
        '
        'CheckBoxDeduplicator
        '
        Me.CheckBoxDeduplicator.AutoSize = True
        Me.CheckBoxDeduplicator.Location = New System.Drawing.Point(20, 34)
        Me.CheckBoxDeduplicator.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxDeduplicator.Name = "CheckBoxDeduplicator"
        Me.CheckBoxDeduplicator.Size = New System.Drawing.Size(106, 20)
        Me.CheckBoxDeduplicator.TabIndex = 0
        Me.CheckBoxDeduplicator.Text = "Deduplicator"
        Me.ToolTipSettings.SetToolTip(Me.CheckBoxDeduplicator, "Activate deduplicator in contextmenu")
        Me.CheckBoxDeduplicator.UseVisualStyleBackColor = True
        '
        'CheckBoxDatAid
        '
        Me.CheckBoxDatAid.AutoSize = True
        Me.CheckBoxDatAid.Location = New System.Drawing.Point(20, 127)
        Me.CheckBoxDatAid.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxDatAid.Name = "CheckBoxDatAid"
        Me.CheckBoxDatAid.Size = New System.Drawing.Size(72, 20)
        Me.CheckBoxDatAid.TabIndex = 3
        Me.CheckBoxDatAid.Text = "DatAID"
        Me.ToolTipSettings.SetToolTip(Me.CheckBoxDatAid, "Activate  the Dataid window for datamodeling search in contextmenu")
        Me.CheckBoxDatAid.UseVisualStyleBackColor = True
        '
        'CheckBoxFormFactory
        '
        Me.CheckBoxFormFactory.AutoSize = True
        Me.CheckBoxFormFactory.Location = New System.Drawing.Point(20, 65)
        Me.CheckBoxFormFactory.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxFormFactory.Name = "CheckBoxFormFactory"
        Me.CheckBoxFormFactory.Size = New System.Drawing.Size(108, 20)
        Me.CheckBoxFormFactory.TabIndex = 1
        Me.CheckBoxFormFactory.Text = "Form Factory"
        Me.ToolTipSettings.SetToolTip(Me.CheckBoxFormFactory, "Activate formfactory for LDM simulation in contextmenu")
        Me.CheckBoxFormFactory.UseVisualStyleBackColor = True
        '
        'CheckBoxArchimAid
        '
        Me.CheckBoxArchimAid.AutoSize = True
        Me.CheckBoxArchimAid.Location = New System.Drawing.Point(20, 96)
        Me.CheckBoxArchimAid.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxArchimAid.Name = "CheckBoxArchimAid"
        Me.CheckBoxArchimAid.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxArchimAid.TabIndex = 2
        Me.CheckBoxArchimAid.Text = "ArchimAID"
        Me.ToolTipSettings.SetToolTip(Me.CheckBoxArchimAid, "Activate  the ArchiMaid window for archimate search in contextmenu")
        Me.CheckBoxArchimAid.UseVisualStyleBackColor = True
        '
        'TabPageSystem
        '
        Me.TabPageSystem.Controls.Add(Me.DataGridViewSettings)
        Me.TabPageSystem.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSystem.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageSystem.Name = "TabPageSystem"
        Me.TabPageSystem.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageSystem.Size = New System.Drawing.Size(819, 440)
        Me.TabPageSystem.TabIndex = 0
        Me.TabPageSystem.Text = "System"
        Me.TabPageSystem.UseVisualStyleBackColor = True
        '
        'TabPageStatements
        '
        Me.TabPageStatements.Controls.Add(Me.DataGridViewStatement)
        Me.TabPageStatements.Location = New System.Drawing.Point(4, 25)
        Me.TabPageStatements.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageStatements.Name = "TabPageStatements"
        Me.TabPageStatements.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageStatements.Size = New System.Drawing.Size(819, 440)
        Me.TabPageStatements.TabIndex = 2
        Me.TabPageStatements.Text = "Statements"
        Me.TabPageStatements.UseVisualStyleBackColor = True
        '
        'DataGridViewStatement
        '
        Me.DataGridViewStatement.AllowUserToOrderColumns = True
        Me.DataGridViewStatement.ColumnHeadersHeight = 29
        Me.DataGridViewStatement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewStatement.Location = New System.Drawing.Point(4, 4)
        Me.DataGridViewStatement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewStatement.Name = "DataGridViewStatement"
        Me.DataGridViewStatement.RowHeadersWidth = 51
        Me.DataGridViewStatement.RowTemplate.Height = 24
        Me.DataGridViewStatement.Size = New System.Drawing.Size(811, 432)
        Me.DataGridViewStatement.TabIndex = 1
        '
        'TabPageTranslations
        '
        Me.TabPageTranslations.Controls.Add(Me.DataGridViewTranslations)
        Me.TabPageTranslations.Location = New System.Drawing.Point(4, 25)
        Me.TabPageTranslations.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageTranslations.Name = "TabPageTranslations"
        Me.TabPageTranslations.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageTranslations.Size = New System.Drawing.Size(819, 440)
        Me.TabPageTranslations.TabIndex = 3
        Me.TabPageTranslations.Text = "Translations"
        Me.TabPageTranslations.UseVisualStyleBackColor = True
        '
        'DataGridViewTranslations
        '
        Me.DataGridViewTranslations.AllowUserToOrderColumns = True
        Me.DataGridViewTranslations.ColumnHeadersHeight = 29
        Me.DataGridViewTranslations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewTranslations.Location = New System.Drawing.Point(4, 4)
        Me.DataGridViewTranslations.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewTranslations.Name = "DataGridViewTranslations"
        Me.DataGridViewTranslations.RowHeadersWidth = 51
        Me.DataGridViewTranslations.RowTemplate.Height = 24
        Me.DataGridViewTranslations.Size = New System.Drawing.Size(811, 432)
        Me.DataGridViewTranslations.TabIndex = 2
        '
        'TabPageArchiMaid
        '
        Me.TabPageArchiMaid.Controls.Add(Me.DataGridViewArchiMaid)
        Me.TabPageArchiMaid.Location = New System.Drawing.Point(4, 25)
        Me.TabPageArchiMaid.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageArchiMaid.Name = "TabPageArchiMaid"
        Me.TabPageArchiMaid.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageArchiMaid.Size = New System.Drawing.Size(819, 440)
        Me.TabPageArchiMaid.TabIndex = 4
        Me.TabPageArchiMaid.Text = "ArchiMaid"
        Me.TabPageArchiMaid.UseVisualStyleBackColor = True
        '
        'DataGridViewArchiMaid
        '
        Me.DataGridViewArchiMaid.AllowUserToOrderColumns = True
        Me.DataGridViewArchiMaid.ColumnHeadersHeight = 29
        Me.DataGridViewArchiMaid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewArchiMaid.Location = New System.Drawing.Point(4, 4)
        Me.DataGridViewArchiMaid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewArchiMaid.Name = "DataGridViewArchiMaid"
        Me.DataGridViewArchiMaid.RowHeadersWidth = 51
        Me.DataGridViewArchiMaid.RowTemplate.Height = 24
        Me.DataGridViewArchiMaid.Size = New System.Drawing.Size(811, 432)
        Me.DataGridViewArchiMaid.TabIndex = 3
        '
        'TabPageDataAnalyser
        '
        Me.TabPageDataAnalyser.Controls.Add(Me.DataGridViewDataAnalyser)
        Me.TabPageDataAnalyser.Location = New System.Drawing.Point(4, 25)
        Me.TabPageDataAnalyser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageDataAnalyser.Name = "TabPageDataAnalyser"
        Me.TabPageDataAnalyser.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageDataAnalyser.Size = New System.Drawing.Size(819, 440)
        Me.TabPageDataAnalyser.TabIndex = 5
        Me.TabPageDataAnalyser.Text = "Data Aanalyser"
        Me.TabPageDataAnalyser.UseVisualStyleBackColor = True
        '
        'DataGridViewDataAnalyser
        '
        Me.DataGridViewDataAnalyser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDataAnalyser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewDataAnalyser.Location = New System.Drawing.Point(3, 2)
        Me.DataGridViewDataAnalyser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewDataAnalyser.Name = "DataGridViewDataAnalyser"
        Me.DataGridViewDataAnalyser.RowHeadersWidth = 51
        Me.DataGridViewDataAnalyser.RowTemplate.Height = 24
        Me.DataGridViewDataAnalyser.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DataGridViewDataAnalyser.Size = New System.Drawing.Size(813, 436)
        Me.DataGridViewDataAnalyser.TabIndex = 0
        '
        'ToolTipSettings
        '
        Me.ToolTipSettings.IsBalloon = True
        '
        'ComboBoxSettingMode
        '
        Me.ComboBoxSettingMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxSettingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSettingMode.FormattingEnabled = True
        Me.ComboBoxSettingMode.Items.AddRange(New Object() {"User", "File", "Repo"})
        Me.ComboBoxSettingMode.Location = New System.Drawing.Point(628, 104)
        Me.ComboBoxSettingMode.Name = "ComboBoxSettingMode"
        Me.ComboBoxSettingMode.Size = New System.Drawing.Size(177, 24)
        Me.ComboBoxSettingMode.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(625, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Setting mode"
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 469)
        Me.Controls.Add(Me.TabControlSettings)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmSettings"
        Me.Text = "IDEA Settings"
        CType(Me.DataGridViewSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlSettings.ResumeLayout(False)
        Me.TabPageUser.ResumeLayout(False)
        Me.TabPageUser.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPageSystem.ResumeLayout(False)
        Me.TabPageStatements.ResumeLayout(False)
        CType(Me.DataGridViewStatement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageTranslations.ResumeLayout(False)
        CType(Me.DataGridViewTranslations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageArchiMaid.ResumeLayout(False)
        CType(Me.DataGridViewArchiMaid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageDataAnalyser.ResumeLayout(False)
        CType(Me.DataGridViewDataAnalyser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewSettings As System.Windows.Forms.DataGridView
    Friend WithEvents TabControlSettings As System.Windows.Forms.TabControl
    Friend WithEvents TabPageSystem As System.Windows.Forms.TabPage
    Friend WithEvents TabPageUser As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxAssistant As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDeduplicator As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDatAid As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFormFactory As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxArchimAid As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxArchiMateHelper As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxPackageHelper As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTableHelper As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDiagramHelper As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxClassHelper As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxXSDHelper As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxShowAidOnDiagramOpen As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPageStatements As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewStatement As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBoxDocumentImport As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSolutionWizard As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxEntityChecker As System.Windows.Forms.CheckBox
    Friend WithEvents TabPageTranslations As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewTranslations As System.Windows.Forms.DataGridView
    Friend WithEvents TabPageArchiMaid As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewArchiMaid As System.Windows.Forms.DataGridView
    Friend WithEvents TabPageDataAnalyser As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewDataAnalyser As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBoxAnalyserWindow As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonReset As Windows.Forms.Button
    Friend WithEvents TextBoxSettingFile As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents CheckBoxExtendedWarning As Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSuppressValidationWarning As Windows.Forms.CheckBox
    Friend WithEvents ToolTipSettings As Windows.Forms.ToolTip
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents ComboBoxSettingMode As Windows.Forms.ComboBox
End Class

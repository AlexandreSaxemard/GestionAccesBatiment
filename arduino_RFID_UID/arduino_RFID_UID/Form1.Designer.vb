<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBoxSelect = New System.Windows.Forms.PictureBox()
        Me.ButtonRegistration = New System.Windows.Forms.Button()
        Me.ButtonUserData = New System.Windows.Forms.Button()
        Me.ButtonConnection = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.LabelConnectionStatus = New System.Windows.Forms.Label()
        Me.Label1DateTime = New System.Windows.Forms.Label()
        Me.PanelConnection = New System.Windows.Forms.Panel()
        Me.buttonConnect = New System.Windows.Forms.Button()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.buttonScanPort = New System.Windows.Forms.Button()
        Me.PanelUserData = New System.Windows.Forms.Panel()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.LabelVill = New System.Windows.Forms.Label()
        Me.LabelCity = New System.Windows.Forms.Label()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.Labeladress = New System.Windows.Forms.Label()
        Me.LabelDepartment = New System.Windows.Forms.Label()
        Me.buttonClear = New System.Windows.Forms.Button()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelDep = New System.Windows.Forms.Label()
        Me.Labelnom = New System.Windows.Forms.Label()
        Me.GroupBoxImage = New System.Windows.Forms.GroupBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.PictureBoxUserImage = New System.Windows.Forms.PictureBox()
        Me.PanelRegistrationandEditUserData = New System.Windows.Forms.Panel()
        Me.PanelReadingTagProcess = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.buttonCloseReadingTag = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxImagePreview = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CheckBoxByID = New System.Windows.Forms.CheckBox()
        Me.CheckBoxByName = New System.Windows.Forms.CheckBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxImageInput = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelGetID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.buttonScanID = New System.Windows.Forms.Button()
        Me.buttonClearForm = New System.Windows.Forms.Button()
        Me.buttonSave = New System.Windows.Forms.Button()
        Me.TextBoxDep = New System.Windows.Forms.TextBox()
        Me.TextBoxVille = New System.Windows.Forms.TextBox()
        Me.TextBoxadresse = New System.Windows.Forms.TextBox()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectionnerToutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EffacerSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RafraîchirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerSerialIn = New System.Windows.Forms.Timer(Me.components)
        Me.TimerTimeDate = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelConnection.SuspendLayout()
        Me.PanelUserData.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.GroupBoxImage.SuspendLayout()
        CType(Me.PictureBoxUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegistrationandEditUserData.SuspendLayout()
        Me.PanelReadingTagProcess.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBoxSelect)
        Me.Panel1.Controls.Add(Me.ButtonRegistration)
        Me.Panel1.Controls.Add(Me.ButtonUserData)
        Me.Panel1.Controls.Add(Me.ButtonConnection)
        Me.Panel1.Controls.Add(Me.PictureBoxLogo)
        Me.Panel1.Location = New System.Drawing.Point(12, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 449)
        Me.Panel1.TabIndex = 0
        '
        'PictureBoxSelect
        '
        Me.PictureBoxSelect.Image = Global.arduino_RFID_UID.My.Resources.Resources.iconfinder_arrow138_216456
        Me.PictureBoxSelect.Location = New System.Drawing.Point(3, 133)
        Me.PictureBoxSelect.Name = "PictureBoxSelect"
        Me.PictureBoxSelect.Size = New System.Drawing.Size(26, 31)
        Me.PictureBoxSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSelect.TabIndex = 1
        Me.PictureBoxSelect.TabStop = False
        '
        'ButtonRegistration
        '
        Me.ButtonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegistration.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonRegistration.Image = Global.arduino_RFID_UID.My.Resources.Resources.iconfinder_document_text_edit_103514
        Me.ButtonRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRegistration.Location = New System.Drawing.Point(31, 253)
        Me.ButtonRegistration.Name = "ButtonRegistration"
        Me.ButtonRegistration.Size = New System.Drawing.Size(280, 41)
        Me.ButtonRegistration.TabIndex = 3
        Me.ButtonRegistration.Text = "Enregistrer / Editer un utilisateur"
        Me.ButtonRegistration.UseVisualStyleBackColor = True
        '
        'ButtonUserData
        '
        Me.ButtonUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUserData.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonUserData.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonUserData.Location = New System.Drawing.Point(31, 192)
        Me.ButtonUserData.Name = "ButtonUserData"
        Me.ButtonUserData.Size = New System.Drawing.Size(280, 41)
        Me.ButtonUserData.TabIndex = 2
        Me.ButtonUserData.Text = "Données Utilisateurs"
        Me.ButtonUserData.UseVisualStyleBackColor = True
        '
        'ButtonConnection
        '
        Me.ButtonConnection.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonConnection.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonConnection.Image = Global.arduino_RFID_UID.My.Resources.Resources.iconfinder_Computer__Computer_Hardware_USB_Port_Connection_4064143_1_
        Me.ButtonConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonConnection.Location = New System.Drawing.Point(31, 120)
        Me.ButtonConnection.Name = "ButtonConnection"
        Me.ButtonConnection.Size = New System.Drawing.Size(280, 53)
        Me.ButtonConnection.TabIndex = 1
        Me.ButtonConnection.Text = "Connexion"
        Me.ButtonConnection.UseVisualStyleBackColor = True
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Image = Global.arduino_RFID_UID.My.Resources.Resources.user
        Me.PictureBoxLogo.Location = New System.Drawing.Point(76, 3)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(164, 111)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 1
        Me.PictureBoxLogo.TabStop = False
        '
        'LabelConnectionStatus
        '
        Me.LabelConnectionStatus.AutoSize = True
        Me.LabelConnectionStatus.Location = New System.Drawing.Point(348, 4)
        Me.LabelConnectionStatus.Name = "LabelConnectionStatus"
        Me.LabelConnectionStatus.Size = New System.Drawing.Size(161, 13)
        Me.LabelConnectionStatus.TabIndex = 2
        Me.LabelConnectionStatus.Text = "Etat de connexion : Déconnecté"
        '
        'Label1DateTime
        '
        Me.Label1DateTime.AutoSize = True
        Me.Label1DateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1DateTime.Location = New System.Drawing.Point(728, 3)
        Me.Label1DateTime.Name = "Label1DateTime"
        Me.Label1DateTime.Size = New System.Drawing.Size(209, 16)
        Me.Label1DateTime.TabIndex = 3
        Me.Label1DateTime.Text = "Time 00:00:00 Date 00 mmm; 0000"
        '
        'PanelConnection
        '
        Me.PanelConnection.Controls.Add(Me.buttonConnect)
        Me.PanelConnection.Controls.Add(Me.ComboBoxBaudRate)
        Me.PanelConnection.Controls.Add(Me.Label)
        Me.PanelConnection.Controls.Add(Me.ComboBoxPort)
        Me.PanelConnection.Controls.Add(Me.buttonScanPort)
        Me.PanelConnection.Location = New System.Drawing.Point(347, 22)
        Me.PanelConnection.Name = "PanelConnection"
        Me.PanelConnection.Size = New System.Drawing.Size(798, 427)
        Me.PanelConnection.TabIndex = 4
        '
        'buttonConnect
        '
        Me.buttonConnect.BackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.buttonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.buttonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.buttonConnect.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonConnect.Location = New System.Drawing.Point(14, 65)
        Me.buttonConnect.Name = "buttonConnect"
        Me.buttonConnect.Size = New System.Drawing.Size(555, 30)
        Me.buttonConnect.TabIndex = 7
        Me.buttonConnect.Text = "Connecté"
        Me.buttonConnect.UseVisualStyleBackColor = False
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600 ", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(439, 23)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(90, 21)
        Me.ComboBoxBaudRate.TabIndex = 6
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(377, 23)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(47, 13)
        Me.Label.TabIndex = 5
        Me.Label.Text = "Vitesse :"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(95, 20)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(265, 21)
        Me.ComboBoxPort.TabIndex = 2
        '
        'buttonScanPort
        '
        Me.buttonScanPort.BackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonScanPort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.buttonScanPort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.buttonScanPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.buttonScanPort.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonScanPort.Location = New System.Drawing.Point(14, 18)
        Me.buttonScanPort.Name = "buttonScanPort"
        Me.buttonScanPort.Size = New System.Drawing.Size(75, 23)
        Me.buttonScanPort.TabIndex = 1
        Me.buttonScanPort.Text = "Scanner le port"
        Me.buttonScanPort.UseVisualStyleBackColor = False
        '
        'PanelUserData
        '
        Me.PanelUserData.Controls.Add(Me.GroupBox)
        Me.PanelUserData.Controls.Add(Me.GroupBoxImage)
        Me.PanelUserData.Location = New System.Drawing.Point(347, 20)
        Me.PanelUserData.Name = "PanelUserData"
        Me.PanelUserData.Size = New System.Drawing.Size(796, 554)
        Me.PanelUserData.TabIndex = 8
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.LabelVill)
        Me.GroupBox.Controls.Add(Me.LabelCity)
        Me.GroupBox.Controls.Add(Me.LabelAddress)
        Me.GroupBox.Controls.Add(Me.Labeladress)
        Me.GroupBox.Controls.Add(Me.LabelDepartment)
        Me.GroupBox.Controls.Add(Me.buttonClear)
        Me.GroupBox.Controls.Add(Me.LabelName)
        Me.GroupBox.Controls.Add(Me.LabelDep)
        Me.GroupBox.Controls.Add(Me.Labelnom)
        Me.GroupBox.Location = New System.Drawing.Point(35, 263)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(505, 268)
        Me.GroupBox.TabIndex = 10
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Detail Données"
        '
        'LabelVill
        '
        Me.LabelVill.AutoSize = True
        Me.LabelVill.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVill.Location = New System.Drawing.Point(6, 149)
        Me.LabelVill.Name = "LabelVill"
        Me.LabelVill.Size = New System.Drawing.Size(40, 15)
        Me.LabelVill.TabIndex = 16
        Me.LabelVill.Text = "Ville:"
        '
        'LabelCity
        '
        Me.LabelCity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCity.AutoSize = True
        Me.LabelCity.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCity.Location = New System.Drawing.Point(129, 149)
        Me.LabelCity.Name = "LabelCity"
        Me.LabelCity.Size = New System.Drawing.Size(81, 15)
        Me.LabelCity.TabIndex = 15
        Me.LabelCity.Text = "Patientez..."
        '
        'LabelAddress
        '
        Me.LabelAddress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.Location = New System.Drawing.Point(129, 87)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(81, 15)
        Me.LabelAddress.TabIndex = 14
        Me.LabelAddress.Text = "Patientez..."
        '
        'Labeladress
        '
        Me.Labeladress.AutoSize = True
        Me.Labeladress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeladress.Location = New System.Drawing.Point(6, 87)
        Me.Labeladress.Name = "Labeladress"
        Me.Labeladress.Size = New System.Drawing.Size(64, 15)
        Me.Labeladress.TabIndex = 13
        Me.Labeladress.Text = "Adresse:"
        '
        'LabelDepartment
        '
        Me.LabelDepartment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDepartment.AutoSize = True
        Me.LabelDepartment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDepartment.Location = New System.Drawing.Point(129, 208)
        Me.LabelDepartment.Name = "LabelDepartment"
        Me.LabelDepartment.Size = New System.Drawing.Size(81, 15)
        Me.LabelDepartment.TabIndex = 12
        Me.LabelDepartment.Text = "Patientez..."
        '
        'buttonClear
        '
        Me.buttonClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.buttonClear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClear.Location = New System.Drawing.Point(426, 231)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(68, 21)
        Me.buttonClear.TabIndex = 11
        Me.buttonClear.Text = "Clear"
        Me.buttonClear.UseVisualStyleBackColor = False
        '
        'LabelName
        '
        Me.LabelName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(129, 28)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(81, 15)
        Me.LabelName.TabIndex = 2
        Me.LabelName.Text = "Patientez..."
        '
        'LabelDep
        '
        Me.LabelDep.AutoSize = True
        Me.LabelDep.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDep.Location = New System.Drawing.Point(6, 208)
        Me.LabelDep.Name = "LabelDep"
        Me.LabelDep.Size = New System.Drawing.Size(97, 15)
        Me.LabelDep.TabIndex = 1
        Me.LabelDep.Text = "Département:"
        '
        'Labelnom
        '
        Me.Labelnom.AutoSize = True
        Me.Labelnom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelnom.Location = New System.Drawing.Point(6, 28)
        Me.Labelnom.Name = "Labelnom"
        Me.Labelnom.Size = New System.Drawing.Size(42, 15)
        Me.Labelnom.TabIndex = 0
        Me.Labelnom.Text = "NOM:"
        '
        'GroupBoxImage
        '
        Me.GroupBoxImage.Controls.Add(Me.LabelID)
        Me.GroupBoxImage.Controls.Add(Me.PictureBoxUserImage)
        Me.GroupBoxImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxImage.Location = New System.Drawing.Point(207, 3)
        Me.GroupBoxImage.Name = "GroupBoxImage"
        Me.GroupBoxImage.Size = New System.Drawing.Size(208, 239)
        Me.GroupBoxImage.TabIndex = 9
        Me.GroupBoxImage.TabStop = False
        Me.GroupBoxImage.Text = "Image and Id"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(25, 201)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(79, 16)
        Me.LabelID.TabIndex = 10
        Me.LabelID.Text = "ID : _______"
        '
        'PictureBoxUserImage
        '
        Me.PictureBoxUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxUserImage.Location = New System.Drawing.Point(18, 24)
        Me.PictureBoxUserImage.Name = "PictureBoxUserImage"
        Me.PictureBoxUserImage.Size = New System.Drawing.Size(174, 174)
        Me.PictureBoxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUserImage.TabIndex = 10
        Me.PictureBoxUserImage.TabStop = False
        '
        'PanelRegistrationandEditUserData
        '
        Me.PanelRegistrationandEditUserData.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.PanelReadingTagProcess)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.GroupBox3)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.GroupBox2)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.GroupBox1)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.buttonClearForm)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.buttonSave)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxDep)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxVille)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxadresse)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxNom)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label4)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label3)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label2)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label1)
        Me.PanelRegistrationandEditUserData.Location = New System.Drawing.Point(347, 20)
        Me.PanelRegistrationandEditUserData.Name = "PanelRegistrationandEditUserData"
        Me.PanelRegistrationandEditUserData.Size = New System.Drawing.Size(809, 701)
        Me.PanelRegistrationandEditUserData.TabIndex = 8
        '
        'PanelReadingTagProcess
        '
        Me.PanelReadingTagProcess.Controls.Add(Me.PictureBox2)
        Me.PanelReadingTagProcess.Controls.Add(Me.buttonCloseReadingTag)
        Me.PanelReadingTagProcess.Controls.Add(Me.Button1)
        Me.PanelReadingTagProcess.Location = New System.Drawing.Point(4, 14)
        Me.PanelReadingTagProcess.Name = "PanelReadingTagProcess"
        Me.PanelReadingTagProcess.Size = New System.Drawing.Size(264, 165)
        Me.PanelReadingTagProcess.TabIndex = 14
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.arduino_RFID_UID.My.Resources.Resources._762
        Me.PictureBox2.Location = New System.Drawing.Point(91, 72)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'buttonCloseReadingTag
        '
        Me.buttonCloseReadingTag.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.buttonCloseReadingTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.buttonCloseReadingTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonCloseReadingTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonCloseReadingTag.Image = Global.arduino_RFID_UID.My.Resources.Resources.iconfinder_cancel_326554
        Me.buttonCloseReadingTag.Location = New System.Drawing.Point(224, 5)
        Me.buttonCloseReadingTag.Name = "buttonCloseReadingTag"
        Me.buttonCloseReadingTag.Size = New System.Drawing.Size(25, 23)
        Me.buttonCloseReadingTag.TabIndex = 11
        Me.buttonCloseReadingTag.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(2, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 43)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Lecture de la carte...."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBoxImagePreview)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.CheckBoxByID)
        Me.GroupBox3.Controls.Add(Me.CheckBoxByName)
        Me.GroupBox3.Controls.Add(Me.TextBoxSearch)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 350)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(779, 331)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Enregistrements"
        '
        'PictureBoxImagePreview
        '
        Me.PictureBoxImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImagePreview.Location = New System.Drawing.Point(425, 91)
        Me.PictureBoxImagePreview.Name = "PictureBoxImagePreview"
        Me.PictureBoxImagePreview.Size = New System.Drawing.Size(110, 110)
        Me.PictureBoxImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImagePreview.TabIndex = 6
        Me.PictureBoxImagePreview.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(401, 227)
        Me.DataGridView1.TabIndex = 5
        '
        'CheckBoxByID
        '
        Me.CheckBoxByID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxByID.AutoSize = True
        Me.CheckBoxByID.Checked = True
        Me.CheckBoxByID.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxByID.Location = New System.Drawing.Point(373, 63)
        Me.CheckBoxByID.Name = "CheckBoxByID"
        Me.CheckBoxByID.Size = New System.Drawing.Size(114, 17)
        Me.CheckBoxByID.TabIndex = 4
        Me.CheckBoxByID.Text = "Rechercher par ID"
        Me.CheckBoxByID.UseVisualStyleBackColor = True
        '
        'CheckBoxByName
        '
        Me.CheckBoxByName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxByName.AutoSize = True
        Me.CheckBoxByName.Checked = True
        Me.CheckBoxByName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxByName.Location = New System.Drawing.Point(373, 29)
        Me.CheckBoxByName.Name = "CheckBoxByName"
        Me.CheckBoxByName.Size = New System.Drawing.Size(123, 17)
        Me.CheckBoxByName.TabIndex = 3
        Me.CheckBoxByName.Text = "Rechercher par nom"
        Me.CheckBoxByName.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSearch.Location = New System.Drawing.Point(119, 25)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(248, 20)
        Me.TextBoxSearch.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Rechercher ici"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PictureBoxImageInput)
        Me.GroupBox2.Location = New System.Drawing.Point(673, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 130)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Photo"
        '
        'PictureBoxImageInput
        '
        Me.PictureBoxImageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImageInput.Image = Global.arduino_RFID_UID.My.Resources.Resources.tele
        Me.PictureBoxImageInput.Location = New System.Drawing.Point(10, 22)
        Me.PictureBoxImageInput.Name = "PictureBoxImageInput"
        Me.PictureBoxImageInput.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxImageInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImageInput.TabIndex = 13
        Me.PictureBoxImageInput.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabelGetID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.buttonScanID)
        Me.GroupBox1.Location = New System.Drawing.Point(547, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 130)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Récuperer ID"
        '
        'LabelGetID
        '
        Me.LabelGetID.AutoSize = True
        Me.LabelGetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGetID.Location = New System.Drawing.Point(35, 98)
        Me.LabelGetID.Name = "LabelGetID"
        Me.LabelGetID.Size = New System.Drawing.Size(81, 16)
        Me.LabelGetID.TabIndex = 13
        Me.LabelGetID.Text = ".__________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ID"
        '
        'buttonScanID
        '
        Me.buttonScanID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonScanID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.buttonScanID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.buttonScanID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.buttonScanID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonScanID.Location = New System.Drawing.Point(6, 22)
        Me.buttonScanID.Name = "buttonScanID"
        Me.buttonScanID.Size = New System.Drawing.Size(108, 49)
        Me.buttonScanID.TabIndex = 12
        Me.buttonScanID.Text = "Scanner"
        Me.buttonScanID.UseVisualStyleBackColor = False
        '
        'buttonClearForm
        '
        Me.buttonClearForm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonClearForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.buttonClearForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.buttonClearForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.buttonClearForm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClearForm.Location = New System.Drawing.Point(106, 203)
        Me.buttonClearForm.Name = "buttonClearForm"
        Me.buttonClearForm.Size = New System.Drawing.Size(86, 30)
        Me.buttonClearForm.TabIndex = 10
        Me.buttonClearForm.Text = "Effacer"
        Me.buttonClearForm.UseVisualStyleBackColor = False
        '
        'buttonSave
        '
        Me.buttonSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.buttonSave.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSave.Location = New System.Drawing.Point(14, 203)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(86, 30)
        Me.buttonSave.TabIndex = 9
        Me.buttonSave.Text = "Enregistrer"
        Me.buttonSave.UseVisualStyleBackColor = False
        '
        'TextBoxDep
        '
        Me.TextBoxDep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxDep.Location = New System.Drawing.Point(110, 159)
        Me.TextBoxDep.Name = "TextBoxDep"
        Me.TextBoxDep.Size = New System.Drawing.Size(503, 20)
        Me.TextBoxDep.TabIndex = 8
        '
        'TextBoxVille
        '
        Me.TextBoxVille.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxVille.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxVille.Location = New System.Drawing.Point(110, 114)
        Me.TextBoxVille.Name = "TextBoxVille"
        Me.TextBoxVille.Size = New System.Drawing.Size(503, 20)
        Me.TextBoxVille.TabIndex = 7
        '
        'TextBoxadresse
        '
        Me.TextBoxadresse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxadresse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxadresse.Location = New System.Drawing.Point(110, 65)
        Me.TextBoxadresse.Name = "TextBoxadresse"
        Me.TextBoxadresse.Size = New System.Drawing.Size(503, 20)
        Me.TextBoxadresse.TabIndex = 6
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNom.Location = New System.Drawing.Point(110, 22)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(503, 20)
        Me.TextBoxNom.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Département:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ville:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Adresse:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOM:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupprimerToolStripMenuItem, Me.SelectionnerToutToolStripMenuItem, Me.EffacerSelectionToolStripMenuItem, Me.RafraîchirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(165, 92)
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Image = Global.arduino_RFID_UID.My.Resources.Resources.iconfinder_Bin_2202256
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'SelectionnerToutToolStripMenuItem
        '
        Me.SelectionnerToutToolStripMenuItem.Image = Global.arduino_RFID_UID.My.Resources.Resources.iconfinder_icon_27_one_finger_click_315854
        Me.SelectionnerToutToolStripMenuItem.Name = "SelectionnerToutToolStripMenuItem"
        Me.SelectionnerToutToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SelectionnerToutToolStripMenuItem.Text = "Selectionner tout"
        '
        'EffacerSelectionToolStripMenuItem
        '
        Me.EffacerSelectionToolStripMenuItem.Image = Global.arduino_RFID_UID.My.Resources.Resources.iconfinder_check_box_outline_blank_326558_1_
        Me.EffacerSelectionToolStripMenuItem.Name = "EffacerSelectionToolStripMenuItem"
        Me.EffacerSelectionToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EffacerSelectionToolStripMenuItem.Text = "Effacer selection"
        '
        'RafraîchirToolStripMenuItem
        '
        Me.RafraîchirToolStripMenuItem.Image = Global.arduino_RFID_UID.My.Resources.Resources._822
        Me.RafraîchirToolStripMenuItem.Name = "RafraîchirToolStripMenuItem"
        Me.RafraîchirToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RafraîchirToolStripMenuItem.Text = "Rafraîchir"
        '
        'TimerSerialIn
        '
        Me.TimerSerialIn.Interval = 1000
        '
        'TimerTimeDate
        '
        Me.TimerTimeDate.Enabled = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM25"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.arduino_RFID_UID.My.Resources.Resources.Connected
        Me.PictureBox1.Location = New System.Drawing.Point(515, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 13)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 733)
        Me.Controls.Add(Me.Label1DateTime)
        Me.Controls.Add(Me.LabelConnectionStatus)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelUserData)
        Me.Controls.Add(Me.PanelRegistrationandEditUserData)
        Me.Controls.Add(Me.PanelConnection)
        Me.Location = New System.Drawing.Point(12, 1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBoxSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelConnection.ResumeLayout(False)
        Me.PanelConnection.PerformLayout()
        Me.PanelUserData.ResumeLayout(False)
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.GroupBoxImage.ResumeLayout(False)
        Me.GroupBoxImage.PerformLayout()
        CType(Me.PictureBoxUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegistrationandEditUserData.ResumeLayout(False)
        Me.PanelRegistrationandEditUserData.PerformLayout()
        Me.PanelReadingTagProcess.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents ButtonConnection As Button
    Friend WithEvents ButtonRegistration As Button
    Friend WithEvents ButtonUserData As Button
    Friend WithEvents PictureBoxSelect As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelConnectionStatus As Label
    Friend WithEvents Label1DateTime As Label
    Friend WithEvents PanelConnection As Panel
    Friend WithEvents Label As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents buttonScanPort As Button
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents buttonConnect As Button
    Friend WithEvents PanelUserData As Panel
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents LabelVill As Label
    Friend WithEvents LabelCity As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents Labeladress As Label
    Friend WithEvents LabelDepartment As Label
    Friend WithEvents buttonClear As Button
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelDep As Label
    Friend WithEvents Labelnom As Label
    Friend WithEvents GroupBoxImage As GroupBox
    Friend WithEvents LabelID As Label
    Friend WithEvents PictureBoxUserImage As PictureBox
    Friend WithEvents PanelRegistrationandEditUserData As Panel
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDep As TextBox
    Friend WithEvents TextBoxVille As TextBox
    Friend WithEvents TextBoxadresse As TextBox
    Friend WithEvents buttonSave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBoxImageInput As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelGetID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents buttonScanID As Button
    Friend WithEvents buttonClearForm As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelReadingTagProcess As Panel
    Friend WithEvents buttonCloseReadingTag As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBoxImagePreview As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CheckBoxByID As CheckBox
    Friend WithEvents CheckBoxByName As CheckBox
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectionnerToutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EffacerSelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RafraîchirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerSerialIn As Timer
    Friend WithEvents TimerTimeDate As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class

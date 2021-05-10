<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ResidentsRecord
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.datResidents = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlInformations = New System.Windows.Forms.Panel()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDelivery = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtMunicipality = New System.Windows.Forms.TextBox()
        Me.txtBarangay = New System.Windows.Forms.TextBox()
        Me.txtHouseholdNo = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtHouseNo = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtHouseContactNo = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.chkPregnant = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblPersonalInfo = New System.Windows.Forms.Label()
        Me.cboSamahan = New System.Windows.Forms.ComboBox()
        Me.cboCivilStatus = New System.Windows.Forms.ComboBox()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.txtContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.txtDisability = New System.Windows.Forms.TextBox()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.txtCitizenship = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtBirthPlace = New System.Windows.Forms.TextBox()
        Me.chkPWD = New System.Windows.Forms.CheckBox()
        Me.chkIndigent = New System.Windows.Forms.CheckBox()
        Me.chkInHabitant = New System.Windows.Forms.CheckBox()
        Me.chkVoter = New System.Windows.Forms.CheckBox()
        Me.lblDiasability = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.datResidents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlInformations.SuspendLayout()
        Me.SuspendLayout()
        '
        'datResidents
        '
        Me.datResidents.AllowUserToAddRows = False
        Me.datResidents.AllowUserToDeleteRows = False
        Me.datResidents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.datResidents.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datResidents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.datResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datResidents.DefaultCellStyle = DataGridViewCellStyle6
        Me.datResidents.Location = New System.Drawing.Point(11, 11)
        Me.datResidents.MultiSelect = False
        Me.datResidents.Name = "datResidents"
        Me.datResidents.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datResidents.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.datResidents.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datResidents.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.datResidents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datResidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datResidents.Size = New System.Drawing.Size(345, 347)
        Me.datResidents.StandardTab = True
        Me.datResidents.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RESIDENT CODE :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Location = New System.Drawing.Point(114, 10)
        Me.txtCode.MaxLength = 10
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(118, 21)
        Me.txtCode.TabIndex = 1
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(113, 34)
        Me.txtName.MaxLength = 100
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(244, 21)
        Me.txtName.TabIndex = 3
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RESIDENT NAME :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(268, 57)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(89, 30)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Tag = "Primary"
        Me.btnSearch.Text = "&SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.btnClear)
        Me.pnlSearch.Controls.Add(Me.txtName)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.Label1)
        Me.pnlSearch.Controls.Add(Me.txtCode)
        Me.pnlSearch.Controls.Add(Me.Label2)
        Me.pnlSearch.Location = New System.Drawing.Point(5, 5)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(366, 95)
        Me.pnlSearch.TabIndex = 1
        Me.pnlSearch.Tag = "Secondary"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(175, 57)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 30)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Tag = "Primary"
        Me.btnClear.Text = "&CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.datResidents)
        Me.Panel1.Location = New System.Drawing.Point(5, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 411)
        Me.Panel1.TabIndex = 2
        Me.Panel1.Tag = "Secondary"
        '
        'pnlInformations
        '
        Me.pnlInformations.Controls.Add(Me.dtpBirthdate)
        Me.pnlInformations.Controls.Add(Me.dtpDelivery)
        Me.pnlInformations.Controls.Add(Me.btnUpdate)
        Me.pnlInformations.Controls.Add(Me.txtProvince)
        Me.pnlInformations.Controls.Add(Me.cboRole)
        Me.pnlInformations.Controls.Add(Me.txtStreet)
        Me.pnlInformations.Controls.Add(Me.txtMunicipality)
        Me.pnlInformations.Controls.Add(Me.txtBarangay)
        Me.pnlInformations.Controls.Add(Me.txtHouseholdNo)
        Me.pnlInformations.Controls.Add(Me.Label36)
        Me.pnlInformations.Controls.Add(Me.txtHouseNo)
        Me.pnlInformations.Controls.Add(Me.Label47)
        Me.pnlInformations.Controls.Add(Me.Label48)
        Me.pnlInformations.Controls.Add(Me.Label27)
        Me.pnlInformations.Controls.Add(Me.Label46)
        Me.pnlInformations.Controls.Add(Me.Label40)
        Me.pnlInformations.Controls.Add(Me.txtHouseContactNo)
        Me.pnlInformations.Controls.Add(Me.Label43)
        Me.pnlInformations.Controls.Add(Me.Label45)
        Me.pnlInformations.Controls.Add(Me.lblDelivery)
        Me.pnlInformations.Controls.Add(Me.chkPregnant)
        Me.pnlInformations.Controls.Add(Me.Label6)
        Me.pnlInformations.Controls.Add(Me.Label7)
        Me.pnlInformations.Controls.Add(Me.txtFullName)
        Me.pnlInformations.Controls.Add(Me.lblPersonalInfo)
        Me.pnlInformations.Controls.Add(Me.cboSamahan)
        Me.pnlInformations.Controls.Add(Me.cboCivilStatus)
        Me.pnlInformations.Controls.Add(Me.cboSex)
        Me.pnlInformations.Controls.Add(Me.txtContactNo)
        Me.pnlInformations.Controls.Add(Me.txtDisability)
        Me.pnlInformations.Controls.Add(Me.txtOccupation)
        Me.pnlInformations.Controls.Add(Me.txtCitizenship)
        Me.pnlInformations.Controls.Add(Me.txtAge)
        Me.pnlInformations.Controls.Add(Me.txtBirthPlace)
        Me.pnlInformations.Controls.Add(Me.chkPWD)
        Me.pnlInformations.Controls.Add(Me.chkIndigent)
        Me.pnlInformations.Controls.Add(Me.chkInHabitant)
        Me.pnlInformations.Controls.Add(Me.chkVoter)
        Me.pnlInformations.Controls.Add(Me.lblDiasability)
        Me.pnlInformations.Controls.Add(Me.Label13)
        Me.pnlInformations.Controls.Add(Me.Label12)
        Me.pnlInformations.Controls.Add(Me.Label17)
        Me.pnlInformations.Controls.Add(Me.Label15)
        Me.pnlInformations.Controls.Add(Me.Label14)
        Me.pnlInformations.Controls.Add(Me.Label9)
        Me.pnlInformations.Controls.Add(Me.Label8)
        Me.pnlInformations.Controls.Add(Me.Label3)
        Me.pnlInformations.Controls.Add(Me.Label11)
        Me.pnlInformations.Controls.Add(Me.txtID)
        Me.pnlInformations.Controls.Add(Me.lblID)
        Me.pnlInformations.Controls.Add(Me.Label4)
        Me.pnlInformations.Controls.Add(Me.Label5)
        Me.pnlInformations.Location = New System.Drawing.Point(377, 5)
        Me.pnlInformations.Name = "pnlInformations"
        Me.pnlInformations.Size = New System.Drawing.Size(587, 512)
        Me.pnlInformations.TabIndex = 3
        Me.pnlInformations.Tag = "Secondary"
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpBirthdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthdate.Location = New System.Drawing.Point(356, 94)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(85, 21)
        Me.dtpBirthdate.TabIndex = 9
        Me.dtpBirthdate.Tag = "IN:"
        '
        'dtpDelivery
        '
        Me.dtpDelivery.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpDelivery.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDelivery.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDelivery.Location = New System.Drawing.Point(472, 124)
        Me.dtpDelivery.Name = "dtpDelivery"
        Me.dtpDelivery.Size = New System.Drawing.Size(85, 21)
        Me.dtpDelivery.TabIndex = 16
        Me.dtpDelivery.Tag = "IN:"
        Me.dtpDelivery.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(462, 462)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(114, 45)
        Me.btnUpdate.TabIndex = 51
        Me.btnUpdate.Tag = "Primary"
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtProvince
        '
        Me.txtProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvince.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(341, 416)
        Me.txtProvince.MaxLength = 20
        Me.txtProvince.Multiline = True
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(216, 21)
        Me.txtProvince.TabIndex = 50
        Me.txtProvince.Tag = "IN;"
        Me.txtProvince.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboRole
        '
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboRole.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Items.AddRange(New Object() {"", "HEAD", "MEMBER"})
        Me.cboRole.Location = New System.Drawing.Point(341, 321)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(117, 24)
        Me.cboRole.TabIndex = 38
        Me.cboRole.Tag = "IN;"
        '
        'txtStreet
        '
        Me.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStreet.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreet.Location = New System.Drawing.Point(341, 354)
        Me.txtStreet.MaxLength = 100
        Me.txtStreet.Multiline = True
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(216, 21)
        Me.txtStreet.TabIndex = 42
        Me.txtStreet.Tag = "IN;"
        Me.txtStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMunicipality
        '
        Me.txtMunicipality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMunicipality.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunicipality.Location = New System.Drawing.Point(341, 385)
        Me.txtMunicipality.MaxLength = 20
        Me.txtMunicipality.Multiline = True
        Me.txtMunicipality.Name = "txtMunicipality"
        Me.txtMunicipality.Size = New System.Drawing.Size(216, 21)
        Me.txtMunicipality.TabIndex = 46
        Me.txtMunicipality.Tag = "IN;"
        Me.txtMunicipality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBarangay
        '
        Me.txtBarangay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarangay.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarangay.Location = New System.Drawing.Point(117, 385)
        Me.txtBarangay.MaxLength = 50
        Me.txtBarangay.Multiline = True
        Me.txtBarangay.Name = "txtBarangay"
        Me.txtBarangay.Size = New System.Drawing.Size(127, 21)
        Me.txtBarangay.TabIndex = 44
        Me.txtBarangay.Tag = "IN;"
        Me.txtBarangay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHouseholdNo
        '
        Me.txtHouseholdNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHouseholdNo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseholdNo.Location = New System.Drawing.Point(117, 323)
        Me.txtHouseholdNo.MaxLength = 10
        Me.txtHouseholdNo.Multiline = True
        Me.txtHouseholdNo.Name = "txtHouseholdNo"
        Me.txtHouseholdNo.ReadOnly = True
        Me.txtHouseholdNo.Size = New System.Drawing.Size(76, 21)
        Me.txtHouseholdNo.TabIndex = 36
        Me.txtHouseholdNo.Tag = "IN;"
        Me.txtHouseholdNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(15, 325)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(104, 16)
        Me.Label36.TabIndex = 35
        Me.Label36.Text = "HOUSEHOLD No. :"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHouseNo
        '
        Me.txtHouseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHouseNo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseNo.Location = New System.Drawing.Point(117, 354)
        Me.txtHouseNo.MaxLength = 10
        Me.txtHouseNo.Multiline = True
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.ReadOnly = True
        Me.txtHouseNo.Size = New System.Drawing.Size(99, 21)
        Me.txtHouseNo.TabIndex = 40
        Me.txtHouseNo.Tag = "IN;"
        Me.txtHouseNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(46, 387)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(73, 16)
        Me.Label47.TabIndex = 43
        Me.Label47.Text = "BARANGAY :"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(46, 356)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(73, 16)
        Me.Label48.TabIndex = 39
        Me.Label48.Text = "HOUSE No. :"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(272, 418)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 16)
        Me.Label27.TabIndex = 49
        Me.Label27.Text = "PROVINCE :"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(294, 356)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(49, 16)
        Me.Label46.TabIndex = 41
        Me.Label46.Text = "STREET :"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(301, 325)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(42, 16)
        Me.Label40.TabIndex = 37
        Me.Label40.Text = "ROLE :"
        '
        'txtHouseContactNo
        '
        Me.txtHouseContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHouseContactNo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseContactNo.Location = New System.Drawing.Point(117, 416)
        Me.txtHouseContactNo.MaxLength = 100
        Me.txtHouseContactNo.Multiline = True
        Me.txtHouseContactNo.Name = "txtHouseContactNo"
        Me.txtHouseContactNo.Size = New System.Drawing.Size(127, 21)
        Me.txtHouseContactNo.TabIndex = 48
        Me.txtHouseContactNo.Tag = "IN:"
        Me.txtHouseContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(31, 418)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(88, 16)
        Me.Label43.TabIndex = 47
        Me.Label43.Text = "CONTACT No. :"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(253, 387)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(90, 16)
        Me.Label45.TabIndex = 45
        Me.Label45.Text = "MUNICIPALITY :"
        '
        'lblDelivery
        '
        Me.lblDelivery.AutoSize = True
        Me.lblDelivery.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelivery.Location = New System.Drawing.Point(384, 126)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(92, 16)
        Me.lblDelivery.TabIndex = 15
        Me.lblDelivery.Text = "DELIVERY DATE :"
        Me.lblDelivery.Visible = False
        '
        'chkPregnant
        '
        Me.chkPregnant.AutoSize = True
        Me.chkPregnant.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.chkPregnant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPregnant.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPregnant.Location = New System.Drawing.Point(268, 124)
        Me.chkPregnant.Name = "chkPregnant"
        Me.chkPregnant.Size = New System.Drawing.Size(82, 20)
        Me.chkPregnant.TabIndex = 14
        Me.chkPregnant.Tag = "IN:"
        Me.chkPregnant.Text = "PREGNANT"
        Me.chkPregnant.UseVisualStyleBackColor = True
        Me.chkPregnant.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Tag = "Header-5"
        Me.Label6.Text = "HOUSEHOLD INFORMATION"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Location = New System.Drawing.Point(10, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(566, 165)
        Me.Label7.TabIndex = 34
        '
        'txtFullName
        '
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(313, 64)
        Me.txtFullName.MaxLength = 150
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.Size = New System.Drawing.Size(244, 21)
        Me.txtFullName.TabIndex = 5
        Me.txtFullName.Tag = ""
        Me.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPersonalInfo
        '
        Me.lblPersonalInfo.AutoSize = True
        Me.lblPersonalInfo.Location = New System.Drawing.Point(16, 22)
        Me.lblPersonalInfo.Name = "lblPersonalInfo"
        Me.lblPersonalInfo.Size = New System.Drawing.Size(144, 16)
        Me.lblPersonalInfo.TabIndex = 0
        Me.lblPersonalInfo.Tag = "Header-5"
        Me.lblPersonalInfo.Text = "PERSONAL INFORMATION"
        '
        'cboSamahan
        '
        Me.cboSamahan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSamahan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboSamahan.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSamahan.FormattingEnabled = True
        Me.cboSamahan.Items.AddRange(New Object() {"", "1", "2", "3"})
        Me.cboSamahan.Location = New System.Drawing.Point(104, 212)
        Me.cboSamahan.Name = "cboSamahan"
        Me.cboSamahan.Size = New System.Drawing.Size(145, 24)
        Me.cboSamahan.Sorted = True
        Me.cboSamahan.TabIndex = 26
        Me.cboSamahan.Tag = "IN:"
        '
        'cboCivilStatus
        '
        Me.cboCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCivilStatus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboCivilStatus.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCivilStatus.FormattingEnabled = True
        Me.cboCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Separated", "Widowed"})
        Me.cboCivilStatus.Location = New System.Drawing.Point(356, 152)
        Me.cboCivilStatus.Name = "cboCivilStatus"
        Me.cboCivilStatus.Size = New System.Drawing.Size(114, 24)
        Me.cboCivilStatus.TabIndex = 20
        Me.cboCivilStatus.Tag = "IN:"
        '
        'cboSex
        '
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboSex.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"FEMALE", "MALE"})
        Me.cboSex.Location = New System.Drawing.Point(104, 122)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(118, 24)
        Me.cboSex.TabIndex = 13
        Me.cboSex.Tag = "IN;"
        '
        'txtContactNo
        '
        Me.txtContactNo.BeepOnError = True
        Me.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(104, 244)
        Me.txtContactNo.Mask = "(+63)000-000-0000"
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(124, 21)
        Me.txtContactNo.TabIndex = 30
        Me.txtContactNo.Tag = "IN:"
        Me.txtContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDisability
        '
        Me.txtDisability.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDisability.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisability.Location = New System.Drawing.Point(341, 244)
        Me.txtDisability.MaxLength = 150
        Me.txtDisability.Name = "txtDisability"
        Me.txtDisability.Size = New System.Drawing.Size(216, 21)
        Me.txtDisability.TabIndex = 32
        Me.txtDisability.Tag = "IN:"
        Me.txtDisability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDisability.Visible = False
        '
        'txtOccupation
        '
        Me.txtOccupation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOccupation.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupation.Location = New System.Drawing.Point(104, 184)
        Me.txtOccupation.MaxLength = 150
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(144, 21)
        Me.txtOccupation.TabIndex = 22
        Me.txtOccupation.Tag = "IN:"
        Me.txtOccupation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCitizenship
        '
        Me.txtCitizenship.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCitizenship.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCitizenship.Location = New System.Drawing.Point(104, 154)
        Me.txtCitizenship.MaxLength = 150
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.Size = New System.Drawing.Size(144, 21)
        Me.txtCitizenship.TabIndex = 18
        Me.txtCitizenship.Tag = "IN:"
        Me.txtCitizenship.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(503, 94)
        Me.txtAge.MaxLength = 3
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(54, 21)
        Me.txtAge.TabIndex = 11
        Me.txtAge.Tag = "IN;"
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBirthPlace.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthPlace.Location = New System.Drawing.Point(104, 94)
        Me.txtBirthPlace.MaxLength = 150
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.Size = New System.Drawing.Size(144, 21)
        Me.txtBirthPlace.TabIndex = 7
        Me.txtBirthPlace.Tag = "IN:"
        Me.txtBirthPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkPWD
        '
        Me.chkPWD.AutoSize = True
        Me.chkPWD.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.chkPWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPWD.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPWD.Location = New System.Drawing.Point(313, 214)
        Me.chkPWD.Name = "chkPWD"
        Me.chkPWD.Size = New System.Drawing.Size(144, 20)
        Me.chkPWD.TabIndex = 27
        Me.chkPWD.Tag = "IN:"
        Me.chkPWD.Text = "PERSON w\ DISABILITY"
        Me.chkPWD.UseVisualStyleBackColor = True
        '
        'chkIndigent
        '
        Me.chkIndigent.AutoSize = True
        Me.chkIndigent.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.chkIndigent.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.chkIndigent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkIndigent.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIndigent.Location = New System.Drawing.Point(482, 214)
        Me.chkIndigent.Name = "chkIndigent"
        Me.chkIndigent.Size = New System.Drawing.Size(75, 20)
        Me.chkIndigent.TabIndex = 28
        Me.chkIndigent.Tag = "IN:"
        Me.chkIndigent.Text = "INDIGENT"
        Me.chkIndigent.UseVisualStyleBackColor = True
        '
        'chkInHabitant
        '
        Me.chkInHabitant.AutoSize = True
        Me.chkInHabitant.Checked = True
        Me.chkInHabitant.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInHabitant.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.chkInHabitant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkInHabitant.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInHabitant.Location = New System.Drawing.Point(469, 184)
        Me.chkInHabitant.Name = "chkInHabitant"
        Me.chkInHabitant.Size = New System.Drawing.Size(88, 20)
        Me.chkInHabitant.TabIndex = 24
        Me.chkInHabitant.Tag = "IN:"
        Me.chkInHabitant.Text = "IN-HABITANT"
        Me.chkInHabitant.UseVisualStyleBackColor = True
        '
        'chkVoter
        '
        Me.chkVoter.AutoSize = True
        Me.chkVoter.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.chkVoter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkVoter.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVoter.Location = New System.Drawing.Point(313, 184)
        Me.chkVoter.Name = "chkVoter"
        Me.chkVoter.Size = New System.Drawing.Size(59, 20)
        Me.chkVoter.TabIndex = 23
        Me.chkVoter.Tag = "IN:"
        Me.chkVoter.Text = "VOTER"
        Me.chkVoter.UseVisualStyleBackColor = True
        '
        'lblDiasability
        '
        Me.lblDiasability.AutoSize = True
        Me.lblDiasability.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiasability.Location = New System.Drawing.Point(268, 246)
        Me.lblDiasability.Name = "lblDiasability"
        Me.lblDiasability.Size = New System.Drawing.Size(75, 16)
        Me.lblDiasability.TabIndex = 31
        Me.lblDiasability.Text = "DISABILITIES :"
        Me.lblDiasability.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(72, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "SEX :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(464, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 16)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "AGE :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(38, 216)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 16)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "SAMAHAN :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 246)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "CONTACT No. :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(277, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 16)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "CIVIL STATUS :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "OCCUPATION :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "CITIZENSHIP :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "BIRTH PLACE :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(268, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "DATE OF BIRTH :"
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(104, 64)
        Me.txtID.MaxLength = 10
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(118, 21)
        Me.txtID.TabIndex = 3
        Me.txtID.Tag = "SG"
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(60, 66)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(46, 16)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "ID No. :"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(268, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "NAME :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(10, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(566, 248)
        Me.Label5.TabIndex = 1
        '
        'F_ResidentsRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 521)
        Me.Controls.Add(Me.pnlInformations)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlSearch)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_ResidentsRecord"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Text = "RESIDENT'S RECORDS"
        CType(Me.datResidents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnlInformations.ResumeLayout(False)
        Me.pnlInformations.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents datResidents As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlInformations As System.Windows.Forms.Panel
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkPWD As System.Windows.Forms.CheckBox
    Friend WithEvents chkIndigent As System.Windows.Forms.CheckBox
    Friend WithEvents chkInHabitant As System.Windows.Forms.CheckBox
    Friend WithEvents chkVoter As System.Windows.Forms.CheckBox
    Friend WithEvents lblDiasability As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDisability As System.Windows.Forms.TextBox
    Friend WithEvents txtOccupation As System.Windows.Forms.TextBox
    Friend WithEvents txtCitizenship As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents dtpBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtContactNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboSamahan As System.Windows.Forms.ComboBox
    Friend WithEvents cboCivilStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents lblPersonalInfo As System.Windows.Forms.Label
    Friend WithEvents txtBirthPlace As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpDelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDelivery As System.Windows.Forms.Label
    Friend WithEvents chkPregnant As System.Windows.Forms.CheckBox
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents cboRole As System.Windows.Forms.ComboBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtMunicipality As System.Windows.Forms.TextBox
    Friend WithEvents txtBarangay As System.Windows.Forms.TextBox
    Friend WithEvents txtHouseholdNo As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtHouseNo As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtHouseContactNo As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
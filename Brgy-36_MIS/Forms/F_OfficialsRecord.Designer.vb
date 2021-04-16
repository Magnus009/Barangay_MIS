<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_OfficialsRecord
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.datOfficials = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dtpTermTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTermFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlInformations = New System.Windows.Forms.Panel()
        Me.txtOfficialID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.cboCommittee = New System.Windows.Forms.ComboBox()
        Me.dtpTermEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpTermStart = New System.Windows.Forms.DateTimePicker()
        Me.cboRank = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblPersonalInfo = New System.Windows.Forms.Label()
        Me.txtResidentID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.datOfficials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlInformations.SuspendLayout()
        Me.SuspendLayout()
        '
        'datOfficials
        '
        Me.datOfficials.AllowUserToAddRows = False
        Me.datOfficials.AllowUserToDeleteRows = False
        Me.datOfficials.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.datOfficials.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datOfficials.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datOfficials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datOfficials.DefaultCellStyle = DataGridViewCellStyle2
        Me.datOfficials.Location = New System.Drawing.Point(7, 62)
        Me.datOfficials.MultiSelect = False
        Me.datOfficials.Name = "datOfficials"
        Me.datOfficials.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datOfficials.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datOfficials.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datOfficials.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.datOfficials.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datOfficials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datOfficials.Size = New System.Drawing.Size(439, 392)
        Me.datOfficials.StandardTab = True
        Me.datOfficials.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.dtpTermTo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtpTermFrom)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.datOfficials)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 461)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Tag = "Secondary"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(354, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(92, 48)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dtpTermTo
        '
        Me.dtpTermTo.Checked = False
        Me.dtpTermTo.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpTermTo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTermTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTermTo.Location = New System.Drawing.Point(199, 8)
        Me.dtpTermTo.Name = "dtpTermTo"
        Me.dtpTermTo.ShowCheckBox = True
        Me.dtpTermTo.Size = New System.Drawing.Size(105, 21)
        Me.dtpTermTo.TabIndex = 3
        Me.dtpTermTo.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(176, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = " - "
        '
        'dtpTermFrom
        '
        Me.dtpTermFrom.Checked = False
        Me.dtpTermFrom.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpTermFrom.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTermFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTermFrom.Location = New System.Drawing.Point(66, 8)
        Me.dtpTermFrom.Name = "dtpTermFrom"
        Me.dtpTermFrom.ShowCheckBox = True
        Me.dtpTermFrom.Size = New System.Drawing.Size(105, 21)
        Me.dtpTermFrom.TabIndex = 1
        Me.dtpTermFrom.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TERM :"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(66, 35)
        Me.txtSearch.MaxLength = 20
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(282, 21)
        Me.txtSearch.TabIndex = 5
        Me.txtSearch.Tag = ""
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SEARCH :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlInformations
        '
        Me.pnlInformations.Controls.Add(Me.btnAdd)
        Me.pnlInformations.Controls.Add(Me.txtOfficialID)
        Me.pnlInformations.Controls.Add(Me.Label8)
        Me.pnlInformations.Controls.Add(Me.cboPosition)
        Me.pnlInformations.Controls.Add(Me.Label12)
        Me.pnlInformations.Controls.Add(Me.txtContactNo)
        Me.pnlInformations.Controls.Add(Me.cboCommittee)
        Me.pnlInformations.Controls.Add(Me.dtpTermEnd)
        Me.pnlInformations.Controls.Add(Me.Label15)
        Me.pnlInformations.Controls.Add(Me.Label17)
        Me.pnlInformations.Controls.Add(Me.Label16)
        Me.pnlInformations.Controls.Add(Me.dtpTermStart)
        Me.pnlInformations.Controls.Add(Me.cboRank)
        Me.pnlInformations.Controls.Add(Me.cboStatus)
        Me.pnlInformations.Controls.Add(Me.Label9)
        Me.pnlInformations.Controls.Add(Me.Label14)
        Me.pnlInformations.Controls.Add(Me.Label11)
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
        Me.pnlInformations.Controls.Add(Me.Label6)
        Me.pnlInformations.Controls.Add(Me.Label7)
        Me.pnlInformations.Controls.Add(Me.txtFullName)
        Me.pnlInformations.Controls.Add(Me.lblPersonalInfo)
        Me.pnlInformations.Controls.Add(Me.txtResidentID)
        Me.pnlInformations.Controls.Add(Me.lblID)
        Me.pnlInformations.Controls.Add(Me.Label4)
        Me.pnlInformations.Controls.Add(Me.Label5)
        Me.pnlInformations.Location = New System.Drawing.Point(466, 7)
        Me.pnlInformations.Name = "pnlInformations"
        Me.pnlInformations.Size = New System.Drawing.Size(512, 461)
        Me.pnlInformations.TabIndex = 1
        Me.pnlInformations.Tag = "Secondary"
        '
        'txtOfficialID
        '
        Me.txtOfficialID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOfficialID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficialID.Location = New System.Drawing.Point(348, 64)
        Me.txtOfficialID.MaxLength = 10
        Me.txtOfficialID.Multiline = True
        Me.txtOfficialID.Name = "txtOfficialID"
        Me.txtOfficialID.ReadOnly = True
        Me.txtOfficialID.Size = New System.Drawing.Size(118, 21)
        Me.txtOfficialID.TabIndex = 5
        Me.txtOfficialID.Tag = "SG"
        Me.txtOfficialID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(270, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "OFFICIAL ID :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboPosition
        '
        Me.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosition.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboPosition.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Location = New System.Drawing.Point(348, 90)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(117, 24)
        Me.cboPosition.TabIndex = 9
        Me.cboPosition.Tag = "IN:Position*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(279, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "POSITION :"
        '
        'txtContactNo
        '
        Me.txtContactNo.BeepOnError = True
        Me.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(348, 181)
        Me.txtContactNo.Mask = "(+63)000-000-0000"
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(124, 21)
        Me.txtContactNo.TabIndex = 21
        Me.txtContactNo.Tag = "IN:"
        Me.txtContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboCommittee
        '
        Me.cboCommittee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCommittee.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboCommittee.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCommittee.FormattingEnabled = True
        Me.cboCommittee.Location = New System.Drawing.Point(348, 120)
        Me.cboCommittee.Name = "cboCommittee"
        Me.cboCommittee.Size = New System.Drawing.Size(145, 24)
        Me.cboCommittee.Sorted = True
        Me.cboCommittee.TabIndex = 13
        Me.cboCommittee.Tag = "IN:Committee"
        '
        'dtpTermEnd
        '
        Me.dtpTermEnd.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpTermEnd.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTermEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTermEnd.Location = New System.Drawing.Point(348, 151)
        Me.dtpTermEnd.Name = "dtpTermEnd"
        Me.dtpTermEnd.Size = New System.Drawing.Size(88, 21)
        Me.dtpTermEnd.TabIndex = 17
        Me.dtpTermEnd.Tag = "IN:Term End*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(257, 183)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "CONTACT No. :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(265, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 16)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "COMMITTEE :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(277, 153)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 16)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "TERM END :"
        '
        'dtpTermStart
        '
        Me.dtpTermStart.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpTermStart.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTermStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTermStart.Location = New System.Drawing.Point(91, 151)
        Me.dtpTermStart.Name = "dtpTermStart"
        Me.dtpTermStart.Size = New System.Drawing.Size(88, 21)
        Me.dtpTermStart.TabIndex = 15
        Me.dtpTermStart.Tag = "IN:Term Start*"
        '
        'cboRank
        '
        Me.cboRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRank.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboRank.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRank.FormattingEnabled = True
        Me.cboRank.Location = New System.Drawing.Point(91, 120)
        Me.cboRank.Name = "cboRank"
        Me.cboRank.Size = New System.Drawing.Size(145, 24)
        Me.cboRank.TabIndex = 11
        Me.cboRank.Tag = "IN:Rank*"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboStatus.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(91, 179)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(145, 24)
        Me.cboStatus.TabIndex = 19
        Me.cboStatus.Tag = "IN:Status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(45, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "RANK :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(37, 183)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 16)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "STATUS :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "TERM START :"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(389, 409)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(114, 45)
        Me.btnUpdate.TabIndex = 40
        Me.btnUpdate.Tag = "Primary"
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtProvince
        '
        Me.txtProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvince.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(335, 363)
        Me.txtProvince.MaxLength = 20
        Me.txtProvince.Multiline = True
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(158, 21)
        Me.txtProvince.TabIndex = 39
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
        Me.cboRole.Location = New System.Drawing.Point(340, 268)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(117, 24)
        Me.cboRole.TabIndex = 27
        Me.cboRole.Tag = "IN;"
        '
        'txtStreet
        '
        Me.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStreet.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreet.Location = New System.Drawing.Point(335, 301)
        Me.txtStreet.MaxLength = 100
        Me.txtStreet.Multiline = True
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(158, 21)
        Me.txtStreet.TabIndex = 31
        Me.txtStreet.Tag = "IN;"
        Me.txtStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMunicipality
        '
        Me.txtMunicipality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMunicipality.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunicipality.Location = New System.Drawing.Point(335, 332)
        Me.txtMunicipality.MaxLength = 20
        Me.txtMunicipality.Multiline = True
        Me.txtMunicipality.Name = "txtMunicipality"
        Me.txtMunicipality.Size = New System.Drawing.Size(158, 21)
        Me.txtMunicipality.TabIndex = 35
        Me.txtMunicipality.Tag = "IN;"
        Me.txtMunicipality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBarangay
        '
        Me.txtBarangay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarangay.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarangay.Location = New System.Drawing.Point(116, 332)
        Me.txtBarangay.MaxLength = 50
        Me.txtBarangay.Multiline = True
        Me.txtBarangay.Name = "txtBarangay"
        Me.txtBarangay.Size = New System.Drawing.Size(120, 21)
        Me.txtBarangay.TabIndex = 33
        Me.txtBarangay.Tag = "IN;"
        Me.txtBarangay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHouseholdNo
        '
        Me.txtHouseholdNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHouseholdNo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseholdNo.Location = New System.Drawing.Point(116, 270)
        Me.txtHouseholdNo.MaxLength = 10
        Me.txtHouseholdNo.Multiline = True
        Me.txtHouseholdNo.Name = "txtHouseholdNo"
        Me.txtHouseholdNo.ReadOnly = True
        Me.txtHouseholdNo.Size = New System.Drawing.Size(76, 21)
        Me.txtHouseholdNo.TabIndex = 25
        Me.txtHouseholdNo.Tag = "IN;"
        Me.txtHouseholdNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(14, 272)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(104, 16)
        Me.Label36.TabIndex = 24
        Me.Label36.Text = "HOUSEHOLD No. :"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHouseNo
        '
        Me.txtHouseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHouseNo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseNo.Location = New System.Drawing.Point(116, 301)
        Me.txtHouseNo.MaxLength = 10
        Me.txtHouseNo.Multiline = True
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.ReadOnly = True
        Me.txtHouseNo.Size = New System.Drawing.Size(99, 21)
        Me.txtHouseNo.TabIndex = 29
        Me.txtHouseNo.Tag = "IN;"
        Me.txtHouseNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(45, 334)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(73, 16)
        Me.Label47.TabIndex = 32
        Me.Label47.Text = "BARANGAY :"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(45, 303)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(73, 16)
        Me.Label48.TabIndex = 28
        Me.Label48.Text = "HOUSE No. :"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(262, 365)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 16)
        Me.Label27.TabIndex = 38
        Me.Label27.Text = "PROVINCE :"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(284, 303)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(49, 16)
        Me.Label46.TabIndex = 30
        Me.Label46.Text = "STREET :"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(300, 272)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(42, 16)
        Me.Label40.TabIndex = 26
        Me.Label40.Text = "ROLE :"
        '
        'txtHouseContactNo
        '
        Me.txtHouseContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHouseContactNo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseContactNo.Location = New System.Drawing.Point(116, 363)
        Me.txtHouseContactNo.MaxLength = 100
        Me.txtHouseContactNo.Multiline = True
        Me.txtHouseContactNo.Name = "txtHouseContactNo"
        Me.txtHouseContactNo.Size = New System.Drawing.Size(120, 21)
        Me.txtHouseContactNo.TabIndex = 37
        Me.txtHouseContactNo.Tag = "IN:"
        Me.txtHouseContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(30, 365)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(88, 16)
        Me.Label43.TabIndex = 36
        Me.Label43.Text = "CONTACT No. :"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(243, 334)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(90, 16)
        Me.Label45.TabIndex = 34
        Me.Label45.Text = "MUNICIPALITY :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Tag = "Header-5"
        Me.Label6.Text = "HOUSEHOLD INFORMATION"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Location = New System.Drawing.Point(9, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(494, 165)
        Me.Label7.TabIndex = 23
        '
        'txtFullName
        '
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(91, 92)
        Me.txtFullName.MaxLength = 150
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.Size = New System.Drawing.Size(173, 21)
        Me.txtFullName.TabIndex = 7
        Me.txtFullName.Tag = ""
        Me.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPersonalInfo
        '
        Me.lblPersonalInfo.AutoSize = True
        Me.lblPersonalInfo.Location = New System.Drawing.Point(15, 22)
        Me.lblPersonalInfo.Name = "lblPersonalInfo"
        Me.lblPersonalInfo.Size = New System.Drawing.Size(141, 16)
        Me.lblPersonalInfo.TabIndex = 0
        Me.lblPersonalInfo.Tag = "Header-5"
        Me.lblPersonalInfo.Text = "OFFICER'S INFORMATION"
        '
        'txtResidentID
        '
        Me.txtResidentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResidentID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResidentID.Location = New System.Drawing.Point(91, 64)
        Me.txtResidentID.MaxLength = 10
        Me.txtResidentID.Multiline = True
        Me.txtResidentID.Name = "txtResidentID"
        Me.txtResidentID.ReadOnly = True
        Me.txtResidentID.Size = New System.Drawing.Size(118, 21)
        Me.txtResidentID.TabIndex = 3
        Me.txtResidentID.Tag = "SG"
        Me.txtResidentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(15, 66)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(77, 16)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "RESIDENT ID :"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "NAME :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(9, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(494, 188)
        Me.Label5.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(269, 409)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(114, 45)
        Me.btnAdd.TabIndex = 41
        Me.btnAdd.Tag = "Primary"
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'F_OfficialsRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 476)
        Me.Controls.Add(Me.pnlInformations)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_OfficialsRecord"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Text = "OFFICIAL'S RECORDS"
        CType(Me.datOfficials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlInformations.ResumeLayout(False)
        Me.pnlInformations.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents datOfficials As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlInformations As System.Windows.Forms.Panel
    Friend WithEvents txtResidentID As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblPersonalInfo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
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
    Friend WithEvents dtpTermStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboRank As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboCommittee As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTermEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpTermTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTermFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtOfficialID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class

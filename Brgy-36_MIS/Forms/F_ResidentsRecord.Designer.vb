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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.datResidents = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkPWD = New System.Windows.Forms.CheckBox()
        Me.chkIndigent = New System.Windows.Forms.CheckBox()
        Me.chkInHabitant = New System.Windows.Forms.CheckBox()
        Me.chkVoter = New System.Windows.Forms.CheckBox()
        Me.lblDiasability = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.dtpCaseStudy = New System.Windows.Forms.DateTimePicker()
        Me.txtContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.cboSamahan = New System.Windows.Forms.ComboBox()
        Me.cboCivilStatus = New System.Windows.Forms.ComboBox()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.lblPersonalInfo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.datResidents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'datResidents
        '
        Me.datResidents.AllowUserToAddRows = False
        Me.datResidents.AllowUserToDeleteRows = False
        Me.datResidents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.datResidents.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datResidents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.datResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datResidents.DefaultCellStyle = DataGridViewCellStyle10
        Me.datResidents.Location = New System.Drawing.Point(11, 11)
        Me.datResidents.MultiSelect = False
        Me.datResidents.Name = "datResidents"
        Me.datResidents.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datResidents.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.datResidents.RowHeadersVisible = False
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datResidents.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.datResidents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datResidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datResidents.Size = New System.Drawing.Size(345, 327)
        Me.datResidents.StandardTab = True
        Me.datResidents.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 1
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
        Me.txtName.TabIndex = 2
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "RESIDENT NAME :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(243, 57)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(114, 30)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Tag = "Primary"
        Me.btnSearch.Text = "&SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.txtName)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.Label1)
        Me.pnlSearch.Controls.Add(Me.txtCode)
        Me.pnlSearch.Controls.Add(Me.Label2)
        Me.pnlSearch.Location = New System.Drawing.Point(13, 12)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(366, 95)
        Me.pnlSearch.TabIndex = 6
        Me.pnlSearch.Tag = "Secondary"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.datResidents)
        Me.Panel1.Location = New System.Drawing.Point(13, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 366)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Tag = "Secondary"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtLName)
        Me.Panel2.Controls.Add(Me.lblPersonalInfo)
        Me.Panel2.Controls.Add(Me.cboSamahan)
        Me.Panel2.Controls.Add(Me.cboCivilStatus)
        Me.Panel2.Controls.Add(Me.cboSex)
        Me.Panel2.Controls.Add(Me.dtpCaseStudy)
        Me.Panel2.Controls.Add(Me.txtContactNo)
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.chkPWD)
        Me.Panel2.Controls.Add(Me.chkIndigent)
        Me.Panel2.Controls.Add(Me.chkInHabitant)
        Me.Panel2.Controls.Add(Me.chkVoter)
        Me.Panel2.Controls.Add(Me.lblDiasability)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtID)
        Me.Panel2.Controls.Add(Me.lblID)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(385, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(587, 467)
        Me.Panel2.TabIndex = 8
        Me.Panel2.Tag = "Secondary"
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
        Me.txtID.TabIndex = 4
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
        Me.lblID.TabIndex = 3
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
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NAME :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLName
        '
        Me.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLName.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(313, 64)
        Me.txtLName.MaxLength = 150
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(244, 21)
        Me.txtLName.TabIndex = 6
        Me.txtLName.Tag = "IN;Last Name*"
        Me.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(38, 186)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 16)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "SAMAHAN :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 218)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "CONTACT No. :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(268, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 16)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "CIVIL STATUS :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 16)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "OCCUPATION :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "CITIZENSHIP :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(268, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 16)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "DATE OF BIRTH :"
        '
        'chkPWD
        '
        Me.chkPWD.AutoSize = True
        Me.chkPWD.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.chkPWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPWD.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPWD.Location = New System.Drawing.Point(313, 184)
        Me.chkPWD.Name = "chkPWD"
        Me.chkPWD.Size = New System.Drawing.Size(144, 20)
        Me.chkPWD.TabIndex = 47
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
        Me.chkIndigent.Location = New System.Drawing.Point(482, 184)
        Me.chkIndigent.Name = "chkIndigent"
        Me.chkIndigent.Size = New System.Drawing.Size(75, 20)
        Me.chkIndigent.TabIndex = 46
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
        Me.chkInHabitant.Location = New System.Drawing.Point(469, 154)
        Me.chkInHabitant.Name = "chkInHabitant"
        Me.chkInHabitant.Size = New System.Drawing.Size(88, 20)
        Me.chkInHabitant.TabIndex = 45
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
        Me.chkVoter.Location = New System.Drawing.Point(313, 154)
        Me.chkVoter.Name = "chkVoter"
        Me.chkVoter.Size = New System.Drawing.Size(59, 20)
        Me.chkVoter.TabIndex = 44
        Me.chkVoter.Tag = "IN:"
        Me.chkVoter.Text = "VOTER"
        Me.chkVoter.UseVisualStyleBackColor = True
        '
        'lblDiasability
        '
        Me.lblDiasability.AutoSize = True
        Me.lblDiasability.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiasability.Location = New System.Drawing.Point(268, 218)
        Me.lblDiasability.Name = "lblDiasability"
        Me.lblDiasability.Size = New System.Drawing.Size(75, 16)
        Me.lblDiasability.TabIndex = 48
        Me.lblDiasability.Text = "DISABILITIES :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(449, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 16)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "SEX :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(464, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 16)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "AGE :"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(503, 94)
        Me.TextBox2.MaxLength = 150
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(54, 21)
        Me.TextBox2.TabIndex = 52
        Me.TextBox2.Tag = "IN;Last Name*"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(104, 124)
        Me.TextBox3.MaxLength = 150
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(144, 21)
        Me.TextBox3.TabIndex = 53
        Me.TextBox3.Tag = "IN;Last Name*"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(104, 154)
        Me.TextBox5.MaxLength = 150
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(144, 21)
        Me.TextBox5.TabIndex = 55
        Me.TextBox5.Tag = "IN;Last Name*"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(341, 216)
        Me.TextBox6.MaxLength = 150
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(216, 21)
        Me.TextBox6.TabIndex = 56
        Me.TextBox6.Tag = "IN;Last Name*"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpCaseStudy
        '
        Me.dtpCaseStudy.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpCaseStudy.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCaseStudy.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCaseStudy.Location = New System.Drawing.Point(356, 94)
        Me.dtpCaseStudy.Name = "dtpCaseStudy"
        Me.dtpCaseStudy.Size = New System.Drawing.Size(85, 21)
        Me.dtpCaseStudy.TabIndex = 58
        Me.dtpCaseStudy.Tag = "IN:"
        '
        'txtContactNo
        '
        Me.txtContactNo.BeepOnError = True
        Me.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(104, 216)
        Me.txtContactNo.Mask = "(+63)000-000-0000"
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(124, 21)
        Me.txtContactNo.TabIndex = 57
        Me.txtContactNo.Tag = "IN:"
        Me.txtContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboSamahan
        '
        Me.cboSamahan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSamahan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboSamahan.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSamahan.FormattingEnabled = True
        Me.cboSamahan.Items.AddRange(New Object() {"", "1", "2", "3"})
        Me.cboSamahan.Location = New System.Drawing.Point(104, 182)
        Me.cboSamahan.Name = "cboSamahan"
        Me.cboSamahan.Size = New System.Drawing.Size(145, 24)
        Me.cboSamahan.Sorted = True
        Me.cboSamahan.TabIndex = 61
        Me.cboSamahan.Tag = "IN:Samahan*"
        '
        'cboCivilStatus
        '
        Me.cboCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCivilStatus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboCivilStatus.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCivilStatus.FormattingEnabled = True
        Me.cboCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Separated", "Widowed"})
        Me.cboCivilStatus.Location = New System.Drawing.Point(348, 122)
        Me.cboCivilStatus.Name = "cboCivilStatus"
        Me.cboCivilStatus.Size = New System.Drawing.Size(84, 24)
        Me.cboCivilStatus.TabIndex = 60
        Me.cboCivilStatus.Tag = "IN:Civil Status*"
        '
        'cboSex
        '
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboSex.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"FEMALE", "MALE"})
        Me.cboSex.Location = New System.Drawing.Point(481, 122)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(76, 24)
        Me.cboSex.TabIndex = 59
        Me.cboSex.Tag = "IN;Sex*"
        '
        'lblPersonalInfo
        '
        Me.lblPersonalInfo.AutoSize = True
        Me.lblPersonalInfo.Location = New System.Drawing.Point(16, 22)
        Me.lblPersonalInfo.Name = "lblPersonalInfo"
        Me.lblPersonalInfo.Size = New System.Drawing.Size(144, 16)
        Me.lblPersonalInfo.TabIndex = 62
        Me.lblPersonalInfo.Tag = "Header-5"
        Me.lblPersonalInfo.Text = "PERSONAL INFORMATION"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(10, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(566, 219)
        Me.Label5.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "BIRTH PLACE :"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(104, 94)
        Me.TextBox1.MaxLength = 150
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 21)
        Me.TextBox1.TabIndex = 51
        Me.TextBox1.Tag = "IN;Last Name*"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 16)
        Me.Label6.TabIndex = 64
        Me.Label6.Tag = "Header-5"
        Me.Label6.Text = "HOUSEHOLD INFORMATION"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Location = New System.Drawing.Point(10, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(566, 188)
        Me.Label7.TabIndex = 65
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(74, 341)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "DELETED"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(11, 342)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 16)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "LEGEND :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'F_ResidentsRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 485)
        Me.Controls.Add(Me.Panel2)
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
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
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
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents dtpCaseStudy As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtContactNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboSamahan As System.Windows.Forms.ComboBox
    Friend WithEvents cboCivilStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents lblPersonalInfo As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class

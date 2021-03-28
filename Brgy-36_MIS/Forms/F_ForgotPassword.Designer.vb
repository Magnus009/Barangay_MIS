<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_forgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_forgotPassword))
        Me.txtQuestion_2 = New System.Windows.Forms.TextBox()
        Me.txtQuestion_1 = New System.Windows.Forms.TextBox()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.pnlVerification = New System.Windows.Forms.Panel()
        Me.lblAsterisk_2 = New System.Windows.Forms.Label()
        Me.lblAsterisk_1 = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblQ2 = New System.Windows.Forms.Label()
        Me.lblQ1 = New System.Windows.Forms.Label()
        Me.lblA2 = New System.Windows.Forms.Label()
        Me.txtAnswer_2 = New System.Windows.Forms.TextBox()
        Me.lblA1 = New System.Windows.Forms.Label()
        Me.txtAnswer_1 = New System.Windows.Forms.TextBox()
        Me.lblSecurityFrame = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblOP = New System.Windows.Forms.Label()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.lblCNPassword = New System.Windows.Forms.Label()
        Me.txtConfirmNewPass = New System.Windows.Forms.TextBox()
        Me.lblNP = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.picChangePass = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.chkShowHide_P = New System.Windows.Forms.CheckBox()
        Me.chkShowHide_NP = New System.Windows.Forms.CheckBox()
        Me.chkShowHide_CNP = New System.Windows.Forms.CheckBox()
        Me.pnlVerification.SuspendLayout()
        CType(Me.picChangePass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtQuestion_2
        '
        Me.txtQuestion_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuestion_2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion_2.Location = New System.Drawing.Point(110, 136)
        Me.txtQuestion_2.Name = "txtQuestion_2"
        Me.txtQuestion_2.ReadOnly = True
        Me.txtQuestion_2.Size = New System.Drawing.Size(262, 21)
        Me.txtQuestion_2.TabIndex = 6
        '
        'txtQuestion_1
        '
        Me.txtQuestion_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuestion_1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion_1.Location = New System.Drawing.Point(110, 77)
        Me.txtQuestion_1.Name = "txtQuestion_1"
        Me.txtQuestion_1.ReadOnly = True
        Me.txtQuestion_1.Size = New System.Drawing.Size(262, 21)
        Me.txtQuestion_1.TabIndex = 4
        '
        'btnVerify
        '
        Me.btnVerify.BackColor = System.Drawing.Color.Teal
        Me.btnVerify.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerify.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerify.ForeColor = System.Drawing.Color.White
        Me.btnVerify.Location = New System.Drawing.Point(293, 21)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(79, 24)
        Me.btnVerify.TabIndex = 2
        Me.btnVerify.Text = "VERIFY"
        Me.btnVerify.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Green
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(293, 191)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(98, 31)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "&SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(90, 23)
        Me.txtUserName.MaxLength = 20
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(197, 21)
        Me.txtUserName.TabIndex = 1
        '
        'pnlVerification
        '
        Me.pnlVerification.BackColor = System.Drawing.Color.White
        Me.pnlVerification.Controls.Add(Me.lblAsterisk_2)
        Me.pnlVerification.Controls.Add(Me.lblAsterisk_1)
        Me.pnlVerification.Controls.Add(Me.txtQuestion_2)
        Me.pnlVerification.Controls.Add(Me.txtQuestion_1)
        Me.pnlVerification.Controls.Add(Me.btnVerify)
        Me.pnlVerification.Controls.Add(Me.btnSubmit)
        Me.pnlVerification.Controls.Add(Me.lblUserName)
        Me.pnlVerification.Controls.Add(Me.txtUserName)
        Me.pnlVerification.Controls.Add(Me.Label1)
        Me.pnlVerification.Controls.Add(Me.lblQ2)
        Me.pnlVerification.Controls.Add(Me.lblQ1)
        Me.pnlVerification.Controls.Add(Me.lblA2)
        Me.pnlVerification.Controls.Add(Me.txtAnswer_2)
        Me.pnlVerification.Controls.Add(Me.lblA1)
        Me.pnlVerification.Controls.Add(Me.txtAnswer_1)
        Me.pnlVerification.Controls.Add(Me.lblSecurityFrame)
        Me.pnlVerification.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlVerification.Location = New System.Drawing.Point(0, 230)
        Me.pnlVerification.Name = "pnlVerification"
        Me.pnlVerification.Size = New System.Drawing.Size(409, 21)
        Me.pnlVerification.TabIndex = 3
        '
        'lblAsterisk_2
        '
        Me.lblAsterisk_2.AutoSize = True
        Me.lblAsterisk_2.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsterisk_2.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk_2.Location = New System.Drawing.Point(30, 165)
        Me.lblAsterisk_2.Name = "lblAsterisk_2"
        Me.lblAsterisk_2.Size = New System.Drawing.Size(11, 13)
        Me.lblAsterisk_2.TabIndex = 41
        Me.lblAsterisk_2.Tag = "reqSign"
        Me.lblAsterisk_2.Text = "*"
        Me.lblAsterisk_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblAsterisk_2.Visible = False
        '
        'lblAsterisk_1
        '
        Me.lblAsterisk_1.AutoSize = True
        Me.lblAsterisk_1.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsterisk_1.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk_1.Location = New System.Drawing.Point(30, 106)
        Me.lblAsterisk_1.Name = "lblAsterisk_1"
        Me.lblAsterisk_1.Size = New System.Drawing.Size(11, 13)
        Me.lblAsterisk_1.TabIndex = 40
        Me.lblAsterisk_1.Tag = "reqSign"
        Me.lblAsterisk_1.Text = "*"
        Me.lblAsterisk_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblAsterisk_1.Visible = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(20, 27)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(64, 13)
        Me.lblUserName.TabIndex = 31
        Me.lblUserName.Text = "USER NAME :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "SECURITY QUESTION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQ2
        '
        Me.lblQ2.AutoSize = True
        Me.lblQ2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ2.Location = New System.Drawing.Point(36, 140)
        Me.lblQ2.Name = "lblQ2"
        Me.lblQ2.Size = New System.Drawing.Size(68, 13)
        Me.lblQ2.TabIndex = 27
        Me.lblQ2.Text = "QUESTION 2 : "
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = True
        Me.lblQ1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ1.Location = New System.Drawing.Point(36, 81)
        Me.lblQ1.Name = "lblQ1"
        Me.lblQ1.Size = New System.Drawing.Size(68, 13)
        Me.lblQ1.TabIndex = 26
        Me.lblQ1.Text = "QUESTION 1 : "
        '
        'lblA2
        '
        Me.lblA2.AutoSize = True
        Me.lblA2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA2.Location = New System.Drawing.Point(43, 165)
        Me.lblA2.Name = "lblA2"
        Me.lblA2.Size = New System.Drawing.Size(61, 13)
        Me.lblA2.TabIndex = 25
        Me.lblA2.Text = "ANSWER 2 : "
        '
        'txtAnswer_2
        '
        Me.txtAnswer_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer_2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer_2.Location = New System.Drawing.Point(110, 161)
        Me.txtAnswer_2.Name = "txtAnswer_2"
        Me.txtAnswer_2.ReadOnly = True
        Me.txtAnswer_2.Size = New System.Drawing.Size(262, 21)
        Me.txtAnswer_2.TabIndex = 4
        Me.txtAnswer_2.Tag = "IN:Answer 2*"
        '
        'lblA1
        '
        Me.lblA1.AutoSize = True
        Me.lblA1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA1.Location = New System.Drawing.Point(43, 106)
        Me.lblA1.Name = "lblA1"
        Me.lblA1.Size = New System.Drawing.Size(61, 13)
        Me.lblA1.TabIndex = 24
        Me.lblA1.Text = "ANSWER 1 : "
        '
        'txtAnswer_1
        '
        Me.txtAnswer_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer_1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer_1.Location = New System.Drawing.Point(110, 102)
        Me.txtAnswer_1.Name = "txtAnswer_1"
        Me.txtAnswer_1.ReadOnly = True
        Me.txtAnswer_1.Size = New System.Drawing.Size(262, 21)
        Me.txtAnswer_1.TabIndex = 3
        Me.txtAnswer_1.Tag = "IN:Answer 1*"
        '
        'lblSecurityFrame
        '
        Me.lblSecurityFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSecurityFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSecurityFrame.Location = New System.Drawing.Point(20, 60)
        Me.lblSecurityFrame.Name = "lblSecurityFrame"
        Me.lblSecurityFrame.Size = New System.Drawing.Size(371, 128)
        Me.lblSecurityFrame.TabIndex = 29
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirm.BackColor = System.Drawing.Color.Green
        Me.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(302, 192)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(83, 31)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "&CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'lblOP
        '
        Me.lblOP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOP.AutoSize = True
        Me.lblOP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOP.ForeColor = System.Drawing.Color.White
        Me.lblOP.Location = New System.Drawing.Point(82, 115)
        Me.lblOP.Name = "lblOP"
        Me.lblOP.Size = New System.Drawing.Size(105, 16)
        Me.lblOP.TabIndex = 43
        Me.lblOP.Text = "OLD PASSWORD : "
        '
        'txtOldPass
        '
        Me.txtOldPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOldPass.BackColor = System.Drawing.Color.White
        Me.txtOldPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOldPass.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPass.Location = New System.Drawing.Point(188, 113)
        Me.txtOldPass.MaxLength = 20
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtOldPass.ReadOnly = True
        Me.txtOldPass.Size = New System.Drawing.Size(197, 21)
        Me.txtOldPass.TabIndex = 1
        Me.txtOldPass.Tag = "*Old Password"
        Me.txtOldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCNPassword
        '
        Me.lblCNPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCNPassword.AutoSize = True
        Me.lblCNPassword.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNPassword.ForeColor = System.Drawing.Color.White
        Me.lblCNPassword.Location = New System.Drawing.Point(24, 167)
        Me.lblCNPassword.Name = "lblCNPassword"
        Me.lblCNPassword.Size = New System.Drawing.Size(163, 16)
        Me.lblCNPassword.TabIndex = 39
        Me.lblCNPassword.Text = "CONFIRM NEW PASSWORD : "
        '
        'txtConfirmNewPass
        '
        Me.txtConfirmNewPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConfirmNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmNewPass.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmNewPass.Location = New System.Drawing.Point(188, 165)
        Me.txtConfirmNewPass.MaxLength = 20
        Me.txtConfirmNewPass.Name = "txtConfirmNewPass"
        Me.txtConfirmNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtConfirmNewPass.Size = New System.Drawing.Size(197, 21)
        Me.txtConfirmNewPass.TabIndex = 3
        Me.txtConfirmNewPass.Tag = "*Confirm New Password"
        Me.txtConfirmNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNP
        '
        Me.lblNP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNP.AutoSize = True
        Me.lblNP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNP.ForeColor = System.Drawing.Color.White
        Me.lblNP.Location = New System.Drawing.Point(80, 141)
        Me.lblNP.Name = "lblNP"
        Me.lblNP.Size = New System.Drawing.Size(107, 16)
        Me.lblNP.TabIndex = 38
        Me.lblNP.Text = "NEW PASSWORD : "
        '
        'txtNewPass
        '
        Me.txtNewPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPass.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.Location = New System.Drawing.Point(188, 139)
        Me.txtNewPass.MaxLength = 20
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNewPass.Size = New System.Drawing.Size(197, 21)
        Me.txtNewPass.TabIndex = 2
        Me.txtNewPass.Tag = "*New Password"
        Me.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picChangePass
        '
        Me.picChangePass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picChangePass.Image = CType(resources.GetObject("picChangePass.Image"), System.Drawing.Image)
        Me.picChangePass.Location = New System.Drawing.Point(161, 20)
        Me.picChangePass.Name = "picChangePass"
        Me.picChangePass.Size = New System.Drawing.Size(87, 83)
        Me.picChangePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChangePass.TabIndex = 35
        Me.picChangePass.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.SystemColors.Control
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(188, 192)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(83, 31)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "&BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Teal
        Me.pnlTop.Controls.Add(Me.chkShowHide_CNP)
        Me.pnlTop.Controls.Add(Me.chkShowHide_NP)
        Me.pnlTop.Controls.Add(Me.chkShowHide_P)
        Me.pnlTop.Controls.Add(Me.btnConfirm)
        Me.pnlTop.Controls.Add(Me.lblOP)
        Me.pnlTop.Controls.Add(Me.txtOldPass)
        Me.pnlTop.Controls.Add(Me.lblCNPassword)
        Me.pnlTop.Controls.Add(Me.txtConfirmNewPass)
        Me.pnlTop.Controls.Add(Me.lblNP)
        Me.pnlTop.Controls.Add(Me.txtNewPass)
        Me.pnlTop.Controls.Add(Me.picChangePass)
        Me.pnlTop.Controls.Add(Me.btnBack)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(409, 230)
        Me.pnlTop.TabIndex = 4
        '
        'chkShowHide_P
        '
        Me.chkShowHide_P.AutoSize = True
        Me.chkShowHide_P.BackColor = System.Drawing.Color.White
        Me.chkShowHide_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowHide_P.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowHide_P.Location = New System.Drawing.Point(336, 115)
        Me.chkShowHide_P.Name = "chkShowHide_P"
        Me.chkShowHide_P.Size = New System.Drawing.Size(48, 17)
        Me.chkShowHide_P.TabIndex = 44
        Me.chkShowHide_P.Text = "&Show"
        Me.chkShowHide_P.UseVisualStyleBackColor = False
        '
        'chkShowHide_NP
        '
        Me.chkShowHide_NP.AutoSize = True
        Me.chkShowHide_NP.BackColor = System.Drawing.Color.White
        Me.chkShowHide_NP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowHide_NP.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowHide_NP.Location = New System.Drawing.Point(336, 141)
        Me.chkShowHide_NP.Name = "chkShowHide_NP"
        Me.chkShowHide_NP.Size = New System.Drawing.Size(48, 17)
        Me.chkShowHide_NP.TabIndex = 45
        Me.chkShowHide_NP.Text = "&Show"
        Me.chkShowHide_NP.UseVisualStyleBackColor = False
        '
        'chkShowHide_CNP
        '
        Me.chkShowHide_CNP.AutoSize = True
        Me.chkShowHide_CNP.BackColor = System.Drawing.Color.White
        Me.chkShowHide_CNP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowHide_CNP.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowHide_CNP.Location = New System.Drawing.Point(336, 167)
        Me.chkShowHide_CNP.Name = "chkShowHide_CNP"
        Me.chkShowHide_CNP.Size = New System.Drawing.Size(48, 17)
        Me.chkShowHide_CNP.TabIndex = 46
        Me.chkShowHide_CNP.Text = "&Show"
        Me.chkShowHide_CNP.UseVisualStyleBackColor = False
        '
        'F_forgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 251)
        Me.Controls.Add(Me.pnlVerification)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_forgotPassword"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORGOT PASSWORD"
        Me.pnlVerification.ResumeLayout(False)
        Me.pnlVerification.PerformLayout()
        CType(Me.picChangePass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtQuestion_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestion_1 As System.Windows.Forms.TextBox
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents pnlVerification As System.Windows.Forms.Panel
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblQ2 As System.Windows.Forms.Label
    Friend WithEvents lblQ1 As System.Windows.Forms.Label
    Friend WithEvents lblA2 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer_2 As System.Windows.Forms.TextBox
    Friend WithEvents lblA1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer_1 As System.Windows.Forms.TextBox
    Friend WithEvents lblSecurityFrame As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents lblOP As System.Windows.Forms.Label
    Friend WithEvents txtOldPass As System.Windows.Forms.TextBox
    Friend WithEvents lblCNPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirmNewPass As System.Windows.Forms.TextBox
    Friend WithEvents lblNP As System.Windows.Forms.Label
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents picChangePass As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblAsterisk_2 As System.Windows.Forms.Label
    Friend WithEvents lblAsterisk_1 As System.Windows.Forms.Label
    Friend WithEvents chkShowHide_CNP As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowHide_NP As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowHide_P As System.Windows.Forms.CheckBox
End Class

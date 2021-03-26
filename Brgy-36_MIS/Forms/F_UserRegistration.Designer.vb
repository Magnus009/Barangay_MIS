<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_UserRegistration
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.grpUserInfo = New System.Windows.Forms.GroupBox()
        Me.cboUserLevel = New System.Windows.Forms.ComboBox()
        Me.lblUserLevel = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.grpSecurityQuestion = New System.Windows.Forms.GroupBox()
        Me.txtAns2 = New System.Windows.Forms.TextBox()
        Me.lblAns2 = New System.Windows.Forms.Label()
        Me.cboQuestion2 = New System.Windows.Forms.ComboBox()
        Me.lblQ2 = New System.Windows.Forms.Label()
        Me.txtAns1 = New System.Windows.Forms.TextBox()
        Me.lblAnswer1 = New System.Windows.Forms.Label()
        Me.cboQuestion1 = New System.Windows.Forms.ComboBox()
        Me.lblQ1 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.grpUserInfo.SuspendLayout()
        Me.grpSecurityQuestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(307, 459)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(111, 39)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Teal
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(190, 459)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 39)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Teal
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(435, 57)
        Me.pnlHeader.TabIndex = 4
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(15, 15)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(192, 26)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Account Registration"
        '
        'grpUserInfo
        '
        Me.grpUserInfo.Controls.Add(Me.cboUserLevel)
        Me.grpUserInfo.Controls.Add(Me.lblUserLevel)
        Me.grpUserInfo.Controls.Add(Me.txtConfirmPass)
        Me.grpUserInfo.Controls.Add(Me.lblConfirmPass)
        Me.grpUserInfo.Controls.Add(Me.txtPassword)
        Me.grpUserInfo.Controls.Add(Me.lblPassword)
        Me.grpUserInfo.Controls.Add(Me.txtUserName)
        Me.grpUserInfo.Controls.Add(Me.lblUserName)
        Me.grpUserInfo.Controls.Add(Me.txtID)
        Me.grpUserInfo.Controls.Add(Me.lblID)
        Me.grpUserInfo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUserInfo.Location = New System.Drawing.Point(12, 67)
        Me.grpUserInfo.Name = "grpUserInfo"
        Me.grpUserInfo.Size = New System.Drawing.Size(411, 198)
        Me.grpUserInfo.TabIndex = 5
        Me.grpUserInfo.TabStop = False
        Me.grpUserInfo.Text = "USER INFO"
        '
        'cboUserLevel
        '
        Me.cboUserLevel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUserLevel.FormattingEnabled = True
        Me.cboUserLevel.Location = New System.Drawing.Point(135, 147)
        Me.cboUserLevel.Name = "cboUserLevel"
        Me.cboUserLevel.Size = New System.Drawing.Size(121, 22)
        Me.cboUserLevel.TabIndex = 9
        Me.cboUserLevel.Tag = "IN;User Level*"
        '
        'lblUserLevel
        '
        Me.lblUserLevel.AutoSize = True
        Me.lblUserLevel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserLevel.Location = New System.Drawing.Point(58, 147)
        Me.lblUserLevel.Name = "lblUserLevel"
        Me.lblUserLevel.Size = New System.Drawing.Size(69, 14)
        Me.lblUserLevel.TabIndex = 8
        Me.lblUserLevel.Text = "USER LEVEL:"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(135, 117)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(257, 22)
        Me.txtConfirmPass.TabIndex = 7
        Me.txtConfirmPass.Tag = "IN;Confirm Password*"
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPass.Location = New System.Drawing.Point(7, 122)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(120, 14)
        Me.lblConfirmPass.TabIndex = 6
        Me.lblConfirmPass.Text = "CONFIRM PASSWORD:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(136, 88)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(257, 22)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.Tag = "IN;Password*"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(59, 93)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(68, 14)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "PASSWORD:"
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(135, 58)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(257, 22)
        Me.txtUserName.TabIndex = 3
        Me.txtUserName.Tag = "IN;User Name *"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(53, 63)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(74, 14)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "USER NAME :"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(135, 29)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(121, 22)
        Me.txtID.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(102, 34)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(25, 14)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID :"
        '
        'grpSecurityQuestion
        '
        Me.grpSecurityQuestion.Controls.Add(Me.txtAns2)
        Me.grpSecurityQuestion.Controls.Add(Me.lblAns2)
        Me.grpSecurityQuestion.Controls.Add(Me.cboQuestion2)
        Me.grpSecurityQuestion.Controls.Add(Me.lblQ2)
        Me.grpSecurityQuestion.Controls.Add(Me.txtAns1)
        Me.grpSecurityQuestion.Controls.Add(Me.lblAnswer1)
        Me.grpSecurityQuestion.Controls.Add(Me.cboQuestion1)
        Me.grpSecurityQuestion.Controls.Add(Me.lblQ1)
        Me.grpSecurityQuestion.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSecurityQuestion.Location = New System.Drawing.Point(12, 271)
        Me.grpSecurityQuestion.Name = "grpSecurityQuestion"
        Me.grpSecurityQuestion.Size = New System.Drawing.Size(411, 179)
        Me.grpSecurityQuestion.TabIndex = 6
        Me.grpSecurityQuestion.TabStop = False
        Me.grpSecurityQuestion.Text = "SECURITY QUESTION"
        '
        'txtAns2
        '
        Me.txtAns2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAns2.Location = New System.Drawing.Point(125, 122)
        Me.txtAns2.Name = "txtAns2"
        Me.txtAns2.Size = New System.Drawing.Size(257, 22)
        Me.txtAns2.TabIndex = 16
        Me.txtAns2.Tag = "IN;Answer 2*"
        '
        'lblAns2
        '
        Me.lblAns2.AutoSize = True
        Me.lblAns2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAns2.Location = New System.Drawing.Point(43, 126)
        Me.lblAns2.Name = "lblAns2"
        Me.lblAns2.Size = New System.Drawing.Size(64, 14)
        Me.lblAns2.TabIndex = 15
        Me.lblAns2.Text = "ANSWER 2:"
        '
        'cboQuestion2
        '
        Me.cboQuestion2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuestion2.FormattingEnabled = True
        Me.cboQuestion2.Location = New System.Drawing.Point(126, 94)
        Me.cboQuestion2.Name = "cboQuestion2"
        Me.cboQuestion2.Size = New System.Drawing.Size(256, 22)
        Me.cboQuestion2.TabIndex = 14
        Me.cboQuestion2.Tag = "IN;Question 2*"
        '
        'lblQ2
        '
        Me.lblQ2.AutoSize = True
        Me.lblQ2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ2.Location = New System.Drawing.Point(44, 97)
        Me.lblQ2.Name = "lblQ2"
        Me.lblQ2.Size = New System.Drawing.Size(73, 14)
        Me.lblQ2.TabIndex = 13
        Me.lblQ2.Text = "QUESTION 2:"
        '
        'txtAns1
        '
        Me.txtAns1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAns1.Location = New System.Drawing.Point(125, 65)
        Me.txtAns1.Name = "txtAns1"
        Me.txtAns1.Size = New System.Drawing.Size(257, 22)
        Me.txtAns1.TabIndex = 12
        Me.txtAns1.Tag = "IN;Answer 1*"
        '
        'lblAnswer1
        '
        Me.lblAnswer1.AutoSize = True
        Me.lblAnswer1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer1.Location = New System.Drawing.Point(43, 69)
        Me.lblAnswer1.Name = "lblAnswer1"
        Me.lblAnswer1.Size = New System.Drawing.Size(64, 14)
        Me.lblAnswer1.TabIndex = 11
        Me.lblAnswer1.Text = "ANSWER 1:"
        '
        'cboQuestion1
        '
        Me.cboQuestion1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuestion1.FormattingEnabled = True
        Me.cboQuestion1.Location = New System.Drawing.Point(126, 37)
        Me.cboQuestion1.Name = "cboQuestion1"
        Me.cboQuestion1.Size = New System.Drawing.Size(256, 22)
        Me.cboQuestion1.TabIndex = 10
        Me.cboQuestion1.Tag = "IN;Question 1*"
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = True
        Me.lblQ1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ1.Location = New System.Drawing.Point(44, 40)
        Me.lblQ1.Name = "lblQ1"
        Me.lblQ1.Size = New System.Drawing.Size(73, 14)
        Me.lblQ1.TabIndex = 9
        Me.lblQ1.Text = "QUESTION 1:"
        '
        'F_UserResitration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(435, 516)
        Me.Controls.Add(Me.grpSecurityQuestion)
        Me.Controls.Add(Me.grpUserInfo)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_UserResitration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USER REGISTRATION"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.grpUserInfo.ResumeLayout(False)
        Me.grpUserInfo.PerformLayout()
        Me.grpSecurityQuestion.ResumeLayout(False)
        Me.grpSecurityQuestion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents grpUserInfo As System.Windows.Forms.GroupBox
    Friend WithEvents cboUserLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblUserLevel As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPass As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents grpSecurityQuestion As System.Windows.Forms.GroupBox
    Friend WithEvents txtAns2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAns2 As System.Windows.Forms.Label
    Friend WithEvents cboQuestion2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblQ2 As System.Windows.Forms.Label
    Friend WithEvents txtAns1 As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer1 As System.Windows.Forms.Label
    Friend WithEvents cboQuestion1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblQ1 As System.Windows.Forms.Label
End Class

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
        Me.btnSave = New System.Windows.Forms.Button()
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
        Me.txtAns2 = New System.Windows.Forms.TextBox()
        Me.lblAns2 = New System.Windows.Forms.Label()
        Me.cboQuestion2 = New System.Windows.Forms.ComboBox()
        Me.lblQ2 = New System.Windows.Forms.Label()
        Me.txtAns1 = New System.Windows.Forms.TextBox()
        Me.lblAnswer1 = New System.Windows.Forms.Label()
        Me.cboQuestion1 = New System.Windows.Forms.ComboBox()
        Me.lblQ1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(292, 354)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 39)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cboUserLevel
        '
        Me.cboUserLevel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUserLevel.FormattingEnabled = True
        Me.cboUserLevel.Location = New System.Drawing.Point(140, 156)
        Me.cboUserLevel.Name = "cboUserLevel"
        Me.cboUserLevel.Size = New System.Drawing.Size(121, 22)
        Me.cboUserLevel.TabIndex = 9
        Me.cboUserLevel.Tag = "IN;User Level*"
        '
        'lblUserLevel
        '
        Me.lblUserLevel.AutoSize = True
        Me.lblUserLevel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserLevel.Location = New System.Drawing.Point(63, 160)
        Me.lblUserLevel.Name = "lblUserLevel"
        Me.lblUserLevel.Size = New System.Drawing.Size(69, 14)
        Me.lblUserLevel.TabIndex = 8
        Me.lblUserLevel.Text = "USER LEVEL:"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(140, 131)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(257, 22)
        Me.txtConfirmPass.TabIndex = 7
        Me.txtConfirmPass.Tag = "IN;Confirm Password*"
        Me.txtConfirmPass.UseSystemPasswordChar = True
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPass.Location = New System.Drawing.Point(12, 135)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(120, 14)
        Me.lblConfirmPass.TabIndex = 6
        Me.lblConfirmPass.Text = "CONFIRM PASSWORD:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(140, 102)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(257, 22)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.Tag = "IN;Password*"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(64, 106)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(68, 14)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "PASSWORD:"
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(140, 72)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(257, 22)
        Me.txtUserName.TabIndex = 3
        Me.txtUserName.Tag = "IN;User Name *"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(58, 76)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(74, 14)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "USER NAME :"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(140, 43)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(121, 22)
        Me.txtID.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(107, 47)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(25, 14)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID :"
        '
        'txtAns2
        '
        Me.txtAns2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAns2.Location = New System.Drawing.Point(140, 322)
        Me.txtAns2.Name = "txtAns2"
        Me.txtAns2.Size = New System.Drawing.Size(257, 22)
        Me.txtAns2.TabIndex = 16
        Me.txtAns2.Tag = "IN;Answer 2*"
        '
        'lblAns2
        '
        Me.lblAns2.AutoSize = True
        Me.lblAns2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAns2.Location = New System.Drawing.Point(68, 326)
        Me.lblAns2.Name = "lblAns2"
        Me.lblAns2.Size = New System.Drawing.Size(64, 14)
        Me.lblAns2.TabIndex = 15
        Me.lblAns2.Text = "ANSWER 2:"
        '
        'cboQuestion2
        '
        Me.cboQuestion2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuestion2.FormattingEnabled = True
        Me.cboQuestion2.Location = New System.Drawing.Point(140, 294)
        Me.cboQuestion2.Name = "cboQuestion2"
        Me.cboQuestion2.Size = New System.Drawing.Size(256, 22)
        Me.cboQuestion2.TabIndex = 14
        Me.cboQuestion2.Tag = "IN;Question 2*"
        '
        'lblQ2
        '
        Me.lblQ2.AutoSize = True
        Me.lblQ2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ2.Location = New System.Drawing.Point(59, 297)
        Me.lblQ2.Name = "lblQ2"
        Me.lblQ2.Size = New System.Drawing.Size(73, 14)
        Me.lblQ2.TabIndex = 13
        Me.lblQ2.Text = "QUESTION 2:"
        '
        'txtAns1
        '
        Me.txtAns1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAns1.Location = New System.Drawing.Point(140, 265)
        Me.txtAns1.Name = "txtAns1"
        Me.txtAns1.Size = New System.Drawing.Size(257, 22)
        Me.txtAns1.TabIndex = 12
        Me.txtAns1.Tag = "IN;Answer 1*"
        '
        'lblAnswer1
        '
        Me.lblAnswer1.AutoSize = True
        Me.lblAnswer1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer1.Location = New System.Drawing.Point(68, 269)
        Me.lblAnswer1.Name = "lblAnswer1"
        Me.lblAnswer1.Size = New System.Drawing.Size(64, 14)
        Me.lblAnswer1.TabIndex = 11
        Me.lblAnswer1.Text = "ANSWER 1:"
        '
        'cboQuestion1
        '
        Me.cboQuestion1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuestion1.FormattingEnabled = True
        Me.cboQuestion1.Location = New System.Drawing.Point(140, 237)
        Me.cboQuestion1.Name = "cboQuestion1"
        Me.cboQuestion1.Size = New System.Drawing.Size(256, 22)
        Me.cboQuestion1.TabIndex = 10
        Me.cboQuestion1.Tag = "IN;Question 1*"
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = True
        Me.lblQ1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ1.Location = New System.Drawing.Point(59, 240)
        Me.lblQ1.Name = "lblQ1"
        Me.lblQ1.Size = New System.Drawing.Size(73, 14)
        Me.lblQ1.TabIndex = 9
        Me.lblQ1.Text = "QUESTION 1:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtAns2)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.cboUserLevel)
        Me.Panel1.Controls.Add(Me.lblAns2)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.cboQuestion2)
        Me.Panel1.Controls.Add(Me.lblUserLevel)
        Me.Panel1.Controls.Add(Me.lblQ2)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.txtAns1)
        Me.Panel1.Controls.Add(Me.txtConfirmPass)
        Me.Panel1.Controls.Add(Me.lblAnswer1)
        Me.Panel1.Controls.Add(Me.lblUserName)
        Me.Panel1.Controls.Add(Me.cboQuestion1)
        Me.Panel1.Controls.Add(Me.lblQ1)
        Me.Panel1.Controls.Add(Me.lblConfirmPass)
        Me.Panel1.Controls.Add(Me.txtUserName)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.lblItems)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(5, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 396)
        Me.Panel1.TabIndex = 1
        Me.Panel1.Tag = "Secondary"
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(20, 13)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(115, 16)
        Me.lblItems.TabIndex = 68
        Me.lblItems.Tag = "Header-5"
        Me.lblItems.Text = "USER INFORMATION"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(395, 169)
        Me.Label10.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Tag = "Header-5"
        Me.Label1.Text = "SECURITY QUESTION"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(395, 143)
        Me.Label2.TabIndex = 71
        '
        'F_UserRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 407)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_UserRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Text = "USER REGISTRATION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
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
    Friend WithEvents txtAns2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAns2 As System.Windows.Forms.Label
    Friend WithEvents cboQuestion2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblQ2 As System.Windows.Forms.Label
    Friend WithEvents txtAns1 As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer1 As System.Windows.Forms.Label
    Friend WithEvents cboQuestion1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblQ1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblItems As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

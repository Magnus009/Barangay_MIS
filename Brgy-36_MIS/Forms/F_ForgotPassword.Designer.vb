<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ForgotPassword
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.grpQuestions = New System.Windows.Forms.GroupBox()
        Me.txtAnswer2 = New System.Windows.Forms.TextBox()
        Me.lblAnswer2 = New System.Windows.Forms.Label()
        Me.txtQuestion2 = New System.Windows.Forms.TextBox()
        Me.lblQuestion2 = New System.Windows.Forms.Label()
        Me.txtAnswer1 = New System.Windows.Forms.TextBox()
        Me.txtQuestion1 = New System.Windows.Forms.TextBox()
        Me.lblAnswer1 = New System.Windows.Forms.Label()
        Me.lblQuestion1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpQuestions.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 56)
        Me.Panel1.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(15, 16)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(163, 26)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Change Password"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtConfirmPass)
        Me.GroupBox1.Controls.Add(Me.lblConfirmPass)
        Me.GroupBox1.Controls.Add(Me.txtNewPass)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.lblNewPass)
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 135)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USER"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(135, 87)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtConfirmPass.ReadOnly = True
        Me.txtConfirmPass.Size = New System.Drawing.Size(219, 21)
        Me.txtConfirmPass.TabIndex = 5
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPass.Location = New System.Drawing.Point(1, 90)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(132, 16)
        Me.lblConfirmPass.TabIndex = 4
        Me.lblConfirmPass.Text = "CONFIRM PASSWORD :"
        '
        'txtNewPass
        '
        Me.txtNewPass.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.Location = New System.Drawing.Point(135, 60)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNewPass.ReadOnly = True
        Me.txtNewPass.Size = New System.Drawing.Size(219, 21)
        Me.txtNewPass.TabIndex = 3
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(135, 31)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(219, 21)
        Me.txtUserName.TabIndex = 2
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPass.Location = New System.Drawing.Point(29, 65)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(104, 16)
        Me.lblNewPass.TabIndex = 1
        Me.lblNewPass.Text = "NEW PASSWORD :"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(57, 34)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(76, 16)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "USER NAME :"
        '
        'grpQuestions
        '
        Me.grpQuestions.Controls.Add(Me.txtAnswer2)
        Me.grpQuestions.Controls.Add(Me.lblAnswer2)
        Me.grpQuestions.Controls.Add(Me.txtQuestion2)
        Me.grpQuestions.Controls.Add(Me.lblQuestion2)
        Me.grpQuestions.Controls.Add(Me.txtAnswer1)
        Me.grpQuestions.Controls.Add(Me.txtQuestion1)
        Me.grpQuestions.Controls.Add(Me.lblAnswer1)
        Me.grpQuestions.Controls.Add(Me.lblQuestion1)
        Me.grpQuestions.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpQuestions.Location = New System.Drawing.Point(12, 218)
        Me.grpQuestions.Name = "grpQuestions"
        Me.grpQuestions.Size = New System.Drawing.Size(360, 175)
        Me.grpQuestions.TabIndex = 2
        Me.grpQuestions.TabStop = False
        Me.grpQuestions.Text = "VERIFICATION QUESTIONS"
        '
        'txtAnswer2
        '
        Me.txtAnswer2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer2.Location = New System.Drawing.Point(110, 122)
        Me.txtAnswer2.Name = "txtAnswer2"
        Me.txtAnswer2.ReadOnly = True
        Me.txtAnswer2.Size = New System.Drawing.Size(235, 21)
        Me.txtAnswer2.TabIndex = 13
        '
        'lblAnswer2
        '
        Me.lblAnswer2.AutoSize = True
        Me.lblAnswer2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer2.Location = New System.Drawing.Point(36, 125)
        Me.lblAnswer2.Name = "lblAnswer2"
        Me.lblAnswer2.Size = New System.Drawing.Size(68, 16)
        Me.lblAnswer2.TabIndex = 12
        Me.lblAnswer2.Text = "ANSWER 2 :"
        '
        'txtQuestion2
        '
        Me.txtQuestion2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion2.Location = New System.Drawing.Point(110, 95)
        Me.txtQuestion2.Name = "txtQuestion2"
        Me.txtQuestion2.ReadOnly = True
        Me.txtQuestion2.Size = New System.Drawing.Size(235, 21)
        Me.txtQuestion2.TabIndex = 11
        '
        'lblQuestion2
        '
        Me.lblQuestion2.AutoSize = True
        Me.lblQuestion2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion2.Location = New System.Drawing.Point(25, 98)
        Me.lblQuestion2.Name = "lblQuestion2"
        Me.lblQuestion2.Size = New System.Drawing.Size(79, 16)
        Me.lblQuestion2.TabIndex = 10
        Me.lblQuestion2.Text = "QUESTION 2 :"
        '
        'txtAnswer1
        '
        Me.txtAnswer1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer1.Location = New System.Drawing.Point(110, 68)
        Me.txtAnswer1.Name = "txtAnswer1"
        Me.txtAnswer1.ReadOnly = True
        Me.txtAnswer1.Size = New System.Drawing.Size(235, 21)
        Me.txtAnswer1.TabIndex = 9
        '
        'txtQuestion1
        '
        Me.txtQuestion1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion1.Location = New System.Drawing.Point(110, 39)
        Me.txtQuestion1.Name = "txtQuestion1"
        Me.txtQuestion1.ReadOnly = True
        Me.txtQuestion1.Size = New System.Drawing.Size(235, 21)
        Me.txtQuestion1.TabIndex = 8
        '
        'lblAnswer1
        '
        Me.lblAnswer1.AutoSize = True
        Me.lblAnswer1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer1.Location = New System.Drawing.Point(36, 71)
        Me.lblAnswer1.Name = "lblAnswer1"
        Me.lblAnswer1.Size = New System.Drawing.Size(68, 16)
        Me.lblAnswer1.TabIndex = 7
        Me.lblAnswer1.Text = "ANSWER 1 :"
        '
        'lblQuestion1
        '
        Me.lblQuestion1.AutoSize = True
        Me.lblQuestion1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion1.Location = New System.Drawing.Point(22, 42)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(82, 16)
        Me.lblQuestion1.TabIndex = 6
        Me.lblQuestion1.Text = " QUESTION 1 :"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(264, 404)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 41)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Teal
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(154, 404)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 41)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'F_ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 460)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grpQuestions)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_ForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORGOT PASSWORD"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpQuestions.ResumeLayout(False)
        Me.grpQuestions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtConfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPass As System.Windows.Forms.Label
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblNewPass As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents grpQuestions As System.Windows.Forms.GroupBox
    Friend WithEvents txtAnswer2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer2 As System.Windows.Forms.Label
    Friend WithEvents txtQuestion2 As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestion2 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer1 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestion1 As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer1 As System.Windows.Forms.Label
    Friend WithEvents lblQuestion1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class

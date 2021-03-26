<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_BarangayIndigency
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
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.txtCompleteAdd = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpCaseStudy = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFullName
        '
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(142, 69)
        Me.txtFullName.MaxLength = 50
        Me.txtFullName.Multiline = True
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(230, 20)
        Me.txtFullName.TabIndex = 3
        Me.txtFullName.Tag = ""
        Me.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NAME :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(324, 95)
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(48, 20)
        Me.txtAge.TabIndex = 23
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(281, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "AGE :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(46, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "DATE OF BIRTH :"
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpBirthdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthdate.Location = New System.Drawing.Point(142, 95)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(117, 21)
        Me.dtpBirthdate.TabIndex = 22
        Me.dtpBirthdate.Tag = ""
        '
        'txtCompleteAdd
        '
        Me.txtCompleteAdd.BackColor = System.Drawing.Color.White
        Me.txtCompleteAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompleteAdd.Enabled = False
        Me.txtCompleteAdd.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompleteAdd.Location = New System.Drawing.Point(66, 142)
        Me.txtCompleteAdd.MaxLength = 100
        Me.txtCompleteAdd.Multiline = True
        Me.txtCompleteAdd.Name = "txtCompleteAdd"
        Me.txtCompleteAdd.Size = New System.Drawing.Size(306, 47)
        Me.txtCompleteAdd.TabIndex = 48
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(12, 123)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(124, 16)
        Me.Label28.TabIndex = 49
        Me.Label28.Text = "COMPLETE ADDRESS :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 196)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 16)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "DATE OF CASE STUDY :"
        '
        'dtpCaseStudy
        '
        Me.dtpCaseStudy.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpCaseStudy.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCaseStudy.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCaseStudy.Location = New System.Drawing.Point(142, 195)
        Me.dtpCaseStudy.Name = "dtpCaseStudy"
        Me.dtpCaseStudy.Size = New System.Drawing.Size(105, 21)
        Me.dtpCaseStudy.TabIndex = 50
        Me.dtpCaseStudy.Tag = ""
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(268, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 35)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "&PRINT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'F_BarangayIndigency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 241)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dtpCaseStudy)
        Me.Controls.Add(Me.txtCompleteAdd)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpBirthdate)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_BarangayIndigency"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCompleteAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpCaseStudy As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

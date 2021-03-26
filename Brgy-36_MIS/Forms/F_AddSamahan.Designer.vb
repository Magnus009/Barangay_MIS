<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_AddSamahan
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
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtCreatedDate = New System.Windows.Forms.TextBox()
        Me.lblCreatedDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(115, 14)
        Me.txtTitle.MaxLength = 50
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(248, 20)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Tag = "IN;Title*"
        Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "TITLE :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(21, 59)
        Me.txtDescription.MaxLength = 250
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(342, 55)
        Me.txtDescription.TabIndex = 2
        Me.txtDescription.Tag = "IN:Description*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DESCRIPTION :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(288, 117)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 32)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtCreatedDate
        '
        Me.txtCreatedDate.BackColor = System.Drawing.Color.White
        Me.txtCreatedDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCreatedDate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreatedDate.Location = New System.Drawing.Point(115, 120)
        Me.txtCreatedDate.MaxLength = 50
        Me.txtCreatedDate.Multiline = True
        Me.txtCreatedDate.Name = "txtCreatedDate"
        Me.txtCreatedDate.ReadOnly = True
        Me.txtCreatedDate.Size = New System.Drawing.Size(121, 20)
        Me.txtCreatedDate.TabIndex = 4
        Me.txtCreatedDate.Tag = ""
        Me.txtCreatedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCreatedDate.Visible = False
        '
        'lblCreatedDate
        '
        Me.lblCreatedDate.AutoSize = True
        Me.lblCreatedDate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreatedDate.Location = New System.Drawing.Point(18, 122)
        Me.lblCreatedDate.Name = "lblCreatedDate"
        Me.lblCreatedDate.Size = New System.Drawing.Size(91, 16)
        Me.lblCreatedDate.TabIndex = 10
        Me.lblCreatedDate.Text = "CREATED DATE :"
        Me.lblCreatedDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCreatedDate.Visible = False
        '
        'F_AddSamahan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 152)
        Me.Controls.Add(Me.lblCreatedDate)
        Me.Controls.Add(Me.txtCreatedDate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_AddSamahan"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAMAHAN INFORMATION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtCreatedDate As System.Windows.Forms.TextBox
    Friend WithEvents lblCreatedDate As System.Windows.Forms.Label
End Class

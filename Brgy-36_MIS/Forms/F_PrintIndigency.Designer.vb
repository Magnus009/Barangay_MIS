<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_PrintIndigency
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_PrintIndigency))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnResidentList = New System.Windows.Forms.Button()
        Me.txtResident = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.lblPurpose = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnResidentList)
        Me.Panel1.Controls.Add(Me.txtResident)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.txtPurpose)
        Me.Panel1.Controls.Add(Me.lblPurpose)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 217)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Tag = "Secondary"
        '
        'btnResidentList
        '
        Me.btnResidentList.Location = New System.Drawing.Point(347, 18)
        Me.btnResidentList.Name = "btnResidentList"
        Me.btnResidentList.Size = New System.Drawing.Size(58, 24)
        Me.btnResidentList.TabIndex = 12
        Me.btnResidentList.Text = "SELECT"
        Me.btnResidentList.UseVisualStyleBackColor = True
        '
        'txtResident
        '
        Me.txtResident.Location = New System.Drawing.Point(115, 20)
        Me.txtResident.Name = "txtResident"
        Me.txtResident.ReadOnly = True
        Me.txtResident.Size = New System.Drawing.Size(232, 21)
        Me.txtResident.TabIndex = 11
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(296, 174)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(106, 32)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'txtPurpose
        '
        Me.txtPurpose.Location = New System.Drawing.Point(115, 53)
        Me.txtPurpose.Multiline = True
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(289, 107)
        Me.txtPurpose.TabIndex = 9
        '
        'lblPurpose
        '
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.Location = New System.Drawing.Point(56, 53)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.Size = New System.Drawing.Size(57, 16)
        Me.lblPurpose.TabIndex = 8
        Me.lblPurpose.Text = "Purpose :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(11, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(102, 16)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Resident's Name :"
        '
        'F_PrintIndigency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 236)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_PrintIndigency"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnResidentList As System.Windows.Forms.Button
    Friend WithEvents txtResident As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents lblPurpose As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class

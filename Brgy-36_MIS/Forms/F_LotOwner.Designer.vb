<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LotOwner
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
        Me.pnlSamahan = New System.Windows.Forms.Panel()
        Me.btnResidence = New System.Windows.Forms.Button()
        Me.txtResidence = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLot = New System.Windows.Forms.Label()
        Me.datMember = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlSamahan.SuspendLayout()
        CType(Me.datMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSamahan
        '
        Me.pnlSamahan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSamahan.Controls.Add(Me.btnSave)
        Me.pnlSamahan.Controls.Add(Me.Label2)
        Me.pnlSamahan.Controls.Add(Me.datMember)
        Me.pnlSamahan.Controls.Add(Me.btnResidence)
        Me.pnlSamahan.Controls.Add(Me.txtResidence)
        Me.pnlSamahan.Controls.Add(Me.Label1)
        Me.pnlSamahan.Controls.Add(Me.lblLot)
        Me.pnlSamahan.Location = New System.Drawing.Point(5, 5)
        Me.pnlSamahan.Name = "pnlSamahan"
        Me.pnlSamahan.Size = New System.Drawing.Size(368, 253)
        Me.pnlSamahan.TabIndex = 2
        Me.pnlSamahan.Tag = "Secondary"
        '
        'btnResidence
        '
        Me.btnResidence.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResidence.Location = New System.Drawing.Point(331, 38)
        Me.btnResidence.Name = "btnResidence"
        Me.btnResidence.Size = New System.Drawing.Size(32, 23)
        Me.btnResidence.TabIndex = 3
        Me.btnResidence.Text = "..."
        Me.btnResidence.UseVisualStyleBackColor = True
        '
        'txtResidence
        '
        Me.txtResidence.Location = New System.Drawing.Point(134, 39)
        Me.txtResidence.Name = "txtResidence"
        Me.txtResidence.Size = New System.Drawing.Size(197, 21)
        Me.txtResidence.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RESIDENCE NAME :"
        '
        'lblLot
        '
        Me.lblLot.AutoSize = True
        Me.lblLot.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLot.Location = New System.Drawing.Point(7, 11)
        Me.lblLot.Name = "lblLot"
        Me.lblLot.Size = New System.Drawing.Size(65, 19)
        Me.lblLot.TabIndex = 0
        Me.lblLot.Text = "LOT 0-0"
        '
        'datMember
        '
        Me.datMember.AllowUserToAddRows = False
        Me.datMember.AllowUserToDeleteRows = False
        Me.datMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datMember.Location = New System.Drawing.Point(11, 88)
        Me.datMember.Name = "datMember"
        Me.datMember.ReadOnly = True
        Me.datMember.Size = New System.Drawing.Size(352, 120)
        Me.datMember.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MEMBERS"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(284, 214)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 34)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'F_LotOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 263)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlSamahan)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "F_LotOwner"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Text = "LOT OWNER"
        Me.pnlSamahan.ResumeLayout(False)
        Me.pnlSamahan.PerformLayout()
        CType(Me.datMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSamahan As System.Windows.Forms.Panel
    Friend WithEvents txtResidence As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLot As System.Windows.Forms.Label
    Friend WithEvents btnResidence As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents datMember As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class

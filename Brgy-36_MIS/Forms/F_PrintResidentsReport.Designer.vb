<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_PrintResidentsReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_PrintResidentsReport))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboCivilStatus = New System.Windows.Forms.ComboBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.lblCivilStatus = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.chkIndigent = New System.Windows.Forms.CheckBox()
        Me.chkPWD = New System.Windows.Forms.CheckBox()
        Me.chkInHabitant = New System.Windows.Forms.CheckBox()
        Me.chkVoters = New System.Windows.Forms.CheckBox()
        Me.datResidents = New System.Windows.Forms.DataGridView()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.datResidents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboCivilStatus)
        Me.Panel1.Controls.Add(Me.cboGender)
        Me.Panel1.Controls.Add(Me.lblCivilStatus)
        Me.Panel1.Controls.Add(Me.lblGender)
        Me.Panel1.Controls.Add(Me.chkIndigent)
        Me.Panel1.Controls.Add(Me.chkPWD)
        Me.Panel1.Controls.Add(Me.chkInHabitant)
        Me.Panel1.Controls.Add(Me.chkVoters)
        Me.Panel1.Controls.Add(Me.datResidents)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 549)
        Me.Panel1.TabIndex = 10
        Me.Panel1.Tag = "Secondary"
        '
        'cboCivilStatus
        '
        Me.cboCivilStatus.FormattingEnabled = True
        Me.cboCivilStatus.Location = New System.Drawing.Point(373, 48)
        Me.cboCivilStatus.Name = "cboCivilStatus"
        Me.cboCivilStatus.Size = New System.Drawing.Size(112, 25)
        Me.cboCivilStatus.TabIndex = 18
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Location = New System.Drawing.Point(373, 17)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(112, 25)
        Me.cboGender.TabIndex = 17
        '
        'lblCivilStatus
        '
        Me.lblCivilStatus.AutoSize = True
        Me.lblCivilStatus.Location = New System.Drawing.Point(287, 52)
        Me.lblCivilStatus.Name = "lblCivilStatus"
        Me.lblCivilStatus.Size = New System.Drawing.Size(80, 17)
        Me.lblCivilStatus.TabIndex = 16
        Me.lblCivilStatus.Text = "Civil Status :"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(308, 17)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(59, 17)
        Me.lblGender.TabIndex = 15
        Me.lblGender.Text = "Gender :"
        '
        'chkIndigent
        '
        Me.chkIndigent.AutoSize = True
        Me.chkIndigent.Location = New System.Drawing.Point(168, 48)
        Me.chkIndigent.Name = "chkIndigent"
        Me.chkIndigent.Size = New System.Drawing.Size(76, 21)
        Me.chkIndigent.TabIndex = 14
        Me.chkIndigent.Text = "Indigent"
        Me.chkIndigent.UseVisualStyleBackColor = True
        '
        'chkPWD
        '
        Me.chkPWD.AutoSize = True
        Me.chkPWD.Location = New System.Drawing.Point(168, 17)
        Me.chkPWD.Name = "chkPWD"
        Me.chkPWD.Size = New System.Drawing.Size(56, 21)
        Me.chkPWD.TabIndex = 13
        Me.chkPWD.Text = "PWD"
        Me.chkPWD.UseVisualStyleBackColor = True
        '
        'chkInHabitant
        '
        Me.chkInHabitant.AutoSize = True
        Me.chkInHabitant.Location = New System.Drawing.Point(24, 48)
        Me.chkInHabitant.Name = "chkInHabitant"
        Me.chkInHabitant.Size = New System.Drawing.Size(92, 21)
        Me.chkInHabitant.TabIndex = 12
        Me.chkInHabitant.Text = "In Habitant"
        Me.chkInHabitant.UseVisualStyleBackColor = True
        '
        'chkVoters
        '
        Me.chkVoters.AutoSize = True
        Me.chkVoters.Location = New System.Drawing.Point(24, 17)
        Me.chkVoters.Name = "chkVoters"
        Me.chkVoters.Size = New System.Drawing.Size(66, 21)
        Me.chkVoters.TabIndex = 11
        Me.chkVoters.Text = "Voters"
        Me.chkVoters.UseVisualStyleBackColor = True
        '
        'datResidents
        '
        Me.datResidents.AllowUserToAddRows = False
        Me.datResidents.AllowUserToDeleteRows = False
        Me.datResidents.AllowUserToResizeColumns = False
        Me.datResidents.AllowUserToResizeRows = False
        Me.datResidents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datResidents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datResidents.DefaultCellStyle = DataGridViewCellStyle2
        Me.datResidents.Location = New System.Drawing.Point(12, 98)
        Me.datResidents.Name = "datResidents"
        Me.datResidents.RowHeadersVisible = False
        Me.datResidents.Size = New System.Drawing.Size(476, 395)
        Me.datResidents.TabIndex = 10
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(374, 496)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(112, 46)
        Me.btnPrint.TabIndex = 19
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'F_PrintResidentsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 566)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_PrintResidentsReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Text = "Reaidents Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datResidents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboCivilStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblCivilStatus As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents chkIndigent As System.Windows.Forms.CheckBox
    Friend WithEvents chkPWD As System.Windows.Forms.CheckBox
    Friend WithEvents chkInHabitant As System.Windows.Forms.CheckBox
    Friend WithEvents chkVoters As System.Windows.Forms.CheckBox
    Friend WithEvents datResidents As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class

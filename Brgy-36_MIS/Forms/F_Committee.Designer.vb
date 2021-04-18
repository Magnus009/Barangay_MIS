<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Committee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Committee))
        Me.datOfficials = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpCommittee = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cboCommittee = New System.Windows.Forms.ComboBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.btnResidents = New System.Windows.Forms.Button()
        Me.txtResident = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.datOfficials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCommittee.SuspendLayout()
        Me.SuspendLayout()
        '
        'datOfficials
        '
        Me.datOfficials.AllowUserToAddRows = False
        Me.datOfficials.AllowUserToDeleteRows = False
        Me.datOfficials.AllowUserToResizeColumns = False
        Me.datOfficials.AllowUserToResizeRows = False
        Me.datOfficials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datOfficials.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datOfficials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datOfficials.DefaultCellStyle = DataGridViewCellStyle2
        Me.datOfficials.Location = New System.Drawing.Point(12, 190)
        Me.datOfficials.Name = "datOfficials"
        Me.datOfficials.RowHeadersVisible = False
        Me.datOfficials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datOfficials.Size = New System.Drawing.Size(421, 288)
        Me.datOfficials.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(81, 162)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(322, 22)
        Me.txtSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SEARCH :"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(206, 104)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 29)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "SAVE"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grpCommittee
        '
        Me.grpCommittee.Controls.Add(Me.btnCancel)
        Me.grpCommittee.Controls.Add(Me.cboCommittee)
        Me.grpCommittee.Controls.Add(Me.lblPosition)
        Me.grpCommittee.Controls.Add(Me.btnResidents)
        Me.grpCommittee.Controls.Add(Me.txtResident)
        Me.grpCommittee.Controls.Add(Me.lblName)
        Me.grpCommittee.Controls.Add(Me.btnAdd)
        Me.grpCommittee.Location = New System.Drawing.Point(12, 7)
        Me.grpCommittee.Name = "grpCommittee"
        Me.grpCommittee.Size = New System.Drawing.Size(421, 146)
        Me.grpCommittee.TabIndex = 4
        Me.grpCommittee.TabStop = False
        Me.grpCommittee.Text = " COMMITTEE INFORMATION"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(306, 104)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 29)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cboCommittee
        '
        Me.cboCommittee.FormattingEnabled = True
        Me.cboCommittee.Location = New System.Drawing.Point(89, 73)
        Me.cboCommittee.Name = "cboCommittee"
        Me.cboCommittee.Size = New System.Drawing.Size(273, 25)
        Me.cboCommittee.TabIndex = 8
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(15, 76)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(68, 17)
        Me.lblPosition.TabIndex = 7
        Me.lblPosition.Text = "POSITION :"
        '
        'btnResidents
        '
        Me.btnResidents.Location = New System.Drawing.Point(365, 45)
        Me.btnResidents.Name = "btnResidents"
        Me.btnResidents.Size = New System.Drawing.Size(41, 23)
        Me.btnResidents.TabIndex = 6
        Me.btnResidents.UseVisualStyleBackColor = True
        '
        'txtResident
        '
        Me.txtResident.Location = New System.Drawing.Point(91, 45)
        Me.txtResident.Name = "txtResident"
        Me.txtResident.Size = New System.Drawing.Size(271, 22)
        Me.txtResident.TabIndex = 5
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(34, 48)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 17)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "NAME :"
        '
        'F_Committee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 490)
        Me.Controls.Add(Me.grpCommittee)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.datOfficials)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Committee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Committee"
        CType(Me.datOfficials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCommittee.ResumeLayout(False)
        Me.grpCommittee.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datOfficials As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents grpCommittee As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cboCommittee As System.Windows.Forms.ComboBox
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents btnResidents As System.Windows.Forms.Button
    Friend WithEvents txtResident As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class

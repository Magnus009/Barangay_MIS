<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Officials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Officials))
        Me.picCaviteCityLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picBarangayLogo = New System.Windows.Forms.PictureBox()
        Me.datOfficials = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblTOS = New System.Windows.Forms.Label()
        Me.dtpDOS = New System.Windows.Forms.DateTimePicker()
        CType(Me.picCaviteCityLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBarangayLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datOfficials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCaviteCityLogo
        '
        Me.picCaviteCityLogo.Location = New System.Drawing.Point(12, 13)
        Me.picCaviteCityLogo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picCaviteCityLogo.Name = "picCaviteCityLogo"
        Me.picCaviteCityLogo.Size = New System.Drawing.Size(80, 75)
        Me.picCaviteCityLogo.TabIndex = 0
        Me.picCaviteCityLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BARANGAY 36-A (SAP-SAP)"
        '
        'picBarangayLogo
        '
        Me.picBarangayLogo.Location = New System.Drawing.Point(520, 13)
        Me.picBarangayLogo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picBarangayLogo.Name = "picBarangayLogo"
        Me.picBarangayLogo.Size = New System.Drawing.Size(80, 75)
        Me.picBarangayLogo.TabIndex = 3
        Me.picBarangayLogo.TabStop = False
        '
        'datOfficials
        '
        Me.datOfficials.AllowUserToAddRows = False
        Me.datOfficials.AllowUserToDeleteRows = False
        Me.datOfficials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datOfficials.ColumnHeadersHeight = 30
        Me.datOfficials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datOfficials.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.datOfficials.Location = New System.Drawing.Point(12, 126)
        Me.datOfficials.MultiSelect = False
        Me.datOfficials.Name = "datOfficials"
        Me.datOfficials.ReadOnly = True
        Me.datOfficials.RowHeadersVisible = False
        Me.datOfficials.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datOfficials.Size = New System.Drawing.Size(588, 261)
        Me.datOfficials.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "NAME"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "POSITION"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "STATUS"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "TERM OF SERVICE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "VIEW"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(35, 104)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(57, 16)
        Me.lblSearch.TabIndex = 5
        Me.lblSearch.Text = "SEARCH :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(98, 102)
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(204, 21)
        Me.txtSearch.TabIndex = 6
        '
        'lblTOS
        '
        Me.lblTOS.AutoSize = True
        Me.lblTOS.Location = New System.Drawing.Point(369, 104)
        Me.lblTOS.Name = "lblTOS"
        Me.lblTOS.Size = New System.Drawing.Size(108, 16)
        Me.lblTOS.TabIndex = 7
        Me.lblTOS.Text = "TERM OF SERVICE :"
        '
        'dtpDOS
        '
        Me.dtpDOS.CustomFormat = "yyyy/MM/dd"
        Me.dtpDOS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOS.Location = New System.Drawing.Point(483, 102)
        Me.dtpDOS.Name = "dtpDOS"
        Me.dtpDOS.Size = New System.Drawing.Size(104, 21)
        Me.dtpDOS.TabIndex = 8
        '
        'F_Officials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 399)
        Me.Controls.Add(Me.dtpDOS)
        Me.Controls.Add(Me.lblTOS)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.datOfficials)
        Me.Controls.Add(Me.picBarangayLogo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picCaviteCityLogo)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Officials"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OFFICIALS"
        CType(Me.picCaviteCityLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBarangayLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datOfficials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCaviteCityLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picBarangayLogo As System.Windows.Forms.PictureBox
    Friend WithEvents datOfficials As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblTOS As System.Windows.Forms.Label
    Friend WithEvents dtpDOS As System.Windows.Forms.DateTimePicker
End Class

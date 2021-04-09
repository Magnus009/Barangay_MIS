<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CasesRecords
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReportedBy = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpReported = New System.Windows.Forms.DateTimePicker()
        Me.dtpIncident = New System.Windows.Forms.DateTimePicker()
        Me.datCases = New System.Windows.Forms.DataGridView()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.pnlCase = New System.Windows.Forms.Panel()
        CType(Me.datCases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCase.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(573, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(114, 53)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "&SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Location = New System.Drawing.Point(105, 15)
        Me.txtCode.MaxLength = 20
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(118, 21)
        Me.txtCode.TabIndex = 5
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(52, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CODE :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReportedBy
        '
        Me.txtReportedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReportedBy.Location = New System.Drawing.Point(105, 42)
        Me.txtReportedBy.MaxLength = 20
        Me.txtReportedBy.Name = "txtReportedBy"
        Me.txtReportedBy.Size = New System.Drawing.Size(205, 21)
        Me.txtReportedBy.TabIndex = 8
        Me.txtReportedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "REPORTED BY :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(355, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "DATE REPORTED :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(343, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "DATE OF INCIDENT :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpReported
        '
        Me.dtpReported.CustomFormat = "yyyy/MM/dd"
        Me.dtpReported.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReported.Location = New System.Drawing.Point(460, 42)
        Me.dtpReported.Name = "dtpReported"
        Me.dtpReported.ShowCheckBox = True
        Me.dtpReported.Size = New System.Drawing.Size(104, 21)
        Me.dtpReported.TabIndex = 12
        '
        'dtpIncident
        '
        Me.dtpIncident.CustomFormat = "yyyy/MM/dd"
        Me.dtpIncident.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIncident.Location = New System.Drawing.Point(460, 15)
        Me.dtpIncident.Name = "dtpIncident"
        Me.dtpIncident.ShowCheckBox = True
        Me.dtpIncident.Size = New System.Drawing.Size(104, 21)
        Me.dtpIncident.TabIndex = 13
        '
        'datCases
        '
        Me.datCases.AllowUserToAddRows = False
        Me.datCases.AllowUserToDeleteRows = False
        Me.datCases.AllowUserToResizeColumns = False
        Me.datCases.AllowUserToResizeRows = False
        Me.datCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datCases.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datCases.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datCases.ColumnHeadersHeight = 30
        Me.datCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datCases.Location = New System.Drawing.Point(9, 69)
        Me.datCases.MultiSelect = False
        Me.datCases.Name = "datCases"
        Me.datCases.ReadOnly = True
        Me.datCases.RowHeadersVisible = False
        Me.datCases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datCases.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datCases.Size = New System.Drawing.Size(678, 340)
        Me.datCases.TabIndex = 14
        '
        'btnFile
        '
        Me.btnFile.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFile.Location = New System.Drawing.Point(573, 411)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(114, 32)
        Me.btnFile.TabIndex = 15
        Me.btnFile.Text = "&FILE"
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'pnlCase
        '
        Me.pnlCase.Controls.Add(Me.datCases)
        Me.pnlCase.Controls.Add(Me.btnFile)
        Me.pnlCase.Controls.Add(Me.txtReportedBy)
        Me.pnlCase.Controls.Add(Me.dtpIncident)
        Me.pnlCase.Controls.Add(Me.Label1)
        Me.pnlCase.Controls.Add(Me.dtpReported)
        Me.pnlCase.Controls.Add(Me.txtCode)
        Me.pnlCase.Controls.Add(Me.Label3)
        Me.pnlCase.Controls.Add(Me.btnSearch)
        Me.pnlCase.Controls.Add(Me.Label4)
        Me.pnlCase.Controls.Add(Me.Label2)
        Me.pnlCase.Location = New System.Drawing.Point(6, 7)
        Me.pnlCase.Name = "pnlCase"
        Me.pnlCase.Size = New System.Drawing.Size(697, 447)
        Me.pnlCase.TabIndex = 1
        Me.pnlCase.Tag = "Secondary"
        '
        'F_CasesRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 461)
        Me.Controls.Add(Me.pnlCase)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_CasesRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Text = "CASE"
        CType(Me.datCases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCase.ResumeLayout(False)
        Me.pnlCase.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReportedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpReported As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpIncident As System.Windows.Forms.DateTimePicker
    Friend WithEvents datCases As System.Windows.Forms.DataGridView
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents pnlCase As System.Windows.Forms.Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Inventory
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Inventory))
        Me.datItems = New System.Windows.Forms.DataGridView()
        Me.datBorrow = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchItems = New System.Windows.Forms.TextBox()
        Me.txtSearchBorrow = New System.Windows.Forms.TextBox()
        Me.lblSearch1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.lblDash = New System.Windows.Forms.Label()
        Me.pnlBorrow = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.datItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datBorrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBorrow.SuspendLayout()
        Me.SuspendLayout()
        '
        'datItems
        '
        Me.datItems.AllowUserToAddRows = False
        Me.datItems.AllowUserToDeleteRows = False
        Me.datItems.AllowUserToResizeColumns = False
        Me.datItems.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datItems.DefaultCellStyle = DataGridViewCellStyle2
        Me.datItems.Location = New System.Drawing.Point(14, 71)
        Me.datItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.datItems.MultiSelect = False
        Me.datItems.Name = "datItems"
        Me.datItems.RowHeadersVisible = False
        Me.datItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datItems.Size = New System.Drawing.Size(375, 437)
        Me.datItems.TabIndex = 1
        '
        'datBorrow
        '
        Me.datBorrow.AllowUserToAddRows = False
        Me.datBorrow.AllowUserToDeleteRows = False
        Me.datBorrow.AllowUserToResizeColumns = False
        Me.datBorrow.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datBorrow.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datBorrow.ColumnHeadersHeight = 20
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datBorrow.DefaultCellStyle = DataGridViewCellStyle4
        Me.datBorrow.Location = New System.Drawing.Point(408, 71)
        Me.datBorrow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.datBorrow.MultiSelect = False
        Me.datBorrow.Name = "datBorrow"
        Me.datBorrow.RowHeadersVisible = False
        Me.datBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datBorrow.Size = New System.Drawing.Size(753, 437)
        Me.datBorrow.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(281, 512)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(108, 31)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "ADD ITEM"
        '
        'btnBorrow
        '
        Me.btnBorrow.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrow.Location = New System.Drawing.Point(1035, 512)
        Me.btnBorrow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(126, 31)
        Me.btnBorrow.TabIndex = 6
        Me.btnBorrow.Text = "BORROW ITEM"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(15, 48)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(57, 16)
        Me.lblSearch.TabIndex = 7
        Me.lblSearch.Text = "SEARCH :"
        '
        'txtSearchItems
        '
        Me.txtSearchItems.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchItems.Location = New System.Drawing.Point(83, 44)
        Me.txtSearchItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchItems.Name = "txtSearchItems"
        Me.txtSearchItems.Size = New System.Drawing.Size(228, 21)
        Me.txtSearchItems.TabIndex = 8
        '
        'txtSearchBorrow
        '
        Me.txtSearchBorrow.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBorrow.Location = New System.Drawing.Point(462, 44)
        Me.txtSearchBorrow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchBorrow.Name = "txtSearchBorrow"
        Me.txtSearchBorrow.Size = New System.Drawing.Size(179, 21)
        Me.txtSearchBorrow.TabIndex = 10
        '
        'lblSearch1
        '
        Me.lblSearch1.AutoSize = True
        Me.lblSearch1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch1.Location = New System.Drawing.Point(408, 46)
        Me.lblSearch1.Name = "lblSearch1"
        Me.lblSearch1.Size = New System.Drawing.Size(57, 16)
        Me.lblSearch1.TabIndex = 9
        Me.lblSearch1.Text = "SEARCH :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(669, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "BORROWED DATE :"
        '
        'dtpFrom
        '
        Me.dtpFrom.CalendarFont = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.CustomFormat = "yyyy/MM/dd"
        Me.dtpFrom.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(779, 44)
        Me.dtpFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(97, 21)
        Me.dtpFrom.TabIndex = 12
        '
        'dtpTo
        '
        Me.dtpTo.CalendarFont = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.CustomFormat = "yyyy/MM/dd"
        Me.dtpTo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(892, 44)
        Me.dtpTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(94, 21)
        Me.dtpTo.TabIndex = 13
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(1097, 39)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(64, 30)
        Me.btnFilter.TabIndex = 14
        Me.btnFilter.Text = "FILTER"
        '
        'lblDash
        '
        Me.lblDash.AutoSize = True
        Me.lblDash.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDash.Location = New System.Drawing.Point(879, 46)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(12, 16)
        Me.lblDash.TabIndex = 15
        Me.lblDash.Text = "-"
        '
        'pnlBorrow
        '
        Me.pnlBorrow.Controls.Add(Me.Label2)
        Me.pnlBorrow.Controls.Add(Me.btnAdd)
        Me.pnlBorrow.Controls.Add(Me.txtSearchItems)
        Me.pnlBorrow.Controls.Add(Me.datItems)
        Me.pnlBorrow.Controls.Add(Me.lblItems)
        Me.pnlBorrow.Controls.Add(Me.lblSearch)
        Me.pnlBorrow.Controls.Add(Me.Label10)
        Me.pnlBorrow.Controls.Add(Me.txtSearchBorrow)
        Me.pnlBorrow.Controls.Add(Me.datBorrow)
        Me.pnlBorrow.Controls.Add(Me.lblDash)
        Me.pnlBorrow.Controls.Add(Me.btnBorrow)
        Me.pnlBorrow.Controls.Add(Me.btnFilter)
        Me.pnlBorrow.Controls.Add(Me.lblSearch1)
        Me.pnlBorrow.Controls.Add(Me.dtpTo)
        Me.pnlBorrow.Controls.Add(Me.Label1)
        Me.pnlBorrow.Controls.Add(Me.dtpFrom)
        Me.pnlBorrow.Controls.Add(Me.Label3)
        Me.pnlBorrow.Location = New System.Drawing.Point(6, 13)
        Me.pnlBorrow.Name = "pnlBorrow"
        Me.pnlBorrow.Size = New System.Drawing.Size(1172, 557)
        Me.pnlBorrow.TabIndex = 17
        Me.pnlBorrow.Tag = "Secondary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(412, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Tag = "Header-5"
        Me.Label2.Text = "BORROW HISTORY"
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(16, 13)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(39, 16)
        Me.lblItems.TabIndex = 66
        Me.lblItems.Tag = "Header-5"
        Me.lblItems.Text = "ITEMS"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(390, 528)
        Me.Label10.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(402, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(764, 528)
        Me.Label3.TabIndex = 69
        '
        'F_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 580)
        Me.Controls.Add(Me.pnlBorrow)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Text = "INVENTORY"
        CType(Me.datItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datBorrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBorrow.ResumeLayout(False)
        Me.pnlBorrow.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents datItems As System.Windows.Forms.DataGridView
    Friend WithEvents datBorrow As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnBorrow As System.Windows.Forms.Button
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearchItems As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchBorrow As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents lblDash As System.Windows.Forms.Label
    Friend WithEvents pnlBorrow As System.Windows.Forms.Panel
    Friend WithEvents lblItems As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

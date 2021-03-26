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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.datItems = New System.Windows.Forms.DataGridView()
        Me.datBorrow = New System.Windows.Forms.DataGridView()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.lblBorrow = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        CType(Me.datItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datBorrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
<<<<<<< HEAD
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1021, 74)
=======
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 60)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.Panel1.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.lblHeader.Location = New System.Drawing.Point(23, 23)
=======
        Me.lblHeader.Location = New System.Drawing.Point(20, 19)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(128, 25)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "INVENTORY"
        '
        'datItems
        '
        Me.datItems.AllowUserToAddRows = False
        Me.datItems.AllowUserToDeleteRows = False
        Me.datItems.AllowUserToResizeColumns = False
        Me.datItems.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
<<<<<<< HEAD
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
=======
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
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
<<<<<<< HEAD
        Me.datItems.Location = New System.Drawing.Point(14, 156)
        Me.datItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.datItems.Name = "datItems"
        Me.datItems.RowHeadersVisible = False
        Me.datItems.Size = New System.Drawing.Size(297, 469)
=======
        Me.datItems.Location = New System.Drawing.Point(12, 127)
        Me.datItems.Name = "datItems"
        Me.datItems.RowHeadersVisible = False
        Me.datItems.Size = New System.Drawing.Size(255, 381)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
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
<<<<<<< HEAD
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
=======
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
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
<<<<<<< HEAD
        Me.datBorrow.Location = New System.Drawing.Point(318, 155)
        Me.datBorrow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.datBorrow.Name = "datBorrow"
        Me.datBorrow.RowHeadersVisible = False
        Me.datBorrow.Size = New System.Drawing.Size(688, 474)
=======
        Me.datBorrow.Location = New System.Drawing.Point(273, 126)
        Me.datBorrow.Name = "datBorrow"
        Me.datBorrow.RowHeadersVisible = False
        Me.datBorrow.Size = New System.Drawing.Size(590, 385)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.datBorrow.TabIndex = 2
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.lblItems.Location = New System.Drawing.Point(14, 98)
=======
        Me.lblItems.Location = New System.Drawing.Point(12, 80)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(50, 19)
        Me.lblItems.TabIndex = 3
        Me.lblItems.Text = "ITEMS"
        '
        'lblBorrow
        '
        Me.lblBorrow.AutoSize = True
        Me.lblBorrow.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.lblBorrow.Location = New System.Drawing.Point(322, 98)
=======
        Me.lblBorrow.Location = New System.Drawing.Point(276, 80)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.lblBorrow.Name = "lblBorrow"
        Me.lblBorrow.Size = New System.Drawing.Size(171, 19)
        Me.lblBorrow.TabIndex = 4
        Me.lblBorrow.Text = "BORROWING HISTORY"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Teal
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.btnAdd.Location = New System.Drawing.Point(203, 94)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(108, 31)
=======
        Me.btnAdd.Location = New System.Drawing.Point(174, 76)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 25)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "ADD ITEM"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnBorrow
        '
        Me.btnBorrow.BackColor = System.Drawing.Color.Teal
        Me.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrow.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrow.ForeColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.btnBorrow.Location = New System.Drawing.Point(881, 91)
        Me.btnBorrow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(126, 31)
=======
        Me.btnBorrow.Location = New System.Drawing.Point(755, 74)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(108, 25)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.btnBorrow.TabIndex = 6
        Me.btnBorrow.Text = "BORROW ITEM"
        Me.btnBorrow.UseVisualStyleBackColor = False
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.lblSearch.Location = New System.Drawing.Point(15, 132)
=======
        Me.lblSearch.Location = New System.Drawing.Point(13, 107)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(57, 16)
        Me.lblSearch.TabIndex = 7
        Me.lblSearch.Text = "SEARCH :"
        '
        'txtSearchItems
        '
        Me.txtSearchItems.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.txtSearchItems.Location = New System.Drawing.Point(83, 128)
        Me.txtSearchItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchItems.Name = "txtSearchItems"
        Me.txtSearchItems.Size = New System.Drawing.Size(228, 21)
=======
        Me.txtSearchItems.Location = New System.Drawing.Point(71, 104)
        Me.txtSearchItems.Name = "txtSearchItems"
        Me.txtSearchItems.Size = New System.Drawing.Size(196, 21)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.txtSearchItems.TabIndex = 8
        '
        'txtSearchBorrow
        '
        Me.txtSearchBorrow.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.txtSearchBorrow.Location = New System.Drawing.Point(385, 126)
        Me.txtSearchBorrow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchBorrow.Name = "txtSearchBorrow"
        Me.txtSearchBorrow.Size = New System.Drawing.Size(179, 21)
=======
        Me.txtSearchBorrow.Location = New System.Drawing.Point(330, 102)
        Me.txtSearchBorrow.Name = "txtSearchBorrow"
        Me.txtSearchBorrow.Size = New System.Drawing.Size(154, 21)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.txtSearchBorrow.TabIndex = 10
        '
        'lblSearch1
        '
        Me.lblSearch1.AutoSize = True
        Me.lblSearch1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.lblSearch1.Location = New System.Drawing.Point(317, 129)
=======
        Me.lblSearch1.Location = New System.Drawing.Point(272, 105)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.lblSearch1.Name = "lblSearch1"
        Me.lblSearch1.Size = New System.Drawing.Size(57, 16)
        Me.lblSearch1.TabIndex = 9
        Me.lblSearch1.Text = "SEARCH :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label1.Location = New System.Drawing.Point(569, 129)
=======
        Me.Label1.Location = New System.Drawing.Point(488, 105)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
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
<<<<<<< HEAD
        Me.dtpFrom.Location = New System.Drawing.Point(695, 126)
        Me.dtpFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(97, 21)
=======
        Me.dtpFrom.Location = New System.Drawing.Point(596, 102)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(84, 21)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.dtpFrom.TabIndex = 12
        '
        'dtpTo
        '
        Me.dtpTo.CalendarFont = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.CustomFormat = "yyyy/MM/dd"
        Me.dtpTo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
<<<<<<< HEAD
        Me.dtpTo.Location = New System.Drawing.Point(814, 126)
        Me.dtpTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(94, 21)
=======
        Me.dtpTo.Location = New System.Drawing.Point(698, 102)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(81, 21)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.dtpTo.TabIndex = 13
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.Teal
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.btnFilter.Location = New System.Drawing.Point(916, 123)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(64, 30)
=======
        Me.btnFilter.Location = New System.Drawing.Point(785, 100)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(55, 24)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.btnFilter.TabIndex = 14
        Me.btnFilter.Text = "FILTER"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'lblDash
        '
        Me.lblDash.AutoSize = True
        Me.lblDash.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.lblDash.Location = New System.Drawing.Point(797, 129)
=======
        Me.lblDash.Location = New System.Drawing.Point(683, 105)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(12, 16)
        Me.lblDash.TabIndex = 15
        Me.lblDash.Text = "-"
        '
        'F_Inventory
        '
<<<<<<< HEAD
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1021, 645)
=======
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 524)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.Controls.Add(Me.lblDash)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearchBorrow)
        Me.Controls.Add(Me.lblSearch1)
        Me.Controls.Add(Me.txtSearchItems)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblBorrow)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.datBorrow)
        Me.Controls.Add(Me.datItems)
        Me.Controls.Add(Me.Panel1)
<<<<<<< HEAD
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
=======
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
>>>>>>> 0cc0851a47f557d2d9b122cfb02ce042dfa8eb44
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_Inventory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datBorrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents datItems As System.Windows.Forms.DataGridView
    Friend WithEvents datBorrow As System.Windows.Forms.DataGridView
    Friend WithEvents lblItems As System.Windows.Forms.Label
    Friend WithEvents lblBorrow As System.Windows.Forms.Label
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
End Class

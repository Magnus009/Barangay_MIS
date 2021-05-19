<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Mapping
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.pnlAssignOuter = New System.Windows.Forms.Panel()
        Me.pnlAssign = New System.Windows.Forms.Panel()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.datRecords = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSHouseholdNo = New System.Windows.Forms.TextBox()
        Me.txtSHouseNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLegends = New System.Windows.Forms.Label()
        Me.lblUnavailableColor = New System.Windows.Forms.Label()
        Me.lblUnavailable = New System.Windows.Forms.Label()
        Me.lblOccupiedColor = New System.Windows.Forms.Label()
        Me.lblOccupied = New System.Windows.Forms.Label()
        Me.lblAvailableColor = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ctxlot = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DivideLotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveLotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAssignOuter.SuspendLayout()
        Me.pnlAssign.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        CType(Me.datRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxlot.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBox
        '
        Me.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBox.Location = New System.Drawing.Point(0, 0)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(100, 50)
        Me.picBox.TabIndex = 0
        Me.picBox.TabStop = False
        Me.picBox.Visible = False
        '
        'pnlAssignOuter
        '
        Me.pnlAssignOuter.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlAssignOuter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAssignOuter.Controls.Add(Me.pnlAssign)
        Me.pnlAssignOuter.Location = New System.Drawing.Point(0, 408)
        Me.pnlAssignOuter.Name = "pnlAssignOuter"
        Me.pnlAssignOuter.Size = New System.Drawing.Size(516, 282)
        Me.pnlAssignOuter.TabIndex = 7
        '
        'pnlAssign
        '
        Me.pnlAssign.BackColor = System.Drawing.Color.White
        Me.pnlAssign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAssign.Controls.Add(Me.pnlSearch)
        Me.pnlAssign.Controls.Add(Me.lblLegends)
        Me.pnlAssign.Controls.Add(Me.lblUnavailableColor)
        Me.pnlAssign.Controls.Add(Me.lblUnavailable)
        Me.pnlAssign.Controls.Add(Me.lblOccupiedColor)
        Me.pnlAssign.Controls.Add(Me.lblOccupied)
        Me.pnlAssign.Controls.Add(Me.lblAvailableColor)
        Me.pnlAssign.Controls.Add(Me.lblAvailable)
        Me.pnlAssign.Controls.Add(Me.btnSearch)
        Me.pnlAssign.Location = New System.Drawing.Point(7, 9)
        Me.pnlAssign.Name = "pnlAssign"
        Me.pnlAssign.Size = New System.Drawing.Size(501, 263)
        Me.pnlAssign.TabIndex = 7
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.White
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearch.Controls.Add(Me.datRecords)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.Label4)
        Me.pnlSearch.Controls.Add(Me.Label2)
        Me.pnlSearch.Controls.Add(Me.txtSHouseholdNo)
        Me.pnlSearch.Controls.Add(Me.txtSHouseNo)
        Me.pnlSearch.Controls.Add(Me.Label1)
        Me.pnlSearch.Location = New System.Drawing.Point(158, 3)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(338, 253)
        Me.pnlSearch.TabIndex = 9
        '
        'datRecords
        '
        Me.datRecords.AllowUserToAddRows = False
        Me.datRecords.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datRecords.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(112, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datRecords.ColumnHeadersHeight = 30
        Me.datRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datRecords.Location = New System.Drawing.Point(16, 65)
        Me.datRecords.MultiSelect = False
        Me.datRecords.Name = "datRecords"
        Me.datRecords.ReadOnly = True
        Me.datRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datRecords.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datRecords.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datRecords.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.datRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datRecords.Size = New System.Drawing.Size(309, 180)
        Me.datRecords.TabIndex = 15
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(80, 33)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(248, 21)
        Me.txtSearch.TabIndex = 13
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "SEARCH :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(155, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "HOUSEHOLD No. :"
        '
        'txtSHouseholdNo
        '
        Me.txtSHouseholdNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSHouseholdNo.Location = New System.Drawing.Point(259, 7)
        Me.txtSHouseholdNo.Name = "txtSHouseholdNo"
        Me.txtSHouseholdNo.Size = New System.Drawing.Size(69, 21)
        Me.txtSHouseholdNo.TabIndex = 9
        Me.txtSHouseholdNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSHouseNo
        '
        Me.txtSHouseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSHouseNo.Location = New System.Drawing.Point(80, 7)
        Me.txtSHouseNo.Name = "txtSHouseNo"
        Me.txtSHouseNo.Size = New System.Drawing.Size(61, 21)
        Me.txtSHouseNo.TabIndex = 7
        Me.txtSHouseNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "HOUSE No. :"
        '
        'lblLegends
        '
        Me.lblLegends.AutoSize = True
        Me.lblLegends.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegends.Location = New System.Drawing.Point(45, 128)
        Me.lblLegends.Name = "lblLegends"
        Me.lblLegends.Size = New System.Drawing.Size(65, 16)
        Me.lblLegends.TabIndex = 10
        Me.lblLegends.Text = "LEGENDS"
        '
        'lblUnavailableColor
        '
        Me.lblUnavailableColor.AutoSize = True
        Me.lblUnavailableColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblUnavailableColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUnavailableColor.Location = New System.Drawing.Point(15, 200)
        Me.lblUnavailableColor.Name = "lblUnavailableColor"
        Me.lblUnavailableColor.Size = New System.Drawing.Size(19, 18)
        Me.lblUnavailableColor.TabIndex = 9
        Me.lblUnavailableColor.Text = "   "
        '
        'lblUnavailable
        '
        Me.lblUnavailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUnavailable.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnavailable.Location = New System.Drawing.Point(13, 198)
        Me.lblUnavailable.Name = "lblUnavailable"
        Me.lblUnavailable.Size = New System.Drawing.Size(129, 23)
        Me.lblUnavailable.TabIndex = 9
        Me.lblUnavailable.Text = "UNAVAILABLE"
        Me.lblUnavailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOccupiedColor
        '
        Me.lblOccupiedColor.AutoSize = True
        Me.lblOccupiedColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblOccupiedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOccupiedColor.Location = New System.Drawing.Point(15, 175)
        Me.lblOccupiedColor.Name = "lblOccupiedColor"
        Me.lblOccupiedColor.Size = New System.Drawing.Size(19, 18)
        Me.lblOccupiedColor.TabIndex = 8
        Me.lblOccupiedColor.Text = "   "
        '
        'lblOccupied
        '
        Me.lblOccupied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOccupied.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupied.Location = New System.Drawing.Point(13, 173)
        Me.lblOccupied.Name = "lblOccupied"
        Me.lblOccupied.Size = New System.Drawing.Size(129, 23)
        Me.lblOccupied.TabIndex = 8
        Me.lblOccupied.Text = "OCCUPIED"
        Me.lblOccupied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAvailableColor
        '
        Me.lblAvailableColor.AutoSize = True
        Me.lblAvailableColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblAvailableColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvailableColor.Location = New System.Drawing.Point(15, 150)
        Me.lblAvailableColor.Name = "lblAvailableColor"
        Me.lblAvailableColor.Size = New System.Drawing.Size(19, 18)
        Me.lblAvailableColor.TabIndex = 7
        Me.lblAvailableColor.Text = "   "
        '
        'lblAvailable
        '
        Me.lblAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvailable.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailable.Location = New System.Drawing.Point(13, 148)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(129, 23)
        Me.lblAvailable.TabIndex = 7
        Me.lblAvailable.Text = "AVAILABLE"
        Me.lblAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(3, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(152, 33)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(386, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        '
        'ctxlot
        '
        Me.ctxlot.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DivideLotToolStripMenuItem, Me.RemoveLotToolStripMenuItem})
        Me.ctxlot.Name = "ctxlot"
        Me.ctxlot.ShowImageMargin = False
        Me.ctxlot.Size = New System.Drawing.Size(128, 70)
        '
        'DivideLotToolStripMenuItem
        '
        Me.DivideLotToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivideLotToolStripMenuItem.Name = "DivideLotToolStripMenuItem"
        Me.DivideLotToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.DivideLotToolStripMenuItem.Text = "Divide Lot"
        '
        'RemoveLotToolStripMenuItem
        '
        Me.RemoveLotToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveLotToolStripMenuItem.Name = "RemoveLotToolStripMenuItem"
        Me.RemoveLotToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.RemoveLotToolStripMenuItem.Text = "Remove Lot"
        '
        'F_Mapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Brgy_36_MIS.My.Resources.Resources.Map
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(992, 690)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlAssignOuter)
        Me.Controls.Add(Me.picBox)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "F_Mapping"
        Me.Text = "F_Mapping"
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAssignOuter.ResumeLayout(False)
        Me.pnlAssign.ResumeLayout(False)
        Me.pnlAssign.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.datRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxlot.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBox As System.Windows.Forms.PictureBox
    Friend WithEvents pnlAssignOuter As System.Windows.Forms.Panel
    Friend WithEvents pnlAssign As System.Windows.Forms.Panel
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents datRecords As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSHouseholdNo As System.Windows.Forms.TextBox
    Friend WithEvents txtSHouseNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLegends As System.Windows.Forms.Label
    Friend WithEvents lblUnavailableColor As System.Windows.Forms.Label
    Friend WithEvents lblUnavailable As System.Windows.Forms.Label
    Friend WithEvents lblOccupiedColor As System.Windows.Forms.Label
    Friend WithEvents lblOccupied As System.Windows.Forms.Label
    Friend WithEvents lblAvailableColor As System.Windows.Forms.Label
    Friend WithEvents lblAvailable As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ctxlot As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DivideLotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveLotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

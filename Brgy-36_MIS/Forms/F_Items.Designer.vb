<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Items
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Items))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.txtItemID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.txtTotalQTY = New System.Windows.Forms.TextBox()
        Me.lblTotalQTY = New System.Windows.Forms.Label()
        Me.txtStocks = New System.Windows.Forms.TextBox()
        Me.lblStocks = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 47)
        Me.Panel1.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(18, 15)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(88, 19)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "ADD ITEMS"
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemID.Location = New System.Drawing.Point(19, 64)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(54, 17)
        Me.lblItemID.TabIndex = 1
        Me.lblItemID.Text = "ITEM ID :"
        '
        'txtItemID
        '
        Me.txtItemID.Location = New System.Drawing.Point(19, 84)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.ReadOnly = True
        Me.txtItemID.Size = New System.Drawing.Size(118, 20)
        Me.txtItemID.TabIndex = 2
        Me.txtItemID.Text = "- - -"
        Me.txtItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(19, 128)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(304, 41)
        Me.txtName.TabIndex = 4
        Me.txtName.Tag = "IN;Name/Description*"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(19, 108)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(129, 17)
        Me.lblItemName.TabIndex = 3
        Me.lblItemName.Text = "NAME/DESCRIPTION :"
        '
        'txtTotalQTY
        '
        Me.txtTotalQTY.Location = New System.Drawing.Point(19, 192)
        Me.txtTotalQTY.Name = "txtTotalQTY"
        Me.txtTotalQTY.Size = New System.Drawing.Size(147, 20)
        Me.txtTotalQTY.TabIndex = 6
        Me.txtTotalQTY.Tag = "IN;Total QTY*"
        '
        'lblTotalQTY
        '
        Me.lblTotalQTY.AutoSize = True
        Me.lblTotalQTY.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQTY.Location = New System.Drawing.Point(19, 172)
        Me.lblTotalQTY.Name = "lblTotalQTY"
        Me.lblTotalQTY.Size = New System.Drawing.Size(77, 17)
        Me.lblTotalQTY.TabIndex = 5
        Me.lblTotalQTY.Text = "TOTAL QTY  :"
        '
        'txtStocks
        '
        Me.txtStocks.Location = New System.Drawing.Point(176, 192)
        Me.txtStocks.Name = "txtStocks"
        Me.txtStocks.Size = New System.Drawing.Size(147, 20)
        Me.txtStocks.TabIndex = 8
        Me.txtStocks.Tag = "IN;Total Stocks*"
        '
        'lblStocks
        '
        Me.lblStocks.AutoSize = True
        Me.lblStocks.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStocks.Location = New System.Drawing.Point(175, 172)
        Me.lblStocks.Name = "lblStocks"
        Me.lblStocks.Size = New System.Drawing.Size(62, 17)
        Me.lblStocks.TabIndex = 7
        Me.lblStocks.Text = "STOCKS  :"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Teal
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(131, 227)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 41)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(229, 227)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 41)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'F_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(340, 281)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtStocks)
        Me.Controls.Add(Me.lblStocks)
        Me.Controls.Add(Me.txtTotalQTY)
        Me.Controls.Add(Me.lblTotalQTY)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.txtItemID)
        Me.Controls.Add(Me.lblItemID)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_Items"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblItemID As System.Windows.Forms.Label
    Friend WithEvents txtItemID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents txtTotalQTY As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalQTY As System.Windows.Forms.Label
    Friend WithEvents txtStocks As System.Windows.Forms.TextBox
    Friend WithEvents lblStocks As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class

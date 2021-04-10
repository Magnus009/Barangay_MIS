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
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.txtItemID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.txtTotalQTY = New System.Windows.Forms.TextBox()
        Me.lblTotalQTY = New System.Windows.Forms.Label()
        Me.txtStocks = New System.Windows.Forms.TextBox()
        Me.lblStocks = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemID.Location = New System.Drawing.Point(15, 12)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(54, 17)
        Me.lblItemID.TabIndex = 1
        Me.lblItemID.Text = "ITEM ID :"
        '
        'txtItemID
        '
        Me.txtItemID.Location = New System.Drawing.Point(15, 36)
        Me.txtItemID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.ReadOnly = True
        Me.txtItemID.Size = New System.Drawing.Size(137, 21)
        Me.txtItemID.TabIndex = 1
        Me.txtItemID.Text = "- - -"
        Me.txtItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(15, 91)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(354, 50)
        Me.txtName.TabIndex = 2
        Me.txtName.Tag = "IN;Name/Description*"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(15, 66)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(129, 17)
        Me.lblItemName.TabIndex = 3
        Me.lblItemName.Text = "NAME/DESCRIPTION :"
        '
        'txtTotalQTY
        '
        Me.txtTotalQTY.Location = New System.Drawing.Point(15, 169)
        Me.txtTotalQTY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalQTY.Name = "txtTotalQTY"
        Me.txtTotalQTY.Size = New System.Drawing.Size(171, 21)
        Me.txtTotalQTY.TabIndex = 3
        Me.txtTotalQTY.Tag = "IN;Total QTY*"
        '
        'lblTotalQTY
        '
        Me.lblTotalQTY.AutoSize = True
        Me.lblTotalQTY.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQTY.Location = New System.Drawing.Point(15, 145)
        Me.lblTotalQTY.Name = "lblTotalQTY"
        Me.lblTotalQTY.Size = New System.Drawing.Size(77, 17)
        Me.lblTotalQTY.TabIndex = 5
        Me.lblTotalQTY.Text = "TOTAL QTY  :"
        '
        'txtStocks
        '
        Me.txtStocks.Location = New System.Drawing.Point(198, 169)
        Me.txtStocks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStocks.Name = "txtStocks"
        Me.txtStocks.Size = New System.Drawing.Size(171, 21)
        Me.txtStocks.TabIndex = 4
        Me.txtStocks.Tag = "IN;Total Stocks*"
        '
        'lblStocks
        '
        Me.lblStocks.AutoSize = True
        Me.lblStocks.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStocks.Location = New System.Drawing.Point(197, 145)
        Me.lblStocks.Name = "lblStocks"
        Me.lblStocks.Size = New System.Drawing.Size(62, 17)
        Me.lblStocks.TabIndex = 7
        Me.lblStocks.Text = "STOCKS  :"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(137, 198)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 49)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblItemID)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.txtItemID)
        Me.Panel1.Controls.Add(Me.txtStocks)
        Me.Panel1.Controls.Add(Me.lblItemName)
        Me.Panel1.Controls.Add(Me.lblStocks)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.txtTotalQTY)
        Me.Panel1.Controls.Add(Me.lblTotalQTY)
        Me.Panel1.Location = New System.Drawing.Point(6, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 254)
        Me.Panel1.TabIndex = 1
        Me.Panel1.Tag = "Secondary"
        '
        'F_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 268)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Items"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Primary"
        Me.Text = "ITEMS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblItemID As System.Windows.Forms.Label
    Friend WithEvents txtItemID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents txtTotalQTY As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalQTY As System.Windows.Forms.Label
    Friend WithEvents txtStocks As System.Windows.Forms.TextBox
    Friend WithEvents lblStocks As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class

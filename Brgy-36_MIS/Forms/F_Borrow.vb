Public Class F_Borrow

    Private Sub F_Borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
        setGridHeader(True)

        strQuery = "SELECT * FROM M_BorrowStatus WHERE DeletedDate IS NULL"
        cboDataBinding(cboStatus, strQuery, "--STATUS--")
    End Sub

    Private Sub setGridHeader(blnNewRequest As Boolean)
        With datBorrowItems
            .Columns.Clear()
            .ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Bold)
            .ColumnHeadersHeight = 40
            If blnNewRequest Then
                .Columns.Add("colItemID", "ID")
                .Columns.Add("colItemName", "NAME")
                .Columns.Add("colBorrowedQTY", "BARROWED QTY")

                .Columns(0).Width = .Width * 0.3
                .Columns(1).Width = .Width * 0.5
                .Columns(2).Width = .Width * 0.2
                .AllowUserToAddRows = True
            Else
                .Columns.Add("colItemID", "ID")
                .Columns.Add("colItemName", "NAME")
                .Columns.Add("colBorrowedQTY", "BARROWED QTY")
                .Columns.Add("colReturnedQTY", "RETURNED QTY")

                Dim colStatus As New DataGridViewComboBoxColumn
                colStatus.HeaderText = "STATUS"
                colStatus.Name = "colStatus"

                strQuery = "SELECT ID, Description FROM M_ReturnStatus WHERE DeletedDate IS NULL"
                colStatus.DataSource = SQL_SELECT(strQuery).Tables(0)
                colStatus.DisplayMember = "Description"
                colStatus.ValueMember = "ID"
                .Columns.Add(colStatus)

                .Columns(0).Width = .Width * 0.2
                .Columns(1).Width = .Width * 0.3
                .Columns(2).Width = .Width * 0.15
                .Columns(3).Width = .Width * 0.15
                .Columns(4).Width = .Width * 0.2
            End If
            .AllowUserToAddRows = True
        End With
    End Sub

    Private Sub datBorrowItems_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datBorrowItems.CellDoubleClick

    End Sub
End Class
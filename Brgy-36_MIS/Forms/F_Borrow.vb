Public Class F_Borrow

    Private Sub F_Borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
        setGridHeader()

        strQuery = "SELECT * FROM M_BorrowStatus WHERE DeletedDate IS NULL"
        cboDataBinding(cboStatus, strQuery, "--STATUS--")
    End Sub

    Private Sub setGridHeader()
        With datBorrowItems
            .Columns.Clear()
            .ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Bold)

            .Columns.Add("colItemID", "ID")
            .Columns.Add("colItemName", "NAME")
            .Columns.Add("colBorrowedQTY", "QTY")

            .Columns(0).Width = .Width * 0.3
            .Columns(1).Width = .Width * 0.5
            .Columns(2).Width = .Width * 0.2
            .AllowUserToAddRows = True
        End With
    End Sub


End Class
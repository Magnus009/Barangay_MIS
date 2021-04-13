Public Class F_Borrow

    Private Sub F_Borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
        setGridHeader()
        loadItems()

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
        End With
    End Sub

    Private Sub loadItems(Optional strFilter As String = "")
        Dim dtItems As New DataTable

        With datItems
            .Columns.Clear()
            .ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Bold)

            strQuery = "SELECT II.ItemID 'ID', I.Description 'NAME', II.Stocks 'STOCKS' FROM M_ItemsInventory II" + vbCrLf
            strQuery += "INNER JOIN M_Items I ON II.ItemID = I.ItemID" + vbCrLf
            strQuery += "WHERE II.DeletedDate IS NULL" + vbCrLf
            If strFilter <> "" Then
                strQuery += "AND(II.ItemID LIKE '%%'" + vbCrLf
                strQuery += "OR I.Description LIKE '%%')"
            End If
            dtItems = SQL_SELECT(strQuery).Tables(0)

            datItems.DataSource = dtItems
            .Columns(0).Width = .Width * 0.3
            .Columns(1).Width = .Width * 0.5
            .Columns(2).Width = .Width * 0.2
        End With
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        Try
            Dim strItemID As String = datItems.CurrentRow.Cells("ID").Value
            Dim strItemName As String = datItems.CurrentRow.Cells("NAME").Value
            Dim intStocks As Integer = datItems.CurrentRow.Cells("STOCKS").Value
            Dim intItemRow As Integer
            Dim blnNew As Boolean = False

            If intStocks > 0 Then
                If datBorrowItems.RowCount > 0 Then
                    For intRow As Integer = 0 To datBorrowItems.RowCount - 1
                        If Not datBorrowItems.Rows(intRow).Cells("colItemID").Value.Equals(strItemID) Then
                            blnNew = True
                        End If
                    Next
                Else
addRow:
                    Dim row As String()
                    row = New String() {strItemID, strItemName, 1}
                    datBorrowItems.Rows.Add(row)
                End If

                If blnNew Then
                Else
                    datBorrowItems.Rows(intItemRow).Cells("colBorrowedQTY").Value = datBorrowItems.Rows(intItemRow).Cells("colBorrowedQTY").Value + 1
                End If


                datItems.CurrentRow.Cells("STOCKS").Value = datItems.CurrentRow.Cells("STOCKS").Value - 1
            Else
                Throw New Exception("Item has no Stocks left")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub moveItem(dgvFrom As DataGridView, dgvTo As DataGridView)
        Try
            Dim strItemID As String = dgvFrom.CurrentRow.Cells(0).Value
            Dim strItemName As String = dgvFrom.CurrentRow.Cells(1).Value
            Dim intQty As Integer = dgvFrom.CurrentRow.Cells(2).Value
            Dim intItemRow As Integer
            Dim blnNew As Boolean = False

            If intQty > 0 Then
                If dgvTo.RowCount > 0 Then
                    For intRow As Integer = 0 To datBorrowItems.RowCount - 1
                        If Not datBorrowItems.Rows(intRow).Cells("colItemID").Value.Equals(strItemID) Then
                            blnNew = True
                        End If
                    Next
                Else
addRow:
                    Dim row As String()
                    row = New String() {strItemID, strItemName, 1}
                    datBorrowItems.Rows.Add(row)
                End If

                If blnNew Then
                Else
                    datBorrowItems.Rows(intItemRow).Cells("colBorrowedQTY").Value = datBorrowItems.Rows(intItemRow).Cells("colBorrowedQTY").Value + 1
                End If


                datItems.CurrentRow.Cells("STOCKS").Value = datItems.CurrentRow.Cells("STOCKS").Value - 1
            Else
                Throw New Exception("Item has no Stocks left")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
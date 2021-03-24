Public Class F_Inventory
    Dim blnFIlter As Boolean
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        F_Items.ShowDialog()
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        F_BorrowItems.ShowDialog()
    End Sub

    Private Sub F_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getItems()
        Call getBorrowHistories()
    End Sub

    Public Sub getItems()
        Try
            Dim dsItems As New DataSet

            strQuery = ""
            strQuery += "SELECT I.ItemID, Description,TotalQTY,Stocks FROM M_Items I" & vbCrLf
            strQuery += "INNER JOIN M_ItemsInventory IV ON I.ItemID = IV.ItemID" & vbCrLf
            strQuery += "WHERE I.DeletedDate IS null" & vbCrLf
            If txtSearchItems.Text <> "" Then
                strQuery += "AND (I.ItemID LIKE '%" + txtSearchItems.Text + "%'" & vbCrLf
                strQuery += "OR I.Description LIKE '%" + txtSearchItems.Text + "%'" & vbCrLf
                strQuery += "OR TotalQTY LIKE '%" + txtSearchItems.Text + "%'" & vbCrLf
                strQuery += "OR Stocks LIKE '%" + txtSearchItems.Text + "%')" & vbCrLf
            End If
            dsItems = SQL_SELECT(strQuery)

            With datItems
                .Columns.Clear()
                .Columns.Add("colItemID", "ITEM ID") : .Columns("colItemID").Width = .Width * 0.3
                .Columns.Add("colName", "NAME") : .Columns("colName").Width = .Width * 0.3
                .Columns.Add("colTotalQTY", "TOTAL") : .Columns("colTotalQTY").Width = .Width * 0.15
                .Columns.Add("colStocks", "STOCKS") : .Columns("colStocks").Width = .Width * 0.15
                'btnView
                Dim btnView As New DataGridViewButtonColumn
                btnView.Width = .Width * 0.09
                btnView.Resizable = DataGridViewTriState.False
                btnView.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                btnView.Text = "•••"
                btnView.UseColumnTextForButtonValue = True
                .Columns.Add(btnView)

                For Each row As DataRow In dsItems.Tables(0).Rows
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = row.Item("ItemID")
                    .Rows(.RowCount - 1).Cells(1).Value = row.Item("Description")
                    .Rows(.RowCount - 1).Cells(2).Value = row.Item("TotalQTY")
                    .Rows(.RowCount - 1).Cells(3).Value = row.Item("Stocks")
                Next

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSearchItems_TextChanged(sender As Object, e As EventArgs) Handles txtSearchItems.TextChanged
        Call getItems()
    End Sub

    Private Sub datItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datItems.CellContentClick
        Try
            If e.ColumnIndex = 4 Then
                With F_Items
                    .txtItemID.Text = datItems.Rows(e.RowIndex).Cells(0).Value
                    .txtName.Text = datItems.Rows(e.RowIndex).Cells(1).Value
                    .txtTotalQTY.Text = datItems.Rows(e.RowIndex).Cells(2).Value
                    .txtStocks.Text = datItems.Rows(e.RowIndex).Cells(3).Value
                    .blnIsUpdate = True
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub getBorrowHistories()
        Try
            Dim dsBorrowHistory As New DataSet

            strQuery = ""
            strQuery += "SELECT BorrowCode,BorrowerName,inCharge,BH.ItemID,I.Description,QTY,BH.StatusID,S.Description AS Status,BorrowedDate,ReturnDate,isResidence  FROM T_BorrowHistory BH" & vbCrLf
            strQuery += "INNER JOIN M_Items I ON BH.ItemID = I.ItemID" & vbCrLf
            strQuery += "INNER JOIN M_BorrowStatus S ON BH.StatusID = S.ID" & vbCrLf
            strQuery += "WHERE BH.DeletedDate IS null" & vbCrLf
            If txtSearchBorrow.Text <> "" Then
                strQuery += "AND (BorrowCode LIKE '%" + txtSearchBorrow.Text + "%'" & vbCrLf
                strQuery += "OR BorrowerName LIKE '%" + txtSearchBorrow.Text + "%'" & vbCrLf
                strQuery += "OR inCharge LIKE '%" + txtSearchBorrow.Text + "%'" & vbCrLf
                strQuery += "OR I.Description LIKE '%" + txtSearchBorrow.Text + "%'" & vbCrLf
                strQuery += "OR QTY LIKE '%" + txtSearchBorrow.Text + "%'" & vbCrLf
                strQuery += "OR S.Description LIKE '%" + txtSearchBorrow.Text + "%')" & vbCrLf
            End If
            If blnFIlter Then
                strQuery += "AND BorrowedDate BETWEEN '" + Format(dtpFrom.Value, "yyyy/MM/dd") + " 0:00:00' and "
                strQuery += "'" + Format(dtpTo.Value, "yyyy/MM/dd") + " 0:00:00'"
            End If

            dsBorrowHistory = SQL_SELECT(strQuery)

            With datBorrow
                .Columns.Clear()
                .Columns.Add("colBorrowID", "CODE") : .Columns("colBorrowID").Width = .Width * 0.15
                .Columns.Add("colBorrower", "BORROWER") : .Columns("colBorrower").Width = .Width * 0.16
                .Columns.Add("colinCharge", "IN-CHARGE") : .Columns("colinCharge").Width = .Width * 0.16
                .Columns.Add("colItemID", "ITEM") : .Columns("colItemID").Visible = False
                .Columns.Add("colItem", "ITEM") : .Columns("colItem").Width = .Width * 0.1
                .Columns.Add("colqty", "QTY") : .Columns("colqty").Width = .Width * 0.05
                .Columns.Add("colstatusID", "STATUS") : .Columns("colstatusID").Visible = False
                .Columns.Add("colstatus", "STATUS") : .Columns("colstatus").Width = .Width * 0.08
                .Columns.Add("colBorrowDate", "BORROW DATE") : .Columns("colBorrowDate").Width = .Width * 0.12
                .Columns.Add("colReturnDate", "RETURN DATE") : .Columns("colReturnDate").Width = .Width * 0.12
                .Columns.Add("colisResident", "isResident") : .Columns("colisResident").Visible = False
                'btnView
                Dim btnView As New DataGridViewButtonColumn
                btnView.Width = .Width * 0.05
                btnView.Resizable = DataGridViewTriState.False
                btnView.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                btnView.Text = "•••"
                btnView.UseColumnTextForButtonValue = True
                .Columns.Add(btnView)

                For Each row As DataRow In dsBorrowHistory.Tables(0).Rows
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = row.Item("BorrowCode")
                    .Rows(.RowCount - 1).Cells(1).Value = row.Item("BorrowerName")
                    .Rows(.RowCount - 1).Cells(2).Value = row.Item("inCharge")
                    .Rows(.RowCount - 1).Cells(3).Value = row.Item("ItemID")
                    .Rows(.RowCount - 1).Cells(4).Value = row.Item("Description")
                    .Rows(.RowCount - 1).Cells(5).Value = row.Item("QTY")
                    .Rows(.RowCount - 1).Cells(6).Value = row.Item("StatusID")
                    .Rows(.RowCount - 1).Cells(7).Value = row.Item("Status")
                    .Rows(.RowCount - 1).Cells(8).Value = Format(row.Item("BorrowedDate"), "yyyy/MM/dd")
                    .Rows(.RowCount - 1).Cells(9).Value = Format(row.Item("ReturnDate"), "yyyy/MM/dd")
                    .Rows(.RowCount - 1).Cells(10).Value = row.Item("isResidence")
                Next

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSearchBorrow_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBorrow.TextChanged
        Call getBorrowHistories()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        blnFIlter = True
        Call getBorrowHistories()
    End Sub

    Private Sub datBorrow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datBorrow.CellContentClick
        If e.ColumnIndex = 11 Then
            With F_BorrowItems
                .txtCode.Text = datBorrow.Rows(e.RowIndex).Cells(0).Value
                .txtBorrower.Text = datBorrow.Rows(e.RowIndex).Cells(1).Value
                .txtIncharge.Text = datBorrow.Rows(e.RowIndex).Cells(2).Value
                .cboItems.SelectedValue = datBorrow.Rows(e.RowIndex).Cells(3).Value
                .txtQTY.Text = datBorrow.Rows(e.RowIndex).Cells(5).Value
                .cboStatus.SelectedValue = datBorrow.Rows(e.RowIndex).Cells(6).Value
                .dtpBorrowedDate.Text = datBorrow.Rows(e.RowIndex).Cells(8).Value
                .dtpReturnDate.Text = datBorrow.Rows(e.RowIndex).Cells(9).Value
                .chkisResident.Checked = datBorrow.Rows(e.RowIndex).Cells(10).Value
                .blnisUpdate = True
                .ShowDialog()
            End With
        End If
    End Sub
End Class
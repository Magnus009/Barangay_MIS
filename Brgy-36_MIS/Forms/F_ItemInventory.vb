Public Class F_ItemInventory

    Private Sub F_ItemInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            formLoadSetup(Me)
            loadItems()
            modifyMode(False)
            strQuery = "SELECT * FROM M_ItemType WHERE DeletedDate IS NULL"
            cboDataBinding(cboType, strQuery, "---")

            AddHandler txtTotal.KeyPress, AddressOf numericOnly
            AddHandler txtStocks.KeyPress, AddressOf numericOnly
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub modifyMode(blnModify As Boolean)
        Try
            If blnModify Then
                txtItemName.ReadOnly = False
                cboType.Enabled = True
                txtDescription.ReadOnly = False
                txtTotal.ReadOnly = False
                txtStocks.ReadOnly = False
            Else
                txtItemName.ReadOnly = True
                cboType.Enabled = False
                txtDescription.ReadOnly = True
                txtTotal.ReadOnly = True
                txtStocks.ReadOnly = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub loadItems()
        Try
            Dim dtItems As New DataTable

            strQuery = "SELECT I.ItemID [ID], I.ItemName [NAME], IT.Description [TYPE] FROM M_Items I" + vbCrLf
            strQuery += "LEFT JOIN M_ItemsInventory II ON I.ItemID = II.ItemID" + vbCrLf
            strQuery += "INNER JOIN M_ItemType IT ON I.ItemTypeID = IT.ID" + vbCrLf
            If txtSearch.Text <> "" Then
                strQuery += "WHERE I.ItemID LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                strQuery += "OR I.ItemName LIKE '%" + txtSearch.Text + "%'" + vbCrLf
                strQuery += "OR IT.Description LIKE '%" + txtSearch.Text + "%'" + vbCrLf
            End If

            dtItems = SQL_SELECT(strQuery).Tables(0)
            datItems.DataSource = dtItems

            With datItems
                .Columns(0).Width = .Width * 0.25
                .Columns(1).Width = .Width * 0.54
                .Columns(2).Width = .Width * 0.2
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub loadItemDetails(strItemCode As String)
        Dim dtItems As New DataTable

        strQuery = "SELECT I.ItemID, I.ItemTypeID, I.ItemName, I.Description, IT.TotalQTY, IT.Stocks FROM M_Items I" + vbCrLf
        strQuery += "LEFT JOIN M_ItemsInventory IT ON I.ItemID = IT.ItemID" + vbCrLf
        strQuery += "WHERE I.ItemID = '" + strItemCode + "'" + vbCrLf
        dtItems = SQL_SELECT(strQuery).Tables(0)

        With dtItems
            If .Rows.Count <> 0 Then
                txtItemID.Text = .Rows(0)("ItemID")
                txtItemName.Text = .Rows(0)("ItemName")
                txtDescription.Text = .Rows(0)("Description")
                cboType.SelectedValue = .Rows(0)("ItemTypeID")
                txtTotal.Text = .Rows(0)("TotalQTY")
                txtStocks.Text = .Rows(0)("Stocks")
            End If
        End With
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If btnUpdate.Text = "UPDATE" Then
                btnUpdate.Text = "SAVE"
                btnUpdate.BackColor = Color.Green
                btnAdd.Visible = False
                modifyMode(True)
            Else
                saveItem()
                loadItems()
                btnUpdate.Text = "UPDATE"
                btnUpdate.BackColor = My.Settings.Primary
                btnAdd.Visible = True
                modifyMode(False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            btnUpdate.Text = "ADD"
            btnUpdate.BackColor = Color.Green
            btnAdd.Visible = False

            txtItemName.Text = ""
            cboType.SelectedValue = -1
            txtDescription.Text = ""
            txtTotal.Text = ""
            txtStocks.Text = ""

            modifyMode(True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub saveItem()
        Try
            If btnUpdate.Text = "ADD" Then
                Dim strItemCode As String
                strQuery = "SELECT dbo.fn_colID ('I')"
                strItemCode = SQL_SELECT(strQuery).Tables(0).Rows(0)(0)

                strQuery = "INSERT INTO M_Items (ItemID, ItemTypeID, ItemName, Description, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                strQuery += "VALUES ('" + strItemCode + "'," + vbCrLf
                strQuery += cboVal(cboType) + "," + vbCrLf
                strQuery += "'" + txtItemName.Text + "',"
                strQuery += "'" + txtDescription.Text + "'," + vbCrLf
                strQuery += "getdate(), getdate(), '" + UserName + "')"

                If SQL_EXECUTE(strQuery) Then
                    strQuery = "INSERT INTO M_ItemsInventory (ItemID, TotalQTY, Stocks, CreatedDate, UpdatedDate, UpdatedBy)" + vbCrLf
                    strQuery += "VALUES ('" + strItemCode + "', " + vbCrLf
                    strQuery += txtTotal.Text + ", " + vbCrLf
                    strQuery += txtStocks.Text + ", " + vbCrLf
                    strQuery += "getdate(), getdate(), '" + UserName + "')"
                    If SQL_EXECUTE(strQuery) Then
                        MsgBox("Item successfully added!", MsgBoxStyle.Information, "Add Item")
                    End If
                End If
            Else
                strQuery = "UPDATE M_Items" + vbCrLf
                strQuery += " SET ItemTypeID = " + cboVal(cboType) + "," + vbCrLf
                strQuery += "ItemName = '" + txtItemName.Text + "'," + vbCrLf
                strQuery += "Description = '" + txtDescription.Text + "'," + vbCrLf
                strQuery += "UpdatedDate = getdate()," + vbCrLf
                strQuery += "UpdatedBy = '" + UserName + "'" + vbCrLf
                strQuery += "WHERE ItemID = '" + txtItemID.Text + "'"

                If SQL_EXECUTE(strQuery) Then
                    strQuery = "UPDATE M_ItemsInventory" + vbCrLf
                    strQuery += "SET TotalQTY = " + txtTotal.Text + "," + vbCrLf
                    strQuery += "	Stocks = " + txtStocks.Text + "," + vbCrLf
                    strQuery += "UpdatedDate = getdate()," + vbCrLf
                    strQuery += "UpdatedBy = '" + UserName + "'" + vbCrLf
                    strQuery += "WHERE ItemID = '" + txtItemID.Text + "'"
                    If SQL_EXECUTE(strQuery) Then
                        MsgBox("Item update successfully!", MsgBoxStyle.Information, "Update Item")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub datItems_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles datItems.RowEnter
        Try
            Dim strItemCode As String
            strItemCode = datItems.Rows(e.RowIndex).Cells("ID").Value
            loadItemDetails(strItemCode)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            loadItems()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
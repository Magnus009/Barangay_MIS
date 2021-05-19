Imports Microsoft.Reporting.WinForms

Public Class F_PrintInventoryReport

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim dtInvent As New DataTable
            Dim frmInventReport As New F_InventoryReport

            strQuery = "SELECT BH.BorrowCode, BH.BorrowerName,I.ItemName,BD.QTY, BS.Description [Status], BorrowedDate, ReturnDate  FROM T_BorrowHeader BH" & vbCrLf
            strQuery += "INNER JOIN T_BorrowDetails BD ON BH.BorrowCode = BD.BorrowCode" & vbCrLf
            strQuery += "INNER JOIN M_Items I ON BD.ItemID = I.ItemID" & vbCrLf
            strQuery += "INNER JOIN M_BorrowStatus BS ON BH.StatusID = BS.ID" & vbCrLf
            dtInvent = SQL_SELECT(strQuery).Tables(0)

            With frmInventReport
                .rpvInventoryReport.LocalReport.DataSources.Clear()
                .rpvInventoryReport.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsInventory", dtInvent))
                .rpvInventoryReport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                .rpvInventoryReport.ZoomMode = ZoomMode.Percent
                .rpvInventoryReport.ZoomPercent = 100
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub getInventory()
        Try
            Dim dtInvent As New DataTable

            strQuery = "SELECT BH.BorrowCode [CODE], BH.BorrowerName [BORROWER],I.ItemName [ITEM],BD.QTY, BS.Description [Status], BorrowedDate, ReturnDate  FROM T_BorrowHeader BH" & vbCrLf
            strQuery += "INNER JOIN T_BorrowDetails BD ON BH.BorrowCode = BD.BorrowCode" & vbCrLf
            strQuery += "INNER JOIN M_Items I ON BD.ItemID = I.ItemID" & vbCrLf
            strQuery += "INNER JOIN M_BorrowStatus BS ON BH.StatusID = BS.ID" & vbCrLf
            dtInvent = SQL_SELECT(strQuery).Tables(0)

            datInventory.DataSource = dtInvent

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub F_PrintInventoryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
        getInventory()
    End Sub
End Class
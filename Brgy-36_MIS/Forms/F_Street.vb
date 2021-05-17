Public Class F_Street

    Private Sub F_Street_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        loadStreetData()
    End Sub

    Private Sub F_Street_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            formLoadSetup(Me)
            loadStreetData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub loadStreetData()
        Dim dtStreet As New DataTable("Samahan")

        strQuery = "SELECT ID, Name FROM M_Street" + vbCrLf
        strQuery += "WHERE DeletedDate IS NULL" + vbCrLf
        If txtSearch.Text <> "" Then
            strQuery += "AND Name LIKE '%" + txtSearch.Text + "%'"
        End If

        With datStreet
            .Columns.Clear()
            dtStreet = SQL_SELECT(strQuery).Tables(0)
            .DataSource = dtStreet
            .Columns(0).Width = .Width * 0.25
            .Columns(1).Width = .Width * 0.73
        End With
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadStreetData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmStreet As New F_AddStreet
        frmStreet.ShowDialog()
    End Sub
End Class
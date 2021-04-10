Public Class F_Samahan

    Private Sub F_Samahan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        loadSamahanData()
    End Sub

    Private Sub F_Samahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            formLoadSetup(Me)
            loadSamahanData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub loadSamahanData()
        Dim dtSamahan As New DataTable("Samahan")

        strQuery = "SELECT ID, Title, Description FROM M_Samahan" + vbCrLf
        strQuery += "WHERE DeletedDate IS NULL" + vbCrLf
        If txtSearch.Text <> "" Then
            strQuery += "AND Title LIKE '%" + txtSearch.Text + "%'"
        End If

        With datSamahan
            .Columns.Clear()
            dtSamahan = SQL_SELECT(strQuery).Tables(0)
            .DataSource = dtSamahan
            .Columns(0).Visible = False
            .Columns(1).Width = .Width * 0.25
            .Columns(2).Width = .Width * 0.6

            Dim btnView As New DataGridViewButtonColumn
            btnView.Text = "•••"
            btnView.UseColumnTextForButtonValue = True
            .Columns.Add(btnView)
            .Columns(3).Width = .Width * 0.12
        End With
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim formAddSamahan As New F_AddSamahan
        formAddSamahan.ShowDialog()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadSamahanData()
    End Sub

    Private Sub datSamahan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datSamahan.CellContentClick
        If e.ColumnIndex = 3 Then
            Dim formAddSamahan As New F_AddSamahan
            formAddSamahan.loadSamahan(datSamahan.Rows(e.RowIndex).Cells(0).Value)
        End If
    End Sub
End Class
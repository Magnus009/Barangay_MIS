Public Class F_UserAccounts

    Private Sub F_UserAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            formLoadSetup(Me)
            loadUserLevels()
            loadAccounts()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub loadUserLevels()
        strQuery = "SELECT ID, Description FROM M_UserLevel WHERE DeletedDate IS NULL"
        cboDataBinding(cboLevels, strQuery, "ALL")
        AddHandler cboLevels.SelectedValueChanged, AddressOf levelFilter
    End Sub

    Private Sub loadAccounts()
        Dim dtAccounts As New DataTable("Accounts")

        strQuery = "SELECT A.UserID, A.UserName 'NAME', A.Password 'PASSWORD', L.Description 'LEVEL', A.isActive, A.CreatedDate 'REGISTERED DATE', A.DeletedDate FROM M_UserAccounts A" + vbCrLf
        strQuery += "INNER JOIN M_UserLevel L ON A.UserLevel = L.ID" + vbCrLf
        If txtSearch.Text <> "" Then
            strQuery += "AND A.UserName LIKE '%" + txtSearch.Text + "%'" + vbCrLf
        End If

        If Not cboLevels.SelectedValue = -1 Then
            strQuery += "AND A.UserLevel = " + cboLevels.SelectedValue.ToString
        End If

        With datAccounts
            .Columns.Clear()
            dtAccounts = SQL_SELECT(strQuery).Tables(0)
            .DataSource = dtAccounts
            .Columns(0).Visible = False
            .Columns(1).Width = .Width * 0.25
            .Columns(2).Width = .Width * 0.25
            .Columns(3).Width = .Width * 0.2
            .Columns(4).Visible = False
            .Columns(5).Width = .Width * 0.2
            .Columns(6).Visible = False

            Dim btnView As New DataGridViewButtonColumn
            btnView.Text = "•••"
            btnView.UseColumnTextForButtonValue = True
            .Columns.Add(btnView)
            .Columns(7).Width = .Width * 0.08
        End With
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadAccounts()
    End Sub

    Private Sub levelFilter(sender As Object, e As EventArgs)
        loadAccounts()
    End Sub
End Class
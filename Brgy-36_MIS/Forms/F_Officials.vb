Public Class F_Officials

    Private Sub F_Officials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadSetup(Me)
    End Sub

    Private Sub btnResidentList_Click(sender As Object, e As EventArgs) Handles btnResidentList.Click
        Dim frmResidentList As New F_SelectionList

        AddHandler frmResidentList.selectedResident, AddressOf loadResidentsInfo
        frmResidentList.loadSelection(1)
    End Sub

    Private Sub loadResidentsInfo(ByVal strResidentID As String)
        Try
            MsgBox(strResidentID)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
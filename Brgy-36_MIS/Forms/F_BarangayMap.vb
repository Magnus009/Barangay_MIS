
Public Class F_BarangayMap

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        Try
            For Each ctrl As Control In Me.Controls
                If ctrl.GetType() = GetType(Label) Then
                    Dim lbl As New Label
                    lbl = ctrl

                    Select Case UCase(lbl.Tag)
                        Case "AVAILABLE"
                            lbl.BackColor = Color.Green
                        Case "OCCUPIED"
                            lbl.BackColor = Color.Orange
                        Case Else
                            lbl.BackColor = Color.Gray
                    End Select
                    AddHandler lbl.Click, AddressOf AssignHouse
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub AssignHouse(sender As Object, e As EventArgs)
        Try
            Dim lblSlot As New Label
            lblSlot = sender

            If UCase(lblSlot.Tag).Equals("AVAILABLE") Then
                Dim msgDialog As DialogResult
                msgDialog = MsgBox("Do you want to Assign household in this Lot?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "REMOVE FILE")

                If msgDialog = Windows.Forms.DialogResult.Yes Then
                    Dim frmHouseList As New F_SelectionList

                    AddHandler frmHouseList.selectedHouseNo, AddressOf loadHouseholdDetails
                    frmHouseList.loadSelection(0)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub loadHouseholdDetails(ByVal strHouseNo As String, ByVal strHouseholdNo As String)
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
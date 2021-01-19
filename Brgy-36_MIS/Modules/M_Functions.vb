﻿Module M_Functions
    Public strRequire As String

    Public Sub fn_ClearField(container As Form)
        On Error GoTo errClear
        For Each ctrl As Control In container.Controls
            Select Case ctrl.GetType()
                Case GetType(TextBox)
                    ctrl.Text = ""
                Case GetType(GroupBox)
                    groupControls(ctrl)
                Case GetType(Label)
                    'No Event
                Case GetType(ComboBox)
                    Dim cbo As New ComboBox
                    cbo = ctrl
                    cbo.SelectedIndex = -1
                Case Else
                    'No Event
            End Select
        Next
errClear:
        If Err.Number <> 0 Then
            MsgBox(Err.Number & "-->" & Err.Description, MsgBoxStyle.Critical, "Invalid Action")
        End If
    End Sub

    Private Sub groupControls(group As GroupBox)
        For Each ctrl As Control In group.Controls
            Select Case ctrl.GetType()
                Case GetType(Label)
                    'No Event
                Case GetType(TextBox)
                    ctrl.Text = ""
                Case GetType(MaskedTextBox)
                    ctrl.ResetText()
                Case GetType(ComboBox)
                    Dim cbo As New ComboBox
                    cbo = ctrl
                    cbo.SelectedIndex = -1
                Case GetType(GroupBox)
                    groupControls(ctrl)
                Case Else
                    'No Event
            End Select
        Next
    End Sub

    Public Function subCheckRequire(container As Control) As Boolean
        For Each ctrl As Control In container.Controls
            Select Case ctrl.GetType()
                Case GetType(GroupBox)
                    subCheckRequire(ctrl)
                Case Else
                    If Left(ctrl.Tag, 1) = "*" Then
                        If ctrl.Text = "" Then
                            strRequire &= "- " & Mid(ctrl.Tag, 2, Len(ctrl.Tag) - 1) & vbCrLf
                        End If
                    End If
            End Select
        Next
        If strRequire <> "" Then Return True
    End Function
End Module

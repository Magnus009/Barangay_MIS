Imports System
Module M_Handler
    Public Sub GlobalException_Handler(ByVal sender As Object, ByVal exArgs As UnhandledExceptionEventArgs)
        Dim ex As Exception = DirectCast(exArgs.ExceptionObject, Exception)
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Barangay MIS")
    End Sub
End Module

Public Class App

End Class

Public Class MiAplicacion
    Public Property IDAplication() As String
    Public Property Name() As String
    Public Property DataSore() As String
    Public Property Settings() As String
    Public Property Log() As String
End Class

Public Class MiSession
    Public Property keyusu As Integer
    Public Property Status As String
    Public Property App As New MiAplicacion
End Class
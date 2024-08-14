Public Class WorkBackground
    'Eventos que usará el componente para comunicar valores al formulario
    Public Event MsgWork(ByVal sAcción As String, ByVal sKey As String, ByVal sMensaje As String)
    Public Sub Transf(ByVal Acc As String, ByVal Key As String, ByVal Val As String)
        RaiseEvent MsgWork(Acc, Key, Val)
    End Sub

End Class

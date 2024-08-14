Imports Security_System
Public Class Settings
    Public Shared Function Setting(ByVal SGSetting As String, ByVal Tipo As TypeVal) As Object
        Dim oSql As New SQLSettings(oUsr)
        Dim oCs As New ColeccionPrmSql
        Setting = String.Empty
        Try
            Dim oValor As Object = Nothing
            oValor = oSql._Valor(oSql.Item, IIf(Tipo = TypeVal.Texto, "SGSettingValorTexto", "SGSettingValorFecha"), oCs)
            If oValor Is Nothing Then
                oValor = String.Empty
            End If
            Return oValor

        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Function

End Class
Public Enum TypeVal
    Texto = 1
    Fecha = 2
End Enum

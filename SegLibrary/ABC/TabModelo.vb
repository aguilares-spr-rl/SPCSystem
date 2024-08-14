Imports Security_System
Public Class TabModelo

End Class

Public Class Usuario
    Public Property r As New ColeccionPrmSql
    Public Property Accion As String

    Public Sub New()

    End Sub
    Public Sub New(ByVal Acc As String, ByVal ID As Integer, ByVal UserName As String, ByVal Email As String, ByVal Alta As Date, ByVal Password As String, ByVal Nombre As String, ByVal Apellidos As String, ByVal ErpHost As String, ByVal ErpUsr As String, ByVal ErpPwd As String)
        r.Create("@SgUserID", ID)
        r.Create("@SgUserName", UserName)
        r.Create("@SgUserEmail", Email)
        r.Create("@SgUserPasswd", Password)
        r.Create("@SgNombre", Nombre)
        r.Create("@SgApellidos", Apellidos)
        r.Create("@SgUserAlta", Alta)
        r.Create("@ModifiUserID", oUsr.UserID)
        r.Create("@ModifiDate", Now)
        r.Create("@ErpHost", ErpHost)
        r.Create("@ErpUser", ErpUsr)
        r.Create("@ErpPasswd", ErpPwd)
        Accion = Acc
    End Sub
    Public Function Save() As Boolean
        Dim oSql As New SgUsuarios(oUsr)
        Save = False
        Try
            Dim oTb As DataTable = oSql._Item(oSql.Item, "SGUSUARIOS", r)
            If Not oTb Is Nothing Then
                Select Case Accion
                    Case "Ins"
                        Return oSql.StatemenInsert(oTb)
                    Case "Upd"
                        If oTb.Rows.Count > 0 Then
                            oTb.Columns.Item("SgUserID").Unique = True
                            For Each Dr As DataRow In oTb.Rows
                                For Each Col In oTb.Columns
                                    If Not Col.Unique And Not r.ItemValue("@" + Col.ToString) Is Nothing Then
                                        Dr(Col) = r.ItemValue("@" + Col.ToString)
                                    End If
                                Next
                            Next
                            Return oSql.StatemenUpdate(oTb)
                        End If
                    Case "Del"
                        If oTb.Rows.Count > 0 Then
                            Return oSql.StatemenDelete(oTb)
                        End If
                End Select
            End If
        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Function

End Class

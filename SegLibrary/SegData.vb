Imports Security_System
Imports System.Windows.Forms
Public Class SegData
    Public Function InstanciaFrm(ByVal cUser As MySession, ByVal formParent As Form) As Object
        InstanciaFrm = Nothing
        Try
            Dim asm As System.Reflection.Assembly
            oUsr = cUser
            asm = Reflection.Assembly.GetExecutingAssembly()

            Select Case FunctionName(oUsr.CurrentFunction)
                Case "SGESTRUCTURAMENU"
                    InstanciaFrm = New frmEstructuraMenu(oUsr.CurrentFunction, formParent, oUsr)
                Case "SGPERFILES"
                    InstanciaFrm = New frmPerfiles(oUsr.CurrentFunction, formParent, oUsr)
                Case "SGMODULOS"
                    InstanciaFrm = New frmModulos(oUsr.CurrentFunction, formParent, oUsr)
                Case "SGFUNCIONES"
                    InstanciaFrm = New frmFunciones(oUsr.CurrentFunction, formParent, oUsr)
                Case "SGUSUARIOS"
                    InstanciaFrm = New frmUsuarios(oUsr.CurrentFunction, formParent, oUsr)
                Case "SGSETTINGSC"
                    InstanciaFrm = New frmSettings(oUsr.CurrentFunction, formParent, oUsr)
                Case Else
            End Select

        Catch ex As Exception
            Dim s As String = ex.Message
        End Try
    End Function
    Public Function FunctionName(ByVal id As Integer) As String
        Dim oSql As New SQLFuncion(oUsr)
        Dim oCs As New ColeccionPrmSql
        oCs.Create("@SGFuncionID", id)
        FunctionName = String.Empty
        Try
            Dim oTb As DataTable = oSql._Item(oSql.Item, "FUNCION", oCs)
            If Not oTb Is Nothing Then
                For Each Dr As DataRow In oTb.Rows
                    FunctionName = Dr("SGFuncionNombre").ToString
                    Exit For
                Next
            End If
        Catch ex As Exception
            Dim s As String = ex.Message
        End Try

    End Function
End Class

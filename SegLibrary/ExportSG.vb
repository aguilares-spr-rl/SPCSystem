Imports Security_System
Imports System.Windows.Forms
Public Class ExportSG

    Public Function Export() As Boolean
        Dim oSql As New SQLSg(oUsr)
        Dim oCs As New ColeccionPrmSql
        Dim Ds As New DataSet
        Export = False
        Try
            oSql.GetQry(Ds, "SGESTRUCTURAMENU", oSql.ListEstructuras, oCs)
            oSql.GetQry(Ds, "SGMODULOS", oSql.ListModulos, oCs)
            oSql.GetQry(Ds, "SGFUNCIONES", oSql.ListFunciones, oCs)
            oSql.GetQry(Ds, "SGESTRUCTURASM_DETALLE", oSql.ListEstructurasDetalle, oCs)
            oSql.GetQry(Ds, "SGFUNCIONESMODULO", oSql.ListFuncionesModulos, oCs)
            oSql.GetQry(Ds, "SGPERFILES", oSql.ListPerfiles, oCs)
            oSql.GetQry(Ds, "SGPERFILESDETALLE", oSql.ListPerfilesDetalle, oCs)

            Dim sFileName = My.Computer.FileSystem.CombinePath(Application.StartupPath, "../Export/Funcionalidad.xml")
            Ds.WriteXml(sFileName, XmlWriteMode.WriteSchema)
            Return True

        Catch ex As Exception
            Dim s As String = ex.Message
        End Try
    End Function

    Public Function Import(ByRef Ds As DataSet) As Boolean
        Dim oSql As New SQLSg(oUsr)
        Dim oCs As New ColeccionPrmSql
        Dim bExito As Boolean = True
        Import = False
        Try
            For Each oTb As DataTable In Ds.Tables
                bExito = bExito And oSql.StatemenInsert(oTb, "IZ_" + oTb.TableName)
            Next
            If bExito Then
                Return oSql.ExecuteStore("SP_IFUNCIONALIDAD", oCs)
            End If
        Catch ex As Exception
            Dim s As String = ex.Message
        End Try
    End Function

End Class
Public Class SQLSg
    Inherits Sql
    Private m_sLog As String
    Private Ds As New DataSet
    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub
    Public ReadOnly Property ListEstructuras
        Get
            Return " SELECT * FROM SGESTRUCTURAMENU "
        End Get
    End Property
    Public ReadOnly Property ListModulos
        Get
            Return " SELECT * FROM SGMODULOS "
        End Get
    End Property
    Public ReadOnly Property ListFunciones
        Get
            Return " SELECT * FROM SGFUNCIONES "
        End Get
    End Property
    Public ReadOnly Property ListEstructurasDetalle
        Get
            Return " SELECT * FROM SGESTRUCTURASM_DETALLE "
        End Get
    End Property
    Public ReadOnly Property ListFuncionesModulos
        Get
            Return " SELECT * FROM SGFUNCIONESMODULO "
        End Get
    End Property
    Public ReadOnly Property ListPerfiles
        Get
            Return " SELECT * FROM SGPERFILES "
        End Get
    End Property
    Public ReadOnly Property ListPerfilesDetalle
        Get
            Return " SELECT * FROM SGPERFILESDETALLE "
        End Get
    End Property
End Class

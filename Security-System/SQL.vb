Imports System.Data.SqlClient
Imports System.Data
Imports System.Xml
Imports System
Imports System.IO
Imports System.Configuration
Imports System.Configuration.ConfigurationManager
Imports System.Net.Mail
Imports System.Net.Mail.SmtpClient

Public Class SQL
    Private Cn As New SqlClient.SqlConnection
    Private Qy As New SqlClient.SqlCommand
    Private SQLAdapter As SqlDataAdapter
    Private m_oUsr As New MySession
    Private m_strCnx As String

    Private Function OpenDataBase(ByVal sCnx As String) As SqlConnection
        Dim Cnx As New SqlConnection(sCnx)
        OpenDataBase = Nothing
        Try
            Cnx.Open()
            If (Cnx.State = ConnectionState.Open) Then
                If SetLanguage(Cnx, "ESPAÑOL") Then
                    Return Cnx
                End If
            End If

        Catch ex As Exception
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
        End Try

    End Function

    Private Function SetLanguage(ByRef Cn As SqlConnection, ByVal sIdioma As String) As Boolean
        Dim sStatement As String
        Try

            sStatement = "SET LANGUAGE @IDIOMA"
            sStatement = sStatement.Replace("@IDIOMA", sIdioma)
            Dim Qy As New SqlCommand(sStatement, Cn)
            Qy.CommandType = CommandType.Text

            Qy.ExecuteNonQuery()
            Qy.Dispose()

            Return True

        Catch ex As Exception
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
            Return False

        End Try

    End Function

    Private Function QryLinkDB(ByVal sDataBase As String, ByVal sStatement As String) As String
        sDataBase = sDataBase & ".dbo."
        sStatement = Replace(sStatement, "@DB_", sDataBase)
        Return sStatement
    End Function

    Public Function TestingConn() As String
        TestingConn = String.Empty
        Try
            Cn = OpenDataBase(m_strCnx)
            If Cn.State = ConnectionState.Open Then
                TestingConn = Cn.DataSource & "@" & Cn.Database & "@" & Cn.WorkstationId
            End If
        Catch ex As Exception
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
        Finally
            Cn.Close()
        End Try

    End Function

    Public Sub New(ByVal oUsr As MySession, Optional ByVal iDst As Integer = -1)
        m_oUsr = oUsr

        If iDst >= 0 Then
            Dim Cnx As String = oUsr.App.OthersDataStore(iDst).StringCnxSQL
            Dim Cnb As System.Data.SqlClient.SqlConnectionStringBuilder = New System.Data.SqlClient.SqlConnectionStringBuilder(Cnx)
            Cnb.DataSource = oUsr.App.OthersDataStore(iDst).Source
            Cnb.InitialCatalog = oUsr.App.OthersDataStore(iDst).DataBase
            Cnb.Password = oUsr.App.OthersDataStore(iDst).Password
            Cnb.UserID = oUsr.App.OthersDataStore(iDst).User
            m_strCnx = Cnb.ToString
        Else
            Dim Cnx As String = oUsr.App.DataStore.StringCnxSQL
            Dim Cnb As System.Data.SqlClient.SqlConnectionStringBuilder = New System.Data.SqlClient.SqlConnectionStringBuilder(Cnx)
            Cnb.DataSource = oUsr.App.DataStore.Source
            Cnb.InitialCatalog = oUsr.App.DataStore.DataBase
            Cnb.Password = oUsr.App.DataStore.Password
            Cnb.UserID = oUsr.App.DataStore.User
            m_strCnx = Cnb.ToString
        End If

    End Sub

    Public Function _Lista(ByVal sQry As String, ByVal sTabla As String, ByVal oCs As ColeccionPrmSql) As DataTable
        Dim Ds As New DataSet
        _Lista = Nothing
        Try
            If GetQry(Ds, sTabla, sQry, oCs) Then
                Return Ds.Tables(sTabla)
            End If

        Catch ex As Exception
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
        End Try
    End Function

    Public Function _Item(ByVal sQry As String, ByVal sTabla As String, ByVal oCs As ColeccionPrmSql) As DataTable
        Dim Ds As New DataSet
        _Item = Nothing
        Try
            If GetQry(Ds, sTabla, sQry, oCs) Then
                Return Ds.Tables(sTabla)
            End If

        Catch ex As Exception
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
        End Try
    End Function

    Public Function _Valor(ByVal sQry As String, ByVal sField As String, ByVal oCs As ColeccionPrmSql, Optional ByRef sErr As String = "") As Object
        Dim Ds As New DataSet
        _Valor = Nothing
        Try
            If GetQry(Ds, "VALOR", sQry, oCs, sErr) Then
                If Ds.Tables("VALOR").Rows.Count > 0 Then
                    Return Ds.Tables("VALOR").Rows(0).Item(sField)
                Else
                    Return "0"
                End If
            End If
        Catch ex As Exception
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
        End Try
    End Function

    Public Function GetQry(ByRef Ds As DataSet, ByVal sTabla As String, ByVal sQry As String, ByVal cs As ColeccionPrmSql, Optional ByRef sErr As String = "", Optional ByRef DBLinked As String = "") As Boolean

        Dim oPrm As SqlParameter
        Try
            sQry = sQry.Replace("VIEW_FILTRO", "")
            sQry = QryLinkDB(DBLinked, sQry)
            Cn = OpenDataBase(m_strCnx)

            Dim myDataAdapter As New SqlDataAdapter(sQry, Cn)
            myDataAdapter.SelectCommand.CommandType = CommandType.Text
            myDataAdapter.SelectCommand.CommandTimeout = 300

            For Each Prm As PrmSql In cs
                If InStr(sQry.ToUpper, Prm.Nombre.ToUpper) > 0 Then
                    oPrm = New SqlParameter(Prm.Nombre, Prm.Valor)
                    myDataAdapter.SelectCommand.Parameters.Add(oPrm)
                End If
            Next

            myDataAdapter.Fill(Ds, sTabla) 'Fill the DataSet with the rows returned.
            myDataAdapter.Dispose()
            Cn.Close() 'Close the connection.

            Return True

        Catch ex As Exception
            sErr = ex.Message
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
            Return False
        Finally
            Cn.Close()
        End Try

    End Function

#Region "Compatibilidad MO"
    Public Function GetValor(ByVal sQry As String, ByVal cs As ColeccionPrmSql) As Object
        Dim sStatement As String = ""
        Dim oPrm As SqlParameter
        GetValor = Nothing
        Try
            sStatement = DataModel.Statement(sQry)

            Cn = OpenDataBase(m_strCnx)
            Dim Qry As New SqlCommand(sStatement, Cn)
            Qry.CommandType = CommandType.Text

            For Each Prm As PrmSql In cs
                If InStr(sStatement.ToUpper, Prm.Nombre.ToUpper) > 0 Then
                    oPrm = New SqlParameter(Prm.Nombre, Prm.Valor)
                    Qry.Parameters.Add(oPrm)
                End If
            Next

            Dim sVal As Object = Qry.ExecuteScalar()
            Return sVal

        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + ex.StackTrace + vbCrLf + ex.Source, MsgBoxStyle.Critical, "ERROR EN LA APLICACIÓN")
            Return False

        Finally
            Cn.Close()
        End Try

    End Function
    Public Function GetRow(ByVal sQry As String, ByVal cs As ColeccionPrmSql) As DataRow
        Dim sStatement As String = ""
        Dim oPrm As SqlParameter
        Dim Ds As New DataSet
        GetRow = Nothing

        Try
            sStatement = DataModel.Statement(sQry)
            Cn = OpenDataBase(m_strCnx)

            Dim myDataAdapter As New SqlDataAdapter(sStatement, Cn)
            myDataAdapter.SelectCommand.CommandType = CommandType.Text

            For Each Prm As PrmSql In cs
                If InStr(sStatement.ToUpper, Prm.Nombre.ToUpper) > 0 Then
                    oPrm = New SqlParameter(Prm.Nombre, Prm.Valor)
                    myDataAdapter.SelectCommand.Parameters.Add(oPrm)
                End If
            Next

            myDataAdapter.Fill(Ds, sQry) 'Fill the DataSet with the rows returned.
            If Ds.Tables(sQry).Rows.Count > 0 Then
                GetRow = Ds.Tables(sQry).Rows(0)
            End If

            myDataAdapter.Dispose()
            Return GetRow

        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + ex.StackTrace + vbCrLf + ex.Source, MsgBoxStyle.Critical, "ERROR EN LA APLICACIÓN")
        Finally
            Cn.Close()
        End Try

    End Function
    Public Function GetQry(ByRef Ds As DataSet, ByVal sQry As String, ByVal cs As ColeccionPrmSql, Optional ByVal DBLinked As String = "") As Boolean
        Dim oPrm As SqlParameter
        Dim sStatement As String = ""
        Try

            Select Case sQry

                Case "LogIn"
                    sStatement = " SELECT usu_keyusu, usu_passwd, usu_keypfl, usu_qadpsw, usu_hostnm, usu_nombre, usu_dblinked " &
                                 "   FROM SG_USUARIOS  " &
                                 "  WHERE usu_nombre = @nombre " &
                                 "    AND usu_passwd = @passwd " &
                                 "    AND usu_status = 'A' "

                Case "MenuItems"
                    sStatement = " 	SELECT DPF_KEYFUN as men_keymen, FUN_DESFUN as men_desmen, DPF_KEYMOD as men_keypad, MOD_DESMOD as men_despad, FMO_KEYFMO as men_posisi, '' as men_fmaspx " &
                                 "    FROM SG_DETALLES_PERFIL LEFT JOIN SG_FUNCIONES ON DPF_KEYFUN = FUN_KEYFUN " &
                                 "         LEFT JOIN SG_MODULOS ON DPF_KEYMOD = MOD_KEYMOD " &
                                 "         LEFT JOIN SG_FUNCIONES_MODULO ON DPF_KEYEME = FMO_KEYEME AND DPF_KEYMOD = FMO_KEYMOD AND DPF_KEYFUN = FMO_KEYFUN " &
                                 "   WHERE DPF_KEYPFL  = @sKeyPfl " &
                                 "     AND DPF_CONSUL = 'S' " &
                                 "     AND FUN_PRIMAR = 'S' " &
                                 "  UNION " &
                                 "  SELECT DEM_KEYMOD as men_keymen, MOD_DESCOR as men_desmen, " &
                                 "         CASE DEM_KEYPAD " &
                                 "            WHEN (SELECT dem_keymod FROM SG_DETALLES_ESTRUCTURAM WHERE (dem_keypad IS NULL OR dem_keypad = '') AND dem_keyeme = (SELECT pfl_keyeme FROM SG_PERFILES WHERE pfl_keypfl = @sKeyPfl)) THEN DEM_KEYMOD " &
                                 "            ELSE DEM_KEYPAD " &
                                 "         END as men_keypad, " &
                                 "         (SELECT MOD_DESMOD FROM SG_MODULOS WHERE MOD_KEYMOD = DEM_KEYPAD) as men_despad, DEM_KEYDEM as men_posisi, '' as men_fmaspx " &
                                 "            FROM SG_DETALLES_ESTRUCTURAM LEFT JOIN SG_MODULOS ON DEM_KEYMOD = MOD_KEYMOD " &
                                 "           WHERE DEM_KEYMOD <> (SELECT dem_keymod FROM SG_DETALLES_ESTRUCTURAM WHERE (dem_keypad IS NULL OR dem_keypad = '') AND dem_keyeme = (SELECT pfl_keyeme FROM SG_PERFILES WHERE pfl_keypfl = @sKeyPfl)) " &
                                 "             AND dem_keyeme = (SELECT pfl_keyeme FROM SG_PERFILES WHERE pfl_keypfl = @sKeyPfl) " &
                                 " ORDER BY men_posisi "

                Case "NM_RAZON_SOCIAL_DISTINCT"
                    sStatement = "SELECT DISTINCT raz_keyraz, raz_nombre FROM NM_RAZON_SOCIAL"


                Case Else
                    sStatement = DataModel.Statement(sQry, cs)
                    sStatement = QryLinkDB(DBLinked, sStatement)

            End Select

            Cn = OpenDataBase(m_strCnx)

            Dim myDataAdapter As New SqlDataAdapter(sStatement, Cn)
            myDataAdapter.SelectCommand.CommandType = CommandType.Text

            For Each Prm As PrmSql In cs
                If InStr(sStatement.ToUpper, Prm.Nombre.ToUpper) > 0 Then
                    oPrm = New SqlParameter(Prm.Nombre, Prm.Valor)
                    myDataAdapter.SelectCommand.Parameters.Add(oPrm)
                End If
            Next

            myDataAdapter.Fill(Ds, sQry) 'Fill the DataSet with the rows returned.
            myDataAdapter.Dispose()
            Cn.Close() 'Close the connection.

            Return True

        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + ex.StackTrace + vbCrLf + ex.Source, MsgBoxStyle.Critical, "ERROR EN LA APLICACIÓN")
            Return False
        Finally
            Cn.Close()
        End Try

    End Function
#End Region

    Public Function ExecuteQry(ByVal sQry As String, ByVal cs As ColeccionPrmSql, Optional ByVal sPrefix As String = "") As Boolean
        Dim oPrm As SqlParameter
        Dim sStatement As String = QryLinkDB(sPrefix, sQry)
        Dim sStatementCom As String = ""
        Try
            sStatementCom = DataModel.Statement(sQry)
            If sStatementCom <> "" Then sStatement = sStatementCom
            Cn = OpenDataBase(m_strCnx)

            Dim Qy As New SqlCommand(sStatement, Cn)
            Qy.CommandType = CommandType.Text

            For Each Prm As PrmSql In cs
                If InStr(sStatement.ToUpper, Prm.Nombre.ToUpper) > 0 Then
                    oPrm = New SqlParameter(Prm.Nombre, Prm.Valor)
                    Qy.Parameters.Add(oPrm)
                End If
            Next

            Qy.ExecuteNonQuery()
            Qy.Dispose()

            Return True

        Catch ex As Exception
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
            Return False
        Finally
            Cn.Close()
        End Try

    End Function

    Public Overloads Function ExecuteStore(ByVal Pd As String, ByVal cs As ColeccionPrmSql) As Boolean
        Dim oPrm As SqlParameter
        'Esta linea sirve para garantizar que no se detenga la ejecución secuencial
        ' a pesar de un probable error
        ExecuteStore = True
        Try
            Cn = OpenDataBase(m_strCnx)

            Dim Qy As New SqlCommand(Pd, Cn)
            Qy.CommandType = CommandType.StoredProcedure
            Qy.CommandTimeout = 3000

            For Each Prm As PrmSql In cs
                oPrm = New SqlParameter(Prm.Nombre, Prm.Valor)
                If Prm.Dirección = "out" Then oPrm.Direction = ParameterDirection.Output
                Qy.Parameters.Add(oPrm)
            Next

            Qy.ExecuteNonQuery()
            For Each op As SqlParameter In Qy.Parameters
                If op.Direction = ParameterDirection.Output Then
                    cs.ItemValue(op.ParameterName) = op.Value
                End If
            Next
            Qy.Dispose()

            Return True

        Catch ex As Exception
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
            Return False
        Finally
            Cn.Close()
        End Try

    End Function
    Public Overloads Function ExecuteStore(ByVal Pd As String, ByVal cs As ColeccionPrmSql, ByRef Identity As Integer) As Boolean
        Dim oPrm As SqlParameter

        Try
            Cn = OpenDataBase(m_strCnx)

            Dim Qy As New SqlCommand(Pd, Cn)
            Qy.CommandType = CommandType.StoredProcedure
            Qy.CommandTimeout = 300

            For Each Prm As PrmSql In cs
                oPrm = New SqlParameter(Prm.Nombre, Prm.Valor)
                If Prm.Dirección = "out" Then oPrm.Direction = ParameterDirection.Output
                Qy.Parameters.Add(oPrm)
            Next

            Qy.ExecuteNonQuery()
            For Each op As SqlParameter In Qy.Parameters
                If op.Direction = ParameterDirection.Output Then
                    cs.ItemValue(op.ParameterName) = op.Value
                End If
            Next
            Qy.Dispose()

            Return True

        Catch ex As Exception
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
            Return False
        Finally
            Cn.Close()
        End Try

    End Function

    Public Function StatemenUpdate(ByVal oTb As DataTable) As Boolean
        Dim sStatement As String = "UPDATE @TABLE_NAME SET @ASIGNA WHERE @CONDICION"
        Dim sColumnas As String = ""
        Dim sParameter As String = ""
        Dim sAsignacion As String = ""
        Dim sCondición As String = ""
        Dim sTipoDato As String = ""
        Dim sTipoDatoC As String = ""
        Dim oPrm As SqlParameter

        Try
            If oTb.Rows.Count > 0 Then

                For Each oCol As DataColumn In oTb.Columns

                    If oCol.Unique Then
                        sCondición = sCondición & oCol.ColumnName & " = " & "@" & oCol.ColumnName & " AND "
                    Else
                        sAsignacion = sAsignacion & oCol.ColumnName & " = " & "@" & oCol.ColumnName & ","
                    End If
                    'sTipoDato = sTipoDato & oCol.DataType.ToString & ","
                Next
                sAsignacion = Left(sAsignacion, sAsignacion.Length - 1)
                sCondición = Left(sCondición, sCondición.Length - 5)
                'sTipoDato = Left(sTipoDato, sTipoDato.Length - 1)

                sStatement = sStatement.Replace("@TABLE_NAME", oTb.TableName).Replace("@ASIGNA", sAsignacion).Replace("@CONDICION", sCondición)

                Cn = OpenDataBase(m_strCnx)

                Dim Qy As New SqlCommand(sStatement, Cn)
                Qy.CommandType = CommandType.Text

                For Each oCol As DataColumn In oTb.Columns
                    oPrm = New SqlParameter("@" & oCol.ColumnName, Type.GetType(oCol.DataType.ToString))
                    oPrm.Direction = ParameterDirection.Input
                    Qy.Parameters.Add(oPrm)
                Next

                'Ejecución de la sentencia insert para cada registro
                For Each oRow As DataRow In oTb.Rows
                    For Each oCol As DataColumn In oTb.Columns
                        Qy.Parameters("@" & oCol.ColumnName).Value = oRow(oCol.ColumnName)
                    Next
                    Qy.ExecuteNonQuery()
                Next

            End If

            Return True

        Catch ex As Exception
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
            Return False
        Finally
            Cn.Close()
        End Try

    End Function

    Public Function StatemenInsert(ByVal oTb As DataTable) As Boolean
        Dim sStatement As String = "INSERT INTO @TABLE_NAME (@CAMPOS) VALUES(@PARAMETERS)"
        Dim sColumnas As String = ""
        Dim sParameter As String = ""
        Dim sTipoDato As String = ""
        Dim oPrm As SqlParameter

        Try
            If oTb.Rows.Count > 0 Then

                For Each oCol As DataColumn In oTb.Columns
                    If Not oCol.AutoIncrement And oCol.Caption <> "Excluir" Then
                        sColumnas = sColumnas & oCol.ColumnName & ","
                        sParameter = sParameter & "@" & oCol.ColumnName & ","
                        sTipoDato = sTipoDato & oCol.DataType.ToString & ","
                    End If
                Next
                sColumnas = Left(sColumnas, sColumnas.Length - 1)
                sParameter = Left(sParameter, sParameter.Length - 1)
                sTipoDato = Left(sTipoDato, sTipoDato.Length - 1)

                sStatement = sStatement.Replace("@TABLE_NAME", oTb.TableName).Replace("@CAMPOS", sColumnas).Replace("@PARAMETERS", sParameter)

                Cn = OpenDataBase(m_strCnx)

                Dim Qy As New SqlCommand(sStatement, Cn)
                Qy.CommandType = CommandType.Text

                For Each oCol As DataColumn In oTb.Columns
                    If Not oCol.AutoIncrement And oCol.Caption <> "Excluir" Then
                        oPrm = New SqlParameter("@" & oCol.ColumnName, Type.GetType(oCol.DataType.ToString))
                        oPrm.Direction = ParameterDirection.Input
                        Qy.Parameters.Add(oPrm)
                    End If
                Next

                'Ejecución de la sentencia insert para cada registro
                For Each oRow As DataRow In oTb.Rows
                    For Each oCol As DataColumn In oTb.Columns
                        If Not oCol.AutoIncrement And oCol.Caption <> "Excluir" Then
                            Qy.Parameters("@" & oCol.ColumnName).Value = oRow(oCol.ColumnName)
                        End If
                    Next
                    Qy.ExecuteNonQuery()
                Next

            End If

            Return True

        Catch ex As Exception
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
            Return False
        Finally
            Cn.Close()
        End Try

    End Function
    Public Function StatemenInsert(ByVal oTb As DataTable, ByVal oTbInterfaz As String) As Boolean
        Dim sStatement As String = "INSERT INTO @TABLE_NAME (@CAMPOS) VALUES(@PARAMETERS)"
        Dim sColumnas As String = ""
        Dim sParameter As String = ""
        Dim sTipoDato As String = ""
        Dim oPrm As SqlParameter

        Try
            If oTb.Rows.Count > 0 Then

                For Each oCol As DataColumn In oTb.Columns
                    If Not oCol.AutoIncrement And oCol.Caption <> "Excluir" Then
                        sColumnas = sColumnas & oCol.ColumnName & ","
                        sParameter = sParameter & "@" & oCol.ColumnName & ","
                        sTipoDato = sTipoDato & oCol.DataType.ToString & ","
                    End If
                Next
                sColumnas = Left(sColumnas, sColumnas.Length - 1)
                sParameter = Left(sParameter, sParameter.Length - 1)
                sTipoDato = Left(sTipoDato, sTipoDato.Length - 1)

                sStatement = sStatement.Replace("@TABLE_NAME", oTbInterfaz).Replace("@CAMPOS", sColumnas).Replace("@PARAMETERS", sParameter)

                Cn = OpenDataBase(m_strCnx)

                Dim Qy As New SqlCommand(sStatement, Cn)
                Qy.CommandType = CommandType.Text

                For Each oCol As DataColumn In oTb.Columns
                    If Not oCol.AutoIncrement And oCol.Caption <> "Excluir" Then
                        oPrm = New SqlParameter("@" & oCol.ColumnName, Type.GetType(oCol.DataType.ToString))
                        oPrm.Direction = ParameterDirection.Input
                        Qy.Parameters.Add(oPrm)
                    End If
                Next

                'Ejecución de la sentencia insert para cada registro
                For Each oRow As DataRow In oTb.Rows
                    For Each oCol As DataColumn In oTb.Columns
                        If Not oCol.AutoIncrement And oCol.Caption <> "Excluir" Then
                            Qy.Parameters("@" & oCol.ColumnName).Value = oRow(oCol.ColumnName)
                        End If
                    Next
                    Qy.ExecuteNonQuery()
                Next

            End If

            Return True

        Catch ex As Exception
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
            Return False
        Finally
            Cn.Close()
        End Try

    End Function

    Public Function StatemenDelete(ByVal oTb As DataTable) As Boolean
        Dim sStatement As String = "DELETE FROM @TABLE_NAME WHERE @CONDICION"
        Dim sColumnas As String = ""
        Dim sParameter As String = ""
        Dim sAsignacion As String = ""
        Dim sCondición As String = "WHERE "
        Dim sTipoDato As String = ""
        Dim sTipoDatoC As String = ""
        Dim oPrm As SqlParameter

        Try
            If oTb.Rows.Count > 0 Then

                For Each oCol As DataColumn In oTb.Columns

                    If oCol.Unique Then
                        sCondición = sCondición & oCol.ColumnName & " = " & "@" & oCol.ColumnName & " AND "
                    End If
                    'sTipoDato = sTipoDato & oCol.DataType.ToString & ","
                Next
                sCondición = Left(sCondición, sCondición.Length - 5)

                sStatement = sStatement.Replace("@TABLE_NAME", oTb.TableName).Replace("@CONDICION", sCondición)

                Cn = OpenDataBase(m_strCnx)

                Dim Qy As New SqlCommand(sStatement, Cn)
                Qy.CommandType = CommandType.Text

                For Each oCol As DataColumn In oTb.Columns
                    oPrm = New SqlParameter("@" & oCol.ColumnName, Type.GetType(oCol.DataType.ToString))
                    oPrm.Direction = ParameterDirection.Input
                    Qy.Parameters.Add(oPrm)
                Next

                'Ejecución de la sentencia insert para cada registro
                For Each oRow As DataRow In oTb.Rows
                    For Each oCol As DataColumn In oTb.Columns
                        Qy.Parameters("@" & oCol.ColumnName).Value = oRow(oCol.ColumnName)
                    Next
                    Qy.ExecuteNonQuery()
                Next

            End If

            Return True

        Catch ex As Exception
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
            Return False
        Finally
            Cn.Close()
        End Try

    End Function

    '================================================================================================================
    ' Ernesto Alvarez Flores
    '================================================================================================================
    Public Function GetTabla(ByRef Ds As DataSet, ByVal Tb As String, ByVal Pd As String, ByVal cs As ColeccionPrmSql) As Boolean
        Dim oPrm As SqlParameter
        Try
            Cn = OpenDataBase(m_strCnx)

            Dim myDataAdapter As New SqlDataAdapter(Pd, Cn)
            myDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            myDataAdapter.SelectCommand.CommandTimeout = 300

            For Each Prm As PrmSql In cs
                oPrm = New SqlParameter(Prm.Nombre, Prm.Valor)
                myDataAdapter.SelectCommand.Parameters.Add(oPrm)
            Next

            myDataAdapter.Fill(Ds, Tb) 'Fill the DataSet with the rows returned.
            myDataAdapter.Dispose()
            Cn.Close() 'Close the connection.

            Return True

        Catch ex As Exception
            Tools.AddErrorLog(m_oUsr.App.Log, ex.Message + vbCrLf + ex.TargetSite.ToString)
            Return False
        Finally
            Cn.Close()
        End Try

    End Function

End Class

Public Class PrmSql
    Public Property Nombre As String
    Public Property Valor As Object
    Public Property Dirección As String
End Class

Public Class ColeccionPrmSql
    Inherits System.Collections.CollectionBase

    'La propiedad Item configura ó devuelve un objeto PrmSql
    Default Property Item(ByVal indice As Integer) As PrmSql
        Get
            Return CType(InnerList.Item(indice), PrmSql)
        End Get
        Set(ByVal value As PrmSql)
            InnerList.Item(indice) = value
        End Set
    End Property

    Property ItemValue(ByVal sNombre As String) As Object
        Get
            ItemValue = Nothing
            For Each oE As PrmSql In InnerList
                If oE.Nombre = sNombre Then
                    Return oE.Valor
                End If
            Next
        End Get
        Set(ByVal value As Object)
            For Each oE As PrmSql In InnerList
                If oE.Nombre = sNombre Then
                    oE.Valor = value
                End If
            Next
        End Set
    End Property

    'Solo puede agregar objetos PrmSql a esta colección
    Sub Add(ByVal value As PrmSql)
        InnerList.Add(value)
    End Sub

    Function Create(ByVal sNombre As String, ByVal oVal As Object, Optional ByVal Direc As String = "inp") As PrmSql
        Dim oPrm As New PrmSql
        Try
            With oPrm
                .Nombre = sNombre
                .Valor = oVal
                .Dirección = Direc
            End With
            Add(oPrm)

        Catch ex As Exception
            Dim s As String = ex.Message
        End Try

        Return oPrm

    End Function

    Overloads Sub Clear()
        InnerList.Clear()
    End Sub

End Class

Public Class Tools
    Shared Function ReadConexión(ByVal Name As String) As String
        ReadConexión = ""
        Try
            Return ConfigurationManager.ConnectionStrings(Name).ConnectionString
        Catch ex As Exception
            Dim s As String = ex.Message
        End Try
    End Function

    Overloads Shared Sub AddErrorLog(ByVal sFile As String, ByVal exo As Exception)
        Dim objStreamWriter As StreamWriter = New StreamWriter(sFile, True, System.Text.Encoding.Default)
        Try
            objStreamWriter.WriteLine(CStr(Now()) + exo.Message + " @ " + exo.TargetSite.Name + " @ " + exo.TargetSite.Module.Name)
        Catch ex As Exception
            Dim s As String = ex.Message
            MsgBox(s, MsgBoxStyle.Critical, "Error Rutina: AddErrorLog")
        Finally
            objStreamWriter.Close()
        End Try
    End Sub

    Overloads Shared Sub AddErrorLog(ByVal sFile As String, ByVal sMsj As String)
        Dim objStreamWriter As StreamWriter = New StreamWriter(sFile, True, System.Text.Encoding.Default)
        Try
            objStreamWriter.WriteLine(CStr(Now()) + sMsj)
        Catch ex As Exception
            Dim s As String = ex.Message
            MsgBox(s, MsgBoxStyle.Critical, "Error Rutina: AddErrorLog")
        Finally
            objStreamWriter.Close()
        End Try
    End Sub
End Class
#Region "Seguridad"
Public Class Seguridad
    Public Shared Function Encriptar(ByVal _cadenaAencriptar As String) As String
        Encriptar = String.Empty
        Try
            Dim encryted As Byte() = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar)
            Encriptar = Convert.ToBase64String(encryted)
        Catch ex As Exception
            Dim s As String = ex.Message
        End Try
    End Function

    Public Shared Function DesEncriptar(ByVal _cadenaAdesencriptar As String) As String
        DesEncriptar = String.Empty
        Try
            Dim decryted As Byte() = Convert.FromBase64String(_cadenaAdesencriptar)
            DesEncriptar = System.Text.Encoding.Unicode.GetString(decryted)
        Catch ex As Exception
            Dim s As String = ex.Message
        End Try
    End Function

End Class
#End Region


#Region "Compatibilidad moveorder"
Public Class DataModel
    Shared Function Statement(ByVal sQry As String, Optional ByVal oCs As ColeccionPrmSql = Nothing) As String
        Statement = String.Empty
        Try
            Select Case sQry
                '===============================================================================================================
                ' INFORMACION DEL SISTEMA
                '===============================================================================================================
                Case "AHORA"
                    Statement = " SELECT GETDATE()  "

                    '===============================================================================================================
                    ' UBICACION, SEGURIDAD Y ACCESO
                    '===============================================================================================================
                Case "MENUITEMS"
                    Statement = " 	SELECT DPF_KEYFUN as men_keymen, FUN_DESFUN as men_desmen, DPF_KEYMOD as men_keypad, MOD_DESMOD as men_despad, FMO_KEYFMO as men_posisi, '' as men_fmaspx " &
                                 "    FROM SG_DETALLES_PERFIL LEFT JOIN SG_FUNCIONES ON DPF_KEYFUN = FUN_KEYFUN " &
                                 "         LEFT JOIN SG_MODULOS ON DPF_KEYMOD = MOD_KEYMOD " &
                                 "         LEFT JOIN SG_FUNCIONES_MODULO ON DPF_KEYEME = FMO_KEYEME AND DPF_KEYMOD = FMO_KEYMOD AND DPF_KEYFUN = FMO_KEYFUN " &
                                 "   WHERE DPF_KEYPFL  = @keypfl " &
                                 "     AND DPF_CONSUL = 'S' " &
                                 "     AND FUN_PRIMAR = 'S' " &
                                 "  UNION " &
                                 "  SELECT DEM_KEYMOD as men_keymen, MOD_DESMOD as men_desmen, " &
                                 "         CASE DEM_KEYPAD " &
                                 "            WHEN (SELECT dem_keymod FROM SG_DETALLES_ESTRUCTURAM WHERE (dem_keypad IS NULL OR dem_keypad = '') AND dem_keyeme = (SELECT pfl_keyeme FROM SG_PERFILES WHERE pfl_keypfl = @keypfl)) THEN DEM_KEYMOD " &
                                 "            ELSE DEM_KEYPAD " &
                                 "         END as men_keypad, " &
                                 "         (SELECT MOD_DESMOD FROM SG_MODULOS WHERE MOD_KEYMOD = DEM_KEYPAD) as men_despad, DEM_KEYDEM as men_posisi, '' as men_fmaspx " &
                                 "            FROM SG_DETALLES_ESTRUCTURAM LEFT JOIN SG_MODULOS ON DEM_KEYMOD = MOD_KEYMOD " &
                                 "           WHERE DEM_KEYMOD <> (SELECT dem_keymod FROM SG_DETALLES_ESTRUCTURAM WHERE (dem_keypad IS NULL OR dem_keypad = '') AND dem_keyeme = (SELECT pfl_keyeme FROM SG_PERFILES WHERE pfl_keypfl = @keypfl)) " &
                                 "             AND dem_keyeme = (SELECT pfl_keyeme FROM SG_PERFILES WHERE pfl_keypfl = @keypfl) " &
                                 " ORDER BY men_posisi "

                Case "USU_NOMBRE"
                    Statement = "SELECT usu_nombre FROM SG_USUARIOS WHERE usu_keyusu = @keyusu"

                Case "RW_SG_USUARIOS"
                    Statement = " SELECT USU_KEYUSU, USU_NOMBRE, USU_FECALT, USU_STATUS, USU_PASSWD, USU_KEYPFL, PFL_DESPFL " &
                                "   FROM SG_USUARIOS LEFT JOIN SG_PERFILES ON PFL_KEYPFL = USU_KEYPFL  " &
                                "  WHERE usu_keyusu = @keyusu "

                Case "RW_SG_USUARIO"
                    Statement = " SELECT USU_KEYUSU, USU_NOMBRE, USU_FECALT, USU_STATUS, USU_PASSWD, USU_KEYPFL " &
                                "   FROM SG_USUARIOS " &
                                "  WHERE usu_nombre = @nombre " &
                                "    AND usu_passwd = @passwd " &
                                "    AND usu_status = 'A' "

                Case "PERFIL"
                    Statement = " SELECT usu_keypfl FROM SG_USUARIOS " &
                                "  WHERE usu_nombre = @nombre " &
                                "    AND usu_passwd = @passwd " &
                                "    AND usu_status = 'A' "

                    '===============================================================================================================
                    ' Seguridades
                    '===============================================================================================================
                Case "SG_FUNCIONES_KEY"
                    Statement = " SELECT * FROM SG_FUNCIONES " &
                                "  WHERE fun_keyfun = @keyfun "

                Case "SG_SUBFUNCIONES_FUNCION_KEY"
                    Statement = " SELECT sfu_keysfu, sfu_ordens FROM SG_SUBFUNCIONES_FUNCION " &
                                "  WHERE sfu_keyfun = @keyfun "

                Case "SG_USUARIOS"
                    Statement = " SELECT * FROM SG_USUARIOS WHERE usu_status = @status"

                Case "SG_PERFILES"
                    Statement = " SELECT pfl_keypfl, pfl_despfl, pfl_keyeme, eme_deseme " &
                                "   FROM sg_perfiles, sg_estructuras_menu " &
                                "  WHERE pfl_keyeme = eme_keyeme " &
                                "    AND pfl_keypfl <> 'DES' "

                Case "SG_USUARIOS_PERFIL"
                    Statement = " SELECT usu_keyusu, usu_nombre, usu_fecalt FROM sg_usuarios " &
                                "  WHERE usu_status = 'A' " &
                                "    AND usu_keypfl = @keypfl "

                    '===============================================================================================================
                    ' LOG
                    '===============================================================================================================
                Case "CAT_DP_LOG_ESCANNER"
                    Statement = " SELECT TOP 1000 log_keyesc as ID, log_fecreg as Registro, log_infosc as Información, log_usunom as Usuario FROM DP_LOG_ESCANNER ORDER BY log_keyesc DESC "

                    '===============================================================================================================
                    ' SETTINGS
                    '===============================================================================================================
                Case "SETTINGS"
                    Statement = " SELECT svalue FROM SETTINGS WHERE sname = @sname"

                Case "SETTINGS_UPD"
                    Statement = " UPDATE SETTINGS SET svalue = @svalue " &
                                "  WHERE sname = @sname "

                Case "CAT_SETTINGS"
                    Statement = " SELECT sname, svalue FROM SETTINGS"

                Case "CAT_SETTINGS_INS"
                    Statement = " INSERT INTO SETTINGS(sname, svalue) " &
                                " VALUES(@sname, @svalue) "

                Case "CAT_SETTINGS_UPD"
                    Statement = " UPDATE SETTINGS SET svalue = @svalue WHERE sname = @sname "

                Case "CAT_SETTINGS_DEL"
                    Statement = " DELETE FROM SETTINGS WHERE sname = @sname "

                    '===============================================================================================================
                    ' CATALOGOS/EVENTOS 
                    '===============================================================================================================
                    ' USUARIOS =====================================================================================================
                Case "CAT_SG_USUARIOS"
                    Statement = " SELECT USU_KEYUSU AS ID, USU_NOMBRE AS NOMBRE, USU_FECALT AS ALTA, USU_PASSWD AS CONTRASEÑA, USU_KEYPFL AS IDP, PFL_DESPFL AS PERFIL, " &
                                "        USU_QADPSW AS QAD, USU_HOSTNM AS HOSTNAME, USU_DBLINKED AS DBLINKED " &
                                "   FROM SG_USUARIOS LEFT JOIN SG_PERFILES ON PFL_KEYPFL = USU_KEYPFL  " &
                                "  WHERE usu_status = @status "
                Case "INS_SG_USUARIOS"
                    Statement = " INSERT INTO SG_USUARIOS (USU_KEYUSU, USU_NOMBRE, USU_FECALT, USU_PASSWD, USU_QADPSW, USU_HOSTNM, USU_KEYPFL, USU_DBLINKED) " &
                                "   VALUES(@KEYUSU, @NOMBRE, @FECALT, @PASSWD, @QADPSW, @HOSTNM, @KEYPFL, @DBLINKED) "

                Case "UPD_SG_USUARIOS"
                    Statement = " UPDATE SG_USUARIOS SET USU_NOMBRE = @NOMBRE, USU_FECALT = @FECALT, USU_PASSWD = @PASSWD, " &
                                "                        USU_QADPSW = @QADPSW, USU_HOSTNM = @HOSTNM, USU_KEYPFL = @KEYPFL, USU_DBLINKED = @DBLINKED " &
                                "  WHERE USU_KEYUSU = @KEYUSU "

                Case "DEL_SG_USUARIOS"
                    ' Statement = " UPDATE SG_USUARIOS SET usu_status = @status " & _
                    '             "  WHERE USU_KEYUSU = @KEYUSU "

                    Statement = " DELETE FROM SG_USUARIOS WHERE USU_KEYUSU = @KEYUSU "

                Case "NEXT_USUARIO"
                    Statement = " SELECT COALESCE(MAX(usu_keyusu)+1,1) as NextID FROM SG_USUARIOS "


                    ' PERFILES =====================================================================================================
                Case "CAT_SG_PERFILES"
                    Statement = " SELECT PFL_KEYPFL AS ID, PFL_DESPFL AS PERFIL, PFL_KEYEME AS EME FROM SG_PERFILES "


                    ' MODELOS / FAMILIAS DE CONFIGURACION  =========================================================================
                Case "DP_ARCHIVOS_INI"
                    Statement = " SELECT * " &
                                "   FROM DP_ARCHIVOS_INI "

                Case "DP_ARCHIVOS_INI_INS"
                    Statement = " INSERT INTO DP_ARCHIVOS_INI(ini_desini, ini_ttscan, ini_produc, ini_serial, ini_serimo, ini_flecha) " &
                                "  VALUES (@desini, @ttscan, @produc, @serial, @serimo, @flecha) "

                Case "DP_ARCHIVOS_INI_UPD"
                    Statement = " UPDATE DP_ARCHIVOS_INI SET ini_desini = @desini, ini_ttscan = @ttscan, ini_produc = @produc, " &
                                "                            ini_serial = @serial, ini_serimo = @serimo, ini_flecha = @flecha " &
                                "  WHERE ini_keyini = @keyini "

                Case "DP_ARCHIVOS_INI_DEL"
                    Statement = " DELETE FROM DP_ARCHIVOS_INI " &
                                "  WHERE ini_keyini = @keyini "

                Case "DP_ARCHIVOS_INI_KEY"
                    Statement = " SELECT * " &
                                "   FROM DP_ARCHIVOS_INI " &
                                "  WHERE ini_keyini = @keyini "

                Case "DP_INI_SCANEOS_KEY"
                    Statement = " SELECT * " &
                                "   FROM DP_INI_SCANEOS " &
                                "  WHERE ins_keyini = @keyini "

                Case "DP_INI_ATRIBUTOS_KEY"
                    Statement = " SELECT * FROM DP_INI_ATRIBUTOS " &
                                "  WHERE ina_keyini = @keyini "

                Case "DP_MENSAJES"
                    Statement = " SELECT msj_keytip, msj_keymsj, msj_mensaj" &
                                "   FROM DP_MENSAJES "
                    ' SUBENSAMBLES ==================================================================================================
                Case "CAT_DP_ENSAMBLE_DATA"
                    Statement = " SELECT par_keybin, par_desbin, par_keypar, par_despar, " &
                                "        par_stdpak, par_ostdpk, par_lbform, par_string, " &
                                "        par_keyini, par_keymov, par_keycon, par_imagen, " &
                                "        par_escaja, par_cajaca, par_prints, par_qrycon " &
                                "   FROM DP_ENSAMBLE_DATA " &
                                "  WHERE par_status = @status "

                Case "DP_ENSAMBLE_DATA_ROW"
                    Statement = " SELECT par_keybin, par_desbin, par_keypar, par_despar, par_keyclt, " &
                                "        par_versio, par_operac, par_keybro, par_stdpak, " &
                                "        par_ostdpk, par_lbform, par_field1, par_field2, " &
                                "        par_keyrak, par_keydun, par_player, par_dlayer, " &
                                "        par_qlayer, par_avgwht, par_tolera, par_master, " &
                                "        par_labmov, par_preser, par_string, par_keypaf, " &
                                "        par_keyini, par_keymov, par_keycon, par_escaja, " &
                                "        par_cajaca, par_prints, par_qrycon, par_timest " &
                                "   FROM DP_ENSAMBLE_DATA " +
                                "  WHERE par_keybin = @keybin "

                Case "DP_ENSAMBLE_DATA_IMAGEN"
                    Statement = " SELECT par_keybin, par_desbin, par_keypar, par_despar, par_imagen" &
                                "   FROM DP_ENSAMBLE_DATA " +
                                "  WHERE par_keybin = @keybin "

                Case "DP_ENSAMBLE_DATA_INI_SELECT"
                    Statement = " SELECT par_keybin, par_keybin + ' - ' + par_despar as par_despar FROM DP_ENSAMBLE_DATA WHERE par_keyini = @keyini"

                Case "DP_ENSAMBLE_DATA_INI"
                    Statement = " SELECT par_keypar, par_despar, par_keyclt, " &
                                "        par_versio, par_operac, par_keybro, par_stdpak, " &
                                "        par_ostdpk, par_lbform, par_field1, par_field2, " &
                                "        par_keyrak, par_keydun, par_player, par_dlayer, " &
                                "        par_qlayer, par_avgwht, par_tolera, par_master, " &
                                "        par_labmov, par_preser, par_string, par_keypaf, " &
                                "        par_keyini, par_keymov, par_keycon " &
                                "   FROM DP_ENSAMBLE_DATA " +
                                "  WHERE par_keyini = @keyini "

                Case "INS_DP_ENSAMBLE_DATA"
                    Statement = " INSERT INTO DP_ENSAMBLE_DATA(par_keybin, par_desbin, par_keypar, par_despar, " &
                                "                          par_versio, par_operac, par_keybro, par_stdpak, " &
                                "                          par_ostdpk, par_lbform, par_field1, par_field2, " &
                                "                          par_keyrak, par_keydun, par_player, par_dlayer, " &
                                "                          par_qlayer, par_avgwht, par_tolera, " &
                                "                          par_preser, par_string, " &
                                "                          par_keyini, par_keymov, " &
                                "                          par_escaja, par_cajaca, par_prints, par_qrycon) " &
                                "  VALUES (@keybin, @desbin, @keypar, @despar, @versio, @operac, @keybro, @stdpak, " &
                                "          @ostdpk, @lbform, @field1, @field2, @keyrak, @keydun, @player, @dlayer, " &
                                "          @qlayer, @avgwht, @tolera, @preser, @string, " &
                                "          @keyini, @keymov, @escaja, @cajaca, @prints, @qrycon) "

                Case "UPD_DP_ENSAMBLE_DATA"
                    Statement = " UPDATE DP_ENSAMBLE_DATA SET par_desbin = @desbin, par_keypar = @keypar, par_despar = @despar, par_versio = @versio, " &
                                "                         par_operac = @operac, par_keybro = @keybro, par_stdpak = @stdpak, par_ostdpk = @ostdpk, " &
                                "                         par_lbform = @lbform, par_field1 = @field1, par_field2 = @field2, par_keyrak = @keyrak, " &
                                "                         par_keydun = @keydun, par_player = @player, par_dlayer = @dlayer, par_qlayer = @qlayer, " &
                                "                         par_avgwht = @avgwht, par_tolera = @tolera, " &
                                "                         par_preser = @preser, par_string = @string, " &
                                "                         par_keyini = @keyini, par_keymov = @keymov, par_imagen = @imagen, " &
                                "                         par_escaja = @escaja, par_cajaca = @cajaca, par_prints = @prints, par_qrycon = @qrycon " &
                                "  WHERE par_keybin = @keybin "

                Case "DEL_DP_ENSAMBLE_DATA"
                    Statement = " DELETE FROM DP_ENSAMBLE_DATA " &
                                "  WHERE par_keybin = @keybin "

                Case "GET_ENSAMBLE_DATA"
                    Statement = " SELECT par_keypar FROM DP_ENSAMBLE_DATA " &
                                "  WHERE par_keybin = @keybin "

                    ' PRODUCTOS =====================================================================================================
                Case "CAT_DP_PART_DATA"
                    Statement = " SELECT par_keybin, par_desbin, par_keypar, par_despar, par_keyclt, " &
                                "        par_versio, par_operac, par_keybro, par_stdpak, " &
                                "        par_ostdpk, par_lbform, par_field1, par_field2, " &
                                "        par_keyrak, par_keydun, par_player, par_dlayer, " &
                                "        par_qlayer, par_avgwht, par_tolera, par_master, " &
                                "        par_labmov, par_preser, par_string, par_keypaf, " &
                                "        par_keyini, par_keymov, par_keycon, par_imagen, " &
                                "        par_escaja, par_cajaca, par_prints, par_printp, " &
                                "        par_pakout, par_lbinfo, par_datai1, par_lbinf2, par_datai2 " &
                                "   FROM DP_PART_DATA " &
                                "  WHERE par_status = @status "

                Case "DP_PART_DATA_ROW"
                    Statement = " SELECT par_keybin, par_desbin, par_keypar, par_despar, par_keyclt, " &
                                "        par_versio, par_operac, par_keybro, par_stdpak, " &
                                "        par_ostdpk, par_lbform, par_field1, par_field2, " &
                                "        par_keyrak, par_keydun, par_player, par_dlayer, " &
                                "        par_qlayer, par_avgwht, par_tolera, par_master, " &
                                "        par_labmov, par_preser, par_string, par_keypaf, " &
                                "        par_keyini, par_keymov, par_keycon, par_escaja, " &
                                "        par_cajaca, par_prints, par_printp, par_pakout, " &
                                "        par_lbinfo, par_datai1, par_lbinf2, par_datai2  " &
                                "   FROM DP_PART_DATA " +
                                "  WHERE par_keybin = @keybin "

                Case "DP_PART_DATA_IMAGEN"
                    Statement = " SELECT par_keybin, par_desbin, par_keypar, par_despar, par_keyclt, par_imagen" &
                                "   FROM DP_PART_DATA " +
                                "  WHERE par_keybin = @keybin "


                Case "DP_PART_DATA_INI_SELECT"
                    Statement = " SELECT par_keybin, par_keybin + ' - ' + par_despar as par_despar FROM DP_PART_DATA WHERE par_keyini = @keyini"

                Case "DP_PART_DATA_INI"
                    Statement = " SELECT par_keypar, par_despar, par_keyclt, " &
                                "        par_versio, par_operac, par_keybro, par_stdpak, " &
                                "        par_ostdpk, par_lbform, par_field1, par_field2, " &
                                "        par_keyrak, par_keydun, par_player, par_dlayer, " &
                                "        par_qlayer, par_avgwht, par_tolera, par_master, " &
                                "        par_labmov, par_preser, par_string, par_keypaf, " &
                                "        par_keyini, par_keymov, par_keycon " &
                                "   FROM DP_PART_DATA " +
                                "  WHERE par_keyini = @keyini "


                Case "INS_DP_PART_DATA"
                    Statement = " INSERT INTO DP_PART_DATA(par_keybin, par_desbin, par_keypar, par_despar, " &
                                "                          par_versio, par_operac, par_keybro, par_stdpak, " &
                                "                          par_ostdpk, par_lbform, par_field1, par_field2, " &
                                "                          par_keyrak, par_keydun, par_player, par_dlayer, " &
                                "                          par_qlayer, par_avgwht, par_tolera, par_keyclt, " &
                                "                          par_master, par_labmov, par_preser, par_string, " &
                                "                          par_keypaf, par_keyini, par_keymov, par_keycon, " &
                                "                          par_escaja, par_cajaca, par_prints, par_printp, " &
                                "                          par_pakout, par_lbinfo, par_datai1, par_lbinf2, par_datai2) " &
                                "  VALUES (@keybin, @desbin, @keypar, @despar, @versio, @operac, @keybro, @stdpak, " &
                                "          @ostdpk, @lbform, @field1, @field2, @keyrak, @keydun, @player, @dlayer, " &
                                "          @qlayer, @avgwht, @tolera, @keyclt, @master, @labmov, @preser, @string, " &
                                "          @keypaf, @keyini, @keymov, @keycon, @escaja, @cajaca, @prints, @printp, " &
                                "          @pakout, @lbinfo, @datai1, @lbinf2, @datai2) "

                Case "UPD_DP_PART_DATA"
                    Statement = " UPDATE DP_PART_DATA SET par_desbin = @desbin, par_keypar = @keypar, par_despar = @despar, par_versio = @versio, " &
                                "                         par_operac = @operac, par_keybro = @keybro, par_stdpak = @stdpak, par_ostdpk = @ostdpk, " &
                                "                         par_lbform = @lbform, par_field1 = @field1, par_field2 = @field2, par_keyrak = @keyrak, " &
                                "                         par_keydun = @keydun, par_player = @player, par_dlayer = @dlayer, par_qlayer = @qlayer, " &
                                "                         par_avgwht = @avgwht, par_tolera = @tolera, par_keyclt = @keyclt, par_master = @master, " &
                                "                         par_labmov = @labmov, par_preser = @preser, par_string = @string, par_keypaf = @keypaf, " &
                                "                         par_keyini = @keyini, par_keymov = @keymov, par_keycon = @keycon, par_imagen = @imagen, " &
                                "                         par_escaja = @escaja, par_cajaca = @cajaca, par_prints = @prints, par_printp = @printp, " &
                                "                         par_pakout = @pakout, par_lbinfo = @lbinfo, par_datai1 = @datai1, par_lbinf2 = @lbinf2, " &
                                "                         par_datai2 = @datai2 " &
                                "  WHERE par_keybin = @keybin "

                Case "DEL_DP_PART_DATA"
                    Statement = " DELETE FROM DP_PART_DATA " &
                                "  WHERE par_keybin = @keybin "

                Case "GET_PART_DATA"
                    Statement = " SELECT par_keypar FROM DP_PART_DATA " &
                                "  WHERE par_keybin = @keybin "

                Case "GET_DP_PART_DATA_KEYPAF"
                    Statement = " SELECT par_keypaf FROM DP_PART_DATA WHERE par_keybin = @keybin"

                    ' WIP ORDER =====================================================================================================
                Case "DP_ORDENES_WIP"
                    Statement = " SELECT ord_keyord, ord_serial, ord_fecord, ord_horord, ord_keybin, " &
                                "        ord_keypar, ord_despar, ord_operac, ord_frmpdg, ord_keymov, " &
                                "        ord_stdpak, ord_quanti, ord_lbtype, ord_versio, ord_status, " &
                                "        ord_impres " &
                                "   FROM DP_ORDENES_WIP " &
                                "  WHERE ord_status = @stsord " &
                                 Filtro("And", oCs)

                Case "DP_ORDENES_WIP_INS"
                    Statement = " INSERT INTO DP_ORDENES_WIP( ord_keybin, ord_keypar, ord_despar, ord_operac, ord_frmpdg, " &
                                "                             ord_keymov, ord_stdpak, ord_quanti, ord_lbtype, ord_versio, " &
                                "                             ord_keyusu, ord_keycon) " &
                                "  VALUES (@keybin, @keypar, @despar, @operac, @frmpdg, @keymov, @stdpak, @quanti, @lbtype, @versio, @keyusu, @keycon)"

                Case "DP_ORDENES_WIP_UPD"
                    Statement = " UPDATE DP_ORDENES_WIP SET ord_fecord = @fecord, ord_horord = @horord, ord_keyusu = @keyusu " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_WIP_UPD_STS"
                    Statement = " UPDATE DP_ORDENES_WIP SET ord_impres = @impres, ord_status = @status " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_WIP_DEL"
                    Statement = " DELETE FROM DP_ORDENES_WIP 
                                   WHERE ord_keyord = @keyord 
                                     AND NOT EXISTS (SELECT * FROM DP_ORDENES_WIP_DETALLE
                                                       WHERE dor_keyord = ord_keyord) "

                Case "DP_ORDENES_WIP_SERIAL_COUNT"
                    Statement = " SELECT COUNT(*) FROM DP_ORDENES_WIP WHERE ord_serial = @serial "

                Case "DP_ORDENES_WIP_CIERRE"
                    Statement = " UPDATE DP_ORDENES_WIP SET ord_serial = @serial, ord_status = 'C' " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_WIP_PENDIENTE"
                    Statement = " SELECT ord_keyord, ord_fecord, ord_horord, ord_keybin, ord_keypar, " &
                                "        ord_despar, ord_operac, ord_frmpdg, ord_keymov, ord_keycon, " &
                                "        ord_stdpak, ord_quanti, ord_lbtype, ord_versio, ord_serial, " &
                                "        ord_impres, ord_keyusu " &
                                "   FROM DP_ORDENES_WIP " &
                                "  WHERE ord_status = 'P' " &
                                " ORDER BY ord_keyord "

                Case "DP_ORDENES_WIP_IMPRESA"
                    Statement = " SELECT ord_impres " &
                                "   FROM DP_ORDENES_WIP " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_WIP_STATUS"
                    Statement = " SELECT ord_status " &
                                "   FROM DP_ORDENES_WIP " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_WIP_IMPRESA_OK"
                    Statement = " UPDATE DP_ORDENES_WIP SET ord_impres = 1 " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_WIP_QUANTI"
                    Statement = " SELECT ord_quanti FROM DP_ORDENES_WIP WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_WIP_UPD_QUANTI"
                    Statement = " UPDATE DP_ORDENES_WIP SET ord_quanti = @quanti, ord_keycon = @keycon WHERE ord_keyord = @keyord "

                ' DETALLE WIP ORDER =====================================================================================================
                Case "DP_ORDENES_WIP_DETALLE"
                    Statement = "SELECT dor_itemky, dor_fecpro, dor_flecha " &
                                "  FROM DP_ORDENES_WIP_DETALLE " &
                                " WHERE dor_keyord = @keyord "

                Case "DP_ORDENES_WIP_DETALLE_COUNT"
                    Statement = " SELECT count(dor_itemky) as Registros FROM DP_ORDENES_WIP_DETALLE " &
                                "  WHERE dor_keyord = @keyord "

                Case "DP_ORDENES_WIP_DETALLE_INS"
                    Statement = " INSERT INTO DP_ORDENES_WIP_DETALLE(dor_keyord, dor_itemky, dor_flecha, dor_string) " &
                                "  VALUES (@keyord, @itemky, @flecha, @string )  "

                Case "DP_ORDENES_WIP_DETALLE_EXIST"
                    Statement = " SELECT dor_keyord, dor_itemky, dor_fecpro FROM DP_ORDENES_WIP_DETALLE " &
                                "  WHERE dor_itemky = @itemky "

                Case "DP_ORDENES_WIP_DETALLE_EXIST"
                    Statement = " SELECT COUNT(*) FROM DP_ORDENES_WIP_DETALLE " &
                                "  WHERE dor_itemky = @itemky "

                Case "DP_ORDENES_WIP_DETALLE_EXIST_FLECHA"
                    Statement = " SELECT COUNT(*) FROM DP_ORDENES_WIP_DETALLE " &
                                "  WHERE dor_flecha = @flecha "

                Case "DP_ORDENES_WIP_DETALLE_SERIAL_IN_ORDEN"
                    Statement = " SELECT COUNT(*) FROM DP_ORDENES_WIP_DETALLE " &
                                "  WHERE dor_keyord = @keyord " &
                                "    AND dor_itemky = @itemky "

                Case "DP_ORDENES_WIP_DETALLE_DEL"
                    Statement = " DELETE FROM DP_ORDENES_WIP_DETALLE
                                   WHERE dor_keyord = @keyord
                                     AND dor_itemky = @itemky "
                    ' MOVE ORDER PARKING TICKET =====================================================================================================
                Case "DP_ORDENES_MOV_PARKING_TICKET_BIN"
                    Statement = "  SELECT ord_keyord OrdID, ord_fecord Fecha, ord_keybin Bin, ord_despar Parte, ord_stdpak StdPak,   
                                          (SELECT COUNT(*) FROM DP_ORDENES_MOV_DETALLE WHERE dor_keyord = ord_keyord) Conteo 
                                     FROM DP_ORDENES_MOV
                                     WHERE ord_status = 'D'
                                       AND (SELECT COUNT(*) FROM DP_ORDENES_MOV_DETALLE WHERE dor_keyord = ord_keyord) BETWEEN 1 AND ord_stdpak 
                                       AND ord_keybin = @ord_keybin
                                     ORDER BY ord_keyord "

                Case "DP_ORDENES_MOV_PARKING_TICKET_LIST"
                    Statement = "  SELECT ord_keyord OrdID, ord_fecord Fecha, ord_keybin Bin, ord_despar Parte, ord_stdpak StdPak,   
                                          (SELECT COUNT(*) FROM DP_ORDENES_MOV_DETALLE WHERE dor_keyord = ord_keyord) Conteo 
                                     FROM DP_ORDENES_MOV
                                     WHERE ord_status = 'D'
                                       AND (SELECT COUNT(*) FROM DP_ORDENES_MOV_DETALLE WHERE dor_keyord = ord_keyord) BETWEEN 1 AND ord_stdpak 
                                     ORDER BY ord_keyord "

                Case "DP_ORDENES_MOV_LAST_PARKING_TICKET"
                    Statement = " SELECT TOP 1 ord_keyord FROM DP_ORDENES_MOV
                                   WHERE ord_status = @status  -- D es un parkingTicket estandar, E es un parkingTicket Completo en buffer
                                     AND EXISTS (SELECT * FROM DP_ORDENES_MOV_DETALLE
                                                  WHERE dor_keyord = ord_keyord)
                                   ORDER BY ord_keyord DESC"

                Case "DP_ORDENES_MOV_ULTIMO_PARKING_TICKET"
                    Statement = " SELECT TOP 1 ord_keyord FROM DP_ORDENES_MOV
                                   WHERE ord_status IN ('D','E')
                                     AND EXISTS (SELECT * FROM DP_ORDENES_MOV_DETALLE
                                                  WHERE dor_keyord = ord_keyord)
                                   ORDER BY ord_keyord DESC"


                Case "DP_ORDENES_MOV_ESPERA_QAD_LIST"
                    Statement = "  SELECT ord_keyord OrdID, ord_fecord Fecha, ord_keybin Bin, ord_despar Parte, ord_stdpak StdPak,   
                                          (SELECT COUNT(*) FROM DP_ORDENES_MOV_DETALLE WHERE dor_keyord = ord_keyord) Conteo 
                                     FROM DP_ORDENES_MOV
                                     WHERE ord_status = 'E'
                                       AND (SELECT COUNT(*) FROM DP_ORDENES_MOV_DETALLE WHERE dor_keyord = ord_keyord) BETWEEN 1 AND ord_stdpak 
                                     ORDER BY ord_keyord "

                    ' MOVE ORDER =====================================================================================================
                Case "DP_ORDENES_MOV"
                    Statement = " SELECT ord_keyord, ord_serial, ord_fecord, ord_horord, ord_keybin, " &
                                "        ord_keypar, ord_despar, ord_operac, ord_frmpdg, ord_keymov, " &
                                "        ord_stdpak, ord_quanti, ord_lbtype, ord_versio, ord_status, " &
                                "        ord_impres " &
                                "   FROM DP_ORDENES_MOV " &
                                "  WHERE ord_status = @stsord " &
                                 Filtro("AND", oCs)

                Case "DP_ORDENES_MOV_INS"
                    Statement = " INSERT INTO DP_ORDENES_MOV( ord_keybin, ord_keypar, ord_despar, ord_operac, ord_frmpdg, " &
                                "                             ord_keymov, ord_stdpak, ord_quanti, ord_lbtype, ord_versio, " &
                                "                             ord_keyusu, ord_keycon) " &
                                "  VALUES (@keybin, @keypar, @despar, @operac, @frmpdg, @keymov, @stdpak, @quanti, @lbtype, @versio, @keyusu, @keycon)"

                Case "DP_ORDENES_MOV_UPD"
                    Statement = " UPDATE DP_ORDENES_MOV SET ord_fecord = @fecord, ord_horord = @horord, ord_keyusu = @keyusu " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_MOV_UPD_STS"
                    Statement = " UPDATE DP_ORDENES_MOV SET ord_impres = @impres, ord_status = @status " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_MOV_UPD_STS_PT"
                    Statement = " UPDATE DP_ORDENES_MOV SET ord_impres = @impres, ord_status = @status, ord_fecspt = GETDATE() " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_MOV_UPD_IMPRESION"
                    Statement = " UPDATE DP_ORDENES_MOV SET ord_impres = @impres " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_MOV_UPD_STS_HABILITA_PT"
                    Statement = " UPDATE DP_ORDENES_MOV SET ord_impres = @impres, ord_status = @status, ord_fecspt = GETDATE() " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_MOV_DEL"
                    Statement = " DELETE FROM DP_ORDENES_MOV 
                                   WHERE ord_keyord = @keyord 
                                     AND NOT EXISTS (SELECT * FROM DP_ORDENES_MOV_DETALLE
                                                       WHERE dor_keyord = ord_keyord) "
                Case "DP_ORDENES_MOV_DELETE_WITH_OBS"
                    Statement = ""

                Case "DP_ORDENES_MOV_DELETE_ROLLBACK"
                    Statement = " DELETE FROM DP_ORDENES_MOV 
                                   WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_MOV_SERIAL_COUNT"
                    Statement = " SELECT COUNT(*) FROM DP_ORDENES_MOV WHERE ord_serial = @serial "

                Case "DP_ORDENES_MOV_CIERRE"
                    Statement = " UPDATE DP_ORDENES_MOV SET ord_serial = @serial, ord_status = 'C', ord_dbatch = @dbatch, ord_datapn = @datapn " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_MOV_PENDIENTE"
                    Statement = " SELECT ord_keyord, ord_fecord, ord_horord, ord_keybin, ord_keypar, " &
                                "        ord_despar, ord_operac, ord_frmpdg, ord_keymov, ord_keycon, " &
                                "        ord_stdpak, ord_quanti, ord_lbtype, ord_versio, ord_serial, " &
                                "        ord_impres, ord_keyusu, ord_fecspt " &
                                "   FROM DP_ORDENES_MOV " &
                                "  WHERE ord_status = @status " &
                                " ORDER BY ord_keyord "

                Case "DP_ORDENES_MOV_IMPRESA"
                    Statement = " SELECT ord_impres " &
                                "   FROM DP_ORDENES_MOV " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_MOV_STATUS"
                    Statement = " SELECT ord_status " &
                                "   FROM DP_ORDENES_MOV " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_MOV_IMPRESA_OK"
                    Statement = " UPDATE DP_ORDENES_MOV SET ord_impres = 1 " &
                                "  WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_MOV_QUANTI"
                    Statement = " SELECT ord_quanti FROM DP_ORDENES_MOV WHERE ord_keyord = @keyord "

                Case "DP_ORDENES_MOV_UPD_QUANTI"
                    Statement = " UPDATE DP_ORDENES_MOV SET ord_quanti = @quanti, ord_keycon = @keycon WHERE ord_keyord = @keyord "

                    ' DETALLE MOVE ORDER =====================================================================================================
                Case "DP_ORDENES_MOV_DETALLE"
                    Statement = "SELECT dor_itemky, dor_fecpro, dor_flecha, dor_chkptv " &
                                "  FROM DP_ORDENES_MOV_DETALLE " &
                                " WHERE dor_keyord = @keyord "

                Case "DP_ORDENES_MOV_DETALLE_COUNT"
                    Statement = " SELECT count(dor_itemky) as Registros FROM DP_ORDENES_MOV_DETALLE " &
                                "  WHERE dor_keyord = @keyord "

                Case "DP_ORDENES_MOV_DETALLE_INS"
                    Statement = " INSERT INTO DP_ORDENES_MOV_DETALLE(dor_keyord, dor_itemky, dor_flecha, dor_string, dor_maslap) " &
                                "  VALUES (@keyord, @itemky, @flecha, @string, @maslap)  "

                Case "DP_ORDENES_MOV_DETALLE_EXIST"
                    Statement = " SELECT dor_keyord, dor_itemky, dor_fecpro FROM DP_ORDENES_MOV_DETALLE " &
                                "  WHERE dor_itemky = @itemky "

                Case "DP_ORDENES_MOV_DETALLE_EXIST"
                    Statement = " SELECT COUNT(*) FROM DP_ORDENES_MOV_DETALLE " &
                                "  WHERE dor_itemky = @itemky "

                Case "DP_ORDENES_MOV_DETALLE_EXIST_FLECHA"
                    Statement = " SELECT COUNT(*) FROM DP_ORDENES_MOV_DETALLE " &
                                "  WHERE dor_flecha = @flecha "

                Case "DP_ORDENES_MOV_DETALLE_SERIAL_IN_ORDEN"
                    Statement = " SELECT COUNT(*) FROM DP_ORDENES_MOV_DETALLE " &
                                "  WHERE dor_keyord = @keyord " &
                                "    AND dor_itemky = @itemky "

                Case "DP_ORDENES_MOV_DETALLE_DEL"
                    Statement = " DELETE FROM DP_ORDENES_MOV_DETALLE
                                   WHERE dor_keyord = @keyord
                                     AND dor_itemky = @itemky "

                    ' CONSULTA DE ORDENES =====================================================================================================
                Case "DP_ORDENES_CONSULTA"
                    Statement = " SELECT ord_keyord, ord_serial, ord_fecord, ord_keybin, ord_despar, ord_operac, ord_stdpak, ord_quanti, " &
                                "                    ord_status = CASE ord_status " &
                                "						WHEN 'P' THEN 'PROCESO' " &
                                "						WHEN 'D' THEN 'DESHABILITADA' " &
                                "                        WHEN 'C' THEN 'CERRADA' " &
                                "                    END, " &
                                "        dor_itemky, dor_fecpro, dor_flecha " &
                                "   FROM DP_ORDENES_MOV LEFT JOIN DP_ORDENES_MOV_DETALLE ON dor_keyord = ord_keyord " &
                                Filtro("WHERE", oCs) &
                                " ORDER BY dor_fecpro, ord_fecord "

                Case "PARKING_TICKET_IN_DBLINKED"
                    Statement = " SELECT * FROM @DB_DP_ORDENES_MOV
                                   WHERE ord_keyord = @keyord 
                                     AND ord_keybin = @keybin 
                                     AND ord_status = @status "

                Case "PARKING_TICKET_IN_DBLINKED_DETALLE"
                    Statement = " SELECT * FROM @DB_DP_ORDENES_MOV_DETALLE
                                   WHERE dor_keyord = @keyord "

                Case "PARKING_TICKET_EXIST"
                    Statement = " SELECT COUNT(*) FROM DP_ORDENES_MOV " &
                                "  WHERE ord_keyord = @keyord " &
                                "    AND ord_keybin = @keybin " &
                                "    AND ord_status = @status "

                Case "PARKING_TICKET_EXIST_ORD"
                    Statement = " SELECT COUNT(*) FROM DP_ORDENES_MOV " &
                                "  WHERE ord_keyord = @keyord " &
                                "    AND ord_status = @status "

                Case "PARKING_TICKET_EXIST_KEYPAR"
                    Statement = " SELECT COUNT(*) FROM DP_ORDENES_MOV " &
                                "  WHERE ord_keyord = @keyord " &
                                "    AND ord_keypar = @keypar " &
                                "    AND ord_status = @status "

                Case "PARKING_TICKET_INFO"
                    Statement = " SELECT ord_keyord, ord_fecord, ord_keybin, ord_keypar, ini_desini, ord_despar,
                                         (SELECT COUNT(*) FROM DP_ORDENES_MOV_DETALLE WHERE dor_keyord = ord_keyord) AS ord_quanti,
	                                     SgUserName, ord_serial, par_datai1, par_datai2
                                    FROM DP_ORDENES_MOV LEFT JOIN DP_PART_DATA ON par_keybin = ord_keybin
                                                        LEFT JOIN DP_ARCHIVOS_INI ON ini_keyini = par_keyini
                                                        LEFT JOIN SGUSUARIOS ON SgUserID = ord_keyusu
                                   WHERE ord_keyord = @keyord "

                Case "LABEL_PARTIAL"
                    Statement = " SELECT ord_keyord, ord_fecord, ord_keybin, ord_keypar, ini_desini, ord_despar, " &
                                "        par_pakout, usu_nombre " &
                                "   FROM DP_ORDENES_MOV LEFT JOIN DP_PART_DATA ON par_keybin = ord_keybin " &
                                "                       LEFT JOIN DP_ARCHIVOS_INI ON ini_keyini = par_keyini " &
                                "                       LEFT JOIN SG_USUARIOS ON usu_keyusu = ord_keyusu " &
                                "  WHERE ord_keyord = @keyord "
                Case "LBL_INFO_PRODUCTO"
                    Statement = "SELECT ord_keyord, ord_fecord, ord_keybin, ord_keypar, ini_desini, ord_despar,
                                        (SELECT COUNT(*) FROM DP_ORDENES_MOV_DETALLE WHERE dor_keyord = ord_keyord) ord_quanti,
                                        usu_nombre, ord_serial, par_datai1, par_datai2
                                   FROM DP_ORDENES_MOV LEFT JOIN DP_PART_DATA ON par_keybin = ord_keybin
                                                       LEFT JOIN DP_ARCHIVOS_INI ON ini_keyini = par_keyini
                                                       LEFT JOIN SG_USUARIOS ON usu_keyusu = ord_keyusu
                                  WHERE ord_keyord = @keyord"
                    ' ================================================================================================================
                Case "IDENTITY"
                    Statement = " SELECT IDENT_CURRENT(@ntabla) "

                Case "OPERADORES"
                    Statement = " SELECT ope_keyope, ope_desope FROM OPERADORES"

                Case "LINKSERVER-LINEAS"
                    Statement = " SELECT ConfigItemValor, ConfigItemNombre FROM CONFIGITEM WHERE ConfigID = @ConfigID"

            End Select
        Catch ex As Exception

        End Try
    End Function

    Shared Function Filtro(ByVal Ope As String, ByVal oCs As ColeccionPrmSql) As String
        Filtro = ""
        Try
            If oCs.ItemValue("_FiltroGrid").ToString <> "" Then
                Return Ope & " " & oCs.ItemValue("_FiltroGrid").ToString
            End If
        Catch ex As Exception

        End Try
    End Function

End Class
#End Region 'Compatibilidad moveorder

Public Enum OData
    UERP
End Enum


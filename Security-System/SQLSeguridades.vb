Public Class SQLSeguridades
    Inherits SQL

    Private m_sLog As String
    Private Ds As New DataSet

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

    Public ReadOnly Property QryCredenciales() As String
        Get
            Return "SELECT U.SgUserID, P.PerfilID, PerfilNombre 
                      FROM SGUSUARIOS U LEFT JOIN SGUSRPERFIL UP ON UP.SgUserID = U.SgUserID
                                        LEFT JOIN  SGPERFILES P ON P.PerfilID = UP.PerfilID
                     WHERE SgUserName = @SgUserName
                       AND SgUserPasswd = @SgUserPasswd
                       AND PlataformaID = @PlataformaID "
        End Get
    End Property

    Public ReadOnly Property QryCredencialesAgroGe() As String
        Get
            Return "SELECT usu_keypfl as Perfil FROM SG_USUARIOS WHERE usu_nombre = @nombre"
        End Get
    End Property


    Public ReadOnly Property QryUpdateContraseña() As String
        Get
            Return "UPDATE SG_USUARIOS SET usu_passwd =  @usu_passwd " &
                   " WHERE usu_keyusu = @usu_keyusu "
        End Get
    End Property
    Public ReadOnly Property QryPerfiles() As String
        Get
            Return "SELECT P.PerfilID, P.PerfilNombre 
                      FROM SGUSUARIOS U LEFT JOIN SGUSRPERFIL UP ON UP.SgUserID = U.SgUserID
                                        LEFT JOIN  SGPERFILES P ON P.PerfilID = UP.PerfilID
                     WHERE U.SgUserID = @SgUserID
                       AND PlataformaID = @PlataformaID"
        End Get
    End Property

End Class

Public Class NMUsuarios
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

    Public ReadOnly Property Lista As String
        Get
            Return "SELECT * FROM SG_USUARIOS WHERE usu_status = @status"
        End Get
    End Property

    Public ReadOnly Property Item() As String
        Get
            Return "SELECT * FROM SG_USUARIOS WHERE usu_keymai = @keymai"
        End Get
    End Property

    Public ReadOnly Property ItemForID() As String
        Get
            Return "SELECT * FROM SG_USUARIOS WHERE usu_keyusu = @keyusu"
        End Get
    End Property

End Class

Public Class SQLMenu
    Inherits SQL

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
    End Sub
    Public ReadOnly Property ListGroups
        Get
            Return " SELECT DISTINCT PD.ModuloID, ModuloNombre
                       FROM SGPERFILESDETALLE PD LEFT JOIN SGPERFILES P ON P.PerfilID = PD.PerfilID
                                                 LEFT JOIN SGMODULOS M ON M.ModuloID = PD.ModuloID
                                                 LEFT JOIN SGFUNCIONES F ON F.SGFuncionID = PD.SGFuncionID
                    		                     LEFT JOIN SGESTRUCTURASM_DETALLE ED ON ED.EstructuraMenuID = P.EstructuraMenuID AND ED.ModuloID = PD.ModuloID
                      WHERE PerfilConsultar = 1
                        AND PD.PerfilID = @PerfilID
                      GROUP BY PD.ModuloID, ModuloNombre, PerfilDetalleID"
        End Get
    End Property

    Public ReadOnly Property ListItems
        Get
            Return " SELECT PD.ModuloID, ModuloNombre, F.SGFuncionID, SGFuncionNombre, SGFuncionDescripcion, SGFuncionWeb
                       FROM SGPERFILESDETALLE PD LEFT JOIN SGPERFILES P ON P.PerfilID = PD.PerfilID
                                                 LEFT JOIN SGMODULOS M ON M.ModuloID = PD.ModuloID
                                                 LEFT JOIN SGFUNCIONES F ON F.SGFuncionID = PD.SGFuncionID
                                                 LEFT JOIN SGFUNCIONESMODULO FM ON FM.EstructuraMenuID = P.EstructuraMenuID AND FM.ModuloID = PD.ModuloID AND FM.SGFuncionID = PD.SGFuncionID
                      WHERE PerfilConsultar = 1
                        AND PD.PerfilID = @PerfilID
                        AND PD.ModuloID = @ModuloID
                      ORDER BY SGFuncionModuloID "
        End Get
    End Property
    Public ReadOnly Property Lista
        Get
            Return " SELECT PD.SGFuncionID as men_keymen, SGFuncion as men_desmen, PD.ModuloID as men_keypad, Modulo as men_despad, SGFuncionModuloOrden as men_posisi, SGFuncionOLEDLL as men_fmaspx, " &
                   "        SGFuncionConsultar+SGFuncionNuevo+SGFuncionEliminar+SGFuncionRecuperar+SGFuncionModificar+SGFuncionListar+SGFuncionExportar+SGFuncionGraficar as men_permis " &
                   "   FROM PERFILES_DETALLE PD LEFT JOIN PERFILES P ON P.PerfilID = PD.PerfilID " &
                   "                           LEFT JOIN SGFUNCIONES F ON F.SGFuncionID = PD.SGFuncionID " &
                   "                           LEFT JOIN MODULOS M ON M.ModuloID = PD.ModuloID " &
                   "						   LEFT JOIN SGFUNCIONES_MODULO FM ON FM.EstructuraMenuID = P.EstructuraMenuID AND FM.ModuloID = PD.ModuloID AND FM.SGFuncionID = PD.SGFuncionID " &
                   "  WHERE P.PerfilID = @keypfl " &
                   "    AND PerfilConsultar = 'S' " &
                   "  UNION " &
                   " SELECT ED.ModuloID as men_keymen, Modulo as men_desmen, ModuloPadreID as men_keypad, " &
                   "        (SELECT Modulo FROM MODULOS WHERE ModuloID = ModuloPadreID) as men_despad, EstructuraMenuOrden as men_posisi, '' as men_fmaspx, '' as men_permis " &
                   "   FROM ESTRUCTURASM_DETALLE ED LEFT JOIN MODULOS M ON M.ModuloID = ED.ModuloID " &
                   "  WHERE EstructuraMenuID = (SELECT EstructuraMenuID FROM PERFILES WHERE PerfilID = @keypfl) " &
                   "    AND EstructuraMenuID = (SELECT EstructuraMenuID FROM PERFILES WHERE PerfilID = @keypfl) "
        End Get
    End Property

End Class
'Public Class Permisos
'    Inherits SQL
'    Private m_sLog As String
'    Private Ds As New DataSet
'    Private arPermiso As List(Of Boolean)

'    Public Sub New(ByVal oUsr As MySession)
'        MyBase.New(oUsr)
'        m_sLog = oUsr.App.Log
'        GetPermisos(oUsr)
'    End Sub

'    Private M_FUN_CONSUL As Boolean
'    Private M_FUN_ENUEVO As Boolean
'    Private M_FUN_ELIMIN As Boolean
'    Private M_FUN_RECUPE As Boolean
'    Private M_FUN_MODIFI As Boolean
'    Private M_FUN_LISTAR As Boolean
'    Private M_FUN_EXPORT As Boolean
'    Private M_FUN_GRAFIC As Boolean
'    Private M_FUN_ESPEC1 As Boolean
'    Private M_FUN_ESPEC2 As Boolean
'    Private M_FUN_ESPEC3 As Boolean
'    Private M_FUN_ESPEC4 As Boolean
'    Private M_FUN_ESPEC5 As Boolean

'    Public ReadOnly Property FUN_CONSUL As Boolean
'        Get
'            Return M_FUN_CONSUL
'        End Get
'    End Property
'    Public ReadOnly Property FUN_ENUEVO As Boolean
'        Get
'            Return M_FUN_ENUEVO
'        End Get
'    End Property

'    Public ReadOnly Property FUN_ELIMIN As Boolean
'        Get
'            Return M_FUN_ELIMIN
'        End Get
'    End Property
'    Public ReadOnly Property FUN_RECUPE As Boolean
'        Get
'            Return M_FUN_RECUPE
'        End Get
'    End Property
'    Public ReadOnly Property FUN_MODIFI As Boolean
'        Get
'            Return M_FUN_MODIFI
'        End Get
'    End Property
'    Public ReadOnly Property FUN_LISTAR As Boolean
'        Get
'            Return M_FUN_LISTAR
'        End Get
'    End Property
'    Public ReadOnly Property FUN_EXPORT As Boolean
'        Get
'            Return M_FUN_EXPORT
'        End Get
'    End Property
'    Public ReadOnly Property FUN_GRAFIC As Boolean
'        Get
'            Return M_FUN_GRAFIC
'        End Get
'    End Property
'    Public ReadOnly Property FUN_ESPEC1 As Boolean
'        Get
'            Return M_FUN_ESPEC1
'        End Get
'    End Property
'    Public ReadOnly Property FUN_ESPEC2 As Boolean
'        Get
'            Return M_FUN_ESPEC2
'        End Get
'    End Property
'    Public ReadOnly Property FUN_ESPEC3 As Boolean
'        Get
'            Return M_FUN_ESPEC3
'        End Get
'    End Property
'    Public ReadOnly Property FUN_ESPEC4 As Boolean
'        Get
'            Return M_FUN_ESPEC4
'        End Get
'    End Property
'    Public ReadOnly Property FUN_ESPEC5 As Boolean
'        Get
'            Return M_FUN_ESPEC5
'        End Get
'    End Property

'    Private ReadOnly Property ListaPermisos As String
'        Get
'            Return " SELECT PerfilConsultar dpf_consul, PerfilNuevo dpf_enuevo, PerfilEliminar dpf_elimin, PerfilRecuperar dpf_recupe," & _
'                   "        PerfilModificar dpf_modifi, PerfilListar dpf_listar,PerfilExportar dpf_export, PerfilGraficar dpf_grafic " & _
'                   "   FROM PERFILES_DETALLE " & _
'                   "  WHERE PerfilID = @keypfl " & _
'                   "    AND SGFuncionID = @keyfun "
'        End Get
'    End Property

'    'Private ReadOnly Property ListaPermisos As String
'    '    Get
'    '        Return " SELECT dpf_consul, dpf_enuevo, dpf_elimin, dpf_recupe, dpf_modifi, dpf_listar, dpf_export, dpf_grafic," & _
'    '               "        dpf_espec1, dpf_espec2, dpf_espec3, dpf_espec4, dpf_espec5 " & _
'    '               "   FROM SG_DETALLES_PERFIL " & _
'    '               "  WHERE dpf_keypfl = @keypfl " & _
'    '               "    AND dpf_keyfun = @keyfun "
'    '    End Get
'    'End Property

'    Private Sub GetPermisos(ByVal oUsr As MySession)
'        Dim oCs As New ColeccionPrmSql
'        Try
'            oCs.Create("@keypfl", oUsr.Perfil)
'            oCs.Create("@keyfun", oUsr.CurrentFunction)
'            If GetQry(Ds, "PERMISOS", ListaPermisos, oCs) Then
'                If Not Ds.Tables("PERMISOS") Is Nothing Then
'                    For Each Dr As DataRow In Ds.Tables("PERMISOS").Rows
'                        M_FUN_CONSUL = (Dr("DPF_CONSUL") = "S")
'                        M_FUN_ENUEVO = (Dr("DPF_ENUEVO") = "S")
'                        M_FUN_ELIMIN = (Dr("DPF_ELIMIN") = "S")
'                        M_FUN_RECUPE = (Dr("DPF_RECUPE") = "S")
'                        M_FUN_MODIFI = (Dr("DPF_MODIFI") = "S")
'                        M_FUN_LISTAR = (Dr("DPF_LISTAR") = "S")
'                        M_FUN_EXPORT = (Dr("DPF_EXPORT") = "S")
'                        M_FUN_GRAFIC = (Dr("DPF_GRAFIC") = "S")
'                        'M_FUN_ESPEC1 = (Dr("DPF_ESPEC1") = "S")
'                        'M_FUN_ESPEC2 = (Dr("DPF_ESPEC2") = "S")
'                        'M_FUN_ESPEC3 = (Dr("DPF_ESPEC3") = "S")
'                        'M_FUN_ESPEC4 = (Dr("DPF_ESPEC4") = "S")
'                        'M_FUN_ESPEC5 = (Dr("DPF_ESPEC5") = "S")
'                        Exit For
'                    Next
'                End If
'            End If
'        Catch ex As Exception
'            Tools.AddErrorLog(m_sLog, ex)
'        End Try
'    End Sub


'End Class

Public Class CurrentAutoriza
    Inherits SQL
    Private m_sLog As String
    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        GetAutoriza(oUsr)
    End Sub

    Public FunctionID As String
    Public FunctionName As String
    Public FunctionDescription As String
    Public FunctionPadre As String
    Public Consultar As Boolean
    Public Nuevo As Boolean
    Public Eliminar As Boolean
    Public Recuperar As Boolean
    Public Modificar As Boolean
    Public Listar As Boolean
    Public Exportar As Boolean
    Public Graficar As Boolean
    Private Sub GetAutoriza(ByVal oUsr As MySession)
        Dim oSql As New SQLErpSeguridades(oUsr)
        Dim oCs As New ColeccionPrmSql
        Try
            oCs.Create("@PerfilID", oUsr.Perfil)
            oCs.Create("@SGFuncionID", oUsr.CurrentFunction)
            Dim oTb As DataTable = oSql._Lista(oSql.Autoriza, "Permisos", oCs)
            If Not oTb Is Nothing Then
                For Each Dr As DataRow In oTb.Rows
                    FunctionID = Dr("SGFuncionID").ToString
                    Consultar = Dr("PerfilConsultar")
                    Nuevo = Dr("PerfilNuevo")
                    Eliminar = Dr("PerfilEliminar")
                    Recuperar = Dr("PerfilRecuperar")
                    Modificar = Dr("PerfilModificar")
                    Listar = Dr("PerfilListar")
                    Exportar = Dr("PerfilExportar")
                    Graficar = Dr("PerfilGraficar")
                    Exit For
                Next
            End If

        Catch ex As Exception
            Tools.AddErrorLog(m_sLog, ex)
        End Try
    End Sub

End Class

Public Class SQLFiltrosFuncion
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public ReadOnly Property Lista As String
        Get
            Return " SELECT * FROM SGFUNCIONESSGFiltroStatus WHERE SGFuncionID = @SGFuncionID ORDER BY SGFiltroStatusID "
        End Get
    End Property

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

End Class

Public Class SQLEventosFuncion
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public ReadOnly Property Lista As String
        Get
            Return " SELECT * FROM SGFUNCIONESEVENTOSESP WHERE SGFuncionID = @SGFuncionID ORDER BY SGFuncionEventoID "
        End Get
    End Property

    Public ReadOnly Property Item As String
        Get
            Return " SELECT * FROM SGFUNCIONESEVENTOSESP WHERE SGFuncionID = @SGFuncionID AND SGFuncionEventoID = @SGFuncionEventoID "
        End Get
    End Property

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

End Class

Public Class SQLFuncion
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public ReadOnly Property Lista As String
        Get
            Return " SELECT * FROM SGFUNCIONES WHERE SGFuncionActivo = @status "
        End Get
    End Property
    Public ReadOnly Property ListxAsignar As String
        Get
            Return " SELECT SGFuncionID, SGFuncionNombre FROM SGFUNCIONES F
                      WHERE NOT EXISTS (SELECT * FROM SGFUNCIONESMODULO FM WHERE FM.SGFuncionID = F.SGFuncionID AND EstructuraMenuID = @EstructuraMenuID)
                      ORDER BY SGFuncionNombre "
        End Get
    End Property

    Public ReadOnly Property Item As String
        Get
            Return " SELECT * FROM SGFUNCIONES WHERE SGFuncionID = @SGFuncionID "
        End Get
    End Property

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

End Class

Public Class SQLSubfuncion
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public ReadOnly Property Lista As String
        Get
            Return " SELECT S.SGFuncionID, SGSubFuncionID, SGSubFuncionOrden, SGFuncion, dbo.GetNombreFuncion(SGSubFuncionID) SGSubFuncion " & _
                   "   FROM SGFUNCIONESSUBFUNCION S LEFT JOIN SGFUNCIONES F ON F.SGFuncionID = S.SGFuncionID " & _
                   "  WHERE S.SGFuncionID = @SGFuncionID "
        End Get
    End Property

    Public ReadOnly Property Item As String
        Get
            Return " SELECT * " & _
                   "   FROM SGSUBFUNCIONES WHERE SGSubFuncionID = @SGSubFuncionID "
        End Get
    End Property

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

End Class

Public Class SQLModulo
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet
    Public ReadOnly Property List As String
        Get
            Return "SELECT * FROM SGMODULOS WHERE ModuloActivo = @status "
        End Get
    End Property
    Public ReadOnly Property Item As String
        Get
            Return "SELECT * FROM SGMODULOS WHERE ModuloID = @ModuloID "
        End Get
    End Property
    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

End Class

Public Class SQLAccesoUbica
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

    Public ReadOnly Property Lista As String
        Get
            Return " SELECT * FROM AA_ACCESO_UBICACIONES LEFT JOIN NM_UBICACIONES ON ubi_keyubi = acu_keyubi " & _
                   "  WHERE acu_keyeme = @keyeme"
        End Get
    End Property

    Public ReadOnly Property Item As String
        Get
            Return "SELECT * FROM AA_ACCESO_UBICACIONES WHERE acu_keyeme = @keyeme AND acu_keyubi = keyubi"
        End Get
    End Property

    Public ReadOnly Property Delete As String
        Get
            Return "DELETE FROM AA_ACCESO_UBICACIONES WHERE acu_keyeme = @keyeme AND acu_keyubi = keyubi"
        End Get
    End Property

End Class
Public Class SQLFuncionesModulo
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet
    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub
    Public ReadOnly Property List
        Get
            Return " SELECT SGFuncionModuloID, ModuloID, F.SGFuncionID, SGFuncionNombre, SGFuncionDescripcion  
                       FROM SGFUNCIONESMODULO FM LEFT JOIN SGFUNCIONES F ON F.SGFuncionID = FM.SGFuncionID
                      WHERE EstructuraMenuID = @EstructuraMenuID
                        AND ModuloID =  @ModuloID
                      ORDER BY SGFuncionModuloID "
        End Get
    End Property
    Public ReadOnly Property Insert As String
        Get
            Return " INSERT INTO SGFUNCIONESMODULO(EstructuraMenuID, ModuloID, SGFuncionID)
                       VALUES(@EstructuraMenuID, @ModuloID, @SGFuncionID)"
        End Get
    End Property
    Public ReadOnly Property Delete As String
        Get
            Return " DELETE FROM SGFUNCIONESMODULO 
                      WHERE SGFuncionModuloID = @SGFuncionModuloID"
        End Get
    End Property
End Class
Public Class SQLEstructuraDetalle
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub
    Public ReadOnly Property List
        Get
            Return " SELECT ModuloPadreID, M.ModuloID, ModuloNombre   
                       FROM SGESTRUCTURASM_DETALLE ED LEFT JOIN SGMODULOS M ON M.ModuloID = ED.ModuloID
                      WHERE EstructuraMenuID = @EstructuraMenuID
                      ORDER BY EstructuraMenuDetalleID "
        End Get
    End Property
    Public ReadOnly Property Insert
        Get
            Return " INSERT INTO SGESTRUCTURASM_DETALLE(EstructuraMenuID, ModuloID, ModuloPadreID) 
                      VALUES(@EstructuraMenuID, @ModuloID, @ModuloPadreID)"
        End Get
    End Property
    Public ReadOnly Property Delete
        Get
            Return " DELETE FROM SGESTRUCTURASM_DETALLE
                      WHERE EstructuraMenuDetalleID = @EstructuraMenuDetalleID "
        End Get
    End Property

End Class
Public Class SQLPlataforma
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub
    Public ReadOnly Property Lista As String
        Get
            Return "SELECT * FROM SGPLATAFORMA"
        End Get
    End Property
    Public ReadOnly Property Item As String
        Get
            Return "SELECT * FROM SGPLATAFORMA WHERE PlataformaID = @PlataformaID"
        End Get
    End Property
End Class
Public Class SQLEstructura
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

    Public ReadOnly Property Lista As String
        Get
            Return "SELECT * FROM SGESTRUCTURAMENU"
        End Get
    End Property

    Public ReadOnly Property Item As String
        Get
            Return "SELECT * FROM SGESTRUCTURA_MENU WHERE eme_keyeme = @keyeme"
        End Get
    End Property

    Public ReadOnly Property Delete As String
        Get
            Return "DELETE FROM SGESTRUCTURA_MENU WHERE eme_keyeme = @keyeme"
        End Get
    End Property

    Public ReadOnly Property EstructuraEventos() As String
        Get
            Return " SELECT *, 'M' as tipo, '' as fun_consul, '' as fun_enuevo, '' as fun_elimin, '' as fun_recupe, " & _
                   "        '' as fun_modifi, '' as fun_listar, '' as fun_export, '' as fun_grafic " & _
                   "   FROM SG_DETALLES_ESTRUCTURAM LEFT JOIN SG_MODULOS ON mod_keymod = dem_keymod " & _
                   "  WHERE dem_keyeme = @keyeme " & _
                   "  UNION " & _
                   " SELECT fmo_keyeme as dem_keyeme, fmo_keyfun as dem_keymod, fmo_keymod as dem_keypad, fmo_keyfmo as dem_keydem, " & _
                   "        fun_keyfun as mod_keymod, fun_desfun as mod_desmod, fun_desfun as mod_descor, fun_status as mod_status, " & _
                   "        fun_ayufun as mod_ayumod, '' as mod_iconoa, 'F' as tipo, fun_consul, fun_enuevo, fun_elimin, fun_recupe, " & _
                   "  	     fun_modifi, fun_listar, fun_export, fun_grafic " & _
                   "   FROM SG_FUNCIONES_MODULO LEFT JOIN SG_FUNCIONES ON fmo_keyfun = fun_keyfun " & _
                   "  WHERE fmo_keyeme = @keyeme " & _
                   "  ORDER BY dem_keypad "
        End Get
    End Property

    Public ReadOnly Property DeleteDetalleEstructura() As String
        Get
            Return " DELETE FROM SG_DETALLES_ESTRUCTURAM " & _
                                "  WHERE dem_keyeme = @keyeme " & _
                                "    AND dem_keymod = @keymod "

        End Get
    End Property

    Public ReadOnly Property InsertDefaultDetalleEstructura As String
        Get
            Return " INSERT INTO SG_DETALLES_ESTRUCTURAM(dem_keyeme, dem_keymod, dem_keydem)" & _
                   " VALUES(@keyeme, 'SYSTEM', 0)"
        End Get
    End Property

End Class

Public Class SQLPerfil
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

    Public ReadOnly Property List As String
        Get
            Return "SELECT * FROM SGPERFILES"
        End Get
    End Property

    Public ReadOnly Property Item As String
        Get
            Return "SELECT * FROM SGPERFILES WHERE PerfilID = @PerfilID"
        End Get
    End Property

    Public ReadOnly Property Delete As String
        Get
            Return "DELETE FROM SG_PERFILES WHERE pfl_keypfl = @keypfl"
        End Get
    End Property

End Class
Public Class AppPermisos
    Inherits SQL

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
    End Sub

    Public ReadOnly Property Lista As String
        Get
            Return " SELECT * FROM SGUSUARIOS U LEFT JOIN SGPERFILES P ON P.PerfilID = U.PerfilID " &
                   "   LEFT JOIN SGPERFILESDETALLE PD ON PD.PerfilID = P.PerfilID " &
                   "  WHERE SgUserID = @SgUserID " &
                   "    AND SGFuncionID = @SGFuncionID "
        End Get
    End Property

End Class
Public Class SQLDetallesPerfil
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    'Nota esta clase mantiene funciones del esquema de datos obsoleto que debera actualizar
    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

    Public ReadOnly Property Lista As String
        Get
            Return "SELECT * FROM SG_DETALLES_PERFIL "
        End Get
    End Property

    Public ReadOnly Property Item As String
        Get
            Return "SELECT * FROM SGPERFILESDETALLE WHERE PerfilID = @PerfilID AND ModuloID = @ModuloID AND SGFuncionID = @SGFuncionID "
        End Get
    End Property
    Public ReadOnly Property Insert As String
        Get
            Return " INSERT INTO SGPERFILESDETALLE(PerfilID, ModuloID, SGFuncionID, PerfilConsultar, PerfilNuevo, PerfilEliminar, PerfilRecuperar, PerfilModificar,
                                                   PerfilListar, PerfilExportar, PerfilGraficar, CreaUserID)
                       VALUES(@PerfilID, @ModuloID, @SGFuncionID, @PerfilConsultar, @PerfilNuevo, @PerfilEliminar, @PerfilRecuperar, @PerfilModificar,
                              @PerfilListar, @PerfilExportar, @PerfilGraficar, @CreaUserID) "
        End Get
    End Property
    Public ReadOnly Property Update As String
        Get
            Return " UPDATE SGPERFILESDETALLE SET PerfilConsultar = @PerfilConsultar, PerfilNuevo = @PerfilNuevo, PerfilEliminar = @PerfilEliminar, PerfilRecuperar = @PerfilRecuperar,
                                                  PerfilModificar = @PerfilModificar, PerfilListar = @PerfilListar, PerfilExportar = @PerfilExportar, PerfilGraficar = @PerfilGraficar
                      WHERE PerfilDetalleID = @PerfilDetalleID "
        End Get
    End Property
    Public ReadOnly Property Existe As String
        Get
            Return " SELECT PerfilDetalleID AS Identificador FROM SGPERFILESDETALLE WHERE PerfilID = @PerfilID AND ModuloID = @ModuloID AND SGFuncionID = @SGFuncionID "
        End Get
    End Property
    Public ReadOnly Property Delete As String
        Get
            Return " DELETE FROM SG_PERFILES WHERE pfl_keypfl = @keypfl "
        End Get
    End Property

End Class

Public Class SQLUbicacion
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

    Public ReadOnly Property ListaForCombo() As String
        Get
            Return "SELECT ubi_keyubi, dbo.GETPATHUBICA(ubi_keyubi) as ubi_desubi, ubi_keytub, ubi_keypad" & _
                   "  FROM NM_UBICACIONES " & _
                   " WHERE NOT ubi_keypad IS NULL"
        End Get
    End Property

    Public ReadOnly Property ListaForComboOrigen() As String
        Get
            Return "SELECT ubi_keyubi, dbo.GETPATHUBICA(ubi_keyubi) as ubi_desubi, ubi_keytub, ubi_keypad" & _
                   "  FROM NM_UBICACIONES " & _
                   " WHERE ubi_keypad = @keypad"
        End Get
    End Property

    Public ReadOnly Property NextID() As String
        Get
            Return " SELECT COALESCE(MAX(CAST(RIGHT(ubi_keyubi, LEN(ubi_keyubi)-1) as int)),0) + 1 as ubi_nextid " & _
                   "   FROM NM_UBICACIONES " & _
                   "  WHERE ubi_keyubi <> 'ROOT' " & _
                   "    AND LEFT(ubi_keyubi,1) = @keytub"
        End Get
    End Property

    Public ReadOnly Property Delete As String
        Get
            Return "DELETE FROM NM_UBICACIONES WHERE ubi_keyubi = @keyubi"
        End Get
    End Property

    Public ReadOnly Property Lista As String
        Get
            Return "SELECT ubi_keyubi, ubi_desubi, tub_destub, ubi_keypad, ubi_ordubi, ubi_keytub " & _
                   "  FROM NM_UBICACIONES LEFT JOIN NM_TIPO_UBICACION ON tub_keytub = ubi_keytub " & _
                   "VIEW_FILTRO" & _
                   " ORDER BY ubi_keypad, ubi_desubi"
        End Get
    End Property

    Public ReadOnly Property ListaTablasDestino As String
        Get
            Return " SELECT ubi_keyubi, ubi_desubi, tub_destub, ubi_keypad, ubi_ordubi, ubi_keytub " & _
                   "   FROM NM_UBICACIONES LEFT JOIN NM_TIPO_UBICACION ON tub_keytub = ubi_keytub " & _
                   "  WHERE ubi_keypad = (SELECT rut_ubides FROM FL_RUTAS WHERE rut_keyrut = @keyrut) " & _
                   "  ORDER BY ubi_desubi "
        End Get
    End Property

    Public ReadOnly Property Item As String
        Get
            Return "SELECT * FROM NM_UBICACIONES WHERE ubi_keyubi = @keyubi"
        End Get
    End Property

    Public ReadOnly Property ListaTipo As String
        Get
            Return "SELECT * FROM NM_TIPO_UBICACION WHERE tub_status = @status"
        End Get
    End Property

    Public ReadOnly Property ItemTipo As String
        Get
            Return "SELECT * FROM NM_TIPO_UBICACION WHERE tub_keytub = @keytub"
        End Get
    End Property

End Class

Public Class SQLSetting
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

    Public ReadOnly Property Lista As String
        Get
            Return "SELECT * FROM SETTINGS "
        End Get
    End Property

    Public ReadOnly Property Item As String
        Get
            Return "SELECT * FROM SETTINGS WHERE set_secion = @secion AND set_sname = @sname"
        End Get
    End Property

End Class

Public Class SQLEmpresa
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

    Public ReadOnly Property Lista As String
        Get
            Return "SELECT * FROM AA_EMPRESAS WHERE cia_status = @status"
        End Get
    End Property

    Public ReadOnly Property Item As String
        Get
            Return "SELECT * FROM AA_EMPRESAS WHERE cia_keycia = @keycia"
        End Get
    End Property

    Public ReadOnly Property ListaComboID As String
        Get
            Return "SELECT cia_keycia, cia_razsoc FROM AA_EMPRESAS WHERE cia_status = @status"
        End Get
    End Property

    Public ReadOnly Property ListaComboRfc As String
        Get
            Return "SELECT cia_keycia, cia_razsoc + '|' + cia_abrevi as cia_razsoc FROM AA_EMPRESAS_CONTRATO WHERE cia_status = @status"
        End Get
    End Property

End Class

Public Class SQLSys
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

    Public ReadOnly Property Lista As String
        Get
            Return "SELECT * FROM AA_SYS WHERE sys_status = @status"
        End Get
    End Property

    Public ReadOnly Property Item As String
        Get
            Return "SELECT * FROM AA_SYS WHERE sys_keysys = @keysys"
        End Get
    End Property

End Class

Public Class SQLSysOrganizacional
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub

    Public ReadOnly Property Lista As String
        Get
            Return "SELECT * FROM AA_SYS_ORG LEFT JOIN AA_SYS_OBJ ON osy_keyosy = syo_keyosy " & _
                   " WHERE osy_keysys = @keysys AND syo_status = @status " & _
                   " ORDER BY syo_keypad, syo_dessyo"
        End Get
    End Property

    Public ReadOnly Property Item As String
        Get
            Return "SELECT * FROM AA_SYS_ORG WHERE WHERE syo_keysyo = @keysyo"
        End Get
    End Property

End Class

Public Class SQLErpSeguridades
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub
    Public ReadOnly Property Autoriza As String
        Get
            Return " SELECT * FROM SGPERFILESDETALLE WHERE PerfilID = @PerfilID AND SGFuncionID = @SGFuncionID "
        End Get
    End Property


End Class
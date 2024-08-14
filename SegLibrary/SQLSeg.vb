Imports Security_System
Public Class SQLSeg
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet
    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub
    Public ReadOnly Property ListEstructuraDetalle
        Get
            Return " SELECT ModuloPadreID, M.ModuloID, ModuloNombre, EstructuraMenuDetalleID   
                       FROM SGESTRUCTURASM_DETALLE ED LEFT JOIN SGMODULOS M ON M.ModuloID = ED.ModuloID
                      WHERE EstructuraMenuID = @EstructuraMenuID
                      ORDER BY EstructuraMenuDetalleID "
        End Get
    End Property
    Public ReadOnly Property ListModulos
        Get
            Return " SELECT * FROM SGMODULOS M
                      WHERE M.ModuloActivo = @ModuloActivo
                        AND NOT EXISTS (SELECT * FROM SGESTRUCTURASM_DETALLE ED WHERE ED.EstructuraMenuID = @EstructuraMenuID AND ED.ModuloID = M.ModuloID)"
        End Get
    End Property

End Class
Public Class SQLSettings
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet
    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub
    Public ReadOnly Property List
        Get
            Return " SELECT * FROM SGSETTINGS S LEFT JOIN SGSETTINGSS SS ON SS.SGSettingsID = S.SGSettingsID
                                                LEFT JOIN SGSETTINGSC SC ON SC.SGSettingcID = SS.SGSettingcID "
        End Get
    End Property
    Public ReadOnly Property ListxCatego
        Get
            Return " SELECT * FROM SGSETTINGS S LEFT JOIN SGSETTINGSS SS ON SS.SGSettingsID = S.SGSettingsID
                                                LEFT JOIN SGSETTINGSC SC ON SC.SGSettingcID = SS.SGSettingcID
                      WHERE SGSettingcID = @SGSettingcID "
        End Get
    End Property
    Public ReadOnly Property ListxSubCatego
        Get
            Return " SELECT * FROM SGSETTINGS S LEFT JOIN SGSETTINGSS SS ON SS.SGSettingsID = S.SGSettingsID
                                                LEFT JOIN SGSETTINGSC SC ON SC.SGSettingcID = SS.SGSettingcID
                      WHERE SGSettingsID = @SGSettingsID "
        End Get
    End Property
    Public ReadOnly Property Item
        Get
            Return " SELECT * FROM SGSETTINGS S LEFT JOIN SGSETTINGSS SS ON SS.SGSettingsID = S.SGSettingsID
                                                LEFT JOIN SGSETTINGSC SC ON SC.SGSettingcID = SS.SGSettingcID 
                      WHERE SGSettingID = SGSettingID "
        End Get
    End Property
    Public ReadOnly Property GetSettingID
        Get
            Return " SELECT * FROM SGSETTINGS WHERE SGSettingNombre = @SGSettingNombre"
        End Get
    End Property
    Public ReadOnly Property GetSubCategoriaSettingID
        Get
            Return " SELECT * FROM SGSETTINGSS WHERE SGSettingsNombre = @SGSettingsNombre"
        End Get
    End Property
    Public ReadOnly Property GetCategoriaSettingID
        Get
            Return " SELECT * FROM SGSETTINGSC WHERE SGSettingcNombre = @SGSettingcNombre"
        End Get
    End Property
End Class
Public Class SegListas
    Inherits SQL
    Private m_sLog As String
    Private Ds As New DataSet
    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub
    Public ReadOnly Property Estructuras As String
        Get
            Return "SELECT * FROM SGESTRUCTURAMENU WHERE EstructuraMenuID LIKE @EstructuraMenuID "
        End Get
    End Property
    Public ReadOnly Property Plataforma
        Get
            Return " SELECT * FROM SGPLATAFORMA "
        End Get
    End Property
    Public ReadOnly Property Usuarios
        Get
            Return " SELECT * FROM SGUSUARIOS WHERE SgActivo = 1 "
        End Get
    End Property
End Class

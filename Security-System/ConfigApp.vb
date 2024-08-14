Imports System.Windows.Forms

Public Class ConfigApp

End Class

<Serializable>
Public Class MyDataStore
    Public Property Source() As String
    Public Property DataBase() As String
    Public Property User() As String
    Public Property Password() As String
    Public ReadOnly Property InfoCnx As String
        Get
            Return Source + " | " + DataBase + " | " + User
        End Get
    End Property
    Public ReadOnly Property StringCnxSQL() As String
        Get
            Dim sStringCnx = "Data Source=@server;Initial Catalog=@dbase;Persist Security Info=True;User ID=@user;Password=@password"
            Return sStringCnx
        End Get
    End Property
    Public ReadOnly Property StringCnx As String
        Get
            Dim Cnx As String = StringCnxSQL
            Dim Cnb As System.Data.SqlClient.SqlConnectionStringBuilder = New System.Data.SqlClient.SqlConnectionStringBuilder(Cnx)
            Cnb.DataSource = Source
            Cnb.InitialCatalog = DataBase
            Cnb.Password = Password
            Cnb.UserID = User
            Return Cnb.ToString
        End Get
    End Property
End Class

Public Class MyEmpresa
    Public Property Empresa() As String
    Public Property EmpresaID() As Integer
End Class

Public Class MyDivision
    Public Property Division() As String
    Public Property DivisionID() As Integer
End Class
Public Class MyServidorFtp
    Public Property Servidor As String
    Public Property Usuario As String
    Public Property Password As String
    Public Property DirectorioRemoto As String
    Public Property DirectorioLocal As String
End Class
Public Class MyAplication
    Public Property ID() As String
    Public Property Name() As String
    Public Property DataStore() As New MyDataStore
    Public Property OthersDataStore As New List(Of MyDataStore)
    Public Property Settings() As String
    Public Property Log() As String
    Public Property ExportPath As String
    Public Property Division As New MyDivision
    Public Property Empresa As New MyEmpresa
    Public Property Estructura As Short
End Class

Public Class MySession
    Public Property Host() As String
    Public Property UserID() As Integer
    Public Property UserName() As String
    Public Property UserPasswd() As String
    Public Property PasswdQAD() As String
    Public Property UserLogin() As Boolean
    Public Property Perfil() As String
    Public Property PerfilNombre() As String
    Public Property Perfiles As Integer
    Public Property CurrentSubSistema() As String
    Public Property CurrentFunction() As String
    Public Property CurrentSubFunction() As String
    Public Property CurrentEvent() As String
    Public Property CurrentStatus() As String
    Public Property App() As New MyAplication
    Public Property ServerFTP() As New MyServidorFtp
    Public Property MyPath() As String
    Public Property PathConector() As String
    Public Property RfcEmpresa() As String
    Public Property Division() As String
    Public Property Periodo() As Date
    Public Property FiltrosStatus As New List(Of Object)
    Public Property DBLinked As String
    Public Property LnkToTeraTerm As String
    Public Property TeraTerm As String
    Public Property Extension As String
End Class

Public Class MyFunción
    Public Property SGFuncionID() As String
    Public Property SGFuncionOLEDLL() As String
    Public Property SGFuncionMaestroDetalle() As String
    Public Property SGFuncionPrimaria() As String
    Public Property SGFuncionSubsistema() As String
    Public Property SGFuncionEventosEspeciales As New List(Of MyEventoFunción)
End Class

Public Class MyEventoFunción
    Public Property EventoID As Integer
    Public Property EventoNombre As String
End Class

Public Enum EVENTOS
    EV_CONSULTAR
    EV_NUEVO
    EV_ELIMINAR
    EV_RECUPERAR
    EV_PROPIEDADES
    EV_LISTAR
    EV_EXPORTAR
    EV_GRAFICAR
    EV_ESPECIAL1
    EV_ESPECIAL2
    EV_ESPECIAL3
    EV_ESPECIAL4
    EV_ESPECIAL5
    EV_ESPECIAL6
    EV_ESPECIAL7
    EV_ESPECIAL8
    EV_ESPECIAL9
    EV_ESPECIAL10
    OP_AYUDA
End Enum

Public Class Nivel
    Public Property NombreNivel() As String
    Public Property LabelNivel() As ToolStripLabel
    Public Property ComboNivel() As ToolStripComboBox
    Public Property Mostrar() As Boolean = False
End Class

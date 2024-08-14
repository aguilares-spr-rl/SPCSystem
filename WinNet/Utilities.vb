Imports System.IO
Imports System.Reflection
Imports System.Resources
Public Class Utilities
    Public Shared Function GetImageFromResource(ByVal imgName As String) As Bitmap
        GetImageFromResource = Nothing
        Try
            Dim bmp As Bitmap = Nothing
            Dim type As Type = GetType(Utilities)
            Dim fullResourceName As String = String.Format("VBWinNet.Images.{0}", imgName)
            Dim stream As Stream = type.Assembly.GetManifestResourceStream(fullResourceName)

            If (Not stream Is Nothing) Then
                bmp = Image.FromStream(stream)
            End If
            Return bmp

        Catch ex As Exception

        End Try
    End Function

    Public Shared Function GetEmbeddedResourceStream(ByVal resourceName As String) As Stream
        GetEmbeddedResourceStream = Nothing
        Try
            Dim stream As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
            Debug.Assert(stream Is Nothing, "Unable to locate embedded resource.", "Resource name: {0}", resourceName)
            Return stream
        Catch ex As Exception

        End Try
    End Function
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
    Public Shared Function GetDataStoreInfoEncript(Optional ByVal sDataStore As String = "") As String
        GetDataStoreInfoEncript = String.Empty
        Try
            Dim Store As New UMyDataStore
            If sDataStore <> "" Then
                Store.Source = System.Configuration.ConfigurationManager.AppSettings("DataSource" + sDataStore)
                Store.DataBase = System.Configuration.ConfigurationManager.AppSettings("DataBase" + sDataStore)
                Store.User = DesEncriptar(System.Configuration.ConfigurationManager.AppSettings("User" + sDataStore))
                Store.Password = DesEncriptar(System.Configuration.ConfigurationManager.AppSettings("Password" + sDataStore))
            Else
                Store.Source = System.Configuration.ConfigurationManager.AppSettings("DataSource")
                Store.DataBase = System.Configuration.ConfigurationManager.AppSettings("DataBase")
                Store.User = DesEncriptar(System.Configuration.ConfigurationManager.AppSettings("User"))
                Store.Password = DesEncriptar(System.Configuration.ConfigurationManager.AppSettings("Password"))
            End If
            Return Store.StringCnxSQL
        Catch ex As Exception
            Dim s As String = ex.Message
        End Try
    End Function

End Class

Public Class UMyDataStore
    Public Property Source As String
    Public Property DataBase As String
    Public Property User As String
    Public Property Password As String
    Public ReadOnly Property StringCnxSQL As String
        Get
            Dim sStringCnx As String = "Data Source=@server;Initial Catalog=@dbase;Persist Security Info=True;User ID=@user;Password=@password"
            Dim Cnb As New System.Data.SqlClient.SqlConnectionStringBuilder(sStringCnx)
            Cnb.DataSource = Source
            Cnb.InitialCatalog = DataBase
            Cnb.Password = Password
            Cnb.UserID = User
            Return Cnb.ToString
        End Get
    End Property
End Class

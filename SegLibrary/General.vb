Imports System.IO
Imports Security_System
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Module General
    Public oUsr As MySession
    Public Function Maneja_Error(oErr As Exception, Optional ByVal sRutina As String = "") As MsgBoxResult
        Dim sBody As String = String.Empty
        Dim sTitulo As String = String.Empty
        Maneja_Error = MsgBoxResult.Ignore

        Try
            sTitulo = "¡Condición Anormal!"
            sBody = "Rutina: " + sRutina & vbCrLf
            sBody += oErr.Message & vbCrLf
            sBody += oErr.Source

            Maneja_Error = MsgBox(sBody, MsgBoxStyle.AbortRetryIgnore, sTitulo)

        Catch ex As Exception
            MsgBox("ERROR | ERROR", MsgBoxStyle.Critical, "MANEJA ERROR")

        End Try

    End Function
    Public Sub LoadCombo(ByVal oCmbx As ComboBox, ByVal View As DataView)
        Try
            With oCmbx
                .DataSource = View
                .ValueMember = View.Table.Columns(0).ColumnName
                .DisplayMember = View.Table.Columns(1).ColumnName
                .SelectedIndex = -1
            End With
        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub
    Public Sub GetIndex(ByRef oCB As ComboBox, ByVal iTem As Integer, ByVal Val As Object)
        Try
            oCB.SelectedIndex = 0
            For Each NextItem As DataRowView In oCB.Items
                If NextItem.Item(iTem).ToString = Val Then
                    oCB.SelectedItem = NextItem
                    Exit For
                End If
            Next
        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)

        End Try
    End Sub

#Region "UGrid"
    Public Sub IniLista(ByVal oTabla As DataTable, ByVal UGrid As UltraGrid, ByVal banda As Integer)
        Dim ItemKey As Integer = 0
        Dim ItemDes As Integer = 1
        If oTabla Is Nothing Then
            Exit Sub
        End If
        Try
            If UGrid.DisplayLayout.ValueLists.Exists(oTabla.TableName) Then
                Exit Sub
            End If

            If Not oTabla Is Nothing Then
                Dim valueList As ValueList = UGrid.DisplayLayout.ValueLists.Add(oTabla.TableName)
                For Each Dr As DataRow In oTabla.Rows
                    valueList.ValueListItems.Add(Dr(ItemKey), Dr(ItemDes).ToString)
                Next
                Dim column As UltraGridColumn = UGrid.DisplayLayout.Bands(banda).Columns(oTabla.Columns(ItemKey).ColumnName)
                column.ValueList = valueList
                column.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate
            End If

        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub
#End Region 'UGrid
End Module
Class Utilities
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
Class UMyDataStore
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
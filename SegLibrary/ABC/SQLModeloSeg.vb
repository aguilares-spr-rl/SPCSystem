Imports Security_System
Public Class SQLModeloSeg

End Class
Public Class SgUsuarios
    Inherits Sql
    Private m_sLog As String
    Private Ds As New DataSet

    Public Sub New(ByVal oUsr As MySession)
        MyBase.New(oUsr)
        m_sLog = oUsr.App.Log
    End Sub
    Public ReadOnly Property List As String
        Get
            Return "SELECT * FROM SGUSUARIOS WHERE SgActivo = @SgActivo"
        End Get
    End Property
    Public ReadOnly Property Item As String
        Get
            Return "SELECT * FROM SGUSUARIOS WHERE SgUserID = @SgUserID"
        End Get
    End Property
    Public ReadOnly Property UpdPass As String
        Get
            Return "UPDATE SGUSUARIOS SET SgUserPasswd = @SgUserPasswd WHERE SgUserID = @SgUserID"
        End Get
    End Property

End Class
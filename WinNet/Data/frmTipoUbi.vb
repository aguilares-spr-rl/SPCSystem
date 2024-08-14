Public Class frmTipoUbi
    Private Sub TIPOUBICABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TIPOUBICABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TIPOUBICABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSAgroGem)

    End Sub

    Private Sub frmTipoUbi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSAgroGem.TIPOUBICA' Puede moverla o quitarla según sea necesario.
        Me.TIPOUBICATableAdapter.Fill(Me.DSAgroGem.TIPOUBICA)

    End Sub
End Class
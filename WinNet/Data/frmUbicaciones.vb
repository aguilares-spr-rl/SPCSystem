Public Class frmUbicaciones
    Private Sub UBICACIONESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UBICACIONESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UBICACIONESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSAgroGem)

    End Sub

    Private Sub frmUbicaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSAgroGem.UBICACIONES' Puede moverla o quitarla según sea necesario.
        Me.UBICACIONESTableAdapter.Fill(Me.DSAgroGem.UBICACIONES)

    End Sub
End Class
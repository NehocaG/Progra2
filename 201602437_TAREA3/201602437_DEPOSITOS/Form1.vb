Public Class Form1
    Private Sub CBPropios_CheckedChanged(sender As Object, e As EventArgs) Handles CBPropios.CheckedChanged
        If CBPropios.Checked = True Then
            TBPropio.Visible = True
            TBPropio.Text = " "
        Else
            TBPropio.Visible = False
        End If
    End Sub

    Private Sub CBOtros_CheckedChanged(sender As Object, e As EventArgs) Handles CBOtros.CheckedChanged
        If CBOtros.Checked = True Then
            TBOtros.Visible = True
            TBOtros.Text = " "
        Else
            TBOtros.Visible = False
        End If
    End Sub

    Private Sub CBefectivo_CheckedChanged(sender As Object, e As EventArgs) Handles CBefectivo.CheckedChanged
        If CBefectivo.Checked = True Then
            TBEfectivo.Visible = True
            TBEfectivo.Text = " "
        Else
            TBEfectivo.Visible = False

        End If
    End Sub


    Private Sub RBAhorro_CheckedChanged(sender As Object, e As EventArgs) Handles RBAhorro.CheckedChanged
        If RBAhorro.Checked = True Then

        Else

        End If
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles BLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Salir()
    End Sub

    Private Sub BCalcular_Click(sender As Object, e As EventArgs) Handles BCalcular.Click
        Calcular()
    End Sub

    Private Sub BBorrar_Click(sender As Object, e As EventArgs) Handles BBorrar.Click
        If (MsgBox("¿Desea borrar los datos?", vbQuestion + vbYesNo, "Mensaje para Borrar") = vbYes) Then
            Borrar()
        End If
    End Sub
End Class

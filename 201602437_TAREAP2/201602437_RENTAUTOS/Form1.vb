Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Honda")
        ComboBox1.Items.Add("Mercedes Benz")
        ComboBox1.Items.Add("Toyota")
        ComboBox1.Items.Add("Mazda")
    End Sub
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If indice <= 6 Then
            Efectivo(indice) = TBefectivo.Text
            Tarjeta(indice) = TBTarjeta.Text
            Porcentaje(indice) = Efectivo(indice) + Tarjeta(indice)
            If Porcentaje(indice) = 100 Then
                If ComboBox1.Text = "Honda" Then
                    MARCA(indice) = 250
                ElseIf ComboBox1.Text = "Mercedes Benz" Then
                    MARCA(indice) = 450
                ElseIf ComboBox1.Text = "Toyota" Then
                    MARCA(indice) = 325
                ElseIf ComboBox1.Text = "Mazda" Then
                    MARCA(indice) = 300
                End If
                Calcular()
            Else
                MsgBox("Se tiene que cobrar el 100%")
            End If
        Else
            MsgBox("Listas llenas")
        End If

    End Sub
    Private Sub CBEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles CBEfectivo.CheckedChanged
        If CBEfectivo.Checked = True Then
            TBefectivo.Visible = True
            TBefectivo.Text = ""
        Else
            TBefectivo.Visible = False
            TBefectivo.Text = "0"
        End If
    End Sub
    Private Sub CBTarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles CBTarjeta.CheckedChanged
        If CBTarjeta.Checked = True Then
            TBTarjeta.Visible = True
            TBTarjeta.Text = ""
        Else
            TBTarjeta.Visible = False
            TBTarjeta.Text = "0"
        End If
    End Sub
    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        LimpiarEntras()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Salir()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        LimpiasListas()
    End Sub
End Class

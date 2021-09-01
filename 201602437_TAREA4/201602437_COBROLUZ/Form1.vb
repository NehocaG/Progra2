Public Class Form1
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Residencial")
        ComboBox1.Items.Add("Industrial")
        ComboBox2.Items.Add("Social")
        ComboBox2.Items.Add("No social")

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Salir()
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        LimpiarEntradas()
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If TxtNombre.Text = "" Or TxtNIT.Text = "" Or TxtSaldo.Text = "" Or TxtConsumo.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Por favor llenar todos los campos")
        End If
        Calcular()
        Mostrar()
    End Sub

    Private Sub LimpiarListasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListasToolStripMenuItem.Click
        LimpiarLista()

    End Sub
End Class

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Efectivo")
        ComboBox1.Items.Add("Tarjeta")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Salir()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        Limpiar_Entradas()
    End Sub

    Private Sub ProcesarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesarToolStripMenuItem.Click
        Proceso()
    End Sub

    Private Sub FacturarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturarToolStripMenuItem.Click
        Facturar()

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Limpiar_Vectores()
    End Sub
End Class

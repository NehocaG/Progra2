Public Class Form1
    Private Sub MostrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem1.Click
        MCodigo()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Salir()
    End Sub

    Private Sub OperarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OperarToolStripMenuItem1.Click
        MCodigo()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem1.Click
        Limpiar_Entradas()
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
        ListBox8.Items.Clear()
        ListBox9.Items.Clear()
    End Sub

    Private Sub LimpiarEstadisticasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LimpiarEstadisticasToolStripMenuItem1.Click
        Label19.Text = ""
        Label18.Text = ""
        Label17.Text = ""
    End Sub
End Class

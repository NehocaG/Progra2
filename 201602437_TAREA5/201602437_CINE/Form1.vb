Public Class Form1
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
        ComboBox1.Items.Add("4")
        ComboBox2.Items.Add("A")
        ComboBox2.Items.Add("B")
        ComboBox2.Items.Add("C")
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        Calcular()



    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Close()
        End If
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub LimpiarListasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListasToolStripMenuItem.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        Función.Items.Clear()
        Cine.Items.Clear()
        Subtotal.Items.Clear()
        Descuento1.Items.Clear()
        Descuento2.Items.Clear()
        Total.Items.Clear()
    End Sub
End Class

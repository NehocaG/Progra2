Public Class Form1
    Public Nombre As String
    Public Monto As Double
    Public Regin As Double
    Public Bono As Double
    Public Comision As Double
    Public Remuneracion As Double
    Public Sueldo As Double
    Const BASE = 3800


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        Label7.Text = " "
        Label6.Text = " "
        Label5.Text = " "
        Label4.Text = " "
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        Nombre = TextBox1.Text
        Monto = TextBox2.Text
        Label4.Text = "Nombre del Vendedor: " + Nombre
        If RadioButton1.Checked = True Then
            Regin = 150
        ElseIf RadioButton2.Checked = True Then
            Regin = 175
        ElseIf RadioButton3.Checked = True Then
            Regin = 200
        ElseIf RadioButton4.Checked = True Then
            Regin = 225
        End If
        Label7.Text = "Viaticos: Q" + Str(System.Math.Round(Regin, 2))
        If RadioButton5.Checked = True Then
            Bono = Monto * 0.03
            Label5.Text = "Monto de Incentivo: Q" + Str(System.Math.Round(Bono, 2))
        End If
        If RadioButton6.Checked = True Then
            Comision = Monto * 0.05
            Label5.Text = "Monto de Incentivo: Q" + Str(System.Math.Round(Comision, 2))
        End If
        Remuneracion = Monto + Bono + Comision
        Label6.Text = "Remumeració: Q" + Str(System.Math.Round(Remuneracion, 2))

        Sueldo = Remuneracion + Regin + BASE
        Label8.Text = "SueldoFinal: Q" + Str(System.Math.Round(Remuneracion, 2))
    End Sub

End Class

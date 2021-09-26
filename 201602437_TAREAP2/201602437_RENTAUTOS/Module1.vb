Module Module1
    Public MARCA(6) As Double
    Public Efectivo(6) As Double
    Public Tarjeta(6) As Double
    Public Porcentaje(6) As Double
    Public Dias(6) As Double
    Public PagoParcial(6) As Double
    Public Descuento(6) As Double
    Public Recargo(6) As Double
    Public Total(6) As Double
    Public indice As Double = 1
    Sub Calcular()
        Dias(indice) = Form1.TBDias.Text
        If indice <= 6 Then
            PagoParcial(indice) = Dias(indice) * MARCA(indice)
            If Efectivo(indice) = 100 Then
                Descuento(indice) = PagoParcial(indice) * 0.05
                Form1.ListBox5.Items.Add(Descuento(indice))
            Else
                Descuento(indice) = 0
            End If
            If Tarjeta(indice) = 100 Then
                Recargo(indice) = PagoParcial(indice) * 0.025
                Form1.ListBox5.Items.Add(Recargo(indice))
            Else
                Recargo(indice) = 0
            End If
            Total(indice) = PagoParcial(indice) - Descuento(indice) + Recargo(indice)
            Form1.ListBox1.Items.Add(Form1.TBPlaca.Text)
            Form1.ListBox2.Items.Add(Form1.ComboBox1.Text)
            Form1.ListBox3.Items.Add(Form1.TBDias.Text)
            Form1.ListBox4.Items.Add(PagoParcial(indice))
            Form1.ListBox6.Items.Add(Total(indice))
            indice = 1 + indice

        End If
    End Sub
    Sub Salir()
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Form1.Close()
        End If
    End Sub
    Sub LimpiarEntras()
        Form1.CBEfectivo.Checked = False
        Form1.CBTarjeta.Checked = False
        Form1.ComboBox1.Text = ""
        Form1.TBNIT.Text = ""
        Form1.TBPlaca.Text = ""
        Form1.TBTarjeta.Text = "0"
        Form1.TBDias.Text = ""
        Form1.TBefectivo.Text = "0"
    End Sub
    Sub LimpiasListas()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
    End Sub
End Module

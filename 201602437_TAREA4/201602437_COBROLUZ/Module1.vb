Module Module1
    Public Indice As Byte = 1
    Public Servicio(11) As String
    Public Tarifa(11) As String
    Public SaldoAnte(11) As Double
    Public KW(11) As Double
    Public PagoIni(11) As Double
    Public Mora(11) As Double
    Public Descuento(11) As Double
    Public TotalPagar(11) As Double
    Sub Calcular()
        If Indice <= 11 Then
            Servicio(Indice) = Form1.ComboBox1.Text
            Tarifa(Indice) = Form1.ComboBox2.Text
            SaldoAnte(Indice) = Form1.TxtSaldo.Text
            KW(Indice) = Form1.TxtConsumo.Text
            If Form1.ComboBox1.Text = "Residencial" Then
                Select Case KW(Indice)
                    Case Is < 100
                        PagoIni(Indice) = KW(Indice) * 0.99
                    Case Is < 300
                        PagoIni(Indice) = KW(Indice) * 1.2
                    Case Is >= 301
                        PagoIni(Indice) = KW(Indice) * 3
                End Select
            End If
            If Form1.ComboBox1.Text = "Industrial" Then
                Select Case KW(Indice)
                    Case Is < 100
                        PagoIni(Indice) = KW(Indice) * 1.99
                    Case Is < 300
                        PagoIni(Indice) = KW(Indice) * 2.2
                    Case Is >= 301
                        PagoIni(Indice) = KW(Indice) * 4
                End Select
            End If
            Mora(Indice) = SaldoAnte(Indice) * 0.02
            If Form1.ComboBox2.Text = "Social" Then
                Descuento(Indice) = (PagoIni(Indice) + Mora(Indice) + SaldoAnte(Indice)) * 0.2
            ElseIf Form1.ComboBox2.Text = "No social" Then
                Descuento(Indice) = PagoIni(Indice) * 0.1
            End If
            TotalPagar(Indice) = PagoIni(Indice) + SaldoAnte(Indice) + Mora(Indice) - Descuento(Indice)
        End If
        If Indice = 12 Then
            MsgBox("Las listas estan llenas, borrar listas para continuar")
        End If
    End Sub
    Sub Mostrar()
        Form1.ListBox1.Items.Add(Servicio(Indice))
        Form1.ListBox2.Items.Add(Tarifa(Indice))
        Form1.ListBox3.Items.Add(SaldoAnte(Indice))
        Form1.ListBox4.Items.Add(PagoIni(Indice))
        Form1.ListBox5.Items.Add(Mora(Indice))
        Form1.ListBox6.Items.Add(Descuento(Indice))
        Form1.ListBox7.Items.Add(TotalPagar(Indice))
    End Sub
    Sub LimpiarEntradas()
        Form1.TxtNombre.Clear()
        Form1.TxtNIT.Clear()
        Form1.TxtSaldo.Clear()
        Form1.TxtConsumo.Clear()
        Form1.ComboBox1.Text = " "
        Form1.ComboBox2.Text = " "
    End Sub

    Sub LimpiarLista()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
    End Sub
    Sub Salir()
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Form1.Close()
        End If
    End Sub
End Module

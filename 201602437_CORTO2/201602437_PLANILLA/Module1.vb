Module Module1
    Public Salario(6) As Double
    Public Descuento(6) As Double
    Public Sueldo(6) As Double
    Public Indice As Double = 1

    Sub Calcular()
        If Indice <= 6 Then
            Salario(Indice) = Form1.TextBox2.Text
            If Form1.ComboBox1.Text = "IGSS" Then
                Descuento(Indice) = Salario(Indice) * 0.15
            ElseIf Form1.ComboBox1.Text = "ISR" Then
                Descuento(Indice) = Salario(Indice) * 0.06
            End If
            Sueldo(Indice) = Salario(Indice) - Descuento(Indice)
            Form1.ListBox3.Items.Add(Descuento(Indice))
            Form1.ListBox4.Items.Add(Sueldo(Indice))
            Form1.ListBox2.Items.Add(Salario(Indice))
            Indice = 1 + Indice
        Else
            MsgBox("Listas llenas")
        End If

    End Sub
    Sub Limpiar()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
    End Sub
    Sub Salir()
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Form1.Close()
        End If
    End Sub
End Module

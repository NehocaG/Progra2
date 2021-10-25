Module Module1
    Public Codigo(6) As String
    Public Nombre(6) As String
    Public Precio(6) As Double
    Public Defectuosas(6) As Double
    Public Aprobada(6) As Double
    Public Ganancia(6) As Double
    Public Perdida(6) As Double
    Public Total(6) As Double
    Public Sello(6) As String
    Public I As Byte = 1
    Sub MCodigo()
        If I <= 6 Then
            If Form1.RadioButton1.Checked = True Then
                Codigo(I) = "L01"
            End If
            If Form1.RadioButton2.Checked = True Then
                Codigo(I) = "L02"
            End If
            If Form1.RadioButton3.Checked = True Then
                Codigo(I) = "L03"
            End If
            If Form1.RadioButton4.Checked = True Then
                Codigo(I) = "L04"
            End If
            If Form1.RadioButton5.Checked = True Then
                Codigo(I) = "L05"
            End If
            If Form1.RadioButton6.Checked = True Then
                Codigo(I) = "L06"
            End If
            If Form1.RadioButton1.Checked = True Then
                Nombre(I) = "Memoria RAM"
            End If
            If Form1.RadioButton2.Checked = True Then
                Nombre(I) = "Disco Duro"
            End If
            If Form1.RadioButton3.Checked = True Then
                Nombre(I) = "Procesador"
            End If
            If Form1.RadioButton4.Checked = True Then
                Nombre(I) = "MotherBoard"
            End If
            If Form1.RadioButton5.Checked = True Then
                Nombre(I) = "Tarjeta Gráfica"
            End If
            If Form1.RadioButton6.Checked = True Then
                Codigo(I) = "SSD"
            End If
            Precio(I) = Form1.TextBox1.Text
            Defectuosas(I) = Form1.TextBox3.Text
            Aprobada(I) = Form1.TextBox2.Text

            Ganancia(I) = Precio(I) * Defectuosas(I) + Precio(I) * Aprobada(I)
            Perdida(I) = Precio(I) * Defectuosas(I) * 0.75
            Total(I) = Ganancia(I) - Perdida(I)
            If Defectuosas(I) = 0 Then
                Sello(I) = "SI"
            Else
                Sello(I) = "NO"
            End If
            Form1.ListBox1.Items.Add(Codigo(I))
            Form1.ListBox2.Items.Add(Nombre(I))
            Form1.ListBox3.Items.Add(Precio(I))
            Form1.ListBox4.Items.Add(Defectuosas(I))
            Form1.ListBox5.Items.Add(Aprobada(I))
            Form1.ListBox6.Items.Add(Ganancia(I))
            Form1.ListBox7.Items.Add(Perdida(I))
            Form1.ListBox8.Items.Add(Total(I))
            Form1.ListBox9.Items.Add(Sello(I))
            I = 1 + I
        End If


    End Sub

    Sub Salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        End If
    End Sub

    Sub Limpiar_Entradas()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.TextBox4.Text = ""
    End Sub
End Module

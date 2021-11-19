Module Module1
    Public ID(10) As Double
    Public Noches(10) As Double
    Public Personas(10) As Double
    Public Tipo(10) As String
    Public Precio(10) As Double
    Public Parcial(10) As Double
    Public Descu(10) As Double
    Public Recar(10) As Double
    Public Total(10) As Double
    Public contador As Byte = 1
    Public I As Byte = 1

    Sub Acepta()
        If I <= 10 Then
            ID(I) = Form1.TextBox1.Text
            Noches(I) = Form1.TextBox2.Text
            Personas(I) = Form1.TextBox3.Text
            Tipo(I) = Form1.ComboBox1.Text
            If Form1.ComboBox1.Text = "Simple" Then
                Precio(I) = 150
            ElseIf Form1.ComboBox1.Text = "Familiar" Then
                Precio(I) = 400
            Else
                Precio(I) = 750
            End If
            Parcial(I) = Precio(I) * Noches(I)
            If Form1.ComboBox1.Text = "Simple" And Noches(I) >= 7 Then
                Descu(I) = Parcial(I) * 0.1
            ElseIf Form1.ComboBox1.Text = "Familiar" And Noches(I) >= 4 Then
                Descu(I) = Parcial(I) * 0.07
            ElseIf Form1.ComboBox1.Text = "Suite" And Personas(I) = 2 And Noches(I) > 15 Then
                Descu(I) = Parcial(I) * 0.2
            Else
                Descu(I) = 0
            End If
            If Form1.ComboBox1.Text = "Simple" And Personas(I) > 3 Then
                Recar(I) = Parcial(I) * 0.05
            Else
                Recar(I) = 0
            End If
            Total(I) = Parcial(I) + Recar(I) - Descu(I)
        End If

    End Sub

    Sub Mostra()

        Form1.ListBox1.Items.Add(ID(I))
        Form1.ListBox2.Items.Add(Noches(I))
        Form1.ListBox3.Items.Add(Personas(I))
        Form1.ListBox4.Items.Add(Tipo(I))
        Form1.ListBox5.Items.Add(Parcial(I))
        Form1.ListBox6.Items.Add(Descu(I))
        Form1.ListBox7.Items.Add(Recar(I))
        Form1.ListBox8.Items.Add(Total(I))
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
        Form1.ComboBox1.Text = ""
    End Sub
    Sub Limpiar_Matriz()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
    End Sub

End Module


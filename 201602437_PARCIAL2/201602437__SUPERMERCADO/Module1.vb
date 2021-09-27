Module Module1
    Public precio(6) As Double
    Public Cantidad(6) As Double
    Public Subtotal(6) As Double
    Public Descuento(6) As Double
    Public Subgeneral As Double
    Public DescuGeneral As Double
    Public Recargo As Double
    Public total As Double
    Public indice As Double = 1
    Sub Proceso()
        If indice <= 6 Then
            precio(indice) = Form1.TextBox5.Text
            Cantidad(indice) = Form1.TextBox6.Text
            Subtotal(indice) = precio(indice) * Cantidad(indice)
            If Cantidad(indice) >= 5 Then
                Descuento(indice) = Subtotal(indice) * 0.05
            End If
            Form1.ListBox1.Items.Add(Form1.TextBox4.Text)
            Form1.ListBox2.Items.Add(Form1.TextBox5.Text)
            Form1.ListBox3.Items.Add(Form1.TextBox6.Text)
            Form1.ListBox4.Items.Add(Subtotal(indice))
            indice = 1 + indice

        Else
            MsgBox("Llego al maximo de productos")
        End If
    End Sub
    Sub Facturar()
        Subgeneral = Subtotal(1) + Subtotal(2) + Subtotal(3) + Subtotal(4) + Subtotal(5) + Subtotal(6)
        DescuGeneral = Descuento(1) + Descuento(2) + Descuento(3) + Descuento(4) + Descuento(5) + Descuento(6)
        If Form1.ComboBox1.Text = "Tarjeta" Then
            Recargo = Subgeneral * 0.08
        End If
        total = Subgeneral - DescuGeneral + Recargo
        Form1.Label12.Text = "Nit: " + Form1.TextBox1.Text
        Form1.Label13.Text = "Nombre: " + Form1.TextBox2.Text
        Form1.Label14.Text = "Dirección: " + Form1.TextBox3.Text
        Form1.Label15.Text = Subgeneral
        Form1.Label16.Text = "Subtotal: "
        Form1.Label17.Text = "Descuento: "
        Form1.Label18.Text = DescuGeneral
        Form1.Label19.Text = "Recargo: "
        Form1.Label20.Text = Recargo
        Form1.Label21.Text = "Total a pagar: "
        Form1.Label22.Text = total
    End Sub
    Sub Limpiar_Vectores()
        Form1.Label12.Text = ""
        Form1.Label13.Text = ""
        Form1.Label14.Text = ""
        Form1.Label15.Text = ""
        Form1.Label16.Text = ""
        Form1.Label17.Text = ""
        Form1.Label18.Text = ""
        Form1.Label19.Text = ""
        Form1.Label20.Text = ""
        Form1.Label21.Text = ""
        Form1.Label22.Text = ""
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
    End Sub
    Sub Salir()
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Form1.Close()
        End If
    End Sub
    Sub Limpiar_Entradas()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.TextBox4.Text = ""
        Form1.TextBox5.Text = ""
        Form1.TextBox6.Text = ""
        Form1.ComboBox1.Text = ""
    End Sub
End Module

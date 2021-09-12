Module Module1
    Public VFuncion(8)
    Public VCine(8)
    Public SubTo(8)
    Public Descuen1(8)
    Public Descuen2(8)
    Public VTotal(8)
    Public Cantidad As Double
    Public Precio As Double = 0
    Public Desc1 As Double = 0
    Public Desc2 As Double = 0


    Public indice = 0

    Function Canti(Funcion As String, Cine As String) As Double
        Select Case Cine
            Case "A"
                Select Case Funcion
                    Case 1
                        Precio = 30
                    Case 2
                        Precio = 35
                    Case Else
                        Precio = 40
                End Select
            Case "B"
                Select Case Funcion
                    Case 1
                        Precio = 24
                    Case 2
                        Precio = 34
                    Case Else
                        Precio = 44
                End Select
            Case "C"
                Select Case Funcion
                    Case 1
                        Precio = 35
                    Case 2
                        Precio = 40
                    Case Else
                        Precio = 50
                End Select
        End Select
        Return Precio
    End Function

    Function Descuento_1(Funcion As String, Cine As String) As Double
        If (Funcion = "3" Or Funcion = "4") And (Cine = "C" Or Cine = "B") Then
            Desc1 = 0.055
        ElseIf (Funcion = "1") And (Cine = "C" Or Cine = "B") Then
            Desc1 = 0.03
        ElseIf (Funcion = "2") And (Cine = "A") Then
            Desc1 = 0.015
        End If

        Return Desc1
    End Function
    Sub Calcular()
        If indice < 9 Then
            VFuncion(indice) = Form1.ComboBox1.SelectedItem
            VCine(indice) = Form1.ComboBox2.SelectedItem
            Cantidad = Form1.TextBox1.Text
            SubTo(indice) = Canti(VFuncion(indice), VCine(indice)) * Cantidad
            Descuen1(indice) = Descuento_1(VFuncion(indice), VCine(indice)) * SubTo(indice)

            Select Case SubTo(indice)
                Case 100 To 300
                    Desc2 = 0.02
                Case 300 To 500
                    Desc2 = 0.04
                Case 500 To 1000
                    Desc2 = 0.06
            End Select

            Descuen2(indice) = Desc2 * SubTo(indice)
            VTotal(indice) = SubTo(indice) - Descuen1(indice) - Descuen2(indice)


            Form1.Función.Items.Add(VFuncion(indice))
            Form1.Cine.Items.Add(VCine(indice))
            Form1.Subtotal.Items.Add(SubTo(indice))
            Form1.Descuento1.Items.Add(Descuen1(indice))
            Form1.Descuento2.Items.Add(Descuen2(indice))
            Form1.Total.Items.Add(VTotal(indice))
            indice = indice + 1
        Else
            MsgBox("Listas llenas, por favor limpiar")

        End If
    End Sub

End Module



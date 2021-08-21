Module Module1
    Public Tamaño As Double
    Public Lino As Double
    Public Algodon As Double
    Public Seda As Double
    Public Hilo As Double
    Public Yarda As Double
    Public Costo As Double
    Public Precio As Double
    Public Rlino As Double
    Public Ralgo As Double
    Public Rseda As Double
    Public RHilo As Double

    Sub Limpiar()
        Form1.RBImperial.Checked = False
        Form1.RBMatrimonial.Checked = False
        Form1.RBQueen.Checked = False
        Form1.RBKing.Checked = False
        Form1.CBSeda.Checked = False
        Form1.CBLino.Checked = False
        Form1.CBAlgodon.Checked = False
        Form1.CBHilo.Checked = False
        Form1.TBLino.Text = "0 "
        Form1.TBalgo.Text = " 0"
        Form1.TBseda.Text = "0 "
        Form1.TBhilo.Text = "0 "
        Form2.RELino.Text = " "
        Form2.REAlgo.Text = " "
        Form2.RESeda.Text = " "
        Form2.REHilo.Text = " "
    End Sub
    Sub Salir()
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Form1.Close()
        End If
    End Sub
    Sub Calcular()
        Lino = Form1.TBLino.Text
        Algodon = Form1.TBalgo.Text
        Seda = Form1.TBseda.Text
        Hilo = Form1.TBhilo.Text

        Yarda = Lino + Algodon + Seda + Hilo

        If Form1.RBImperial.Checked = True And Yarda = 3 Then
            Form1.Hide()
            Form2.Show()
        ElseIf Form1.RBMatrimonial.Checked = True And Yarda = 5 Then
            Form1.Hide()
            Form2.Show()
        ElseIf Form1.RBQueen.Checked = True And Yarda = 6 Then
            Form1.Hide()
            Form2.Show()
        ElseIf Form1.RBKing.Checked = True And Yarda = 7 Then
            Form1.Hide()
            Form2.Show()
        Else
            MsgBox("Yardas no validas")
        End If

        If Form1.CBLino.Checked = True Then
            Rlino = 15 * Lino
        End If
        Form2.RELino.Text = "Q" + Str(System.Math.Round(Rlino, 2))

        If Form1.CBAlgodon.Checked = True Then
            Ralgo = 23.99 * Algodon
        End If
        Form2.REAlgo.Text = "Q" + Str(System.Math.Round(Ralgo, 2))

        If Form1.CBSeda.Checked = True Then
            Rseda = 30.99 * Seda
        End If
        Form2.RESeda.Text = "Q" + Str(System.Math.Round(Rseda, 2))

        If Form1.CBHilo.Checked = True Then
            RHilo = 39.99 * Hilo
        End If
        Form2.REHilo.Text = "Q" + Str(System.Math.Round(RHilo, 2))

        Costo = Tamaño + Rlino + Ralgo + Rseda + RHilo
        Form2.LbCos.Text = "Q" + Str(System.Math.Round(Costo, 2))

        Precio = Costo * 1.65
        Form2.LbPre.Text = "Q" + Str(System.Math.Round(Precio, 2))

    End Sub
End Module

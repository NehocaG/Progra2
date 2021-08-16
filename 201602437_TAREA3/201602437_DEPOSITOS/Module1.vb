Module Module1
    Public DepoPropio As Double
    Public DepoOtros As Double
    Public DepoEfectivo As Double
    Public TotalDepo As Double
    Public Saldo As Double
    Public IntPremi As Double
    Public IntAhorro As Double

    Sub Limpiar()
        Form1.RBMonetario.Checked = False
        Form1.RBMonetarioPremi.Checked = False
        Form1.RBAhorro.Checked = False
        Form1.CBPropios.Checked = False
        Form1.CBOtros.Checked = False
        Form1.CBefectivo.Checked = False
        Form1.LbAhorro.Visible = False
        Form1.LbMonPre.Visible = False
        Form1.LbTD.Visible = False
        Form1.LSA.Visible = False
        Form1.LbSalAct.Text = " "
        Form1.LbInteres.Text = " "
        Form1.LbTotalDe.Text = " "
        Form1.TBPropio.Text = "0 "
        Form1.TBOtros.Text = " 0"
        Form1.TBEfectivo.Text = "0 "
    End Sub

    Sub Borrar()
        Saldo = 0
        Form1.RBMonetario.Checked = False
        Form1.RBMonetarioPremi.Checked = False
        Form1.RBAhorro.Checked = False
        Form1.CBPropios.Checked = False
        Form1.CBOtros.Checked = False
        Form1.CBefectivo.Checked = False
        Form1.LbAhorro.Visible = False
        Form1.LbMonPre.Visible = False
        Form1.LbTD.Visible = False
        Form1.LSA.Visible = False
        Form1.LbSalAct.Text = " "
        Form1.LbInteres.Text = " "
        Form1.LbTotalDe.Text = " "
        Form1.TBPropio.Text = "0 "
        Form1.TBOtros.Text = " 0"
        Form1.TBEfectivo.Text = "0 "
    End Sub

    Sub Calcular()
        Form1.LbTD.Visible = True
        Form1.LSA.Visible = True

        DepoPropio = Form1.TBPropio.Text
        DepoOtros = Form1.TBOtros.Text
        DepoEfectivo = Form1.TBEfectivo.Text
        TotalDepo = DepoPropio + DepoOtros + DepoEfectivo
        Form1.LbTotalDe.Text = "Q" + Str(System.Math.Round(TotalDepo, 2))



        If Form1.RBMonetarioPremi.Checked = True Then
            Form1.LbMonPre.Visible = True
            Select Case Saldo
                Case Is < 10001
                    IntPremi = Saldo * 0.025
                Case Is < 15001
                    IntPremi = Saldo * 0.03
                Case Is > 15001
                    IntPremi = Saldo * 0.045
            End Select
            Form1.LbInteres.Text = "Q" + Str(System.Math.Round(IntPremi, 2))
        Else
            IntPremi = 0
            Form1.LbMonPre.Visible = False
        End If


        If Form1.RBAhorro.Checked = True Then
            Form1.LbAhorro.Visible = True
            Select Case TotalDepo
                Case Is < 1001
                    IntAhorro = TotalDepo * 0.015
                Case Is < 5001
                    IntAhorro = TotalDepo * 0.025
                Case Is < 15001
                    IntAhorro = TotalDepo * 0.075
                Case Else
                    IntAhorro = TotalDepo * 0.1
            End Select
            Form1.LbInteres.Text = "Q" + Str(System.Math.Round(IntAhorro, 2))
        Else
            Form1.LbAhorro.Visible = False
            IntAhorro = 0
        End If

        Saldo = TotalDepo + IntAhorro + IntPremi + Saldo
        Form1.LbSalAct.Text = "Q" + Str(System.Math.Round(Saldo, 2))
    End Sub

    Sub Salir()
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Form1.Close()
        End If
    End Sub

End Module

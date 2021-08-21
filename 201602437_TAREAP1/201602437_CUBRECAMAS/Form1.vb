Public Class Form1
    Private Sub CBLino_CheckedChanged(sender As Object, e As EventArgs) Handles CBLino.CheckedChanged
        If CBLino.Checked = True Then
            TBLino.Visible = True
            TBLino.Text = " "
        Else
            TBLino.Visible = False
            TBLino.Text = "0 "
        End If
    End Sub

    Private Sub CBAlgodon_CheckedChanged(sender As Object, e As EventArgs) Handles CBAlgodon.CheckedChanged
        If CBAlgodon.Checked = True Then
            TBalgo.Visible = True
            TBalgo.Text = " "
        Else
            TBalgo.Visible = False
            TBalgo.Text = "0 "
        End If
    End Sub

    Private Sub CBSeda_CheckedChanged(sender As Object, e As EventArgs) Handles CBSeda.CheckedChanged
        If CBSeda.Checked = True Then
            TBseda.Visible = True
            TBseda.Text = " "
        Else
            TBseda.Visible = False
            TBseda.Text = " 0"
        End If
    End Sub

    Private Sub CBHilo_CheckedChanged(sender As Object, e As EventArgs) Handles CBHilo.CheckedChanged
        If CBHilo.Checked = True Then
            TBhilo.Visible = True
            TBhilo.Text = " "
        Else
            TBhilo.Visible = False
            TBhilo.Text = " 0"
        End If
    End Sub

    Private Sub RBImperial_CheckedChanged(sender As Object, e As EventArgs) Handles RBImperial.CheckedChanged
        If RBImperial.Checked = True Then
            Tamaño = 65.5
        End If
    End Sub

    Private Sub RBMatrimonial_CheckedChanged(sender As Object, e As EventArgs) Handles RBMatrimonial.CheckedChanged
        If RBMatrimonial.Checked = True Then
            Tamaño = 85.99
        End If
    End Sub

    Private Sub RBQueen_CheckedChanged(sender As Object, e As EventArgs) Handles RBQueen.CheckedChanged
        If RBQueen.Checked = True Then
            Tamaño = 99.99
        End If
    End Sub

    Private Sub RBKing_CheckedChanged(sender As Object, e As EventArgs) Handles RBKing.CheckedChanged
        If RBKing.Checked = True Then
            Tamaño = 105.99
        End If
    End Sub

    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        Calcular()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Salir()
    End Sub
End Class

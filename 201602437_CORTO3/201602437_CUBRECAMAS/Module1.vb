Module Module1
    Public Cubrecamas(15, 6)
    Public Fila As Byte = 0
    Public I As Byte

    Sub Limpiar_Matriz()
        Form1.DataGridView1.Rows.Clear()
        Fila = 0
        I = 0
        While (I <= 15)
            Cubrecamas(I, 0) = Nothing
            Cubrecamas(I, 1) = Nothing
            Cubrecamas(I, 2) = Nothing
            Cubrecamas(I, 3) = Nothing
            Cubrecamas(I, 4) = Nothing
            Cubrecamas(I, 5) = Nothing
            Cubrecamas(I, 6) = Nothing
            I = I + 1
        End While
    End Sub

End Module

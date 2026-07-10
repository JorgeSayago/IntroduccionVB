Public Class Pagina3
    Private Sub BtnEje1_Click(sender As Object, e As EventArgs) Handles BtnEje1.Click
        Dim numero As Integer
        Dim contador As Integer = 0

        numero = TxtNum.Text

        Do
            contador = contador + 1
            If numero Mod contador = 0 Then

                RichTextBox1.Text() = RichTextBox1.Text() & "El numero " & contador & " es divisor de " & numero & Environment.NewLine

            End If
        Loop Until (contador = numero)


    End Sub

    Private Sub BtnEje1Limpiar_Click(sender As Object, e As EventArgs) Handles BtnEje1Limpiar.Click
        TxtNum.Clear()
        RichTextBox1.Clear()

    End Sub
End Class
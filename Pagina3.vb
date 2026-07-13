Imports System.Diagnostics.Eventing.Reader

Public Class Pagina3
    Private Sub BtnEje1_Click(sender As Object, e As EventArgs) Handles BtnEje1.Click
        Dim numero As Integer
        Dim contador As Integer = 0

        numero = TxtNum.Text

        If TxtNum.Text <> 0 Then
            Do
                contador = contador + 1
                If numero Mod contador = 0 Then

                    RichTextBox1.Text() = RichTextBox1.Text() & "El numero " & contador & " es divisor de " & numero & Environment.NewLine

                End If
            Loop Until (contador = numero)

        Else
            MsgBox(" Por favor ingrese un numero diferente de 0")
            TxtNum.Focus()
            TxtNum.Clear()


        End If



    End Sub

    Private Sub BtnEje1Limpiar_Click(sender As Object, e As EventArgs) Handles BtnEje1Limpiar.Click
        TxtNum.Clear()
        RichTextBox1.Clear()

    End Sub

    Private Sub BtnEje2Iniciar_Click(sender As Object, e As EventArgs) Handles BtnEje2Iniciar.Click
        Dim contador, ciclo As Integer
        ciclo = 1

        If TbxNumEje2.Text <> "" Then
            For contador = 0 To Val(TbxNumEje2.Text)
                RTbxEjercicio2.Text = RTbxEjercicio2.Text & "contador = " & contador & " ciclo = " & ciclo & Environment.NewLine
                ciclo += 1
            Next

        Else
            MsgBox("Ingrese un numero en el campo de texto por favor")
        End If


    End Sub

    Private Sub BtnLimpiar2_Click(sender As Object, e As EventArgs) Handles BtnLimpiar2.Click
        TbxNumEje2.Clear
        RTbxEjercicio2.Clear

    End Sub

    Private Sub BtnIniIncremento_Click(sender As Object, e As EventArgs) Handles BtnIniIncremento.Click
        Dim contador, ciclo As Integer
        ciclo = 1
        If TxtNumInc.Text <> "" Then
            If TxtIncremento.Text <> "" Then
                RichTextBox2.Clear()

                For contador = 0 To Val(TxtNumInc.Text) Step Val(TxtIncremento.Text)
                    RichTextBox2.Text = RichTextBox2.Text & "contador: " & contador & " ciclo: " & ciclo & Environment.NewLine
                    ciclo += 1
                Next
            Else
                MsgBox("Ingrese un numero en el campo incremento")
                TxtIncremento.Focus()
            End If

        Else
            MsgBox(" Por Favor no deje el campo vacio")
        End If
    End Sub
End Class
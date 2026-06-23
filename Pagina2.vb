Public Class Pagina2

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem
            Case "Verde"
                PnlHeader.BackColor = Color.Green
            Case "Azul"
                PnlHeader.BackColor = Color.Blue
            Case "Amarillo"
                PnlHeader.BackColor = Color.Yellow
            Case "Rojo"
                PnlHeader.BackColor = Color.Red
            Case Else
                PnlHeader.BackColor = Color.Transparent

        End Select

    End Sub

    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim resultado As Decimal
    Dim operador As String
    Dim bandera As Integer = 0


    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If bandera = 1 Then
            TxtCalculo.Text = ""
            bandera = 0
        End If
        TxtCalculo.Text = TxtCalculo.Text & "1"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If bandera = 1 Then
            TxtCalculo.Text = ""
            bandera = 0
        End If
        TxtCalculo.Text = TxtCalculo.Text & "2"
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If bandera = 1 Then
            TxtCalculo.Text = ""
            bandera = 0
        End If
        TxtCalculo.Text = TxtCalculo.Text & "3"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If bandera = 1 Then
            TxtCalculo.Text = ""
            bandera = 0
        End If
        TxtCalculo.Text = TxtCalculo.Text & "4"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If bandera = 1 Then
            TxtCalculo.Text = ""
            bandera = 0
        End If
        TxtCalculo.Text = TxtCalculo.Text & "5"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        If bandera = 1 Then
            TxtCalculo.Text = ""
            bandera = 0
        End If
        TxtCalculo.Text = TxtCalculo.Text & "6"
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        If bandera = 1 Then
            TxtCalculo.Text = ""
            bandera = 0
        End If
        TxtCalculo.Text = TxtCalculo.Text & "7"
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If bandera = 1 Then
            TxtCalculo.Text = ""
            bandera = 0
        End If
        TxtCalculo.Text = TxtCalculo.Text & "8"
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If bandera = 1 Then
            TxtCalculo.Text = ""
            bandera = 0
        End If
        TxtCalculo.Text = TxtCalculo.Text & "9"
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        If bandera = 1 Then
            TxtCalculo.Text = ""
            bandera = 0
        End If
        TxtCalculo.Text = TxtCalculo.Text & "0"
    End Sub

    Private Sub BtnPunto_Click(sender As Object, e As EventArgs) Handles BtnPunto.Click
        If bandera = 1 Then
            TxtCalculo.Text = ""
            bandera = 0
        End If
        TxtCalculo.Text = TxtCalculo.Text & "."
    End Sub


    Private Sub BtnSum_Click(sender As Object, e As EventArgs) Handles BtnSum.Click
        num1 = TxtCalculo.Text
        TxtCalculo.Text = ""
        operador = "+"
    End Sub

    Private Sub BtnResta_Click(sender As Object, e As EventArgs) Handles BtnResta.Click
        num1 = TxtCalculo.Text
        TxtCalculo.Text = ""
        operador = "-"
    End Sub

    Private Sub BtnMulti_Click(sender As Object, e As EventArgs) Handles BtnMulti.Click
        num1 = TxtCalculo.Text
        TxtCalculo.Text = ""
        operador = "*"
    End Sub

    Private Sub BtnDiv_Click(sender As Object, e As EventArgs) Handles BtnDiv.Click
        num1 = TxtCalculo.Text
        TxtCalculo.Text = ""
        operador = "/"
    End Sub

    Private Sub BtnIgual_Click(sender As Object, e As EventArgs) Handles BtnIgual.Click
        num2 = TxtCalculo.Text
        Select Case operador
            Case "+"
                resultado = num1 + num2
            Case "-"
                resultado = num1 - num2
            Case "*"
                resultado = num1 * num2
            Case "/"
                resultado = num1 / num2
            Case Else
                MsgBox("Operador Incorrecto")
        End Select
        TxtCalculo.Text = resultado
        bandera = 1

    End Sub



    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        TxtCalculo.Text = ""
        num1 = 0
        num2 = 0
        resultado = 0
    End Sub
End Class
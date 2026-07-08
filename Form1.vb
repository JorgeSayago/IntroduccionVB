Public Class Form1

    ' Declara variables globales
    Dim resultado As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Text = "Hola mundo"


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Instruccion1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = TextBox1.Text
        TextBox1.Clear()


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Num2_TextChanged(sender As Object, e As EventArgs) Handles Num2.TextChanged

    End Sub

    Private Sub BtnSuma_Click(sender As Object, e As EventArgs) Handles BtnSuma.Click
        Dim numero1, numero2 As Decimal
        numero1 = Num1.Text
        numero2 = Num2.Text

        resultado = numero1 + numero2

        Lresulado.Text = resultado





    End Sub

    Private Sub Lresultado_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnResta_Click(sender As Object, e As EventArgs) Handles BtnResta.Click
        Dim numero1, numero2 As Decimal

        numero1 = Num1.Text
        numero2 = Num2.Text

        resultado = numero1 - numero2

        Lresulado.Text = resultado




    End Sub

    Private Sub BtnMultiplicacion_Click(sender As Object, e As EventArgs) Handles BtnMultiplicacion.Click
        Dim numero1, numero2 As Decimal
        numero1 = Num1.Text
        numero2 = Num2.Text

        resultado = numero1 * numero2

        Lresulado.Text = resultado





    End Sub

    Private Sub BtnDivision_Click(sender As Object, e As EventArgs) Handles BtnDivision.Click
        Dim numero1, numero2 As Decimal
        numero1 = Num1.Text
        numero2 = Num2.Text

        resultado = numero1 / numero2
        Lresulado.Text = Math.Round(resultado, 3)





    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs)
        Num1.Clear()
        Num2.Clear()


    End Sub

    Private Sub BtnLimpieza_Click(sender As Object, e As EventArgs) Handles BtnLimpieza.Click
        Num1.Clear()
        Num2.Clear()


    End Sub

    Private Sub BtnResiduo_Click(sender As Object, e As EventArgs) Handles BtnResiduo.Click
        Dim numero1, numero2 As Decimal

        numero1 = Num1.Text
        numero2 = Num2.Text

        resultado = numero1 Mod numero2

        Lresulado.Text = resultado





    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub BtnEvaluar_Click(sender As Object, e As EventArgs) Handles BtnEvaluar.Click
        If CalBox.Text > 5 Then
            Lcalificacion.Text = " APROBADO"
            Lcalificacion.ForeColor = Color.Green
        Else
            Lcalificacion.Text = " REPROBADO"
            Lcalificacion.ForeColor = Color.Red

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Menos de 40 horas de paga normal
        ' Excedetes de 40 horas y menos de 50 horas se pagan el doble
        ' Excedentes de 50 horas se pagan el triple
        Dim horasDobles As Decimal
        Dim total As Decimal
        Dim horasTriples As Decimal



        If TxtHora.Text <= 40 Then
            total = TxtCostoHora.Text * TxtHora.Text

            Lnormal.Text = Format(Math.Round(total, 2), "$ ###,##0.#0")
            Ldoble.Text = Format(Math.Round(0, 2), "$ ###,##0.#0")
            Ltriple.Text = Format(Math.Round(0, 2), "$ ###,##0.#0")
            LTotal.Text = Format(Math.Round(total, 2), "$ ###,##0.#0")

        ElseIf TxtHora.Text > 40 And TxtHora.Text < 50 Then
            total = 40 * TxtCostoHora.Text
            horasDobles = ((TxtHora.Text - 40) * TxtCostoHora.Text) * 2
            resultado = total + horasDobles

            Lnormal.Text = Format(Math.Round(total, 2), "$ ###,##0.#0")
            Ldoble.Text = Format(Math.Round(horasDobles, 2), "$ ###,##0.#0")
            Ltriple.Text = Format(Math.Round(0, 2), "$ ###,##0.#0")
            LTotal.Text = Format(Math.Round(resultado, 2), "$ ###,##0.#0")
        ElseIf TxtHora.Text >= 50 Then
            total = 40 * TxtCostoHora.Text
            horasDobles = (10 * TxtCostoHora.Text) * 2
            horasTriples = ((TxtHora.Text - 50) * TxtCostoHora.Text) * 3
            resultado = total + horasDobles + horasTriples

            Lnormal.Text = Format(Math.Round(total, 2), "$ ###,##0.#0")
            Ldoble.Text = Format(Math.Round(horasDobles, 2), "$ ###,##0.#0")
            Ltriple.Text = Format(Math.Round(horasTriples, 2), "$ ###,##0.#0")
            LTotal.Text = Format(Math.Round(resultado, 2), "$ ###,##0.#0")

        End If



    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub RbtnCalcular_Click(sender As Object, e As EventArgs) Handles RbtnCalcular.Click
        Dim RadioTotal As Decimal
        Dim num1 As Decimal
        Dim num2 As Decimal

        If RbtnSuma.Checked Then
            num1 = TbNum1.Text
            num2 = TbnNum2.Text

            RadioTotal = num1 + num2
            RbResultado.Text = Format(Math.Round(RadioTotal, 2), "###,##0.#0")
        ElseIf RbtnResta.Checked Then
            num1 = TbNum1.Text
            num2 = TbnNum2.Text
            RadioTotal = num1 - num2
            RbResultado.Text = Format(Math.Round(RadioTotal, 2), "###,##0.#0")
        ElseIf RbtnMulti.Checked Then
            num1 = TbNum1.Text
            num2 = TbnNum2.Text
            RadioTotal = num1 * num2
            RbResultado.Text = Format(Math.Round(RadioTotal, 2), "###,##0.#0")
        ElseIf RbtnDivision.Checked Then
            num1 = TbNum1.Text
            num2 = TbnNum2.Text
            RadioTotal = num1 / num2
            RbResultado.Text = Format(Math.Round(RadioTotal, 2), "###,##0.#0")
        ElseIf RbtnResiduo.Checked Then
            num1 = TbNum1.Text
            num2 = TbnNum2.Text
            RadioTotal = num1 Mod num2
            RbResultado.Text = Format(Math.Round(RadioTotal, 2), "###,##0.#0")
        End If
    End Sub

    Private Sub BtnPag2_Click(sender As Object, e As EventArgs) Handles BtnPag2.Click
        Dim f As New Pagina2()
        f.ShowDialog()

    End Sub

    Private Sub RbtLimpiar_Click(sender As Object, e As EventArgs) Handles RbtLimpiar.Click
        TbNum1.Clear()
        TbnNum2.Clear()
        RbResultado.Text() = " "
    End Sub

    Private Sub BtnPag3_Click(sender As Object, e As EventArgs) Handles BtnPag3.Click
        Dim f As New Pagina3()
        f.ShowDialog()
    End Sub
End Class

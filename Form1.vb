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

        numero1 = Num1.Text()
        numero2 = Num2.Text()

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
        Lresulado.Text = resultado





    End Sub
End Class

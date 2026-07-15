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

    Private Sub BtnAniadir_Click(sender As Object, e As EventArgs) Handles BtnAniadir.Click
        Dim nombre As String

        nombre = TxtAniadir.Text
        ListBox1.Items.Add(nombre)
        TxtAniadir.Clear()

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim nombre As String
        If ListBox1.SelectedItems.Count = 1 Then
            nombre = ListBox1.SelectedItem
            ListBox2.Items.Add(nombre)
            ListBox1.Items.Remove(nombre)
        Else
            MsgBox("Por favor seleccione un valor valido")
        End If


    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Dim nombre As String

        If ListBox2.SelectedItems.Count = 1 Then
            nombre = ListBox2.SelectedItem
            ListBox1.Items.Add(nombre)
            ListBox2.Items.Remove(nombre)

        Else
            MsgBox("Por favor seleccione un valor valido")
        End If

    End Sub

    Private Sub BtnAgregarTodo_Click(sender As Object, e As EventArgs) Handles BtnAgregarTodo.Click
        Dim nombre As String
        Dim contador As Integer
        Dim valor = ListBox1.Items.Count

        For contador = 0 To valor - 1

            nombre = ListBox1.Items(0)
            ListBox2.Items.Add(nombre)
            ListBox1.Items.Remove(nombre)

        Next
    End Sub

    Private Sub BtnRegresarTodo_Click(sender As Object, e As EventArgs) Handles BtnRegresarTodo.Click
        Dim nombre As String
        Dim contador As Integer

        Dim valor = ListBox2.Items.Count

        For contador = 0 To valor - 1
            nombre = ListBox2.Items(0)
            ListBox1.Items.Add(nombre)
            ListBox2.Items.Remove(nombre)
        Next

    End Sub

    Private Sub actualizas()
        Label6.Text = "Indice: " & ListBox1.SelectedIndex
        Label7.Text = "Nombre: " & ListBox1.SelectedItem
        Label8.Text = "Elementos: " & ListBox1.Items.Count

        Label9.Text = "Indice: " & ListBox2.SelectedIndex
        Label10.Text = "Nombre: " & ListBox2.SelectedItem
        Label11.Text = "Elementos: " & ListBox2.Items.Count

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        actualizas()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        actualizas()
    End Sub

    Private Sub BtnDelete1_Click(sender As Object, e As EventArgs) Handles BtnDelete1.Click
        Dim nombre As String

        nombre = ListBox1.SelectedItem
        ListBox1.Items.Remove(nombre)
    End Sub

    Private Sub BtnDelete2_Click(sender As Object, e As EventArgs) Handles BtnDelete2.Click
        Dim nombre As String
        nombre = ListBox2.SelectedItem
        ListBox2.Items.Remove(nombre)
    End Sub

    Private Sub BtnDeleteAll1_Click(sender As Object, e As EventArgs) Handles BtnDeleteAll1.Click
        Dim nombre As String
        Dim contador As Integer
        Dim valor = ListBox1.Items.Count

        For contador = 0 To valor - 1
            nombre = ListBox1.Items(0)
            ListBox1.Items.Remove(nombre)
        Next



    End Sub

    Private Sub BtnDeleteAll2_Click(sender As Object, e As EventArgs) Handles BtnDeleteAll2.Click
        Dim nombre As String
        Dim contador As Integer
        Dim valor = ListBox2.Items.Count

        For contador = 0 To valor - 1
            nombre = ListBox2.Items(0)
            ListBox2.Items.Remove(nombre)
        Next
    End Sub
End Class
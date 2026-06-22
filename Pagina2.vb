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
End Class
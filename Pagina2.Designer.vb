<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagina2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LblColor = New Label()
        ComboBox1 = New ComboBox()
        PnlHeader = New Panel()
        Panel1 = New Panel()
        Label1 = New Label()
        BtnClean = New Button()
        BtnDiv = New Button()
        Btn0 = New Button()
        BtnMulti = New Button()
        BtnResta = New Button()
        BtnSum = New Button()
        BtnIgual = New Button()
        BtnPunto = New Button()
        Btn9 = New Button()
        Btn8 = New Button()
        Btn7 = New Button()
        Btn6 = New Button()
        Btn5 = New Button()
        Btn4 = New Button()
        Btn3 = New Button()
        Btn2 = New Button()
        Btn1 = New Button()
        TxtCalculo = New TextBox()
        Panel2 = New Panel()
        BtnIniciar = New Button()
        RichTextBox1 = New RichTextBox()
        TbxNumero = New TextBox()
        Label2 = New Label()
        Panel3 = New Panel()
        Label5 = New Label()
        BtnReiniciar = New Button()
        Label4 = New Label()
        BtnCalcular = New Button()
        TbxCalcular = New TextBox()
        Label3 = New Label()
        Panel4 = New Panel()
        Label8 = New Label()
        BtnInicio = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        PnlHeader.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblColor
        ' 
        LblColor.AutoSize = True
        LblColor.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblColor.Location = New Point(356, 37)
        LblColor.Name = "LblColor"
        LblColor.Size = New Size(163, 20)
        LblColor.TabIndex = 0
        LblColor.Text = "Seleccione un Color:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Verde", "Azul", "Rojo", "Amarillo", "Sin color"})
        ComboBox1.Location = New Point(535, 34)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 1
        ' 
        ' PnlHeader
        ' 
        PnlHeader.Controls.Add(LblColor)
        PnlHeader.Controls.Add(ComboBox1)
        PnlHeader.Dock = DockStyle.Top
        PnlHeader.Location = New Point(0, 0)
        PnlHeader.Name = "PnlHeader"
        PnlHeader.Size = New Size(987, 98)
        PnlHeader.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientInactiveCaption
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(BtnClean)
        Panel1.Controls.Add(BtnDiv)
        Panel1.Controls.Add(Btn0)
        Panel1.Controls.Add(BtnMulti)
        Panel1.Controls.Add(BtnResta)
        Panel1.Controls.Add(BtnSum)
        Panel1.Controls.Add(BtnIgual)
        Panel1.Controls.Add(BtnPunto)
        Panel1.Controls.Add(Btn9)
        Panel1.Controls.Add(Btn8)
        Panel1.Controls.Add(Btn7)
        Panel1.Controls.Add(Btn6)
        Panel1.Controls.Add(Btn5)
        Panel1.Controls.Add(Btn4)
        Panel1.Controls.Add(Btn3)
        Panel1.Controls.Add(Btn2)
        Panel1.Controls.Add(Btn1)
        Panel1.Controls.Add(TxtCalculo)
        Panel1.Location = New Point(4, 98)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(390, 414)
        Panel1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(132, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 20)
        Label1.TabIndex = 18
        Label1.Text = "Calculadora"
        ' 
        ' BtnClean
        ' 
        BtnClean.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnClean.Location = New Point(269, 97)
        BtnClean.Name = "BtnClean"
        BtnClean.Size = New Size(51, 42)
        BtnClean.TabIndex = 17
        BtnClean.Text = "C"
        BtnClean.UseVisualStyleBackColor = True
        ' 
        ' BtnDiv
        ' 
        BtnDiv.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnDiv.Location = New Point(269, 348)
        BtnDiv.Name = "BtnDiv"
        BtnDiv.Size = New Size(51, 42)
        BtnDiv.TabIndex = 16
        BtnDiv.Text = "/"
        BtnDiv.UseVisualStyleBackColor = True
        ' 
        ' Btn0
        ' 
        Btn0.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn0.Location = New Point(52, 348)
        Btn0.Name = "Btn0"
        Btn0.Size = New Size(51, 42)
        Btn0.TabIndex = 10
        Btn0.Text = "0"
        Btn0.UseVisualStyleBackColor = True
        ' 
        ' BtnMulti
        ' 
        BtnMulti.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnMulti.Location = New Point(269, 285)
        BtnMulti.Name = "BtnMulti"
        BtnMulti.Size = New Size(51, 42)
        BtnMulti.TabIndex = 15
        BtnMulti.Text = "*"
        BtnMulti.UseVisualStyleBackColor = True
        ' 
        ' BtnResta
        ' 
        BtnResta.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnResta.Location = New Point(269, 222)
        BtnResta.Name = "BtnResta"
        BtnResta.Size = New Size(51, 42)
        BtnResta.TabIndex = 14
        BtnResta.Text = "-"
        BtnResta.UseVisualStyleBackColor = True
        ' 
        ' BtnSum
        ' 
        BtnSum.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnSum.Location = New Point(269, 156)
        BtnSum.Name = "BtnSum"
        BtnSum.Size = New Size(51, 42)
        BtnSum.TabIndex = 13
        BtnSum.Text = "+"
        BtnSum.UseVisualStyleBackColor = True
        ' 
        ' BtnIgual
        ' 
        BtnIgual.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnIgual.Location = New Point(186, 348)
        BtnIgual.Name = "BtnIgual"
        BtnIgual.Size = New Size(51, 42)
        BtnIgual.TabIndex = 12
        BtnIgual.Text = "="
        BtnIgual.UseVisualStyleBackColor = True
        ' 
        ' BtnPunto
        ' 
        BtnPunto.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnPunto.Location = New Point(118, 348)
        BtnPunto.Name = "BtnPunto"
        BtnPunto.Size = New Size(51, 42)
        BtnPunto.TabIndex = 11
        BtnPunto.Text = "."
        BtnPunto.UseVisualStyleBackColor = True
        ' 
        ' Btn9
        ' 
        Btn9.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn9.Location = New Point(186, 285)
        Btn9.Name = "Btn9"
        Btn9.Size = New Size(51, 42)
        Btn9.TabIndex = 9
        Btn9.Text = "9"
        Btn9.UseVisualStyleBackColor = True
        ' 
        ' Btn8
        ' 
        Btn8.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn8.Location = New Point(118, 285)
        Btn8.Name = "Btn8"
        Btn8.Size = New Size(51, 42)
        Btn8.TabIndex = 8
        Btn8.Text = "8"
        Btn8.UseVisualStyleBackColor = True
        ' 
        ' Btn7
        ' 
        Btn7.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn7.Location = New Point(52, 285)
        Btn7.Name = "Btn7"
        Btn7.Size = New Size(51, 42)
        Btn7.TabIndex = 7
        Btn7.Text = "7"
        Btn7.UseVisualStyleBackColor = True
        ' 
        ' Btn6
        ' 
        Btn6.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn6.Location = New Point(186, 222)
        Btn6.Name = "Btn6"
        Btn6.Size = New Size(51, 42)
        Btn6.TabIndex = 6
        Btn6.Text = "6"
        Btn6.UseVisualStyleBackColor = True
        ' 
        ' Btn5
        ' 
        Btn5.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn5.Location = New Point(118, 222)
        Btn5.Name = "Btn5"
        Btn5.Size = New Size(51, 42)
        Btn5.TabIndex = 5
        Btn5.Text = "5"
        Btn5.UseVisualStyleBackColor = True
        ' 
        ' Btn4
        ' 
        Btn4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn4.Location = New Point(52, 222)
        Btn4.Name = "Btn4"
        Btn4.Size = New Size(51, 42)
        Btn4.TabIndex = 4
        Btn4.Text = "4"
        Btn4.UseVisualStyleBackColor = True
        ' 
        ' Btn3
        ' 
        Btn3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn3.Location = New Point(186, 156)
        Btn3.Name = "Btn3"
        Btn3.Size = New Size(51, 42)
        Btn3.TabIndex = 3
        Btn3.Text = "3"
        Btn3.UseVisualStyleBackColor = True
        ' 
        ' Btn2
        ' 
        Btn2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn2.Location = New Point(118, 156)
        Btn2.Name = "Btn2"
        Btn2.Size = New Size(51, 42)
        Btn2.TabIndex = 2
        Btn2.Text = "2"
        Btn2.UseVisualStyleBackColor = True
        ' 
        ' Btn1
        ' 
        Btn1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn1.Location = New Point(52, 156)
        Btn1.Name = "Btn1"
        Btn1.Size = New Size(51, 42)
        Btn1.TabIndex = 1
        Btn1.Text = "1"
        Btn1.UseVisualStyleBackColor = True
        ' 
        ' TxtCalculo
        ' 
        TxtCalculo.Location = New Point(52, 53)
        TxtCalculo.Name = "TxtCalculo"
        TxtCalculo.Size = New Size(268, 27)
        TxtCalculo.TabIndex = 0
        TxtCalculo.TextAlign = HorizontalAlignment.Right
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.Controls.Add(BtnIniciar)
        Panel2.Controls.Add(RichTextBox1)
        Panel2.Controls.Add(TbxNumero)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(394, 98)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(653, 414)
        Panel2.TabIndex = 4
        ' 
        ' BtnIniciar
        ' 
        BtnIniciar.Location = New Point(436, 23)
        BtnIniciar.Name = "BtnIniciar"
        BtnIniciar.Size = New Size(94, 29)
        BtnIniciar.TabIndex = 3
        BtnIniciar.Text = "Iniciar"
        BtnIniciar.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(201, 106)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(253, 238)
        RichTextBox1.TabIndex = 2
        RichTextBox1.Text = ""
        ' 
        ' TbxNumero
        ' 
        TbxNumero.Location = New Point(265, 23)
        TbxNumero.Name = "TbxNumero"
        TbxNumero.Size = New Size(136, 27)
        TbxNumero.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(102, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 20)
        Label2.TabIndex = 0
        Label2.Text = "Escoge un numero: "
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Info
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(BtnReiniciar)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(BtnCalcular)
        Panel3.Controls.Add(TbxCalcular)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(0, 512)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(418, 203)
        Panel3.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(64, 86)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 20)
        Label5.TabIndex = 5
        Label5.Text = "La media es: "
        Label5.Visible = False
        ' 
        ' BtnReiniciar
        ' 
        BtnReiniciar.Location = New Point(99, 118)
        BtnReiniciar.Name = "BtnReiniciar"
        BtnReiniciar.Size = New Size(94, 29)
        BtnReiniciar.TabIndex = 4
        BtnReiniciar.Text = "Reiniciar"
        BtnReiniciar.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(165, 86)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 3
        Label4.Text = "Label4"
        Label4.Visible = False
        ' 
        ' BtnCalcular
        ' 
        BtnCalcular.Location = New Point(318, 38)
        BtnCalcular.Name = "BtnCalcular"
        BtnCalcular.Size = New Size(94, 29)
        BtnCalcular.TabIndex = 2
        BtnCalcular.Text = "Calcular"
        BtnCalcular.UseVisualStyleBackColor = True
        ' 
        ' TbxCalcular
        ' 
        TbxCalcular.Location = New Point(182, 36)
        TbxCalcular.Name = "TbxCalcular"
        TbxCalcular.Size = New Size(125, 27)
        TbxCalcular.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 22)
        Label3.TabIndex = 0
        Label3.Text = "Numero de Datos: "
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaption
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(BtnInicio)
        Panel4.Controls.Add(TextBox2)
        Panel4.Controls.Add(TextBox1)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(418, 512)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(629, 203)
        Panel4.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(28, 13)
        Label8.Name = "Label8"
        Label8.Size = New Size(403, 80)
        Label8.TabIndex = 5
        Label8.Text = "Inserta 2 numeros con las siguientes caracteristicas:" & vbCrLf & vbCrLf & "- Los 2 numeros deben ser diferentes" & vbCrLf & "- El primer numero tiene que ser menor que el numero 2"
        ' 
        ' BtnInicio
        ' 
        BtnInicio.BackColor = SystemColors.ButtonHighlight
        BtnInicio.FlatStyle = FlatStyle.Flat
        BtnInicio.Location = New Point(400, 132)
        BtnInicio.Name = "BtnInicio"
        BtnInicio.Size = New Size(94, 29)
        BtnInicio.TabIndex = 4
        BtnInicio.Text = "Iniciar"
        BtnInicio.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(181, 161)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(181, 118)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(72, 161)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 20)
        Label7.TabIndex = 1
        Label7.Text = "Numero 2: "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(72, 118)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 20)
        Label6.TabIndex = 0
        Label6.Text = "Numero 1: "
        ' 
        ' Pagina2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(987, 991)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PnlHeader)
        Name = "Pagina2"
        Text = "Ejercicios 2"
        PnlHeader.ResumeLayout(False)
        PnlHeader.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LblColor As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PnlHeader As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtCalculo As TextBox
    Friend WithEvents Btn0 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents BtnDiv As Button
    Friend WithEvents BtnMulti As Button
    Friend WithEvents BtnResta As Button
    Friend WithEvents BtnSum As Button
    Friend WithEvents BtnIgual As Button
    Friend WithEvents BtnPunto As Button
    Friend WithEvents BtnClean As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnIniciar As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TbxNumero As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents TbxCalcular As TextBox
    Friend WithEvents BtnReiniciar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnInicio As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class

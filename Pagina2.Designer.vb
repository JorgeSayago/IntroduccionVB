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
        PnlHeader.SuspendLayout()
        Panel1.SuspendLayout()
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
        PnlHeader.Size = New Size(1140, 98)
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
        Panel1.Size = New Size(390, 435)
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
        ' Pagina2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1140, 740)
        Controls.Add(Panel1)
        Controls.Add(PnlHeader)
        Name = "Pagina2"
        Text = "Ejercicios 2"
        PnlHeader.ResumeLayout(False)
        PnlHeader.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label1 = New Label()
        Instruccion1 = New Label()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Label2 = New Label()
        Panel1 = New Panel()
        Lresulado = New Label()
        BtnSuma = New Button()
        BtnResta = New Button()
        BtnMultiplicacion = New Button()
        BtnDivision = New Button()
        Num2 = New TextBox()
        Num1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(9, 11)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 27)
        Button1.TabIndex = 0
        Button1.Text = "Mensaje"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(157, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 1
        ' 
        ' Instruccion1
        ' 
        Instruccion1.AutoSize = True
        Instruccion1.Font = New Font("Sitka Text", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Instruccion1.ForeColor = Color.Black
        Instruccion1.Location = New Point(12, 63)
        Instruccion1.Name = "Instruccion1"
        Instruccion1.Size = New Size(166, 21)
        Instruccion1.TabIndex = 2
        Instruccion1.Text = "Ingrese un mensaje: "
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(184, 61)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(230, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.ForeColor = Color.IndianRed
        Button2.Location = New Point(184, 112)
        Button2.Name = "Button2"
        Button2.Size = New Size(181, 29)
        Button2.TabIndex = 4
        Button2.Text = "Mostrar Mensaje" & vbCrLf
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Text", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(43, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 21)
        Label2.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(Lresulado)
        Panel1.Controls.Add(BtnSuma)
        Panel1.Controls.Add(BtnResta)
        Panel1.Controls.Add(BtnMultiplicacion)
        Panel1.Controls.Add(BtnDivision)
        Panel1.Controls.Add(Num2)
        Panel1.Controls.Add(Num1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(474, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(479, 228)
        Panel1.TabIndex = 6
        ' 
        ' Lresulado
        ' 
        Lresulado.AutoSize = True
        Lresulado.Font = New Font("Sitka Text", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lresulado.ForeColor = Color.Black
        Lresulado.Location = New Point(77, 141)
        Lresulado.Name = "Lresulado"
        Lresulado.Size = New Size(0, 21)
        Lresulado.TabIndex = 7
        ' 
        ' BtnSuma
        ' 
        BtnSuma.ForeColor = Color.IndianRed
        BtnSuma.Location = New Point(336, 24)
        BtnSuma.Name = "BtnSuma"
        BtnSuma.Size = New Size(127, 29)
        BtnSuma.TabIndex = 13
        BtnSuma.Text = "Suma"
        BtnSuma.UseVisualStyleBackColor = True
        ' 
        ' BtnResta
        ' 
        BtnResta.ForeColor = Color.IndianRed
        BtnResta.Location = New Point(336, 75)
        BtnResta.Name = "BtnResta"
        BtnResta.Size = New Size(127, 29)
        BtnResta.TabIndex = 12
        BtnResta.Text = "Resta" & vbCrLf & vbCrLf
        BtnResta.UseVisualStyleBackColor = True
        ' 
        ' BtnMultiplicacion
        ' 
        BtnMultiplicacion.ForeColor = Color.IndianRed
        BtnMultiplicacion.Location = New Point(336, 119)
        BtnMultiplicacion.Name = "BtnMultiplicacion"
        BtnMultiplicacion.Size = New Size(127, 29)
        BtnMultiplicacion.TabIndex = 11
        BtnMultiplicacion.Text = "Multiplicacion" & vbCrLf & vbCrLf
        BtnMultiplicacion.UseVisualStyleBackColor = True
        ' 
        ' BtnDivision
        ' 
        BtnDivision.ForeColor = Color.IndianRed
        BtnDivision.Location = New Point(336, 168)
        BtnDivision.Name = "BtnDivision"
        BtnDivision.Size = New Size(127, 29)
        BtnDivision.TabIndex = 7
        BtnDivision.Text = "Division" & vbCrLf
        BtnDivision.UseVisualStyleBackColor = True
        ' 
        ' Num2
        ' 
        Num2.Location = New Point(147, 83)
        Num2.Name = "Num2"
        Num2.Size = New Size(134, 27)
        Num2.TabIndex = 10
        ' 
        ' Num1
        ' 
        Num1.Location = New Point(147, 39)
        Num1.Name = "Num1"
        Num1.Size = New Size(134, 27)
        Num1.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(22, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 21)
        Label5.TabIndex = 9
        Label5.Text = "Numero 1: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(22, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 21)
        Label4.TabIndex = 8
        Label4.Text = "Numero 2: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Text", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(12, 4)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 21)
        Label3.TabIndex = 7
        Label3.Text = "Operaciones Basicas"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(949, 364)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Instruccion1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        ForeColor = Color.Coral
        Name = "Form1"
        Text = "Solucion 1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Instruccion1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Num2 As TextBox
    Friend WithEvents Num1 As TextBox
    Friend WithEvents BtnSuma As Button
    Friend WithEvents BtnResta As Button
    Friend WithEvents BtnMultiplicacion As Button
    Friend WithEvents BtnDivision As Button
    Friend WithEvents Lresulado As Label

End Class

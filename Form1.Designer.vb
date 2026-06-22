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
        BtnResiduo = New Button()
        BtnLimpieza = New Button()
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
        Panel2 = New Panel()
        GroupBox1 = New GroupBox()
        LTotal = New Label()
        Ltriple = New Label()
        Ldoble = New Label()
        Lnormal = New Label()
        Button3 = New Button()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        TxtCostoHora = New TextBox()
        Label9 = New Label()
        TxtHora = New TextBox()
        Label8 = New Label()
        Lcalificacion = New Label()
        BtnEvaluar = New Button()
        CalBox = New ComboBox()
        Label7 = New Label()
        Label6 = New Label()
        FooterPanel = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox1.SuspendLayout()
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
        Instruccion1.Font = New Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Label2.Font = New Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(43, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 21)
        Label2.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(BtnResiduo)
        Panel1.Controls.Add(BtnLimpieza)
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
        Panel1.Location = New Point(497, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(538, 273)
        Panel1.TabIndex = 6
        ' 
        ' BtnResiduo
        ' 
        BtnResiduo.ForeColor = Color.IndianRed
        BtnResiduo.Location = New Point(336, 214)
        BtnResiduo.Name = "BtnResiduo"
        BtnResiduo.Size = New Size(127, 29)
        BtnResiduo.TabIndex = 15
        BtnResiduo.Text = "Residuo"
        BtnResiduo.UseVisualStyleBackColor = True
        ' 
        ' BtnLimpieza
        ' 
        BtnLimpieza.ForeColor = Color.IndianRed
        BtnLimpieza.Location = New Point(22, 197)
        BtnLimpieza.Name = "BtnLimpieza"
        BtnLimpieza.Size = New Size(127, 29)
        BtnLimpieza.TabIndex = 14
        BtnLimpieza.Text = "Limpieza" & vbCrLf
        BtnLimpieza.UseVisualStyleBackColor = True
        ' 
        ' Lresulado
        ' 
        Lresulado.AutoSize = True
        Lresulado.Font = New Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Label3.Font = New Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(12, 4)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 21)
        Label3.TabIndex = 7
        Label3.Text = "Operaciones Basicas"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.Controls.Add(GroupBox1)
        Panel2.Controls.Add(Lcalificacion)
        Panel2.Controls.Add(BtnEvaluar)
        Panel2.Controls.Add(CalBox)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(0, 271)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(498, 467)
        Panel2.TabIndex = 16
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.GradientInactiveCaption
        GroupBox1.Controls.Add(LTotal)
        GroupBox1.Controls.Add(Ltriple)
        GroupBox1.Controls.Add(Ldoble)
        GroupBox1.Controls.Add(Lnormal)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(TxtCostoHora)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(TxtHora)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Location = New Point(0, 142)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(498, 322)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Salario"
        ' 
        ' LTotal
        ' 
        LTotal.AutoSize = True
        LTotal.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        LTotal.ForeColor = Color.DarkSlateBlue
        LTotal.Location = New Point(136, 279)
        LTotal.Name = "LTotal"
        LTotal.Size = New Size(0, 17)
        LTotal.TabIndex = 26
        ' 
        ' Ltriple
        ' 
        Ltriple.AutoSize = True
        Ltriple.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        Ltriple.ForeColor = Color.DarkSlateBlue
        Ltriple.Location = New Point(136, 243)
        Ltriple.Name = "Ltriple"
        Ltriple.Size = New Size(0, 17)
        Ltriple.TabIndex = 25
        ' 
        ' Ldoble
        ' 
        Ldoble.AutoSize = True
        Ldoble.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        Ldoble.ForeColor = Color.DarkSlateBlue
        Ldoble.Location = New Point(136, 205)
        Ldoble.Name = "Ldoble"
        Ldoble.Size = New Size(0, 17)
        Ldoble.TabIndex = 24
        ' 
        ' Lnormal
        ' 
        Lnormal.AutoSize = True
        Lnormal.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        Lnormal.ForeColor = Color.DarkSlateBlue
        Lnormal.Location = New Point(136, 166)
        Lnormal.Name = "Lnormal"
        Lnormal.Size = New Size(0, 17)
        Lnormal.TabIndex = 23
        ' 
        ' Button3
        ' 
        Button3.ForeColor = Color.DarkBlue
        Button3.Location = New Point(325, 139)
        Button3.Name = "Button3"
        Button3.Size = New Size(108, 29)
        Button3.TabIndex = 22
        Button3.Text = "Cotizar" & vbCrLf
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        Label13.ForeColor = Color.DarkSlateBlue
        Label13.Location = New Point(45, 279)
        Label13.Name = "Label13"
        Label13.Size = New Size(41, 17)
        Label13.TabIndex = 7
        Label13.Text = "Total" & vbCrLf
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        Label12.ForeColor = Color.DarkSlateBlue
        Label12.Location = New Point(43, 243)
        Label12.Name = "Label12"
        Label12.Size = New Size(54, 17)
        Label12.TabIndex = 6
        Label12.Text = "Triples"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        Label11.ForeColor = Color.DarkSlateBlue
        Label11.Location = New Point(43, 205)
        Label11.Name = "Label11"
        Label11.Size = New Size(54, 17)
        Label11.TabIndex = 5
        Label11.Text = "Dobles"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        Label10.ForeColor = Color.DarkSlateBlue
        Label10.Location = New Point(43, 166)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 17)
        Label10.TabIndex = 4
        Label10.Text = "Normal"
        ' 
        ' TxtCostoHora
        ' 
        TxtCostoHora.Location = New Point(182, 80)
        TxtCostoHora.Name = "TxtCostoHora"
        TxtCostoHora.Size = New Size(125, 27)
        TxtCostoHora.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.Maroon
        Label9.Location = New Point(28, 83)
        Label9.Name = "Label9"
        Label9.Size = New Size(114, 20)
        Label9.TabIndex = 2
        Label9.Text = "Costo por Hora:" & vbCrLf
        ' 
        ' TxtHora
        ' 
        TxtHora.Location = New Point(182, 38)
        TxtHora.Name = "TxtHora"
        TxtHora.Size = New Size(125, 27)
        TxtHora.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.Maroon
        Label8.Location = New Point(28, 39)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 20)
        Label8.TabIndex = 0
        Label8.Text = "Horas Trabajadas: "
        ' 
        ' Lcalificacion
        ' 
        Lcalificacion.AutoSize = True
        Lcalificacion.Location = New Point(126, 90)
        Lcalificacion.Name = "Lcalificacion"
        Lcalificacion.Size = New Size(0, 20)
        Lcalificacion.TabIndex = 20
        ' 
        ' BtnEvaluar
        ' 
        BtnEvaluar.ForeColor = Color.DarkBlue
        BtnEvaluar.Location = New Point(306, 41)
        BtnEvaluar.Name = "BtnEvaluar"
        BtnEvaluar.Size = New Size(108, 29)
        BtnEvaluar.TabIndex = 19
        BtnEvaluar.Text = "Evaluar"
        BtnEvaluar.UseVisualStyleBackColor = True
        ' 
        ' CalBox
        ' 
        CalBox.FormattingEnabled = True
        CalBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        CalBox.Location = New Point(126, 44)
        CalBox.Name = "CalBox"
        CalBox.Size = New Size(115, 28)
        CalBox.TabIndex = 18
        CalBox.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Sienna
        Label7.Location = New Point(12, 44)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 42)
        Label7.TabIndex = 17
        Label7.Text = "Calificacion: " & vbCrLf & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(174, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 21)
        Label6.TabIndex = 16
        Label6.Text = "Calificacion" & vbCrLf
        ' 
        ' FooterPanel
        ' 
        FooterPanel.BackColor = SystemColors.Info
        FooterPanel.Dock = DockStyle.Bottom
        FooterPanel.Location = New Point(0, 741)
        FooterPanel.Name = "FooterPanel"
        FooterPanel.Size = New Size(1036, 120)
        FooterPanel.TabIndex = 17
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(1036, 861)
        Controls.Add(FooterPanel)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Instruccion1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        ForeColor = Color.Coral
        Name = "Form1"
        Text = "Ejercicios 1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
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
    Friend WithEvents BtnLimpieza As Button
    Friend WithEvents BtnResiduo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CalBox As ComboBox
    Friend WithEvents BtnEvaluar As Button
    Friend WithEvents Lcalificacion As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCostoHora As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtHora As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents LTotal As Label
    Friend WithEvents Ltriple As Label
    Friend WithEvents Ldoble As Label
    Friend WithEvents Lnormal As Label
    Friend WithEvents FooterPanel As Panel

End Class

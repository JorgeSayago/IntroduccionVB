<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagina3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagina3))
        Panel1 = New Panel()
        BtnEje1Limpiar = New Button()
        RichTextBox1 = New RichTextBox()
        BtnEje1 = New Button()
        TxtNum = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        BtnLimpiar2 = New Button()
        RTbxEjercicio2 = New RichTextBox()
        BtnEje2Iniciar = New Button()
        TbxNumEje2 = New TextBox()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        TxtIncremento = New TextBox()
        Label4 = New Label()
        RichTextBox2 = New RichTextBox()
        BtnIniIncremento = New Button()
        TxtNumInc = New TextBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(BtnEje1Limpiar)
        Panel1.Controls.Add(RichTextBox1)
        Panel1.Controls.Add(BtnEje1)
        Panel1.Controls.Add(TxtNum)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(1, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(518, 349)
        Panel1.TabIndex = 0
        ' 
        ' BtnEje1Limpiar
        ' 
        BtnEje1Limpiar.Location = New Point(160, 296)
        BtnEje1Limpiar.Name = "BtnEje1Limpiar"
        BtnEje1Limpiar.Size = New Size(94, 29)
        BtnEje1Limpiar.TabIndex = 4
        BtnEje1Limpiar.Text = "Limpiar"
        BtnEje1Limpiar.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(113, 93)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(211, 176)
        RichTextBox1.TabIndex = 3
        RichTextBox1.Text = ""
        ' 
        ' BtnEje1
        ' 
        BtnEje1.Location = New Point(349, 27)
        BtnEje1.Name = "BtnEje1"
        BtnEje1.Size = New Size(94, 29)
        BtnEje1.TabIndex = 2
        BtnEje1.Text = "Iniciar"
        BtnEje1.UseVisualStyleBackColor = True
        ' 
        ' TxtNum
        ' 
        TxtNum.Location = New Point(199, 28)
        TxtNum.Name = "TxtNum"
        TxtNum.Size = New Size(125, 27)
        TxtNum.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 23)
        Label1.TabIndex = 0
        Label1.Text = "Escriba un numero: "
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = My.Resources.Resources.findi
        GroupBox1.Controls.Add(BtnLimpiar2)
        GroupBox1.Controls.Add(RTbxEjercicio2)
        GroupBox1.Controls.Add(BtnEje2Iniciar)
        GroupBox1.Controls.Add(TbxNumEje2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(525, -1)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(518, 349)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Contador"
        ' 
        ' BtnLimpiar2
        ' 
        BtnLimpiar2.Location = New Point(407, 296)
        BtnLimpiar2.Name = "BtnLimpiar2"
        BtnLimpiar2.Size = New Size(94, 29)
        BtnLimpiar2.TabIndex = 5
        BtnLimpiar2.Text = "Limpiar"
        BtnLimpiar2.UseVisualStyleBackColor = True
        ' 
        ' RTbxEjercicio2
        ' 
        RTbxEjercicio2.Location = New Point(153, 110)
        RTbxEjercicio2.Name = "RTbxEjercicio2"
        RTbxEjercicio2.Size = New Size(211, 176)
        RTbxEjercicio2.TabIndex = 5
        RTbxEjercicio2.Text = ""
        ' 
        ' BtnEje2Iniciar
        ' 
        BtnEje2Iniciar.Location = New Point(371, 48)
        BtnEje2Iniciar.Name = "BtnEje2Iniciar"
        BtnEje2Iniciar.Size = New Size(94, 29)
        BtnEje2Iniciar.TabIndex = 2
        BtnEje2Iniciar.Text = "Iniciar"
        BtnEje2Iniciar.UseVisualStyleBackColor = True
        ' 
        ' TbxNumEje2
        ' 
        TbxNumEje2.Location = New Point(210, 47)
        TbxNumEje2.Name = "TbxNumEje2"
        TbxNumEje2.Size = New Size(125, 35)
        TbxNumEje2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(18, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 22)
        Label2.TabIndex = 0
        Label2.Text = "Ingrese un numero:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), Image)
        GroupBox2.Controls.Add(TxtIncremento)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(RichTextBox2)
        GroupBox2.Controls.Add(BtnIniIncremento)
        GroupBox2.Controls.Add(TxtNumInc)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = SystemColors.ButtonHighlight
        GroupBox2.Location = New Point(1, 354)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(518, 463)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Contador"
        ' 
        ' TxtIncremento
        ' 
        TxtIncremento.Location = New Point(209, 100)
        TxtIncremento.Name = "TxtIncremento"
        TxtIncremento.Size = New Size(125, 35)
        TxtIncremento.TabIndex = 7
        TxtIncremento.Text = "1"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(17, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 22)
        Label4.TabIndex = 6
        Label4.Text = "Incremento:"
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(146, 181)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(225, 253)
        RichTextBox2.TabIndex = 5
        RichTextBox2.Text = ""
        ' 
        ' BtnIniIncremento
        ' 
        BtnIniIncremento.ForeColor = SystemColors.ActiveCaptionText
        BtnIniIncremento.Location = New Point(371, 73)
        BtnIniIncremento.Name = "BtnIniIncremento"
        BtnIniIncremento.Size = New Size(94, 29)
        BtnIniIncremento.TabIndex = 2
        BtnIniIncremento.Text = "Iniciar"
        BtnIniIncremento.UseVisualStyleBackColor = True
        ' 
        ' TxtNumInc
        ' 
        TxtNumInc.Location = New Point(210, 47)
        TxtNumInc.Name = "TxtNumInc"
        TxtNumInc.Size = New Size(125, 35)
        TxtNumInc.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(18, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(173, 22)
        Label3.TabIndex = 0
        Label3.Text = "Ingrese un numero:"
        ' 
        ' Pagina3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1069, 829)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Name = "Pagina3"
        Text = "Pagina3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents BtnEje1 As Button
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEje1Limpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RTbxEjercicio2 As RichTextBox
    Friend WithEvents BtnEje2Iniciar As Button
    Friend WithEvents TbxNumEje2 As TextBox
    Friend WithEvents BtnLimpiar2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents BtnIniIncremento As Button
    Friend WithEvents TxtNumInc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtIncremento As TextBox
    Friend WithEvents Label4 As Label
End Class

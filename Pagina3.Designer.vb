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
        Panel1 = New Panel()
        BtnEje1Limpiar = New Button()
        RichTextBox1 = New RichTextBox()
        BtnEje1 = New Button()
        TxtNum = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
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
        Panel1.Size = New Size(484, 353)
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
        BtnEje1.Location = New Point(376, 29)
        BtnEje1.Name = "BtnEje1"
        BtnEje1.Size = New Size(94, 29)
        BtnEje1.TabIndex = 2
        BtnEje1.Text = "Iniciar"
        BtnEje1.UseVisualStyleBackColor = True
        ' 
        ' TxtNum
        ' 
        TxtNum.Location = New Point(209, 29)
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
        ' Pagina3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(922, 725)
        Controls.Add(Panel1)
        Name = "Pagina3"
        Text = "Pagina3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents BtnEje1 As Button
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEje1Limpiar As Button
End Class

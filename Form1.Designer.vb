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
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(12, 6)
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
        Label1.Location = New Point(359, 13)
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
        TextBox1.Size = New Size(365, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.ForeColor = Color.IndianRed
        Button2.Location = New Point(268, 110)
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
        Label2.Location = New Point(23, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 21)
        Label2.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(629, 364)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Instruccion1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        ForeColor = Color.Coral
        Name = "Form1"
        Text = "Solucion 1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Instruccion1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label

End Class

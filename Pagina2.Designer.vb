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
        PnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblColor
        ' 
        LblColor.AutoSize = True
        LblColor.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblColor.Location = New Point(313, 34)
        LblColor.Name = "LblColor"
        LblColor.Size = New Size(163, 20)
        LblColor.TabIndex = 0
        LblColor.Text = "Seleccione un Color:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Verde", "Azul", "Rojo", "Amarillo", "Sin color"})
        ComboBox1.Location = New Point(492, 31)
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
        PnlHeader.Size = New Size(1010, 98)
        PnlHeader.TabIndex = 2
        ' 
        ' Pagina2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1010, 672)
        Controls.Add(PnlHeader)
        Name = "Pagina2"
        Text = "Ejercicios 2"
        PnlHeader.ResumeLayout(False)
        PnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LblColor As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PnlHeader As Panel
End Class

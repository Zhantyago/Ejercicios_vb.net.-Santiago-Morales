<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Texto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextNum1 = New System.Windows.Forms.TextBox()
        Me.TextNum2 = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Texto
        '
        Me.Texto.AutoSize = True
        Me.Texto.Location = New System.Drawing.Point(2, 2)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(131, 13)
        Me.Texto.TabIndex = 0
        Me.Texto.Text = "Digite la base del triangulo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Digite la altura del triangulo"
        '
        'TextNum1
        '
        Me.TextNum1.Location = New System.Drawing.Point(141, 0)
        Me.TextNum1.Name = "TextNum1"
        Me.TextNum1.Size = New System.Drawing.Size(105, 20)
        Me.TextNum1.TabIndex = 2
        '
        'TextNum2
        '
        Me.TextNum2.Location = New System.Drawing.Point(141, 21)
        Me.TextNum2.Name = "TextNum2"
        Me.TextNum2.Size = New System.Drawing.Size(105, 20)
        Me.TextNum2.TabIndex = 3
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(94, 57)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(70, 19)
        Me.Calcular.TabIndex = 4
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.TextNum2)
        Me.Controls.Add(Me.TextNum1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Texto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Texto As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextNum1 As System.Windows.Forms.TextBox
    Friend WithEvents TextNum2 As System.Windows.Forms.TextBox
    Friend WithEvents Calcular As System.Windows.Forms.Button

End Class

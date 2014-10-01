<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.archivo = New System.Windows.Forms.TextBox()
        Me.ejecutaFirma = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Archivo XML"
        '
        'archivo
        '
        Me.archivo.Location = New System.Drawing.Point(48, 86)
        Me.archivo.Name = "archivo"
        Me.archivo.Size = New System.Drawing.Size(152, 20)
        Me.archivo.TabIndex = 1
        '
        'ejecutaFirma
        '
        Me.ejecutaFirma.Location = New System.Drawing.Point(186, 177)
        Me.ejecutaFirma.Name = "ejecutaFirma"
        Me.ejecutaFirma.Size = New System.Drawing.Size(75, 25)
        Me.ejecutaFirma.TabIndex = 2
        Me.ejecutaFirma.Text = "Firmar"
        Me.ejecutaFirma.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ejecutaFirma)
        Me.Controls.Add(Me.archivo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Firma Digital"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents archivo As System.Windows.Forms.TextBox
    Friend WithEvents ejecutaFirma As System.Windows.Forms.Button

End Class

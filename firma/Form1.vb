Public Class Form1

    Private Sub ejecutaFirma_Click(sender As Object, e As EventArgs) Handles ejecutaFirma.Click
        MessageBox.Show("Se procesara el archivo indicado " & archivo.Text)
        pongaFirma(archivo.Text)
        'sacaX509()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

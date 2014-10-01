Imports System
Imports System.Security.Cryptography.X509Certificates

Module X509sacar

    Sub sacaX509()

        ' The path to the certificate. 
        Dim Certificate As String = "juancarrillo.cer"

        ' Load the certificate into an X509Certificate object. 
        Dim cert As New X509Certificate(Certificate)

        ' Get the value. 
        Dim resultsTrue As String = cert.ToString(True)

        ' Display the value to the console.
        Console.WriteLine(resultsTrue)

        ' Get the value. 
        Dim resultsFalse As String = cert.ToString(False)

        ' Display the value to the console.
        Console.WriteLine(resultsFalse)

    End Sub
End Module

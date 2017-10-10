Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Encryption.Encrypt(TextBox1.Text).ToLower() = "1fe0802764aaba20e57a3999e6fe885e" Then
            MsgBox("Success")
        Else
            MsgBox("Incorrect")
        End If
    End Sub



End Class

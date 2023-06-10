Imports System.IO
Imports System.Windows
Imports Microsoft.Office.Interop.Word
Public Class Form4
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TipoFichero As String
        TipoFichero = ""
        TipoFichero = "Fichero MSWord |*.doc;*.docx"


        Try
            Dim oFD As New OpenFileDialog
            With oFD
                .Filter = TipoFichero
                .FileName = TextBox1.Text
                If .ShowDialog = DialogResult.OK Then
                    TextBox1.Text = .FileName
                End If
            End With

        Catch oexcep As Exception
            MessageBox.Show("Error: //Abriendo Documento// " & vbCrLf &
"Use una ubicación diferente" & vbCrLf &
ControlChars.CrLf &
oexcep.Message & ControlChars.CrLf)

        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
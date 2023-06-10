Imports System.IO
Imports System.IO.File
Public Class Form5
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim op1 As OpenFileDialog = New OpenFileDialog() With {
          .ValidateNames = True,
          .Multiselect = False,
          .Filter = "Word|*.doc;*.docx"}
        If op1.ShowDialog() = DialogResult.OK Then

            Dim readonly1 As Object = True
            Dim visible As Object = True
            Dim save As Object = True
            Dim filename As Object = op1.FileName
            Dim file As String
            Dim missing As Object = Type.Missing
            Dim template As Object = False
            Dim typedoc As Object = 0
            file = Path.GetFileName(op1.FileName)
            TextBox1.Text = file
            Dim doc1 As Microsoft.Office.Interop.Word._Document = Nothing
            Dim word1 As Microsoft.Office.Interop.Word._Application = New Microsoft.Office.Interop.Word.Application() With {
              .Visible = False
            }

            doc1 = word1.Documents.Open(filename, readonly1, visible)
            doc1.ActiveWindow.Selection.WholeStory()
            doc1.ActiveWindow.Selection.Copy()
            Dim data1 As IDataObject = Clipboard.GetDataObject
            RichTextBox1.Rtf = data1.GetData(DataFormats.Rtf).ToString
            word1.Quit(missing)


        End If
    End Sub

End Class
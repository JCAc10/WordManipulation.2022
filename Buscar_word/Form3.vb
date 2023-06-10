Imports Word = Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop.Word
Public Class Form3
    Dim oWord As Word.Application
    Dim oDoc As Word.Document
    Dim oTable As Word.Table
    Dim oPara1 As Word.Paragraph
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add

        oPara1 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara1.Range.Text = TextBox1.Text
        oPara1.Range.Font.Bold = False
        oPara1.Format.SpaceAfter = 24
        oPara1.Range.InsertParagraphAfter()

        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 3, 5)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        oTable.Cell(1, 1).Range.Text = TextBox3.Text
        oTable.Cell(1, 2).Range.Text = TextBox4.Text
        oTable.Cell(1, 3).Range.Text = TextBox5.Text

        oTable.Cell(2, 1).Range.Text = TextBox6.Text
        oTable.Cell(2, 2).Range.Text = TextBox7.Text
        oTable.Cell(2, 3).Range.Text = TextBox8.Text

        oTable.Cell(3, 1).Range.Text = TextBox9.Text
        oTable.Cell(3, 2).Range.Text = TextBox10.Text
        oTable.Cell(3, 3).Range.Text = TextBox11.Text

        oTable.Rows.Item(1).Range.Font.Bold = True
        oTable.Rows.Item(1).Range.Font.Italic = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        oDoc.SaveAs2(".\TablaVB.docx")
    End Sub
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

End Class
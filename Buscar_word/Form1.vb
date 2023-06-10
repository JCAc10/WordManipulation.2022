Imports Word = Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop.Word
Public Class Form1
    Dim oWord As Word.Application
    Dim oDoc As Word.Document
    Dim oPara2 As Word.Paragraph
    Dim oPara3 As Word.Paragraph

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        'Inicia y abre word.
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add

        'Inserta un título en el documento.
        '** \endofdoc es un marcador pre definido
        oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara2.Range.Text = TextBox1.Text
        oPara2.Range.Font.Bold = False
        oPara2.Format.SpaceAfter = 6
        oPara2.Range.InsertParagraphAfter()

        'Inserta un párrafo al texto.
        oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara3.Range.Text = TextBox2.Text
        oPara3.Range.Font.Bold = False
        oPara3.Format.SpaceAfter = 24
        oPara3.Range.InsertParagraphAfter()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Guarda el documento como "DocumentoEnVB"
        oDoc.SaveAs2(".\DocumentoEnVB.docx")

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'BUSCAMOS EL TEXTO
        oDoc.ActiveWindow.Selection.Find.Text = TextBox3.Text
        oDoc.ActiveWindow.Selection.Find.Forward = True
        oDoc.ActiveWindow.Selection.Find.MatchCase = False
        'SI SI SE ENCONTRO EL TEXTO
        If oDoc.ActiveWindow.Selection.Find.Execute() Then
            'NOS MOVEMO S UNA LINEA ADELANTE
            oDoc.ActiveWindow.Selection.MoveRight(Unit:=WdUnits.wdCharacter, Count:=1)
            'ESCRIBIMOS
            oDoc.ActiveWindow.Selection.TypeText(Text:="<-Acá está la línea que buscas")
        Else
            MsgBox("Línea no encontrada")
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'BUSCAMOS EL TEXTO
        oDoc.ActiveWindow.Selection.Find.Text = TextBox3.Text
        oDoc.ActiveWindow.Selection.Find.Forward = True
        oDoc.ActiveWindow.Selection.Find.MatchCase = False
        'SI SI SE ENCONTRO EL TEXTO
        If oDoc.ActiveWindow.Selection.Find.Execute() Then
            'NOS MOVEMO S UNA LINEA ADELANTE
            oDoc.ActiveWindow.Selection.MoveRight(Unit:=WdUnits.wdCharacter, Count:=1)
            'ESCRIBIMOS
            oDoc.ActiveWindow.Selection.TypeText(Text:="<-Acá está la línea que buscas")
        Else
            MsgBox("Línea no encontrada")
        End If
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

End Class

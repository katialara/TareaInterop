Imports Word = Microsoft.Office.Interop.Word
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Dim dialogo As New SaveFileDialog()
    Private Sub pictureBoxWord_Click(sender As Object, e As EventArgs) Handles pictureBoxWord.Click


        If dialogo.ShowDialog = DialogResult.OK Then
            Dim ruta = dialogo.FileName
            Dim wordApp As New Word.Application()
            wordApp.Documents.Add()
            Dim dato = txtTexto.Text
            wordApp.Selection.TypeText(dato)
            wordApp.ActiveDocument.SaveAs2(ruta)
            wordApp.Visible = True
        End If

    End Sub

    Private Sub pictureBoxExcel_Click(sender As Object, e As EventArgs) Handles pictureBoxExcel.Click
        If dialogo.ShowDialog = DialogResult.OK Then
            Dim ruta = dialogo.FileName
            Dim excelApp As New Excel.Application
            Dim Libro = excelApp.Workbooks.Add
            Libro.Sheets(1).cells(1, 1) = txtTexto.Text
            Libro.SaveAs(ruta)
            excelApp.Visible = True
        End If
    End Sub
End Class

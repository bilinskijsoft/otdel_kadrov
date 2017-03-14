Imports Microsoft.Office.Interop

Public Class excellApp

    Private app As Excel.Application
    Private wBook As Excel.Workbook
    Private wSheet As Excel.Worksheet
    Private range As Excel.Range

    Public Sub createExcellApp(path As String)
        app = CreateObject("Excel.Application")
        app.Visible = True
        If path <> "" Then
            wBook = app.Workbooks.Open(path)
        Else
            wBook = app.Workbooks.Add
        End If
        wSheet = wBook.ActiveSheet
    End Sub

    Public Sub writeCell(text As String, row As Integer, col As Integer)
        wSheet.Cells(row, col).Value = text
    End Sub

    Public Sub destroyExcellApp()
        range = Nothing
        wSheet = Nothing
        wSheet = Nothing
        app.Quit()
        app = Nothing
    End Sub

    Public Sub copyRow(row As Integer)
        wSheet.Range("B" & row & ":G" & row).Copy(wSheet.Range("B" & row + 1 & ":G" & row + 1))
    End Sub
End Class

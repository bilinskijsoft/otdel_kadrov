Imports Microsoft.Office.Interop

''' <summary>
''' Класс роботи з файлом Excel
''' </summary>
Public Class excellApp

    Private app As Excel.Application
    Private wBook As Excel.Workbook
    Private wSheet As Excel.Worksheet
    Private range As Excel.Range

    ''' <summary>
    ''' Створюєме екземпляр програми excell
    ''' </summary>
    ''' <param name="path">Шлях до файлу</param>
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

    ''' <summary>
    ''' Записати інформацію до відкритого файлу
    ''' </summary>
    ''' <param name="text">Текст</param>
    ''' <param name="row">Рядок файлу</param>
    ''' <param name="col">Стовпчик файлу</param>
    Public Sub writeCell(text As String, row As Integer, col As Integer)
        wSheet.Cells(row, col).Value = text
    End Sub

    ''' <summary>
    ''' Знищюємо екземпляр програми Excel
    ''' </summary>
    Public Sub destroyExcellApp()
        range = Nothing
        wSheet = Nothing
        wSheet = Nothing
        app.Quit()
        app = Nothing
    End Sub

    ''' <summary>
    ''' Скопіювати рядок файлу
    ''' </summary>
    ''' <param name="row">номер рядку</param>
    Public Sub copyRow(row As Integer)
        wSheet.Range("B" & row & ":H" & row).Copy(wSheet.Range("B" & row + 1 & ":H" & row + 1))
    End Sub
End Class

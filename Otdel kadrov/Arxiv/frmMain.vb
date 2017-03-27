Imports System.ComponentModel

Public Class frmMain
    Dim excel As excellApp = New excellApp
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Відкрити вікно пошуку
        frmFindWorker.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        excel.createExcellApp("")

        Dim DB As DataBase = New DataBase
        Dim SQLreader As System.Data.SQLite.SQLiteDataReader
        DB.createDbConnection(Application.StartupPath & "/db.sqlite")
        'Іиконуємо запит до БД з фільтром
        SQLreader = DB.queryDb("SELECT * FROM workersf")
        Dim i = 0
        'Виводимм результат в таблицю
        While SQLreader.Read
            i = i + 1
            excel.writeCell(SQLreader.GetValue(1), i, 1)
            excel.writeCell(SQLreader.GetValue(2), i, 2)
            excel.writeCell(SQLreader.GetValue(3), i, 3)
            excel.writeCell(SQLreader.GetValue(4), i, 4)
            excel.writeCell(SQLreader.GetValue(5), i, 5)
            excel.writeCell(SQLreader.GetValue(6), i, 6)
            excel.writeCell(SQLreader.GetValue(7), i, 7)
            excel.writeCell(SQLreader.GetValue(8), i, 8)
            excel.writeCell(SQLreader.GetValue(9), i, 9)
            excel.writeCell(SQLreader.GetValue(10), i, 10)
            excel.writeCell(SQLreader.GetValue(11), i, 11)
            'excel.writeCell(SQLreader.GetValue(12), i, 12)
            excel.writeCell(SQLreader.GetValue(13), i, 12)
            excel.writeCell(SQLreader.GetValue(14), i, 13)

        End While
        SQLreader.Close()
        DB.closeDbConnection()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmExport.Show()
    End Sub

End Class

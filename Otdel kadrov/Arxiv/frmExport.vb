Public Class frmExport
    Dim excell As excellApp = New excellApp
    Dim DB As DataBase = New DataBase
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        'Створюємо тимчасову копію шаблону звіту та запускаємо Excel
        FileCopy(Application.StartupPath & "\report_uv.xlsx", Application.StartupPath & "\report_tmp.xlsx")
        excell.createExcellApp(Application.StartupPath & "\report_tmp.xlsx")

        'Заповнюємо дату звіту
        excell.writeCell(txtFromM.Text & "." & txtFromR.Text & "-" & txtToM.Text & "." & txtToR.Text, 3, 5)

        'Виконуємо запит по прийнятим працівникам до БД
        Dim SQLreader As System.Data.SQLite.SQLiteDataReader
        DB.createDbConnection(Application.StartupPath & "/db.sqlite")
        SQLreader = DB.queryDb("SELECT * FROM workersf")

        Dim counter As Integer
        'Обходимо всі записи БД
        While SQLreader.Read
            Dim datePriem As Date
            datePriem = Date.Parse(SQLreader.GetValue(8))
            'Фільтруємо по параметрам вказаним на формі
            If Month(datePriem) >= txtFromM.Text And Year(datePriem) >= txtFromR.Text And Month(datePriem) <= txtToM.Text And Year(datePriem) <= txtToR.Text Then
                'Записуємо інформацію до файлу
                counter = counter + 1
                excell.copyRow(counter + 7)
                excell.writeCell(counter, counter + 7, 2)
                excell.writeCell(SQLreader.GetValue(1), counter + 7, 3)
                excell.writeCell(SQLreader.GetValue(4), counter + 7, 4)
                excell.writeCell(SQLreader.GetValue(9), counter + 7, 5)
                excell.writeCell(SQLreader.GetValue(8), counter + 7, 7)
                excell.writeCell(SQLreader.GetValue(14), counter + 7, 6)
                excell.writeCell(SQLreader.GetValue(13), counter + 7, 8)
            End If

        End While

        SQLreader.Close()
        DB.closeDbConnection()
    End Sub
End Class
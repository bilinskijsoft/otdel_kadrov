''' <summary>
''' Форма роботи зі звітом
''' </summary>
Public Class frmStats
    Dim db As DataBase = New DataBase()
    Dim excell As excellApp = New excellApp

    ''' <summary>
    ''' При створенні форми заповнюємо поля параметрів по замовчуванню
    ''' </summary>
    Private Sub frmStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMonth.Text = Month(Date.Now)
        txtYear.Text = Year(Date.Now)
    End Sub

    ''' <summary>
    ''' Створити звіт
    ''' </summary>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Створюємо тимчасову копію шаблону звіту та запускаємо Excel
        FileCopy(Application.StartupPath & "\report.xlsx", Application.StartupPath & "\report_tmp.xlsx")
        excell.createExcellApp(Application.StartupPath & "\report_tmp.xlsx")

        'Заповнюємо дату звіту
        excell.writeCell(MonthName(txtMonth.Text) & " " & txtYear.Text & " р.", 3, 5)

        'Виконуємо запит по прийнятим працівникам до БД
        Dim SQLreader As System.Data.SQLite.SQLiteDataReader
        db.createDbConnection(Application.StartupPath & "/db.sqlite")
        SQLreader = db.queryDb("SELECT * FROM workers")

        Dim counter As Integer
        'Обходимо всі записи БД
        While SQLreader.Read
            Dim datePriem As Date
            datePriem = Date.Parse(SQLreader.GetValue(8))
            'Фільтруємо по параметрам вказаним на формі
            If Month(datePriem) = txtMonth.Text And Year(datePriem) = txtYear.Text Then
                'Записуємо інформацію до файлу
                counter = counter + 1
                excell.copyRow(counter + 7)
                excell.writeCell(counter, counter + 7, 2)
                excell.writeCell(SQLreader.GetValue(1), counter + 7, 3)
                excell.writeCell(SQLreader.GetValue(4), counter + 7, 4)
                excell.writeCell(SQLreader.GetValue(9), counter + 7, 5)
                excell.writeCell(SQLreader.GetValue(8), counter + 7, 6)
            End If

        End While

        SQLreader.Close()
        db.closeDbConnection()

        'Виконуємо запит по звільненим до БД
        db.createDbConnection(Application.StartupPath & "/db.sqlite")
        SQLreader = db.queryDb("SELECT * FROM workersf")
        'Обходимо всі записи БД
        While SQLreader.Read
            Dim datePriem As Date
            datePriem = Date.Parse(SQLreader.GetValue(8))
            'Фільтруємо по параметрам вказаним на формі
            If Month(datePriem) = txtMonth.Text And Year(datePriem) = txtYear.Text Then
                'Записуємо інформацію до файлу
                counter = counter + 1
                excell.copyRow(counter + 7)
                excell.writeCell(counter, counter + 7, 2)
                excell.writeCell(SQLreader.GetValue(1), counter + 7, 3)
                excell.writeCell(SQLreader.GetValue(4), counter + 7, 4)
                excell.writeCell(SQLreader.GetValue(9), counter + 7, 5)
                excell.writeCell(SQLreader.GetValue(8), counter + 7, 7)
                excell.writeCell(SQLreader.GetValue(14), counter + 7, 6)
            End If

        End While
        SQLreader.Close()
        db.closeDbConnection()

    End Sub
End Class
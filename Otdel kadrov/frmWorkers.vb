''' <summary>
''' Форма працівників
''' </summary>
Public Class frmWorkers
    Dim db As DataBase = New DataBase()

    ''' <summary>
    ''' При завантаженні форми заповнюємо фільтр та таблицю
    ''' </summary>
    Private Sub frmWorkers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQLreader As System.Data.SQLite.SQLiteDataReader
        'Виконуємо запит до БД
        db.createDbConnection(Application.StartupPath & "/db.sqlite")
        SQLreader = db.queryDb("SELECT * FROM workers WHERE fired=0")
        'Видаляємо всі дані з таблиці та філтру
        lstWorkers.Items.Clear()
        cbOtdel.Items.Clear()

        'Заповнюємо таблицю
        While SQLreader.Read
            'Вираховуємо стаж роботи
            Dim dataPriem = Date.Parse(SQLreader.GetValue(8))
            Dim stag = (Year(Date.Now) - Year(dataPriem)) * 12
            stag = stag + Month(Date.Now) - Month(dataPriem)

            lstWorkers.Items.Add(SQLreader.GetValue(0))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(1))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(2))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(3))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(4))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(5))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(6) + stag)
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(7))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(8))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(9))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(stag)
        End While
        SQLreader.Close()

        'Заповнюємо філтр
        SQLreader = db.queryDb("SELECT otdel FROM workers GROUP BY otdel")
        While SQLreader.Read
            cbOtdel.Items.Add(SQLreader.GetValue(0))
        End While

        db.closeDbConnection()
    End Sub

    'Зміна фільтру
    Private Sub cbOtdel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOtdel.SelectedIndexChanged
        Dim SQLreader As System.Data.SQLite.SQLiteDataReader
        db.createDbConnection(Application.StartupPath & "/db.sqlite")
        'Іиконуємо запит до БД з фільтром
        SQLreader = db.queryDb("SELECT * FROM workers WHERE otdel='" & cbOtdel.SelectedItem.ToString & "'")
        lstWorkers.Items.Clear()

        'Виводимм результат в таблицю
        While SQLreader.Read
            'Вираховуємо стаж роботи
            Dim dataPriem = Date.Parse(SQLreader.GetValue(8))
            Dim stag = (Year(Date.Now) - Year(dataPriem)) * 12
            stag = stag + Month(Date.Now) - Month(dataPriem)

            lstWorkers.Items.Add(SQLreader.GetValue(0))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(1))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(2))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(3))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(4))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(5))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(6) + stag)
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(7))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(8))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(9))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(stag)
        End While
        SQLreader.Close()
        db.closeDbConnection()
    End Sub

    'Кнопка відміни філтрації
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbOtdel.Text = ""
        frmWorkers_Load(Nothing, Nothing)
    End Sub

    'При подвійному натисканні мішою по працівнику - відкриваємо форму зміни даних
    Private Sub lstWorkers_DoubleClick(sender As Object, e As EventArgs) Handles lstWorkers.DoubleClick
        If lstWorkers.SelectedItems(0).Text <> "" Then
            frmWorker.loadForm(1, lstWorkers.SelectedItems(0).Text)
        End If
    End Sub
End Class
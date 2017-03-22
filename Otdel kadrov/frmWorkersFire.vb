''' <summary>
''' Форма для звільнення працівників
''' </summary>
Public Class frmWorkersFire
    Dim db As DataBase = New DataBase()

    'При завантаженні форми заповнюємо таблицю та фільтр
    Private Sub frmWorkersFire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQLreader As System.Data.SQLite.SQLiteDataReader
        db.createDbConnection(Application.StartupPath & "/db.sqlite")
        'Виконуємо запит до БД
        SQLreader = db.queryDb("SELECT * FROM workers WHERE fired=0")
        'Видалаємо дані з фільтру та таблиці
        lstWorkers.Items.Clear()
        cbOtdel.Items.Clear()
        'Запровнюємо таблицю
        While SQLreader.Read
            lstWorkers.Items.Add(SQLreader.GetValue(0))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(1))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(2))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(3))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(4))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(5))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(6))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(7))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(8))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(9))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(10))
        End While
        SQLreader.Close()
        'Заповнюємо фільтр
        SQLreader = db.queryDb("SELECT otdel FROM workers GROUP BY otdel")
        While SQLreader.Read
            cbOtdel.Items.Add(SQLreader.GetValue(0))
        End While

        db.closeDbConnection()
    End Sub

    'При зміні філтру
    Private Sub cbOtdel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOtdel.SelectedIndexChanged
        Dim SQLreader As System.Data.SQLite.SQLiteDataReader
        db.createDbConnection(Application.StartupPath & "/db.sqlite")
        'Виконуємо запит з фільтром
        SQLreader = db.queryDb("SELECT * FROM workers WHERE fired=0 AND otdel='" & cbOtdel.SelectedItem.ToString & "'")
        lstWorkers.Items.Clear()
        'Заповнюємо таблицю
        While SQLreader.Read
            lstWorkers.Items.Add(SQLreader.GetValue(0))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(1))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(2))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(3))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(4))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(5))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(6))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(7))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(8))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(9))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(10))
        End While
        SQLreader.Close()
        db.closeDbConnection()
    End Sub

    'Відалаємо фільтр
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbOtdel.Text = ""
        frmWorkersFire_Load(Nothing, Nothing)
    End Sub

    'При натисканні кнопки звільнити
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Перевіряємо чи виділений працівник в таблиці
        If lstWorkers.SelectedItems.Count > 0 Then
            'Просимо ввести дату звільнення та причину
            fireDialog.ShowDialog()
            'Якщо в діалозі натиснули ОК
            If fireDialog.DialogResult = DialogResult.OK Then

                db.createDbConnection(Application.StartupPath & "/db.sqlite")
                'Виконуємо пакет запітив до БД
                'Створюємо копію в архівну таблицю
                'Видаляємо дані з основної таблиці
                'Змінюємо дату звільнення в архівній таблиці
                db.queryDb("INSERT INTO workersf(id, fio, adress, phone, dolgn, obraz, stagob, simp, otdel, stag, picture) select id, fio, adress, phone, dolgn, obraz, stagob, simp, otdel, stag, picture from workers WHERE id='" & lstWorkers.SelectedItems(0).Text & "';" & "
                            DELETE FROM workers WHERE id='" & lstWorkers.SelectedItems(0).Text & "'; 
                            UPDATE workersf SET datauv='" & fireDialog.result.dateFire & "', reason='" & fireDialog.result.reason & "' WHERE id='" & lstWorkers.SelectedItems(0).Text & "';")
                db.closeDbConnection()

                'Перезавантажуємо дані в таблицю
                frmWorkersFire_Load(Nothing, Nothing)
            End If
        End If
    End Sub
End Class
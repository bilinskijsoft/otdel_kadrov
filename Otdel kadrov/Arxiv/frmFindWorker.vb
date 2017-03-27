Public Class frmFindWorker
    Dim DB As DataBase = New DataBase

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Trim(txtSearch.Text) <> "" Then
            Dim SQLreader As System.Data.SQLite.SQLiteDataReader
            DB.createDbConnection(Application.StartupPath & "/db.sqlite")
            'Виконуємо запит до БД з фільтром
            SQLreader = DB.queryDb("SELECT * FROM workersf WHERE fio LIKE '%" & Trim(txtSearch.Text) & "%'")
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
                lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(14))
                lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(8))
            End While
            SQLreader.Close()
            DB.closeDbConnection()
        End If
    End Sub

    Private Sub frmFindWorker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQLreader As System.Data.SQLite.SQLiteDataReader
        DB.createDbConnection(Application.StartupPath & "/db.sqlite")
        'Іиконуємо запит до БД з фільтром
        SQLreader = DB.queryDb("SELECT * FROM workersf")
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
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(14))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(8))
        End While
        SQLreader.Close()
        DB.closeDbConnection()
    End Sub

    Private Sub lstWorkers_DoubleClick(sender As Object, e As EventArgs) Handles lstWorkers.DoubleClick
        'Відкрити працівника по кліку на список
        If lstWorkers.SelectedItems(0).Text <> "" Then
            frmWorker.loadForm(lstWorkers.SelectedItems(0).Text)
        End If
    End Sub

    Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
        'Відновити працівника
        If lstWorkers.SelectedItems.Count > 0 Then
            frmWorkerRecover.loadForm(lstWorkers.SelectedItems(0).Text)
        End If
    End Sub

    Public Sub RefreshData()
        Dim SQLreader As System.Data.SQLite.SQLiteDataReader
        DB.createDbConnection(Application.StartupPath & "/db.sqlite")
        'Іиконуємо запит до БД з фільтром
        SQLreader = DB.queryDb("SELECT * FROM workersf")
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
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(14))
            lstWorkers.Items.Item(lstWorkers.Items.Count - 1).SubItems.Add(SQLreader.GetValue(8))
        End While
        SQLreader.Close()
        DB.closeDbConnection()
    End Sub
End Class
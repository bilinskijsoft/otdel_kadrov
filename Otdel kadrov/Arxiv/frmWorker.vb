Public Class frmWorker
    Dim act As Integer
    Dim db As DataBase = New DataBase()

    ''' <summary>
    ''' Завантаження форми з параметрами
    ''' </summary>
    ''' <param name="id">id працівника для зміни даних</param>
    Public Sub loadForm(id As Integer)
        'Якщо додаємо працівника то ниічго не заповнюємо

        Dim SQLreader As System.Data.SQLite.SQLiteDataReader
        'Виконуємо запит до БД
        db.createDbConnection(Application.StartupPath & "/db.sqlite")
        SQLreader = db.queryDb("SELECT * FROM workersf WHERE id=" & id)

        'Заповнюємо поля
        SQLreader.Read()
        'Вираховуємо стаж роботи
        Dim dataPriem = Date.Parse(SQLreader.GetValue(8))
        Dim stag = (Year(Date.Now) - Year(dataPriem)) * 12
        stag = stag + Month(Date.Now) - Month(dataPriem)

        txtId.Text = SQLreader.GetValue(0)
        txtFIO.Text = SQLreader.GetValue(1)
        txtAdress.Text = SQLreader.GetValue(2)
        txtPhone.Text = SQLreader.GetValue(3)
        txtDolgn.Text = SQLreader.GetValue(4)
        txtOsv.Text = SQLreader.GetValue(5)
        txtStagO.Text = SQLreader.GetValue(6) + stag
        txtSimPolog.Text = SQLreader.GetValue(7)
        txtData.Text = SQLreader.GetValue(14)
        txtDataUv.Text = SQLreader.GetValue(8)
        txtReason.Text = SQLreader.GetValue(13)
        txtOtdel.Text = stag

        PictureBox1.ImageLocation = Application.StartupPath & SQLreader.GetValue(12)

        SQLreader.Close()
        db.closeDbConnection()

        Me.Show()
    End Sub
End Class
Public Class frmWorkerRecover
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
        txtStagO.Text = ""
        txtSimPolog.Text = SQLreader.GetValue(7)
        txtData.Text = ""
        txtOtdel.Text = SQLreader.GetValue(9)

        PictureBox1.ImageLocation = Application.StartupPath & SQLreader.GetValue(12)

        SQLreader.Close()
        db.closeDbConnection()

        Me.Show()
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        OpenFile.ShowDialog()
        'Встановлюємо фільтр для файлів
        With OpenFile
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 2
        End With
        PictureBox1.Image = Image.FromFile(OpenFile.FileName)
    End Sub

    Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
        If txtData.Text <> "" Then
            PictureBox1.Image.Save(Application.StartupPath & "\images\" & txtId.Text & ".jpg", Imaging.ImageFormat.Jpeg)

            db.createDbConnection(Application.StartupPath & "/db.sqlite")
            'Виконуємо пакет запітив до БД

            db.queryDb("INSERT INTO workers(id, fio, adress, phone, dolgn, obraz, stagob, simp, otdel, stag, picture) select id, fio, adress, phone, dolgn, obraz, stagob, simp, otdel, stag, picture from workersf WHERE id='" & txtId.Text & "';" & "
                                DELETE FROM workersf WHERE id='" & txtId.Text & "'; 
                                UPDATE workers SET datap='" & txtData.Text & "' WHERE id='" & txtId.Text & "';")
            db.closeDbConnection()

            frmFindWorker.RefreshData()
            Me.Close()
        Else
            MsgBox("Введіть дату прийому!")
        End If
    End Sub
End Class
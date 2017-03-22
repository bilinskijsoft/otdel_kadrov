Imports System.IO

''' <summary>
''' Форма роботи з працівником
''' </summary>
Public Class frmWorker
    Dim act As Integer
    Dim db As DataBase = New DataBase()

    ''' <summary>
    ''' Обробка натискання кнопки Зберегти/Додати
    ''' </summary>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        'Якщо зберігаємо запис
        If btnAction.Text = "Зберегти" Then
            'Збережемо файл фото
            PictureBox1.Image.Save(Application.StartupPath & "\images\" & txtId.Text & ".jpg", Imaging.ImageFormat.Jpeg)
            'Виконаємо запит на збереження даних
            db.createDbConnection(Application.StartupPath & "/db.sqlite")
            db.queryDb("UPDATE workers SET 
                        fio= '" & txtFIO.Text & "',
                        adress= '" & txtAdress.Text & "',
                        phone= '" & txtPhone.Text & "',
                        dolgn= '" & txtDolgn.Text & "',
                        obraz= '" & txtOsv.Text & "',
                        stagob= '" & txtStagO.Text & "',
                        simp= '" & txtSimPolog.Text & "',
                        datap= '" & txtData.Text & "',
                        otdel= '" & txtOtdel.Text & "',
                        stag= '" & txtStag.Text & "',
                        picture= '" & Application.StartupPath & "\images\" & txtId.Text & ".jpg' 
                        WHERE id=" & txtId.Text)
            db.closeDbConnection()
        Else 'Якщо додаємо працівника
            Dim SQLreader As System.Data.SQLite.SQLiteDataReader
            'Виконуємо запит на додавання працівника
            db.createDbConnection(Application.StartupPath & "/db.sqlite")
            db.queryDb("INSERT INTO workers (fio, adress, phone, dolgn, obraz, simp, datap, otdel, stag, picture) 
                                    VALUES  ('" & txtFIO.Text & "', 
                                             '" & txtAdress.Text & "', 
                                             '" & txtPhone.Text & "', 
                                             '" & txtDolgn.Text & "', 
                                             '" & txtOsv.Text & "', 
                                             '" & txtSimPolog.Text & "', 
                                             '" & txtData.Text & "', 
                                             '" & txtOtdel.Text & "', 
                                             '" & txtStag.Text & "', 
                                             '')")
            db.closeDbConnection()
            db.createDbConnection(Application.StartupPath & "/db.sqlite")
            'Отримаємо id останньго доданого працівника
            SQLreader = db.queryDb("SELECT seq FROM sqlite_sequence WHERE name='workers'")
            SQLreader.Read()
            'Збережемо зображення
            Dim imgPath = Application.StartupPath & "\images\" & SQLreader.GetValue(0) & ".jpg"
            Dim id = SQLreader.GetValue(0)
            PictureBox1.Image.Save(imgPath, Imaging.ImageFormat.Jpeg)
            SQLreader.Close()
            db.closeDbConnection()
            'Оновимо дані по працівнику - збережемо зображення
            db.createDbConnection(Application.StartupPath & "/db.sqlite")
            db.queryDb("UPDATE workers SET picture='" & imgPath & "' WHERE id=" & id)
            db.closeDbConnection()
        End If
        Me.Close()
    End Sub

    ''' <summary>
    ''' Завантаження форми з параметрами
    ''' </summary>
    ''' <param name="Action">Тип дії: 0-Додати 1-Зберегти</param>
    ''' <param name="id">id працівника для зміни даних</param>
    Public Sub loadForm(Action As Integer, id As Integer)
        'Якщо додаємо працівника то ниічго не заповнюємо
        If Action = 0 Then
            btnAction.Text = "Додати"
            'Інакше заповнюємо всі поля
        Else
            btnAction.Text = "Зберегти"
            Dim SQLreader As System.Data.SQLite.SQLiteDataReader
            'Виконуємо запит до БД
            db.createDbConnection(Application.StartupPath & "/db.sqlite")
            SQLreader = db.queryDb("SELECT * FROM workers WHERE id=" & id)

            'Заповнюємо поля
            SQLreader.Read()
            txtId.Text = SQLreader.GetValue(0)
            txtFIO.Text = SQLreader.GetValue(1)
            txtAdress.Text = SQLreader.GetValue(2)
            txtPhone.Text = SQLreader.GetValue(3)
            txtDolgn.Text = SQLreader.GetValue(4)
            txtOsv.Text = SQLreader.GetValue(5)
            txtStagO.Text = SQLreader.GetValue(6)
            txtSimPolog.Text = SQLreader.GetValue(7)
            txtData.Text = SQLreader.GetValue(8)
            txtOtdel.Text = SQLreader.GetValue(9)
            txtStag.Text = SQLreader.GetValue(10)

            PictureBox1.ImageLocation = SQLreader.GetValue(12)

            SQLreader.Close()
            db.closeDbConnection()
        End If
        Me.Show()
    End Sub

    ''' <summary>
    ''' Відкрити файл зображення
    ''' </summary>
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        openFile.ShowDialog()
        'Встановлюємо фільтр для файлів
        With openFile
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 2
        End With
        PictureBox1.Image = Image.FromFile(openFile.FileName)
    End Sub
End Class
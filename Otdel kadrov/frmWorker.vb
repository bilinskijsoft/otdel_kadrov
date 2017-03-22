Imports System.IO

Public Class frmWorker
    Dim act As Integer
    Dim db As DataBase = New DataBase()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        If btnAction.Text = "Зберегти" Then
            PictureBox1.Image.Save(Application.StartupPath & "\images\" & txtId.Text & ".jpg", Imaging.ImageFormat.Jpeg)

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
        Else
            Dim SQLreader As System.Data.SQLite.SQLiteDataReader
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
            SQLreader = db.queryDb("SELECT seq FROM sqlite_sequence WHERE name='workers'")
            SQLreader.Read()
            Dim imgPath = Application.StartupPath & "\images\" & SQLreader.GetValue(0) & ".jpg"
            Dim id = SQLreader.GetValue(0)
            PictureBox1.Image.Save(imgPath, Imaging.ImageFormat.Jpeg)
            SQLreader.Close()
            db.closeDbConnection()
            db.createDbConnection(Application.StartupPath & "/db.sqlite")
            db.queryDb("UPDATE workers SET picture='" & imgPath & "' WHERE id=" & id)
            db.closeDbConnection()
        End If
        Me.Close()
    End Sub

    Public Sub loadForm(Action As Integer, id As Integer)
        act = Action
        If Action = 0 Then
            btnAction.Text = "Додати"
        Else
            btnAction.Text = "Зберегти"
            Dim SQLreader As System.Data.SQLite.SQLiteDataReader
            db.createDbConnection(Application.StartupPath & "/db.sqlite")
            SQLreader = db.queryDb("SELECT * FROM workers WHERE id=" & id)

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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        openFile.ShowDialog()
        With openFile
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 2
        End With
        PictureBox1.Image = Image.FromFile(openFile.FileName)
    End Sub

    Private Sub frmWorker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
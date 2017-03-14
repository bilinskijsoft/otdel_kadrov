Public Class frmWorker
    Dim act As Integer
    Dim db As DataBase = New DataBase()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAction.Click
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

            SQLreader.Close()
            db.closeDbConnection()
        End If
        Me.Show()
    End Sub
End Class
Public Class frmWorkers
    Dim db As DataBase = New DataBase()

    Private Sub frmWorkers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQLreader As System.Data.SQLite.SQLiteDataReader
        db.createDbConnection(Application.StartupPath & "/db.sqlite")
        SQLreader = db.queryDb("SELECT * FROM workers WHERE fired=0")
        lstWorkers.Items.Clear()
        cbOtdel.Items.Clear()

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

        SQLreader = db.queryDb("SELECT otdel FROM workers GROUP BY otdel")
        While SQLreader.Read
            cbOtdel.Items.Add(SQLreader.GetValue(0))
        End While

        db.closeDbConnection()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub cbOtdel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOtdel.SelectedIndexChanged
        Dim SQLreader As System.Data.SQLite.SQLiteDataReader
        db.createDbConnection(Application.StartupPath & "/db.sqlite")
        SQLreader = db.queryDb("SELECT * FROM workers WHERE otdel='" & cbOtdel.SelectedItem.ToString & "'")
        lstWorkers.Items.Clear()

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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbOtdel.Text = ""
        frmWorkers_Load(Nothing, Nothing)
    End Sub

    Private Sub lstWorkers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstWorkers.SelectedIndexChanged

    End Sub

    Private Sub lstWorkers_DoubleClick(sender As Object, e As EventArgs) Handles lstWorkers.DoubleClick
        If lstWorkers.SelectedItems(0).Text <> "" Then
            frmWorker.loadForm(1, lstWorkers.SelectedItems(0).Text)
        End If
    End Sub
End Class
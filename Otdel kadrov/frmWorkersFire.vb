Public Class frmWorkersFire
    Dim db As DataBase = New DataBase()

    Private Sub frmWorkersFire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub cbOtdel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOtdel.SelectedIndexChanged
        Dim SQLreader As System.Data.SQLite.SQLiteDataReader
        db.createDbConnection(Application.StartupPath & "/db.sqlite")
        SQLreader = db.queryDb("SELECT * FROM workers WHERE fired=0 AND otdel='" & cbOtdel.SelectedItem.ToString & "'")
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
        frmWorkersFire_Load(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lstWorkers.SelectedItems.Count > 0 Then
            fireDialog.ShowDialog()

            If fireDialog.DialogResult = DialogResult.OK Then

                db.createDbConnection(Application.StartupPath & "/db.sqlite")
                db.queryDb("INSERT INTO workersf(id, fio, adress, phone, dolgn, obraz, stagob, simp, otdel, stag, picture) select id, fio, adress, phone, dolgn, obraz, stagob, simp, otdel, stag, picture from workers WHERE id='" & lstWorkers.SelectedItems(0).Text & "';" & "
                            DELETE FROM workers WHERE id='" & lstWorkers.SelectedItems(0).Text & "'; 
                            UPDATE workersf SET datauv='" & fireDialog.result.dateFire & "', reason='" & fireDialog.result.reason & "' WHERE id='" & lstWorkers.SelectedItems(0).Text & "';")
                db.closeDbConnection()

                frmWorkersFire_Load(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub lstWorkers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstWorkers.SelectedIndexChanged

    End Sub
End Class
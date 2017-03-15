Public Class frmStats
    Dim db As DataBase = New DataBase()
    Dim excell As excellApp = New excellApp


    Private Sub frmStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileCopy(Application.StartupPath & "\report.xlsx", Application.StartupPath & "\report_tmp.xlsx")
        excell.createExcellApp(Application.StartupPath & "\report_tmp.xlsx")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SQLreader As System.Data.SQLite.SQLiteDataReader
        db.createDbConnection(Application.StartupPath & "/db.sqlite")
        SQLreader = db.queryDb("SELECT * FROM workers")


        Dim counter As Integer
        While SQLreader.Read
            counter = counter + 1
            excell.copyRow(counter + 7)
            excell.writeCell(counter, counter + 7, 2)
            excell.writeCell(SQLreader.GetValue(1), counter + 7, 3)
            excell.writeCell(SQLreader.GetValue(4), counter + 7, 4)
            excell.writeCell(SQLreader.GetValue(9), counter + 7, 5)
            excell.writeCell(SQLreader.GetValue(8), counter + 7, 6)

        End While


        db.closeDbConnection()
    End Sub
End Class
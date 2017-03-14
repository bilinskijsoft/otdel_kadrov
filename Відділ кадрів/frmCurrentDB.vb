Public Class frmCurrentDB
    Private Sub frmCurrentDB_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub frmCurrentDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBranches_Click(sender As Object, e As EventArgs) Handles btnBranches.Click
        frmWorkers.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmWorker.loadForm(0, 0)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        frmWorkersFire.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmStats.Show()
    End Sub
End Class
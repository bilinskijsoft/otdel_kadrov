Public Class frmCurrentDB
    Private Sub frmCurrentDB_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub frmCurrentDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBranches_Click(sender As Object, e As EventArgs) Handles btnBranches.Click
        frmWorkers.Show()
    End Sub
End Class
''' <summary>
''' Первинна форма для роботи з программою
''' </summary>
Public Class frmCurrentDB
    ''' <summary>
    ''' Закрити программу
    ''' </summary>
    Private Sub frmCurrentDB_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
    ''' <summary>
    ''' Показати форму співробітників
    ''' </summary>
    Private Sub btnBranches_Click(sender As Object, e As EventArgs) Handles btnBranches.Click
        frmWorkers.Show()
    End Sub
    ''' <summary>
    ''' Додати співробітника
    ''' </summary>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmWorker.loadForm(0, 0)
    End Sub
    ''' <summary>
    ''' Звільнити співробітника
    ''' </summary>
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        frmWorkersFire.Show()
    End Sub
    ''' <summary>
    ''' Відкрити форму звіту
    ''' </summary>
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmStats.Show()
    End Sub
End Class
Public Class frmStats
    Dim excell As excellApp = New excellApp
    Private Sub frmStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        excell.createExcellApp(Application.StartupPath & "\report.xlsx")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        excell.copyRow(8)
    End Sub
End Class
''' <summary>
''' Заставка программи при старті
''' </summary>
Public Class frmStart
    ''' <summary>
    ''' Відкрити вікно роботи з основоною БД
    ''' </summary>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MsgBox("Увага!" & vbCrLf & "Усі дати вводити у форматі ДД-ММ-РРРР!", MsgBoxStyle.Exclamation, "Увага!")
        frmCurrentDB.Show()
    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            MkDir(Application.StartupPath & "\images")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start(Application.StartupPath & "\Arxiv.exe")
        Shell("Arxiv.exe")
        Application.Exit()
    End Sub
End Class

﻿''' <summary>
''' Заставка программи при старті
''' </summary>
Public Class frmStart
    ''' <summary>
    ''' Відкрити вікно роботи з основоною БД
    ''' </summary>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmCurrentDB.Show()
    End Sub
End Class

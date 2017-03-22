Imports System.Windows.Forms

Public Class fireDialog
    Public result As dialogFireResult = New dialogFireResult

    ''' <summary>
    ''' Структура відповіді діалогового вікна
    ''' </summary>
    Public Structure dialogFireResult
        Dim buttonOK As Boolean
        Dim dateFire As String
        Dim reason As String
    End Structure

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        result.dateFire = txtDate.Text
        result.reason = txtReason.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class

Imports System.Data.SQLite

Public Class DataBase
    Private SQLconnect As New SQLiteConnection()
    Private SQLcommand As SQLiteCommand
    Private SQLreader As SQLiteDataReader

    Public Function createDbConnection(dbPath As String)
        SQLconnect.ConnectionString = "Data Source=" & dbPath
        Try
            SQLconnect.Open() : SQLcommand = SQLconnect.CreateCommand
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Public Function closeDbConnection()
        Try
            SQLconnect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Public Function queryDb(query As String)
        SQLcommand.CommandText = query
        Try
            SQLreader = SQLcommand.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return vbNull
        End Try

        Return SQLreader
    End Function
End Class

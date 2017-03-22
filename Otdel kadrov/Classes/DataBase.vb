Imports System.Data.SQLite

''' <summary>
''' Класс роботи з базою даних
''' </summary>
Public Class DataBase
    Private SQLconnect As New SQLiteConnection()
    Private SQLcommand As SQLiteCommand
    Private SQLreader As SQLiteDataReader

    ''' <summary>
    ''' Створюємо підключення до БД
    ''' </summary>
    ''' <param name="dbPath">Шлях до файлу БД</param>
    ''' <returns>Повертає істину якщо вдало</returns>
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

    ''' <summary>
    ''' Закриваємо підключення до БД
    ''' </summary>
    ''' <returns>Повертає істину якщо вдало</returns>
    Public Function closeDbConnection()
        Try
            SQLconnect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    ''' <summary>
    ''' Запит до БД
    ''' </summary>
    ''' <param name="query">Текст запиту у форматі SQL</param>
    ''' <returns>Повертая тип System.Data.SQLite.SQLReader при вдалості, інакше Null</returns>
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

Imports System.Data.Odbc
Module Module1
    Public Conn As OdbcConnection
    Public rd As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public MyDB As String

    Sub koneksi()
        MyDB = "Driver={MySQL ODBC 5.1 Driver};server=localhost;uid=root;database=perpusonline;port=3306"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module

Imports MySql.Data.MySqlClient
Module Module1


    Public connection As String
    Public SQLConn As New MySqlConnection
    Public SQLcmd As New MySqlCommand
    Public SQLdr As MySqlDataReader
    Public test As MySqlException

    Public DatabaseName As String = My.Settings.db
    Public server As String = My.Settings.server
    Public userName As String = My.Settings.un
    Public password As String = My.Settings.pw
    Public port As String = My.Settings.port

    Public TellerID As Integer
    Public tellercount As Integer
    Public totaltellers As Integer
    Public newTB(totaltellers) As Object
    Public newlbl(totaltellers) As Object
    Public interval As Integer
    Public branch As String = My.Settings.branch
    Public branch_id As String
    Public datenow As String = DateTime.Now.Year.ToString & "-" & DateTime.Now.Month & "-" & DateTime.Now.Day


    Public Sub SQLClose()
        SQLdr.Close()
        SQLConn.Close()
    End Sub

    Public Sub SQLOpen()

        SQLConn.Open()
        SQLcmd.Connection = SQLConn
    End Sub

    Public Sub SQLConnectionString()
        If Not SQLConn Is Nothing Then SQLConn.Close()
        ' SQLConn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=true", server, userName, password, DatabaseName)
        connection = "server=" & server & ";port=" & port & ";uid=" & userName & ";pwd=" & password & ";database=" & DatabaseName & "" '"server=" & server & ";uid=" & userName & ";pwd=" & password & ";database=" & DatabaseName & ";"
        SQLConn.ConnectionString = connection
    End Sub

    Public Sub SQLQuery(query As String)
        SQLcmd.CommandText = query
        SQLdr = SQLcmd.ExecuteReader()
    End Sub

End Module

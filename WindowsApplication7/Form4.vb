
Public Class Form4


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtdb.TextChanged, txtp.TextChanged, txtu.TextChanged, txthn.TextChanged
        If Not txtdb.Text = "" Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        DatabaseName = txtdb.Text
        userName = txtu.Text
        password = txtp.Text
        port = txtport.Text
        server = txthn.Text
        SQLConnectionString()
        Try
            SQLConn.Open()
            My.Settings.Save()
            My.Settings.Reload()
            Me.Hide()
            ' Form2.Show()
            setBranchvb.Show()

        Catch myerror As MySql.Data.MySqlClient.MySqlException

            MsgBox("Error Connecting to Database: " & myerror.Message, vbCritical, "Error")
        Finally
            SQLConn.Dispose()
            My.Settings.db = txtdb.Text
            My.Settings.un = txtu.Text
            My.Settings.pw = txtp.Text
            My.Settings.port = txtport.Text
            My.Settings.server = txthn.Text
           
            My.Settings.Save()
        End Try

    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdb.Text = My.Settings.db
        txthn.Text = My.Settings.server
        txtport.Text = My.Settings.port
        txtu.Text = My.Settings.un
        txtp.Text = My.Settings.pw
        MsgBox("FQS - Client", vbInformation, "Welcome")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to exit?", vbYesNo, "Exit Program") = MsgBoxResult.Yes Then
            Dispose()
            Me.Close()
            Application.Exit()
        End If

    End Sub
End Class
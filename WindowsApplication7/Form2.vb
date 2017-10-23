

Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        btnLogin.Enabled = False

        SQLConn.ConnectionString = connection

        For j As Integer = 0 To 1 Step 0

            SQLConn.Open()

            SQLcmd.Connection = SQLConn
            SQLcmd.CommandText = "select * from user where isActive = 'T' and branch_id='" & branch_id & "'" ' and teller = '" & (i) & "'"
            SQLdr = SQLcmd.ExecuteReader()
            Dim temp As Integer
            While SQLdr.Read()
                temp = temp + 1
            End While


            totaltellers = temp

            SQLdr.Close()
            SQLConn.Close()

            Exit For

        Next


        ReDim newTB(totaltellers)
        ReDim newlbl(totaltellers)

        'SQLConn.ConnectionString = connection
        SQLcmd.Connection = SQLConn
        SQLConn.Open()


        SQLcmd.CommandText = "select * from user where username = '" & txtUsername.Text & "' and password = '" & txtPassword.Text & "' and branch_id='" & branch_id & "'"
        SQLdr = SQLcmd.ExecuteReader()

        While SQLdr.Read()
            Form3.Text = "Welcome Teller " & SQLdr("teller").ToString
            If SQLdr("isActive").ToString = "T" Then
                MsgBox("Welcome Back " & Form3.Text, MsgBoxStyle.Information, "Login")
                SQLdr.Close()
                SQLConn.Close()
                btnLogin.Enabled = True
                Me.Hide()
                Form3.Show()
                Exit Sub
            ElseIf SQLdr("username").ToString = "admin" Then
                Me.Hide()
                Form1.Show()
                SQLdr.Close()
                SQLConn.Close()
                btnLogin.Enabled = True
                Exit Sub
            End If

            SQLdr.Close()
            SQLConn.Close()

            SQLConn.ConnectionString = connection
            SQLcmd.Connection = SQLConn
            SQLConn.Open()
            SQLcmd.CommandText = "update user set isActive ='T' where username = '" & txtUsername.Text & "' and branch_id='" & branch_id & "'"
            SQLdr = SQLcmd.ExecuteReader()
            Me.Hide()
            Form3.Show()

            SQLdr.Close()
            SQLConn.Close()
            btnLogin.Enabled = True
            Exit Sub
        End While

        SQLdr.Close()
        SQLConn.Close()

        MsgBox("Account Not Found", MsgBoxStyle.Critical, "Login")
        btnLogin.Enabled = True
 
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to exit?", vbYesNo, "Exit Program") = MsgBoxResult.Yes Then
            Me.Dispose()
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblbranchname.Text = setBranchvb.ComboBox1.Text & " Branch"
        ' where branch_id='" & branch_id & "'"
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form4.Show()

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles lblbranchname.Click

    End Sub


    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub DatabaseToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles DatabaseToolStripMenuItem1.Click
        If MsgBox("Are you sure you want to exit?", vbYesNo, "Exit Program") = MsgBoxResult.Yes Then
            Me.Dispose()
            Me.Close()
            Application.Exit()
        End If
    End Sub
End Class
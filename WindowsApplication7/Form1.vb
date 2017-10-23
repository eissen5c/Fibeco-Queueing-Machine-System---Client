Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Are you sure to Logout?", vbYesNo, "Logout") = MsgBoxResult.Yes Then
            Me.Hide()
            Form2.txtUsername.Clear()
            Form2.txtPassword.Clear()
            Form2.Show()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txtOld.Text = Form2.txtPassword.Text Then
            SQLdr.Close()
            SQLConn.Close()
            SQLConn.Open()

            SQLcmd.Connection = SQLConn
            SQLcmd.CommandText = "update user set password = '" & txtNew.Text & "' where username = '" & Form2.txtUsername.Text & "' and branch_id='" & branch_id & "'"
            SQLdr = SQLcmd.ExecuteReader()

            SQLdr.Close()
            SQLConn.Close()
            MsgBox("Password Succesfuly Changed", vbInformation, "Password Change")
            txtOld.Clear()
            txtNew.Clear()

            Panel1.Visible = False
        Else
            MsgBox("Password Not Match", vbInformation, "Password Change")
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SQLConnectionString()
        SQLOpen()
        SQLQuery("update user set isActive='F' where not username='admin'")
        SQLClose()
        MsgBox("Logout Success", vbInformation, "Logout")
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        SQLConnectionString()
        SQLOpen()
        SQLQuery("update status set current_count='0' ")
        SQLClose()

        ' SQLConnectionString()
        'SQLOpen()
        'SQLQuery("delete from current")
        'SQLClose()

        MsgBox("Reset Success", vbInformation, "Logout")
    End Sub
End Class
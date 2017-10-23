Public Class Form3

   
    Dim count As Integer = 0
    Dim countwp As Integer = 0


    Private Sub btnserved_Click(sender As Object, e As EventArgs) Handles btnserved.Click
        If btnserved.Text = "Serve" Then

            count = count - 1
            SQLConnectionString()
            SQLOpen()
            SQLQuery("update indexcount set indexcount='" & count & "' where date='" & datenow & "' and branch_id='" & branch_id & "'")
            SQLClose()

            SQLConnectionString()
            SQLOpen()
            SQLQuery("update current set status='OK' where number='" & Label3.Text & "' and date_print ='" & datenow & "' and branch_id = '" & branch_id & "'")
            SQLClose()
            MsgBox("Number is Served", vbInformation, "Served")
            btnserved.Text = "UnServe"
        Else

            count = count + 1
            SQLConnectionString()
            SQLOpen()
            SQLQuery("update indexcount set indexcount='" & count & "' where date='" & datenow & "' and branch_id='" & branch_id & "'")
            SQLClose()
            SQLConnectionString()
            SQLOpen()
            SQLQuery("update current set status='NOT' where status='OK' and number='" & Label3.Text & "' and date_print ='" & datenow & "' and branch_id = '" & branch_id & "'")
            SQLClose()
            MsgBox("Number is Not Served", vbInformation, "Not Served")
            btnserved.Text = "Serve"

        End If

    End Sub

    Private Sub btnNext_button(sender As Object, e As EventArgs) Handles btnNext.Click
        btnNext.Enabled = False
        btnserved.Enabled = False
        btnBeep.Enabled = False
        btnserved.Text = "Serve"
        Dim tellercapacity As Integer = 0
        Dim tellercapacitywp As Integer = 0
        Dim currentcapacity As Integer = 0
        Dim currentcapacitywp As Integer = 0

      
        SQLConnectionString()
        SQLOpen()
        SQLQuery("update current set status = 'NOT', teller = 'X'  where number='" & Label3.Text & "' and status='NEW' and date_print ='" & datenow & "' and branch_id='" & branch_id & "'")
        SQLClose()

        SQLConnectionString()
        SQLOpen()
        SQLQuery("update current set teller = 'X' where number='" & Label3.Text & "' and status='NOT' and date_print ='" & datenow & "' and branch_id='" & branch_id & "'")
        SQLClose()

        If lstPriority.Items.Count = 0 Then
            CheckBox1.Checked = False
        End If


        If CheckBox1.Checked = True Then 'if senior priority activate
            '=======================================================START OF WITH PRIORITY
            SQLConnectionString()
            SQLOpen()
            SQLQuery("select * from current where status = 'NEW' and date_print ='" & datenow & "' and branch_id = '" & branch_id & "' and teller ='X' ")


            While SQLdr.Read
                tellercapacitywp = tellercapacitywp + 1
            End While

            currentcapacitywp = tellercapacitywp
            SQLClose()


            If tellercapacitywp = 0 Then

                SQLConnectionString()
                SQLOpen()
                SQLQuery("select * from indexcount where date='" & datenow & "' and branch_id='" & branch_id & "'")
                If SQLdr.HasRows = False Then
                    SQLClose()
                    SQLConnectionString()
                    SQLOpen()
                    SQLQuery("insert into indexcount (indexcount,indexcountwp,date,branch_id) values ('0','0',NOW(),'" & branch_id & "')")
                    SQLClose()
                Else
                    While SQLdr.Read
                        count = SQLdr("indexcount")
                    End While
                    SQLClose()
                End If


                SQLConnectionString()
                SQLOpen()
                SQLQuery("select * from current where status = 'NOT' and date_print ='" & datenow & "' and branch_id = '" & branch_id & "' and teller ='X' ")

                While SQLdr.Read
                    tellercapacitywp = tellercapacitywp + 1
                End While

                SQLClose()

                If countwp = tellercapacitywp Then
                    countwp = 0
                    SQLConnectionString()
                    SQLOpen()
                    SQLQuery("update indexcount set indexcountwp='" & countwp & "' where  date='" & datenow & "' and branch_id='" & branch_id & "'")
                    SQLClose()
                End If

                SQLConnectionString()
                SQLOpen()
                SQLQuery("select * from current where status = 'NOT' and date_print ='" & datenow & "' and branch_id = '" & branch_id & "' and teller ='X' ")

                If SQLdr.HasRows = False Then
                    MsgBox("Empty Queue", vbInformation, "")
                    Label3.Text = ""
                    lbltype.Text = "-"
                    btnserved.Enabled = False
                    btnBeep.Enabled = False

                Else
                    Dim temp As Integer = 0
                    Dim temp2 As Integer = 0
                    While SQLdr.Read
                        Label3.Text = SQLdr("number")
                        lbltype.Text = SQLdr("type")
                        If temp = countwp Then
                            countwp = countwp + 1
                            SQLConnectionString()
                            SQLOpen()
                            SQLQuery("update indexcount set indexcountwp='" & countwp & "' where date='" & datenow & "' and branch_id='" & branch_id & "'")
                            'SQLClose()
                            'Exit While
                        End If
                        temp = temp + 1
                    End While
                    SQLClose()

                    temp = 0


                    SQLClose()
                    btnserved.Enabled = True
                    btnBeep.Enabled = True
                End If


            Else
                SQLConnectionString()
                SQLOpen()
                SQLQuery("select * from current where status = 'NEW' and date_print ='" & datenow & "' and branch_id = '" & branch_id & "' and teller ='X' ")

                While SQLdr.Read
                    Label3.Text = SQLdr("number")
                    lbltype.Text = SQLdr("type")
                    Exit While
                End While

                SQLClose()
            End If
            '=======================================================END OF WITH PRIORTIY
        Else


            SQLConnectionString()
            SQLOpen()
            SQLQuery("select * from current where status = 'NEW' and date_print ='" & datenow & "' and branch_id = '" & branch_id & "' and teller ='X' ")


            While SQLdr.Read
                tellercapacity = tellercapacity + 1
            End While

            currentcapacity = tellercapacity
            SQLClose()



            If tellercapacity = 0 Then

                SQLConnectionString()
                SQLOpen()
                SQLQuery("select * from indexcount where date='" & datenow & "' and branch_id='" & branch_id & "'")
                If SQLdr.HasRows = False Then
                    SQLClose()
                    SQLConnectionString()
                    SQLOpen()
                    SQLQuery("insert into indexcount (indexcount,indexcountwp,date,branch_id) values ('0','0',NOW(),'" & branch_id & "')")
                    SQLClose()
                Else
                    While SQLdr.Read
                        count = SQLdr("indexcount")
                    End While
                    SQLClose()
                End If


                SQLConnectionString()
                SQLOpen()
                SQLQuery("select * from current where status = 'NOT' and date_print ='" & datenow & "' and branch_id = '" & branch_id & "' and teller ='X' ")

                While SQLdr.Read
                    tellercapacity = tellercapacity + 1
                End While

                SQLClose()

                If count = tellercapacity Then
                    count = 0
                    SQLConnectionString()
                    SQLOpen()
                    SQLQuery("update indexcount set indexcount='" & count & "' where  date='" & datenow & "' and branch_id='" & branch_id & "'")
                    SQLClose()
                End If

                SQLConnectionString()
                SQLOpen()
                SQLQuery("select * from current where status = 'NOT' and date_print ='" & datenow & "' and branch_id = '" & branch_id & "' and teller ='X' ")

                If SQLdr.HasRows = False Then
                    MsgBox("Empty Queue", vbInformation, "")
                    Label3.Text = ""
                    lbltype.Text = "-"
                    btnserved.Enabled = False
                    btnBeep.Enabled = False
                Else
                    Dim temp As Integer = 0
                    Dim temp2 As Integer = 0
                    While SQLdr.Read
                        Label3.Text = SQLdr("number")
                        lbltype.Text = SQLdr("type")
                        If temp = count Then
                            count = count + 1
                            SQLConnectionString()
                            SQLOpen()
                            SQLQuery("update indexcount set indexcount='" & count & "' where date='" & datenow & "' and branch_id='" & branch_id & "'")
                            'SQLClose()
                            'Exit While
                        End If
                        temp = temp + 1
                    End While
                    SQLClose()

                    temp = 0


                    SQLClose()
                    btnserved.Enabled = True
                    btnBeep.Enabled = True
                End If


            Else
                SQLConnectionString()
                SQLOpen()
                SQLQuery("select * from current where status = 'NEW' and date_print ='" & datenow & "' and branch_id = '" & branch_id & "' and teller ='X' ")

                While SQLdr.Read
                    Label3.Text = SQLdr("number")
                    lbltype.Text = SQLdr("type")
                    Exit While
                End While

                SQLClose()
            End If

        End If

        SQLConnectionString()
        SQLOpen()
        SQLQuery("update user set current_number='" & Label3.Text & "' , isNext ='T' where username='" & Form2.txtUsername.Text & "' and isActive='T' and branch_id='" & branch_id & "'")
        SQLClose()

        SQLConnectionString()
        SQLOpen()
        SQLQuery("update current set teller='" & Form2.txtUsername.Text & "' where number='" & Label3.Text & "' and date_print ='" & datenow & "' and branch_id='" & branch_id & "'")
        SQLClose()

        btnNext.Enabled = False

        Timer2.Start()
    End Sub

    Private Sub btnBeep_Click(sender As Object, e As EventArgs) Handles btnBeep.Click
        btnBeep.Enabled = False
        SQLConn.Open()

        SQLcmd.Connection = SQLConn
        SQLcmd.CommandText = "update user set isBeep = 'T' where username = '" & Form2.txtUsername.Text & "' and branch_id='" & branch_id & "'"

        SQLdr = SQLcmd.ExecuteReader()

        SQLdr.Close()
        SQLConn.Close()
        Timer3.Start()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 'Me.Left = My.Computer.Screen.WorkingArea.Width
        ' 'Me.Top = My.Computer.Screen.WorkingArea.Width - 745
        ' 'Me.Left = My.Computer.Screen.WorkingArea.Width - 370
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
        lbldatenow.Text = Date.Now.ToShortDateString

        SQLConnectionString()
        SQLOpen()
        SQLQuery("select * from user where username='" & Form2.txtUsername.Text & "' and branch_id='" & branch_id & "'")

        If SQLdr.HasRows = True Then
            While SQLdr.Read
                Label3.Text = Convert.ToString(SQLdr("current_number"))
                'lbltype.Text = Convert.ToString(SQLdr("type"))
                Exit While
            End While
        End If
        SQLClose()


        Timer1.Start()
        Timer4.Start()

    End Sub

  


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

       

        ' SQLConn.ConnectionString = connection

        If MsgBox("Are you sure to Logout?", vbYesNo, "Logout") = MsgBoxResult.Yes Then
            ' SQLConnectionString()
            ' SQLOpen()
            '  SQLQuery("update indexcount set indexcount='0',indexcountwp='0' where  username='" & Form2.txtUsername.Text & "' and branch_id='" & branch_id & "'")
            ' SQLClose()

            SQLcmd.Connection = SQLConn
            SQLConn.Open()

            SQLcmd.Connection = SQLConn
            SQLcmd.CommandText = "select * from user where username = '" & Form2.txtUsername.Text & "' and branch_id='" & branch_id & "'"
            SQLdr = SQLcmd.ExecuteReader()


            While SQLdr.Read()


                'Form2.Show()

                SQLdr.Close()
                SQLConn.Close()

                SQLcmd.Connection = SQLConn
                SQLConn.Open()
                SQLcmd.CommandText = "update user set isActive ='F' where username = '" & Form2.txtUsername.Text & "' and branch_id='" & branch_id & "'"
                SQLdr = SQLcmd.ExecuteReader()
                SQLdr.Close()
                SQLConn.Close()


                SQLConnectionString()
                SQLOpen()
                SQLQuery("update current set teller = 'X' where number='" & Label3.Text & "' and status='NOT' and date_print ='" & datenow & "' and branch_id='" & branch_id & "'")
                SQLClose()

                SQLConnectionString()
                SQLOpen()
                SQLQuery("update current set teller = 'X' where number='" & Label3.Text & "' and status='NEW' and date_print ='" & datenow & "' and branch_id='" & branch_id & "'")
                SQLClose()

                Label3.Text = ""
                lbltype.Text = "-"

                Me.Close()
                Form2.txtUsername.Clear()
                Form2.txtPassword.Clear()
                Form2.Show()
                Exit Sub
            End While
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SQLdr.Close()
        SQLConn.Close()
        SQLConn.Open()

        SQLcmd.Connection = SQLConn
        SQLcmd.CommandText = "select * from current where type = 'senior' and status !='OK' and date_print ='" & datenow & "' and branch_id = '" & branch_id & "'"
        SQLdr = SQLcmd.ExecuteReader()
        lstPriority.Items.Clear()
        While SQLdr.Read()
            lstPriority.Items.Add(SQLdr("number").ToString())
        End While
        SQLdr.Close()
        SQLConn.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            MsgBox("Senior Priority set", MsgBoxStyle.Information, "High Priority")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = True

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtOld.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Visible = False
    End Sub
    Dim counter As Integer = 4
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        If counter = 0 Then
            btnNext.Enabled = True

            counter = 4
            btnNext.Text = "Next"
            Timer2.Stop()
            Exit Sub
        End If
        counter = counter - 1
        btnNext.Text = "Next(" & counter & ")"
        btnNext.Enabled = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Dim counter2 As Integer = 1
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If counter2 = 0 Then
            btnBeep.Enabled = True
            counter2 = 1
            btnBeep.Text = "Call"
            Timer3.Stop()
            Exit Sub
        End If
        counter2 = counter2 - 1
        btnBeep.Text = "Call(" & counter2 & ")"
        btnBeep.Enabled = False

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        SQLConnectionString()
        SQLOpen()
        SQLQuery("select * from user where username ='" & Form2.txtUsername.Text & "' and isActive='F' and branch_id='" & branch_id & "'")
        While SQLdr.Read
            Timer4.Stop()
            SQLClose()
            MsgBox("Session Expired", vbInformation, "Expired")
            SQLcmd.Connection = SQLConn
            SQLConn.Open()

            SQLcmd.Connection = SQLConn
            SQLcmd.CommandText = "select * from user where username = '" & Form2.txtUsername.Text & "' and branch_id='" & branch_id & "'"
            SQLdr = SQLcmd.ExecuteReader()


            While SQLdr.Read()


                'Form2.Show()

                SQLdr.Close()
                SQLConn.Close()

                SQLcmd.Connection = SQLConn
                SQLConn.Open()
                SQLcmd.CommandText = "update user set isActive ='F' , current_number = NULL where username = '" & Form2.txtUsername.Text & "' and branch_id='" & branch_id & "'"
                SQLdr = SQLcmd.ExecuteReader()
                SQLdr.Close()
                SQLConn.Close()

                Me.Hide()
                Form2.txtUsername.Clear()
                Form2.txtPassword.Clear()
                Form2.Show()
                Exit Sub
            End While
            Exit Sub
        End While
        SQLClose()
    End Sub

    Private Sub Label3_TextChanged(sender As Object, e As EventArgs) Handles Label3.TextChanged
        If Label3.Text = "" Then
            btnBeep.Enabled = False
            btnserved.Enabled = False
        Else
            btnBeep.Enabled = True
            btnserved.Enabled = True
        End If

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        ' SQLConnectionString()
        'SQLOpen()
        'SQLQuery("select * from current")

    End Sub

    Private Sub lstPriority_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPriority.SelectedIndexChanged

    End Sub
End Class
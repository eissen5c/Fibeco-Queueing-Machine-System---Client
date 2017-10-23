Public Class setBranchvb

    Private Sub setBranchvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLConnectionString()
        SQLOpen()
        SQLQuery("select * from branch")
        ComboBox1.Items.Clear()
        While SQLdr.Read
            ComboBox1.Items.Add(SQLdr("branch_name"))
        End While

        SQLClose()

        ComboBox1.Text = My.Settings.branch

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ComboBox1.Text = "" Then
            My.Settings.branch = ComboBox1.Text
            My.Settings.Save()
            Me.Hide()
           
            Form2.Show()
            SQLConnectionString()
            SQLOpen()
            SQLQuery("select * from branch where branch_name ='" & ComboBox1.Text & "'")
            While SQLdr.Read
                branch_id = SQLdr("branch_id")
            End While
            SQLClose()

        Else
            MsgBox("set Branch first", vbCritical, "Required")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class
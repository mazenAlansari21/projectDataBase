Imports System.Data.SqlClient
Public Class Form1
    Dim sqlcon As New SqlConnection("data source=DESKTOP-P49SO4E; initial catalog=sakniH; integrated security=true")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles enterButt.Click
        sqlcon.Open()

        Dim query As String = "select * from student where userName='" & userName.Text & "' and password_student='" & Password.Text & "'"
        Dim cmd As New SqlCommand(query, sqlcon)


        Dim reader As SqlDataReader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            MsgBox("logged in has been succeed", MsgBoxStyle.Information, "log in ")
            Form2.Show()



        Else
            MsgBox("user name or password is not correct ", MsgBoxStyle.Exclamation, "log in ")

        End If
        reader.Close()
        sqlcon.Close()

    End Sub

    Private Sub cancelButt_Click(sender As Object, e As EventArgs) Handles cancelButt.Click
        Me.Close()

    End Sub
End Class

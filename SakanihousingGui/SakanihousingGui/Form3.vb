Imports System.Data.SqlClient
Public Class Form3
    Dim myconnection As New SqlConnection("data source=DESKTOP-P49SO4E; initial catalog=sakniH; integrated security=true")
    Dim query As String

    Dim mycommand As SqlCommand

    Dim dr As SqlDataReader

    Dim dr1 As SqlDataReader

    Dim ra As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SakniHDataSet1.Room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter1.Fill(Me.SakniHDataSet1.Room)
        'TODO: This line of code loads data into the 'SakniHDataSet.RequestOfstudent' table. You can move, or remove it, as needed.
        Me.RequestOfstudentTableAdapter.Fill(Me.SakniHDataSet.RequestOfstudent)
        'TODO: This line of code loads data into the 'SakniHDataSet.student' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'SakniHDataSet.Room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me.SakniHDataSet.Room)


    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1_.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim count As Integer = 1
        myconnection.Open()
        mycommand = New SqlCommand("insert into requestOfstudent([academicNumber],[requestNum]) values ('" & TextBox1_.Text & "','" & count & "')", myconnection)

        mycommand.ExecuteNonQuery()

        MessageBox.Show("request submeted" & ra)

        myconnection.Close()
        count = count + 1


    End Sub
End Class
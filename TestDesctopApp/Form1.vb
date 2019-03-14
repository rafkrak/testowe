Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Optyk2DataSet.DICT_lokalizacje' table. You can move, or remove it, as needed.
        Me.DICT_lokalizacjeTableAdapter.Fill(Me.Optyk2DataSet.DICT_lokalizacje)

    End Sub

    Public Sub pierwsza_funkcja()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = pobierzSkalar("select placowka from [dbo].[main_placowki]  where id_placowki = 1")
    End Sub

    Public Function namiarySQL() As String

        namiarySQL = "Server=localhost\MSSQL2012;Initial Catalog=luxplacowki;Persist Security Info=True;User ID=placowkiAPP;Password=luxmed2019#"

    End Function

    Public Sub wykonaj_sql(ByVal sql_command As String)

        Dim Polecenie As New SqlCommand
        Dim SQLConn As New SqlConnection
        Dim cmd As String

        SQLConn.ConnectionString = namiarySQL()
        SQLConn.Open()
        Polecenie.Connection = SQLConn
        Polecenie.CommandType = CommandType.Text
        cmd = sql_command
        Polecenie.CommandText = cmd
        Polecenie.ExecuteNonQuery()
        SQLConn.Close()

    End Sub

    Public Function pobierzSkalar(ByVal sql_command As String) As String

        Dim Polecenie As New SqlCommand
        Dim SQLConn As New SqlConnection
        Dim cmd As String

        SQLConn.ConnectionString = namiarySQL()
        SQLConn.Open()
        Polecenie.Connection = SQLConn
        Polecenie.CommandType = CommandType.Text
        cmd = sql_command
        Polecenie.CommandText = cmd

        Dim returnValue As String = Polecenie.ExecuteScalar()
        SQLConn.Close()
        Return returnValue

    End Function


End Class

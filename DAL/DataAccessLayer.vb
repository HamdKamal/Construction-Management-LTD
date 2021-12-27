Imports System.Data.SqlClient
Imports System.Data
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System

Namespace Constraction_Management_Co.DAL

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")>
    Public Class DataAccessLayer
        ' methode connection to database
        ' Dim mode As String

        Public sqlconn As SqlConnection = New SqlConnection("server= " & My.Settings.Server & ";Database=" & My.Settings.DataBase & ";Integrated Security=True")

        ' method to open connection
        Public Sub open()
            If sqlconn.State <> ConnectionState.Open Then
                sqlconn.Open()
            End If
            '  
        End Sub

        ' method to close connection
        Public Sub close()
            If sqlconn.State <> ConnectionState.Closed Then
                sqlconn.Close()
            End If
            '
        End Sub

        'method to read data from database "select data"
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")>
        Public Function selectData(ByVal stored_procedure As String, ByVal param As SqlParameter()) As DataTable
            Dim sqlcmd As SqlCommand = New SqlCommand()
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.CommandText = stored_procedure
            sqlcmd.Connection = sqlconn

            If param IsNot Nothing Then
                For i As Integer = 0 To param.Length - 1
                    sqlcmd.Parameters.Add(param(i))
                Next
            End If
            Dim da As SqlDataAdapter
            da = New SqlDataAdapter(sqlcmd)
            Dim dt As DataTable = New DataTable()
            da.Fill(dt)
            Return dt
        End Function

        ' procuder to insert ,update and delete data form database
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")>
        Public Sub ExecuteCommand(ByVal stored_procedure As String, ByVal param As SqlParameter())
            Try
                Dim sqlcmd As SqlCommand = New SqlCommand()
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = stored_procedure
                sqlcmd.Connection = sqlconn

                If param IsNot Nothing Then
                    sqlcmd.Parameters.AddRange(param)
                End If

                sqlcmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Sub setx()
            My.Settings.Server = ""
            My.Settings.DataBase = "construction"
            My.Settings.Mode = "Windows"
            My.Settings.Counter = 0
        End Sub

    End Class
End Namespace
Imports System.Data.SqlClient

Module Mod_DAL
    Public con As SqlConnection = Nothing
    Public cmd, cmd1 As SqlCommand
    Public rdr As SqlDataReader = Nothing
    Public ds As DataSet
    Public adp As SqlDataAdapter
    Public dtable As DataTable
    Public st As String
    Dim e As Object
    Sub JustNumber(ByVal r As System.Windows.Forms.KeyPressEventArgs)

        If Not Char.IsDigit(r.KeyChar) Then
            If Not Char.IsControl(r.KeyChar) Then
                If Not Char.IsPunctuation(r.KeyChar) Then
                    If Not Char.IsWhiteSpace(r.KeyChar) Then
                        If Not Char.IsSeparator(r.KeyChar) Then
                            r.Handled = True
                        End If
                    End If
                End If
            End If

        End If

    End Sub
End Module

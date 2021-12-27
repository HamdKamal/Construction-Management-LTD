Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co
Imports System.Data.SqlClient

Public Class Reportin
    Dim B As New Constraction_Management_Co.CLS_login


    Private Sub Reportin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Reportin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub Reportin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub PrintPreviewBarItem26_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles PrintPreviewBarItem26.ItemClick
        Dispose()
    End Sub
End Class
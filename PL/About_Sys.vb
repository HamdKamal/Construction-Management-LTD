Public Class About_pro

    Private Sub bttnInfo_Click(sender As Object, e As EventArgs) Handles bttnInfo.Click
        MessageBox.Show("NOTE: This application was created by: SmartVision.IT Company." & vbLf & vbLf & "[ APPLICATION TOOLS USED: ]" & vbLf & vbLf & "Programming Language: VB.Net 2013" & vbLf & "Back End Database: MS Sql Server 2012 " & vbLf & "Graphics Designed: DEV Express 15.2.7" & vbLf & vbLf & "[ SVIT - Make Of High Quality Softwares. ]" & vbLf, "Short Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
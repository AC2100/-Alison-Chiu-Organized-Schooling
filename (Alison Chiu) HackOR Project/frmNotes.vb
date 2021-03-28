'Author:        Alison Chiu
'Purpose:       For schools to utilize to make their lives easier :)
'Hackathon:     HackOR

Public Class frmNotes
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim frmHomePage As New frmHome
        Hide()
        frmHomePage.ShowDialog()
    End Sub

    Private Sub btnSaveNotes_Click(sender As Object, e As EventArgs) Handles btnSaveNotes.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(txtSaveFilePath.Text, False)
        file.WriteLine(txtNotes.Text)
        file.Close()
    End Sub
End Class
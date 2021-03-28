'Author:        Alison Chiu
'Purpose:       For schools to utilize to make their lives easier :)
'Hackathon:     HackOR

Public Class frmAddNewGrades
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim frmHomePage As New frmHome
        Hide()
        frmHomePage.ShowDialog()
    End Sub
End Class
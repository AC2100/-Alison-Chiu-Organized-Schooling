'Author:        Alison Chiu
'Purpose:       For schools to utilize to make their lives easier :)
'Hackathon:     HackOR

Public Class frmStudentGrade
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim frmHomePage As New frmHome
        Hide()
        frmHomePage.ShowDialog()
    End Sub

    Private Sub frmStudentGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intCount = 0 To frmUpload._intSizeOfClass
            If frmUpload._strClassNames(intCount) = frmSelectStudent.strSelectedStudent Then
                lblTitle.Text = frmSelectStudent.strSelectedStudent
                lblMissing.Text = frmUpload._strClassMissingAssign(intCount)
                lblScore.Text = frmUpload._intClassGrades(intCount).ToString()
            End If
        Next

    End Sub
End Class
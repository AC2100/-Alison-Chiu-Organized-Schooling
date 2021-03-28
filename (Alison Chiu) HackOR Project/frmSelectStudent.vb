'Author:        Alison Chiu
'Purpose:       For schools to utilize to make their lives easier :)
'Hackathon:     HackOR

Public Class frmSelectStudent

    Public strSelectedStudent As String

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim frmHomePage As New frmHome
        Hide()
        frmHomePage.ShowDialog()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim frmIndividualStudent As New frmStudentGrade
        Hide()
        frmIndividualStudent.ShowDialog()
    End Sub

    Private Sub frmSelectStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intCount = 0 To frmUpload._intSizeOfClass
            cboStudents.Items.Add(frmClassGrades.frmUploadFile._strClassNames(intCount))
            strSelectedStudent = cboStudents.SelectedItem
        Next
    End Sub

End Class
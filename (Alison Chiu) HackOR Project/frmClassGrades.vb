'Author:        Alison Chiu
'Purpose:       For schools to utilize to make their lives easier :)
'Hackathon:     HackOR


Public Class frmClassGrades
    Public frmUploadFile As New frmUpload
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        'Dim frmUploadFile As New frmUpload
        Hide()
        frmUploadFile.ShowDialog()
    End Sub

    Private Sub btnAddScore_Click(sender As Object, e As EventArgs)
        Dim frmAddScore As New frmAddNewGrades
        Hide()
        frmAddScore.ShowDialog()
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim frmAddStud As New frmAddNewStudent
        Hide()
        frmAddStud.ShowDialog()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim frmHomeForm As New frmHome
        Hide()
        frmHomeForm.ShowDialog()
    End Sub

    Private Sub frmClassGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If frmUpload.boolIsThereAFileUploaded = True Then
            lblHighest.Text = frmUpload.intGreatestScore.ToString()
            lblLowest.Text = frmUpload.intLowestScore.ToString()
            lblClassSize.Text = frmUpload._intNumberOfStudents.ToString()
            lblAverage.Text = frmUpload.decClassAverage.ToString()
            lblMissingAssignments.Text = frmUpload.intNumberOfMissingAssignments.ToString()

            lblHighest.Visible = True
            lblLowest.Visible = True
            lblClassSize.Visible = True
            lblAverage.Visible = True

            chart.Series("Class Scores").Points.AddXY("3", 8)

        End If

    End Sub
    Public frmViewStudent As New frmSelectStudent
    Private Sub btnViewStudent_Click(sender As Object, e As EventArgs) Handles btnViewStudent.Click
        'Dim frmViewStudent As New frmSelectStudent
        Hide()
        frmViewStudent.ShowDialog()
    End Sub

End Class
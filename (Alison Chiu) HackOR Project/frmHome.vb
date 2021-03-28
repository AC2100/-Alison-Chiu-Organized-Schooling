'Author:        Alison Chiu
'Purpose:       For schools to utilize to make their lives easier :)
'Hackathon:     HackOR


Public Class frmHome

    Public frmBookBrowserForm As New frmBookBrowser

    Private Sub picBookBroswer_Click(sender As Object, e As EventArgs) Handles picBookBroswer.Click
        'Make an instance of Book Broswer
        'Dim frmBookBrowserForm As New frmBookBrowser

        'Hide this form, and show the Book Broswer
        Hide()
        frmBookBrowserForm.ShowDialog()
    End Sub

    Private Sub picClassGradesViewer_Click(sender As Object, e As EventArgs) Handles picClassGradesViewer.Click
        'Make an instance of Class Grades
        Dim frmClassGrades As New frmClassGrades

        'Hide this form, and show the Class Grades
        Hide()
        frmClassGrades.ShowDialog()
    End Sub

    Private Sub picIndividualBookInformation_click(sender As Object, e As EventArgs) Handles picIndividualBookInformation.Click
        'Make an instance of Individual Grades
        Dim frmIndividualBookInformation As New frmIndividualBookInformation

        'Hide this form, and show the Individual Grades
        Hide()
        frmIndividualBookInformation.ShowDialog()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'Make an instance of Individual Grades
        Dim frmHelpPage As New frmHelpPage

        'Hide this form, and show the Individual Grades
        Hide()
        frmHelpPage.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub picNotes_Click(sender As Object, e As EventArgs) Handles picNotes.Click
        Dim frmNotesPage As New frmNotes
        Hide()
        frmNotesPage.ShowDialog()
    End Sub

End Class

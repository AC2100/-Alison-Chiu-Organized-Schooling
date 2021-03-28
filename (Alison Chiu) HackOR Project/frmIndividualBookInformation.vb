'Author:        Alison Chiu
'Purpose:       For schools to utilize to make their lives easier :)
'Hackathon:     HackOR

Public Class frmIndividualBookInformation

    Private Sub IndividualBookInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
        Dim strSpecialBook As String
        Dim intSpecialChosenIndex As Integer
        Dim strFilePath = "C:\users\girl4\Desktop\" + frmBookBrowser._strImagePath(intSpecialChosenIndex)

        'Change the name property of the form depending on the book that is displayed pls
        Me.Text = frmBookBrowser.strSelectedBookName

        'Change da labels

        If frmHome.frmBookBrowserForm.strSelectedBookName <> "" Then
            lblTitle.Text = frmHome.frmBookBrowserForm.strSelectedBookName
            lblBookTitle.Text = frmHome.frmBookBrowserForm.strSelectedBookName
            lblAuthorName.Text = frmHome.frmBookBrowserForm.strSelectedAuthor
            lblBookGenre.Text = frmHome.frmBookBrowserForm.strSelectedGenre
            lblPublicationYear.Text = frmHome.frmBookBrowserForm.strSelectedPublicationYear
            lblBookDescription.Text = frmHome.frmBookBrowserForm.strSelectedDescritpion
            lblAgeRange.Text = frmHome.frmBookBrowserForm.strSelectedAgeRange

            'picBookCover.Image = Image.FromFile(frmBookBrowser.strSelectedImage)
        Else

            'maybe therell be a search function fro students to help practice or quick access their books if they need to
            'then we'd add another if block that tested if the user already upload a file with the book ifnromation
            'if not, we'll send them to the book broswer
            'if so, we'll execute the code down below 

            'If (frmBookBrowser.boolIsThereAFileUploaded = True) Or (frmAddNewBook.frmBookSecond._strBookNames(0) <> Nothing) Then
            If (frmBookBrowser.boolIsThereAFileUploaded = True) Then
                strSpecialBook = InputBox("Please type in the book you would like information on: ", "Book Prompt")
                If strSpecialBook <> "" Then
                    Dim boolFoundBook As Boolean
                    For intCounting = 0 To (frmBookBrowser._strBookNames.Length - 1)
                        If frmBookBrowser._strBookNames(intCounting) = strSpecialBook Then
                            intSpecialChosenIndex = intCounting

                            lblTitle.Text = frmBookBrowser._strBookNames(intSpecialChosenIndex)
                            lblAuthorName.Text = frmBookBrowser._strAuthor(intSpecialChosenIndex)
                            lblBookGenre.Text = frmBookBrowser._strGenre(intSpecialChosenIndex)
                            lblAgeRange.Text = frmBookBrowser._strAgeRange(intSpecialChosenIndex)
                            lblBookDescription.Text = frmBookBrowser._strDescription(intSpecialChosenIndex)
                            lblPublicationYear.Text = frmBookBrowser._strPublicationYear(intSpecialChosenIndex)

                            'picBookCover.Image = Image.FromFile(strFilePath)
                            boolFoundBook = True
                            Me.Visible = True
                            Exit For
                        End If
                        'MsgBox("Sorry, we couldn't find your book. Please double check your spelling, and ensure that your school/library has this title.",, "Error")
                        boolFoundBook = False
                    Next

                    If boolFoundBook = False Then
                        MsgBox("Sorry, we couldn't find your book. Please double check your spelling, and ensure that your school/library has this title.",, "Error")
                    End If
                Else
                    MsgBox("Please type something into the Input Box.",, "error")
                End If
            Else
                'MsgBox("There was no file uploaded, please upload a file before searching for a book.",, "error")

                'Make an instance of Book Browser
                Dim frmBook As New frmBookBrowser

                'Hide this form, and show the Book Browser
                Hide()
                frmBook.ShowDialog()

            End If

        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        'Make an instance of Home
        Dim frmHome As New frmHome

        'Hide this form, and show the Home
        Hide()
        frmHome.ShowDialog()
    End Sub

End Class
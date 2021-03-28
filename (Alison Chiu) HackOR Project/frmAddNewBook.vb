'Author:        Alison Chiu
'Purpose:       For schools to utilize to make their lives easier :)
'Hackathon:     HackOR

Public Class frmAddNewBook
    Public frmBookSecond As New frmBookBrowser

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Dim strFilePath = "C:\users\girl4\Desktop\" + txtImage.Text
        Dim strFile As System.IO.StreamWriter

        'If (txtTitle.Text = "") Or (txtAuthor.Text = "") Or (txtGenre.Text = "") Or (txtAgeRange.Text = "") Or (txtDescription.Text = "") Or (txtImage.Text = "") Or (txtPublicationYear.Text = "") Then
        If (txtTitle.Text = "") Or (txtAuthor.Text = "") Or (txtGenre.Text = "") Or (txtAgeRange.Text = "") Or (txtDescription.Text = "") Or (txtPublicationYear.Text = "") Then
            MsgBox("One of the textboxes is empty, please double check them :)",, "Error")

        Else

            'Make an instance of Book Broswer
            Dim frmBook As New frmBookBrowser

            ReDim Preserve frmHome.frmBookBrowserForm._strBookNames(frmHome.frmBookBrowserForm._intSizeOfArray)
            frmHome.frmBookBrowserForm._strBookNames(frmHome.frmBookBrowserForm._intSizeOfArray) = txtTitle.Text

            ReDim Preserve frmHome.frmBookBrowserForm._strAuthor(frmHome.frmBookBrowserForm._intSizeOfArray)
            frmHome.frmBookBrowserForm._strAuthor(frmHome.frmBookBrowserForm._intSizeOfArray) = txtAuthor.Text

            ReDim Preserve frmHome.frmBookBrowserForm._strGenre(frmHome.frmBookBrowserForm._intSizeOfArray)
            frmHome.frmBookBrowserForm._strGenre(frmHome.frmBookBrowserForm._intSizeOfArray) = txtGenre.Text

            ReDim Preserve frmHome.frmBookBrowserForm._strAgeRange(frmHome.frmBookBrowserForm._intSizeOfArray)
            frmHome.frmBookBrowserForm._strAgeRange(frmHome.frmBookBrowserForm._intSizeOfArray) = txtAgeRange.Text

            'ReDim Preserve frmBook._strImagePath(frmBookBrowser._intSizeOfArray)
            'frmBook._strImagePath(frmBook._intSizeOfArray) = strFilePath

            ReDim Preserve frmHome.frmBookBrowserForm._strDescription(frmHome.frmBookBrowserForm._intSizeOfArray)
            frmHome.frmBookBrowserForm._strDescription(frmHome.frmBookBrowserForm._intSizeOfArray) = txtDescription.Text

            ReDim Preserve frmHome.frmBookBrowserForm._strPublicationYear(frmHome.frmBookBrowserForm._intSizeOfArray)
            frmHome.frmBookBrowserForm._strPublicationYear(frmHome.frmBookBrowserForm._intSizeOfArray) = txtPublicationYear.Text

            frmHome.frmBookBrowserForm.cboBookList.Items.Add(txtTitle.Text)

            If frmHome.frmBookBrowserForm.strLocationOfFile Is Nothing Then

            Else
                strFile = My.Computer.FileSystem.OpenTextFileWriter(frmBookBrowser.strLocationOfFile, True)
                strFile.WriteLine(txtTitle.Text)
                strFile.WriteLine(txtAuthor.Text)
                strFile.WriteLine(txtGenre.Text)
                strFile.WriteLine(txtPublicationYear.Text)
                strFile.WriteLine(txtAgeRange.Text)
                strFile.WriteLine(txtDescription.Text)
                'strFile.WriteLine(txtImage.Text)

                strFile.Close()
            End If

            Hide()
            frmHome.frmBookBrowserForm.cboBookList.Items.Add(txtTitle.Text)
            'frmHome.frmBookBrowserForm.ShowDialog()
            frmHome.frmBookBrowserForm.Visible = True

            'frmBookSecond = frmBook

        End If

        'please find a way to use streamwriter to actually write to he file and append the new info



    End Sub

End Class
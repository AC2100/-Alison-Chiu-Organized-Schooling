'Author:        Alison Chiu
'Purpose:       For schools to utilize to make their lives easier :)
'Hackathon:     HackOR

Public Class frmBookBrowser

    Public _intSizeOfArray As Integer = 9
    Public boolIsThereAFileUploaded As Boolean = False

    Public _strBookNames(_intSizeOfArray) As String
    Public _strAuthor(_intSizeOfArray) As String
    Public _strGenre(_intSizeOfArray) As String
    Public _strAgeRange(_intSizeOfArray) As String
    Public _strPublicationYear(_intSizeOfArray) As String
    Public _strDescription(_intSizeOfArray) As String
    Public _strImagePath(_intSizeOfArray) As String
    Public strLocationOfFile As String

    Public strSelectedBookName As String
    Public strSelectedAuthor As String
    Public strSelectedGenre As String
    Public strSelectedAgeRange As String
    Public strSelectedPublicationYear As String
    Public strSelectedDescritpion As String
    Public strSelectedImage As String

    Public intChosenIndex As Integer

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim objReader As IO.StreamReader
        Dim intCount As Integer = 0

        If txtFilePath.Text = "" Then
            MsgBox("Please enter a file path",, "Error")
        Else
            Dim strLocationAndNameOfFile As String = "C:\Users\girl4\Desktop\" + txtFilePath.Text
            strLocationOfFile = strLocationAndNameOfFile
            boolIsThereAFileUploaded = True
            If IO.File.Exists(strLocationAndNameOfFile) Then
                objReader = IO.File.OpenText(strLocationAndNameOfFile)
                Do While objReader.Peek <> -1
                    _strBookNames(intCount) = objReader.ReadLine
                    _strAuthor(intCount) = objReader.ReadLine
                    _strGenre(intCount) = objReader.ReadLine
                    _strAgeRange(intCount) = objReader.ReadLine
                    _strPublicationYear(intCount) = objReader.ReadLine
                    _strDescription(intCount) = objReader.ReadLine
                    '_strImagePath(intCount) = objReader.ReadLine
                    intCount += 1
                Loop
                objReader.Close()

                For intFill = 0 To (_strBookNames.Length - 1)
                    cboBookList.Items.Add(_strBookNames(intFill))
                Next
            Else
                MsgBox("We couldn't find your file. Do include the extension.",, "Error")
            End If
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim intCounting As Integer

        strSelectedBookName = cboBookList.SelectedItem
        For intCounting = 0 To (_strBookNames.Length - 1)
            If _strBookNames(intCounting) = strSelectedBookName Then
                intChosenIndex = intCounting
            End If
        Next

        strSelectedBookName = _strBookNames(intChosenIndex)
        strSelectedAuthor = _strAuthor(intChosenIndex)
        strSelectedGenre = _strGenre(intChosenIndex)
        strSelectedAgeRange = _strAgeRange(intChosenIndex)
        strSelectedDescritpion = _strDescription(intChosenIndex)
        strSelectedPublicationYear = _strPublicationYear(intChosenIndex)
        strSelectedImage = _strImagePath(intChosenIndex)

        'Make an instance of Book Info
        Dim frmIndividualBookInformation As New frmIndividualBookInformation

        'Hide this form, and show the Book Info
        Hide()
        frmIndividualBookInformation.ShowDialog()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        'Make an instance of Home
        Dim frmHome As New frmHome

        'Hide this form, and show the Home
        Hide()
        Me.Visible = False
        frmHome.ShowDialog()
    End Sub

    Private Sub frmBookBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If boolIsThereAFileUploaded = True Then
            txtFilePath.Text = strLocationOfFile
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Make an instance of Add
        Dim frmAdd As New frmAddNewBook

        'Hide this form, and show the Home
        Hide()
        Me.Visible = False
        frmAdd.ShowDialog()
    End Sub
End Class
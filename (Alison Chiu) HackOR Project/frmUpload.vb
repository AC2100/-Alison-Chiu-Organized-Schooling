'Author:        Alison Chiu
'Purpose:       For schools to utilize to make their lives easier :)
'Hackathon:     HackOR

Public Class frmUpload

    Public _intSizeOfClass As Integer = 25
    Public _intNumberOfStudents As Integer = _intSizeOfClass + 1
    Public boolIsThereAFileUploaded As Boolean = False

    Public _strClassNames(_intSizeOfClass) As String
    Public _intClassGrades(_intSizeOfClass) As Integer
    Public _strClassMissingAssign(_intSizeOfClass) As String

    Public intGreatestScore As Integer = 0
    Public intLowestScore As Integer = 0

    Public decClassAverage As String

    Private intClassTotal As Integer
    Public intNumberOfMissingAssignments As Integer

    Public strLocationOfFile As String

    Public intChosenIndex As Integer

    'Public frmClassGradesForms As New frmClassGrades

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click

        Dim objReader As IO.StreamReader
        Dim intCount As Integer = 0

        If txtFilePath.Text = "" Then
            MsgBox("Please enter a file name",, "Error")
        Else
            Dim strLocationAndNameOfFile As String = "C:\Users\girl4\Desktop\" + txtFilePath.Text
            strLocationOfFile = strLocationAndNameOfFile
            boolIsThereAFileUploaded = True
            If IO.File.Exists(strLocationAndNameOfFile) Then
                objReader = IO.File.OpenText(strLocationAndNameOfFile)
                Do While objReader.Peek <> -1
                    _strClassNames(intCount) = objReader.ReadLine()
                    _intClassGrades(intCount) = Convert.ToInt32(objReader.ReadLine())
                    _strClassMissingAssign(intCount) = objReader.ReadLine()
                    intCount += 1
                    intClassTotal += _intClassGrades(intCount - 1)

                Loop
                objReader.Close()

                decClassAverage = Convert.ToDecimal(intClassTotal) / (_strClassNames.Length + 1)

                For intCounting = 0 To (_strClassNames.Length - 1)
                    If _intClassGrades(intCounting) > intGreatestScore Then
                        intGreatestScore = _intClassGrades(intCounting)

                        If _intClassGrades(intCounting) = 0 Then
                            intNumberOfMissingAssignments += 1
                        End If

                    End If
                Next

                For intCounting = 0 To (_strClassNames.Length - 1)
                    If _intClassGrades(intCounting) < intLowestScore Then
                        intLowestScore = _intClassGrades(intCounting)
                    End If
                Next
                boolIsThereAFileUploaded = True
            Else
                MsgBox("We couldn't find your file. Do include the extension.",, "Error")
            End If


            Dim frmClassGradesForms As New frmClassGrades

            frmClassGradesForms.lblHighest.Text = intGreatestScore.ToString()
            frmClassGradesForms.lblLowest.Text = intLowestScore.ToString()
            frmClassGradesForms.lblClassSize.Text = _intNumberOfStudents.ToString()
            frmClassGradesForms.lblAverage.Text = decClassAverage.ToString()
            frmClassGradesForms.lblMissingAssignments.Text = intNumberOfMissingAssignments.ToString()

            frmClassGradesForms.lblHighest.Visible = True
            frmClassGradesForms.lblLowest.Visible = True
            frmClassGradesForms.lblClassSize.Visible = True
            frmClassGradesForms.lblAverage.Visible = True
            frmClassGradesForms.lblMissingAssignments.Visible = True

            Hide()
            frmClassGradesForms.ShowDialog()

        End If

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim frmHomeForm As New frmHome
        Hide()
        frmHomeForm.ShowDialog()
    End Sub

End Class
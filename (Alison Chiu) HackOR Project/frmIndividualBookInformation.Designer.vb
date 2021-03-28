<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndividualBookInformation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mnuMenuBar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassGraphsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualGraphsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualGraphsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAuthorName = New System.Windows.Forms.Label()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.lblBookGenre = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBookDescription = New System.Windows.Forms.Label()
        Me.lblAgeRange = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPublicationYear = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.picBookCover = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnuMenuBar.SuspendLayout()
        CType(Me.picBookCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 54)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 54)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Genre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 54)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Author: "
        '
        'mnuMenuBar
        '
        Me.mnuMenuBar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuMenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuMenuBar.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuBar.Name = "mnuMenuBar"
        Me.mnuMenuBar.Size = New System.Drawing.Size(1278, 33)
        Me.mnuMenuBar.TabIndex = 10
        Me.mnuMenuBar.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ClassGraphsToolStripMenuItem, Me.IndividualGraphsToolStripMenuItem, Me.IndividualGraphsToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(234, 30)
        Me.ToolStripMenuItem2.Text = "&Home"
        '
        'ClassGraphsToolStripMenuItem
        '
        Me.ClassGraphsToolStripMenuItem.Name = "ClassGraphsToolStripMenuItem"
        Me.ClassGraphsToolStripMenuItem.Size = New System.Drawing.Size(234, 30)
        Me.ClassGraphsToolStripMenuItem.Text = "&Book Broswers"
        '
        'IndividualGraphsToolStripMenuItem
        '
        Me.IndividualGraphsToolStripMenuItem.Name = "IndividualGraphsToolStripMenuItem"
        Me.IndividualGraphsToolStripMenuItem.Size = New System.Drawing.Size(234, 30)
        Me.IndividualGraphsToolStripMenuItem.Text = "&Class Grades"
        '
        'IndividualGraphsToolStripMenuItem1
        '
        Me.IndividualGraphsToolStripMenuItem1.Name = "IndividualGraphsToolStripMenuItem1"
        Me.IndividualGraphsToolStripMenuItem1.Size = New System.Drawing.Size(234, 30)
        Me.IndividualGraphsToolStripMenuItem1.Text = "&Individual Graphs"
        '
        'lblAuthorName
        '
        Me.lblAuthorName.AutoSize = True
        Me.lblAuthorName.Font = New System.Drawing.Font("Palatino Linotype", 15.0!)
        Me.lblAuthorName.Location = New System.Drawing.Point(296, 324)
        Me.lblAuthorName.Name = "lblAuthorName"
        Me.lblAuthorName.Size = New System.Drawing.Size(278, 41)
        Me.lblAuthorName.TabIndex = 11
        Me.lblAuthorName.Text = "AUTHOR'S NAME"
        '
        'lblBookTitle
        '
        Me.lblBookTitle.AutoSize = True
        Me.lblBookTitle.Font = New System.Drawing.Font("Palatino Linotype", 15.0!)
        Me.lblBookTitle.Location = New System.Drawing.Point(296, 246)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(199, 41)
        Me.lblBookTitle.TabIndex = 12
        Me.lblBookTitle.Text = "BOOK TITLE"
        '
        'lblBookGenre
        '
        Me.lblBookGenre.AutoSize = True
        Me.lblBookGenre.Font = New System.Drawing.Font("Palatino Linotype", 15.0!)
        Me.lblBookGenre.Location = New System.Drawing.Point(296, 408)
        Me.lblBookGenre.Name = "lblBookGenre"
        Me.lblBookGenre.Size = New System.Drawing.Size(218, 41)
        Me.lblBookGenre.TabIndex = 13
        Me.lblBookGenre.Text = "BOOK GENRE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 725)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 54)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Description:"
        '
        'lblBookDescription
        '
        Me.lblBookDescription.AutoSize = True
        Me.lblBookDescription.Font = New System.Drawing.Font("Palatino Linotype", 10.0!)
        Me.lblBookDescription.Location = New System.Drawing.Point(63, 801)
        Me.lblBookDescription.Name = "lblBookDescription"
        Me.lblBookDescription.Size = New System.Drawing.Size(214, 27)
        Me.lblBookDescription.TabIndex = 15
        Me.lblBookDescription.Text = "BOOK DESCRIPTION"
        '
        'lblAgeRange
        '
        Me.lblAgeRange.AutoSize = True
        Me.lblAgeRange.Font = New System.Drawing.Font("Palatino Linotype", 15.0!)
        Me.lblAgeRange.Location = New System.Drawing.Point(296, 503)
        Me.lblAgeRange.Name = "lblAgeRange"
        Me.lblAgeRange.Size = New System.Drawing.Size(199, 41)
        Me.lblAgeRange.TabIndex = 17
        Me.lblAgeRange.Text = "AGE RANGE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 490)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 54)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Age Range:"
        '
        'lblPublicationYear
        '
        Me.lblPublicationYear.AutoSize = True
        Me.lblPublicationYear.Font = New System.Drawing.Font("Palatino Linotype", 15.0!)
        Me.lblPublicationYear.Location = New System.Drawing.Point(296, 618)
        Me.lblPublicationYear.Name = "lblPublicationYear"
        Me.lblPublicationYear.Size = New System.Drawing.Size(299, 41)
        Me.lblPublicationYear.TabIndex = 19
        Me.lblPublicationYear.Text = "PUBICATION YEAR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 588)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(224, 108)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Publication" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Year:"
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnHome.Font = New System.Drawing.Font("Modern No. 20", 14.0!)
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(12, 873)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(123, 59)
        Me.btnHome.TabIndex = 29
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'picBookCover
        '
        Me.picBookCover.Image = Global._Alison_Chiu__HackOR_Project.My.Resources.Resources.Untitled_Artwork_2
        Me.picBookCover.Location = New System.Drawing.Point(698, 27)
        Me.picBookCover.Name = "picBookCover"
        Me.picBookCover.Size = New System.Drawing.Size(555, 437)
        Me.picBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBookCover.TabIndex = 5
        Me.picBookCover.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 40.0!)
        Me.lblTitle.Location = New System.Drawing.Point(208, 90)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(896, 83)
        Me.lblTitle.TabIndex = 30
        Me.lblTitle.Text = "TITLE PLACEHOLDER"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmIndividualBookInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 944)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblPublicationYear)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblAgeRange)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblBookDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblBookGenre)
        Me.Controls.Add(Me.lblBookTitle)
        Me.Controls.Add(Me.lblAuthorName)
        Me.Controls.Add(Me.mnuMenuBar)
        Me.Controls.Add(Me.picBookCover)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmIndividualBookInformation"
        Me.Text = "Book Info"
        Me.mnuMenuBar.ResumeLayout(False)
        Me.mnuMenuBar.PerformLayout()
        CType(Me.picBookCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents picBookCover As PictureBox
    Friend WithEvents mnuMenuBar As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ClassGraphsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndividualGraphsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndividualGraphsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lblAuthorName As Label
    Friend WithEvents lblBookTitle As Label
    Friend WithEvents lblBookGenre As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblBookDescription As Label
    Friend WithEvents lblAgeRange As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPublicationYear As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents lblTitle As Label
End Class

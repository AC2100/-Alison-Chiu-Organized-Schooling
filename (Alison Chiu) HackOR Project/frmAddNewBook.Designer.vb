<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewBook
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbel5 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtPublicationYear = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAgeRange = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(64, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 37)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Author: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(64, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 37)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Genre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(64, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Title:"
        '
        'lbel5
        '
        Me.lbel5.AutoSize = True
        Me.lbel5.Font = New System.Drawing.Font("Palatino Linotype", 14.0!)
        Me.lbel5.Location = New System.Drawing.Point(64, 437)
        Me.lbel5.Name = "lbel5"
        Me.lbel5.Size = New System.Drawing.Size(166, 37)
        Me.lbel5.TabIndex = 10
        Me.lbel5.Text = "Description:"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Palatino Linotype", 35.0!)
        Me.lbltitle.Location = New System.Drawing.Point(55, 41)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(577, 93)
        Me.lbltitle.TabIndex = 11
        Me.lbltitle.Text = "Add a New Book"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Modern No. 20", 13.0!)
        Me.txtTitle.Location = New System.Drawing.Point(303, 162)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(329, 35)
        Me.txtTitle.TabIndex = 12
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Modern No. 20", 13.0!)
        Me.txtAuthor.Location = New System.Drawing.Point(303, 218)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(329, 35)
        Me.txtAuthor.TabIndex = 13
        '
        'txtGenre
        '
        Me.txtGenre.Font = New System.Drawing.Font("Modern No. 20", 13.0!)
        Me.txtGenre.Location = New System.Drawing.Point(303, 270)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(329, 35)
        Me.txtGenre.TabIndex = 14
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Modern No. 20", 13.0!)
        Me.txtDescription.Location = New System.Drawing.Point(303, 437)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(329, 96)
        Me.txtDescription.TabIndex = 17
        Me.txtDescription.Text = ""
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEnter.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnter.Location = New System.Drawing.Point(252, 647)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(172, 59)
        Me.btnEnter.TabIndex = 20
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'txtPublicationYear
        '
        Me.txtPublicationYear.Font = New System.Drawing.Font("Modern No. 20", 13.0!)
        Me.txtPublicationYear.Location = New System.Drawing.Point(303, 324)
        Me.txtPublicationYear.Name = "txtPublicationYear"
        Me.txtPublicationYear.Size = New System.Drawing.Size(329, 35)
        Me.txtPublicationYear.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 14.0!)
        Me.Label6.Location = New System.Drawing.Point(64, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 37)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Publication Year:"
        '
        'txtAgeRange
        '
        Me.txtAgeRange.Font = New System.Drawing.Font("Modern No. 20", 13.0!)
        Me.txtAgeRange.Location = New System.Drawing.Point(303, 374)
        Me.txtAgeRange.Name = "txtAgeRange"
        Me.txtAgeRange.Size = New System.Drawing.Size(329, 35)
        Me.txtAgeRange.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 14.0!)
        Me.Label7.Location = New System.Drawing.Point(64, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 37)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Age Range:"
        '
        'frmAddNewBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(678, 744)
        Me.Controls.Add(Me.txtAgeRange)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPublicationYear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtGenre)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.lbel5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddNewBook"
        Me.Text = "Add a New Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbel5 As Label
    Friend WithEvents lbltitle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtPublicationYear As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAgeRange As TextBox
    Friend WithEvents Label7 As Label
End Class

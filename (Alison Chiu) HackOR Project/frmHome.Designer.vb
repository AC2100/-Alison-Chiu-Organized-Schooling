<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnuMenuBar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassGraphsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualGraphsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picNotes = New System.Windows.Forms.PictureBox()
        Me.picIndividualBookInformation = New System.Windows.Forms.PictureBox()
        Me.picClassGradesViewer = New System.Windows.Forms.PictureBox()
        Me.picBookBroswer = New System.Windows.Forms.PictureBox()
        Me.mnuMenuBar.SuspendLayout()
        CType(Me.picNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIndividualBookInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClassGradesViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBookBroswer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 50.0!)
        Me.lblTitle.Location = New System.Drawing.Point(225, 45)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(883, 103)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Organized Schooling"
        '
        'mnuMenuBar
        '
        Me.mnuMenuBar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuMenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuMenuBar.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuBar.Name = "mnuMenuBar"
        Me.mnuMenuBar.Size = New System.Drawing.Size(1278, 33)
        Me.mnuMenuBar.TabIndex = 9
        Me.mnuMenuBar.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ClassGraphsToolStripMenuItem, Me.IndividualGraphsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(234, 30)
        Me.ToolStripMenuItem2.Text = "&Book Broswers"
        '
        'ClassGraphsToolStripMenuItem
        '
        Me.ClassGraphsToolStripMenuItem.Name = "ClassGraphsToolStripMenuItem"
        Me.ClassGraphsToolStripMenuItem.Size = New System.Drawing.Size(234, 30)
        Me.ClassGraphsToolStripMenuItem.Text = "&Class Grades"
        '
        'IndividualGraphsToolStripMenuItem
        '
        Me.IndividualGraphsToolStripMenuItem.Name = "IndividualGraphsToolStripMenuItem"
        Me.IndividualGraphsToolStripMenuItem.Size = New System.Drawing.Size(234, 30)
        Me.IndividualGraphsToolStripMenuItem.Text = "&Individual Graphs"
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Modern No. 20", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(1161, 876)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(105, 56)
        Me.btnHelp.TabIndex = 10
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Modern No. 20", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(12, 876)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 56)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(297, 515)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 27)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Book Browser"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(882, 876)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 27)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Notes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(851, 515)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 27)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Class Grades"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(238, 867)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 27)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Individual Book Information"
        '
        'picNotes
        '
        Me.picNotes.Image = Global._Alison_Chiu__HackOR_Project.My.Resources.Resources.Notebook_jpg
        Me.picNotes.Location = New System.Drawing.Point(741, 568)
        Me.picNotes.Name = "picNotes"
        Me.picNotes.Size = New System.Drawing.Size(335, 283)
        Me.picNotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNotes.TabIndex = 8
        Me.picNotes.TabStop = False
        '
        'picIndividualBookInformation
        '
        Me.picIndividualBookInformation.Image = Global._Alison_Chiu__HackOR_Project.My.Resources.Resources.Book_jpg
        Me.picIndividualBookInformation.Location = New System.Drawing.Point(198, 568)
        Me.picIndividualBookInformation.Name = "picIndividualBookInformation"
        Me.picIndividualBookInformation.Size = New System.Drawing.Size(335, 283)
        Me.picIndividualBookInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIndividualBookInformation.TabIndex = 7
        Me.picIndividualBookInformation.TabStop = False
        '
        'picClassGradesViewer
        '
        Me.picClassGradesViewer.Image = Global._Alison_Chiu__HackOR_Project.My.Resources.Resources.Graph_jpg
        Me.picClassGradesViewer.Location = New System.Drawing.Point(741, 211)
        Me.picClassGradesViewer.Name = "picClassGradesViewer"
        Me.picClassGradesViewer.Size = New System.Drawing.Size(335, 283)
        Me.picClassGradesViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClassGradesViewer.TabIndex = 6
        Me.picClassGradesViewer.TabStop = False
        '
        'picBookBroswer
        '
        Me.picBookBroswer.Image = Global._Alison_Chiu__HackOR_Project.My.Resources.Resources.Bookshelves_jpg
        Me.picBookBroswer.Location = New System.Drawing.Point(198, 211)
        Me.picBookBroswer.Name = "picBookBroswer"
        Me.picBookBroswer.Size = New System.Drawing.Size(335, 283)
        Me.picBookBroswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBookBroswer.TabIndex = 5
        Me.picBookBroswer.TabStop = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 944)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.picNotes)
        Me.Controls.Add(Me.picIndividualBookInformation)
        Me.Controls.Add(Me.picClassGradesViewer)
        Me.Controls.Add(Me.picBookBroswer)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuMenuBar)
        Me.MainMenuStrip = Me.mnuMenuBar
        Me.Name = "frmHome"
        Me.Text = "Home"
        Me.mnuMenuBar.ResumeLayout(False)
        Me.mnuMenuBar.PerformLayout()
        CType(Me.picNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIndividualBookInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClassGradesViewer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBookBroswer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents picBookBroswer As PictureBox
    Friend WithEvents picClassGradesViewer As PictureBox
    Friend WithEvents picIndividualBookInformation As PictureBox
    Friend WithEvents picNotes As PictureBox
    Friend WithEvents mnuMenuBar As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ClassGraphsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndividualGraphsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class

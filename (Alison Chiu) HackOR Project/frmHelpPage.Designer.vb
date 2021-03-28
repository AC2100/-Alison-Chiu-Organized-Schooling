<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelpPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelpPage))
        Me.mnuMenuBar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassGraphsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualGraphsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mnuMenuBar.SuspendLayout()
        Me.SuspendLayout()
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 50.0!)
        Me.lblTitle.Location = New System.Drawing.Point(404, 51)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(470, 103)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Help Page"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(715, 532)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "bunch of text, dont forget an exit and home button pls :)"
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
        Me.btnHome.TabIndex = 30
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(38, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 41)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Book Broswer Help"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(40, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(617, 225)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(40, 532)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(617, 225)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(38, 487)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(299, 41)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Class Grade Help"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(672, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(594, 175)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 20.0!)
        Me.Label7.Location = New System.Drawing.Point(670, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(555, 41)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "The program can't find your file?"
        '
        'frmHelpPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 944)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuMenuBar)
        Me.Name = "frmHelpPage"
        Me.Text = "Help Page"
        Me.mnuMenuBar.ResumeLayout(False)
        Me.mnuMenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMenuBar As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ClassGraphsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndividualGraphsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

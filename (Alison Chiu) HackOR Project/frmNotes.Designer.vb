<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotes
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
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnuMenuBar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassGraphsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualGraphsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSaveFilePath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveNotes = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.mnuMenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Modern No. 20", 25.0!)
        Me.txtNotes.Location = New System.Drawing.Point(65, 201)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(1136, 518)
        Me.txtNotes.TabIndex = 0
        Me.txtNotes.Text = ""
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 50.0!)
        Me.lblTitle.Location = New System.Drawing.Point(490, 63)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(265, 103)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Notes"
        '
        'mnuMenuBar
        '
        Me.mnuMenuBar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuMenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuMenuBar.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuBar.Name = "mnuMenuBar"
        Me.mnuMenuBar.Size = New System.Drawing.Size(1278, 33)
        Me.mnuMenuBar.TabIndex = 11
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
        'txtSaveFilePath
        '
        Me.txtSaveFilePath.Font = New System.Drawing.Font("Modern No. 20", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaveFilePath.Location = New System.Drawing.Point(65, 849)
        Me.txtSaveFilePath.Name = "txtSaveFilePath"
        Me.txtSaveFilePath.Size = New System.Drawing.Size(751, 61)
        Me.txtSaveFilePath.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(56, 769)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(760, 51)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Where to save your notes (file path):"
        '
        'btnSaveNotes
        '
        Me.btnSaveNotes.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSaveNotes.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNotes.ForeColor = System.Drawing.Color.White
        Me.btnSaveNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveNotes.Location = New System.Drawing.Point(968, 743)
        Me.btnSaveNotes.Name = "btnSaveNotes"
        Me.btnSaveNotes.Size = New System.Drawing.Size(233, 77)
        Me.btnSaveNotes.TabIndex = 31
        Me.btnSaveNotes.Text = "Save Notes"
        Me.btnSaveNotes.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnHome.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(968, 844)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(233, 77)
        Me.btnHome.TabIndex = 32
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'frmNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 944)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnSaveNotes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSaveFilePath)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuMenuBar)
        Me.Controls.Add(Me.txtNotes)
        Me.Name = "frmNotes"
        Me.Text = "Notes"
        Me.mnuMenuBar.ResumeLayout(False)
        Me.mnuMenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNotes As RichTextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents mnuMenuBar As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ClassGraphsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndividualGraphsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtSaveFilePath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveNotes As Button
    Friend WithEvents btnHome As Button
End Class

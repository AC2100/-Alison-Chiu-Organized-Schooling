<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookBrowser
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
        Me.cboBookList = New System.Windows.Forms.ComboBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 50.0!)
        Me.lblTitle.Location = New System.Drawing.Point(26, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(621, 103)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Book Broswer"
        '
        'cboBookList
        '
        Me.cboBookList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboBookList.FormattingEnabled = True
        Me.cboBookList.Location = New System.Drawing.Point(44, 456)
        Me.cboBookList.Name = "cboBookList"
        Me.cboBookList.Size = New System.Drawing.Size(587, 33)
        Me.cboBookList.TabIndex = 13
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEnter.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnter.Location = New System.Drawing.Point(256, 673)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(172, 59)
        Me.btnEnter.TabIndex = 22
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'txtFilePath
        '
        Me.txtFilePath.Font = New System.Drawing.Font("Modern No. 20", 15.0!)
        Me.txtFilePath.Location = New System.Drawing.Point(302, 243)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(329, 40)
        Me.txtFilePath.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(259, 54)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Upload a file:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(49, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(436, 27)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "(Save it to your desktop and type the file name)"
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnUpload.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpload.Location = New System.Drawing.Point(256, 328)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(172, 59)
        Me.btnUpload.TabIndex = 26
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(163, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 41)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Load a New Book List"
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnHome.Font = New System.Drawing.Font("Modern No. 20", 14.0!)
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(12, 673)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(123, 59)
        Me.btnHome.TabIndex = 28
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 14.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(565, 675)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(101, 59)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'frmBookBrowser
        '
        Me.AcceptButton = Me.btnUpload
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(678, 744)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.cboBookList)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmBookBrowser"
        Me.Text = "Bookshelf"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents cboBookList As ComboBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents btnAdd As Button
End Class

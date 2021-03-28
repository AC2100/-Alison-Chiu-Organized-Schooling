<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpload
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
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 50.0!)
        Me.lblTitle.Location = New System.Drawing.Point(31, 50)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(605, 103)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Upload a File"
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
        Me.btnHome.TabIndex = 31
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnUpload.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpload.Location = New System.Drawing.Point(242, 520)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(172, 59)
        Me.btnUpload.TabIndex = 30
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'txtFilePath
        '
        Me.txtFilePath.Font = New System.Drawing.Font("Modern No. 20", 15.0!)
        Me.txtFilePath.Location = New System.Drawing.Point(285, 305)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(329, 40)
        Me.txtFilePath.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(62, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(436, 27)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "(Save it to your desktop and type the file name)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 54)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "File name:"
        '
        'frmUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 744)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmUpload"
        Me.Text = "Upload a File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class

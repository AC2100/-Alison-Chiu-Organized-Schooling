<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewStudent
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEnter.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnter.Location = New System.Drawing.Point(245, 532)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(172, 59)
        Me.btnEnter.TabIndex = 31
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Modern No. 20", 15.0!)
        Me.txtTitle.Location = New System.Drawing.Point(174, 388)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(329, 40)
        Me.txtTitle.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 54)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Name of Student:"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Palatino Linotype", 35.0!)
        Me.lbltitle.Location = New System.Drawing.Point(12, 28)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(662, 93)
        Me.lbltitle.TabIndex = 32
        Me.lbltitle.Text = "Add a New Student"
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
        Me.btnHome.TabIndex = 33
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'frmAddNewStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(678, 744)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddNewStudent"
        Me.Text = "Add a New Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltitle As Label
    Friend WithEvents btnHome As Button
End Class

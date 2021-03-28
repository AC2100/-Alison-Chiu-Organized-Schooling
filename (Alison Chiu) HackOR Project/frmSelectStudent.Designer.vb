<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectStudent
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
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStudents = New System.Windows.Forms.ComboBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 50.0!)
        Me.lblTitle.Location = New System.Drawing.Point(38, 26)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(619, 103)
        Me.lblTitle.TabIndex = 32
        Me.lblTitle.Text = "Select Student"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(165, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 41)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "to view their grades"
        '
        'cboStudents
        '
        Me.cboStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.cboStudents.FormattingEnabled = True
        Me.cboStudents.Location = New System.Drawing.Point(47, 305)
        Me.cboStudents.Name = "cboStudents"
        Me.cboStudents.Size = New System.Drawing.Size(587, 54)
        Me.cboStudents.TabIndex = 34
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEnter.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnter.Location = New System.Drawing.Point(244, 460)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(172, 59)
        Me.btnEnter.TabIndex = 35
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'frmSelectStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 744)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.cboStudents)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Name = "frmSelectStudent"
        Me.Text = "Select Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboStudents As ComboBox
    Friend WithEvents btnEnter As Button
End Class

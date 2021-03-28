<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentGrade
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
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMissing = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnHome.Font = New System.Drawing.Font("Modern No. 20", 25.0!)
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(224, 606)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(225, 100)
        Me.btnHome.TabIndex = 32
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(374, 285)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(158, 62)
        Me.lblScore.TabIndex = 38
        Me.lblScore.Text = "Score"
        Me.lblScore.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 40.0!)
        Me.lblTitle.Location = New System.Drawing.Point(228, 92)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(221, 83)
        Me.lblTitle.TabIndex = 41
        Me.lblTitle.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 62)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Score:"
        '
        'lblMissing
        '
        Me.lblMissing.AutoSize = True
        Me.lblMissing.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissing.Location = New System.Drawing.Point(374, 398)
        Me.lblMissing.Name = "lblMissing"
        Me.lblMissing.Size = New System.Drawing.Size(196, 62)
        Me.lblMissing.TabIndex = 43
        Me.lblMissing.Text = "Yes/No"
        Me.lblMissing.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 398)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 62)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Missing:"
        '
        'frmStudentGrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(678, 744)
        Me.Controls.Add(Me.lblMissing)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHome)
        Me.Name = "frmStudentGrade"
        Me.Text = "STUDENT Grade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMissing As Label
    Friend WithEvents Label3 As Label
End Class

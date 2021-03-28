<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassGrades
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.mnuMenuBar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassGraphsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualGraphsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.lblLowest = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblClassSize = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMissingAssignments = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnViewStudent = New System.Windows.Forms.Button()
        Me.mnuMenuBar.SuspendLayout()
        CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.Location = New System.Drawing.Point(992, 845)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(274, 80)
        Me.btnAddStudent.TabIndex = 0
        Me.btnAddStudent.Text = "Add a Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'mnuMenuBar
        '
        Me.mnuMenuBar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuMenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuMenuBar.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuBar.Name = "mnuMenuBar"
        Me.mnuMenuBar.Size = New System.Drawing.Size(1278, 33)
        Me.mnuMenuBar.TabIndex = 12
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
        Me.ToolStripMenuItem2.Text = "&Home"
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
        Me.lblTitle.Location = New System.Drawing.Point(195, 50)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(552, 103)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Class Grades"
        '
        'btnUpload
        '
        Me.btnUpload.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(992, 651)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(274, 79)
        Me.btnUpload.TabIndex = 23
        Me.btnUpload.Text = "Upload File"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 54)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Highest Score:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 452)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 54)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Lowest Score:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 54)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Class Average:"
        '
        'chart
        '
        ChartArea1.Name = "ChartArea1"
        Me.chart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chart.Legends.Add(Legend1)
        Me.chart.Location = New System.Drawing.Point(78, 534)
        Me.chart.Name = "chart"
        Me.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Class Scores"
        Me.chart.Series.Add(Series1)
        Me.chart.Size = New System.Drawing.Size(861, 391)
        Me.chart.TabIndex = 27
        Me.chart.Text = "Class Grades"
        Title1.Name = "Class Grades"
        Me.chart.Titles.Add(Title1)
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
        'lblHighest
        '
        Me.lblHighest.AutoSize = True
        Me.lblHighest.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighest.Location = New System.Drawing.Point(331, 356)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(161, 54)
        Me.lblHighest.TabIndex = 33
        Me.lblHighest.Text = "Highest"
        Me.lblHighest.Visible = False
        '
        'lblLowest
        '
        Me.lblLowest.AutoSize = True
        Me.lblLowest.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowest.Location = New System.Drawing.Point(334, 452)
        Me.lblLowest.Name = "lblLowest"
        Me.lblLowest.Size = New System.Drawing.Size(148, 54)
        Me.lblLowest.TabIndex = 32
        Me.lblLowest.Text = "Lowest"
        Me.lblLowest.Visible = False
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(331, 262)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(168, 54)
        Me.lblAverage.TabIndex = 31
        Me.lblAverage.Text = "Average"
        Me.lblAverage.Visible = False
        '
        'lblClassSize
        '
        Me.lblClassSize.AutoSize = True
        Me.lblClassSize.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassSize.Location = New System.Drawing.Point(1043, 262)
        Me.lblClassSize.Name = "lblClassSize"
        Me.lblClassSize.Size = New System.Drawing.Size(197, 54)
        Me.lblClassSize.TabIndex = 35
        Me.lblClassSize.Text = "Class Size"
        Me.lblClassSize.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(648, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(389, 54)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Number of Students:"
        '
        'lblMissingAssignments
        '
        Me.lblMissingAssignments.AutoSize = True
        Me.lblMissingAssignments.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissingAssignments.Location = New System.Drawing.Point(1043, 356)
        Me.lblMissingAssignments.Name = "lblMissingAssignments"
        Me.lblMissingAssignments.Size = New System.Drawing.Size(63, 54)
        Me.lblMissingAssignments.TabIndex = 37
        Me.lblMissingAssignments.Text = "10"
        Me.lblMissingAssignments.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(648, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(406, 54)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Missing Assignments:"
        '
        'btnViewStudent
        '
        Me.btnViewStudent.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewStudent.Location = New System.Drawing.Point(992, 748)
        Me.btnViewStudent.Name = "btnViewStudent"
        Me.btnViewStudent.Size = New System.Drawing.Size(274, 79)
        Me.btnViewStudent.TabIndex = 38
        Me.btnViewStudent.Text = "View Student"
        Me.btnViewStudent.UseVisualStyleBackColor = True
        '
        'frmClassGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 944)
        Me.Controls.Add(Me.btnViewStudent)
        Me.Controls.Add(Me.lblMissingAssignments)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblClassSize)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblHighest)
        Me.Controls.Add(Me.lblLowest)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.chart)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnuMenuBar)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Name = "frmClassGrades"
        Me.Text = "Class Grades"
        Me.mnuMenuBar.ResumeLayout(False)
        Me.mnuMenuBar.PerformLayout()
        CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddStudent As Button
    Friend WithEvents mnuMenuBar As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ClassGraphsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndividualGraphsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chart As DataVisualization.Charting.Chart
    Friend WithEvents btnHome As Button
    Friend WithEvents lblHighest As Label
    Friend WithEvents lblLowest As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblClassSize As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblMissingAssignments As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnViewStudent As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marks_report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Marks_report))
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lstvMarksInput = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.cmbRollNo = New System.Windows.Forms.ComboBox
        Me.lblRollNo = New System.Windows.Forms.Label
        Me.dtMonth = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbSubjectId = New System.Windows.Forms.ComboBox
        Me.CmbCourseId = New System.Windows.Forms.ComboBox
        Me.lblSubjectId = New System.Windows.Forms.Label
        Me.lblcourseID = New System.Windows.Forms.Label
        Me.btnGo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Course Name"
        Me.ColumnHeader3.Width = 101
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Student Name"
        Me.ColumnHeader2.Width = 168
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "RollNo"
        Me.ColumnHeader1.Width = 79
        '
        'lblHeader
        '
        Me.lblHeader.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(255, 40)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(191, 33)
        Me.lblHeader.TabIndex = 75
        Me.lblHeader.Text = "Marks Report"
        '
        'lstvMarksInput
        '
        Me.lstvMarksInput.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstvMarksInput.GridLines = True
        Me.lstvMarksInput.Location = New System.Drawing.Point(12, 190)
        Me.lstvMarksInput.Name = "lstvMarksInput"
        Me.lstvMarksInput.Size = New System.Drawing.Size(698, 255)
        Me.lstvMarksInput.TabIndex = 76
        Me.lstvMarksInput.UseCompatibleStateImageBehavior = False
        Me.lstvMarksInput.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Subject Name"
        Me.ColumnHeader4.Width = 109
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Marks"
        '
        'cmbRollNo
        '
        Me.cmbRollNo.FormattingEnabled = True
        Me.cmbRollNo.Location = New System.Drawing.Point(541, 102)
        Me.cmbRollNo.Name = "cmbRollNo"
        Me.cmbRollNo.Size = New System.Drawing.Size(121, 21)
        Me.cmbRollNo.TabIndex = 88
        '
        'lblRollNo
        '
        Me.lblRollNo.AutoSize = True
        Me.lblRollNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRollNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRollNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRollNo.Location = New System.Drawing.Point(482, 105)
        Me.lblRollNo.Name = "lblRollNo"
        Me.lblRollNo.Size = New System.Drawing.Size(53, 13)
        Me.lblRollNo.TabIndex = 85
        Me.lblRollNo.Text = "RollNo:-"
        '
        'dtMonth
        '
        Me.dtMonth.CalendarTitleBackColor = System.Drawing.Color.Gray
        Me.dtMonth.Location = New System.Drawing.Point(117, 148)
        Me.dtMonth.Name = "dtMonth"
        Me.dtMonth.Size = New System.Drawing.Size(200, 20)
        Me.dtMonth.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Select Month:-"
        '
        'cmbSubjectId
        '
        Me.cmbSubjectId.FormattingEnabled = True
        Me.cmbSubjectId.Location = New System.Drawing.Point(347, 102)
        Me.cmbSubjectId.Name = "cmbSubjectId"
        Me.cmbSubjectId.Size = New System.Drawing.Size(121, 21)
        Me.cmbSubjectId.TabIndex = 94
        '
        'CmbCourseId
        '
        Me.CmbCourseId.FormattingEnabled = True
        Me.CmbCourseId.Location = New System.Drawing.Point(117, 102)
        Me.CmbCourseId.Name = "CmbCourseId"
        Me.CmbCourseId.Size = New System.Drawing.Size(121, 21)
        Me.CmbCourseId.TabIndex = 93
        '
        'lblSubjectId
        '
        Me.lblSubjectId.AutoSize = True
        Me.lblSubjectId.BackColor = System.Drawing.Color.Transparent
        Me.lblSubjectId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSubjectId.Location = New System.Drawing.Point(272, 102)
        Me.lblSubjectId.Name = "lblSubjectId"
        Me.lblSubjectId.Size = New System.Drawing.Size(69, 13)
        Me.lblSubjectId.TabIndex = 92
        Me.lblSubjectId.Text = "SubjectId:-"
        '
        'lblcourseID
        '
        Me.lblcourseID.AutoSize = True
        Me.lblcourseID.BackColor = System.Drawing.Color.Transparent
        Me.lblcourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcourseID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcourseID.Location = New System.Drawing.Point(44, 105)
        Me.lblcourseID.Name = "lblcourseID"
        Me.lblcourseID.Size = New System.Drawing.Size(67, 13)
        Me.lblcourseID.TabIndex = 91
        Me.lblcourseID.Text = "CourseID:-"
        '
        'btnGo
        '
        Me.btnGo.BackgroundImage = CType(resources.GetObject("btnGo.BackgroundImage"), System.Drawing.Image)
        Me.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.Color.Maroon
        Me.btnGo.Location = New System.Drawing.Point(323, 138)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(66, 33)
        Me.btnGo.TabIndex = 95
        Me.btnGo.Text = "Go"
        Me.btnGo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Marks_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proect_Work.My.Resources.Resources.Backgound
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(724, 493)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.cmbSubjectId)
        Me.Controls.Add(Me.CmbCourseId)
        Me.Controls.Add(Me.lblSubjectId)
        Me.Controls.Add(Me.lblcourseID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtMonth)
        Me.Controls.Add(Me.cmbRollNo)
        Me.Controls.Add(Me.lblRollNo)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lstvMarksInput)
        Me.Name = "Marks_report"
        Me.Text = "Marks_report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lstvMarksInput As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbRollNo As System.Windows.Forms.ComboBox
    Friend WithEvents lblRollNo As System.Windows.Forms.Label
    Friend WithEvents dtMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSubjectId As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCourseId As System.Windows.Forms.ComboBox
    Friend WithEvents lblSubjectId As System.Windows.Forms.Label
    Friend WithEvents lblcourseID As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
End Class

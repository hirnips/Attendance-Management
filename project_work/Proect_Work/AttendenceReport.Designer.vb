<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendenceReport
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
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lblcoursename = New System.Windows.Forms.Label
        Me.lblRollNo = New System.Windows.Forms.Label
        Me.lblSubjectName = New System.Windows.Forms.Label
        Me.lblStartDate = New System.Windows.Forms.Label
        Me.lblEndDate = New System.Windows.Forms.Label
        Me.cmbCourse = New System.Windows.Forms.ComboBox
        Me.cmbSubject = New System.Windows.Forms.ComboBox
        Me.cmbRollno = New System.Windows.Forms.ComboBox
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.lstvAttendenceReport = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.btnGo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(247, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(260, 33)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Attendence Report"
        '
        'lblcoursename
        '
        Me.lblcoursename.AutoSize = True
        Me.lblcoursename.BackColor = System.Drawing.Color.Transparent
        Me.lblcoursename.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoursename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcoursename.Location = New System.Drawing.Point(12, 66)
        Me.lblcoursename.Name = "lblcoursename"
        Me.lblcoursename.Size = New System.Drawing.Size(116, 17)
        Me.lblcoursename.TabIndex = 2
        Me.lblcoursename.Text = "Course Name:-"
        '
        'lblRollNo
        '
        Me.lblRollNo.AutoSize = True
        Me.lblRollNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRollNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRollNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRollNo.Location = New System.Drawing.Point(513, 66)
        Me.lblRollNo.Name = "lblRollNo"
        Me.lblRollNo.Size = New System.Drawing.Size(72, 17)
        Me.lblRollNo.TabIndex = 4
        Me.lblRollNo.Text = "Roll No:-"
        '
        'lblSubjectName
        '
        Me.lblSubjectName.AutoSize = True
        Me.lblSubjectName.BackColor = System.Drawing.Color.Transparent
        Me.lblSubjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSubjectName.Location = New System.Drawing.Point(261, 66)
        Me.lblSubjectName.Name = "lblSubjectName"
        Me.lblSubjectName.Size = New System.Drawing.Size(119, 17)
        Me.lblSubjectName.TabIndex = 5
        Me.lblSubjectName.Text = "Subject Name:-"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.BackColor = System.Drawing.Color.Transparent
        Me.lblStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStartDate.Location = New System.Drawing.Point(35, 129)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(93, 17)
        Me.lblStartDate.TabIndex = 6
        Me.lblStartDate.Text = "Start Date:-"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.BackColor = System.Drawing.Color.Transparent
        Me.lblEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEndDate.Location = New System.Drawing.Point(404, 129)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(86, 17)
        Me.lblEndDate.TabIndex = 7
        Me.lblEndDate.Text = "End Date:-"
        '
        'cmbCourse
        '
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(134, 65)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(121, 21)
        Me.cmbCourse.TabIndex = 8
        '
        'cmbSubject
        '
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Location = New System.Drawing.Point(386, 65)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(121, 21)
        Me.cmbSubject.TabIndex = 9
        '
        'cmbRollno
        '
        Me.cmbRollno.FormattingEnabled = True
        Me.cmbRollno.Location = New System.Drawing.Point(591, 65)
        Me.cmbRollno.Name = "cmbRollno"
        Me.cmbRollno.Size = New System.Drawing.Size(108, 21)
        Me.cmbRollno.TabIndex = 10
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(134, 129)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 20)
        Me.dtpStart.TabIndex = 12
        '
        'dtpEnd
        '
        Me.dtpEnd.Location = New System.Drawing.Point(499, 129)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(200, 20)
        Me.dtpEnd.TabIndex = 13
        '
        'lstvAttendenceReport
        '
        Me.lstvAttendenceReport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstvAttendenceReport.GridLines = True
        Me.lstvAttendenceReport.Location = New System.Drawing.Point(12, 197)
        Me.lstvAttendenceReport.Name = "lstvAttendenceReport"
        Me.lstvAttendenceReport.Size = New System.Drawing.Size(722, 189)
        Me.lstvAttendenceReport.TabIndex = 14
        Me.lstvAttendenceReport.UseCompatibleStateImageBehavior = False
        Me.lstvAttendenceReport.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Roll No"
        Me.ColumnHeader1.Width = 56
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Student Name"
        Me.ColumnHeader2.Width = 219
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Course"
        Me.ColumnHeader3.Width = 101
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Subject"
        Me.ColumnHeader4.Width = 137
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Login Date"
        Me.ColumnHeader5.Width = 199
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.Color.Maroon
        Me.btnGo.Location = New System.Drawing.Point(335, 163)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(106, 28)
        Me.btnGo.TabIndex = 15
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'AttendenceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proect_Work.My.Resources.Resources.Backgound
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(746, 430)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lstvAttendenceReport)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.cmbRollno)
        Me.Controls.Add(Me.cmbSubject)
        Me.Controls.Add(Me.cmbCourse)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.lblSubjectName)
        Me.Controls.Add(Me.lblRollNo)
        Me.Controls.Add(Me.lblcoursename)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "AttendenceReport"
        Me.Text = "AttendenceReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblcoursename As System.Windows.Forms.Label
    Friend WithEvents lblRollNo As System.Windows.Forms.Label
    Friend WithEvents lblSubjectName As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubject As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRollno As System.Windows.Forms.ComboBox
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents lstvAttendenceReport As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnGo As System.Windows.Forms.Button
End Class

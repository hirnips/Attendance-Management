<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeesReport))
        Me.lblHeader = New System.Windows.Forms.Label
        Me.grpFees = New System.Windows.Forms.GroupBox
        Me.lblTotDueFees = New System.Windows.Forms.Label
        Me.lblTotPaidFees = New System.Windows.Forms.Label
        Me.lblTotFees = New System.Windows.Forms.Label
        Me.lblStuSubject = New System.Windows.Forms.Label
        Me.lblStuCourse = New System.Windows.Forms.Label
        Me.lblStuName = New System.Windows.Forms.Label
        Me.lblStudentSubject = New System.Windows.Forms.Label
        Me.lblTotaldueFees = New System.Windows.Forms.Label
        Me.lbltotalPaidFees = New System.Windows.Forms.Label
        Me.lblTotalFees = New System.Windows.Forms.Label
        Me.lblStudentCourse = New System.Windows.Forms.Label
        Me.lblStudentName = New System.Windows.Forms.Label
        Me.cmbSubject = New System.Windows.Forms.ComboBox
        Me.lblSubjectName = New System.Windows.Forms.Label
        Me.cmbStudent = New System.Windows.Forms.ComboBox
        Me.cmbCourse = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCourseName = New System.Windows.Forms.Label
        Me.btnTotal = New System.Windows.Forms.Button
        Me.grpFees.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(37, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(286, 33)
        Me.lblHeader.TabIndex = 19
        Me.lblHeader.Text = "Student Fees Report"
        '
        'grpFees
        '
        Me.grpFees.BackColor = System.Drawing.Color.Transparent
        Me.grpFees.Controls.Add(Me.lblTotDueFees)
        Me.grpFees.Controls.Add(Me.lblTotPaidFees)
        Me.grpFees.Controls.Add(Me.lblTotFees)
        Me.grpFees.Controls.Add(Me.lblStuSubject)
        Me.grpFees.Controls.Add(Me.lblStuCourse)
        Me.grpFees.Controls.Add(Me.lblStuName)
        Me.grpFees.Controls.Add(Me.lblStudentSubject)
        Me.grpFees.Controls.Add(Me.lblTotaldueFees)
        Me.grpFees.Controls.Add(Me.lbltotalPaidFees)
        Me.grpFees.Controls.Add(Me.lblTotalFees)
        Me.grpFees.Controls.Add(Me.lblStudentCourse)
        Me.grpFees.Controls.Add(Me.lblStudentName)
        Me.grpFees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpFees.Location = New System.Drawing.Point(16, 192)
        Me.grpFees.Name = "grpFees"
        Me.grpFees.Size = New System.Drawing.Size(412, 277)
        Me.grpFees.TabIndex = 27
        Me.grpFees.TabStop = False
        Me.grpFees.Text = "Fees Report"
        '
        'lblTotDueFees
        '
        Me.lblTotDueFees.Location = New System.Drawing.Point(126, 228)
        Me.lblTotDueFees.Name = "lblTotDueFees"
        Me.lblTotDueFees.Size = New System.Drawing.Size(193, 13)
        Me.lblTotDueFees.TabIndex = 35
        '
        'lblTotPaidFees
        '
        Me.lblTotPaidFees.Location = New System.Drawing.Point(126, 180)
        Me.lblTotPaidFees.Name = "lblTotPaidFees"
        Me.lblTotPaidFees.Size = New System.Drawing.Size(193, 13)
        Me.lblTotPaidFees.TabIndex = 34
        '
        'lblTotFees
        '
        Me.lblTotFees.Location = New System.Drawing.Point(126, 147)
        Me.lblTotFees.Name = "lblTotFees"
        Me.lblTotFees.Size = New System.Drawing.Size(193, 13)
        Me.lblTotFees.TabIndex = 33
        '
        'lblStuSubject
        '
        Me.lblStuSubject.Location = New System.Drawing.Point(126, 113)
        Me.lblStuSubject.Name = "lblStuSubject"
        Me.lblStuSubject.Size = New System.Drawing.Size(193, 13)
        Me.lblStuSubject.TabIndex = 32
        '
        'lblStuCourse
        '
        Me.lblStuCourse.Location = New System.Drawing.Point(126, 76)
        Me.lblStuCourse.Name = "lblStuCourse"
        Me.lblStuCourse.Size = New System.Drawing.Size(193, 13)
        Me.lblStuCourse.TabIndex = 31
        '
        'lblStuName
        '
        Me.lblStuName.Location = New System.Drawing.Point(126, 35)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(193, 13)
        Me.lblStuName.TabIndex = 30
        '
        'lblStudentSubject
        '
        Me.lblStudentSubject.AutoSize = True
        Me.lblStudentSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentSubject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStudentSubject.Location = New System.Drawing.Point(8, 113)
        Me.lblStudentSubject.Name = "lblStudentSubject"
        Me.lblStudentSubject.Size = New System.Drawing.Size(102, 13)
        Me.lblStudentSubject.TabIndex = 29
        Me.lblStudentSubject.Text = "Student Subject:"
        '
        'lblTotaldueFees
        '
        Me.lblTotaldueFees.AutoSize = True
        Me.lblTotaldueFees.BackColor = System.Drawing.Color.Transparent
        Me.lblTotaldueFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotaldueFees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotaldueFees.Location = New System.Drawing.Point(15, 228)
        Me.lblTotaldueFees.Name = "lblTotaldueFees"
        Me.lblTotaldueFees.Size = New System.Drawing.Size(95, 13)
        Me.lblTotaldueFees.TabIndex = 28
        Me.lblTotaldueFees.Text = "Total Due fees:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbltotalPaidFees
        '
        Me.lbltotalPaidFees.AutoSize = True
        Me.lbltotalPaidFees.BackColor = System.Drawing.Color.Transparent
        Me.lbltotalPaidFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalPaidFees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltotalPaidFees.Location = New System.Drawing.Point(10, 179)
        Me.lbltotalPaidFees.Name = "lbltotalPaidFees"
        Me.lbltotalPaidFees.Size = New System.Drawing.Size(100, 13)
        Me.lbltotalPaidFees.TabIndex = 27
        Me.lbltotalPaidFees.Text = "Total Paid Fees:"
        '
        'lblTotalFees
        '
        Me.lblTotalFees.AutoSize = True
        Me.lblTotalFees.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalFees.Location = New System.Drawing.Point(39, 147)
        Me.lblTotalFees.Name = "lblTotalFees"
        Me.lblTotalFees.Size = New System.Drawing.Size(71, 13)
        Me.lblTotalFees.TabIndex = 26
        Me.lblTotalFees.Text = "Total Fees:"
        '
        'lblStudentCourse
        '
        Me.lblStudentCourse.AutoSize = True
        Me.lblStudentCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStudentCourse.Location = New System.Drawing.Point(14, 76)
        Me.lblStudentCourse.Name = "lblStudentCourse"
        Me.lblStudentCourse.Size = New System.Drawing.Size(98, 13)
        Me.lblStudentCourse.TabIndex = 25
        Me.lblStudentCourse.Text = "Student Course:"
        '
        'lblStudentName
        '
        Me.lblStudentName.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStudentName.Location = New System.Drawing.Point(19, 35)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(91, 13)
        Me.lblStudentName.TabIndex = 24
        Me.lblStudentName.Text = "Student Name:"
        '
        'cmbSubject
        '
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Location = New System.Drawing.Point(135, 110)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(121, 21)
        Me.cmbSubject.TabIndex = 38
        '
        'lblSubjectName
        '
        Me.lblSubjectName.AutoSize = True
        Me.lblSubjectName.BackColor = System.Drawing.Color.Transparent
        Me.lblSubjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSubjectName.Location = New System.Drawing.Point(8, 111)
        Me.lblSubjectName.Name = "lblSubjectName"
        Me.lblSubjectName.Size = New System.Drawing.Size(119, 17)
        Me.lblSubjectName.TabIndex = 37
        Me.lblSubjectName.Text = "Subject Name:-"
        '
        'cmbStudent
        '
        Me.cmbStudent.FormattingEnabled = True
        Me.cmbStudent.Location = New System.Drawing.Point(135, 151)
        Me.cmbStudent.Name = "cmbStudent"
        Me.cmbStudent.Size = New System.Drawing.Size(121, 21)
        Me.cmbStudent.TabIndex = 44
        '
        'cmbCourse
        '
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(135, 70)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(121, 21)
        Me.cmbCourse.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Student Name:-"
        '
        'lblCourseName
        '
        Me.lblCourseName.AutoSize = True
        Me.lblCourseName.BackColor = System.Drawing.Color.Transparent
        Me.lblCourseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCourseName.Location = New System.Drawing.Point(13, 71)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(116, 17)
        Me.lblCourseName.TabIndex = 39
        Me.lblCourseName.Text = "Course Name:-"
        '
        'btnTotal
        '
        Me.btnTotal.BackgroundImage = CType(resources.GetObject("btnTotal.BackgroundImage"), System.Drawing.Image)
        Me.btnTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.ForeColor = System.Drawing.Color.Maroon
        Me.btnTotal.Location = New System.Drawing.Point(262, 144)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(121, 33)
        Me.btnTotal.TabIndex = 45
        Me.btnTotal.Text = "Total Fees"
        Me.btnTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'FeesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proect_Work.My.Resources.Resources.Backgound
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(440, 519)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.cmbStudent)
        Me.Controls.Add(Me.cmbCourse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCourseName)
        Me.Controls.Add(Me.cmbSubject)
        Me.Controls.Add(Me.lblSubjectName)
        Me.Controls.Add(Me.grpFees)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "FeesReport"
        Me.Text = "Student Fees Report"
        Me.TopMost = True
        Me.grpFees.ResumeLayout(False)
        Me.grpFees.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents grpFees As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotaldueFees As System.Windows.Forms.Label
    Friend WithEvents lbltotalPaidFees As System.Windows.Forms.Label
    Friend WithEvents lblTotalFees As System.Windows.Forms.Label
    Friend WithEvents lblStudentCourse As System.Windows.Forms.Label
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents lblStudentSubject As System.Windows.Forms.Label
    Friend WithEvents lblTotDueFees As System.Windows.Forms.Label
    Friend WithEvents lblTotPaidFees As System.Windows.Forms.Label
    Friend WithEvents lblTotFees As System.Windows.Forms.Label
    Friend WithEvents lblStuSubject As System.Windows.Forms.Label
    Friend WithEvents lblStuCourse As System.Windows.Forms.Label
    Friend WithEvents lblStuName As System.Windows.Forms.Label
    Friend WithEvents cmbSubject As System.Windows.Forms.ComboBox
    Friend WithEvents lblSubjectName As System.Windows.Forms.Label
    Friend WithEvents cmbStudent As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCourseName As System.Windows.Forms.Label
    Friend WithEvents btnTotal As System.Windows.Forms.Button
End Class

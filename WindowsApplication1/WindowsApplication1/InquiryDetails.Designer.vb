<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InquiryDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InquiryDetails))
        Me.grpStudent = New System.Windows.Forms.GroupBox
        Me.txtmobile = New System.Windows.Forms.TextBox
        Me.txtphone = New System.Windows.Forms.TextBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.lblemail = New System.Windows.Forms.Label
        Me.lblphone = New System.Windows.Forms.Label
        Me.lblmobile = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.lbladdress = New System.Windows.Forms.Label
        Me.dtBirthday = New System.Windows.Forms.DateTimePicker
        Me.lblbirth = New System.Windows.Forms.Label
        Me.lblSex = New System.Windows.Forms.Label
        Me.grpsex = New System.Windows.Forms.GroupBox
        Me.rdofemale = New System.Windows.Forms.RadioButton
        Me.rdomale = New System.Windows.Forms.RadioButton
        Me.txtfather = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtsurname = New System.Windows.Forms.TextBox
        Me.lbllastname = New System.Windows.Forms.Label
        Me.lblmidalname = New System.Windows.Forms.Label
        Me.lblfirstname = New System.Windows.Forms.Label
        Me.lblname = New System.Windows.Forms.Label
        Me.grpCourse = New System.Windows.Forms.GroupBox
        Me.dtFollowup = New System.Windows.Forms.DateTimePicker
        Me.lblFollowup = New System.Windows.Forms.Label
        Me.dtInquiry = New System.Windows.Forms.DateTimePicker
        Me.lblInquirydate = New System.Windows.Forms.Label
        Me.cmbarea = New System.Windows.Forms.ComboBox
        Me.lblarea = New System.Windows.Forms.Label
        Me.lstsubject = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.cmbcourse = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblCourse = New System.Windows.Forms.Label
        Me.lblHeader = New System.Windows.Forms.Label
        Me.grpoption = New System.Windows.Forms.GroupBox
        Me.btnnew = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.grpStudent.SuspendLayout()
        Me.grpsex.SuspendLayout()
        Me.grpCourse.SuspendLayout()
        Me.grpoption.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStudent
        '
        Me.grpStudent.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.akshay
        Me.grpStudent.Controls.Add(Me.txtmobile)
        Me.grpStudent.Controls.Add(Me.txtphone)
        Me.grpStudent.Controls.Add(Me.txtemail)
        Me.grpStudent.Controls.Add(Me.lblemail)
        Me.grpStudent.Controls.Add(Me.lblphone)
        Me.grpStudent.Controls.Add(Me.lblmobile)
        Me.grpStudent.Controls.Add(Me.txtaddress)
        Me.grpStudent.Controls.Add(Me.lbladdress)
        Me.grpStudent.Controls.Add(Me.dtBirthday)
        Me.grpStudent.Controls.Add(Me.lblbirth)
        Me.grpStudent.Controls.Add(Me.lblSex)
        Me.grpStudent.Controls.Add(Me.grpsex)
        Me.grpStudent.Controls.Add(Me.txtfather)
        Me.grpStudent.Controls.Add(Me.txtname)
        Me.grpStudent.Controls.Add(Me.txtsurname)
        Me.grpStudent.Controls.Add(Me.lbllastname)
        Me.grpStudent.Controls.Add(Me.lblmidalname)
        Me.grpStudent.Controls.Add(Me.lblfirstname)
        Me.grpStudent.Controls.Add(Me.lblname)
        Me.grpStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpStudent.Location = New System.Drawing.Point(12, 81)
        Me.grpStudent.Name = "grpStudent"
        Me.grpStudent.Size = New System.Drawing.Size(423, 374)
        Me.grpStudent.TabIndex = 0
        Me.grpStudent.TabStop = False
        Me.grpStudent.Text = "Inquiry Details"
        '
        'txtmobile
        '
        Me.txtmobile.BackColor = System.Drawing.Color.White
        Me.txtmobile.Location = New System.Drawing.Point(73, 333)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(203, 23)
        Me.txtmobile.TabIndex = 31
        '
        'txtphone
        '
        Me.txtphone.BackColor = System.Drawing.Color.White
        Me.txtphone.Location = New System.Drawing.Point(73, 295)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(203, 23)
        Me.txtphone.TabIndex = 29
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.White
        Me.txtemail.Location = New System.Drawing.Point(73, 261)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(203, 23)
        Me.txtemail.TabIndex = 28
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(12, 264)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(58, 13)
        Me.lblemail.TabIndex = 27
        Me.lblemail.Text = "E-mail ID"
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.BackColor = System.Drawing.Color.Transparent
        Me.lblphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone.Location = New System.Drawing.Point(7, 302)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(63, 13)
        Me.lblphone.TabIndex = 30
        Me.lblphone.Text = "Phone No"
        '
        'lblmobile
        '
        Me.lblmobile.AutoSize = True
        Me.lblmobile.BackColor = System.Drawing.Color.Transparent
        Me.lblmobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmobile.Location = New System.Drawing.Point(6, 336)
        Me.lblmobile.Name = "lblmobile"
        Me.lblmobile.Size = New System.Drawing.Size(64, 13)
        Me.lblmobile.TabIndex = 32
        Me.lblmobile.Text = "Mobile No"
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.White
        Me.txtaddress.Location = New System.Drawing.Point(73, 157)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(203, 84)
        Me.txtaddress.TabIndex = 26
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.BackColor = System.Drawing.Color.Transparent
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(15, 197)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(52, 13)
        Me.lbladdress.TabIndex = 25
        Me.lbladdress.Text = "Address"
        '
        'dtBirthday
        '
        Me.dtBirthday.Location = New System.Drawing.Point(76, 119)
        Me.dtBirthday.Name = "dtBirthday"
        Me.dtBirthday.Size = New System.Drawing.Size(200, 23)
        Me.dtBirthday.TabIndex = 24
        '
        'lblbirth
        '
        Me.lblbirth.AutoSize = True
        Me.lblbirth.BackColor = System.Drawing.Color.Transparent
        Me.lblbirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbirth.Location = New System.Drawing.Point(6, 123)
        Me.lblbirth.Name = "lblbirth"
        Me.lblbirth.Size = New System.Drawing.Size(64, 13)
        Me.lblbirth.TabIndex = 23
        Me.lblbirth.Text = "Birth Date"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.BackColor = System.Drawing.Color.Transparent
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(42, 88)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(28, 13)
        Me.lblSex.TabIndex = 11
        Me.lblSex.Text = "Sex"
        '
        'grpsex
        '
        Me.grpsex.BackColor = System.Drawing.Color.Transparent
        Me.grpsex.Controls.Add(Me.rdofemale)
        Me.grpsex.Controls.Add(Me.rdomale)
        Me.grpsex.Location = New System.Drawing.Point(76, 74)
        Me.grpsex.Name = "grpsex"
        Me.grpsex.Size = New System.Drawing.Size(203, 30)
        Me.grpsex.TabIndex = 22
        Me.grpsex.TabStop = False
        '
        'rdofemale
        '
        Me.rdofemale.AutoSize = True
        Me.rdofemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdofemale.Location = New System.Drawing.Point(104, 10)
        Me.rdofemale.Name = "rdofemale"
        Me.rdofemale.Size = New System.Drawing.Size(65, 17)
        Me.rdofemale.TabIndex = 1
        Me.rdofemale.TabStop = True
        Me.rdofemale.Text = "Female"
        Me.rdofemale.UseVisualStyleBackColor = True
        '
        'rdomale
        '
        Me.rdomale.AutoSize = True
        Me.rdomale.Checked = True
        Me.rdomale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdomale.Location = New System.Drawing.Point(22, 10)
        Me.rdomale.Name = "rdomale"
        Me.rdomale.Size = New System.Drawing.Size(52, 17)
        Me.rdomale.TabIndex = 0
        Me.rdomale.TabStop = True
        Me.rdomale.Text = "Male"
        Me.rdomale.UseVisualStyleBackColor = True
        '
        'txtfather
        '
        Me.txtfather.BackColor = System.Drawing.Color.White
        Me.txtfather.Location = New System.Drawing.Point(288, 48)
        Me.txtfather.Name = "txtfather"
        Me.txtfather.Size = New System.Drawing.Size(100, 23)
        Me.txtfather.TabIndex = 9
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.Location = New System.Drawing.Point(182, 48)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 23)
        Me.txtname.TabIndex = 8
        '
        'txtsurname
        '
        Me.txtsurname.BackColor = System.Drawing.Color.White
        Me.txtsurname.Location = New System.Drawing.Point(76, 48)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(100, 23)
        Me.txtsurname.TabIndex = 7
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.BackColor = System.Drawing.Color.Transparent
        Me.lbllastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllastname.Location = New System.Drawing.Point(303, 32)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(68, 13)
        Me.lbllastname.TabIndex = 6
        Me.lbllastname.Text = "Father Name"
        '
        'lblmidalname
        '
        Me.lblmidalname.AutoSize = True
        Me.lblmidalname.BackColor = System.Drawing.Color.Transparent
        Me.lblmidalname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmidalname.Location = New System.Drawing.Point(213, 32)
        Me.lblmidalname.Name = "lblmidalname"
        Me.lblmidalname.Size = New System.Drawing.Size(35, 13)
        Me.lblmidalname.TabIndex = 5
        Me.lblmidalname.Text = "Name"
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.BackColor = System.Drawing.Color.Transparent
        Me.lblfirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirstname.Location = New System.Drawing.Point(90, 32)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(49, 13)
        Me.lblfirstname.TabIndex = 4
        Me.lblfirstname.Text = "Surname"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(31, 51)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(39, 13)
        Me.lblname.TabIndex = 3
        Me.lblname.Text = "Name"
        '
        'grpCourse
        '
        Me.grpCourse.BackColor = System.Drawing.Color.Transparent
        Me.grpCourse.Controls.Add(Me.dtFollowup)
        Me.grpCourse.Controls.Add(Me.lblFollowup)
        Me.grpCourse.Controls.Add(Me.dtInquiry)
        Me.grpCourse.Controls.Add(Me.lblInquirydate)
        Me.grpCourse.Controls.Add(Me.cmbarea)
        Me.grpCourse.Controls.Add(Me.lblarea)
        Me.grpCourse.Controls.Add(Me.lstsubject)
        Me.grpCourse.Controls.Add(Me.cmbcourse)
        Me.grpCourse.Controls.Add(Me.Label6)
        Me.grpCourse.Controls.Add(Me.lblCourse)
        Me.grpCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpCourse.Location = New System.Drawing.Point(441, 81)
        Me.grpCourse.Name = "grpCourse"
        Me.grpCourse.Size = New System.Drawing.Size(330, 370)
        Me.grpCourse.TabIndex = 65
        Me.grpCourse.TabStop = False
        Me.grpCourse.Text = "Course Details"
        '
        'dtFollowup
        '
        Me.dtFollowup.Location = New System.Drawing.Point(116, 302)
        Me.dtFollowup.Name = "dtFollowup"
        Me.dtFollowup.Size = New System.Drawing.Size(200, 23)
        Me.dtFollowup.TabIndex = 38
        '
        'lblFollowup
        '
        Me.lblFollowup.AutoSize = True
        Me.lblFollowup.BackColor = System.Drawing.Color.Transparent
        Me.lblFollowup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFollowup.Location = New System.Drawing.Point(18, 307)
        Me.lblFollowup.Name = "lblFollowup"
        Me.lblFollowup.Size = New System.Drawing.Size(92, 13)
        Me.lblFollowup.TabIndex = 37
        Me.lblFollowup.Text = "Follow up Date"
        '
        'dtInquiry
        '
        Me.dtInquiry.Location = New System.Drawing.Point(116, 254)
        Me.dtInquiry.Name = "dtInquiry"
        Me.dtInquiry.Size = New System.Drawing.Size(200, 23)
        Me.dtInquiry.TabIndex = 34
        '
        'lblInquirydate
        '
        Me.lblInquirydate.AutoSize = True
        Me.lblInquirydate.BackColor = System.Drawing.Color.Transparent
        Me.lblInquirydate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInquirydate.Location = New System.Drawing.Point(34, 259)
        Me.lblInquirydate.Name = "lblInquirydate"
        Me.lblInquirydate.Size = New System.Drawing.Size(76, 13)
        Me.lblInquirydate.TabIndex = 33
        Me.lblInquirydate.Text = "Inquiry Date"
        '
        'cmbarea
        '
        Me.cmbarea.FormattingEnabled = True
        Me.cmbarea.Items.AddRange(New Object() {"GBSE", "CBSE"})
        Me.cmbarea.Location = New System.Drawing.Point(116, 210)
        Me.cmbarea.Name = "cmbarea"
        Me.cmbarea.Size = New System.Drawing.Size(121, 24)
        Me.cmbarea.TabIndex = 36
        '
        'lblarea
        '
        Me.lblarea.AutoSize = True
        Me.lblarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblarea.Location = New System.Drawing.Point(69, 215)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(33, 13)
        Me.lblarea.TabIndex = 35
        Me.lblarea.Text = "Area"
        '
        'lstsubject
        '
        Me.lstsubject.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstsubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstsubject.Location = New System.Drawing.Point(116, 65)
        Me.lstsubject.Name = "lstsubject"
        Me.lstsubject.Size = New System.Drawing.Size(121, 115)
        Me.lstsubject.TabIndex = 34
        Me.lstsubject.UseCompatibleStateImageBehavior = False
        Me.lstsubject.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SubjectName"
        Me.ColumnHeader1.Width = 115
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "SabjectID"
        Me.ColumnHeader2.Width = 0
        '
        'cmbcourse
        '
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.Items.AddRange(New Object() {"GBSE", "CBSE"})
        Me.cmbcourse.Location = New System.Drawing.Point(116, 25)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(121, 24)
        Me.cmbcourse.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(52, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Subject"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCourse.Location = New System.Drawing.Point(56, 30)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(46, 13)
        Me.lblCourse.TabIndex = 31
        Me.lblCourse.Text = "Course"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(265, 36)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(214, 33)
        Me.lblHeader.TabIndex = 66
        Me.lblHeader.Text = "Student Master"
        '
        'grpoption
        '
        Me.grpoption.BackColor = System.Drawing.Color.Transparent
        Me.grpoption.Controls.Add(Me.btnnew)
        Me.grpoption.Controls.Add(Me.btnclose)
        Me.grpoption.Controls.Add(Me.btnsave)
        Me.grpoption.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpoption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpoption.Location = New System.Drawing.Point(300, 461)
        Me.grpoption.Name = "grpoption"
        Me.grpoption.Size = New System.Drawing.Size(300, 76)
        Me.grpoption.TabIndex = 67
        Me.grpoption.TabStop = False
        Me.grpoption.Text = "Option"
        '
        'btnnew
        '
        Me.btnnew.BackgroundImage = CType(resources.GetObject("btnnew.BackgroundImage"), System.Drawing.Image)
        Me.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.Maroon
        Me.btnnew.Location = New System.Drawing.Point(46, 22)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 35)
        Me.btnnew.TabIndex = 56
        Me.btnnew.Text = "New"
        Me.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Maroon
        Me.btnclose.Location = New System.Drawing.Point(208, 22)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 30)
        Me.btnclose.TabIndex = 60
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.BackgroundImage = CType(resources.GetObject("btnsave.BackgroundImage"), System.Drawing.Image)
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Maroon
        Me.btnsave.Location = New System.Drawing.Point(127, 22)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 33)
        Me.btnsave.TabIndex = 58
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'InquiryDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.akshay
        Me.ClientSize = New System.Drawing.Size(782, 567)
        Me.Controls.Add(Me.grpoption)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.grpCourse)
        Me.Controls.Add(Me.grpStudent)
        Me.Name = "InquiryDetails"
        Me.Text = "InquiryDetails"
        Me.grpStudent.ResumeLayout(False)
        Me.grpStudent.PerformLayout()
        Me.grpsex.ResumeLayout(False)
        Me.grpsex.PerformLayout()
        Me.grpCourse.ResumeLayout(False)
        Me.grpCourse.PerformLayout()
        Me.grpoption.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpStudent As System.Windows.Forms.GroupBox
    Friend WithEvents lblfirstname As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents txtmobile As System.Windows.Forms.TextBox
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lblphone As System.Windows.Forms.Label
    Friend WithEvents lblmobile As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents dtBirthday As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblbirth As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents grpsex As System.Windows.Forms.GroupBox
    Friend WithEvents rdofemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdomale As System.Windows.Forms.RadioButton
    Friend WithEvents txtfather As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtsurname As System.Windows.Forms.TextBox
    Friend WithEvents lbllastname As System.Windows.Forms.Label
    Friend WithEvents lblmidalname As System.Windows.Forms.Label
    Friend WithEvents grpCourse As System.Windows.Forms.GroupBox
    Friend WithEvents cmbarea As System.Windows.Forms.ComboBox
    Friend WithEvents lblarea As System.Windows.Forms.Label
    Friend WithEvents lstsubject As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbcourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents grpoption As System.Windows.Forms.GroupBox
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents dtInquiry As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblInquirydate As System.Windows.Forms.Label
    Friend WithEvents dtFollowup As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFollowup As System.Windows.Forms.Label
End Class

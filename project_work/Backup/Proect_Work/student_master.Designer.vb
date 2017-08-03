<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STUDENT_MASTER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(STUDENT_MASTER))
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lblbirth = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtrollid = New System.Windows.Forms.TextBox
        Me.lblmobile = New System.Windows.Forms.Label
        Me.lblphone = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.lbladdress = New System.Windows.Forms.Label
        Me.txtsurname = New System.Windows.Forms.TextBox
        Me.lblemail = New System.Windows.Forms.Label
        Me.lbllastname = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.lblmidalname = New System.Windows.Forms.Label
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.lblfirstname = New System.Windows.Forms.Label
        Me.txtphone = New System.Windows.Forms.TextBox
        Me.lblname = New System.Windows.Forms.Label
        Me.txtmobile = New System.Windows.Forms.TextBox
        Me.lblrollno = New System.Windows.Forms.Label
        Me.grpsex = New System.Windows.Forms.GroupBox
        Me.rdofemale = New System.Windows.Forms.RadioButton
        Me.rdomale = New System.Windows.Forms.RadioButton
        Me.txtfather = New System.Windows.Forms.TextBox
        Me.grpadd1 = New System.Windows.Forms.GroupBox
        Me.btnserch = New System.Windows.Forms.Button
        Me.txtdb = New System.Windows.Forms.DateTimePicker
        Me.lblfmo = New System.Windows.Forms.Label
        Me.lbldes = New System.Windows.Forms.Label
        Me.txtfsname = New System.Windows.Forms.TextBox
        Me.lblocc = New System.Windows.Forms.Label
        Me.txtffname = New System.Windows.Forms.TextBox
        Me.lbllstnm = New System.Windows.Forms.Label
        Me.txtfname = New System.Windows.Forms.TextBox
        Me.lblmidlnm = New System.Windows.Forms.Label
        Me.txtoccupa = New System.Windows.Forms.TextBox
        Me.lblfstname = New System.Windows.Forms.Label
        Me.txtdesig = New System.Windows.Forms.TextBox
        Me.lblfname = New System.Windows.Forms.Label
        Me.txtfmobile = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtmedium = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtyear = New System.Windows.Forms.TextBox
        Me.lblper = New System.Windows.Forms.Label
        Me.txtpractical = New System.Windows.Forms.TextBox
        Me.lblmed = New System.Windows.Forms.Label
        Me.txtpercent = New System.Windows.Forms.TextBox
        Me.lblboard = New System.Windows.Forms.Label
        Me.txttot = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtattamp = New System.Windows.Forms.TextBox
        Me.grpexam = New System.Windows.Forms.GroupBox
        Me.cmbboard = New System.Windows.Forms.ComboBox
        Me.btnnew = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.grpoption = New System.Windows.Forms.GroupBox
        Me.ofdPhoto = New System.Windows.Forms.OpenFileDialog
        Me.grpimage = New System.Windows.Forms.GroupBox
        Me.ptustudent = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbarea = New System.Windows.Forms.ComboBox
        Me.lblarea = New System.Windows.Forms.Label
        Me.lstsubject = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.cmbcourse = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblCourse = New System.Windows.Forms.Label
        Me.btnUpload = New System.Windows.Forms.Button
        Me.grpsex.SuspendLayout()
        Me.grpadd1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpexam.SuspendLayout()
        Me.grpoption.SuspendLayout()
        Me.grpimage.SuspendLayout()
        CType(Me.ptustudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(442, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(214, 33)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Student Master"
        '
        'lblbirth
        '
        Me.lblbirth.AutoSize = True
        Me.lblbirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbirth.Location = New System.Drawing.Point(2, 160)
        Me.lblbirth.Name = "lblbirth"
        Me.lblbirth.Size = New System.Drawing.Size(64, 13)
        Me.lblbirth.TabIndex = 11
        Me.lblbirth.Text = "Birth Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Sex"
        '
        'txtrollid
        '
        Me.txtrollid.BackColor = System.Drawing.Color.White
        Me.txtrollid.Location = New System.Drawing.Point(72, 47)
        Me.txtrollid.Name = "txtrollid"
        Me.txtrollid.Size = New System.Drawing.Size(100, 23)
        Me.txtrollid.TabIndex = 0
        '
        'lblmobile
        '
        Me.lblmobile.AutoSize = True
        Me.lblmobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmobile.Location = New System.Drawing.Point(2, 372)
        Me.lblmobile.Name = "lblmobile"
        Me.lblmobile.Size = New System.Drawing.Size(64, 13)
        Me.lblmobile.TabIndex = 9
        Me.lblmobile.Text = "Mobile No"
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone.Location = New System.Drawing.Point(3, 338)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(63, 13)
        Me.lblphone.TabIndex = 8
        Me.lblphone.Text = "Phone No"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.Location = New System.Drawing.Point(176, 89)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 23)
        Me.txtname.TabIndex = 2
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(17, 228)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(52, 13)
        Me.lbladdress.TabIndex = 7
        Me.lbladdress.Text = "Address"
        '
        'txtsurname
        '
        Me.txtsurname.BackColor = System.Drawing.Color.White
        Me.txtsurname.Location = New System.Drawing.Point(69, 89)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(100, 23)
        Me.txtsurname.TabIndex = 1
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(8, 300)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(58, 13)
        Me.lblemail.TabIndex = 6
        Me.lblemail.Text = "E-mail ID"
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllastname.Location = New System.Drawing.Point(296, 73)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(68, 13)
        Me.lbllastname.TabIndex = 5
        Me.lbllastname.Text = "Father Name"
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.White
        Me.txtaddress.Location = New System.Drawing.Point(69, 196)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(203, 84)
        Me.txtaddress.TabIndex = 5
        '
        'lblmidalname
        '
        Me.lblmidalname.AutoSize = True
        Me.lblmidalname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmidalname.Location = New System.Drawing.Point(212, 73)
        Me.lblmidalname.Name = "lblmidalname"
        Me.lblmidalname.Size = New System.Drawing.Size(35, 13)
        Me.lblmidalname.TabIndex = 4
        Me.lblmidalname.Text = "Name"
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.White
        Me.txtemail.Location = New System.Drawing.Point(69, 297)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(203, 23)
        Me.txtemail.TabIndex = 6
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirstname.Location = New System.Drawing.Point(95, 73)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(49, 13)
        Me.lblfirstname.TabIndex = 3
        Me.lblfirstname.Text = "Surname"
        '
        'txtphone
        '
        Me.txtphone.BackColor = System.Drawing.Color.White
        Me.txtphone.Location = New System.Drawing.Point(69, 331)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(203, 23)
        Me.txtphone.TabIndex = 7
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(27, 92)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(39, 13)
        Me.lblname.TabIndex = 2
        Me.lblname.Text = "Name"
        '
        'txtmobile
        '
        Me.txtmobile.BackColor = System.Drawing.Color.White
        Me.txtmobile.Location = New System.Drawing.Point(69, 369)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(203, 23)
        Me.txtmobile.TabIndex = 8
        '
        'lblrollno
        '
        Me.lblrollno.AutoSize = True
        Me.lblrollno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrollno.Location = New System.Drawing.Point(17, 49)
        Me.lblrollno.Name = "lblrollno"
        Me.lblrollno.Size = New System.Drawing.Size(49, 13)
        Me.lblrollno.TabIndex = 1
        Me.lblrollno.Text = "Roll No"
        '
        'grpsex
        '
        Me.grpsex.Controls.Add(Me.rdofemale)
        Me.grpsex.Controls.Add(Me.rdomale)
        Me.grpsex.Location = New System.Drawing.Point(69, 115)
        Me.grpsex.Name = "grpsex"
        Me.grpsex.Size = New System.Drawing.Size(203, 30)
        Me.grpsex.TabIndex = 21
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
        Me.txtfather.Location = New System.Drawing.Point(282, 89)
        Me.txtfather.Name = "txtfather"
        Me.txtfather.Size = New System.Drawing.Size(100, 23)
        Me.txtfather.TabIndex = 3
        '
        'grpadd1
        '
        Me.grpadd1.BackColor = System.Drawing.Color.Transparent
        Me.grpadd1.Controls.Add(Me.btnserch)
        Me.grpadd1.Controls.Add(Me.txtdb)
        Me.grpadd1.Controls.Add(Me.txtfather)
        Me.grpadd1.Controls.Add(Me.grpsex)
        Me.grpadd1.Controls.Add(Me.lblrollno)
        Me.grpadd1.Controls.Add(Me.txtmobile)
        Me.grpadd1.Controls.Add(Me.lblname)
        Me.grpadd1.Controls.Add(Me.txtphone)
        Me.grpadd1.Controls.Add(Me.lblfirstname)
        Me.grpadd1.Controls.Add(Me.txtemail)
        Me.grpadd1.Controls.Add(Me.lblmidalname)
        Me.grpadd1.Controls.Add(Me.txtaddress)
        Me.grpadd1.Controls.Add(Me.lbllastname)
        Me.grpadd1.Controls.Add(Me.lblemail)
        Me.grpadd1.Controls.Add(Me.txtsurname)
        Me.grpadd1.Controls.Add(Me.lbladdress)
        Me.grpadd1.Controls.Add(Me.txtname)
        Me.grpadd1.Controls.Add(Me.lblphone)
        Me.grpadd1.Controls.Add(Me.lblmobile)
        Me.grpadd1.Controls.Add(Me.txtrollid)
        Me.grpadd1.Controls.Add(Me.Label9)
        Me.grpadd1.Controls.Add(Me.lblbirth)
        Me.grpadd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpadd1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpadd1.Location = New System.Drawing.Point(2, 43)
        Me.grpadd1.Name = "grpadd1"
        Me.grpadd1.Size = New System.Drawing.Size(387, 405)
        Me.grpadd1.TabIndex = 22
        Me.grpadd1.TabStop = False
        Me.grpadd1.Text = "Student Details"
        '
        'btnserch
        '
        Me.btnserch.BackColor = System.Drawing.Color.White
        Me.btnserch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnserch.ForeColor = System.Drawing.Color.DarkRed
        Me.btnserch.Location = New System.Drawing.Point(243, 39)
        Me.btnserch.Name = "btnserch"
        Me.btnserch.Size = New System.Drawing.Size(81, 32)
        Me.btnserch.TabIndex = 61
        Me.btnserch.Text = "Search"
        Me.btnserch.UseVisualStyleBackColor = False
        '
        'txtdb
        '
        Me.txtdb.Location = New System.Drawing.Point(69, 160)
        Me.txtdb.Name = "txtdb"
        Me.txtdb.Size = New System.Drawing.Size(200, 23)
        Me.txtdb.TabIndex = 22
        '
        'lblfmo
        '
        Me.lblfmo.AutoSize = True
        Me.lblfmo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfmo.Location = New System.Drawing.Point(26, 145)
        Me.lblfmo.Name = "lblfmo"
        Me.lblfmo.Size = New System.Drawing.Size(64, 13)
        Me.lblfmo.TabIndex = 29
        Me.lblfmo.Text = "Mobile No"
        '
        'lbldes
        '
        Me.lbldes.AutoSize = True
        Me.lbldes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldes.Location = New System.Drawing.Point(16, 108)
        Me.lbldes.Name = "lbldes"
        Me.lbldes.Size = New System.Drawing.Size(74, 13)
        Me.lbldes.TabIndex = 28
        Me.lbldes.Text = "Designation"
        '
        'txtfsname
        '
        Me.txtfsname.Location = New System.Drawing.Point(89, 36)
        Me.txtfsname.Name = "txtfsname"
        Me.txtfsname.Size = New System.Drawing.Size(100, 23)
        Me.txtfsname.TabIndex = 9
        '
        'lblocc
        '
        Me.lblocc.AutoSize = True
        Me.lblocc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblocc.Location = New System.Drawing.Point(18, 72)
        Me.lblocc.Name = "lblocc"
        Me.lblocc.Size = New System.Drawing.Size(72, 13)
        Me.lblocc.TabIndex = 27
        Me.lblocc.Text = "Occupation"
        '
        'txtffname
        '
        Me.txtffname.Location = New System.Drawing.Point(301, 36)
        Me.txtffname.Name = "txtffname"
        Me.txtffname.Size = New System.Drawing.Size(100, 23)
        Me.txtffname.TabIndex = 11
        '
        'lbllstnm
        '
        Me.lbllstnm.AutoSize = True
        Me.lbllstnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllstnm.Location = New System.Drawing.Point(313, 20)
        Me.lbllstnm.Name = "lbllstnm"
        Me.lbllstnm.Size = New System.Drawing.Size(66, 13)
        Me.lbllstnm.TabIndex = 26
        Me.lbllstnm.Text = "Father name"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(195, 36)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(100, 23)
        Me.txtfname.TabIndex = 10
        '
        'lblmidlnm
        '
        Me.lblmidlnm.AutoSize = True
        Me.lblmidlnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmidlnm.Location = New System.Drawing.Point(222, 20)
        Me.lblmidlnm.Name = "lblmidlnm"
        Me.lblmidlnm.Size = New System.Drawing.Size(35, 13)
        Me.lblmidlnm.TabIndex = 25
        Me.lblmidlnm.Text = "Name"
        '
        'txtoccupa
        '
        Me.txtoccupa.Location = New System.Drawing.Point(89, 69)
        Me.txtoccupa.Name = "txtoccupa"
        Me.txtoccupa.Size = New System.Drawing.Size(168, 23)
        Me.txtoccupa.TabIndex = 12
        '
        'lblfstname
        '
        Me.lblfstname.AutoSize = True
        Me.lblfstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfstname.Location = New System.Drawing.Point(122, 20)
        Me.lblfstname.Name = "lblfstname"
        Me.lblfstname.Size = New System.Drawing.Size(49, 13)
        Me.lblfstname.TabIndex = 24
        Me.lblfstname.Text = "Sruname"
        '
        'txtdesig
        '
        Me.txtdesig.Location = New System.Drawing.Point(89, 105)
        Me.txtdesig.Name = "txtdesig"
        Me.txtdesig.Size = New System.Drawing.Size(168, 23)
        Me.txtdesig.TabIndex = 13
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.Location = New System.Drawing.Point(2, 39)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(88, 13)
        Me.lblfname.TabIndex = 23
        Me.lblfname.Text = "Father's Name"
        '
        'txtfmobile
        '
        Me.txtfmobile.Location = New System.Drawing.Point(89, 142)
        Me.txtfmobile.Name = "txtfmobile"
        Me.txtfmobile.Size = New System.Drawing.Size(168, 23)
        Me.txtfmobile.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtfmobile)
        Me.GroupBox1.Controls.Add(Me.lblfname)
        Me.GroupBox1.Controls.Add(Me.txtdesig)
        Me.GroupBox1.Controls.Add(Me.lblfstname)
        Me.GroupBox1.Controls.Add(Me.txtoccupa)
        Me.GroupBox1.Controls.Add(Me.lblmidlnm)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.lbllstnm)
        Me.GroupBox1.Controls.Add(Me.txtffname)
        Me.GroupBox1.Controls.Add(Me.lblocc)
        Me.GroupBox1.Controls.Add(Me.txtfsname)
        Me.GroupBox1.Controls.Add(Me.lbldes)
        Me.GroupBox1.Controls.Add(Me.lblfmo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(395, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 173)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Father's Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Total Marks out of"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Passing Month and Year"
        '
        'txtmedium
        '
        Me.txtmedium.Location = New System.Drawing.Point(157, 52)
        Me.txtmedium.Name = "txtmedium"
        Me.txtmedium.Size = New System.Drawing.Size(100, 23)
        Me.txtmedium.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Total Marks with Practical"
        '
        'txtyear
        '
        Me.txtyear.Location = New System.Drawing.Point(157, 88)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(100, 23)
        Me.txtyear.TabIndex = 17
        '
        'lblper
        '
        Me.lblper.AutoSize = True
        Me.lblper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblper.Location = New System.Drawing.Point(224, 127)
        Me.lblper.Name = "lblper"
        Me.lblper.Size = New System.Drawing.Size(72, 13)
        Me.lblper.TabIndex = 32
        Me.lblper.Text = "Percentage"
        '
        'txtpractical
        '
        Me.txtpractical.Location = New System.Drawing.Point(157, 124)
        Me.txtpractical.Name = "txtpractical"
        Me.txtpractical.Size = New System.Drawing.Size(61, 23)
        Me.txtpractical.TabIndex = 18
        '
        'lblmed
        '
        Me.lblmed.AutoSize = True
        Me.lblmed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmed.Location = New System.Drawing.Point(105, 55)
        Me.lblmed.Name = "lblmed"
        Me.lblmed.Size = New System.Drawing.Size(50, 13)
        Me.lblmed.TabIndex = 31
        Me.lblmed.Text = "Medium"
        '
        'txtpercent
        '
        Me.txtpercent.Location = New System.Drawing.Point(295, 124)
        Me.txtpercent.Name = "txtpercent"
        Me.txtpercent.Size = New System.Drawing.Size(100, 23)
        Me.txtpercent.TabIndex = 19
        '
        'lblboard
        '
        Me.lblboard.AutoSize = True
        Me.lblboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblboard.Location = New System.Drawing.Point(115, 18)
        Me.lblboard.Name = "lblboard"
        Me.lblboard.Size = New System.Drawing.Size(40, 13)
        Me.lblboard.TabIndex = 30
        Me.lblboard.Text = "Board"
        '
        'txttot
        '
        Me.txttot.Location = New System.Drawing.Point(157, 161)
        Me.txttot.Name = "txttot"
        Me.txttot.Size = New System.Drawing.Size(100, 23)
        Me.txttot.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Number of Attempt"
        '
        'txtattamp
        '
        Me.txtattamp.Location = New System.Drawing.Point(157, 198)
        Me.txtattamp.Name = "txtattamp"
        Me.txtattamp.Size = New System.Drawing.Size(100, 23)
        Me.txtattamp.TabIndex = 21
        '
        'grpexam
        '
        Me.grpexam.BackColor = System.Drawing.Color.Transparent
        Me.grpexam.Controls.Add(Me.cmbboard)
        Me.grpexam.Controls.Add(Me.txtattamp)
        Me.grpexam.Controls.Add(Me.Label4)
        Me.grpexam.Controls.Add(Me.txttot)
        Me.grpexam.Controls.Add(Me.lblboard)
        Me.grpexam.Controls.Add(Me.txtpercent)
        Me.grpexam.Controls.Add(Me.lblmed)
        Me.grpexam.Controls.Add(Me.txtpractical)
        Me.grpexam.Controls.Add(Me.lblper)
        Me.grpexam.Controls.Add(Me.txtyear)
        Me.grpexam.Controls.Add(Me.Label1)
        Me.grpexam.Controls.Add(Me.txtmedium)
        Me.grpexam.Controls.Add(Me.Label2)
        Me.grpexam.Controls.Add(Me.Label3)
        Me.grpexam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpexam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpexam.Location = New System.Drawing.Point(395, 224)
        Me.grpexam.Name = "grpexam"
        Me.grpexam.Size = New System.Drawing.Size(405, 224)
        Me.grpexam.TabIndex = 53
        Me.grpexam.TabStop = False
        Me.grpexam.Text = "Details of Examination"
        '
        'cmbboard
        '
        Me.cmbboard.FormattingEnabled = True
        Me.cmbboard.Items.AddRange(New Object() {"GBSE", "CBSE"})
        Me.cmbboard.Location = New System.Drawing.Point(157, 15)
        Me.cmbboard.Name = "cmbboard"
        Me.cmbboard.Size = New System.Drawing.Size(121, 24)
        Me.cmbboard.TabIndex = 15
        '
        'btnnew
        '
        Me.btnnew.BackgroundImage = CType(resources.GetObject("btnnew.BackgroundImage"), System.Drawing.Image)
        Me.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.Maroon
        Me.btnnew.Location = New System.Drawing.Point(43, 22)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 35)
        Me.btnnew.TabIndex = 56
        Me.btnnew.Text = "New"
        Me.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.BackgroundImage = CType(resources.GetObject("btnedit.BackgroundImage"), System.Drawing.Image)
        Me.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.Maroon
        Me.btnedit.Location = New System.Drawing.Point(122, 22)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 34)
        Me.btnedit.TabIndex = 57
        Me.btnedit.Text = "Edit"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.BackgroundImage = CType(resources.GetObject("btnsave.BackgroundImage"), System.Drawing.Image)
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Maroon
        Me.btnsave.Location = New System.Drawing.Point(203, 22)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 33)
        Me.btnsave.TabIndex = 58
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.BackgroundImage = CType(resources.GetObject("btndelete.BackgroundImage"), System.Drawing.Image)
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Maroon
        Me.btndelete.Location = New System.Drawing.Point(280, 22)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 30)
        Me.btndelete.TabIndex = 59
        Me.btndelete.Text = "Delete"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Maroon
        Me.btnclose.Location = New System.Drawing.Point(11, 216)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 30)
        Me.btnclose.TabIndex = 60
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'grpoption
        '
        Me.grpoption.BackColor = System.Drawing.Color.Transparent
        Me.grpoption.Controls.Add(Me.btnclose)
        Me.grpoption.Controls.Add(Me.btndelete)
        Me.grpoption.Controls.Add(Me.btnnew)
        Me.grpoption.Controls.Add(Me.btnsave)
        Me.grpoption.Controls.Add(Me.btnedit)
        Me.grpoption.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpoption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpoption.Location = New System.Drawing.Point(408, 463)
        Me.grpoption.Name = "grpoption"
        Me.grpoption.Size = New System.Drawing.Size(380, 70)
        Me.grpoption.TabIndex = 61
        Me.grpoption.TabStop = False
        Me.grpoption.Text = "Option"
        '
        'ofdPhoto
        '
        Me.ofdPhoto.FileName = "OpenFileDialog1"
        '
        'grpimage
        '
        Me.grpimage.BackColor = System.Drawing.Color.Transparent
        Me.grpimage.Controls.Add(Me.btnUpload)
        Me.grpimage.Controls.Add(Me.ptustudent)
        Me.grpimage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpimage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpimage.Location = New System.Drawing.Point(828, 42)
        Me.grpimage.Name = "grpimage"
        Me.grpimage.Size = New System.Drawing.Size(115, 176)
        Me.grpimage.TabIndex = 62
        Me.grpimage.TabStop = False
        Me.grpimage.Text = "Image"
        '
        'ptustudent
        '
        Me.ptustudent.BackColor = System.Drawing.Color.White
        Me.ptustudent.Location = New System.Drawing.Point(6, 19)
        Me.ptustudent.Name = "ptustudent"
        Me.ptustudent.Size = New System.Drawing.Size(96, 110)
        Me.ptustudent.TabIndex = 54
        Me.ptustudent.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbarea)
        Me.GroupBox2.Controls.Add(Me.lblarea)
        Me.GroupBox2.Controls.Add(Me.lstsubject)
        Me.GroupBox2.Controls.Add(Me.cmbcourse)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblCourse)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(806, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 258)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Course Details"
        '
        'cmbarea
        '
        Me.cmbarea.FormattingEnabled = True
        Me.cmbarea.Items.AddRange(New Object() {"GBSE", "CBSE"})
        Me.cmbarea.Location = New System.Drawing.Point(83, 209)
        Me.cmbarea.Name = "cmbarea"
        Me.cmbarea.Size = New System.Drawing.Size(121, 24)
        Me.cmbarea.TabIndex = 36
        '
        'lblarea
        '
        Me.lblarea.AutoSize = True
        Me.lblarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblarea.Location = New System.Drawing.Point(36, 214)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(33, 13)
        Me.lblarea.TabIndex = 35
        Me.lblarea.Text = "Area"
        '
        'lstsubject
        '
        Me.lstsubject.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstsubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstsubject.Location = New System.Drawing.Point(83, 64)
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
        Me.cmbcourse.Location = New System.Drawing.Point(83, 24)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(121, 24)
        Me.cmbcourse.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Subject"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(23, 29)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(46, 13)
        Me.lblCourse.TabIndex = 31
        Me.lblCourse.Text = "Course"
        '
        'btnUpload
        '
        Me.btnUpload.BackgroundImage = Global.Proect_Work.My.Resources.Resources.ADD
        Me.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.Maroon
        Me.btnUpload.Location = New System.Drawing.Point(17, 134)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 34)
        Me.btnUpload.TabIndex = 62
        Me.btnUpload.Text = "Upload" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Photo"
        Me.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'STUDENT_MASTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.Proect_Work.My.Resources.Resources.akshay
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 553)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpimage)
        Me.Controls.Add(Me.grpoption)
        Me.Controls.Add(Me.grpexam)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpadd1)
        Me.Controls.Add(Me.lblHeader)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Name = "STUDENT_MASTER"
        Me.Text = "Course Details"
        Me.grpsex.ResumeLayout(False)
        Me.grpsex.PerformLayout()
        Me.grpadd1.ResumeLayout(False)
        Me.grpadd1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpexam.ResumeLayout(False)
        Me.grpexam.PerformLayout()
        Me.grpoption.ResumeLayout(False)
        Me.grpimage.ResumeLayout(False)
        CType(Me.ptustudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblbirth As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtrollid As System.Windows.Forms.TextBox
    Friend WithEvents lblmobile As System.Windows.Forms.Label
    Friend WithEvents lblphone As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents txtsurname As System.Windows.Forms.TextBox
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lbllastname As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents lblmidalname As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents lblfirstname As System.Windows.Forms.Label
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents txtmobile As System.Windows.Forms.TextBox
    Friend WithEvents lblrollno As System.Windows.Forms.Label
    Friend WithEvents grpsex As System.Windows.Forms.GroupBox
    Friend WithEvents rdofemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdomale As System.Windows.Forms.RadioButton
    Friend WithEvents txtfather As System.Windows.Forms.TextBox
    Friend WithEvents grpadd1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblfmo As System.Windows.Forms.Label
    Friend WithEvents lbldes As System.Windows.Forms.Label
    Friend WithEvents txtfsname As System.Windows.Forms.TextBox
    Friend WithEvents lblocc As System.Windows.Forms.Label
    Friend WithEvents txtffname As System.Windows.Forms.TextBox
    Friend WithEvents lbllstnm As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents lblmidlnm As System.Windows.Forms.Label
    Friend WithEvents txtoccupa As System.Windows.Forms.TextBox
    Friend WithEvents lblfstname As System.Windows.Forms.Label
    Friend WithEvents txtdesig As System.Windows.Forms.TextBox
    Friend WithEvents lblfname As System.Windows.Forms.Label
    Friend WithEvents txtfmobile As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpoption As System.Windows.Forms.GroupBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmedium As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtyear As System.Windows.Forms.TextBox
    Friend WithEvents lblper As System.Windows.Forms.Label
    Friend WithEvents txtpractical As System.Windows.Forms.TextBox
    Friend WithEvents lblmed As System.Windows.Forms.Label
    Friend WithEvents txtpercent As System.Windows.Forms.TextBox
    Friend WithEvents lblboard As System.Windows.Forms.Label
    Friend WithEvents txttot As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtattamp As System.Windows.Forms.TextBox
    Friend WithEvents grpexam As System.Windows.Forms.GroupBox
    Friend WithEvents cmbboard As System.Windows.Forms.ComboBox
    Friend WithEvents txtdb As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnserch As System.Windows.Forms.Button
    Friend WithEvents ofdPhoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grpimage As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents ptustudent As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbarea As System.Windows.Forms.ComboBox
    Friend WithEvents lblarea As System.Windows.Forms.Label
    Friend WithEvents lstsubject As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbcourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
End Class

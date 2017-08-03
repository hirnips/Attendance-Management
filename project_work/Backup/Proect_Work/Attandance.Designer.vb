<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attandance
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
        Me.lblrollno = New System.Windows.Forms.Label
        Me.txtrollno = New System.Windows.Forms.TextBox
        Me.cmbsubject = New System.Windows.Forms.ComboBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtcourse = New System.Windows.Forms.TextBox
        Me.lblstudnetname = New System.Windows.Forms.Label
        Me.btnlogin = New System.Windows.Forms.Button
        Me.btnLogout = New System.Windows.Forms.Button
        Me.lblcourcename = New System.Windows.Forms.Label
        Me.lblsubjectname = New System.Windows.Forms.Label
        Me.btnserch = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(134, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(164, 33)
        Me.lblHeader.TabIndex = 17
        Me.lblHeader.Text = "Attandance"
        '
        'lblrollno
        '
        Me.lblrollno.AutoSize = True
        Me.lblrollno.BackColor = System.Drawing.Color.Transparent
        Me.lblrollno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrollno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblrollno.Location = New System.Drawing.Point(76, 87)
        Me.lblrollno.Name = "lblrollno"
        Me.lblrollno.Size = New System.Drawing.Size(83, 13)
        Me.lblrollno.TabIndex = 18
        Me.lblrollno.Text = "Enter Roll No"
        '
        'txtrollno
        '
        Me.txtrollno.BackColor = System.Drawing.Color.White
        Me.txtrollno.Location = New System.Drawing.Point(192, 84)
        Me.txtrollno.Name = "txtrollno"
        Me.txtrollno.Size = New System.Drawing.Size(121, 20)
        Me.txtrollno.TabIndex = 1
        '
        'cmbsubject
        '
        Me.cmbsubject.FormattingEnabled = True
        Me.cmbsubject.Location = New System.Drawing.Point(192, 192)
        Me.cmbsubject.Name = "cmbsubject"
        Me.cmbsubject.Size = New System.Drawing.Size(121, 21)
        Me.cmbsubject.TabIndex = 4
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.Location = New System.Drawing.Point(192, 119)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(121, 20)
        Me.txtname.TabIndex = 2
        '
        'txtcourse
        '
        Me.txtcourse.BackColor = System.Drawing.Color.White
        Me.txtcourse.Location = New System.Drawing.Point(192, 156)
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.Size = New System.Drawing.Size(121, 20)
        Me.txtcourse.TabIndex = 3
        '
        'lblstudnetname
        '
        Me.lblstudnetname.AutoSize = True
        Me.lblstudnetname.BackColor = System.Drawing.Color.Transparent
        Me.lblstudnetname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudnetname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblstudnetname.Location = New System.Drawing.Point(38, 122)
        Me.lblstudnetname.Name = "lblstudnetname"
        Me.lblstudnetname.Size = New System.Drawing.Size(121, 13)
        Me.lblstudnetname.TabIndex = 23
        Me.lblstudnetname.Text = "Enter Student Name"
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.Maroon
        Me.btnlogin.Location = New System.Drawing.Point(109, 234)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 23)
        Me.btnlogin.TabIndex = 5
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Maroon
        Me.btnLogout.Location = New System.Drawing.Point(197, 234)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblcourcename
        '
        Me.lblcourcename.AutoSize = True
        Me.lblcourcename.BackColor = System.Drawing.Color.Transparent
        Me.lblcourcename.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcourcename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcourcename.Location = New System.Drawing.Point(43, 159)
        Me.lblcourcename.Name = "lblcourcename"
        Me.lblcourcename.Size = New System.Drawing.Size(116, 13)
        Me.lblcourcename.TabIndex = 30
        Me.lblcourcename.Text = "Enter Course Name"
        '
        'lblsubjectname
        '
        Me.lblsubjectname.AutoSize = True
        Me.lblsubjectname.BackColor = System.Drawing.Color.Transparent
        Me.lblsubjectname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubjectname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblsubjectname.Location = New System.Drawing.Point(38, 195)
        Me.lblsubjectname.Name = "lblsubjectname"
        Me.lblsubjectname.Size = New System.Drawing.Size(120, 13)
        Me.lblsubjectname.TabIndex = 31
        Me.lblsubjectname.Text = "Enter Subject Name"
        '
        'btnserch
        '
        Me.btnserch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnserch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnserch.ForeColor = System.Drawing.Color.DarkRed
        Me.btnserch.Location = New System.Drawing.Point(328, 77)
        Me.btnserch.Name = "btnserch"
        Me.btnserch.Size = New System.Drawing.Size(81, 32)
        Me.btnserch.TabIndex = 8
        Me.btnserch.Text = "Search"
        Me.btnserch.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Maroon
        Me.btnclose.Location = New System.Drawing.Point(286, 234)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 7
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Attandance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proect_Work.My.Resources.Resources.Backgound
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(444, 291)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnserch)
        Me.Controls.Add(Me.lblsubjectname)
        Me.Controls.Add(Me.lblcourcename)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.lblstudnetname)
        Me.Controls.Add(Me.txtcourse)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.cmbsubject)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblrollno)
        Me.Controls.Add(Me.txtrollno)
        Me.Name = "Attandance"
        Me.Text = "Attandance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblrollno As System.Windows.Forms.Label
    Friend WithEvents txtrollno As System.Windows.Forms.TextBox
    Friend WithEvents cmbsubject As System.Windows.Forms.ComboBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtcourse As System.Windows.Forms.TextBox
    Friend WithEvents lblstudnetname As System.Windows.Forms.Label
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents lblcourcename As System.Windows.Forms.Label
    Friend WithEvents lblsubjectname As System.Windows.Forms.Label
    Friend WithEvents btnserch As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class

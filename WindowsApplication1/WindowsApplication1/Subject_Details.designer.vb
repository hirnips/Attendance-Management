<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subject_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Subject_Details))
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lblcoursename = New System.Windows.Forms.Label
        Me.lblcourseid = New System.Windows.Forms.Label
        Me.lblsubjectname = New System.Windows.Forms.Label
        Me.lblsubjectdes = New System.Windows.Forms.Label
        Me.cmbCourseName = New System.Windows.Forms.ComboBox
        Me.txtSubjectName = New System.Windows.Forms.TextBox
        Me.grpoption = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.lstSubject = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.txtSubjectDescription = New System.Windows.Forms.TextBox
        Me.cmbSubjectId = New System.Windows.Forms.ComboBox
        Me.grpoption.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(250, 3)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(213, 33)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Subject Details"
        '
        'lblcoursename
        '
        Me.lblcoursename.AutoSize = True
        Me.lblcoursename.BackColor = System.Drawing.Color.Transparent
        Me.lblcoursename.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoursename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcoursename.Location = New System.Drawing.Point(35, 65)
        Me.lblcoursename.Name = "lblcoursename"
        Me.lblcoursename.Size = New System.Drawing.Size(105, 17)
        Me.lblcoursename.TabIndex = 1
        Me.lblcoursename.Text = "Course Name"
        '
        'lblcourseid
        '
        Me.lblcourseid.AutoSize = True
        Me.lblcourseid.BackColor = System.Drawing.Color.Transparent
        Me.lblcourseid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcourseid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcourseid.Location = New System.Drawing.Point(392, 64)
        Me.lblcourseid.Name = "lblcourseid"
        Me.lblcourseid.Size = New System.Drawing.Size(82, 17)
        Me.lblcourseid.TabIndex = 2
        Me.lblcourseid.Text = "Subject ID"
        '
        'lblsubjectname
        '
        Me.lblsubjectname.AutoSize = True
        Me.lblsubjectname.BackColor = System.Drawing.Color.Transparent
        Me.lblsubjectname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubjectname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblsubjectname.Location = New System.Drawing.Point(32, 110)
        Me.lblsubjectname.Name = "lblsubjectname"
        Me.lblsubjectname.Size = New System.Drawing.Size(108, 17)
        Me.lblsubjectname.TabIndex = 3
        Me.lblsubjectname.Text = "Subject Name"
        '
        'lblsubjectdes
        '
        Me.lblsubjectdes.AutoSize = True
        Me.lblsubjectdes.BackColor = System.Drawing.Color.Transparent
        Me.lblsubjectdes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubjectdes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblsubjectdes.Location = New System.Drawing.Point(325, 112)
        Me.lblsubjectdes.Name = "lblsubjectdes"
        Me.lblsubjectdes.Size = New System.Drawing.Size(149, 17)
        Me.lblsubjectdes.TabIndex = 4
        Me.lblsubjectdes.Text = "Subject Description"
        '
        'cmbCourseName
        '
        Me.cmbCourseName.FormattingEnabled = True
        Me.cmbCourseName.Location = New System.Drawing.Point(146, 64)
        Me.cmbCourseName.Name = "cmbCourseName"
        Me.cmbCourseName.Size = New System.Drawing.Size(149, 21)
        Me.cmbCourseName.TabIndex = 5
        '
        'txtSubjectName
        '
        Me.txtSubjectName.Location = New System.Drawing.Point(146, 109)
        Me.txtSubjectName.Name = "txtSubjectName"
        Me.txtSubjectName.Size = New System.Drawing.Size(149, 20)
        Me.txtSubjectName.TabIndex = 7
        '
        'grpoption
        '
        Me.grpoption.BackColor = System.Drawing.Color.Transparent
        Me.grpoption.Controls.Add(Me.btnClose)
        Me.grpoption.Controls.Add(Me.btnNew)
        Me.grpoption.Controls.Add(Me.btndelete)
        Me.grpoption.Controls.Add(Me.btnedit)
        Me.grpoption.Controls.Add(Me.btnsave)
        Me.grpoption.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpoption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpoption.Location = New System.Drawing.Point(160, 169)
        Me.grpoption.Name = "grpoption"
        Me.grpoption.Size = New System.Drawing.Size(414, 65)
        Me.grpoption.TabIndex = 69
        Me.grpoption.TabStop = False
        Me.grpoption.Text = "Option"
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Maroon
        Me.btnClose.Location = New System.Drawing.Point(330, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 33)
        Me.btnClose.TabIndex = 60
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.BackgroundImage = CType(resources.GetObject("btnNew.BackgroundImage"), System.Drawing.Image)
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Maroon
        Me.btnNew.Location = New System.Drawing.Point(6, 19)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 34)
        Me.btnNew.TabIndex = 56
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.BackgroundImage = CType(resources.GetObject("btndelete.BackgroundImage"), System.Drawing.Image)
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Maroon
        Me.btndelete.Location = New System.Drawing.Point(249, 19)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 33)
        Me.btndelete.TabIndex = 59
        Me.btndelete.Text = "Delete"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.BackgroundImage = CType(resources.GetObject("btnedit.BackgroundImage"), System.Drawing.Image)
        Me.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.Maroon
        Me.btnedit.Location = New System.Drawing.Point(87, 19)
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
        Me.btnsave.Location = New System.Drawing.Point(168, 19)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 33)
        Me.btnsave.TabIndex = 58
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'lstSubject
        '
        Me.lstSubject.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstSubject.GridLines = True
        Me.lstSubject.Location = New System.Drawing.Point(12, 247)
        Me.lstSubject.Name = "lstSubject"
        Me.lstSubject.Size = New System.Drawing.Size(736, 208)
        Me.lstSubject.TabIndex = 70
        Me.lstSubject.UseCompatibleStateImageBehavior = False
        Me.lstSubject.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "C_Name"
        Me.ColumnHeader1.Width = 108
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "S_ID"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "S_Name"
        Me.ColumnHeader3.Width = 137
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "S_Des"
        '
        'txtSubjectDescription
        '
        Me.txtSubjectDescription.Location = New System.Drawing.Point(490, 107)
        Me.txtSubjectDescription.Multiline = True
        Me.txtSubjectDescription.Name = "txtSubjectDescription"
        Me.txtSubjectDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSubjectDescription.Size = New System.Drawing.Size(161, 56)
        Me.txtSubjectDescription.TabIndex = 72
        '
        'cmbSubjectId
        '
        Me.cmbSubjectId.FormattingEnabled = True
        Me.cmbSubjectId.Location = New System.Drawing.Point(490, 64)
        Me.cmbSubjectId.Name = "cmbSubjectId"
        Me.cmbSubjectId.Size = New System.Drawing.Size(161, 21)
        Me.cmbSubjectId.TabIndex = 73
        '
        'Subject_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(760, 502)
        Me.Controls.Add(Me.cmbSubjectId)
        Me.Controls.Add(Me.txtSubjectDescription)
        Me.Controls.Add(Me.lstSubject)
        Me.Controls.Add(Me.grpoption)
        Me.Controls.Add(Me.txtSubjectName)
        Me.Controls.Add(Me.cmbCourseName)
        Me.Controls.Add(Me.lblsubjectdes)
        Me.Controls.Add(Me.lblsubjectname)
        Me.Controls.Add(Me.lblcourseid)
        Me.Controls.Add(Me.lblcoursename)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Subject_Details"
        Me.Text = "Subject_Details"
        Me.grpoption.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblcoursename As System.Windows.Forms.Label
    Friend WithEvents lblcourseid As System.Windows.Forms.Label
    Friend WithEvents lblsubjectname As System.Windows.Forms.Label
    Friend WithEvents lblsubjectdes As System.Windows.Forms.Label
    Friend WithEvents cmbCourseName As System.Windows.Forms.ComboBox
    Friend WithEvents txtSubjectName As System.Windows.Forms.TextBox
    Friend WithEvents grpoption As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents lstSubject As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSubjectDescription As System.Windows.Forms.TextBox
    Friend WithEvents cmbSubjectId As System.Windows.Forms.ComboBox
End Class

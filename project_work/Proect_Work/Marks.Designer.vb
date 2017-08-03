<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Marks))
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lblcourseID = New System.Windows.Forms.Label
        Me.lblSubjectId = New System.Windows.Forms.Label
        Me.lblRollNo = New System.Windows.Forms.Label
        Me.CmbCourseId = New System.Windows.Forms.ComboBox
        Me.cmbSubjectId = New System.Windows.Forms.ComboBox
        Me.cmbRollNo = New System.Windows.Forms.ComboBox
        Me.lblMarks = New System.Windows.Forms.Label
        Me.txtMarks = New System.Windows.Forms.TextBox
        Me.grpoption = New System.Windows.Forms.GroupBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnInsert = New System.Windows.Forms.Button
        Me.lstvMarksInput = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.grpoption.SuspendLayout()
        Me.SuspendLayout()
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
        Me.lblHeader.Location = New System.Drawing.Point(249, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(169, 33)
        Me.lblHeader.TabIndex = 76
        Me.lblHeader.Text = "Marks Input"
        '
        'lblcourseID
        '
        Me.lblcourseID.AutoSize = True
        Me.lblcourseID.BackColor = System.Drawing.Color.Transparent
        Me.lblcourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcourseID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcourseID.Location = New System.Drawing.Point(22, 86)
        Me.lblcourseID.Name = "lblcourseID"
        Me.lblcourseID.Size = New System.Drawing.Size(67, 13)
        Me.lblcourseID.TabIndex = 77
        Me.lblcourseID.Text = "CourseID:-"
        '
        'lblSubjectId
        '
        Me.lblSubjectId.AutoSize = True
        Me.lblSubjectId.BackColor = System.Drawing.Color.Transparent
        Me.lblSubjectId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSubjectId.Location = New System.Drawing.Point(250, 86)
        Me.lblSubjectId.Name = "lblSubjectId"
        Me.lblSubjectId.Size = New System.Drawing.Size(69, 13)
        Me.lblSubjectId.TabIndex = 78
        Me.lblSubjectId.Text = "SubjectId:-"
        '
        'lblRollNo
        '
        Me.lblRollNo.AutoSize = True
        Me.lblRollNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRollNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRollNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRollNo.Location = New System.Drawing.Point(468, 86)
        Me.lblRollNo.Name = "lblRollNo"
        Me.lblRollNo.Size = New System.Drawing.Size(53, 13)
        Me.lblRollNo.TabIndex = 79
        Me.lblRollNo.Text = "RollNo:-"
        '
        'CmbCourseId
        '
        Me.CmbCourseId.FormattingEnabled = True
        Me.CmbCourseId.Location = New System.Drawing.Point(95, 83)
        Me.CmbCourseId.Name = "CmbCourseId"
        Me.CmbCourseId.Size = New System.Drawing.Size(121, 21)
        Me.CmbCourseId.TabIndex = 1
        '
        'cmbSubjectId
        '
        Me.cmbSubjectId.FormattingEnabled = True
        Me.cmbSubjectId.Location = New System.Drawing.Point(325, 83)
        Me.cmbSubjectId.Name = "cmbSubjectId"
        Me.cmbSubjectId.Size = New System.Drawing.Size(121, 21)
        Me.cmbSubjectId.TabIndex = 2
        '
        'cmbRollNo
        '
        Me.cmbRollNo.FormattingEnabled = True
        Me.cmbRollNo.Location = New System.Drawing.Point(527, 83)
        Me.cmbRollNo.Name = "cmbRollNo"
        Me.cmbRollNo.Size = New System.Drawing.Size(121, 21)
        Me.cmbRollNo.TabIndex = 3
        '
        'lblMarks
        '
        Me.lblMarks.AutoSize = True
        Me.lblMarks.BackColor = System.Drawing.Color.Transparent
        Me.lblMarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMarks.Location = New System.Drawing.Point(40, 139)
        Me.lblMarks.Name = "lblMarks"
        Me.lblMarks.Size = New System.Drawing.Size(49, 13)
        Me.lblMarks.TabIndex = 83
        Me.lblMarks.Text = "Marks:-"
        '
        'txtMarks
        '
        Me.txtMarks.Location = New System.Drawing.Point(95, 136)
        Me.txtMarks.Name = "txtMarks"
        Me.txtMarks.Size = New System.Drawing.Size(121, 20)
        Me.txtMarks.TabIndex = 4
        '
        'grpoption
        '
        Me.grpoption.BackColor = System.Drawing.Color.Transparent
        Me.grpoption.Controls.Add(Me.btnDelete)
        Me.grpoption.Controls.Add(Me.btnUpdate)
        Me.grpoption.Controls.Add(Me.btnClose)
        Me.grpoption.Controls.Add(Me.btnInsert)
        Me.grpoption.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpoption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpoption.Location = New System.Drawing.Point(253, 110)
        Me.grpoption.Name = "grpoption"
        Me.grpoption.Size = New System.Drawing.Size(342, 65)
        Me.grpoption.TabIndex = 85
        Me.grpoption.TabStop = False
        Me.grpoption.Text = "Option"
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Maroon
        Me.btnDelete.Location = New System.Drawing.Point(174, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 33)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Maroon
        Me.btnUpdate.Location = New System.Drawing.Point(93, 19)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 34)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Edit"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Maroon
        Me.btnClose.Location = New System.Drawing.Point(255, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 33)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.BackgroundImage = CType(resources.GetObject("btnInsert.BackgroundImage"), System.Drawing.Image)
        Me.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.Maroon
        Me.btnInsert.Location = New System.Drawing.Point(12, 19)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 33)
        Me.btnInsert.TabIndex = 5
        Me.btnInsert.Text = "Save"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'lstvMarksInput
        '
        Me.lstvMarksInput.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstvMarksInput.GridLines = True
        Me.lstvMarksInput.Location = New System.Drawing.Point(12, 197)
        Me.lstvMarksInput.Name = "lstvMarksInput"
        Me.lstvMarksInput.Size = New System.Drawing.Size(643, 243)
        Me.lstvMarksInput.TabIndex = 9
        Me.lstvMarksInput.UseCompatibleStateImageBehavior = False
        Me.lstvMarksInput.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CourseId"
        Me.ColumnHeader1.Width = 91
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "SubjectId"
        Me.ColumnHeader2.Width = 93
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "RollNo"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Marks"
        Me.ColumnHeader4.Width = 100
        '
        'Marks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proect_Work.My.Resources.Resources.Backgound
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(667, 487)
        Me.Controls.Add(Me.lstvMarksInput)
        Me.Controls.Add(Me.grpoption)
        Me.Controls.Add(Me.txtMarks)
        Me.Controls.Add(Me.lblMarks)
        Me.Controls.Add(Me.cmbRollNo)
        Me.Controls.Add(Me.cmbSubjectId)
        Me.Controls.Add(Me.CmbCourseId)
        Me.Controls.Add(Me.lblRollNo)
        Me.Controls.Add(Me.lblSubjectId)
        Me.Controls.Add(Me.lblcourseID)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Marks"
        Me.Text = "Marks"
        Me.grpoption.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblcourseID As System.Windows.Forms.Label
    Friend WithEvents lblSubjectId As System.Windows.Forms.Label
    Friend WithEvents lblRollNo As System.Windows.Forms.Label
    Friend WithEvents CmbCourseId As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubjectId As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRollNo As System.Windows.Forms.ComboBox
    Friend WithEvents lblMarks As System.Windows.Forms.Label
    Friend WithEvents txtMarks As System.Windows.Forms.TextBox
    Friend WithEvents grpoption As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents lstvMarksInput As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class

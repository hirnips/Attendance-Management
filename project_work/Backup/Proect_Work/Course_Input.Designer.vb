<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Course_Input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Course_Input))
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lblcourseid = New System.Windows.Forms.Label
        Me.lblcourcename = New System.Windows.Forms.Label
        Me.lbldescription = New System.Windows.Forms.Label
        Me.txtcoursename = New System.Windows.Forms.TextBox
        Me.grpoption = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnInsert = New System.Windows.Forms.Button
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.lstCourse = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.txtCid = New System.Windows.Forms.TextBox
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
        Me.lblHeader.Location = New System.Drawing.Point(256, 2)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(184, 33)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Course Input"
        '
        'lblcourseid
        '
        Me.lblcourseid.AutoSize = True
        Me.lblcourseid.BackColor = System.Drawing.Color.Transparent
        Me.lblcourseid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcourseid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcourseid.Location = New System.Drawing.Point(75, 52)
        Me.lblcourseid.Name = "lblcourseid"
        Me.lblcourseid.Size = New System.Drawing.Size(79, 17)
        Me.lblcourseid.TabIndex = 1
        Me.lblcourseid.Text = "Course ID"
        '
        'lblcourcename
        '
        Me.lblcourcename.AutoSize = True
        Me.lblcourcename.BackColor = System.Drawing.Color.Transparent
        Me.lblcourcename.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcourcename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcourcename.Location = New System.Drawing.Point(326, 55)
        Me.lblcourcename.Name = "lblcourcename"
        Me.lblcourcename.Size = New System.Drawing.Size(105, 17)
        Me.lblcourcename.TabIndex = 2
        Me.lblcourcename.Text = "Course Name"
        '
        'lbldescription
        '
        Me.lbldescription.AutoSize = True
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbldescription.Location = New System.Drawing.Point(8, 134)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(146, 17)
        Me.lbldescription.TabIndex = 3
        Me.lbldescription.Text = "Course Description"
        '
        'txtcoursename
        '
        Me.txtcoursename.Location = New System.Drawing.Point(437, 54)
        Me.txtcoursename.Name = "txtcoursename"
        Me.txtcoursename.Size = New System.Drawing.Size(139, 20)
        Me.txtcoursename.TabIndex = 2
        '
        'grpoption
        '
        Me.grpoption.BackColor = System.Drawing.Color.Transparent
        Me.grpoption.Controls.Add(Me.btnClose)
        Me.grpoption.Controls.Add(Me.btnNew)
        Me.grpoption.Controls.Add(Me.btnDelete)
        Me.grpoption.Controls.Add(Me.btnUpdate)
        Me.grpoption.Controls.Add(Me.btnInsert)
        Me.grpoption.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpoption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpoption.Location = New System.Drawing.Point(144, 192)
        Me.grpoption.Name = "grpoption"
        Me.grpoption.Size = New System.Drawing.Size(414, 65)
        Me.grpoption.TabIndex = 68
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
        Me.btnClose.TabIndex = 8
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
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Maroon
        Me.btnDelete.Location = New System.Drawing.Point(249, 19)
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
        Me.btnUpdate.Location = New System.Drawing.Point(87, 19)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 34)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Edit"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.BackgroundImage = CType(resources.GetObject("btnInsert.BackgroundImage"), System.Drawing.Image)
        Me.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.Maroon
        Me.btnInsert.Location = New System.Drawing.Point(168, 19)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 33)
        Me.btnInsert.TabIndex = 6
        Me.btnInsert.Text = "Save"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(160, 103)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(344, 83)
        Me.txtDescription.TabIndex = 3
        '
        'lstCourse
        '
        Me.lstCourse.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCourse.FullRowSelect = True
        Me.lstCourse.GridLines = True
        Me.lstCourse.Location = New System.Drawing.Point(12, 263)
        Me.lstCourse.Name = "lstCourse"
        Me.lstCourse.Size = New System.Drawing.Size(670, 194)
        Me.lstCourse.TabIndex = 9
        Me.lstCourse.UseCompatibleStateImageBehavior = False
        Me.lstCourse.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CourseId"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "CourseName"
        Me.ColumnHeader2.Width = 183
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Discription"
        Me.ColumnHeader3.Width = 384
        '
        'txtCid
        '
        Me.txtCid.Location = New System.Drawing.Point(160, 51)
        Me.txtCid.Name = "txtCid"
        Me.txtCid.Size = New System.Drawing.Size(100, 20)
        Me.txtCid.TabIndex = 1
        '
        'Course_Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proect_Work.My.Resources.Resources.Backgound
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(691, 501)
        Me.Controls.Add(Me.txtCid)
        Me.Controls.Add(Me.lstCourse)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.grpoption)
        Me.Controls.Add(Me.txtcoursename)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.lblcourcename)
        Me.Controls.Add(Me.lblcourseid)
        Me.Controls.Add(Me.lblHeader)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Course_Input"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course_Input"
        Me.grpoption.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblcourseid As System.Windows.Forms.Label
    Friend WithEvents lblcourcename As System.Windows.Forms.Label
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents txtcoursename As System.Windows.Forms.TextBox
    Friend WithEvents grpoption As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lstCourse As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtCid As System.Windows.Forms.TextBox
End Class

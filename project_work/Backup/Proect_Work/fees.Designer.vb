<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fees))
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lblCourseName = New System.Windows.Forms.Label
        Me.lblSubjectName = New System.Windows.Forms.Label
        Me.lblEnterAmount = New System.Windows.Forms.Label
        Me.cmbCourseName = New System.Windows.Forms.ComboBox
        Me.cmbSubjectname = New System.Windows.Forms.ComboBox
        Me.txtEnterAmount = New System.Windows.Forms.TextBox
        Me.lstvFees = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.grpoption = New System.Windows.Forms.GroupBox
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
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
        Me.lblHeader.Location = New System.Drawing.Point(245, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(155, 33)
        Me.lblHeader.TabIndex = 18
        Me.lblHeader.Text = "Fees Input"
        '
        'lblCourseName
        '
        Me.lblCourseName.AutoSize = True
        Me.lblCourseName.BackColor = System.Drawing.Color.Transparent
        Me.lblCourseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCourseName.Location = New System.Drawing.Point(35, 69)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(86, 13)
        Me.lblCourseName.TabIndex = 19
        Me.lblCourseName.Text = "Course Name:"
        '
        'lblSubjectName
        '
        Me.lblSubjectName.AutoSize = True
        Me.lblSubjectName.BackColor = System.Drawing.Color.Transparent
        Me.lblSubjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSubjectName.Location = New System.Drawing.Point(31, 101)
        Me.lblSubjectName.Name = "lblSubjectName"
        Me.lblSubjectName.Size = New System.Drawing.Size(90, 13)
        Me.lblSubjectName.TabIndex = 20
        Me.lblSubjectName.Text = "Subject Name:"
        '
        'lblEnterAmount
        '
        Me.lblEnterAmount.AutoSize = True
        Me.lblEnterAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblEnterAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEnterAmount.Location = New System.Drawing.Point(31, 133)
        Me.lblEnterAmount.Name = "lblEnterAmount"
        Me.lblEnterAmount.Size = New System.Drawing.Size(87, 13)
        Me.lblEnterAmount.TabIndex = 21
        Me.lblEnterAmount.Text = "Enter Amount:"
        '
        'cmbCourseName
        '
        Me.cmbCourseName.FormattingEnabled = True
        Me.cmbCourseName.Location = New System.Drawing.Point(127, 66)
        Me.cmbCourseName.Name = "cmbCourseName"
        Me.cmbCourseName.Size = New System.Drawing.Size(121, 21)
        Me.cmbCourseName.TabIndex = 22
        '
        'cmbSubjectname
        '
        Me.cmbSubjectname.FormattingEnabled = True
        Me.cmbSubjectname.Location = New System.Drawing.Point(127, 98)
        Me.cmbSubjectname.Name = "cmbSubjectname"
        Me.cmbSubjectname.Size = New System.Drawing.Size(121, 21)
        Me.cmbSubjectname.TabIndex = 23
        '
        'txtEnterAmount
        '
        Me.txtEnterAmount.Location = New System.Drawing.Point(127, 130)
        Me.txtEnterAmount.Name = "txtEnterAmount"
        Me.txtEnterAmount.Size = New System.Drawing.Size(121, 20)
        Me.txtEnterAmount.TabIndex = 24
        '
        'lstvFees
        '
        Me.lstvFees.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstvFees.GridLines = True
        Me.lstvFees.Location = New System.Drawing.Point(12, 173)
        Me.lstvFees.Name = "lstvFees"
        Me.lstvFees.Size = New System.Drawing.Size(665, 250)
        Me.lstvFees.TabIndex = 25
        Me.lstvFees.UseCompatibleStateImageBehavior = False
        Me.lstvFees.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Course Name"
        Me.ColumnHeader1.Width = 184
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Subject Name"
        Me.ColumnHeader2.Width = 278
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Subject Fees"
        Me.ColumnHeader3.Width = 188
        '
        'grpoption
        '
        Me.grpoption.BackColor = System.Drawing.Color.Transparent
        Me.grpoption.Controls.Add(Me.btnclose)
        Me.grpoption.Controls.Add(Me.btnUpdate)
        Me.grpoption.Controls.Add(Me.btnNew)
        Me.grpoption.Controls.Add(Me.btnDelete)
        Me.grpoption.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpoption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpoption.Location = New System.Drawing.Point(281, 69)
        Me.grpoption.Name = "grpoption"
        Me.grpoption.Size = New System.Drawing.Size(330, 65)
        Me.grpoption.TabIndex = 78
        Me.grpoption.TabStop = False
        Me.grpoption.Text = "Option"
        '
        'btnclose
        '
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Maroon
        Me.btnclose.Location = New System.Drawing.Point(249, 24)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 30)
        Me.btnclose.TabIndex = 62
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Maroon
        Me.btnUpdate.Location = New System.Drawing.Point(87, 22)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 34)
        Me.btnUpdate.TabIndex = 61
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.BackgroundImage = CType(resources.GetObject("btnNew.BackgroundImage"), System.Drawing.Image)
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Maroon
        Me.btnNew.Location = New System.Drawing.Point(6, 22)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 34)
        Me.btnNew.TabIndex = 56
        Me.btnNew.Text = "Insert"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Maroon
        Me.btnDelete.Location = New System.Drawing.Point(168, 23)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 33)
        Me.btnDelete.TabIndex = 59
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'fees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proect_Work.My.Resources.Resources.akshay
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(688, 440)
        Me.Controls.Add(Me.grpoption)
        Me.Controls.Add(Me.lstvFees)
        Me.Controls.Add(Me.txtEnterAmount)
        Me.Controls.Add(Me.cmbSubjectname)
        Me.Controls.Add(Me.cmbCourseName)
        Me.Controls.Add(Me.lblEnterAmount)
        Me.Controls.Add(Me.lblSubjectName)
        Me.Controls.Add(Me.lblCourseName)
        Me.Controls.Add(Me.lblHeader)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Name = "fees"
        Me.Text = "Fees"
        Me.grpoption.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblCourseName As System.Windows.Forms.Label
    Friend WithEvents lblSubjectName As System.Windows.Forms.Label
    Friend WithEvents lblEnterAmount As System.Windows.Forms.Label
    Friend WithEvents cmbCourseName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubjectname As System.Windows.Forms.ComboBox
    Friend WithEvents txtEnterAmount As System.Windows.Forms.TextBox
    Friend WithEvents lstvFees As System.Windows.Forms.ListView
    Friend WithEvents grpoption As System.Windows.Forms.GroupBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class

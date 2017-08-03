<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentFeesInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentFeesInput))
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lblCourseName = New System.Windows.Forms.Label
        Me.lblSubjectName = New System.Windows.Forms.Label
        Me.lblStudentName = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblPaidAmount = New System.Windows.Forms.Label
        Me.cmbCourseName = New System.Windows.Forms.ComboBox
        Me.cmbSubjectName = New System.Windows.Forms.ComboBox
        Me.cmbStudentName = New System.Windows.Forms.ComboBox
        Me.lblTotsubfee = New System.Windows.Forms.Label
        Me.txtPaidamount = New System.Windows.Forms.TextBox
        Me.grpoption = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnInsert = New System.Windows.Forms.Button
        Me.lstvSFees = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
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
        Me.lblHeader.Location = New System.Drawing.Point(125, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(336, 33)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Student Wise Fees Input"
        '
        'lblCourseName
        '
        Me.lblCourseName.AutoSize = True
        Me.lblCourseName.BackColor = System.Drawing.Color.Transparent
        Me.lblCourseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCourseName.Location = New System.Drawing.Point(59, 93)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(116, 17)
        Me.lblCourseName.TabIndex = 2
        Me.lblCourseName.Text = "Course Name:-"
        '
        'lblSubjectName
        '
        Me.lblSubjectName.AutoSize = True
        Me.lblSubjectName.BackColor = System.Drawing.Color.Transparent
        Me.lblSubjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSubjectName.Location = New System.Drawing.Point(346, 94)
        Me.lblSubjectName.Name = "lblSubjectName"
        Me.lblSubjectName.Size = New System.Drawing.Size(119, 17)
        Me.lblSubjectName.TabIndex = 3
        Me.lblSubjectName.Text = "Subject Name:-"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStudentName.Location = New System.Drawing.Point(54, 122)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(121, 17)
        Me.lblStudentName.TabIndex = 4
        Me.lblStudentName.Text = "Student Name:-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(24, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Subject fees:-"
        '
        'lblPaidAmount
        '
        Me.lblPaidAmount.AutoSize = True
        Me.lblPaidAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblPaidAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaidAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPaidAmount.Location = New System.Drawing.Point(346, 125)
        Me.lblPaidAmount.Name = "lblPaidAmount"
        Me.lblPaidAmount.Size = New System.Drawing.Size(110, 17)
        Me.lblPaidAmount.TabIndex = 6
        Me.lblPaidAmount.Text = "Paid Amount:-"
        '
        'cmbCourseName
        '
        Me.cmbCourseName.FormattingEnabled = True
        Me.cmbCourseName.Location = New System.Drawing.Point(181, 92)
        Me.cmbCourseName.Name = "cmbCourseName"
        Me.cmbCourseName.Size = New System.Drawing.Size(121, 21)
        Me.cmbCourseName.TabIndex = 7
        '
        'cmbSubjectName
        '
        Me.cmbSubjectName.FormattingEnabled = True
        Me.cmbSubjectName.Location = New System.Drawing.Point(471, 93)
        Me.cmbSubjectName.Name = "cmbSubjectName"
        Me.cmbSubjectName.Size = New System.Drawing.Size(121, 21)
        Me.cmbSubjectName.TabIndex = 8
        '
        'cmbStudentName
        '
        Me.cmbStudentName.FormattingEnabled = True
        Me.cmbStudentName.Location = New System.Drawing.Point(181, 121)
        Me.cmbStudentName.Name = "cmbStudentName"
        Me.cmbStudentName.Size = New System.Drawing.Size(121, 21)
        Me.cmbStudentName.TabIndex = 9
        '
        'lblTotsubfee
        '
        Me.lblTotsubfee.BackColor = System.Drawing.Color.Transparent
        Me.lblTotsubfee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotsubfee.ForeColor = System.Drawing.Color.White
        Me.lblTotsubfee.Location = New System.Drawing.Point(178, 154)
        Me.lblTotsubfee.Name = "lblTotsubfee"
        Me.lblTotsubfee.Size = New System.Drawing.Size(124, 13)
        Me.lblTotsubfee.TabIndex = 10
        '
        'txtPaidamount
        '
        Me.txtPaidamount.Location = New System.Drawing.Point(471, 124)
        Me.txtPaidamount.Name = "txtPaidamount"
        Me.txtPaidamount.Size = New System.Drawing.Size(121, 20)
        Me.txtPaidamount.TabIndex = 11
        '
        'grpoption
        '
        Me.grpoption.BackColor = System.Drawing.Color.Transparent
        Me.grpoption.Controls.Add(Me.btnClose)
        Me.grpoption.Controls.Add(Me.btnInsert)
        Me.grpoption.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpoption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpoption.Location = New System.Drawing.Point(177, 176)
        Me.grpoption.Name = "grpoption"
        Me.grpoption.Size = New System.Drawing.Size(212, 59)
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
        Me.btnClose.Location = New System.Drawing.Point(112, 18)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(89, 33)
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
        Me.btnInsert.Location = New System.Drawing.Point(13, 18)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(88, 33)
        Me.btnInsert.TabIndex = 6
        Me.btnInsert.Text = "Save"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'lstvSFees
        '
        Me.lstvSFees.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstvSFees.GridLines = True
        Me.lstvSFees.Location = New System.Drawing.Point(12, 247)
        Me.lstvSFees.Name = "lstvSFees"
        Me.lstvSFees.Size = New System.Drawing.Size(580, 169)
        Me.lstvSFees.TabIndex = 70
        Me.lstvSFees.UseCompatibleStateImageBehavior = False
        Me.lstvSFees.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Course Name"
        Me.ColumnHeader1.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Subject Name"
        Me.ColumnHeader2.Width = 99
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Student Name"
        Me.ColumnHeader3.Width = 112
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total Fees"
        Me.ColumnHeader4.Width = 71
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Paid Amount"
        Me.ColumnHeader5.Width = 86
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Due Amount"
        Me.ColumnHeader6.Width = 85
        '
        'StudentFeesInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proect_Work.My.Resources.Resources.akshay
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(604, 428)
        Me.Controls.Add(Me.lstvSFees)
        Me.Controls.Add(Me.grpoption)
        Me.Controls.Add(Me.txtPaidamount)
        Me.Controls.Add(Me.lblTotsubfee)
        Me.Controls.Add(Me.cmbStudentName)
        Me.Controls.Add(Me.cmbSubjectName)
        Me.Controls.Add(Me.cmbCourseName)
        Me.Controls.Add(Me.lblPaidAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblSubjectName)
        Me.Controls.Add(Me.lblCourseName)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "StudentFeesInput"
        Me.Text = "StudentFeesInput"
        Me.grpoption.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblCourseName As System.Windows.Forms.Label
    Friend WithEvents lblSubjectName As System.Windows.Forms.Label
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPaidAmount As System.Windows.Forms.Label
    Friend WithEvents cmbCourseName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubjectName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStudentName As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotsubfee As System.Windows.Forms.Label
    Friend WithEvents txtPaidamount As System.Windows.Forms.TextBox
    Friend WithEvents grpoption As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents lstvSFees As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class

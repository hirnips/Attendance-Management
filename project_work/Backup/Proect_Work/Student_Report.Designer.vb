<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Report
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
        Me.lstReport = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.lblarea = New System.Windows.Forms.Label
        Me.cmbarea = New System.Windows.Forms.ComboBox
        Me.Linkarea = New System.Windows.Forms.LinkLabel
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
        Me.lblHeader.Location = New System.Drawing.Point(259, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(213, 33)
        Me.lblHeader.TabIndex = 73
        Me.lblHeader.Text = "Student Report"
        '
        'lstReport
        '
        Me.lstReport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lstReport.GridLines = True
        Me.lstReport.Location = New System.Drawing.Point(12, 109)
        Me.lstReport.Name = "lstReport"
        Me.lstReport.Size = New System.Drawing.Size(709, 380)
        Me.lstReport.TabIndex = 74
        Me.lstReport.UseCompatibleStateImageBehavior = False
        Me.lstReport.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "RollNo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Stu-Name"
        Me.ColumnHeader2.Width = 111
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Stu-MobNo"
        Me.ColumnHeader3.Width = 112
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Father'sMobNo"
        Me.ColumnHeader4.Width = 96
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "CourseName"
        Me.ColumnHeader5.Width = 94
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Stu_EmailId"
        Me.ColumnHeader6.Width = 227
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Subject"
        Me.ColumnHeader7.Width = 50
        '
        'lblarea
        '
        Me.lblarea.AutoSize = True
        Me.lblarea.BackColor = System.Drawing.Color.Transparent
        Me.lblarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblarea.Location = New System.Drawing.Point(13, 70)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(53, 17)
        Me.lblarea.TabIndex = 75
        Me.lblarea.Text = "Area:-"
        '
        'cmbarea
        '
        Me.cmbarea.FormattingEnabled = True
        Me.cmbarea.Location = New System.Drawing.Point(87, 69)
        Me.cmbarea.Name = "cmbarea"
        Me.cmbarea.Size = New System.Drawing.Size(161, 21)
        Me.cmbarea.TabIndex = 76
        '
        'Linkarea
        '
        Me.Linkarea.AutoSize = True
        Me.Linkarea.BackColor = System.Drawing.Color.Transparent
        Me.Linkarea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Linkarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linkarea.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Linkarea.Location = New System.Drawing.Point(254, 70)
        Me.Linkarea.Name = "Linkarea"
        Me.Linkarea.Size = New System.Drawing.Size(38, 19)
        Me.Linkarea.TabIndex = 77
        Me.Linkarea.TabStop = True
        Me.Linkarea.Text = "ALL"
        '
        'Student_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proect_Work.My.Resources.Resources.Backgound
        Me.ClientSize = New System.Drawing.Size(733, 492)
        Me.Controls.Add(Me.Linkarea)
        Me.Controls.Add(Me.cmbarea)
        Me.Controls.Add(Me.lblarea)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lstReport)
        Me.Name = "Student_Report"
        Me.Text = "Student_Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lstReport As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblarea As System.Windows.Forms.Label
    Friend WithEvents cmbarea As System.Windows.Forms.ComboBox
    Friend WithEvents Linkarea As System.Windows.Forms.LinkLabel
End Class

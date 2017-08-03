Public Class MDI

    Private Sub MDI_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Application.ExitThread()
    End Sub

    Private Sub MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MyModule.Users = UCase("Student") Then
            AttamdanceToolStripMenuItem.Visible = True
            StudentDetailsToolStripMenuItem.Visible = True
            CourseDetailsToolStripMenuItem.Visible = False
            SubjectDetailsToolStripMenuItem.Visible = False
            AreaDetailsToolStripMenuItem.Visible = False
            AttamdanceToolStripMenuItem.Visible = False
            CourseToolStripMenuItem.Visible = False
            SubjectToolStripMenuItem.Visible = False
            StudentToolStripMenuItem.Visible = False
            MarksToolStripMenuItem.Visible = True
            AreaToolStripMenuItem.Visible = False
            MarksInputToolStripMenuItem.Visible = False

        Else
            AttamdanceToolStripMenuItem.Visible = True
            StudentDetailsToolStripMenuItem.Visible = True
            CourseDetailsToolStripMenuItem.Visible = True
            SubjectDetailsToolStripMenuItem.Visible = True
            AreaDetailsToolStripMenuItem.Visible = True
            AttamdanceToolStripMenuItem.Visible = True
            CourseToolStripMenuItem.Visible = True
            SubjectToolStripMenuItem.Visible = True
            StudentToolStripMenuItem.Visible = True
            MarksToolStripMenuItem.Visible = True
            AreaDetailsToolStripMenuItem.Visible = True
        End If
        Me.BackColor = Color.Aqua
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    'Private Sub FillAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttandanceToolStripMenuItem.Click
    '    Dim fillattendance As New Attandance
    '    fillattendance.MdiParent = Me
    '    fillattendance.Show()
    'End Sub
    ''Private Sub AttendanceReoprtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttandanceToolStripMenuItem.Click
    '    Dim report As New AttendenceReport
    '    report.MdiParent = Me
    '    report.Show()
    'End Sub

    Private Sub StudentDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentDetailsToolStripMenuItem.Click
        Dim student As New STUDENT_MASTER
        student.MdiParent = Me
        student.Show()
    End Sub

    Private Sub CourseDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseDetailsToolStripMenuItem.Click
        Dim Course As New Course_Input
        Course.MdiParent = Me
        Course.Show()
    End Sub

    Private Sub SubjectDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectDetailsToolStripMenuItem.Click
        Dim Subject As New Subject_Details
        Subject.MdiParent = Me
        Subject.Show()
    End Sub

    Private Sub AttandanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttandanceToolStripMenuItem.Click
        Dim Attandance As New Attandance
        Attandance.MdiParent = Me
        Attandance.Show()
    End Sub

    Private Sub AreaDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaDetailsToolStripMenuItem.Click
        Dim Area As New Area_Input
        Area.MdiParent = Me
        Area.Show()
    End Sub

    Private Sub AttamdanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttamdanceToolStripMenuItem.Click
        Dim Attandancereport As New AttendenceReport
        Attandancereport.MdiParent = Me
        Attandancereport.Show()
    End Sub

    Private Sub CourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem.Click
        Dim Course As New course_Report
        Course.MdiParent = Me
        Course.Show()
    End Sub

    Private Sub SubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectToolStripMenuItem.Click
        Dim Subject As New Subject_Report
        Subject.MdiParent = Me
        Subject.Show()
    End Sub

    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
        Dim student As New Student_Report
        student.MdiParent = Me
        student.Show()
    End Sub

    Private Sub MarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarksToolStripMenuItem.Click
        Dim Marks As New Marks_report
        Marks.MdiParent = Me
        Marks.Show()
    End Sub

    Private Sub AreaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaToolStripMenuItem.Click
        Dim Area As New Area_Report
        Area.MdiParent = Me
        Area.Show()
    End Sub

    Private Sub MarksInputToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarksInputToolStripMenuItem.Click
        Dim marksinput As New Marks
        Marks.MdiParent = Me
        Marks.Show()
    End Sub

    Private Sub FeesInputToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeesInputToolStripMenuItem.Click
        Dim feesinput As New fees
        fees.MdiParent = Me
        fees.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub CourseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem1.Click
        Dim course As New coursecr
        coursecr.MdiParent = Me
        coursecr.Show()
    End Sub

    Private Sub SubjectToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectToolStripMenuItem1.Click
        Dim subject As New subjectcr
        subjectcr.MdiParent = Me
        subjectcr.Show()
    End Sub

    Private Sub StudentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem1.Click
        Dim student As New studentcr
        studentcr.MdiParent = Me
        studentcr.Show()
    End Sub

    Private Sub AttandanceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttandanceToolStripMenuItem1.Click
        Dim attandance As New attendancecr
        attendancecr.MdiParent = Me
        attendancecr.Show()
    End Sub

    Private Sub MarksToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarksToolStripMenuItem1.Click
        Dim marks As New markscr
        markscr.MdiParent = Me
        markscr.Show()
    End Sub

    Private Sub AreaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaToolStripMenuItem1.Click
        Dim area As New areacr
        areacr.MdiParent = Me
        areacr.Show()
    End Sub

    Private Sub SubjectwisefeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectwisefeesToolStripMenuItem.Click
        Dim subfees As New StudentFeesInput
        StudentFeesInput.MdiParent = Me
        StudentFeesInput.Show()
    End Sub

    Private Sub FeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeesToolStripMenuItem.Click
        Dim fees As New FeesReport
        FeesReport.MdiParent = Me
        FeesReport.Show()
    End Sub
End Class
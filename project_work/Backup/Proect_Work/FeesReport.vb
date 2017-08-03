Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text
Public Class FeesReport
    Dim server As New SqlServer
    Dim total, totalpaid, totaldue As Double
    Private Sub FeesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindCourse()
            BindSubject()
            BindStudent()
        Catch ex As Exception
            '' MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub BindCourse()
        Try
            Dim qry As String = "select * from course"
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(qry)
            server.DisConnect()
            cmbCourse.DataSource = ds.Tables(0)
            cmbCourse.DisplayMember = "CName"
            cmbCourse.ValueMember = "CID"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbSelectCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            BindSubject()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub BindSubject()
        Try
            Server.DoConnect()
            Dim CourseQry As String = "Select * from Subjectdetails where CId=" + cmbCourse.SelectedValue.ToString + ""
            Dim ds1 As DataSet = Server.ExecuteDataSet(CourseQry)
            Server.DisConnect()
            cmbSubject.DataSource = ds1.Tables(0)
            cmbSubject.DisplayMember = "SubjectName"
            cmbSubject.ValueMember = "SubjectId"
            cmbSubject.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub
    Public Sub BindStudent()
        Try
            Server.DoConnect()
            Dim CourseQry As String = "Select * from student_master where Course=" + cmbCourse.SelectedValue.ToString + " and subject=" + cmbSubject.SelectedValue.ToString + ""
            Dim ds1 As DataSet = Server.ExecuteDataSet(CourseQry)
            Server.DisConnect()
            cmbStudent.DataSource = ds1.Tables(0)
            If ds1.Tables(0).Rows.Count > 0 Then
                cmbStudent.DisplayMember = "m_name"
                cmbStudent.ValueMember = "Roll_no"
                cmbStudent.SelectedIndex = 0
            Else
                MsgBox("There is no record found for this subject please enter student for this subject")
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubject.SelectedIndexChanged
        Try
            BindStudent()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbStudent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStudent.SelectedIndexChanged
        Try
            BindDetails()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub BindDetails()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Select f.cid,f.sid,f.Roll_No,c.cname,s.subjectName,st.f_name + ' ' + st.m_name + ' ' + st.l_name as studentname,f.total,f.paidamount,f.dueamount from student_fees f")
            str.AppendLine(" left outer join course c on c.cid = f.cid")
            str.AppendLine(" Left outer join subjectdetails s on f.sid = s.subjectid and s.cid = c.cid")
            str.AppendLine(" Left outer join student_master st on f.roll_no = st.roll_no and st.course = c.cid and st.subject = s.subjectid")
            str.AppendLine(" where(f.cid = " & cmbCourse.SelectedValue.ToString & " And f.sid = " & cmbSubject.SelectedValue.ToString & " And f.Roll_no = " & cmbStudent.SelectedValue.ToString & ")")

            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(str.ToString)
            server.DisConnect()
            If ds.Tables(0).Rows.Count > 0 Then
                lblStuName.Text = ds.Tables(0).Rows(0).Item("StudentName").ToString
                lblStuCourse.Text = ds.Tables(0).Rows(0).Item("CName").ToString
                lblStuSubject.Text = ds.Tables(0).Rows(0).Item("SubjectName").ToString
                lblTotFees.Text = ds.Tables(0).Rows(0).Item("Total").ToString
                lblTotPaidFees.Text = ds.Tables(0).Rows(0).Item("PaidAmount").ToString
                lblTotDueFees.Text = ds.Tables(0).Rows(0).Item("DueAmount").ToString
            Else
                lblStuName.Text = ""
                lblStuCourse.Text = ""
                lblStuSubject.Text = ""
                lblTotFees.Text = ""
                lblTotPaidFees.Text = ""
                lblTotDueFees.Text = ""
                MsgBox("There is no record found for this criteria")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        Try
            BindTotalDetails()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub BindTotalDetails()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Select f.cid,f.sid,f.Roll_No,c.cname,s.subjectName,st.f_name + ' ' + st.m_name + ' ' + st.l_name as studentname,f.total,f.paidamount,f.dueamount from student_fees f")
            str.AppendLine(" left outer join course c on c.cid = f.cid")
            str.AppendLine(" Left outer join subjectdetails s on f.sid = s.subjectid and s.cid = c.cid")
            str.AppendLine(" Left outer join student_master st on f.roll_no = st.roll_no and st.course = c.cid and st.subject = s.subjectid")
            str.AppendLine(" where(f.cid = " & cmbCourse.SelectedValue.ToString & " And f.Roll_no = " & cmbStudent.SelectedValue.ToString & ")")

            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(str.ToString)
            server.DisConnect()
            If ds.Tables(0).Rows.Count > 0 Then
                total = 0
                totaldue = 0
                totalpaid = 0
                Dim str1 As String = ""
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    total = total + CDbl(ds.Tables(0).Rows(i).Item("Total").ToString)
                    totaldue = totaldue + CDbl(ds.Tables(0).Rows(i).Item("DueAmount").ToString)
                    totalpaid = totalpaid + CDbl(ds.Tables(0).Rows(i).Item("PaidAmount").ToString)
                    str1 = str1 + ds.Tables(0).Rows(i).Item("SubjectName").ToString + ","
                Next
                lblStuName.Text = ds.Tables(0).Rows(0).Item("StudentName").ToString
                lblStuCourse.Text = ds.Tables(0).Rows(0).Item("CName").ToString
                lblStuSubject.Text = str1.ToString
                lblTotFees.Text = total.ToString
                lblTotPaidFees.Text = totalpaid.ToString
                lblTotDueFees.Text = totaldue.ToString
            Else
                lblStuName.Text = ""
                lblStuCourse.Text = ""
                lblStuSubject.Text = ""
                lblTotFees.Text = ""
                lblTotPaidFees.Text = ""
                lblTotDueFees.Text = ""
                MsgBox("There is no record found for this criteria")
            End If
            
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        Try
            BindSubject()
            BindStudent()
        Catch ex As Exception
        End Try
    End Sub
End Class
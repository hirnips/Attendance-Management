Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text
Public Class AttendenceReport
    Dim Server As New SqlServer
    Private Sub AttendanceReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            fillCname()
            fillSubject()
            fillRollno()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub fillCname()
        Try
            Server.DoConnect()
            Dim qry As String = "Select * from Course"
            Dim ds As DataSet = Server.ExecuteDataSet(qry)
            Server.DisConnect()
            cmbCourse.DataSource = ds.Tables(0)
            cmbCourse.DisplayMember = "CName"
            cmbCourse.ValueMember = "CId"
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        Try
            fillSubject()
            fillRollno()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub fillRollno()
        Dim cid As String = cmbCourse.SelectedValue.ToString
        Dim sid As String = cmbSubject.SelectedValue.ToString
        Try
            Server.DoConnect()
            Dim qry As String = "Select * from Student_Master where Course=" & cid.ToString & " And Subject=" & sid.ToString & ""
            Dim ds As DataSet = Server.ExecuteDataSet(qry)
            Server.DisConnect()
            cmbRollno.DataSource = ds.Tables(0)
            cmbRollno.DisplayMember = "M_Name"
            cmbRollno.ValueMember = "Roll_No"
        Catch ex As Exception

        End Try
    End Sub
    Public Sub fillSubject()
        Dim cid As String = cmbCourse.SelectedValue.ToString
        Try
            Server.DoConnect()
            Dim qry As String = "Select * from SubjectDetails where Cid=" & cid.ToString
            Dim ds As DataSet = Server.ExecuteDataSet(qry)
            Server.DisConnect()
            cmbSubject.DataSource = ds.Tables(0)
            cmbSubject.DisplayMember = "SubjectName"
            cmbSubject.ValueMember = "SubjectId"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        filldetails()
    End Sub
    Public Sub filldetails()
        Dim cid As String = cmbCourse.SelectedValue.ToString
        Dim roll As String = cmbRollno.SelectedValue.ToString
        Dim sid As String = cmbSubject.SelectedValue.ToString
        Dim tempstart As Date = dtpStart.Text
        Dim string1 As String = FormatDateTime(tempstart, DateFormat.ShortDate)
        If tempstart.Day >= 1 And tempstart.Day <= 9 Then
            string1 = string1.Insert(3, "0")
        End If

        Dim tempend As Date = dtpEnd.Text
        Dim str2 As String = FormatDateTime(tempend, DateFormat.ShortDate)
        If tempend.Day >= 1 And tempend.Day <= 9 Then
            str2 = str2.Insert(3, "0")
        End If
        Try
            Server.DoConnect()
            Dim str As New StringBuilder
            str.AppendLine("select a.rollno,a.courseid,a.studentname,a.subjectid, c.cname,s.subjectname, a.LoginDate from attandance a ")
            str.AppendLine(" left outer join course c on a.courseid = c.CId ")
            str.AppendLine(" left outer join subjectdetails s on a.subjectid = s.Subjectid ")
            str.AppendLine(" where(a.rollno = " & roll.ToString & " And s.cid = " & cid.ToString & " And s.subjectid = " & sid.ToString & " and Logindate between '" & string1.ToString & "' and '" & str2.ToString & "')")
            Dim ds As DataSet = Server.ExecuteDataSet(str.ToString)
            Server.DisConnect()
            lstvAttendenceReport.Items.Clear()
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim str1(5) As String
                    str1(0) = ds.Tables(0).Rows(i).Item("RollNo").ToString
                    str1(1) = ds.Tables(0).Rows(i).Item("StudentName").ToString
                    str1(2) = ds.Tables(0).Rows(i).Item("CName").ToString
                    str1(3) = ds.Tables(0).Rows(i).Item("SubjectName").ToString
                    str1(4) = ds.Tables(0).Rows(i).Item("LoginDate").ToString
                    Dim lst As New ListViewItem(str1)
                    lstvAttendenceReport.Items.Add(lst)
                Next
            Else
                MsgBox("There is no item found between these two dates so please try again")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cmbSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubject.SelectedIndexChanged
        Try
            fillRollno()
        Catch ex As Exception

        End Try
    End Sub
End Class
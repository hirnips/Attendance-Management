Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text

Public Class Marks_report
    Dim server As New SqlServer
    Private Sub Marks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            fillCourseId()
            fillSubjectId()
            fillRollno()
            BindMarks()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub fillCourseId()
        Try
            server.DoConnect()
            Dim qry As String = "Select * from Course"
            Dim ds As DataSet = server.ExecuteDataSet(qry)
            server.DisConnect()
            CmbCourseId.DataSource = ds.Tables(0)
            CmbCourseId.DisplayMember = "Cname"
            CmbCourseId.ValueMember = "CId"
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cmbCourseId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCourseId.SelectedIndexChanged
        Try
            fillSubjectId()
            fillRollno()
            BindMarks()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub fillRollno()
        Dim cid As String = CmbCourseId.SelectedValue.ToString
        Dim sid As String = cmbSubjectId.SelectedValue.ToString
        Try
            server.DoConnect()
            Dim qry As String = "Select * from Student_Master where Course=" & cid.ToString & " And Subject=" & sid.ToString & ""
            Dim ds As DataSet = server.ExecuteDataSet(qry)
            server.DisConnect()
            cmbRollNo.DataSource = ds.Tables(0)
            cmbRollNo.DisplayMember = "M_Name"
            cmbRollNo.ValueMember = "Roll_No"
        Catch ex As Exception

        End Try
    End Sub
    Public Sub fillSubjectId()
        Dim cid As String = CmbCourseId.SelectedValue.ToString
        Try
            server.DoConnect()
            Dim qry As String = "Select * from SubjectDetails where Cid=" & cid.ToString
            Dim ds As DataSet = server.ExecuteDataSet(qry)
            server.DisConnect()
            cmbSubjectId.DataSource = ds.Tables(0)
            cmbSubjectId.DisplayMember = "SubjectName"
            cmbSubjectId.ValueMember = "SubjectId"
        Catch ex As Exception

        End Try
    End Sub
    Public Sub BindMarks()
        Dim tempmonth As Date = dtMonth.Text
        Dim string1 As String = FormatDateTime(tempmonth, DateFormat.ShortDate)
        If tempmonth.Month >= 1 And tempmonth.Month <= 9 Then
            string1 = string1.Substring(4, 1)
        End If
        Dim roll As Integer = cmbRollNo.SelectedValue.ToString
        Dim cid As Integer = CmbCourseId.SelectedValue.ToString
        Dim sid As Integer = cmbSubjectId.SelectedValue.ToString
        Try
            server.DoConnect()
            Dim str As New StringBuilder
            str.AppendLine("select c.cname,s.subjectname, m.rollno, m.inputmonth, st.f_name, st.M_name, st.l_name, m.marks from marksinput m")
            str.AppendLine("left outer join course c on c.cid = m.courseid")
            str.AppendLine("left outer join subjectdetails s on s.subjectid = m.subjectid")
            str.AppendLine("left outer join student_master st on st.subject = m.subjectid and st.course = m.courseid and st.roll_no = m.rollno")
            'str.AppendLine("where(rollno =" & roll.ToString & " And inputmonth =" & string1.ToString & ")")

            Dim ds As DataSet = server.ExecuteDataSet(str.ToString)
            server.DisConnect()
            lstvMarksInput.Items.Clear()
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim str1(5) As String

                    str1(0) = ds.Tables(0).Rows(i).Item("rollno").ToString

                    Dim name As String = ds.Tables(0).Rows(i).Item("f_name").ToString + " " + ds.Tables(0).Rows(i).Item("m_name").ToString + " " + ds.Tables(0).Rows(i).Item("l_name").ToString

                    str1(1) = name.ToString
                    str1(2) = ds.Tables(0).Rows(i).Item("CName").ToString
                    str1(3) = ds.Tables(0).Rows(i).Item("SubjectName").ToString
                    str1(4) = ds.Tables(0).Rows(i).Item("marks").ToString

                    Dim lst As New ListViewItem(str1)
                    lstvMarksInput.Items.Add(lst)
                Next
            Else
                MsgBox("There is no item found between these two dates so please try again")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Dim tempmonth As Date = dtMonth.Text
        Dim string1 As String = FormatDateTime(tempmonth, DateFormat.ShortDate)
        If tempmonth.Month >= 1 And tempmonth.Month <= 9 Then
            string1 = string1.Substring(4, 1)
        End If
        Dim roll As Integer = cmbRollNo.SelectedValue.ToString
        Dim cid As Integer = CmbCourseId.SelectedValue.ToString
        Dim sid As Integer = cmbSubjectId.SelectedValue.ToString
        Try
            server.DoConnect()
            Dim str As New StringBuilder
            str.AppendLine("select c.cname,s.subjectname, m.rollno, m.inputmonth, st.f_name, st.M_name, st.l_name, m.marks from marksinput m")
            str.AppendLine("left outer join course c on c.cid = m.courseid")
            str.AppendLine("left outer join subjectdetails s on s.subjectid = m.subjectid")
            str.AppendLine("left outer join student_master st on st.subject = m.subjectid and st.course = m.courseid and st.roll_no = m.rollno")
            str.AppendLine("where(rollno =" & roll.ToString & " And inputmonth =" & string1.ToString & " And m.subjectid= " & cmbSubjectId.SelectedValue.ToString & ")")

            Dim ds As DataSet = server.ExecuteDataSet(str.ToString)
            server.DisConnect()
            lstvMarksInput.Items.Clear()
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim str1(5) As String

                    str1(0) = ds.Tables(0).Rows(i).Item("rollno").ToString

                    Dim name As String = ds.Tables(0).Rows(i).Item("f_name").ToString + " " + ds.Tables(0).Rows(i).Item("m_name").ToString + " " + ds.Tables(0).Rows(i).Item("l_name").ToString

                    str1(1) = name.ToString
                    str1(2) = ds.Tables(0).Rows(i).Item("CName").ToString
                    str1(3) = ds.Tables(0).Rows(i).Item("SubjectName").ToString
                    str1(4) = ds.Tables(0).Rows(i).Item("marks").ToString

                    Dim lst As New ListViewItem(str1)
                    lstvMarksInput.Items.Add(lst)
                Next
            Else
                MsgBox("There is no item found for this subject please try another subject")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class
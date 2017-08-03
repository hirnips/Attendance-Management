Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text

Public Class Marks
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
        Catch ex As Exception
        End Try
    End Sub
    Public Sub fillRollno()
        Dim cid As String = CmbCourseId.SelectedValue.ToString
        Dim sid As String = cmbSubjectId.SelectedValue.ToString
        Try
            Server.DoConnect()
            Dim qry As String = "Select * from Student_Master where Course=" & cid.ToString & " And Subject=" & sid.ToString & ""
            Dim ds As DataSet = Server.ExecuteDataSet(qry)
            Server.DisConnect()
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

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Try
            If txtMarks.Text = "" Then
                MsgBox("Please enter value into Marks TextBox")
                txtMarks.Focus()
                Exit Sub
            End If
            InsertCourse()
            txtMarks.Text = ""
            CmbCourseId.SelectedIndex = 0
            cmbSubjectId.SelectedIndex = 0
            cmbRollNo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub InsertCourse()
        Try
            Dim month As Integer = Now.Date.Month.ToString
            Dim str As New StringBuilder
            str.AppendLine("Insert into MarksInput(courseId,SubjectId,Rollno,marks,InputDate,Inputmonth) values")
            str.AppendLine("(")
            str.AppendLine("" & CmbCourseId.SelectedValue.ToString & ",'" & cmbSubjectId.SelectedValue.ToString & "','" & cmbRollNo.SelectedValue.ToString & "'," & txtMarks.Text & ",'" & Now.Date.Date.ToString & "'," & month.ToString & "")
            str.AppendLine(")")
            server.DoConnect()
            server.ExecuteNonQuery(str.ToString)
            server.DisConnect()
            BindMarks()
        Catch ex As Exception
            MsgBox("There is already a record inserted for this student for same date")
            Exit Sub
        End Try
    End Sub
    Public Sub BindMarks()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Select * from MarksInput")
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(str.ToString)
            server.DisConnect()
            If ds.Tables(0).Rows.Count > 0 Then
                lstvMarksInput.Items.Clear()
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim str1(3) As String
                    str1(0) = ds.Tables(0).Rows(i).Item("Courseid").ToString
                    str1(1) = ds.Tables(0).Rows(i).Item("SubjectId").ToString
                    str1(2) = ds.Tables(0).Rows(i).Item("Rollno").ToString
                    str1(3) = ds.Tables(0).Rows(i).Item("marks").ToString
                    Dim lst As New ListViewItem(str1)
                    lstvMarksInput.Items.Add(lst)
                Next
            Else
                MsgBox("There is no record found into Marks table")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            UpdateMarks()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub UpdateMarks()
        Try
            Dim qry As String = "Update MarksInput set Marks=" + txtMarks.Text + " Where CourseID=" + CmbCourseId.SelectedValue.ToString + " And SubjectID=" + cmbSubjectId.SelectedValue.ToString + " And RollNo=" + cmbRollNo.SelectedValue.ToString + " And InputDate='" + Now.Date.ToString + "'"
            server.DoConnect()
            server.ExecuteNonQuery(qry)
            server.DisConnect()
            MsgBox("Record Updated Successfully")
            BindMarks()
            txtMarks.Text = ""
            txtMarks.Focus()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            DeleteMarks()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub DeleteMarks()
        Try
            Dim qry As String = "Delete from MarksInput Where CourseId=" + CmbCourseId.SelectedValue.ToString + " And SubjectId=" + cmbSubjectId.SelectedValue.ToString + " And Rollno=" + cmbRollNo.SelectedValue.ToString + " And InputDate='" + Now.Date.ToString + "'"
            server.DoConnect()
            server.ExecuteNonQuery(qry)
            server.DisConnect()
            MsgBox("Record Deleted Successfully")
            txtMarks.Text = ""
            BindMarks()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cmbRollNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRollNo.SelectedIndexChanged
        Try
            SearchMarks()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub SearchMarks()
        Try
            Dim qry As String = "Select Marks from MarksInput where CourseID=" + CmbCourseId.SelectedValue.ToString + " And Subjectid=" + cmbSubjectId.SelectedValue.ToString + " And Rollno=" + cmbRollNo.SelectedValue.ToString + " And InputDate='" + Now.Date.ToString + "'"
            server.DoConnect()
            Dim i As Integer = server.ExecuteScalar(qry)
            server.DisConnect()
            If IsDBNull(i) Then
                MsgBox("There is no record found for this student")
                Exit Sub
            Else
                txtMarks.Text = i.ToString
            End If
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub cmbSubjectId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubjectId.SelectedIndexChanged
        Try
            fillRollno()
        Catch ex As Exception
        End Try
    End Sub
End Class
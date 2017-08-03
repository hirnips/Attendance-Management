Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text
Public Class StudentFeesInput
    Dim Server As New SqlServer
    Private Sub StudentFeesInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            btnInsert.Enabled = False
            bindcourse()
            BindSubject()
            BindFees()
            BindStudent()
            BindGrid()
        Catch ex As Exception
            '' MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub BindGrid()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Select f.cid,f.sid,f.Roll_No,c.cname,s.subjectName,st.f_name + ' ' + st.m_name + ' ' + st.l_name as studentname,f.total,f.paidamount,f.dueamount from student_fees f")
            str.AppendLine(" left outer join course c on c.cid = f.cid")
            str.AppendLine(" Left outer join subjectdetails s on f.sid = s.subjectid and s.cid = c.cid")
            str.AppendLine(" Left outer join student_master st on f.roll_no = st.roll_no and st.course = c.cid and st.subject = s.subjectid")
            Server.DoConnect()
            Dim ds As DataSet = Server.ExecuteDataSet(str.ToString)
            Server.DisConnect()
            If ds.Tables(0).Rows.Count > 0 Then
                lstvSFees.Items.Clear()
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim str2(5) As String
                    str2(0) = ds.Tables(0).Rows(i).Item("Cname").ToString
                    str2(1) = ds.Tables(0).Rows(i).Item("SubjectName").ToString
                    str2(2) = ds.Tables(0).Rows(i).Item("StudentName").ToString
                    str2(3) = ds.Tables(0).Rows(i).Item("Total").ToString
                    str2(4) = ds.Tables(0).Rows(i).Item("PaidAmount").ToString
                    str2(5) = ds.Tables(0).Rows(i).Item("DueAmount").ToString

                    Dim lst As New ListViewItem(str2)
                    lstvSFees.Items.Add(lst)
                Next
            Else
                MsgBox("There is no record found for this student")
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub bindcourse()
        Try
            Dim qry As String = "select * from course"
            Server.DoConnect()
            Dim ds As DataSet = Server.ExecuteDataSet(qry)
            Server.DisConnect()
            cmbCourseName.DataSource = ds.Tables(0)
            cmbCourseName.DisplayMember = "CName"
            cmbCourseName.ValueMember = "CID"
            cmbCourseName.SelectedIndex = 0
        Catch ex As Exception
            '' MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub cmbCourseName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourseName.SelectedIndexChanged
        Try
            BindSubject()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub BindSubject()
        Try
            Server.DoConnect()
            Dim CourseQry As String = "Select * from Subjectdetails where CId=" + cmbCourseName.SelectedValue.ToString + ""
            Dim ds1 As DataSet = Server.ExecuteDataSet(CourseQry)
            Server.DisConnect()
            cmbSubjectName.DataSource = ds1.Tables(0)
            cmbSubjectName.DisplayMember = "SubjectName"
            cmbSubjectName.ValueMember = "SubjectId"
            cmbSubjectName.SelectedIndex = 0
        Catch ex As Exception
            ''MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Try
            If txtPaidamount.Text = "" Then
                MsgBox("Please enter value into Paid Amount TextBox")
                txtPaidamount.Focus()
                Exit Sub
            End If
            If CDbl(txtPaidamount.Text) > CDbl(lblTotsubfee.Text) Then
                MsgBox("You are paying more than the original one")
                txtPaidamount.Text = ""
                txtPaidamount.Focus()
                Exit Sub
            End If
            Dim dueAmount As Double = CDbl(lblTotsubfee.Text) - CDbl(txtPaidamount.Text)
            Dim str As New StringBuilder
            str.AppendLine("Insert into student_fees(cid,sid,roll_no,total,PaidAmount,DueAmount)values(")
            str.AppendLine("" & cmbCourseName.SelectedValue.ToString & "," & cmbSubjectName.SelectedValue.ToString & "," & cmbStudentName.SelectedValue.ToString & "," & lblTotsubfee.Text & "," & txtPaidamount.Text & "," & dueAmount.ToString & ")")
            Server.DoConnect()
            Server.ExecuteNonQuery(str.ToString)
            Server.DisConnect()
            txtPaidamount.Text = ""
            MsgBox("your Record is successfully inserted")
            BindGrid()
        Catch ex As Exception
            ''MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub cmbSubjectName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubjectName.SelectedIndexChanged
        Try
            BindStudent()
            BindFees()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub BindStudent()
        Try
            Server.DoConnect()
            Dim CourseQry As String = "Select * from student_master where Course=" + cmbCourseName.SelectedValue.ToString + " and subject=" + cmbSubjectName.SelectedValue.ToString + ""
            Dim ds1 As DataSet = Server.ExecuteDataSet(CourseQry)
            Server.DisConnect()
            cmbStudentName.DataSource = ds1.Tables(0)
            If ds1.Tables(0).Rows.Count > 0 Then
                cmbStudentName.DisplayMember = "m_name"
                cmbStudentName.ValueMember = "Roll_no"
                cmbStudentName.SelectedIndex = 0
            Else
                MsgBox("There is no record found for this subject please enter student for this subject")
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub BindFees()
        Try
            Server.DoConnect()
            Dim feesquery As String = "Select Amount from Fees_master where cid = " + cmbCourseName.SelectedValue.ToString + " And sid = " + cmbSubjectName.SelectedValue.ToString + ""
            Dim amount As Object = Server.ExecuteScalar(feesquery).ToString
            Dim totalfees As String = amount.ToString
            If totalfees <> "" Then
                lblTotsubfee.Text = totalfees.ToString
            Else
                lblTotsubfee.Text = ""
                MsgBox("Please enter fees for this subject")
                Exit Sub
            End If
            Server.DisConnect()
        Catch ex As Exception
            lblTotsubfee.Text = ""
            ''MsgBox("Please enter fees for this subject")
            Exit Sub
        End Try
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub cmbStudentName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStudentName.SelectedIndexChanged
        btnInsert.Enabled = True
    End Sub
End Class
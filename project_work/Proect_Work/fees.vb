Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text
Public Class fees
    Dim server As New SqlServer
    Private Sub Fees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindCourse()
            BindSubject()
            BindGrid()
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub BindCourse()
        Try
            Dim qry As String = "select * from course"
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(qry)
            server.DisConnect()
            cmbCourseName.DataSource = ds.Tables(0)
            cmbCourseName.DisplayMember = "CName"
            cmbCourseName.ValueMember = "CID"
            cmbCourseName.SelectedIndex.ToString()
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cmbCourseName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourseName.SelectedIndexChanged
        Try
            BindSubject()
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub BindSubject()
        Try
            server.DoConnect()
            Dim CourseQry As String = "Select * from Subjectdetails where CId=" + cmbCourseName.SelectedValue.ToString + ""
            Dim ds1 As DataSet = server.ExecuteDataSet(CourseQry)
            server.DisConnect()
            cmbSubjectname.DataSource = ds1.Tables(0)
            cmbSubjectname.DisplayMember = "subjectname"
            cmbSubjectname.ValueMember = "subjectID"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try
            If txtEnterAmount.Text = "" Then
                MsgBox("Please Enter value into Amount text box")
                txtEnterAmount.Focus()
                Exit Sub
            End If
            Dim str As New StringBuilder
            str.AppendLine("insert into Fees_Master(CID,SID,Amount) values(")
            str.AppendLine("" & cmbCourseName.SelectedValue.ToString & "," & cmbSubjectname.SelectedValue.ToString & "," & txtEnterAmount.Text & ")")
            server.DoConnect()
            server.ExecuteNonQuery(str.ToString)
            server.DisConnect()
            txtEnterAmount.Text = ""
            MsgBox("Your Record Successfully Inserted")
            bindgrid()
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub BindGrid()
        Try
            Dim query As String = "Select Cid, SId, Amount From fees_master"
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(query)
            server.DisConnect()

            lstvFees.Items.Clear()
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Dim str(4) As String
                str(0) = ds.Tables(0).Rows(i).Item("Cid") & ""
                str(1) = ds.Tables(0).Rows(i).Item("sid") & ""
                str(2) = ds.Tables(0).Rows(i).Item("Amount") & ""
                Dim lst As New ListViewItem(str)
                lstvFees.Items.Add(lst)
            Next
        Catch ex As Exception
            ' MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            UpdateCourse()
            BindGrid()
        Catch ex As Exception
            ''MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub UpdateCourse()
        Try
            Dim str As New StringBuilder
            str.AppendLine("update fees_master set Amount=" & txtEnterAmount.Text & " Where CID=" & cmbCourseName.SelectedValue.ToString & " And SID=" & cmbSubjectname.SelectedValue.ToString & "")
            server.DoConnect()
            server.ExecuteNonQuery(str.ToString)
            server.DisConnect()
            MsgBox("Record Updated Successfully")
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            DeleteCourse()
            BindGrid()
        Catch ex As Exception
            ' MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub DeleteCourse()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Delete from fees_master Where CId=" & cmbCourseName.SelectedValue.ToString & " And Sid=" & cmbSubjectname.SelectedValue.ToString & "")
            server.DoConnect()
            server.ExecuteNonQuery(str.ToString)
            server.DisConnect()
            MsgBox("Record Deleted Successfully")
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub cmbSubjectname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubjectname.SelectedIndexChanged
        Try
            BindAmount()
        Catch ex As Exception
            ''MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub BindAmount()
        Try
            Dim qry As String = "Select Amount from Fees_Master where cid=" & cmbCourseName.SelectedValue.ToString & " And Sid=" & cmbSubjectname.SelectedValue.ToString & ""
            server.DoConnect()
            Dim amount As Integer = server.ExecuteScalar(qry)
            server.DisConnect()
            txtEnterAmount.Text = amount.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnclose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub
End Class

Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text
Public Class Subject_Details
    Dim server As New SqlServer
    Dim subjectId As Integer
    'Dim courseId As Integer
    Dim status As Boolean

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If cmbCourseName.Text = String.Empty Then
                MsgBox("Course name cannot be blank")
                cmbCourseName.Focus()
                Exit Sub
            End If
            If txtSubjectName.Text = String.Empty Then
                MsgBox("subject name cannot be blank")
                txtSubjectName.Focus()
                Exit Sub
            End If
            If txtSubjectDescription.Text = String.Empty Then
                MsgBox("subject description cannot be blank")
                txtSubjectDescription.Focus()
                Exit Sub
            End If
            If cmbSubjectId.SelectedItem.ToString = 0 Then
                MsgBox("Please select Subject From SubjectID")
                Exit Sub
            End If
            Dim str As New StringBuilder
            str.AppendLine("insert into subjectdetails (CId, SubjectId, SubjectName, Description) values")
            str.AppendLine("(")
            str.AppendLine("" & cmbCourseName.SelectedValue.ToString & "," & cmbSubjectId.SelectedItem.ToString & ",'" & txtSubjectName.Text & "','" & txtSubjectDescription.Text & "'")
            str.AppendLine(")")
            server.DoConnect()
            server.ExecuteNonQuery(str.ToString)
            server.DisConnect()
            txtSubjectDescription.Clear()
            txtSubjectName.Clear()
            btnedit.Enabled = False
            ' FillSubjects()
            BindGrid()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub BindGrid()
        Try
            Dim query As String = "Select c.CName, s.SubjectId, s.SubjectName,s.Description From subjectdetails s left outer join Course c on c.CID=s.CID"
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(query)
            server.DisConnect()

            lstSubject.Items.Clear()
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Dim str(4) As String
                str(0) = ds.Tables(0).Rows(i).Item("CName") & ""
                str(1) = ds.Tables(0).Rows(i).Item("subjectid") & ""
                str(2) = ds.Tables(0).Rows(i).Item("subjectName") & ""
                str(3) = ds.Tables(0).Rows(i).Item("Description") & ""

                Dim lst As New ListViewItem(str)
                lstSubject.Items.Add(lst)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Function GetSubjectId() As Integer
        Try
            server.DoConnect()
            Dim query As String = "select Max(subjectid) from subjectdetails where CID=" & CInt(cmbCourseName.SelectedValue.ToString) & ""
            Dim id As Object = server.ExecuteScalar(query)
            server.DoConnect()
            If id Is Nothing OrElse IsDBNull(id) = True Then
                Return 1
            Else
                Return id + 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Function

    Private Sub Subject_Input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindGrid()
        FillCourse()
        btnedit.Enabled = False
        txtSubjectDescription.Enabled = False
        txtSubjectName.Enabled = False
    End Sub
    Public Sub FillCourse()
        Try
            server.DoConnect()
            Dim courseQry As String = "select * from Course c order by c.CName"
            Dim ds As DataSet = server.ExecuteDataSet(courseQry)
            server.DisConnect()
            status = True
            cmbCourseName.DataSource = ds.Tables(0)
            cmbCourseName.DisplayMember = "CName"
            cmbCourseName.ValueMember = "CID"
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        DeleteSubject()
        txtSubjectName.Enabled = True
        txtSubjectDescription.Enabled = True
    End Sub
    Public Sub DeleteSubject()
        Try
            Dim subjectId As Integer = cmbSubjectId.SelectedItem.ToString
            server.DoConnect()
            Dim qry As String = "Delete from subjectdetails Where (SubjectID=" + subjectId.ToString + "AND CID=" + cmbCourseName.SelectedValue.ToString + ")"
            server.ExecuteNonQuery(qry)
            server.DisConnect()
            BindGrid()
            FillCourse()
            MsgBox("Record Deleted successfully")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtSubjectName.Text = ""
        txtSubjectDescription.Text = ""
        txtSubjectName.Enabled = True
        txtSubjectDescription.Enabled = True
        subjectId = GetSubjectId()
        btnedit.Enabled = True
        cmbSubjectId.Items.Clear()
        cmbSubjectID.Items.Add(subjectId)

    End Sub

    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourseName.SelectedIndexChanged
        FillSubject()
    End Sub
    Public Sub Fillsubject()
        Try
            server.DoConnect()
            Dim SubjectQry As String = "Select * from Subjectdetails where CId=" + cmbCourseName.SelectedValue.ToString + ""
            Dim ds1 As DataSet = server.ExecuteDataSet(SubjectQry)
            server.DisConnect()
            If ds1.Tables(0).Rows.Count > 0 Then
                cmbSubjectID.Items.Clear()
                For i As Integer = 0 To ds1.Tables(0).Rows.Count - 1
                    cmbSubjectId.Items.Add(ds1.Tables(0).Rows(i).Item("SubjectId").ToString)
                Next
                cmbSubjectID.SelectedIndex = 0
                BindGrid()
            Else
                MsgBox("Please Insert Subject For This course")
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        UpdateSubject()
    End Sub
    Public Sub UpdateSubject()
        Try
            Dim subjectId As Integer = cmbSubjectId.SelectedItem.ToString
            server.DoConnect()
            Dim qry As String = "Update Subjectdetails set SubjectName='" & txtSubjectName.Text & "',Description='" & txtSubjectDescription.Text & "' Where (CID=" & CInt(cmbCourseName.SelectedValue.ToString) & " And SubjectID=" & subjectId.ToString & ")"
            Dim i As Integer = server.ExecuteNonQuery(qry)
            server.DisConnect()
            txtSubjectDescription.Text = ""
            txtSubjectName.Text = ""
            BindGrid()
            Fillsubject()
            MsgBox("Record Updated Successfully")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Function GetSubjectIdByName() As Integer
        Try
            server.DoConnect()
            Dim qry As String = "Select SubjectID from subjectdetails where (subjectName='" & cmbSubjectId.SelectedItem.ToString & "' And CID=" & cmbCourseName.SelectedValue.ToString & ")"
            Dim i As Object = server.ExecuteScalar(qry)
            server.DisConnect()
            Return i
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Function

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub cmbSubjectId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubjectId.SelectedIndexChanged
        filldetails()
        btnedit.Enabled = True
        txtSubjectName.Enabled = True
        txtSubjectDescription.Enabled = True
    End Sub
    Public Sub filldetails()
        Try
            server.DoConnect()
            Dim str As String
            str = "Select * from SubjectDetails Where Cid=" + cmbCourseName.SelectedValue.ToString + " And SubjectId=" + cmbSubjectId.SelectedItem.ToString + ""
            Dim ds As DataSet = server.ExecuteDataSet(str)
            server.DisConnect()
            If ds.Tables(0).Rows.Count > 0 Then
                txtSubjectName.Text = ds.Tables(0).Rows(0).Item("SubjectName").ToString
                txtSubjectDescription.Text = ds.Tables(0).Rows(0).Item("Description").ToString
            Else
                MsgBox("There is no record found for this CourseId and SubjectId")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSubject.SelectedIndexChanged

    End Sub
End Class
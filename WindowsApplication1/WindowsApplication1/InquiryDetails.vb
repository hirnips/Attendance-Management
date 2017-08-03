Imports System.Data
Imports System.Data.SqlClient
Imports WindowsApplication1.Utility
Imports System.Text
Public Class InquiryDetails
    Dim server As New SqlServer
    Private Sub InquiryDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            btnsave.Enabled = False
            cmbcourse.SelectedIndex = 0
            cmbarea.SelectedIndex = 0
            bindCourse()
            bindArea()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub bindArea()
        Try
            Dim str As String = "Select * from Area_Input"
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(str)
            server.DisConnect()
            cmbarea.DataSource = ds.Tables(0)
            cmbarea.DisplayMember = "areaName"
            cmbarea.ValueMember = "areaid"

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub bindCourse()
        Try
            Dim str As String = "Select * from Course"
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(str)
            server.DisConnect()
            cmbcourse.DataSource = ds.Tables(0)
            cmbcourse.DisplayMember = "CName"
            cmbcourse.ValueMember = "CID"

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cmbcourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcourse.SelectedIndexChanged
        Try
            Dim Courseqry As String = "Select * from subjectdetails where CId=" + cmbcourse.SelectedValue.ToString + ""
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(Courseqry)
            server.DisConnect()
            lstsubject.Items.Clear()
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Dim str(2) As String
                str(0) = ds.Tables(0).Rows(i).Item("SubjectName").ToString
                str(1) = ds.Tables(0).Rows(i).Item("SubjectID").ToString
                Dim lst As New ListViewItem(str)
                lstsubject.Items.Add(lst)
            Next

        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Try
            txtaddress.Text = ""
            dtBirthday.Value.Date.ToString()
            txtemail.Text = ""
            txtfather.Text = ""
            txtmobile.Text = ""
            txtname.Text = ""
            txtphone.Text = ""
            txtsurname.Text = ""
            cmbcourse.SelectedIndex = 0
            cmbarea.SelectedIndex = 0
            lstsubject.Items.Clear()
            btnsave.Enabled = True
            btnnew.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Function GetInquiryId() As Integer
        Try

            Dim str As String = "Select MAX(Id) from Inquiry_Master"
            server.DoConnect()
            Dim id As Object = server.ExecuteScalar(str)
            server.DoConnect()

            If id Is Nothing Or IsDBNull(id) = True Then
                Return 1
            Else
                Return id + 1
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Function

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim Id As Integer = GetInquiryId()

            Dim gender As String
            If rdofemale.Checked = True Then
                gender = "Female"
            Else
                gender = "Male"
            End If

            For i As Integer = 0 To lstsubject.SelectedItems.Count - 1
                Dim str As New StringBuilder
                str.AppendLine("Insert into Inquiry_Master values")
                str.AppendLine("(")
                str.AppendLine("" + Id.ToString + ",'" + txtsurname.Text + "','" + txtname.Text + "','" + txtfather.Text + "','" + gender.ToString + "','" + dtBirthday.Value.Date.ToString + "','" + txtaddress.Text + "','" + txtemail.Text + "','" + txtphone.Text + "','" + txtmobile.Text + "'")
                str.AppendLine("," + cmbcourse.SelectedValue.ToString + ",'" + lstsubject.SelectedItems.Item(i).SubItems.Item(1).Text + "'")
                str.AppendLine("," + cmbarea.SelectedValue.ToString + ",'" + dtInquiry.Value.Date.ToString + "','" + dtFollowup.Value.Date.ToString + "'")

                server.DoConnect()
                server.ExecuteNonQuery(str.ToString)
                server.DisConnect()
                Dim Flag As Boolean = False
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class
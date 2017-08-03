Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text
Public Class Course_Input
    Dim server As New SqlServer
    Dim CourseId As Integer
   
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try
            CourseId = GetId()
            txtCid.Text = CourseId.ToString
            txtCid.Enabled = False
            btnInsert.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnNew.Enabled = False
            txtcoursename.Text = ""
            txtDescription.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Function GetId() As Integer
        Try
            server.DoConnect()
            Dim query As String = "Select max(CId) from Course"
            Dim id As Object = server.ExecuteScalar(query)
            server.DisConnect()
            If id Is Nothing OrElse IsDBNull(id) Then
                Return 1
            Else
                Return id + 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Function

    Private Sub Course_Input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            btnInsert.Enabled = False
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            BindCourse()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub BindCourse()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Select * from Course")
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(str.ToString)
            server.DisConnect()
            If ds.Tables(0).Rows.Count > 0 Then
                lstCourse.Items.Clear()
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim str1(3) As String
                    str1(0) = ds.Tables(0).Rows(i).Item("Cid").ToString
                    str1(1) = ds.Tables(0).Rows(i).Item("Cname").ToString
                    str1(2) = ds.Tables(0).Rows(i).Item("CDescription").ToString

                    Dim lst As New ListViewItem(str1)
                    lstCourse.Items.Add(lst)
                Next
            Else
                MsgBox("There is no record found into Course table")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Try
            If txtCid.Text = "" Then
                MsgBox("Please enter value into CourseId TextBox")
                txtCid.Focus()
                Exit Sub
            End If
            If txtcoursename.Text = "" Then
                MsgBox("Please enter value into CourseName TextBox")
                txtcoursename.Focus()
                Exit Sub
            End If
            If txtDescription.Text = "" Then
                MsgBox("Please enter value into CourseDescription TextBox")
                txtDescription.Focus()
                Exit Sub
            End If
            InsertCourse()
            btnNew.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub InsertCourse()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Insert into Course(Cid,Cname,CDescription) values")
            str.AppendLine("(")
            str.AppendLine("" & txtCid.Text & ",'" & txtcoursename.Text & "','" & txtDescription.Text & "'")
            str.AppendLine(")")
            server.DoConnect()
            server.ExecuteNonQuery(str.ToString)
            server.DisConnect()
            BindCourse()
            txtCid.Text = ""
            txtcoursename.Text = ""
            txtDescription.Text = ""
            btnNew.Enabled = True
            btnNew.Focus()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub lstCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCourse.SelectedIndexChanged
        Try
            Dim str As New StringBuilder
            str.AppendLine("Select * from Course where Cid=")
            str.AppendLine("" & lstCourse.SelectedItems.Item(0).SubItems.Item(0).Text & "")
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(str.ToString)
            server.DisConnect()
            txtCid.Text = ds.Tables(0).Rows(0).Item("Cid").ToString
            txtcoursename.Text = ds.Tables(0).Rows(0).Item("CName").ToString
            txtDescription.Text = ds.Tables(0).Rows(0).Item("CDescription").ToString
            btnDelete.Enabled = True
            btnUpdate.Enabled = True
            txtCid.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If lstCourse.SelectedItems.Count = 0 Then
                MsgBox("Please select atleast one item from grid")
                lstCourse.Focus()
                Exit Sub
            End If
            UpdateCourse()
            btnNew.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub UpdateCourse()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Update Course set CName='")
            str.AppendLine("" & txtcoursename.Text & "',Cdescription='" & txtDescription.Text & "'")
            str.AppendLine(" Where Cid=" & txtCid.Text & "")
            server.DoConnect()
            server.ExecuteNonQuery(str.ToString)
            server.DisConnect()
            MsgBox("Record Updated Successfully")
            BindCourse()
            txtCid.Text = ""
            txtcoursename.Text = ""
            txtDescription.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If lstCourse.SelectedItems.Count = 0 Then
                MsgBox("Please select atleast one item from grid")
                lstCourse.Focus()
            End If
            DeleteCourse()
            btnNew.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub DeleteCourse()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Delete from Course where Cid=")
            str.AppendLine("" & txtCid.Text & "")
            server.DoConnect()
            server.ExecuteNonQuery(str.ToString)
            server.DisConnect()
            BindCourse()
            MsgBox("Record Deleted Successfully")
            txtCid.Text = ""
            txtcoursename.Text = ""
            txtDescription.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
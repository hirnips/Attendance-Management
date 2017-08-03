Imports System.Data
Imports System.Data.SqlClient
Imports WindowsApplication1.Utility
Imports System.Text

Public Class User_Input
    Dim Server As New SqlServer
    Dim Id, uid As Integer
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try
            Id = GetId()
            MsgBox("Please enter details for users now")
            txtUserId.Focus()
            btnInsert.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        Catch ex As Exception
        End Try
    End Sub
    Public Function GetId() As Integer
        Try
            server.DoConnect()
            Dim query As String = "Select max(Id) from UserDetails"
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
    Public Sub BindUsers()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Select * from UserDetails")
            Server.DoConnect()
            Dim ds As DataSet = Server.ExecuteDataSet(str.ToString)
            Server.DisConnect()
            If ds.Tables(0).Rows.Count > 0 Then
                lstvUser.Items.Clear()
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim str1(3) As String
                    str1(0) = ds.Tables(0).Rows(i).Item("UserType").ToString
                    str1(1) = ds.Tables(0).Rows(i).Item("Userid").ToString
                    str1(2) = ds.Tables(0).Rows(i).Item("Password").ToString
                    str1(3) = ds.Tables(0).Rows(i).Item("ID").ToString
                    Dim lst As New ListViewItem(str1)
                    lstvUser.Items.Add(lst)
                Next
            Else
                MsgBox("There is no record found into User table")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub User_Input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmbUsertype.SelectedIndex = 0
            btnInsert.Enabled = False
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            BindUsers()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Try
            If txtUserId.Text = "" Then
                MsgBox("Please enter value into userId TextBox")
                txtUserId.Focus()
                Exit Sub
            End If
            If txtPassword.Text = "" Then
                MsgBox("Please enter value into password TextBox")
                txtPassword.Focus()
                Exit Sub
            End If
            If txtConpass.Text = "" Then
                MsgBox("Please enter value into confirm password TextBox")
                txtConpass.Focus()
                Exit Sub
            End If
            If txtPassword.Text <> txtConpass.Text Then
                MsgBox("Please enter same password as into Password TextBox")
                txtConpass.Focus()
                Exit Sub
            End If
            InsertUser()
            btnNew.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub InsertUser()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Insert into UserDetails(id,userid,password,UserType) values")
            str.AppendLine("(")
            str.AppendLine("" & Id.ToString & ",'" & txtUserId.Text & "','" & txtPassword.Text & "','" & cmbUsertype.SelectedItem.ToString & "'")
            str.AppendLine(")")
            Server.DoConnect()
            Server.ExecuteNonQuery(str.ToString)
            Server.DisConnect()
            BindUsers()
            txtUserId.Text = ""
            txtPassword.Text = ""
            txtConpass .Text = ""
            btnNew.Enabled = True
            btnNew.Focus()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub lstvuser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvUser.SelectedIndexChanged
        Try
            If lstvUser.SelectedItems.Count = 1 Then
                uid = lstvUser.SelectedItems.Item(0).SubItems.Item(3).Text
                Dim str As New StringBuilder
                str.AppendLine("Select * from UserDetails where Id=")
                str.AppendLine("" & lstvUser.SelectedItems.Item(0).SubItems.Item(3).Text & "")
                Server.DoConnect()
                Dim ds As DataSet = Server.ExecuteDataSet(str.ToString)
                Server.DisConnect()
                txtUserId.Text = ds.Tables(0).Rows(0).Item("UserId").ToString
                txtPassword.Text = ds.Tables(0).Rows(0).Item("Password").ToString
                txtConpass.Text = ds.Tables(0).Rows(0).Item("Password").ToString

                If ds.Tables(0).Rows(0).Item("UserType").ToString = "Admin" Then
                    cmbUsertype.SelectedIndex = 0
                Else
                    cmbUsertype.SelectedIndex = 1
                End If
                cmbUsertype.Enabled = False
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
                txtUserId.Enabled = True
            Else
                MsgBox("You are alreadly select One Item please Click outside the grid")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If lstvUser.SelectedItems.Count = 0 Then
                MsgBox("Please select atleast one item from grid")
                lstvUser.Focus()
                Exit Sub
            End If
            If txtPassword.Text <> txtConpass.Text Then
                MsgBox("Please enter same password as into Password TextBox")
                txtConpass.Focus()
                Exit Sub
            End If
            Updateuser()
            btnNew.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub Updateuser()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Update UserDetails set UserId='")
            str.AppendLine("" & txtUserId.Text & "',password='" & txtPassword.Text & "'")
            str.AppendLine(" Where id=" & uid.ToString & "")
            Server.DoConnect()
            Server.ExecuteNonQuery(str.ToString)
            Server.DisConnect()
            MsgBox("Record Updated Successfully")
            BindUsers()
            txtUserId.Text = ""
            txtPassword.Text = ""
            txtConpass.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If lstvUser.SelectedItems.Count = 0 Then
                MsgBox("Please select atleast one item from grid")
                lstvUser.Focus()
                Exit Sub
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
            str.AppendLine("Delete from UserDetails where id=")
            str.AppendLine("" & uid.ToString & "")
            server.DoConnect()
            server.ExecuteNonQuery(str.ToString)
            server.DisConnect()
            BindUsers()
            MsgBox("Record Deleted Successfully")
            txtUserId.Text = ""
            txtPassword.Text = ""
            txtConpass.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
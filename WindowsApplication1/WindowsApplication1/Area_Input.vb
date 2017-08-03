Imports System.Data
Imports System.Data.SqlClient
Imports WindowsApplication1.Utility
Imports System.Text
Public Class Area_Input
    Dim server As New SqlServer
    Dim areaId As Integer


    Private Sub Area_Input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            btnUpdate.Enabled = False
            btnInsert.Enabled = False
            btnDelete.Enabled = False
            BindArea()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
    Public Sub BindArea()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Select * from Area_Input")
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(str.ToString)
            server.DisConnect()
            If ds.Tables(0).Rows.Count > 0 Then
                lstArea.Items.Clear()
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim str1(3) As String
                    str1(0) = ds.Tables(0).Rows(i).Item("areaid").ToString
                    str1(1) = ds.Tables(0).Rows(i).Item("areaname").ToString
                    str1(2) = ds.Tables(0).Rows(i).Item("areaDescription").ToString

                    Dim lst As New ListViewItem(str1)
                    lstArea.Items.Add(lst)
                Next
            Else
                MsgBox("There is no record found into Area table")
                lstArea.Items.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try
            areaId = getid()
            txtaid.Text = areaId.ToString
            txtaid.Enabled = False
            btnNew.Enabled = True
            btnInsert.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnClose.Enabled = True
            txtareaname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Function getid() As Integer
        Try
            server.DoConnect()
            Dim query As String = "Select max(areaId) from Area_Input"
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

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Try
            If txtaid.Text = "" Then
                MsgBox("Please Enter value into AreaID TextBox")
                txtaid.Focus()
                Exit Sub
            End If
            If txtareaname.Text = "" Then
                MsgBox("Please Enter value into AreaName TextBox")
                txtareaname.Focus()
                Exit Sub
            End If
            If txtDescription.Text = "" Then
                MsgBox("Please Enter value into AreaDescription TextBox")
                txtDescription.Focus()
                Exit Sub
            End If
            InsertArea()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub InsertArea()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Insert into Area_Input(areaid,areaname,areaDescription) values")
            str.AppendLine("(")
            str.AppendLine("" & txtaid.Text & ",'" & txtareaname.Text & "','" & txtDescription.Text & "'")
            str.AppendLine(")")
            server.DoConnect()
            server.ExecuteNonQuery(str.ToString)
            server.DisConnect()
            BindArea()
            txtaid.Text = ""
            txtareaname.Text = ""
            txtDescription.Text = ""
            btnNew.Enabled = True
            btnNew.Focus()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub lstArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstArea.SelectedIndexChanged
        Try
            If lstArea.SelectedItems.Count = 0 Then
                MsgBox("there is no item left into Grid")
                Exit Sub
            Else
                Dim str As New StringBuilder
                str.AppendLine("Select * from Area_Input where Areaid=")
                str.AppendLine("" & lstArea.SelectedItems.Item(0).SubItems.Item(0).Text & "")
                server.DoConnect()
                Dim ds As DataSet = server.ExecuteDataSet(str.ToString)
                server.DisConnect()
                txtaid.Text = ds.Tables(0).Rows(0).Item("Areaid").ToString
                txtareaname.Text = ds.Tables(0).Rows(0).Item("AreaName").ToString
                txtDescription.Text = ds.Tables(0).Rows(0).Item("AreaDescription").ToString
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
                txtaid.Enabled = False
            End If
           
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If lstArea.SelectedItems.Count = 0 Then
                MsgBox("Please select atleast one item from grid")
                lstArea.Focus()
                Exit Sub
            End If
            UpdateArea()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub UpdateArea()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Update Area_Input set AreaName='")
            str.AppendLine("" & txtareaname.Text & "',Areadescription='" & txtDescription.Text & "'")
            str.AppendLine(" Where areaid=" & txtaid.Text & "")
            server.DoConnect()
            server.ExecuteNonQuery(str.ToString)
            server.DisConnect()
            MsgBox("Record Updated Successfully")
            BindArea()
            txtaid.Text = ""
            txtareaname.Text = ""
            txtDescription.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If lstArea.SelectedItems.Count = 0 Then
                MsgBox("Please select atleast one item from grid")
                lstArea.Focus()
                Exit Sub
            End If
            DeleteArea()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub DeleteArea()
        Try
            Dim str As New StringBuilder
            str.AppendLine("Delete from Area_Input where Areaid=")
            str.AppendLine("" & txtaid.Text & "")
            server.DoConnect()
            server.ExecuteNonQuery(str.ToString)
            server.DisConnect()
            MsgBox("Record Deleted Successfully")
            BindArea()
            txtaid.Text = ""
            txtareaname.Text = ""
            txtDescription.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
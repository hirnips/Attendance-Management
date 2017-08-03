
Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text
Public Class Attandance
    Dim server As New SqlServer

    Private Sub btnserch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnserch.Click
        Dim str As String = txtrollno.Text
        If str = "" Then
            MsgBox("Please enter value into Rollno TextBox")
            txtrollno.Focus()
            Exit Sub
        End If
        Dim ans As Integer = AscW(str)
        If ans >= 65 And ans <= 102 Then
            MsgBox("You must have Enter Numberic value")
            txtrollno.Text = ""
            txtrollno.Focus()
        End If
        If str.Length >= 4 Then
            MsgBox("You Can't Enter More than Four Digit")
            txtrollno.Text = ""
            txtrollno.Focus()
            Exit Sub
        End If
        Try
            fillsname()
            fillcname()
            fillsubject()

        Catch ex As Exception
            ' MsgBox (ex.Message .ToString )
        End Try
    End Sub
    Public Sub fillsname()
        Dim roll As String = txtrollno.Text
        Try
            server.DoConnect()
            Dim qry As String = ("Select * from student_Master where Roll_No=" & roll.ToString)
            Dim ds As DataSet = server.ExecuteDataSet(qry)
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("Record Not Found for this Roll No")
            End If
            server.DisConnect()
            Dim str(2) As String
            str(0) = ds.Tables(0).Rows(0).Item("F_Name").ToString
            str(1) = ds.Tables(0).Rows(0).Item("M_Name").ToString
            str(2) = ds.Tables(0).Rows(0).Item("L_Name").ToString

            Dim name As String = str(0).ToString + " " + str(1).ToString + " " + str(2).ToString
            txtname.Text = name.ToString
        Catch ex As Exception
            ' MsgBox(ex.Message.ToString)
        End Try

    End Sub
    Public Sub fillcname()
        Dim roll As String = txtrollno.Text
        Try
            server.DoConnect()
            Dim qry As String = ("select * from student_Master where Roll_No=" & roll.ToString)
            Dim ds As DataSet = server.ExecuteDataSet(qry)
            Dim cid As String = ds.Tables(0).Rows(0).Item("Course").ToString
            Dim qry1 As String = ("select * from course where CID=" & cid.ToString)
            Dim ds1 As DataSet = server.ExecuteDataSet(qry1)
            server.DisConnect()
            txtcourse.Text = ds1.Tables(0).Rows(0).Item("CName").ToString
        Catch ex As Exception
            ' MsgBox (ex.Message .ToString )

        End Try
    End Sub
    Public Sub fillsubject()
        Dim roll As String = txtrollno.Text
        Try
            server.DoConnect()
            Dim qry As String = ("Select * from student_master where Roll_No=" & roll.ToString)
            Dim ds As DataSet = server.ExecuteDataSet(qry)
            Dim cid As String = ds.Tables(0).Rows(0).Item("Course")
            Dim qry1 As String = ("Select * from SubjectDetails where CId=" & cid.ToString)
            Dim ds1 As DataSet = server.ExecuteDataSet(qry1)
            server.DisConnect()
            cmbsubject.DataSource = ds1.Tables(0)
            cmbsubject.DisplayMember = "SubjectName"
            cmbsubject.ValueMember = "SubjectId"
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim roll As String = txtrollno.Text
        Try
            server.DoConnect()
            Dim Ldate As String = Now.Date.Date
            Dim qry As String = "Select * from Attandance where Rollno = " & roll.ToString & " And SubjectId=" & cmbsubject.SelectedValue.ToString & " And LoginDate= '" & Ldate.ToString & "'"
            Dim ds As DataSet = server.ExecuteDataSet(qry)
            server.DisConnect()
            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("Please select another subject or another batch type to login because you are already loggedin for this type")
                cmbsubject.Focus()
                Exit Sub
            Else
                fillTime()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub fillTime()
        Dim roll As String = txtrollno.Text
        Try
            server.DoConnect()
            Dim qry As String = ("Select * from student_Master where Roll_No=" & roll.ToString)
            Dim ds As DataSet = server.ExecuteDataSet(qry)
            Dim str1(2) As String
            str1(0) = ds.Tables(0).Rows(0).Item("F_Name").ToString
            str1(1) = ds.Tables(0).Rows(0).Item("M_Name").ToString
            str1(2) = ds.Tables(0).Rows(0).Item("L_Name").ToString
            Dim name As String = str1(0).ToString + " " + str1(1).ToString + " " + str1(2).ToString
            Dim cid As String = ds.Tables(0).Rows(0).Item("Course").ToString
            'Dim Cname As String = ds.Tables(0).Rows(0).Item("Cname")
            Dim sid As String = cmbsubject.SelectedValue.ToString
            'Dim sid As String = ds.Tables(0).Rows(0).Item("Subject").ToString
            'Dim SubName As String = ds.Tables(0).Rows(0).Item("SubjectName")
            Dim intime As String = Now.TimeOfDay.ToString
            Dim Ldate As String = Now.Date.Date
            ' Dim Present As String = (Utility.ConstantsAndEnums.presentstatus.Present)
            Dim str As New StringBuilder
            str.AppendLine("INSERT INTO Attandance (RollNo,StudentName,CourseId,SubjectId,Intime,LoginDate) VALUES")
            str.AppendLine("(")
            str.AppendLine("'" & roll.ToString & "','" & name.ToString & "','" & cid.ToString & "','" & sid.ToString & "','" & intime.ToString & "','" & Ldate.ToString & "'")
            str.AppendLine(")")
            server.ExecuteNonQuery(str.ToString)
            server.DisConnect()
            MsgBox("Login Successfully")
            txtrollno.Text = ""
            txtcourse.Text = ""
            txtname.Text = ""
            txtrollno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        If txtrollno.Text = "" And txtname.Text = "" Then
            MsgBox("You must have Enter Your Roll No")
            txtrollno.Focus()
            Exit Sub
        End If
        updateOuttime()
    End Sub
    Public Sub updateOuttime()
        Dim roll As String = txtrollno.Text
        Try
            server.DoConnect()
            Dim query As String = "Update Attandance set OutTime='" + Now.TimeOfDay.ToString + "'where RollNo ='" + roll.ToString + "'"
            Dim i As Object = server.ExecuteNonQuery(query)
            server.DisConnect()
            MsgBox("You have Successfully Logged Out")
            txtrollno.Text = ""
            txtcourse.Text = ""
            txtname.Text = ""
            txtrollno.Focus()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub
End Class


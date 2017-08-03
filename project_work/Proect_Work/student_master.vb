Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text

Public Class STUDENT_MASTER
    Dim server As New SqlServer
    Dim rollid As Integer
    Dim ifiles() As String
    Dim imagefileindex As Integer = 0
    Dim flag As Boolean

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Try
            rollid = getid()
            txtrollid.Text = rollid.ToString
            txtrollid.Enabled = True
            btnsave.Enabled = True
            btnedit.Enabled = False
            btndelete.Enabled = False
            txtsurname.Focus()
            txtname.Text = ""
            txtfather.Text = ""
            txtsurname.Text = ""
            txtdb.Text = ""
            txtaddress.Text = ""
            txtemail.Text = ""
            txtphone.Text = ""
            txtmobile.Text = ""
            txtfsname.Text = ""
            txtfname.Text = ""
            txtffname.Text = ""
            txtoccupa.Text = ""
            txtdesig.Text = ""
            txtfmobile.Text = ""
            cmbboard.SelectedItem.ToString()
            txtmedium.Text = ""
            txtyear.Text = ""
            txtpractical.Text = ""
            txtpercent.Text = ""
            txttot.Text = ""
            txtattamp.Text = ""
        Catch ex As Exception

        End Try
    End Sub
    Public Function getid() As Integer
        Try
            server.doconnect()
            Dim query As String = "select max(ROLL_NO)from STUDENT_MASTER"
            Dim id As Object = server.executescalar(query)
            server.DisConnect()
            If id Is Nothing OrElse IsDBNull(id) Then
                Return 1
            Else
                Return id + 1
            End If
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try
    End Function

    Private Sub STUDENT_MASTER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            btnsave.Enabled = False
            btnedit.Enabled = False
            btndelete.Enabled = False
            cmbboard.SelectedIndex = 0
            bindcourse()
            BindArea()
        Catch ex As Exception
            '' MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub BindArea()
        Try
            Dim qry As String = "Select * from Area_Input"
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(qry)
            server.DisConnect()
            cmbarea.DataSource = ds.Tables(0)
            cmbarea.DisplayMember = "AreaName"
            cmbarea.ValueMember = "AreaId"
        Catch ex As Exception
            '' MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub bindcourse()
        Try
            Dim qry As String = "select * from course"
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(qry)
            server.DisConnect()
            cmbcourse.DataSource = ds.Tables(0)
            cmbcourse.DisplayMember = "CName"
            cmbcourse.ValueMember = "CID"
            cmbcourse.SelectedIndex.ToString()
        Catch ex As Exception
            ''  MsgBox(ex.Message.ToString)
        End Try
    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            InsertStudent()
        Catch ex As Exception
            ''  MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub InsertStudent()
        If flag = True Then
            If txtrollid.Text = "" Then
                MsgBox("Please Enter value into roll no text box")
                txtrollid.Focus()
                Exit Sub
            End If
            If txtsurname.Text = "" Then
                MsgBox("Please Enter value into Surname Text box")
                txtsurname.Focus()
                Exit Sub
            End If
            If txtname.Text = "" Then
                MsgBox("Please Enter value into Name Text box")
                txtname.Focus()
                Exit Sub
            End If
            If txtfather.Text = "" Then
                MsgBox("Please Enter value into Father Name Text box")
                txtfather.Focus()
                Exit Sub
            End If
            If txtdb.Text = "" Then
                MsgBox("Please Enter value into DOB Text box")
                txtdb.Focus()
                Exit Sub
            End If
            If txtaddress.Text = "" Then
                MsgBox("Please Enter value into Address Text box")
                txtaddress.Focus()
                Exit Sub
            End If
            If txtemail.Text = "" Then
                MsgBox("Please Enter value into E-mail ID Text box")
                txtemail.Focus()
                Exit Sub
            End If
            If txtphone.Text = "" Then
                MsgBox("Please Enter value into Phone Number Text box")
                txtphone.Focus()
                Exit Sub
            End If
            If txtmobile.Text = "" Then
                MsgBox("Please Enter value into Mobile Number Text box")
                txtmobile.Focus()
                Exit Sub
            End If
            If txtfsname.Text = "" Then
                MsgBox("Please Enter value into Father's surname Text box")
                txtfsname.Focus()
                Exit Sub
            End If
            If txtfname.Text = "" Then
                MsgBox("Please Enter value into Father's Name Text box")
                txtfname.Focus()
                Exit Sub
            End If
            If txtffname.Text = "" Then
                MsgBox("Please Enter value into Father's Last name Text box")
                txtffname.Focus()
                Exit Sub
            End If
            If txtoccupa.Text = "" Then
                MsgBox("Please Enter value into Occupation Text box")
                txtoccupa.Focus()
                Exit Sub
            End If
            If txtdesig.Text = "" Then
                MsgBox("Please Enter value into Designation Text box")
                txtdesig.Focus()
                Exit Sub
            End If
            If txtfmobile.Text = "" Then
                MsgBox("Please Enter value into Father's Mobile Number Text box")
                txtfmobile.Focus()
                Exit Sub
            End If

            If txtmedium.Text = "" Then
                MsgBox("Please Enter value into Mrdium Text box")
                txtmedium.Focus()
                Exit Sub
            End If
            If txtyear.Text = "" Then
                MsgBox("Please Enter value into Month and year Text box")
                txtyear.Focus()
                Exit Sub
            End If
            If txtpractical.Text = "" Then
                MsgBox("Please Enter value into Total marks with Practical Text box")
                txtpractical.Focus()
                Exit Sub
            End If
            If txtpercent.Text = "" Then
                MsgBox("Please Enter value into percentage Text box")
                txtpercent.Focus()
                Exit Sub
            End If
            If txttot.Text = "" Then
                MsgBox("Please Enter value into Total marks out of Text box")
                txttot.Focus()
                Exit Sub
            End If
            If txtattamp.Text = "" Then
                MsgBox("Please Enter value into Total Attemps Text box")
                txtattamp.Focus()

                Exit Sub
            End If
            If cmbcourse.Text = "" Then
                MsgBox("Please Select Value into DropDown Box")
                cmbcourse.Focus()
            End If
            If cmbarea.Text = "" Then
                MsgBox("Please Select Value into Area DropDown Box")
                cmbarea.Focus()
            End If
            Try
                Dim gender As String
                If rdofemale.Checked = True Then
                    gender = "Female"
                Else
                    gender = "Male"
                End If
                Dim studentID = getid()
                For i As Integer = 0 To lstsubject.SelectedItems.Count - 1

                    Dim str As New StringBuilder
                    str.AppendLine("Insert into student_master(ROLL_NO,F_NAME,M_NAME,L_NAME,STU_EMAIL,PER_ADDRESS,PHONE_HOME,MOBILE_NO,")
                    str.AppendLine("SEX,DOB,FA_NAME,FA_MNAME,FA_LNAME,OCCUPATION,DESIGNATION,FA_MOBILE,BOARD,MEDIUM,YEAR,PRACTICAL,PERC,TOTAL,ATTAMPT,COURSE,SUBJECT,AREA) values")
                    str.AppendLine("(")
                    str.AppendLine("" & txtrollid.Text & ",'" & txtsurname.Text & "','" & txtname.Text & "','" & txtfather.Text & "','" & txtemail.Text & "'")
                    str.AppendLine(",'" & txtaddress.Text & "'," & txtphone.Text & "," & txtmobile.Text & ",'" & gender.ToString & "'")
                    str.AppendLine(",'" & txtdb.Text & "','" & txtfsname.Text & "','" & txtfname.Text & "','" & txtffname.Text & "','" & txtoccupa.Text & "'")
                    str.AppendLine(",'" & txtdesig.Text & "'," & txtfmobile.Text & ",'" & cmbboard.SelectedItem.ToString & "','" & txtmedium.Text & "','" & txtyear.Text & "','" & txtpractical.Text & "'," & txtpercent.Text & "")
                    str.AppendLine("," & txttot.Text & "," & txtattamp.Text & ",'" & cmbcourse.SelectedValue.ToString & "','" & lstsubject.SelectedItems.Item(i).SubItems.Item(1).Text & "'," & cmbarea.SelectedValue.ToString & "")
                    str.AppendLine(")")
                    server.DoConnect()
                    server.ExecuteNonQuery(str.ToString)
                    server.DisConnect()
                    flag = False
                Next
            Catch ex As Exception
                '' MsgBox(ex.Message.ToString)
            End Try
        Else
            If txtrollid.Text = "" Then
                MsgBox("Please Enter value into roll no text box")
                txtrollid.Focus()
                Exit Sub
            End If
            If txtsurname.Text = "" Then
                MsgBox("Please Enter value into Surname Text box")
                txtsurname.Focus()
                Exit Sub
            End If
            If txtname.Text = "" Then
                MsgBox("Please Enter value into Name Text box")
                txtname.Focus()
                Exit Sub
            End If
            If txtfather.Text = "" Then
                MsgBox("Please Enter value into Father Name Text box")
                txtfather.Focus()
                Exit Sub
            End If
            If txtdb.Text = "" Then
                MsgBox("Please Enter value into DOB Text box")
                txtdb.Focus()
                Exit Sub
            End If
            If txtaddress.Text = "" Then
                MsgBox("Please Enter value into Address Text box")
                txtaddress.Focus()
                Exit Sub
            End If
            If txtemail.Text = "" Then
                MsgBox("Please Enter value into E-mail ID Text box")
                txtemail.Focus()
                Exit Sub
            End If
            If txtphone.Text = "" Then
                MsgBox("Please Enter value into Phone Number Text box")
                txtphone.Focus()
                Exit Sub
            End If
            If txtmobile.Text = "" Then
                MsgBox("Please Enter value into Mobile Number Text box")
                txtmobile.Focus()
                Exit Sub
            End If
            If txtfsname.Text = "" Then
                MsgBox("Please Enter value into Father's surname Text box")
                txtfsname.Focus()
                Exit Sub
            End If
            If txtfname.Text = "" Then
                MsgBox("Please Enter value into Father's Name Text box")
                txtfname.Focus()
                Exit Sub
            End If
            If txtffname.Text = "" Then
                MsgBox("Please Enter value into Father's Last name Text box")
                txtffname.Focus()
                Exit Sub
            End If
            If txtoccupa.Text = "" Then
                MsgBox("Please Enter value into Occupation Text box")
                txtoccupa.Focus()
                Exit Sub
            End If
            If txtdesig.Text = "" Then
                MsgBox("Please Enter value into Designation Text box")
                txtdesig.Focus()
                Exit Sub
            End If
            If txtfmobile.Text = "" Then
                MsgBox("Please Enter value into Father's Mobile Number Text box")
                txtfmobile.Focus()
                Exit Sub
            End If

            If txtmedium.Text = "" Then
                MsgBox("Please Enter value into Mrdium Text box")
                txtmedium.Focus()
                Exit Sub
            End If
            If txtyear.Text = "" Then
                MsgBox("Please Enter value into Month and year Text box")
                txtyear.Focus()
                Exit Sub
            End If
            If txtpractical.Text = "" Then
                MsgBox("Please Enter value into Total marks with Practical Text box")
                txtpractical.Focus()
                Exit Sub
            End If
            If txtpercent.Text = "" Then
                MsgBox("Please Enter value into percentage Text box")
                txtpercent.Focus()
                Exit Sub
            End If
            If txttot.Text = "" Then
                MsgBox("Please Enter value into Total marks out of Text box")
                txttot.Focus()
                Exit Sub
            End If
            If txtattamp.Text = "" Then
                MsgBox("Please Enter value into Total Attemps Text box")
                txtattamp.Focus()

                Exit Sub
            End If
            If cmbcourse.Text = "" Then
                MsgBox("Please Select Value into DropDown Box")
                cmbcourse.Focus()
            End If
            If cmbarea.Text = "" Then
                MsgBox("Please Select Value into Area DropDown Box")
                cmbarea.Focus()
            End If
            Try
                Dim gender As String
                If rdofemale.Checked = True Then
                    gender = "Female"
                Else
                    gender = "Male"
                End If
                Dim studentID = getid()
                For i As Integer = 0 To lstsubject.SelectedItems.Count - 1
                    Dim str As New StringBuilder
                    str.AppendLine("Insert into student_master(ROLL_NO,F_NAME,M_NAME,L_NAME,STU_EMAIL,PER_ADDRESS,PHONE_HOME,MOBILE_NO,")
                    str.AppendLine("SEX,DOB,FA_NAME,FA_MNAME,FA_LNAME,OCCUPATION,DESIGNATION,FA_MOBILE,BOARD,MEDIUM,YEAR,PRACTICAL,PERC,TOTAL,ATTAMPT,COURSE,SUBJECT,AREA) values")
                    str.AppendLine("(")
                    str.AppendLine("" & txtrollid.Text & ",'" & txtsurname.Text & "','" & txtname.Text & "','" & txtfather.Text & "','" & txtemail.Text & "'")
                    str.AppendLine(",'" & txtaddress.Text & "'," & txtphone.Text & "," & txtmobile.Text & ",'" & gender.ToString & "'")
                    str.AppendLine(",'" & txtdb.Text & "','" & txtfsname.Text & "','" & txtfname.Text & "','" & txtffname.Text & "','" & txtoccupa.Text & "'")
                    str.AppendLine(",'" & txtdesig.Text & "'," & txtfmobile.Text & ",'" & cmbboard.SelectedItem.ToString & "','" & txtmedium.Text & "','" & txtyear.Text & "','" & txtpractical.Text & "'," & txtpercent.Text & "")
                    str.AppendLine("," & txttot.Text & "," & txtattamp.Text & ",'" & cmbcourse.SelectedValue.ToString & "','" & lstsubject.SelectedItems.Item(i).SubItems.Item(1).Text & "'," & cmbarea.SelectedValue.ToString & "")
                    str.AppendLine(")")
                    server.DoConnect()
                    server.ExecuteNonQuery(str.ToString)
                    server.DisConnect()
                Next
                txtrollid.Text = ""
                txtname.Text = ""
                txtfather.Text = ""
                txtsurname.Text = ""
                txtdb.Text = ""
                txtaddress.Text = ""
                txtemail.Text = ""
                txtphone.Text = ""
                txtmobile.Text = ""
                txtfsname.Text = ""
                txtfname.Text = ""
                txtffname.Text = ""
                txtoccupa.Text = ""
                txtdesig.Text = ""
                txtfmobile.Text = ""
                cmbboard.SelectedItem.ToString()
                txtmedium.Text = ""
                txtyear.Text = ""
                txtpractical.Text = ""
                txtpercent.Text = ""
                txttot.Text = ""
                txtattamp.Text = ""
                ptustudent.Image = Nothing
                cmbcourse.Text = ""
                cmbarea.Text = ""
                btnnew.Enabled = True
                btnsave.Enabled = False
                btnnew.Focus()
                MsgBox("Your Record Successfully Inserted")
            Catch ex As Exception
                ''MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            DeleteStudent()
        Catch ex As Exception
            '' MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub DeleteStudent()
        Try
            If flag = True Then
                If txtrollid.Text = "" Then
                    MsgBox("Please enter value into Rollno TextBox")
                    txtrollid.Focus()
                    Exit Sub
                End If
                Dim str As New StringBuilder
                str.AppendLine("delete from student_master where roll_no=")
                str.AppendLine("" & txtrollid.Text & "")
                server.DoConnect()
                server.ExecuteNonQuery(str.ToString)
                server.DisConnect()
            Else
                If txtrollid.Text = "" Then
                    MsgBox("Please enter value into Rollno TextBox")
                    txtrollid.Focus()
                    Exit Sub
                End If
                Dim str As New StringBuilder
                str.AppendLine("delete from student_master where roll_no=")
                str.AppendLine("" & txtrollid.Text & "")
                server.DoConnect()
                server.ExecuteNonQuery(str.ToString)
                server.DisConnect()
                MsgBox("Record delete Succssesfully")

                txtrollid.Text = ""
                txtname.Text = ""
                txtfather.Text = ""
                txtsurname.Text = ""
                txtdb.Text = ""
                txtaddress.Text = ""
                txtemail.Text = ""
                txtphone.Text = ""
                txtmobile.Text = ""
                txtfsname.Text = ""
                txtfname.Text = ""
                txtffname.Text = ""
                txtoccupa.Text = ""
                txtdesig.Text = ""
                txtfmobile.Text = ""
                cmbboard.SelectedItem.ToString()
                txtmedium.Text = ""
                txtyear.Text = ""
                txtpractical.Text = ""
                txtpercent.Text = ""
                txttot.Text = ""
                txtattamp.Text = ""
            End If
        Catch ex As Exception
            ''  MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Try
            flag = True
            DeleteStudent()
            InsertStudent()
            MsgBox("Record Updated Successfully")
        Catch ex As Exception
            '' MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub UpdateStudent()
        Try
            If txtrollid.Text = "" Then
                MsgBox("Please Enter value into roll no text box")
                txtrollid.Focus()
                Exit Sub
            End If
            If txtsurname.Text = "" Then
                MsgBox("Please Enter value into Surname Text box")
                txtsurname.Focus()
                Exit Sub
            End If
            If txtname.Text = "" Then
                MsgBox("Please Enter value into Name Text box")
                txtname.Focus()
                Exit Sub
            End If
            If txtfather.Text = "" Then
                MsgBox("Please Enter value into Father Name Text box")
                txtfather.Focus()
                Exit Sub
            End If
            If txtdb.Text = "" Then
                MsgBox("Please Enter value into DOB Text box")
                txtdb.Focus()
                Exit Sub
            End If
            If txtaddress.Text = "" Then
                MsgBox("Please Enter value into Address Text box")
                txtaddress.Focus()
                Exit Sub
            End If
            If txtemail.Text = "" Then
                MsgBox("Please Enter value into E-mail ID Text box")
                txtemail.Focus()
                Exit Sub
            End If
            If txtphone.Text = "" Then
                MsgBox("Please Enter value into Phone Number Text box")
                txtphone.Focus()
                Exit Sub
            End If
            If txtmobile.Text = "" Then
                MsgBox("Please Enter value into Mobile Number Text box")
                txtmobile.Focus()
                Exit Sub
            End If
            If txtfsname.Text = "" Then
                MsgBox("Please Enter value into Father's surname Text box")
                txtfsname.Focus()
                Exit Sub
            End If
            If txtfname.Text = "" Then
                MsgBox("Please Enter value into Father's Name Text box")
                txtfname.Focus()
                Exit Sub
            End If
            If txtffname.Text = "" Then
                MsgBox("Please Enter value into Father's Last name Text box")
                txtffname.Focus()
                Exit Sub
            End If
            If txtoccupa.Text = "" Then
                MsgBox("Please Enter value into Occupation Text box")
                txtoccupa.Focus()
                Exit Sub
            End If
            If txtdesig.Text = "" Then
                MsgBox("Please Enter value into Designation Text box")
                txtdesig.Focus()
                Exit Sub
            End If
            If txtfmobile.Text = "" Then
                MsgBox("Please Enter value into Father's Mobile Number Text box")
                txtfmobile.Focus()
                Exit Sub
            End If

            If txtmedium.Text = "" Then
                MsgBox("Please Enter value into Mrdium Text box")
                txtmedium.Focus()
                Exit Sub
            End If
            If txtyear.Text = "" Then
                MsgBox("Please Enter value into Month and year Text box")
                txtyear.Focus()
                Exit Sub
            End If
            If txtpractical.Text = "" Then
                MsgBox("Please Enter value into Total marks with Practical Text box")
                txtpractical.Focus()
                Exit Sub
            End If
            If txtpercent.Text = "" Then
                MsgBox("Please Enter value into percentage Text box")
                txtpercent.Focus()
                Exit Sub
            End If
            If txttot.Text = "" Then
                MsgBox("Please Enter value into Total marks out of Text box")
                txttot.Focus()
                Exit Sub
            End If
            If txtattamp.Text = "" Then
                MsgBox("Please Enter value into Total Attemps Text box")
                txtattamp.Focus()
                Exit Sub
            End If
            Dim gender As String
            If rdofemale.Checked = True Then
                gender = "Female"
            Else
                gender = "Male"
            End If
            For i As Integer = 0 To lstsubject.SelectedItems.Count - 1
                Dim str As New StringBuilder
                str.AppendLine("Update Student_Master set F_NAME='" & txtsurname.Text & "',M_NAME='" & txtname.Text & "',L_NAME='")
                str.AppendLine("" & txtfather.Text & "',STU_EMAIL='" & txtemail.Text & "',PER_ADDRESS='" & txtaddress.Text & "',PHONE_HOME=")
                str.AppendLine("" & txtphone.Text & ",MOBILE_NO=" & txtmobile.Text & ",SEX='" & gender.ToString & "',DOB='" & txtdb.Text & "',")
                str.AppendLine("FA_NAME='" & txtfsname.Text & "',FA_MNAME='" & txtfname.Text & "',FA_LNAME='")
                str.AppendLine("" & txtffname.Text & "',OCCUPATION='" & txtoccupa.Text & "',DESIGNATION='" & txtdesig.Text & "',FA_MOBILE=")
                str.AppendLine("" & txtfmobile.Text & ",BOARD='" & cmbboard.SelectedItem.ToString & "',MEDIUM='" & txtmedium.Text & "',YEAR='")
                str.AppendLine("" & txtyear.Text & "',PRACTICAL=" & txtpractical.Text & ",PERC=" & txtpercent.Text & ",")
                str.AppendLine("TOTAL=" & txttot.Text & ",ATTAMPT=" & txtattamp.Text & ",Course=" & cmbcourse.SelectedValue.ToString & ",Subject=" & lstsubject.SelectedItems.Item(i).SubItems.Item(1).Text & ",Area=" & cmbarea.SelectedValue.ToString & "")
                str.AppendLine("where Roll_No=" & txtrollid.Text & "")
                server.DoConnect()
                server.ExecuteNonQuery(str.ToString)
                server.DisConnect()
            Next

            MsgBox("Your Record update successfully")
            txtrollid.Text = ""
            txtname.Text = ""
            txtfather.Text = ""
            txtsurname.Text = ""
            txtdb.Text = ""
            txtaddress.Text = ""
            txtemail.Text = ""
            txtphone.Text = ""
            txtmobile.Text = ""
            txtfsname.Text = ""
            txtfname.Text = ""
            txtffname.Text = ""
            txtoccupa.Text = ""
            txtdesig.Text = ""
            txtfmobile.Text = ""
            cmbboard.SelectedItem.ToString()
            txtmedium.Text = ""
            txtyear.Text = ""
            txtpractical.Text = ""
            txtpercent.Text = ""
            txttot.Text = ""
            txtattamp.Text = ""
        Catch ex As Exception
            ''   MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub btnserch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnserch.Click
        Try
            If txtrollid.Text = "" Then
                MsgBox("Please enter value into RollId")
                txtrollid.Focus()
                txtrollid.Text = ""
                Exit Sub
            End If
            btnedit.Enabled = True
            btnsave.Enabled = False
            btndelete.Enabled = True
            Dim str As New StringBuilder
            str.AppendLine("select * from student_master where Roll_No=")
            str.AppendLine("" & txtrollid.Text & "")
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(str.ToString)
            server.DisConnect()
            If ds.Tables(0).Rows.Count > 0 Then
                txtsurname.Text = ds.Tables(0).Rows(0).Item("F_NAME").ToString
                txtname.Text = ds.Tables(0).Rows(0).Item("M_NAME").ToString
                txtfather.Text = ds.Tables(0).Rows(0).Item("L_NAME").ToString
                txtaddress.Text = ds.Tables(0).Rows(0).Item("PER_ADDRESS").ToString
                txtemail.Text = ds.Tables(0).Rows(0).Item("STU_EMAIL").ToString
                txtphone.Text = ds.Tables(0).Rows(0).Item("PHONE_HOME").ToString
                txtmobile.Text = ds.Tables(0).Rows(0).Item("MOBILE_NO").ToString
                If UCase(ds.Tables(0).Rows(0).Item("SEX").ToString) = UCase("Male") Then
                    rdomale.Checked = True
                Else
                    rdofemale.Checked = True
                End If
                If UCase(ds.Tables(0).Rows(0).Item("BOARD").ToString) = UCase("CBSE") Then
                    cmbboard.SelectedIndex = 1
                Else
                    cmbboard.SelectedIndex = 0
                End If
                txtdb.Value = ds.Tables(0).Rows(0).Item("DOB").ToString
                txtfsname.Text = ds.Tables(0).Rows(0).Item("FA_NAME").ToString
                txtfname.Text = ds.Tables(0).Rows(0).Item("FA_MNAME").ToString
                txtffname.Text = ds.Tables(0).Rows(0).Item("FA_LNAME").ToString
                txtoccupa.Text = ds.Tables(0).Rows(0).Item("OCCUPATION").ToString
                txtdesig.Text = ds.Tables(0).Rows(0).Item("DESIGNATION").ToString
                txtfmobile.Text = ds.Tables(0).Rows(0).Item("FA_MOBILE").ToString
                txtmedium.Text = ds.Tables(0).Rows(0).Item("MEDIUM").ToString
                txtyear.Text = ds.Tables(0).Rows(0).Item("YEAR").ToString
                txtpractical.Text = ds.Tables(0).Rows(0).Item("PRACTICAL").ToString
                txtpercent.Text = ds.Tables(0).Rows(0).Item("PERC").ToString
                txttot.Text = ds.Tables(0).Rows(0).Item("TOTAL").ToString
                txtattamp.Text = ds.Tables(0).Rows(0).Item("ATTAMPT").ToString
                cmbcourse.SelectedValue = ds.Tables(0).Rows(0).Item("COURSE").ToString
                cmbarea.SelectedValue = ds.Tables(0).Rows(0).Item("AREA").ToString

            Else
                MsgBox("There is no record found for this rollno")
                txtrollid.Text = ""
                txtrollid.Focus()
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbcourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            server.DoConnect()
            Dim CourseQry As String = "Select * from Subjectdetails where CId=" + cmbcourse.SelectedValue.ToString + ""
            Dim ds1 As DataSet = server.ExecuteDataSet(CourseQry)
            server.DisConnect()
            lstsubject.Items.Clear()
            For i As Integer = 0 To ds1.Tables(0).Rows.Count - 1
                Dim str(2) As String
                str(0) = ds1.Tables(0).Rows(i).Item("SubjectName").ToString
                str(1) = ds1.Tables(0).Rows(i).Item("SubjectID").ToString
                Dim lst As New ListViewItem(str)
                lstsubject.Items.Add(lst)
            Next
        Catch ex As Exception
            ''  MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub txtrollid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrollid.TextChanged

    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            server.DoConnect()
            ofdPhoto.ShowDialog()
            If ofdPhoto.FileName Is Nothing Then
                MsgBox("Please select photo to upload")
                Exit Sub
            End If
            If ofdPhoto.FileName.EndsWith(".jpg") = True Or ofdPhoto.FileName.EndsWith(".gif") = True Or ofdPhoto.FileName.EndsWith(".bmp") = True Then
                ptustudent.ImageLocation = ofdPhoto.FileName
                ptustudent.Load()
            Else
                MsgBox("Please select any photo not a file")
                Exit Sub
            End If

        Catch ex As Exception
            ''  MsgBox(ex.Message.ToString)
        End Try

    End Sub


End Class
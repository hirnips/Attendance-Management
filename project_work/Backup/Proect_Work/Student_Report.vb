Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text
Public Class Student_Report
    Dim server As New SqlServer
    Private Sub Student_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindArea()
            BindStudent()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub BindArea()
        Try
            Dim areastr As New StringBuilder
            areastr.AppendLine("select * from Area_Input")
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(areastr.ToString)
            server.DisConnect()
            cmbarea.DataSource = ds.Tables(0)
            cmbarea.DisplayMember = "AreaName"
            cmbarea.ValueMember = "AreaID"
        Catch ex As Exception
        End Try
    End Sub
    Public Sub BindStudent()
        Try
            Dim qry As String
            qry = "Select * from Student_Master"
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(qry)
            server.DisConnect()
            If ds.Tables(0).Rows.Count > 0 Then
                lstReport.Items.Clear()
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim str1(6) As String
                    str1(0) = ds.Tables(0).Rows(i).Item("ROLL_NO").ToString
                    Dim name As String = ds.Tables(0).Rows(i).Item("F_Name").ToString + " " + ds.Tables(0).Rows(i).Item("M_Name").ToString + " " + ds.Tables(0).Rows(i).Item("L_Name").ToString
                    str1(1) = name.ToString 'ds.Tables(0).Rows(i).Item("M_NAME").ToString
                    str1(2) = ds.Tables(0).Rows(i).Item("MOBILE_NO").ToString
                    str1(3) = ds.Tables(0).Rows(i).Item("FA_MOBILE").ToString
                    str1(4) = ds.Tables(0).Rows(i).Item("COURSE").ToString
                    str1(5) = ds.Tables(0).Rows(i).Item("STU_EMAIL").ToString
                    str1(6) = ds.Tables(0).Rows(i).Item("SUBJECT").ToString
                    Dim lst As New ListViewItem(str1)
                    lstReport.Items.Add(lst)
                Next
            Else
                MsgBox("There is no record found into student table")
                lstReport.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cmbarea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbarea.SelectedIndexChanged
        Try
            BindAreaWiseStudent()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub BindAreaWiseStudent()
        Try
            Dim strar As New StringBuilder
            strar.AppendLine("Select * from Student_Master Where Area=" & cmbarea.SelectedValue.ToString & "")
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(strar.ToString)
            server.DisConnect()
            If ds.Tables(0).Rows.Count > 0 Then
                lstReport.Items.Clear()
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    Dim str1(6) As String
                    str1(0) = ds.Tables(0).Rows(i).Item("ROLL_NO").ToString
                    Dim name As String = ds.Tables(0).Rows(i).Item("F_Name").ToString + " " + ds.Tables(0).Rows(i).Item("M_Name").ToString + " " + ds.Tables(0).Rows(i).Item("L_Name").ToString
                    str1(1) = name.ToString 'ds.Tables(0).Rows(i).Item("M_NAME").ToString
                    str1(2) = ds.Tables(0).Rows(i).Item("MOBILE_NO").ToString
                    str1(3) = ds.Tables(0).Rows(i).Item("FA_MOBILE").ToString
                    str1(4) = ds.Tables(0).Rows(i).Item("COURSE").ToString
                    str1(5) = ds.Tables(0).Rows(i).Item("STU_EMAIL").ToString
                    str1(6) = ds.Tables(0).Rows(i).Item("SUBJECT").ToString
                    Dim lst As New ListViewItem(str1)
                    lstReport.Items.Add(lst)
                Next
            Else
                MsgBox("There is no record found into student table")
                lstReport.Items.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Linkarea_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Linkarea.LinkClicked
        Try
            BindStudent()
        Catch ex As Exception

        End Try
    End Sub
End Class
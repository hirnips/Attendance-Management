Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text
Public Class course_Report
    Dim server As New SqlServer
    Dim CourseId As Integer
    Private Sub lblHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub course_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindCourse()
        Catch ex As Exception

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
End Class
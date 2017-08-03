Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text
Public Class Area_Report
    Dim server As New SqlServer
    Dim areaId As Integer

    Private Sub Area_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindArea()

        Catch ex As Exception

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

    Private Sub lstArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstArea.SelectedIndexChanged

    End Sub
End Class
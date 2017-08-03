Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text

Public Class Subject_Report
    Dim server As New SqlServer
    Dim sbjectid As Integer
    Private Sub Subject_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindGrid()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub BindGrid()
        Try
            Dim query As String = "Select c.CID, s.SubjectId, s.SubjectName,s.Description From subjectdetails s left outer join Course c on c.CID=s.CID"
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(query)
            server.DisConnect()

            lstSubject.Items.Clear()
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Dim str(4) As String
                str(0) = ds.Tables(0).Rows(i).Item("CID") & ""
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
End Class
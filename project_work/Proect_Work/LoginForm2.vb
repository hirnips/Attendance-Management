Imports System.Data
Imports System.Data.SqlClient
Imports Proect_Work.Utility
Imports System.Text
Public Class LoginForm2

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If cmbUsertype.SelectedItem.ToString = "Admin" Then
            MyModule.Users = UCase("admin")
            If txtpass.Text = "akshay" Then
                MDI.Show()
                Me.Hide()
            Else
                MsgBox("Please enter correct password")
                txtpass.Focus()
                Exit Sub
            End If
        Else
            MyModule.Users = UCase("Student")
            If txtpass.Text = "student" Then
                MDI.Show()
                Me.Hide()
            Else
                MsgBox("Please Enter correct UserId")
                cmbUsertype.Focus()
                Exit Sub
            End If

        End If
    End Sub

    Private Sub LoginForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbUsertype.SelectedIndex = 0
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class

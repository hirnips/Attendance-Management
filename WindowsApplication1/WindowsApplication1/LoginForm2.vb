Imports System.Data
Imports System.Data.SqlClient
Imports WindowsApplication1.Utility
Imports System.Text
Public Class LoginForm2

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Dim server As New SqlServer
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click

        Dim Utype As String
        Dim Usid As String
        Dim pswd As String

        Try
            Dim str As String = "Select * from UserDetails"
            server.DoConnect()
            Dim ds As DataSet = server.ExecuteDataSet(str)
            server.DisConnect()
            If ds.Tables(0).Rows.Count > 0 Then
                Usid = ds.Tables(0).Rows(0).Item("UserId").ToString
                pswd = ds.Tables(0).Rows(0).Item("Password").ToString
                Utype = ds.Tables(0).Rows(0).Item("UserType").ToString
            Else
                MsgBox("There is no Record found")
                txtUser.Text = ""
                txtpass.Text = ""
                cmbUsertype.SelectedIndex = 0
                txtUser.Focus()
            End If

            If txtUser.Text = Usid.ToString Then
                If cmbUsertype.SelectedItem.ToString = Utype.ToString Then
                    If txtpass.Text = pswd.ToString Then
                        MsgBox("You have logged in Successfully")
                    Else
                        MsgBox("Please enter valid Password")
                    End If
                Else
                    MsgBox("Please select valid UserType")
                End If
            Else
                MsgBox("Please enter valid Username")
            End If


            'If cmbUsertype.SelectedItem.ToString = "Admin" Then
            '    MyModule.Users = UCase("admin")
            '    If txtpass.Text = "akshay" Then
            '        ' MDI.Show()
            '        Me.Hide()
            '    Else
            '        MsgBox("Please enter correct password")
            '        txtpass.Focus()
            '        Exit Sub
            '    End If
            'Else
            '    MyModule.Users = UCase("Student")
            '    If txtpass.Text = "student" Then
            '        'MDI.Show()
            '        Me.Hide()
            '    Else
            '        MsgBox("Please Enter correct UserId")
            '        cmbUsertype.Focus()
            '        Exit Sub
            '    End If
            'End If

            'If cmbUsertype.SelectedItem.ToString = "Admin" Then
            '    MyModule.Users = UCase("admin")
            '    If txtpass.Text = "akshay" Then
            '        ' MDI.Show()
            '        Me.Hide()
            '    Else
            '        MsgBox("Please enter correct password")
            '        txtpass.Focus()
            '        Exit Sub
            '    End If
            'Else
            '    MyModule.Users = UCase("Student")
            '    If txtpass.Text = "student" Then
            '        'MDI.Show()
            '        Me.Hide()
            '    Else
            '        MsgBox("Please Enter correct UserId")
            '        cmbUsertype.Focus()
            '        Exit Sub
            '    End If

            'End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub LoginForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbUsertype.SelectedIndex = 0
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class

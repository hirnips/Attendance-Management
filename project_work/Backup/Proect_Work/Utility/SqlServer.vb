Imports System.Data
Imports System.Data.SqlClient

Namespace Utility
    Public Class SqlServer

        Private mServerName As String
        Private mDatabaseName As String
        Private mUserName As String
        Private mPassword As String

        Private mSqlConnection As SqlConnection

        ''' <summary>
        ''' Set or Get Server Name
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ServerName() As String
            Get
                Return mServerName
            End Get
            Set(ByVal value As String)
                mServerName = value
            End Set
        End Property

        ''' <summary>
        ''' Set or Get Database Name
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DatabaseName() As String
            Get
                Return mDatabaseName
            End Get
            Set(ByVal value As String)
                mDatabaseName = value
            End Set
        End Property

        ''' <summary>
        ''' Set or Get User Name
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property UserName() As String
            Get
                Return mUserName
            End Get
            Set(ByVal value As String)
                mUserName = value
            End Set
        End Property

        ''' <summary>
        ''' Set or Get Password
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Password() As String
            Get
                Return mPassword
            End Get
            Set(ByVal value As String)
                mPassword = value
            End Set
        End Property

        ''' <summary>
        ''' Connect to the Server
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DoConnect()

            Try
                Dim connectionStr As String = "Data Source=KARTIK-PC\SQLEXPRESS;Initial Catalog=Test1;Integrated Security=True"
                mSqlConnection = New SqlConnection(connectionStr)
                mSqlConnection.Open()
            Catch ex As Exception
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' DisConnect from the Server
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DisConnect()
            Try
                If mSqlConnection.State <> ConnectionState.Closed Then
                    mSqlConnection.Close()
                    mSqlConnection = Nothing
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' Executes the query and returns rows affected
        ''' </summary>
        ''' <param name="query"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ExecuteNonQuery(ByVal query As String) As Integer
            Dim datacmd As SqlCommand
            Dim result As Integer
            Try
                datacmd = New SqlCommand(query, mSqlConnection)
                result = datacmd.ExecuteNonQuery
                Return result
            Catch ex As Exception
                Throw
            Finally
                datacmd = Nothing
            End Try
        End Function

        ''' <summary>
        ''' Executes the query and returns first column of first row
        ''' </summary>
        ''' <param name="query"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ExecuteScalar(ByVal query As String) As Object
            Dim datacmd As SqlCommand
            Dim result As Object
            Try
                datacmd = New SqlCommand(query, mSqlConnection)
                result = datacmd.ExecuteScalar
                Return result
            Catch ex As Exception
                Throw
            Finally
                datacmd = Nothing
            End Try
        End Function


        ''' <summary>
        ''' Executes the query as returns the dataset
        ''' </summary>
        ''' <param name="query"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ExecuteDataSet(ByVal query As String) As DataSet
            Dim dap As SqlDataAdapter
            Dim datacmd As SqlCommand
            Dim ds As DataSet
            Try
                datacmd = New SqlCommand(query, mSqlConnection)
                dap = New SqlDataAdapter(datacmd)
                ds = New DataSet
                dap.Fill(ds)

                Return ds
            Catch ex As Exception
                Throw
            Finally
                datacmd = Nothing
                dap = Nothing
            End Try
        End Function
    End Class
End Namespace


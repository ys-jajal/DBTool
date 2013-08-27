Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class sqlClass
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim str As String
    Sub New()
        Try
            str = "data source=.\sqlexpress;integrated security=true"
            con = New SqlConnection(str)
            con.Open()
        Catch ex As Exception
            MsgBox("Connection could not be established!")
        End Try

    End Sub
    Sub New(ByVal cn As String)
        Try
            str = "data source=.\sqlexpress;initial catalog=" & cn & ";integrated security=true"
            con = New SqlConnection(str)
            con.Open()
        Catch ex As Exception
            MsgBox("Connection could not be established for sql database!")
        End Try

    End Sub

    Sub New(ByVal cn As String, ByVal un As String, ByVal pass As String)
        Try
            str = "data source=.\sqlexpress;integrated security=true;initial catalog=" & cn & ";User Id=" & un & ";Password=" & pass
            con = New SqlConnection(str)
            con.Open()
        Catch ex As Exception
            MsgBox("Connection could not be established for sql database!")
        End Try

    End Sub
    Sub executequery(ByVal sql As String)
        cmd = New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
    End Sub
    Sub executequery2(ByVal oledb As String)
        cmd = New SqlCommand(oledb, con)

        Try
            cmd.ExecuteNonQuery()
            Dim ds As DataSet
            ds = gettablevalue1(oledb)
            openform2.DataGridView1.DataSource = ds.Tables(0)
            'queryform.OutputTextBox.Text = "Query Successfully Executed......"
        Catch ex As Exception

            'queryform.OutputTextBox.Text = "Invalid Error..."
            MsgBox("Invalid Error.....")
        End Try

    End Sub
    Sub executequery1(ByVal oledb As String)
        Dim query As String
        query = oledb
        cmd = New SqlCommand(oledb, con)

        MsgBox(query)
        Try
            If InStr(query, "SELECT") Or InStr(query, "select") Then
                cmd.ExecuteNonQuery()
                queryform.OutputTextBox.Visible = False
                queryform.Label2.Visible = True
                'queryform.OutputTextBox.Text = "Query Successfully Executed......"
                queryform.QryDataGridView1.Visible = True

                Try


                    Dim ds As DataSet
                    ds = gettablevalue1(query)
                    queryform.QryDataGridView1.DataSource = ds.Tables(0)
                    'queryform.QryDataGridView1.DataSource = ds.Tables(0)
                Catch ex As Exception
                    MsgBox("binding problem")
                End Try
            End If
            If InStr(query, "INSERT") Or InStr(query, "UPDATE") Then
                queryform.Label2.Visible = True
                queryform.OutputTextBox.Visible = True
                queryform.OutputTextBox.Text = "1 Row Inserted......"

                cmd.ExecuteReader()
            Else
                cmd.ExecuteReader()
            End If
            If InStr(query, "create") Or InStr(query, "CREATE") Then
                queryform.OutputTextBox.Visible = True
                queryform.Label2.Visible = True
                queryform.QryDataGridView1.VirtualMode = False
                queryform.OutputTextBox.Text = queryform.OutputTextBox.Text + "Table Created !"
            End If
        Catch ex As Exception
            queryform.QryDataGridView1.Visible = False
            queryform.OutputTextBox.Visible = True
            queryform.Label2.Visible = True
            queryform.OutputTextBox.Text = ex.Message
            'MsgBox("Invalid Error")
        End Try

    End Sub
    Function checkuser(ByVal un As String, ByVal pass As String) As Boolean
        Dim sql As String
        sql = "select * from passtab where Uname ='" & un & "'and Pword ='" & pass & "'"
        Dim flag As Boolean = False
        Dim cmd As New SqlCommand(sql, con)
        Dim r As SqlDataReader
        r = cmd.ExecuteReader
        If r.Read Then
            flag = True
        Else
            flag = False
        End If
        Return (flag)
    End Function
    Function getdata(ByVal sql As String) As SqlDataReader
        Dim cmd As New SqlCommand(sql, con)
        Return (cmd.ExecuteReader)
    End Function
    Function gettablevalue(ByVal dt As String) As DataSet
        con = New SqlConnection(str)
        Dim da As SqlDataAdapter = New SqlDataAdapter("Select * from " & dt, con)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds)
        Return (ds)
    End Function
    Function gettablevaluequery(ByVal dt As String) As DataSet
        con = New SqlConnection(str)
        Dim da As SqlDataAdapter = New SqlDataAdapter("sp_columns @table_name=mytbl", con)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds)
        Return (ds)
    End Function
    Function gettablevalue1(ByVal dt As String) As DataSet
        con = New SqlConnection(str)
        Dim da As SqlDataAdapter = New SqlDataAdapter(dt, con)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds)
        Return (ds)
    End Function
    Public Sub disconnect()
        con.Close()
    End Sub
End Class

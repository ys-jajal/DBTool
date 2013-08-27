Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Public Class oledb120Class
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim str As String
    Sub New()
        Try
            str = "provider=microsoft.ACE.oledb.12.0"
            con = New OleDbConnection(str)
            con.Open()
        Catch ex As Exception
            MsgBox("Connection could not be established!")
        End Try

    End Sub
    Sub New(ByVal cn As String)
        Try
            str = "provider=microsoft.ACE.oledb.12.0;data source=" & cn
            con = New OleDbConnection(str)
            con.Open()
        Catch ex As Exception
            MsgBox("Connection could not be established!")
        End Try

    End Sub
    Sub New(ByVal cn As String, ByVal pass As String)
        Try
            str = "provider=microsoft.ACE.oledb.12.0;data source=" & cn & ";Persist Security Info=False;Jet OLEDB:Database Password=" & pass
            con = New OleDbConnection(str)
            con.Open()
        Catch ex As Exception
            MsgBox("Connection could not be established!")
        End Try

    End Sub
    Sub executequery(ByVal oledb As String)
        cmd = New OleDbCommand(oledb, con)
        Try
            cmd.ExecuteNonQuery()
        Catch
            MsgBox("Invalid Error")
        End Try


    End Sub
    Sub executequery2(ByVal oledb As String)
        cmd = New OleDbCommand(oledb, con)

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
        cmd = New OleDbCommand(oledb, con)

        MsgBox(query)
        Try
            If InStr(query, "SELECT") Or InStr(query, "select") Then
                cmd.ExecuteNonQuery()
                queryform.OutputTextBox.Visible = False
                'queryform.OutputTextBox.Text = "Query Successfully Executed......"
                queryform.Label2.Visible = True
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
        Dim oledb As String
        oledb = "select * from pastab where Uname ='" & un & "'and Pword ='" & pass & "'"
        Dim flag As Boolean = False
        Dim cmd As New OleDbCommand(oledb, con)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        If r.Read Then
            flag = True
        Else
            flag = False
        End If
        Return (flag)
    End Function
    Function getdata(ByVal oledb As String) As OleDbDataReader
        Dim cmd As New OleDbCommand(oledb, con)
        Return (cmd.ExecuteReader)
    End Function
    Public Sub getAllTableNames(ByVal cn As String)

        Dim com As New OleDbCommand
        Dim con As OleDbConnection

        Dim i As Integer
        'Give your database path
        Dim ConnectionString As String = "provider=microsoft.ACE.oledb.12.0;data source=" & cn
        con = New OleDb.OleDbConnection(ConnectionString)
        con.Open()
        com.Connection = con
        Dim dtable As DataTable
        Try

            dtable = con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
            'Table_Catalog,table_Schema,table_name,table_type

            For i = 0 To dtable.Rows.Count - 1

                openform2.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)

            Next

        Catch ex As Exception
            MsgBox("Tables are not present")
        End Try
    End Sub
    Public Sub getAllTableNames(ByVal cn As String, ByVal pass As String)

        Dim com As New OleDbCommand
        Dim con As OleDbConnection

        Dim i As Integer
        'Give your database path
        Dim ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cn & ";Persist Security Info=False;Jet OLEDB:Database Password=" & pass
        con = New OleDb.OleDbConnection(ConnectionString)
        con.Open()
        com.Connection = con
        Dim dtable As DataTable
        Try

            dtable = con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
            'Table_Catalog,table_Schema,table_name,table_type

            For i = 0 To dtable.Rows.Count - 1

                openform2.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)

            Next

        Catch ex As Exception
        End Try
    End Sub
    Function gettablevalue(ByVal dt As String) As DataSet
        con = New OleDbConnection(str)

        Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from " & dt, con)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds)
        Return (ds)


    End Function
    Function gettablevalue1(ByVal dt As String) As DataSet
        con = New OleDbConnection(str)

        Dim da As OleDbDataAdapter = New OleDbDataAdapter(dt, con)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds)
        Return (ds)


    End Function
    Public Sub disconnect()
        con.Close()
    End Sub
End Class

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Public Class OracleClass1
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim str As String
    Sub New()
        str = "provider=oraoledb.oracle;server name=localhost;user id=system;password=12345"
        con = New OleDbConnection(str)
        con.Open()
    End Sub
    Sub New(ByVal uid As String, ByVal pass As String)
        Try
            str = "provider=oraoledb.oracle;server name=localhost;user id=" & uid & ";password=" & pass
            con = New OleDbConnection(str)
            con.Open()
        Catch ex As Exception
            MsgBox("Connection could not be established!")
        End Try

    End Sub
    Sub executequery(ByVal oledb As String)
        cmd = New OleDbCommand(oledb, con)
        cmd.ExecuteNonQuery()
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
        Dim query As String = oledb
        cmd = New OleDbCommand(oledb, con)

        MsgBox(query)
        Try
            cmd.ExecuteNonQuery()
            If InStr(query, "SELECT") Or InStr(query, "select") Then
                cmd.ExecuteNonQuery()
                'queryform.OutputTextBox.Text = "Query Successfully Executed......"
                queryform.OutputTextBox.Visible = False
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
                queryform.OutputTextBox.Visible = True
                queryform.Label2.Visible = True
                'queryform.OutputTextBox.Visible = True
                queryform.QryDataGridView1.VirtualMode = False
                queryform.OutputTextBox.Text = "1 Row Inserted !"
                cmd.ExecuteReader()
            Else
                cmd.ExecuteReader()
            End If
            If InStr(query, "create") Or InStr(query, "CREATE") Then
                queryform.OutputTextBox.Visible = True
                queryform.QryDataGridView1.VirtualMode = False
                queryform.OutputTextBox.Text = queryform.OutputTextBox.Text + "Table Created !"
            End If


        Catch ex As Exception
            queryform.QryDataGridView1.Visible = False
            queryform.OutputTextBox.Visible = True
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
    Function gettablevalue(ByVal dt As String) As DataSet
        Try
            con = New OleDbConnection(str)
            Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from " & dt, con)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Return (ds)
        Catch ex As Exception
            MsgBox("There is no data.")
            'Form5.Close()
            'Form5.Show()

        End Try
    End Function
    Function gettablevalue1(ByVal dt As String) As DataSet
        Try
            con = New OleDbConnection(str)
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(dt, con)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            'DesingVw.DataGridView1.DataSource = ds.Tables(0)

            Return (ds)
        Catch ex As Exception
            MsgBox("There is no data.")
            'Form5.Close()
            'Form5.Show()

        End Try
    End Function
    Function gettablevaluequery(ByVal dt As String) As DataSet
        Try
            con = New OleDbConnection(str)
            Dim da As OleDbDataAdapter = New OleDbDataAdapter("desc " & dt, con)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Return (ds)
        Catch ex As Exception
            MsgBox("There is no data.")
            'Form5.Close()
            'Form5.Show()

        End Try
    End Function
    'Function gettablevaluequery(ByVal dt As String) As OleDbDataAdapter
    '    ' Try
    '    con = New OleDbConnection(str)
    '    Dim da As OleDbDataAdapter = New OleDbDataAdapter("desc " & dt, con)
    '    'Dim da As OleDbDataReader = New OleDbDataReader("desc " & dt, con)
    '    Dim d1 As OleDbDataReader '= New OleDbDataReader()
    '    ' d1.GetSchemaTable()
    '    d1 = cmd.ExecuteReader
    '    Dim ds As DataSet = New DataSet()
    '    If d1.Read Then
    '        da.Fill(d1.GetSchemaTable)
    '    End If
    '    'da.Fill(d1.GetSchemaTable)
    '    Return (da)
    '    ' Catch ex As Exception
    '    MsgBox("There is no data.")
    '    'Form5.Close()
    '    'Form5.Show()

    '    'End Try
    'End Function
    Public Sub disconnect()
        con.Close()
    End Sub
End Class

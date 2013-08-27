Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class DesingVw

    Private Sub designview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim len As Integer
        'Dim i As Integer
        'Len = openform2.ComboBox1.Items.Count
        'MsgBox(len)
        ''For i = 1 To len
        'ComboBox1.Items.Add(openform2.ComboBox1.Text)

        ' Next
        
        If openform.ListBox1.SelectedIndex = 3 Then
            If openform.RadioButton2.Checked = True Then
                Dim un As String = Trim(openform.TextBox3.Text)
                Dim pass As String = Trim(openform.TextBox4.Text)
                Dim oraobj As New OracleClass1(un, pass)
                getAllTableNamesoracle(un, pass)

            End If
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If openform.ListBox1.SelectedIndex = 0 Then
            If openform.CheckBox1.Checked = True Then
                Dim db As String = Trim(openform.TextBox1.Text)
                Dim pass As String = Trim(openform.TextBox2.Text)
                Dim o As New oledb40Class(db, pass)
                'Dim tblname As String = ComboBox1.SelectedItem.ToString
                'Dim sql As String = "DESC " & ComboBox1.SelectedItem.ToString
                Dim ds As DataSet
                'ds.GetDataSetSchema()
                getAllTableschema2003(ComboBox1.SelectedItem.ToString)
                'ds = o.gettablevalue1(ComboBox1.SelectedItem.ToString)
                'DataGridView1.DataSource = ds.Tables(0)
            Else
                Dim db As String = Trim(openform.TextBox1.Text)
                Dim o As New oledb40Class(db)
                'Dim tblname As String = ComboBox1.SelectedItem.ToString
                'Dim sql As String = "DESC " & ComboBox1.SelectedItem.ToString
                Dim ds As DataSet
                getAllTableschema2003(ComboBox1.SelectedItem.ToString)
                'ds = o.gettablevalue1(ComboBox1.SelectedItem.ToString)
                'MsgBox(ComboBox1.SelectedItem.ToString)
                'DataGridView1.DataSource = ds.Tables(0)
            End If
        End If

        If openform.ListBox1.SelectedIndex = 2 Then
            'MsgBox("2")
            If openform.RadioButton4.Checked = True Then
                Dim sqldb As String = openform.ComboBox2.SelectedItem.ToString
                Dim un As String = Trim(openform.TextBox4.Text)
                Dim pass As String = Trim(openform.TextBox5.Text)
                Dim o As New sqlClass(sqldb, un, pass)
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim ds As DataSet
                ds = o.gettablevaluequery(tblname)
                DataGridView1.DataSource = ds.Tables(0)
                'MsgBox("sql1")
            Else
                Dim db As String = openform.ComboBox2.SelectedItem.ToString
                Dim o As New sqlClass(db)
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim ds As DataSet
                ds = o.gettablevalue(tblname)
                DataGridView1.DataSource = ds.Tables(0)
                'MsgBox("sql")
            End If
        End If
        If openform.ListBox1.SelectedIndex = 3 Then
            If openform.RadioButton2.Checked = True Then
                Dim un As String = Trim(openform.TextBox3.Text)
                Dim pass As String = Trim(openform.TextBox4.Text)
                Dim o As New OracleClass1(un, pass)
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim ds As New DataSet
                o.gettablevaluequery(tblname)

                DataGridView1.Visible = True
                'DataGridView1.DataSource = ds.Tables(0)


            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'openform.getAllTableschema2003(ComboBox1.SelectedItem.ToString)
    End Sub
    Public Sub getAllTableNamesoracle(ByVal uid As String, ByVal pass As String)

        Dim com As New OleDbCommand
        Dim con As OleDbConnection

        Dim i As Integer
        'Give your database path
        Dim ConnectionString As String = "provider=oraoledb.oracle;server name=localhost;user id=" & uid & ";password=" & pass
        con = New OleDb.OleDbConnection(ConnectionString)
        con.Open()
        com.Connection = con
        'Dim dtable As DataTable
        Try
            Dim s As String = "select * from user_objects where object_type = 'TABLE'"
            Dim r As OleDbDataReader
            Dim cmd As New OleDbCommand(s, con)
            r = cmd.ExecuteReader
            While r.Read
                ComboBox1.Items.Add(r("object_name"))
            End While
            'dtable = con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
            ''Table_Catalog,table_Schema,table_name,table_type

            'For i = 0 To dtable.Rows.Count - 1

            '    ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)

            'Next

        Catch ex As Exception
        End Try
    End Sub
    Public Sub getAllTableschema2003(ByVal cn As String)

        'Dim com As New OleDbCommand
        'Dim con As OleDbConnection

        'Dim i As Integer
        ''Give your database path
        Dim ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & openform.TextBox1.Text
        'con = New OleDb.OleDbConnection(ConnectionString)
        'con.Open()
        'com.Connection = con
        ''con.GetSchema(cn)

        'Dim dtable As DataTable
        'Try
        '    Dim dtable1 As Char = con.GetSchema.TableName(cn)
        '    'MsgBox(dtable1)
        '    dtable = con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
        'Table_Catalog,table_Schema,table_name,table_type
        'dtable = con.GetSchema(cn)
        'For i = 0 To dtable.Rows.Count - 1
        ' DataGridView1.DataSource = dtable.Rows(i).Item(1).ToString
        'openform2.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
        'openform2.ComboBox1.Items.Add(dtable.Rows(i).Item(1).ToString)
        'Next
        'Dim myConn As New OleDbConnection(ConnectionString)
        Dim myconn As New OleDbConnection(ConnectionString)
        'Dim myConn As New oledb40Class(ConnectionString)
        Dim sql As String = "Select * from " & cn

        Dim myCommand As New OleDbCommand(sql, myConn)

        myConn.Open()

        Dim da As New OleDbDataAdapter(myCommand)

        'objDR = myCommand.ExecuteReader(CommandBehavior.CloseConnection)

        'Dim schemaTable As DataTable
        'schemaTable = objDR.GetSchemaTable()
        Dim i As Integer
        'Try
        ' For each field in the table...
        'For Each myField As DataRow In schemaTable.Rows

        ' For each property of the field...
        'For Each myProperty As DataColumn In schemaTable.Columns

        'Display the field name and value.
        ' MsgBox(myProperty.ColumnName)
        Dim lb1, lb2, lb3, lb4, lb5, lb6, lb7 As New Label
        ' lb1.Text = (myProperty.ColumnName + " = " + myField(myProperty).ToString())

        'lb2.Text = (myField(0).ToString)
        'lb3.Text = (myField(1).ToString)
        'lb4.Text = (myField(2).ToString)
        'lb5.Text = (myField(3).ToString)
        'lb6.Text = (myField(4).ToString)
        'lb7.Text = (myField(5).ToString)
        ''lb2.te()
        'lb1.Location = New Point(100, 100)
        'lb2.Location = New Point(100, 120)
        'lb3.Location = New Point(100, 140)
        'lb4.Location = New Point(100, 160)
        'lb5.Location = New Point(100, 180)
        'lb6.Location = New Point(100, 200)
        Dim ds As New DataSet()

        da.Fill(ds, cn)
        For Each dc In ds.Tables(cn).Columns
            MsgBox(dc.ColumnName.ToString)
        Next
        ''DataGridView1.DataBindings()
        'Dim lbl1, lbl2, lbl3, lbl4 As New Label
        'lbl1.Text = (myField(10).ToString)

        'lbl1.Location = New Point(180, 100)
        'Me.Controls.Add(lbl1)
        'Me.Controls.Add(lb1)
        'Me.Controls.Add(lb2)
        'Me.Controls.Add(lb3)
        'Me.Controls.Add(lb4)
        'Me.Controls.Add(lb5)
        'Me.Controls.Add(lb6)
        '  Next
        'Dim lbl1, lbl2, lbl3, lbl4 As New Label
        'lbl1.Text = (myField(1).ToString)

        'lbl1.Location = New Point(180, 100)
        'Me.Controls.Add(lbl1)
        MsgBox("")

        ' Next
        'Catch ex As Exception
        '   MsgBox("Error....")
        'End Try
    End Sub
End Class
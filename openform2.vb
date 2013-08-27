Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.VisualBasic

Public Class openform2
    Public flag = 0
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        flag = 1
        If openform.ListBox1.SelectedIndex = 0 Then
            If openform.CheckBox1.Checked = True Then
                Dim db As String = Trim(openform.TextBox1.Text)
                Dim pass As String = Trim(openform.TextBox2.Text)
                Dim o As New oledb40Class(db, pass)
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                ' Dim sql As String = "select * from " & ComboBox1.SelectedItem.ToString
                Dim ds As DataSet
                ds = o.gettablevalue(tblname)
                DataGridView1.DataSource = ds.Tables(0)
            Else
                Dim db As String = Trim(openform.TextBox1.Text)
                Dim o As New oledb40Class(db)
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                ' Dim sql As String = "select * from " & ComboBox1.SelectedItem.ToString
                Dim ds As DataSet
                ds = o.gettablevalue(tblname)
                DataGridView1.DataSource = ds.Tables(0)
            End If
        End If
        If openform.ListBox1.SelectedIndex = 1 Then
            If openform.CheckBox1.Checked = True Then
                Dim db As String = Trim(openform.TextBox1.Text)
                Dim pass As String = Trim(openform.TextBox2.Text)
                Dim o As New oledb120Class(db, pass)
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim ds As DataSet
                ds = o.gettablevalue(tblname)
                DataGridView1.DataSource = ds.Tables(0)
            Else
                Dim db As String = Trim(openform.TextBox1.Text)
                Dim o As New oledb120Class(db)
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim ds As DataSet
                ds = o.gettablevalue(tblname)
                DataGridView1.DataSource = ds.Tables(0)
                'MsgBox("access2007")
            End If
        End If
        'If openform.ListBox1.SelectedIndex = 2 Then
        'MsgBox("SQl")
        'End If
        If openform.ListBox1.SelectedIndex = 2 Then
            'MsgBox("2")
            If openform.RadioButton4.Checked = True Then
                Dim sqldb As String = openform.ComboBox2.SelectedItem.ToString
                Dim un As String = Trim(openform.TextBox4.Text)
                Dim pass As String = Trim(openform.TextBox5.Text)
                Dim o As New sqlClass(sqldb, un, pass)
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim ds As DataSet
                ds = o.gettablevalue(tblname)
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
                Dim ds As DataSet
                ds = o.gettablevalue(tblname)
                DataGridView1.Visible = True
                DataGridView1.DataSource = ds.Tables(0)


            End If
        End If
        'ElseIf openform.ListBox1.SelectedIndex = 2 Then
        '    If openform.RadioButton1.Checked = True Then
        '        Dim sqldb As String = openform.ComboBox2.SelectedItem.ToString
        '        Dim un As String = Trim(openform.TextBox4.Text)
        '        Dim pass As String = Trim(openform.TextBox5.Text)
        '        Dim o As New sqlClass(sqldb, un, pass)
        '        Dim tblname As String = ComboBox1.SelectedItem.ToString
        '        Dim ds As DataSet
        '        ds = o.gettablevalue(tblname)
        '        DataGridView1.DataSource = ds.Tables(0)
        '    Else
        '        Dim db As String = Form4.ComboBox2.SelectedItem.ToString
        '        Dim o As New sqlClass(db)
        '        Dim tblname As String = ComboBox1.SelectedItem.ToString
        '        Dim ds As DataSet
        '        ds = o.gettablevalue(tblname)
        '        DataGridView1.DataSource = ds.Tables(0)
        '    End If
        'ElseIf Form4.ListBox1.SelectedIndex = 3 Then
        '    Dim db As String = Trim(Form4.TextBox1.Text)
        '    Dim o As New FoxproClass(db)
        '    Dim tblname As String = ComboBox1.SelectedItem.ToString
        '    Dim ds As DataSet
        '    ds = o.gettablevalue(tblname)
        '    DataGridView1.DataSource = ds.Tables(0)

        'ElseIf Form4.ListBox1.SelectedIndex = 4 Then
        '    If Form4.RadioButton4.Checked = True Then
        '        Dim un As String = Trim(Form4.TextBox6.Text)
        '        Dim pass As String = Trim(Form4.TextBox7.Text)
        '        Dim o As New OracleClass1(un, pass)
        '        Dim tblname As String = ComboBox1.SelectedItem.ToString
        '        Dim ds As DataSet
        '        ds = o.gettablevalue(tblname)
        '        DataGridView1.DataSource = ds.Tables(0)
        '    Else

        '    End If
    End Sub

    Private Sub openform2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If openform.ListBox1.SelectedIndex = 2 Then
            If openform.RadioButton1.Checked = True Then
                Dim un As String = Trim(openform.TextBox4.Text)
                Dim pass As String = Trim(openform.TextBox5.Text)
                Dim sqldb As String = openform.ComboBox2.SelectedItem.ToString
                Dim sqlobj As New sqlClass(sqldb, un, pass)
                getAllTableNamessql(sqldb, un, pass)
            Else
                Dim sqldb As String = openform.ComboBox2.SelectedItem.ToString
                Dim sqlobj As New sqlClass(sqldb)
                getAllTableNamessql(sqldb)
            End If
        End If

        If openform.ListBox1.SelectedIndex = 4 Then
            If openform.RadioButton4.Checked = True Then
                Dim un As String = Trim(openform.TextBox6.Text)
                Dim pass As String = Trim(openform.TextBox7.Text)
                Dim oraobj As New OracleClass1(un, pass)
                getAllTableNamesoracle(un, pass)
            Else
                Dim sqldb As String = openform.ComboBox2.SelectedItem.ToString
                Dim sqlobj As New sqlClass(sqldb)
                getAllTableNamessql(sqldb)
            End If
        End If

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
    Public Sub getAllTableNamessql(ByVal cn As String)

        Dim com As New SqlCommand
        Dim con As SqlConnection

        Dim i As Integer
        'Give your database path
        Dim ConnectionString As String = "data source=.\sqlexpress;initial catalog=" & cn & ";integrated security=true"
        con = New SqlClient.SqlConnection(ConnectionString)
        con.Open()
        com.Connection = con

        Try

            'dtable = con.GetsqlSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
            'dtable = con.GetSchema.TableName.ToString
            'dtable =con .GetSchema .TableName .
            'Table_Catalog,table_Schema,table_name,table_type
            Dim s As String = "select * from Information_schema.tables"
            Dim r As SqlDataReader
            Dim cmd As New SqlCommand(s, con)
            r = cmd.ExecuteReader
            While r.Read
                ComboBox1.Items.Add(r("Table_name"))
            End While
        Catch ex As Exception
            MsgBox("Tables are not present.")
        End Try
    End Sub
    Public Sub getAllTableNamessql(ByVal cn As String, ByVal un As String, ByVal pass As String)

        Dim com As New SqlCommand
        Dim con As SqlConnection

        Dim i As Integer
        'Give your database path
        Dim ConnectionString As String = "data source=.\sqlexpress;integrated security=true;initial catalog=" & cn & ";User Id=" & un & ";Password=" & pass
        con = New SqlClient.SqlConnection(ConnectionString)
        con.Open()
        com.Connection = con

        Try
            Dim s As String = "select * from Information_schema.tables"
            Dim r As SqlDataReader
            Dim cmd As New SqlCommand(s, con)
            r = cmd.ExecuteReader
            While r.Read
                ComboBox1.Items.Add(r("Table_name"))
            End While
        Catch ex As Exception
            MsgBox("There is no data.")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'DataGridView1.CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange)
        DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("TOTAL RECORDS IN TABLE ARE :" & DataGridView1.RowCount)
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintDocument1.Print()


        'PrintPreviewDialog1.ShowDialog()
        'PrintPreviewDialog1.Region = DataGridView1
        'PrintDialog1.AllowSelection()
        'PrintDialog1.
        'PrintDialog1.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataGridView1.Refresh()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView1.KeyPress

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        form1.Show()

    End Sub
End Class

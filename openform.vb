Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.VisualBasic
Public Class openform
    Dim flag = 0

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        'MsgBox(ListBox1.SelectedIndex.ToString)
        If ListBox1.SelectedIndex = 0 Then
            AccessPanel.Visible = True
            sqlpanel.Visible = False
            oraclepanel.Visible = False
            Label3.Enabled = True
            TextBox1.Enabled = True
            Btnfilediag.Enabled = True
        End If
        If ListBox1.SelectedIndex = 1 Then
            AccessPanel.Visible = True
            sqlpanel.Visible = False
            oraclepanel.Visible = False
            Label3.Enabled = True
            TextBox1.Enabled = True
            Btnfilediag.Enabled = True
        End If
        If ListBox1.SelectedIndex = 2 Then
            AccessPanel.Visible = False
            sqlpanel.Visible = True
            sqlpanel.Location = New Point(265, 31)
            oraclepanel.Visible = False
            ' SQLPanel.Location.X = 144
            'SQLPanel.Location.Y = 44
        End If

        If ListBox1.SelectedIndex = 3 Then
            oraclepanel.Visible = True
            oraclepanel.Location = New Point(265, 31)
            sqlpanel.Visible = False
            AccessPanel.Visible = False
            Dim s As String = "select name from dbo.sysDatabases"
            Dim o As New sqlClass
            Dim r As SqlDataReader = o.getdata(s)
            While r.Read
                ComboBox2.Items.Add((r("name")))
            End While
            Dim d As String = "data source=.\sqlexpress;integrated security=true"
            Dim con As New SqlConnection(d)

            con.Open()
            'TextBox3.Text = con.DataSource

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub





    
    Private Sub pnlopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlopen.Click
        DBTool.Query.Enabled = True
        DBTool.Query.FlatStyle = FlatStyle.Flat
        DBTool.Tool.Enabled = True
        DBTool.Tool.FlatStyle = FlatStyle.Flat
        'DBTool.DesignView.Enabled = True
        'DBTool.DesignView.FlatStyle = FlatStyle.Flat
        DBTool.conclose.Enabled = True
        DBTool.conclose.FlatStyle = FlatStyle.Flat


        If ListBox1.SelectedIndex = 0 Then
            If TextBox1.Text = "" Then
                MsgBox("Please enter the Access database path.")
                If CheckBox1.Checked = True Then
                    If TextBox2.Text = "" Then
                        MsgBox("Please enter the password.")
                    End If
                End If
            Else
                Me.Hide()
                'Dim child3 As New Form5
                ' child3.MdiParent = Form1
                'DBTool.Show()
                openform2.MdiParent = DBTool
                openform2.Show()
                openform2.Dock = DockStyle.Fill
                DBTool.Open.Enabled = False
                openform2.ComboBox1.Visible = True
                openform2.DataGridView1.Visible = True
                'openform2.tablepanel.Visible = True
                Try
                    If ListBox1.SelectedIndex = 0 Then
                        If CheckBox1.Checked = True Then
                            Dim db As String = Trim(TextBox1.Text)
                            Dim pass As String = Trim(TextBox2.Text)
                            Dim o As New oledb40Class(db, pass)
                            getAllTableNames2003(db, pass)
                        Else
                            Dim db As String = Trim(TextBox1.Text)
                            Dim o As New oledb40Class(db)
                            getAllTableNames2003(db)
                        End If
                        'ElseIf ListBox1.SelectedIndex = 1 Then
                        '    If CheckBox1.Checked = True Then
                        '        Dim db As String = Trim(TextBox1.Text)
                        '        Dim pass As String = Trim(TextBox2.Text)
                        '        Dim o As New oledb120Class(db, pass)
                        '        getAllTableNames2007(db, pass)
                        '    Else
                        '        Dim db As String = Trim(TextBox1.Text)
                        '        Dim o As New oledb120Class(db)
                        '        getAllTableNames2007(db)
                        '    End If
                        'ElseIf Form4.ListBox1.SelectedIndex = 2 Then

                        '    If Form4.RadioButton1.Checked = True Then
                        '        Dim un As String = Trim(Form4.TextBox4.Text)
                        '        Dim pass As String = Trim(Form4.TextBox5.Text)
                        '        Dim sqldb As String = Form4.ComboBox2.SelectedItem.ToString
                        '        Dim sqlobj As New sqlClass(sqldb, un, pass)
                        '        getAllTableNamessql(sqldb, un, pass)
                        '    Else
                        '        Dim sqldb As String = Form4.ComboBox2.SelectedItem.ToString
                        '        Dim sqlobj As New sqlClass(sqldb)
                        '        getAllTableNamessql(sqldb)
                        '    End If
                        'ElseIf Form4.ListBox1.SelectedIndex = 3 Then
                        '    Dim db As String = Trim(Form4.TextBox1.Text)
                        '    Dim o As New FoxproClass(db)
                        '    getAllTableNamesfoxpro(db)
                        'ElseIf Form4.ListBox1.SelectedIndex = 4 Then
                        '    If Form4.RadioButton4.Checked = True Then
                        '        Dim un As String = Trim(Form4.TextBox6.Text)
                        '        Dim pass As String = Trim(Form4.TextBox7.Text)
                        '        Dim oraobj As New OracleClass1(un, pass)
                        '        getAllTableNamesoracle(un, pass)
                        '    Else
                        '        Dim sqldb As String = Form4.ComboBox2.SelectedItem.ToString
                        '        Dim sqlobj As New sqlClass(sqldb)
                        '        getAllTableNamessql(sqldb)
                        '    End If
                        

                    End If
                Catch ex As Exception
                    MsgBox("Invalid Error")
                    Me.Close()
                End Try

            End If
        ElseIf ListBox1.SelectedIndex = 1 Then
            If TextBox1.Text = "" Then
                MsgBox("Please enter the Access database path.")
                If CheckBox1.Checked = True Then
                    If TextBox2.Text = "" Then
                        MsgBox("Please enter the password.")
                    End If
                End If
            Else
                Me.Hide()
                openform2.MdiParent = DBTool
                openform2.Show()
                openform2.Dock = DockStyle.Fill
                DBTool.Open.Enabled = False
                openform2.ComboBox1.Visible = True
                openform2.DataGridView1.Visible = True
                Try
                    If ListBox1.SelectedIndex = 1 Then
                        If CheckBox1.Checked = True Then
                            Dim db As String = Trim(TextBox1.Text)
                            Dim pass As String = Trim(TextBox2.Text)
                            Dim o As New oledb120Class(db, pass)
                            getAllTableNames2007(db, pass)
                        Else
                            Dim db As String = Trim(TextBox1.Text)
                            Dim o As New oledb120Class(db)
                            getAllTableNames2007(db)
                        End If
                    End If
                Catch
                    MsgBox("Invalid Error... ")

                End Try
            End If
        End If
        'ElseIf ListBox1.SelectedIndex = 2 Then
        '    If ComboBox2.Text = "" Then
        '        MsgBox("Please select the SQL server database.")
        '    Else
        '        Me.Hide()
        '        Dim child3 As New Form5
        '        child3.MdiParent = Form1
        '        child3.Show()
        '    End If
        'ElseIf ListBox1.SelectedIndex = 3 Then
        '    If TextBox1.Text = "" Then
        '        MsgBox("Please enter the Foxpro database path.")
        '        If CheckBox1.Checked = True Then
        '            If TextBox2.Text = "" Then
        '                MsgBox("Please enter the password.")
        '            End If
        '        End If
        '    Else
        '        Me.Hide()
        '        Dim child3 As New Form5
        '        child3.MdiParent = Form1
        '        child3.Show()
        '    End If
        'ElseIf ListBox1.SelectedIndex = 4 Then
        '    If TextBox7.Text = "" And TextBox6.Text = "" Then
        '        MsgBox("Please enter the User Name and password.")
        '    Else
        '        Me.Hide()
        '        Dim child3 As New Form5
        '        child3.MdiParent = Form1
        '        child3.Show()
        '    End If
        'End If
        'End If
    End Sub


    Private Sub Btnfilediag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnfilediag.Click
        If ListBox1.SelectedIndex = 0 Then
            OpenFileDialog1.DefaultExt = ".mdb"
            OpenFileDialog1.AddExtension = True
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "Access Databases(.mdb)|*.mdb"
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                TextBox1.Text = OpenFileDialog1.FileName
                pnlopen.Enabled = True
            End If
        ElseIf ListBox1.SelectedIndex = 1 Then
            OpenFileDialog1.DefaultExt = ".accdb"
            OpenFileDialog1.AddExtension = True
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "Access Databases(.accdb)|*.accdb"
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                TextBox1.Text = OpenFileDialog1.FileName
                pnlopen.Enabled = True
            End If
        End If

    End Sub

    Private Sub pnlcancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlcancle.Click
        Me.Close()
    End Sub

    Private Sub sqlpnlcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub SQLPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        
    End Sub

    Private Sub openform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox2.Items.Clear()
        Dim s As String = "select name from dbo.sysDatabases"
        Dim o As New sqlClass
        Dim r As SqlDataReader = o.getdata(s)
        While r.Read
            ComboBox2.Items.Add((r("name")))
        End While
        Dim d As String = "data source=.\sqlexpress;integrated security=true"
        Dim con As New SqlConnection(d)
        con.Open()
        'TextBox3.Text = con.DataSource
    End Sub
    Public Sub getAllTableNames2003(ByVal cn As String, ByVal pass As String)

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
                DesingVw.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
                form1.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
                form1.ComboBox2.Items.Add(dtable.Rows(i).Item(2).ToString)

            Next

        Catch ex As Exception
        End Try
    End Sub

    Public Sub getAllTableNames2003(ByVal cn As String)

        Dim com As New OleDbCommand
        Dim con As OleDbConnection

        Dim i As Integer
        'Give your database path
        Dim ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cn
        con = New OleDb.OleDbConnection(ConnectionString)
        con.Open()
        com.Connection = con
        Dim dtable As DataTable
        Try
            dtable = con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
            'Table_Catalog,table_Schema,table_name,table_type

            For i = 0 To dtable.Rows.Count - 1

                openform2.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
                DesingVw.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
                form1.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
                form1.ComboBox2.Items.Add(dtable.Rows(i).Item(2).ToString)

            Next

        Catch ex As Exception
            MsgBox("Error....")
        End Try
    End Sub
    Public Sub getAllTableschema2003(ByVal cn As String)

        Dim com As New OleDbCommand
        Dim con As OleDbConnection

        Dim i As Integer
        'Give your database path
        Dim ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & cn
        con = New OleDb.OleDbConnection(ConnectionString)
        con.Open()
        com.Connection = con
        con.GetSchema(cn)

        Dim dtable As DataTable
        Try
            Dim dtable1 As Char = con.GetSchema.TableName(cn)
            MsgBox(dtable1)
            dtable = con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
            'Table_Catalog,table_Schema,table_name,table_type
            dtable = con.GetSchema(cn)
            For i = 0 To dtable.Rows.Count - 1

                openform2.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
                DesingVw.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
                form1.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
                form1.ComboBox2.Items.Add(dtable.Rows(i).Item(2).ToString)

            Next

        Catch ex As Exception
            MsgBox("Error....")
        End Try
    End Sub
    Public Sub getAllTableNames2007(ByVal cn As String)

        Dim com As New OleDbCommand
        Dim con As OleDbConnection

        Dim i As Integer
        'Give your database path
        Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & cn
        con = New OleDb.OleDbConnection(ConnectionString)
        con.Open()
        com.Connection = con
        Dim dtable As DataTable
        Try

            dtable = con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
            'Table_Catalog,table_Schema,table_name,table_type

            For i = 0 To dtable.Rows.Count - 1

                openform2.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
                DesingVw.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
                form1.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
                form1.ComboBox2.Items.Add(dtable.Rows(i).Item(2).ToString)

            Next

        Catch ex As Exception
            MsgBox("Error...")
        End Try
    End Sub
    Public Sub getAllTableNames2007(ByVal cn As String, ByVal pass As String)

        Dim com As New OleDbCommand
        Dim con As OleDbConnection

        Dim i As Integer
        'Give your database path
        Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & cn & ";Persist Security Info=False;Jet OLEDB:Database Password=" & pass
        con = New OleDb.OleDbConnection(ConnectionString)
        con.Open()
        com.Connection = con
        Dim dtable As DataTable
        Try

            dtable = con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
            'Table_Catalog,table_Schema,table_name,table_type

            For i = 0 To dtable.Rows.Count - 1

                openform2.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
                DesingVw.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
                form1.ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)
                form1.ComboBox2.Items.Add(dtable.Rows(i).Item(2).ToString)

            Next

        Catch ex As Exception
        End Try
    End Sub

    Private Sub sqlopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sqlopen.Click
        DBTool.Query.Enabled = True
        DBTool.Query.FlatStyle = FlatStyle.Flat
        DBTool.Tool.Enabled = True
        DBTool.Tool.FlatStyle = FlatStyle.Flat
        'DBTool.DesignView.Enabled = True
        'DBTool.DesignView.FlatStyle = FlatStyle.Flat
        DBTool.conclose.Enabled = True
        DBTool.conclose.FlatStyle = FlatStyle.Flat
        If ListBox1.SelectedIndex = 2 Then
            'If TextBox1.Text = "" Then
            '    MsgBox("Please enter the Access database path.")
            '    If CheckBox1.Checked = True Then
            '        If TextBox2.Text = "" Then
            '            MsgBox("Please enter the password.")
            '        End If
            '    End If
            'Else
            Me.Hide()
            'Me.Close()

            'Dim child3 As New Form5
            ' child3.MdiParent = Form1
            'DBTool.Show()
            openform2.MdiParent = DBTool
            openform2.Show()
            openform2.Dock = DockStyle.Fill
            DBTool.Open.Enabled = False
            openform2.ComboBox1.Visible = True
            openform2.DataGridView1.Visible = True
            'openform2.tablepanel.Visible = True
            Try

                Dim db As String = Trim(ComboBox2.SelectedItem.ToString)
                Dim o As New sqlClass(db)
                getAllTableNamessql(db)
            Catch ex As Exception
                MsgBox("Error...")
            End Try



        End If
        'End If

    End Sub

    Public Sub getAllTableNamessql(ByVal cn As String)

        Dim com As New SqlCommand
        Dim con As SqlConnection

        Dim i As Integer
        'Give your database path
        Dim ConnectionString As String = "data source=.\sqlexpress;initial catalog=" & cn & ";integrated security=true"
        'ConnectionString = "Provider=SQLNCLI10;Server=.\SQLExpress;AttachDbFilename=" & cn & "Database=dbname; Trusted_Connection=Yes"
        'ConnectionString = "Server=.\SQLExpress;AttachDbFilename=" & cn & "; Trusted_Connection=Yes"
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
                openform2.ComboBox1.Items.Add(r("Table_name"))
                DesingVw.ComboBox1.Items.Add(r("Table_name"))
                form1.ComboBox1.Items.Add(r("Table_name"))
                form1.ComboBox2.Items.Add(r("Table_name"))
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
                openform2.ComboBox1.Items.Add(r("Table_name"))
                DesingVw.ComboBox1.Items.Add(r("Table_name"))
                form1.ComboBox1.Items.Add(r("Table_name"))
                form1.ComboBox2.Items.Add(r("Table_name"))
            End While
        Catch ex As Exception
            MsgBox("There is no data.")
        End Try
    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DBTool.Query.Enabled = True
        DBTool.Query.FlatStyle = FlatStyle.Flat
        DBTool.Tool.Enabled = True
        DBTool.Tool.FlatStyle = FlatStyle.Flat
        'DBTool.DesignView.Enabled = True
        'DBTool.DesignView.FlatStyle = FlatStyle.Flat
        DBTool.conclose.Enabled = True
        DBTool.conclose.FlatStyle = FlatStyle.Flat
        If ListBox1.SelectedIndex = 3 Then
            ' MsgBox("ora")
            If RadioButton2.Checked = True Then
                Dim un As String = Trim(TextBox3.Text)
                Dim pass As String = Trim(TextBox4.Text)
                Dim oraobj As New OracleClass1(un, pass)
                getAllTableNamesoracle(un, pass)
                Me.Hide()
                openform2.MdiParent = DBTool
                openform2.Show()
                openform2.Dock = DockStyle.Fill
                'Else
                '   Dim oraobj As New OracleClass1()
                '  getAllTableNamesoracle()

                'Dim sqldb As String = ComboBox2.SelectedItem.ToString
                'Dim sqlobj As New sqlClass(sqldb)
                'getAllTableNamessql(sqldb)
                'openform2.Show()
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
                openform2.ComboBox1.Items.Add(r("object_name"))
                DesingVw.ComboBox1.Items.Add(r("object_name"))
                form1.ComboBox1.Items.Add(r("object_name"))
                form1.ComboBox2.Items.Add(r("object_name"))
            End While
            'dtable = con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
            ''Table_Catalog,table_Schema,table_name,table_type

            'For i = 0 To dtable.Rows.Count - 1

            '    ComboBox1.Items.Add(dtable.Rows(i).Item(2).ToString)

            'Next

        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub sqlpanel_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles sqlpanel.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label2.Enabled = True
            TextBox2.Enabled = True
        Else
            CheckBox1.Checked = False
            Label2.Enabled = False
            TextBox2.Enabled = False

        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If Len(TextBox4.Text) > 0 Then
            Button4.Enabled = True
        Else
            Button4.Enabled = False

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        sqlopen.Enabled = True
    End Sub

    Private Sub oraclepanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles oraclepanel.Paint

    End Sub
End Class
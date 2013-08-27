Imports System
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class form1

    Private Sub form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Location = New Point(155, 70)

    End Sub

    Private Sub QueryCombobox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryCombobox.SelectedIndexChanged
        Button1.Enabled = True
        If QueryCombobox.SelectedIndex = 0 Then
            Label1.Enabled = True
            ComboBox1.Enabled = True
            Label2.Enabled = False
            ComboBox2.Enabled = False
            TextBox2.Enabled = True
            Label10.Enabled = True
        End If
        If QueryCombobox.SelectedIndex = 1 Then
            Label1.Enabled = True
            ComboBox1.Enabled = True
            Label2.Enabled = False
            ComboBox2.Enabled = False
            TextBox2.Enabled = False
            Label10.Enabled = False
        End If
        If QueryCombobox.SelectedIndex = 2 Then
            Label1.Enabled = True
            ComboBox1.Enabled = True
            Label2.Enabled = True
            ComboBox2.Enabled = True
            TextBox2.Enabled = False
            Label10.Enabled = False
        End If
        If QueryCombobox.SelectedIndex = 3 Then
            Label1.Enabled = True
            ComboBox1.Enabled = True
            Label2.Enabled = False
            ComboBox2.Enabled = False
            TextBox2.Enabled = False
            Label10.Enabled = False
        End If
        If QueryCombobox.SelectedIndex = 4 Or QueryCombobox.SelectedIndex = 5 Or QueryCombobox.SelectedIndex = 6 Or QueryCombobox.SelectedIndex = 7 Then
            Label1.Enabled = True
            ComboBox1.Enabled = True
            Label2.Enabled = True
            ComboBox2.Enabled = True
            TextBox2.Enabled = False
            Label10.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel2.Visible = True
        Panel2.Location = New Point(155, 70)
        Panel1.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel1.Visible = True

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Panel2.Visible = False

        Panel1.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel2.Visible = False
        Panel3.Visible = True
        Panel3.Location = New Point(155, 70)

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Panel4.Visible = False
        Panel3.Visible = True

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Panel3.Visible = False
        Panel4.Visible = True
        Panel4.Location = New Point(155, 70)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Panel3.Visible = False
        Panel2.Visible = True

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Hide()
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If openform.ListBox1.SelectedIndex = 0 Then
            If QueryCombobox.SelectedIndex = 0 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " Between " & value1 & " And " & value2 & ""
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb40Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                'Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 1 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim condexpr As String = TextBox3.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " like '" & condexpr & "'"
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb40Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 2 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim condexpr As String = TextBox3.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " Not like '" & condexpr & "'"
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb40Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                ' Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 3 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " In ('" & value1 & "')"
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb40Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 4 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & "," & tblname2 & " where " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb40Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 5 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & " Left Join " & tblname2 & " On " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb40Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 6 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & " Right Join " & tblname2 & " on " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb40Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 7 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & " Full Join " & tblname2 & " On " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb40Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
        End If
        If openform.ListBox1.SelectedIndex = 1 Then
            If QueryCombobox.SelectedIndex = 0 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " Between " & value1 & " And " & value2 & ""
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb120Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 1 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim condexpr As String = TextBox3.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " like '" & condexpr & "'"
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb120Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                DBTool.Show()
                ' Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 2 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim condexpr As String = TextBox3.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " Not like '" & condexpr & "'"
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb120Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 3 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " In ('" & value1 & "')"
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb120Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 4 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & "," & tblname2 & " where " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb120Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 5 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & " Left Join " & tblname2 & " On " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb120Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                ' Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 6 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & " Right Join " & tblname2 & " on " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb120Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 7 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & " Full Join " & tblname2 & " On " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New oledb120Class(cn)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
        End If
        If openform.ListBox1.SelectedIndex = 2 Then
            Dim cn1 As String = openform.ComboBox2.SelectedItem.ToString
            If QueryCombobox.SelectedIndex = 0 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " Between " & value1 & " And " & value2 & ""
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New sqlClass(cn1)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                ' Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 1 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim condexpr As String = TextBox3.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " like '" & condexpr & "'"
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New sqlClass(cn1)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 2 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim condexpr As String = TextBox3.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " Not like '" & condexpr & "'"
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New sqlClass(cn1)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                ' Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 3 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " In ('" & value1 & "')"
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New sqlClass(cn1)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                ' Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 4 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & "," & tblname2 & " where " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New sqlClass(cn1)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                '  Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 5 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & " Left Join " & tblname2 & " On " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New sqlClass(cn1)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 6 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & " Right Join " & tblname2 & " on " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New sqlClass(cn1)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                ' Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 7 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & " Full Join " & tblname2 & " On " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New sqlClass(cn1)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                ' Me.Controls.Clear()
            End If
        End If
        If openform.ListBox1.SelectedIndex = 3 Then
            Dim un As String = openform.TextBox3.Text
            Dim pass As String = openform.TextBox4.Text
            If QueryCombobox.SelectedIndex = 0 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " Between " & value1 & " And " & value2 & ""
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New OracleClass1(un, pass)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                ' Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 1 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim condexpr As String = TextBox3.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " like '" & condexpr & "'"
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New OracleClass1(un, pass)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                '  Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 2 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim condexpr As String = TextBox3.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " Not like '" & condexpr & "'"
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New OracleClass1(un, pass)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                ' Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 3 Then
                Dim tblname As String = ComboBox1.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname & " where " & condfield & " In ('" & value1 & "')"
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New OracleClass1(un, pass)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                ' Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 4 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & "," & tblname2 & " where " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New OracleClass1(un, pass)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 5 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & " Left Join " & tblname2 & " On " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New OracleClass1(un, pass)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                ' Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 6 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & " Right Join " & tblname2 & " on " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New OracleClass1(un, pass)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
            If QueryCombobox.SelectedIndex = 7 Then
                Dim tblname1 As String = ComboBox1.SelectedItem.ToString
                Dim tblname2 As String = ComboBox2.SelectedItem.ToString
                Dim fieldname As String '= TextBox1.Text
                If Len(TextBox1.Text) > 0 Then
                    fieldname = TextBox1.Text
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                ' If ComboBox3.  = True Then
                'fieldname = ComboBox3.SelectedItem.ToString
                'End If
                If CheckBox1.Checked = True Then
                    fieldname = "*"
                Else
                    fieldname = ComboBox3.SelectedItem.ToString
                End If

                Dim condfield As String = ComboBox3.SelectedItem.ToString
                Dim value1 As String = TextBox3.Text
                'Dim value2 As String = TextBox2.Text
                Dim qry As String
                qry = "select " & fieldname & " from " & tblname1 & " Full Join " & tblname2 & " On " & tblname1 & "." & condfield & "=" & tblname2 & "." & condfield & " "
                MsgBox(qry)
                Dim cn As String = openform.TextBox1.Text
                Dim obj As New OracleClass1(un, pass)
                MsgBox(cn)
                obj.executequery2(qry)
                'Dim ds As DataSet
                'ds = obj.gettablevalue1(qry)
                'openform2.DataGridView1.DataSource(ds)
                Me.Hide()
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = False
                Panel1.Visible = True
                DBTool.Show()
                'Me.Controls.Clear()
            End If
        End If
    End Sub
    Public Sub getfieldName2003(ByVal cn As String)

        Dim ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & openform.TextBox1.Text

        Dim myconn As New OleDbConnection(ConnectionString)
        'Dim myConn As New oledb40Class(ConnectionString)
        Dim sql As String = "Select * from " & cn

        Dim myCommand As New OleDbCommand(sql, myconn)

        myconn.Open()

        Dim da As New OleDbDataAdapter(myCommand)


        Dim ds As New DataSet()
        Try
            da.Fill(ds, cn)
            For Each dc In ds.Tables(cn).Columns
                'MsgBox(dc.ColumnName.ToString)
                ComboBox3.Items.Add(dc.columnname.ToString)
                ComboBox4.Items.Add(dc.columnname.ToString)

            Next
            

        Catch ex As Exception
            MsgBox("Error....")
        End Try
    End Sub
    Public Sub getfieldName2007(ByVal cn As String)

        Dim ConnectionString As String = "provider=microsoft.ACE.oledb.12.0;data source=" & openform.TextBox1.Text

        Dim myconn As New OleDbConnection(ConnectionString)
        'Dim myConn As New oledb40Class(ConnectionString)
        Dim sql As String = "Select * from " & cn

        Dim myCommand As New OleDbCommand(sql, myconn)

        myconn.Open()

        Dim da As New OleDbDataAdapter(myCommand)


        Dim ds As New DataSet()
        Try
            da.Fill(ds, cn)
            For Each dc In ds.Tables(cn).Columns
                'MsgBox(dc.ColumnName.ToString)
                ComboBox3.Items.Add(dc.columnname.ToString)
                ComboBox4.Items.Add(dc.columnname.ToString)
            Next

        Catch ex As Exception
            MsgBox("Error....")
        End Try
    End Sub
    Public Sub getfieldNameSQL(ByVal cn As String)

        Dim ConnectionString As String = "data source=.\sqlexpress;initial catalog=" & openform.ComboBox2.SelectedItem.ToString & ";integrated security=true"

        Dim myconn As New SqlConnection(ConnectionString)
        'Dim myConn As New oledb40Class(ConnectionString)
        Dim sql As String = "Select * from " & cn

        Dim myCommand As New SqlCommand(sql, myconn)

        myconn.Open()

        Dim da As New SqlDataAdapter(myCommand)


        Dim ds As New DataSet()
        Try
            da.Fill(ds, cn)
            For Each dc In ds.Tables(cn).Columns
                'MsgBox(dc.ColumnName.ToString)
                ComboBox3.Items.Add(dc.columnname.ToString)
                ComboBox4.Items.Add(dc.columnname.ToString)
            Next

        Catch ex As Exception
            MsgBox("Error....")
        End Try
    End Sub
    Public Sub getfieldNameOracle(ByVal cn As String)
        Dim uid As String = openform.TextBox3.Text
        Dim pass As String = openform.TextBox4.Text
        Dim ConnectionString As String = "provider=oraoledb.oracle;server name=localhost;user id=" & uid & ";password=" & pass

        Dim myconn As New OleDbConnection(ConnectionString)
        'Dim myConn As New oledb40Class(ConnectionString)
        Dim sql As String = "Select * from " & cn

        Dim myCommand As New OleDbCommand(sql, myconn)

        myconn.Open()

        Dim da As New OleDbDataAdapter(myCommand)


        Dim ds As New DataSet()
        Try
            da.Fill(ds, cn)
            For Each dc In ds.Tables(cn).Columns
                'MsgBox(dc.ColumnName.ToString)
                ComboBox3.Items.Add(dc.columnname.ToString)
                ComboBox4.Items.Add(dc.columnname.ToString)
            Next

        Catch ex As Exception
            MsgBox("Error....")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button2.Enabled = True
        Dim tblnm As String
        If openform.ListBox1.SelectedIndex = 0 Then
            tblnm = ComboBox1.SelectedItem.ToString
            ComboBox3.Items.Clear()
            ComboBox4.Items.Clear()

            getfieldName2003(tblnm)
        End If
        If openform.ListBox1.SelectedIndex = 1 Then
            tblnm = ComboBox1.SelectedItem.ToString
            ComboBox3.Items.Clear()
            ComboBox4.Items.Clear()
            getfieldName2007(tblnm)
        End If
        If openform.ListBox1.SelectedIndex = 2 Then
            tblnm = ComboBox1.SelectedItem.ToString
            ComboBox3.Items.Clear()
            ComboBox4.Items.Clear()
            getfieldNameSQL(tblnm)
        End If
        If openform.ListBox1.SelectedIndex = 3 Then
            tblnm = ComboBox1.SelectedItem.ToString
            ComboBox3.Items.Clear()
            ComboBox4.Items.Clear()
            getfieldNameOracle(tblnm)
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Button10.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Len(TextBox1.Text) > 0 Then
            Button7.Enabled = True
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        'TextBox1.Enabled = False
        'CheckBox1.Enabled = False
        Button7.Enabled = True

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        If openform.ListBox1.SelectedIndex = 0 Then
            Dim cn As String = ComboBox2.SelectedItem.ToString
            getfieldName2003(cn)
        End If
        If openform.ListBox1.SelectedIndex = 1 Then
            Dim cn As String = ComboBox2.SelectedItem.ToString
            getfieldName2007(cn)
        End If
        If openform.ListBox1.SelectedIndex = 2 Then
            Dim cn As String = ComboBox2.SelectedItem.ToString
            getfieldNameSQL(cn)
        End If
        If openform.ListBox1.SelectedIndex = 3 Then
            Dim cn As String = ComboBox2.SelectedItem.ToString
            getfieldNameOracle(cn)
        End If
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            ComboBox4.Enabled = False
            TextBox1.Enabled = False
            Button7.Enabled = True
        End If
        If CheckBox1.Checked = False Then
            ComboBox4.Enabled = True
            TextBox1.Enabled = True
            Button7.Enabled = False
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Hide()
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Hide()
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel1.Visible = True
    End Sub
End Class
Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class queryform

    Dim cmd As New OleDbCommand
    Dim con As New OleDbConnection

    Private Sub runqrybtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles runqrybtn.Click
        Dim qry As String
        qry = queryTextBox1.Text

        If openform.ListBox1.SelectedIndex = 0 Then
            Dim cn As String = openform.TextBox1.Text
            Dim obj As New oledb40Class(cn)
            obj.executequery1(qry)
            'openform.getAllTableschema2003(cn)

        End If
        If openform.ListBox1.SelectedIndex = 1 Then
            Dim cn As String = openform.TextBox1.Text
            Dim obj As New oledb120Class(cn)
            obj.executequery1(qry)
        End If
        If openform.ListBox1.SelectedIndex = 2 Then
            Dim cn As String = openform.TextBox1.Text
            Dim obj As New sqlClass(cn)
            obj.executequery1(qry)
        End If
        If openform.ListBox1.SelectedIndex = 3 Then
            Dim un As String = openform.TextBox3.Text
            Dim pass As String = openform.TextBox4.Text
            
            Dim obj As New OracleClass1(un, pass)
            obj.executequery1(qry)
        End If
    End Sub

    Private Sub OutputTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutputTextBox.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub queryform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub queryTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles queryTextBox1.TextChanged

    End Sub
End Class
Public Class Mainform

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        

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
        ElseIf ListBox1.SelectedIndex = 2 Then
            'OpenFileDialog1.DefaultExt = ".sql"
            OpenFileDialog1.AddExtension = True
            OpenFileDialog1.FileName = ""
            'OpenFileDialog1.Filter = "SQL Databases(.sql)|*.sql"
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                TextBox1.Text = OpenFileDialog1.FileName
                pnlopen.Enabled = True
            End If
        End If
    End Sub

    Private Sub Mainform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
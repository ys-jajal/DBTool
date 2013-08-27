Public Class DBTool

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Open.Click
        queryform.Close()
        ' TabControl1.
        openform.MdiParent = Me
        openform.Show()
        openform.Dock = DockStyle.Fill

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub disablebtn()
        Query.Enabled = False
        Query.FlatStyle = FlatStyle.Standard
        Tool.Enabled = False
        Tool.FlatStyle = FlatStyle.Standard
        'DesignView.Enabled = False
        'DesignView.FlatStyle = FlatStyle.Standard
        conclose.Enabled = False
        conclose.FlatStyle = FlatStyle.Standard


    End Sub
    Private Sub enablebtn()
        Query.Enabled = True
        Query.FlatStyle = FlatStyle.Flat
        Tool.Enabled = True
        Tool.FlatStyle = FlatStyle.Flat
        'DesignView.Enabled = True
        'DesignView.FlatStyle = FlatStyle.Flat
        conclose.Enabled = True
        conclose.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub DBTool_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Startup.Close()

    End Sub

    Private Sub DBTool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disablebtn()
    End Sub

    Private Sub Query_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Query.Click
        queryform.MdiParent = Me
        Form2.Hide()
        openform2.Hide()
        DesingVw.Hide()
        queryform.Show()
        queryform.Dock = DockStyle.Bottom


    End Sub

    Private Sub conclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles conclose.Click
        Dim obj1 As New oledb40Class
        Form2.Close()
        openform.Close()
        queryform.Close()
        openform2.Close()
        DesingVw.Close()
        obj1.disconnect()
        Open.Enabled = True
        disablebtn()

    End Sub

    Private Sub DesignView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        DesingVw.MdiParent = Me
        DesingVw.Dock = DockStyle.Bottom
        Form2.Hide()
        openform2.Hide()
        openform.Hide()
        queryform.Hide()

        DesingVw.Show()



    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripContainer1_TopToolStripPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Open_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Open.MouseHover
        Label1.Visible = True
    End Sub

    Private Sub Open_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Open.MouseLeave
        Label1.Visible = False
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Query_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Query.MouseHover
        Label2.Visible = True

    End Sub

    Private Sub Query_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Query.MouseLeave
        Label2.Visible = False
    End Sub

    Private Sub Tool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool.Click
        openform.Hide()
        queryform.Hide()
        DesingVw.Hide()
        openform2.DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter
        openform2.Button1.Visible = True
        openform2.Label2.Visible = True
        openform2.Button2.Visible = True
        openform2.Label3.Visible = True
        openform2.Button3.Visible = True
        openform2.Label4.Visible = True
        openform2.Button4.Visible = True
        openform2.Label5.Visible = True
        openform2.Show()
    End Sub

    Private Sub Tool_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tool.MouseHover
        Label3.Visible = True
    End Sub

    Private Sub Tool_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tool.MouseLeave
        Label3.Visible = False
    End Sub

    Private Sub DesignView_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        'Label4.Visible = True
    End Sub

    Private Sub DesignView_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        'Label4.Visible = False
    End Sub

    Private Sub conclose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles conclose.MouseHover
        Label5.Visible = True

    End Sub

    Private Sub conclose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles conclose.MouseLeave
        Label5.Visible = False
    End Sub

    Private Sub Label5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        queryform.Hide()
        'DesignView.Hide()
        openform.Hide()
        openform2.MdiParent = Me
        openform2.Show()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Help.ShowHelp(Me, "D:\help.chm")
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Label4.Visible = True
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Label4.Visible = False
    End Sub

    

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DesingVw.MdiParent = Me
        queryform.Hide()
        'DesignView.Hide()
        openform.Hide()
        DesingVw.Dock = DockStyle.Fill
        DesingVw.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        form1.Show()
    End Sub
End Class

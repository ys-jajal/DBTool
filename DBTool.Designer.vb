<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBTool
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DBTool))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.conclose = New System.Windows.Forms.Button
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.Tool = New System.Windows.Forms.Button
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Query = New System.Windows.Forms.Button
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Open = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(243, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Open"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(328, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Query"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(423, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tools"
        Me.Label3.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(482, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Close Connection"
        Me.Label5.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.conclose)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.Tool)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Query)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Open)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(110, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(887, 100)
        Me.Panel1.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(597, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Help"
        Me.Label4.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Desing.My.Resources.Resources.help_256
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gold
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(585, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 69)
        Me.Button1.TabIndex = 25
        Me.Button1.UseVisualStyleBackColor = False
        '
        'conclose
        '
        Me.conclose.BackColor = System.Drawing.Color.Transparent
        Me.conclose.BackgroundImage = Global.Desing.My.Resources.Resources._1206557186603844069mcol_cross_svg_hi
        Me.conclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.conclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.conclose.Enabled = False
        Me.conclose.FlatAppearance.BorderSize = 0
        Me.conclose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gold
        Me.conclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.conclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.conclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.conclose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.conclose.Location = New System.Drawing.Point(498, 3)
        Me.conclose.Name = "conclose"
        Me.conclose.Size = New System.Drawing.Size(65, 69)
        Me.conclose.TabIndex = 4
        Me.conclose.UseVisualStyleBackColor = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Desing.My.Resources.Resources.seperetor
        Me.PictureBox6.Location = New System.Drawing.Point(656, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(5, 98)
        Me.PictureBox6.TabIndex = 24
        Me.PictureBox6.TabStop = False
        '
        'Tool
        '
        Me.Tool.BackColor = System.Drawing.Color.Transparent
        Me.Tool.BackgroundImage = Global.Desing.My.Resources.Resources.Settings_icon
        Me.Tool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Tool.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tool.Enabled = False
        Me.Tool.FlatAppearance.BorderSize = 0
        Me.Tool.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gold
        Me.Tool.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Tool.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.Tool.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Tool.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tool.Location = New System.Drawing.Point(411, 2)
        Me.Tool.Name = "Tool"
        Me.Tool.Size = New System.Drawing.Size(65, 69)
        Me.Tool.TabIndex = 2
        Me.Tool.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Desing.My.Resources.Resources.seperetor
        Me.PictureBox5.Location = New System.Drawing.Point(569, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(5, 98)
        Me.PictureBox5.TabIndex = 23
        Me.PictureBox5.TabStop = False
        '
        'Query
        '
        Me.Query.BackColor = System.Drawing.Color.Transparent
        Me.Query.BackgroundImage = Global.Desing.My.Resources.Resources._5952066
        Me.Query.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Query.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Query.Enabled = False
        Me.Query.FlatAppearance.BorderSize = 0
        Me.Query.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gold
        Me.Query.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Query.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.Query.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Query.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Query.Location = New System.Drawing.Point(319, 1)
        Me.Query.Name = "Query"
        Me.Query.Size = New System.Drawing.Size(66, 72)
        Me.Query.TabIndex = 1
        Me.Query.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Desing.My.Resources.Resources.seperetor
        Me.PictureBox4.Location = New System.Drawing.Point(482, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(5, 98)
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Desing.My.Resources.Resources.seperetor
        Me.PictureBox2.Location = New System.Drawing.Point(391, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(5, 98)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Open
        '
        Me.Open.BackColor = System.Drawing.Color.Transparent
        Me.Open.BackgroundImage = Global.Desing.My.Resources.Resources.Folder_Open1
        Me.Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Open.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Open.FlatAppearance.BorderSize = 0
        Me.Open.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gold
        Me.Open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Open.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Open.Location = New System.Drawing.Point(231, 2)
        Me.Open.Name = "Open"
        Me.Open.Size = New System.Drawing.Size(66, 69)
        Me.Open.TabIndex = 0
        Me.Open.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Desing.My.Resources.Resources.seperetor
        Me.PictureBox1.Location = New System.Drawing.Point(303, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(5, 98)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Desing.My.Resources.Resources.seperetor
        Me.PictureBox3.Location = New System.Drawing.Point(215, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(5, 98)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkGray
        Me.ToolStrip1.BackgroundImage = Global.Desing.My.Resources.Resources.menubck1
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1110, 134)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'DBTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1110, 551)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "DBTool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DB Tool"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents conclose As System.Windows.Forms.Button
    Friend WithEvents Tool As System.Windows.Forms.Button
    Friend WithEvents Query As System.Windows.Forms.Button
    Friend WithEvents Open As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class

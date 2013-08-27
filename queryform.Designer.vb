<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class queryform
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
        Me.QueryPanel = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.runqrybtn = New System.Windows.Forms.Button
        Me.OutputTextBox = New System.Windows.Forms.TextBox
        Me.QryDataGridView1 = New System.Windows.Forms.DataGridView
        Me.queryTextBox1 = New System.Windows.Forms.TextBox
        Me.QueryPanel.SuspendLayout()
        CType(Me.QryDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QueryPanel
        '
        Me.QueryPanel.BackColor = System.Drawing.Color.Khaki
        Me.QueryPanel.Controls.Add(Me.Label2)
        Me.QueryPanel.Controls.Add(Me.Label1)
        Me.QueryPanel.Controls.Add(Me.runqrybtn)
        Me.QueryPanel.Controls.Add(Me.OutputTextBox)
        Me.QueryPanel.Controls.Add(Me.QryDataGridView1)
        Me.QueryPanel.Controls.Add(Me.queryTextBox1)
        Me.QueryPanel.Location = New System.Drawing.Point(297, 7)
        Me.QueryPanel.Name = "QueryPanel"
        Me.QueryPanel.Size = New System.Drawing.Size(518, 369)
        Me.QueryPanel.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Output Window"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Query Window"
        '
        'runqrybtn
        '
        Me.runqrybtn.BackgroundImage = Global.Desing.My.Resources.Resources._5952066
        Me.runqrybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.runqrybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.runqrybtn.Location = New System.Drawing.Point(442, 106)
        Me.runqrybtn.Name = "runqrybtn"
        Me.runqrybtn.Size = New System.Drawing.Size(42, 35)
        Me.runqrybtn.TabIndex = 17
        Me.runqrybtn.UseVisualStyleBackColor = True
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputTextBox.Location = New System.Drawing.Point(36, 169)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.Size = New System.Drawing.Size(400, 117)
        Me.OutputTextBox.TabIndex = 16
        Me.OutputTextBox.Visible = False
        '
        'QryDataGridView1
        '
        Me.QryDataGridView1.AllowUserToAddRows = False
        Me.QryDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.QryDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.QryDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QryDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.QryDataGridView1.GridColor = System.Drawing.Color.Khaki
        Me.QryDataGridView1.Location = New System.Drawing.Point(36, 182)
        Me.QryDataGridView1.Name = "QryDataGridView1"
        Me.QryDataGridView1.Size = New System.Drawing.Size(400, 168)
        Me.QryDataGridView1.TabIndex = 15
        Me.QryDataGridView1.Visible = False
        '
        'queryTextBox1
        '
        Me.queryTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.queryTextBox1.Location = New System.Drawing.Point(36, 26)
        Me.queryTextBox1.Multiline = True
        Me.queryTextBox1.Name = "queryTextBox1"
        Me.queryTextBox1.Size = New System.Drawing.Size(400, 115)
        Me.queryTextBox1.TabIndex = 0
        '
        'queryform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Desing.My.Resources.Resources.formbck
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 410)
        Me.Controls.Add(Me.QueryPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "queryform"
        Me.Text = "queryform"
        Me.QueryPanel.ResumeLayout(False)
        Me.QueryPanel.PerformLayout()
        CType(Me.QryDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QueryPanel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents runqrybtn As System.Windows.Forms.Button
    Friend WithEvents OutputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QryDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents queryTextBox1 As System.Windows.Forms.TextBox
End Class

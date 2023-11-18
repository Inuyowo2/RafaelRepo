<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcourse = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtstudcourse = New System.Windows.Forms.TextBox()
        Me.txtlast = New System.Windows.Forms.TextBox()
        Me.txtfirst = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.btninsert)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcourse)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 258)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test"
        '
        'btninsert
        '
        Me.btninsert.Location = New System.Drawing.Point(50, 190)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(133, 42)
        Me.btninsert.TabIndex = 6
        Me.btninsert.Text = "Insert Record"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name"
        '
        'txtcourse
        '
        Me.txtcourse.Location = New System.Drawing.Point(118, 141)
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.Size = New System.Drawing.Size(100, 24)
        Me.txtcourse.TabIndex = 2
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(118, 95)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(100, 24)
        Me.txtlname.TabIndex = 1
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(118, 51)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(100, 24)
        Me.txtfname.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.ImageLocation = "C:\Users\ITLAB-33\Downloads\mgg7mbt9vk2b1.jpg"
        Me.PictureBox1.Location = New System.Drawing.Point(530, 321)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.btndelete)
        Me.GroupBox2.Controls.Add(Me.btnupdate)
        Me.GroupBox2.Controls.Add(Me.txtuserid)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnsearch)
        Me.GroupBox2.Controls.Add(Me.txtstudcourse)
        Me.GroupBox2.Controls.Add(Me.txtlast)
        Me.GroupBox2.Controls.Add(Me.txtfirst)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 257)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'txtuserid
        '
        Me.txtuserid.Location = New System.Drawing.Point(128, 37)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(100, 20)
        Me.txtuserid.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Student ID"
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(83, 199)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(91, 32)
        Me.btnsearch.TabIndex = 13
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtstudcourse
        '
        Me.txtstudcourse.Location = New System.Drawing.Point(128, 161)
        Me.txtstudcourse.Name = "txtstudcourse"
        Me.txtstudcourse.Size = New System.Drawing.Size(100, 20)
        Me.txtstudcourse.TabIndex = 12
        '
        'txtlast
        '
        Me.txtlast.Location = New System.Drawing.Point(128, 115)
        Me.txtlast.Name = "txtlast"
        Me.txtlast.Size = New System.Drawing.Size(100, 20)
        Me.txtlast.TabIndex = 11
        '
        'txtfirst
        '
        Me.txtfirst.Location = New System.Drawing.Point(128, 76)
        Me.txtfirst.Name = "txtfirst"
        Me.txtfirst.Size = New System.Drawing.Size(100, 20)
        Me.txtfirst.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Course"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Last Name"
        '
        'btndisplay
        '
        Me.btndisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndisplay.Location = New System.Drawing.Point(45, 321)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(150, 47)
        Me.btndisplay.TabIndex = 3
        Me.btndisplay.Text = "Display By Course"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(0, 228)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 16
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(175, 229)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(71, 22)
        Me.btndelete.TabIndex = 17
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(658, 450)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btninsert As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcourse As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtstudcourse As TextBox
    Friend WithEvents txtlast As TextBox
    Friend WithEvents txtfirst As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtuserid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btndisplay As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnupdate As Button
End Class

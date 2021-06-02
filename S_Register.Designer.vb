<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_Register
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_en = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_add = New System.Windows.Forms.TextBox()
        Me.rb_male = New System.Windows.Forms.RadioButton()
        Me.rb_female = New System.Windows.Forms.RadioButton()
        Me.dtp_dob = New System.Windows.Forms.DateTimePicker()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_cn = New System.Windows.Forms.TextBox()
        Me.dtp_ad = New System.Windows.Forms.DateTimePicker()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ep_en = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ep_fname = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ep_lname = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ep_add = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ep_cn = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cb_standard = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.ep_en, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ep_fname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ep_lname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ep_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ep_cn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(473, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Register"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(338, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enrollment No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(338, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(338, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(338, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 29)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(338, 517)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(338, 566)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 29)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Date of Birth"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(338, 632)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 29)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Contact No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(338, 700)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(195, 29)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Addmission Date"
        '
        'txt_en
        '
        Me.txt_en.BackColor = System.Drawing.Color.Black
        Me.txt_en.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_en.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_en.ForeColor = System.Drawing.Color.White
        Me.txt_en.Location = New System.Drawing.Point(560, 124)
        Me.txt_en.Name = "txt_en"
        Me.txt_en.Size = New System.Drawing.Size(292, 27)
        Me.txt_en.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(560, 149)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 2)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(562, 212)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 2)
        Me.Panel2.TabIndex = 22
        '
        'txt_fname
        '
        Me.txt_fname.BackColor = System.Drawing.Color.Black
        Me.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.ForeColor = System.Drawing.Color.White
        Me.txt_fname.Location = New System.Drawing.Point(562, 187)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(292, 27)
        Me.txt_fname.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(562, 278)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(292, 2)
        Me.Panel3.TabIndex = 24
        '
        'txt_lname
        '
        Me.txt_lname.BackColor = System.Drawing.Color.Black
        Me.txt_lname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.ForeColor = System.Drawing.Color.White
        Me.txt_lname.Location = New System.Drawing.Point(562, 253)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(292, 27)
        Me.txt_lname.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(560, 423)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(292, 2)
        Me.Panel4.TabIndex = 22
        '
        'txt_add
        '
        Me.txt_add.BackColor = System.Drawing.Color.Black
        Me.txt_add.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add.ForeColor = System.Drawing.Color.White
        Me.txt_add.Location = New System.Drawing.Point(562, 323)
        Me.txt_add.Multiline = True
        Me.txt_add.Name = "txt_add"
        Me.txt_add.Size = New System.Drawing.Size(290, 102)
        Me.txt_add.TabIndex = 5
        '
        'rb_male
        '
        Me.rb_male.AutoSize = True
        Me.rb_male.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_male.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rb_male.Location = New System.Drawing.Point(562, 524)
        Me.rb_male.Name = "rb_male"
        Me.rb_male.Size = New System.Drawing.Size(87, 33)
        Me.rb_male.TabIndex = 7
        Me.rb_male.TabStop = True
        Me.rb_male.Text = "Male"
        Me.rb_male.UseVisualStyleBackColor = True
        '
        'rb_female
        '
        Me.rb_female.AutoSize = True
        Me.rb_female.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_female.ForeColor = System.Drawing.Color.White
        Me.rb_female.Location = New System.Drawing.Point(682, 524)
        Me.rb_female.Name = "rb_female"
        Me.rb_female.Size = New System.Drawing.Size(116, 33)
        Me.rb_female.TabIndex = 8
        Me.rb_female.TabStop = True
        Me.rb_female.Text = "Female"
        Me.rb_female.UseVisualStyleBackColor = True
        '
        'dtp_dob
        '
        Me.dtp_dob.Location = New System.Drawing.Point(562, 572)
        Me.dtp_dob.Name = "dtp_dob"
        Me.dtp_dob.Size = New System.Drawing.Size(290, 22)
        Me.dtp_dob.TabIndex = 9
        Me.dtp_dob.Value = New Date(2021, 5, 10, 9, 20, 8, 0)
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(560, 659)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(292, 2)
        Me.Panel5.TabIndex = 29
        '
        'txt_cn
        '
        Me.txt_cn.BackColor = System.Drawing.Color.Black
        Me.txt_cn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cn.ForeColor = System.Drawing.Color.White
        Me.txt_cn.Location = New System.Drawing.Point(560, 634)
        Me.txt_cn.Name = "txt_cn"
        Me.txt_cn.Size = New System.Drawing.Size(292, 27)
        Me.txt_cn.TabIndex = 10
        '
        'dtp_ad
        '
        Me.dtp_ad.Location = New System.Drawing.Point(564, 705)
        Me.dtp_ad.Name = "dtp_ad"
        Me.dtp_ad.Size = New System.Drawing.Size(290, 22)
        Me.dtp_ad.TabIndex = 11
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.Color.Black
        Me.btn_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_submit.Location = New System.Drawing.Point(545, 760)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(118, 67)
        Me.btn_submit.TabIndex = 12
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(1163, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 36)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ep_en
        '
        Me.ep_en.BlinkRate = 0
        Me.ep_en.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ep_en.ContainerControl = Me
        '
        'ep_fname
        '
        Me.ep_fname.BlinkRate = 0
        Me.ep_fname.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ep_fname.ContainerControl = Me
        '
        'ep_lname
        '
        Me.ep_lname.BlinkRate = 0
        Me.ep_lname.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ep_lname.ContainerControl = Me
        '
        'ep_add
        '
        Me.ep_add.BlinkRate = 0
        Me.ep_add.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ep_add.ContainerControl = Me
        '
        'ep_cn
        '
        Me.ep_cn.BlinkRate = 0
        Me.ep_cn.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ep_cn.ContainerControl = Me
        '
        'cb_standard
        '
        Me.cb_standard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_standard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_standard.FormattingEnabled = True
        Me.cb_standard.Location = New System.Drawing.Point(560, 463)
        Me.cb_standard.Name = "cb_standard"
        Me.cb_standard.Size = New System.Drawing.Size(294, 33)
        Me.cb_standard.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(338, 456)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 29)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Standard"
        '
        'S_Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1214, 876)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cb_standard)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.dtp_ad)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txt_cn)
        Me.Controls.Add(Me.dtp_dob)
        Me.Controls.Add(Me.rb_female)
        Me.Controls.Add(Me.rb_male)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txt_add)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_en)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "S_Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S_Register"
        CType(Me.ep_en, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ep_fname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ep_lname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ep_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ep_cn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_en As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_add As TextBox
    Friend WithEvents rb_male As RadioButton
    Friend WithEvents rb_female As RadioButton
    Friend WithEvents dtp_dob As DateTimePicker
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_cn As TextBox
    Friend WithEvents dtp_ad As DateTimePicker
    Friend WithEvents btn_submit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ep_en As ErrorProvider
    Friend WithEvents ep_fname As ErrorProvider
    Friend WithEvents ep_lname As ErrorProvider
    Friend WithEvents ep_add As ErrorProvider
    Friend WithEvents ep_cn As ErrorProvider
    Friend WithEvents Label10 As Label
    Friend WithEvents cb_standard As ComboBox
End Class

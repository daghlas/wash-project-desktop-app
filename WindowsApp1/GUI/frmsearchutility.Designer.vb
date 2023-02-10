<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmsearchutility
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsearchutility))
        Me.dtgvill = New System.Windows.Forms.DataGridView()
        Me.cmdQueue = New System.Windows.Forms.Button()
        Me.cmdsearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkChange = New System.Windows.Forms.CheckBox()
        Me.chkchild = New System.Windows.Forms.CheckBox()
        Me.chkAdult = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_Go = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbCluster = New System.Windows.Forms.ComboBox()
        Me.cbVillage = New System.Windows.Forms.ComboBox()
        Me.chk_revisit = New System.Windows.Forms.CheckBox()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.cb_Gender = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtSublocation = New System.Windows.Forms.TextBox()
        Me.txtOtherSpecify = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtTEMPID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.pic_Image = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dtgvill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvill
        '
        Me.dtgvill.AllowUserToAddRows = False
        Me.dtgvill.AllowUserToDeleteRows = False
        Me.dtgvill.AllowUserToResizeColumns = False
        Me.dtgvill.AllowUserToResizeRows = False
        Me.dtgvill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgvill.BackgroundColor = System.Drawing.Color.White
        Me.dtgvill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgvill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvill.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgvill.Location = New System.Drawing.Point(17, 51)
        Me.dtgvill.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtgvill.Name = "dtgvill"
        Me.dtgvill.ReadOnly = True
        Me.dtgvill.RowHeadersVisible = False
        Me.dtgvill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvill.Size = New System.Drawing.Size(262, 194)
        Me.dtgvill.TabIndex = 2
        '
        'cmdQueue
        '
        Me.cmdQueue.BackColor = System.Drawing.Color.DarkSalmon
        Me.cmdQueue.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQueue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdQueue.Image = Global.Patient_Care_System.My.Resources.Resources.group
        Me.cmdQueue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdQueue.Location = New System.Drawing.Point(611, 289)
        Me.cmdQueue.Name = "cmdQueue"
        Me.cmdQueue.Size = New System.Drawing.Size(135, 25)
        Me.cmdQueue.TabIndex = 14
        Me.cmdQueue.Text = "Queue Participant"
        Me.cmdQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdQueue.UseVisualStyleBackColor = False
        '
        'cmdsearch
        '
        Me.cmdsearch.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdsearch.Image = Global.Patient_Care_System.My.Resources.Resources.search
        Me.cmdsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdsearch.Location = New System.Drawing.Point(189, 13)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(95, 24)
        Me.cmdsearch.TabIndex = 15
        Me.cmdsearch.Text = "SEARCH  Patient"
        Me.cmdsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.chkChange)
        Me.GroupBox1.Controls.Add(Me.chkchild)
        Me.GroupBox1.Controls.Add(Me.chkAdult)
        Me.GroupBox1.Controls.Add(Me.cmdsearch)
        Me.GroupBox1.Location = New System.Drawing.Point(241, 263)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(10, 10)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(305, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 25)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Get Residents"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkChange
        '
        Me.chkChange.AutoSize = True
        Me.chkChange.ForeColor = System.Drawing.Color.Red
        Me.chkChange.Location = New System.Drawing.Point(6, 15)
        Me.chkChange.Name = "chkChange"
        Me.chkChange.Size = New System.Drawing.Size(112, 20)
        Me.chkChange.TabIndex = 14
        Me.chkChange.Text = "Change selection"
        Me.chkChange.UseVisualStyleBackColor = True
        Me.chkChange.Visible = False
        '
        'chkchild
        '
        Me.chkchild.AutoSize = True
        Me.chkchild.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkchild.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkchild.Location = New System.Drawing.Point(36, 13)
        Me.chkchild.Name = "chkchild"
        Me.chkchild.Size = New System.Drawing.Size(54, 20)
        Me.chkchild.TabIndex = 2
        Me.chkchild.Text = "Child"
        Me.chkchild.UseVisualStyleBackColor = True
        Me.chkchild.Visible = False
        '
        'chkAdult
        '
        Me.chkAdult.AutoSize = True
        Me.chkAdult.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkAdult.Location = New System.Drawing.Point(34, 12)
        Me.chkAdult.Name = "chkAdult"
        Me.chkAdult.Size = New System.Drawing.Size(56, 20)
        Me.chkAdult.TabIndex = 1
        Me.chkAdult.Text = "Adult"
        Me.chkAdult.UseVisualStyleBackColor = True
        Me.chkAdult.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 292)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 27)
        Me.Panel1.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Participant demographic information"
        '
        'cmd_Go
        '
        Me.cmd_Go.Location = New System.Drawing.Point(507, 258)
        Me.cmd_Go.Name = "cmd_Go"
        Me.cmd_Go.Size = New System.Drawing.Size(10, 10)
        Me.cmd_Go.TabIndex = 12
        Me.cmd_Go.Text = "GO"
        Me.cmd_Go.UseVisualStyleBackColor = True
        Me.cmd_Go.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbCluster)
        Me.GroupBox2.Controls.Add(Me.cbVillage)
        Me.GroupBox2.Controls.Add(Me.chk_revisit)
        Me.GroupBox2.Controls.Add(Me.txt_age)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.dtpDOB)
        Me.GroupBox2.Controls.Add(Me.cb_Gender)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.btnDone)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtLocation)
        Me.GroupBox2.Controls.Add(Me.txtSublocation)
        Me.GroupBox2.Controls.Add(Me.txtOtherSpecify)
        Me.GroupBox2.Controls.Add(Me.txtContact)
        Me.GroupBox2.Controls.Add(Me.txtlname)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtMname)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.txtTEMPID)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(21, 12)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Non Surveillance Patients Data Entry Form"
        Me.GroupBox2.Visible = False
        '
        'cbCluster
        '
        Me.cbCluster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCluster.Enabled = False
        Me.cbCluster.FormattingEnabled = True
        Me.cbCluster.Items.AddRange(New Object() {"", "Soweto", "Kwa mwaura", "Kwa Muganda", "Maranatha", "Mugumo", "KK", "Mama okinda", "Kajulu", "Mama Ruth", "Mfereji nane", "Other"})
        Me.cbCluster.Location = New System.Drawing.Point(159, 113)
        Me.cbCluster.Name = "cbCluster"
        Me.cbCluster.Size = New System.Drawing.Size(143, 24)
        Me.cbCluster.TabIndex = 102
        '
        'cbVillage
        '
        Me.cbVillage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVillage.FormattingEnabled = True
        Me.cbVillage.Items.AddRange(New Object() {"", "Soweto West", "Gatwekera", "Lindi", "Raila", "Kianda", "Kisumu ndogo", "Mashimoni", "Kichijio", "Liani saba", "Makina", "Silanga", "Soweto East", "Kambi muru", "Other"})
        Me.cbVillage.Location = New System.Drawing.Point(10, 113)
        Me.cbVillage.Name = "cbVillage"
        Me.cbVillage.Size = New System.Drawing.Size(143, 24)
        Me.cbVillage.TabIndex = 102
        '
        'chk_revisit
        '
        Me.chk_revisit.AutoSize = True
        Me.chk_revisit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_revisit.Location = New System.Drawing.Point(524, 22)
        Me.chk_revisit.Name = "chk_revisit"
        Me.chk_revisit.Size = New System.Drawing.Size(59, 17)
        Me.chk_revisit.TabIndex = 25
        Me.chk_revisit.Text = "Revisit"
        Me.chk_revisit.UseVisualStyleBackColor = True
        Me.chk_revisit.Visible = False
        '
        'txt_age
        '
        Me.txt_age.Enabled = False
        Me.txt_age.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_age.Location = New System.Drawing.Point(602, 179)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(47, 22)
        Me.txt_age.TabIndex = 9
        Me.txt_age.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(570, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Age:"
        Me.Label9.Visible = False
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "yyyy-MMM-dd"
        Me.dtpDOB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(269, 172)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(91, 22)
        Me.dtpDOB.TabIndex = 8
        '
        'cb_Gender
        '
        Me.cb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Gender.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Gender.FormattingEnabled = True
        Me.cb_Gender.Items.AddRange(New Object() {"M", "F"})
        Me.cb_Gender.Location = New System.Drawing.Point(67, 172)
        Me.cb_Gender.Name = "cb_Gender"
        Me.cb_Gender.Size = New System.Drawing.Size(116, 21)
        Me.cb_Gender.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(595, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 25)
        Me.Button2.TabIndex = 100
        Me.Button2.Text = "GENID"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'btnDone
        '
        Me.btnDone.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(12, 204)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(63, 25)
        Me.btnDone.TabIndex = 10
        Me.btnDone.Text = "DONE"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(191, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Date of Birth"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Gender:"
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(12, 113)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(143, 22)
        Me.txtLocation.TabIndex = 4
        '
        'txtSublocation
        '
        Me.txtSublocation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSublocation.Location = New System.Drawing.Point(161, 113)
        Me.txtSublocation.Name = "txtSublocation"
        Me.txtSublocation.Size = New System.Drawing.Size(172, 22)
        Me.txtSublocation.TabIndex = 5
        '
        'txtOtherSpecify
        '
        Me.txtOtherSpecify.Enabled = False
        Me.txtOtherSpecify.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherSpecify.Location = New System.Drawing.Point(12, 141)
        Me.txtOtherSpecify.Name = "txtOtherSpecify"
        Me.txtOtherSpecify.Size = New System.Drawing.Size(143, 22)
        Me.txtOtherSpecify.TabIndex = 6
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(339, 113)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(166, 22)
        Me.txtContact.TabIndex = 6
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(339, 61)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(166, 22)
        Me.txtlname.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Sublocation:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(158, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "Village"
        '
        'txtMname
        '
        Me.txtMname.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMname.Location = New System.Drawing.Point(159, 61)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(174, 22)
        Me.txtMname.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(357, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Contact:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(9, 61)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(146, 22)
        Me.txtName.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(336, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "Last Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(158, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Middle Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "First Name:"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(157, -167)
        Me.TextBox5.MaxLength = 7
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(130, 21)
        Me.TextBox5.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(353, 19)
        Me.TextBox2.MaxLength = 7
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(156, 22)
        Me.TextBox2.TabIndex = 101
        Me.TextBox2.Visible = False
        '
        'txtTEMPID
        '
        Me.txtTEMPID.Enabled = False
        Me.txtTEMPID.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTEMPID.Location = New System.Drawing.Point(87, 19)
        Me.txtTEMPID.MaxLength = 7
        Me.txtTEMPID.Name = "txtTEMPID"
        Me.txtTEMPID.Size = New System.Drawing.Size(156, 22)
        Me.txtTEMPID.TabIndex = 100
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(289, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "HOSP_NO:"
        Me.Label12.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "HOSPITAL ID:"
        '
        'CheckBox1
        '
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(561, 255)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(10, 10)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Queue non-study patient"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MMM//yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DateTimePicker2.Location = New System.Drawing.Point(290, 491)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(131, 20)
        Me.DateTimePicker2.TabIndex = 124
        Me.DateTimePicker2.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 494)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 125
        Me.Label11.Text = "Visit Date"
        Me.Label11.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 491)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 20)
        Me.TextBox1.TabIndex = 126
        Me.TextBox1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(13, 317)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(734, 157)
        Me.DataGridView1.TabIndex = 127
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView2.Location = New System.Drawing.Point(291, 51)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(455, 194)
        Me.DataGridView2.TabIndex = 128
        '
        'pic_Image
        '
        Me.pic_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pic_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_Image.ErrorImage = Global.Patient_Care_System.My.Resources.Resources.cancel
        Me.pic_Image.Location = New System.Drawing.Point(766, 12)
        Me.pic_Image.Name = "pic_Image"
        Me.pic_Image.Size = New System.Drawing.Size(22, 74)
        Me.pic_Image.TabIndex = 120
        Me.pic_Image.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Info
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Indigo
        Me.Label4.Location = New System.Drawing.Point(192, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 22)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Name"
        Me.Label4.Visible = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(42, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(200, 22)
        Me.Label16.TabIndex = 129
        Me.Label16.Text = "SELECT CLUSTER"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(309, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(256, 27)
        Me.Label17.TabIndex = 129
        Me.Label17.Text = "SELECT HOUSEHOLD"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(561, 251)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(174, 23)
        Me.Button3.TabIndex = 130
        Me.Button3.Text = "Household Consent"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmsearchutility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(747, 479)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pic_Image)
        Me.Controls.Add(Me.cmd_Go)
        Me.Controls.Add(Me.cmdQueue)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtgvill)
        Me.Controls.Add(Me.DataGridView2)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmsearchutility"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Participant  search utility"
        CType(Me.dtgvill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgvill As System.Windows.Forms.DataGridView
    Friend WithEvents cmdQueue As System.Windows.Forms.Button
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAdult As System.Windows.Forms.CheckBox
    Friend WithEvents chkchild As System.Windows.Forms.CheckBox
    Friend WithEvents chkChange As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmd_Go As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cb_Gender As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTEMPID As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtMname As System.Windows.Forms.TextBox
    Friend WithEvents txt_age As System.Windows.Forms.TextBox
    Friend WithEvents chk_revisit As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSublocation As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbCluster As ComboBox
    Friend WithEvents cbVillage As ComboBox
    Friend WithEvents txtOtherSpecify As TextBox
    Friend WithEvents pic_Image As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button3 As Button
End Class

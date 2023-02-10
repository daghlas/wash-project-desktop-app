<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndividuals
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
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dtgvill = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdQueue = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(515, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(256, 27)
        Me.Label17.TabIndex = 136
        Me.Label17.Text = "SELECT HOUSEHOLD"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(175, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(206, 26)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "SELECT CLUSTER"
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
        Me.DataGridView1.Location = New System.Drawing.Point(53, 333)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(933, 277)
        Me.DataGridView1.TabIndex = 134
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
        Me.dtgvill.Location = New System.Drawing.Point(12, 67)
        Me.dtgvill.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtgvill.Name = "dtgvill"
        Me.dtgvill.ReadOnly = True
        Me.dtgvill.RowHeadersVisible = False
        Me.dtgvill.RowHeadersWidth = 62
        Me.dtgvill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvill.Size = New System.Drawing.Size(305, 194)
        Me.dtgvill.TabIndex = 131
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Participant demographic information"
        '
        'cmdQueue
        '
        Me.cmdQueue.BackColor = System.Drawing.Color.DarkSalmon
        Me.cmdQueue.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQueue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdQueue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdQueue.Location = New System.Drawing.Point(704, 292)
        Me.cmdQueue.Name = "cmdQueue"
        Me.cmdQueue.Size = New System.Drawing.Size(175, 34)
        Me.cmdQueue.TabIndex = 132
        Me.cmdQueue.Text = "Queue Participant"
        Me.cmdQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdQueue.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(150, 300)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 27)
        Me.Panel1.TabIndex = 133
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
        Me.DataGridView2.Location = New System.Drawing.Point(323, 67)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(692, 194)
        Me.DataGridView2.TabIndex = 135
        '
        'frmIndividuals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 656)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dtgvill)
        Me.Controls.Add(Me.cmdQueue)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "frmIndividuals"
        Me.Text = "frmIndividuals"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtgvill As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdQueue As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView2 As DataGridView
End Class

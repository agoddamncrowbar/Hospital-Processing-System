<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.txt_sirname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_role = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_contact = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_pass1 = New System.Windows.Forms.TextBox()
        Me.rd_female = New System.Windows.Forms.RadioButton()
        Me.rd_male = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_savestaff = New System.Windows.Forms.Button()
        Me.btn_editstaff = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uniqueid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_sirname
        '
        Me.txt_sirname.BackColor = System.Drawing.Color.White
        Me.txt_sirname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_sirname.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sirname.Location = New System.Drawing.Point(277, 138)
        Me.txt_sirname.Name = "txt_sirname"
        Me.txt_sirname.Size = New System.Drawing.Size(279, 33)
        Me.txt_sirname.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 33)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Sirname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 33)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Gender"
        '
        'txt_role
        '
        Me.txt_role.BackColor = System.Drawing.Color.White
        Me.txt_role.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_role.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_role.Location = New System.Drawing.Point(277, 177)
        Me.txt_role.Name = "txt_role"
        Me.txt_role.Size = New System.Drawing.Size(279, 33)
        Me.txt_role.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 33)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Role"
        '
        'txt_fname
        '
        Me.txt_fname.BackColor = System.Drawing.Color.White
        Me.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(277, 99)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(279, 33)
        Me.txt_fname.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 33)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Firstname"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 33)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Phone"
        '
        'txt_contact
        '
        Me.txt_contact.BackColor = System.Drawing.Color.White
        Me.txt_contact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact.Location = New System.Drawing.Point(277, 253)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(279, 33)
        Me.txt_contact.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 33)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Password"
        '
        'txt_pass
        '
        Me.txt_pass.BackColor = System.Drawing.Color.White
        Me.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(277, 292)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(279, 33)
        Me.txt_pass.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(270, 33)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Confirm Password"
        '
        'txt_pass1
        '
        Me.txt_pass1.BackColor = System.Drawing.Color.White
        Me.txt_pass1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_pass1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass1.Location = New System.Drawing.Point(277, 331)
        Me.txt_pass1.Name = "txt_pass1"
        Me.txt_pass1.Size = New System.Drawing.Size(279, 33)
        Me.txt_pass1.TabIndex = 27
        '
        'rd_female
        '
        Me.rd_female.AutoSize = True
        Me.rd_female.Location = New System.Drawing.Point(6, 44)
        Me.rd_female.Name = "rd_female"
        Me.rd_female.Size = New System.Drawing.Size(131, 37)
        Me.rd_female.TabIndex = 31
        Me.rd_female.TabStop = True
        Me.rd_female.Text = "Female"
        Me.rd_female.UseVisualStyleBackColor = True
        '
        'rd_male
        '
        Me.rd_male.AutoSize = True
        Me.rd_male.Location = New System.Drawing.Point(143, 44)
        Me.rd_male.Name = "rd_male"
        Me.rd_male.Size = New System.Drawing.Size(96, 37)
        Me.rd_male.TabIndex = 32
        Me.rd_male.TabStop = True
        Me.rd_male.Text = "Male"
        Me.rd_male.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Violet
        Me.GroupBox1.Controls.Add(Me.rd_male)
        Me.GroupBox1.Controls.Add(Me.rd_female)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(277, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 96)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'btn_savestaff
        '
        Me.btn_savestaff.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_savestaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_savestaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_savestaff.FlatAppearance.BorderSize = 6
        Me.btn_savestaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btn_savestaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_savestaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_savestaff.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_savestaff.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_savestaff.Location = New System.Drawing.Point(562, 255)
        Me.btn_savestaff.Name = "btn_savestaff"
        Me.btn_savestaff.Size = New System.Drawing.Size(166, 56)
        Me.btn_savestaff.TabIndex = 34
        Me.btn_savestaff.Text = "Submit"
        Me.btn_savestaff.UseVisualStyleBackColor = False
        '
        'btn_editstaff
        '
        Me.btn_editstaff.BackColor = System.Drawing.Color.Purple
        Me.btn_editstaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_editstaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_editstaff.FlatAppearance.BorderSize = 6
        Me.btn_editstaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia
        Me.btn_editstaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_editstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editstaff.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editstaff.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_editstaff.Location = New System.Drawing.Point(562, 193)
        Me.btn_editstaff.Name = "btn_editstaff"
        Me.btn_editstaff.Size = New System.Drawing.Size(166, 56)
        Me.btn_editstaff.TabIndex = 35
        Me.btn_editstaff.Text = "Edit Staff "
        Me.btn_editstaff.UseVisualStyleBackColor = False
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.Navy
        Me.btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_print.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_print.FlatAppearance.BorderSize = 6
        Me.btn_print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_print.Location = New System.Drawing.Point(562, 131)
        Me.btn_print.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(165, 56)
        Me.btn_print.TabIndex = 36
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'btn_end
        '
        Me.btn_end.BackColor = System.Drawing.Color.Maroon
        Me.btn_end.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_end.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btn_end.FlatAppearance.BorderSize = 6
        Me.btn_end.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_end.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_end.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_end.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_end.Location = New System.Drawing.Point(563, 317)
        Me.btn_end.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(165, 56)
        Me.btn_end.TabIndex = 37
        Me.btn_end.Text = "Exit"
        Me.btn_end.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(670, 46)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "STAFF DATABASE OPERATIONS"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fname, Me.lname, Me.role, Me.sex, Me.phone, Me.pword, Me.uniqueid})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 379)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 171)
        Me.DataGridView1.TabIndex = 38
        '
        'fname
        '
        Me.fname.HeaderText = "Name"
        Me.fname.Name = "fname"
        '
        'lname
        '
        Me.lname.HeaderText = "Sirname"
        Me.lname.Name = "lname"
        '
        'role
        '
        Me.role.HeaderText = "role"
        Me.role.Name = "role"
        '
        'sex
        '
        Me.sex.HeaderText = "Sex"
        Me.sex.Name = "sex"
        '
        'phone
        '
        Me.phone.HeaderText = "Contact"
        Me.phone.Name = "phone"
        '
        'pword
        '
        Me.pword.HeaderText = "Password"
        Me.pword.Name = "pword"
        '
        'uniqueid
        '
        Me.uniqueid.HeaderText = "uniqueid"
        Me.uniqueid.Name = "uniqueid"
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Red
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_clear.FlatAppearance.BorderSize = 6
        Me.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_clear.Location = New System.Drawing.Point(735, 63)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(32, 310)
        Me.btn_clear.TabIndex = 39
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_delete.FlatAppearance.BorderSize = 6
        Me.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_delete.Location = New System.Drawing.Point(562, 69)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(165, 56)
        Me.btn_delete.TabIndex = 40
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Violet
        Me.ClientSize = New System.Drawing.Size(771, 559)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_editstaff)
        Me.Controls.Add(Me.btn_savestaff)
        Me.Controls.Add(Me.txt_role)
        Me.Controls.Add(Me.txt_sirname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_pass1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_sirname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_role As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_contact As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_pass1 As TextBox
    Friend WithEvents rd_female As RadioButton
    Friend WithEvents rd_male As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_savestaff As Button
    Friend WithEvents btn_editstaff As Button
    Friend WithEvents btn_print As Button
    Friend WithEvents btn_end As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_clear As Button
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents lname As DataGridViewTextBoxColumn
    Friend WithEvents role As DataGridViewTextBoxColumn
    Friend WithEvents sex As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents pword As DataGridViewTextBoxColumn
    Friend WithEvents uniqueid As DataGridViewTextBoxColumn
    Friend WithEvents btn_delete As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class

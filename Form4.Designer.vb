<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.rich_history = New System.Windows.Forms.RichTextBox()
        Me.btn_savepatient = New System.Windows.Forms.Button()
        Me.txt_sirname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_contact = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_editpatient = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rd_male = New System.Windows.Forms.RadioButton()
        Me.rd_female = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.med_history = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uniquepatientid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rich_history
        '
        Me.rich_history.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rich_history.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!)
        Me.rich_history.Location = New System.Drawing.Point(228, 306)
        Me.rich_history.Name = "rich_history"
        Me.rich_history.Size = New System.Drawing.Size(312, 115)
        Me.rich_history.TabIndex = 23
        Me.rich_history.Text = ""
        '
        'btn_savepatient
        '
        Me.btn_savepatient.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_savepatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_savepatient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_savepatient.FlatAppearance.BorderSize = 6
        Me.btn_savepatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btn_savepatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_savepatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_savepatient.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_savepatient.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_savepatient.Location = New System.Drawing.Point(547, 303)
        Me.btn_savepatient.Name = "btn_savepatient"
        Me.btn_savepatient.Size = New System.Drawing.Size(151, 56)
        Me.btn_savepatient.TabIndex = 21
        Me.btn_savepatient.Text = "Submit"
        Me.btn_savepatient.UseVisualStyleBackColor = False
        '
        'txt_sirname
        '
        Me.txt_sirname.BackColor = System.Drawing.Color.White
        Me.txt_sirname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_sirname.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sirname.Location = New System.Drawing.Point(228, 119)
        Me.txt_sirname.Name = "txt_sirname"
        Me.txt_sirname.Size = New System.Drawing.Size(312, 33)
        Me.txt_sirname.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 33)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Sirname"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 33)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Medical History"
        '
        'txt_contact
        '
        Me.txt_contact.BackColor = System.Drawing.Color.White
        Me.txt_contact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact.Location = New System.Drawing.Point(228, 257)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(312, 33)
        Me.txt_contact.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 33)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Phone"
        '
        'txt_age
        '
        Me.txt_age.BackColor = System.Drawing.Color.White
        Me.txt_age.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_age.Location = New System.Drawing.Point(228, 165)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(312, 33)
        Me.txt_age.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 33)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Age"
        '
        'txt_fname
        '
        Me.txt_fname.BackColor = System.Drawing.Color.White
        Me.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(228, 73)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(312, 33)
        Me.txt_fname.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Firstname"
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
        Me.btn_print.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_print.Location = New System.Drawing.Point(547, 179)
        Me.btn_print.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(150, 56)
        Me.btn_print.TabIndex = 38
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'btn_editpatient
        '
        Me.btn_editpatient.BackColor = System.Drawing.Color.Olive
        Me.btn_editpatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_editpatient.FlatAppearance.BorderColor = System.Drawing.Color.Orange
        Me.btn_editpatient.FlatAppearance.BorderSize = 6
        Me.btn_editpatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btn_editpatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_editpatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editpatient.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editpatient.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_editpatient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_editpatient.Location = New System.Drawing.Point(547, 241)
        Me.btn_editpatient.Name = "btn_editpatient"
        Me.btn_editpatient.Size = New System.Drawing.Size(151, 56)
        Me.btn_editpatient.TabIndex = 37
        Me.btn_editpatient.Text = "Edit "
        Me.btn_editpatient.UseVisualStyleBackColor = False
        '
        'btn_end
        '
        Me.btn_end.BackColor = System.Drawing.Color.Maroon
        Me.btn_end.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_end.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_end.FlatAppearance.BorderSize = 6
        Me.btn_end.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_end.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_end.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_end.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_end.Location = New System.Drawing.Point(547, 365)
        Me.btn_end.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(150, 56)
        Me.btn_end.TabIndex = 39
        Me.btn_end.Text = "Exit"
        Me.btn_end.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 33)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Gender"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.rd_male)
        Me.GroupBox1.Controls.Add(Me.rd_female)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(228, 188)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 96)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'rd_male
        '
        Me.rd_male.AutoSize = True
        Me.rd_male.Location = New System.Drawing.Point(143, 24)
        Me.rd_male.Name = "rd_male"
        Me.rd_male.Size = New System.Drawing.Size(96, 37)
        Me.rd_male.TabIndex = 32
        Me.rd_male.TabStop = True
        Me.rd_male.Text = "Male"
        Me.rd_male.UseVisualStyleBackColor = True
        '
        'rd_female
        '
        Me.rd_female.AutoSize = True
        Me.rd_female.Location = New System.Drawing.Point(6, 24)
        Me.rd_female.Name = "rd_female"
        Me.rd_female.Size = New System.Drawing.Size(131, 37)
        Me.rd_female.TabIndex = 31
        Me.rd_female.TabStop = True
        Me.rd_female.Text = "Female"
        Me.rd_female.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkGoldenrod
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fname, Me.lname, Me.age, Me.sex, Me.phone, Me.med_history, Me.uniquepatientid})
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGoldenrod
        Me.DataGridView1.Location = New System.Drawing.Point(18, 427)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(670, 135)
        Me.DataGridView1.TabIndex = 42
        '
        'fname
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.fname.DefaultCellStyle = DataGridViewCellStyle1
        Me.fname.HeaderText = "Name"
        Me.fname.Name = "fname"
        '
        'lname
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.lname.DefaultCellStyle = DataGridViewCellStyle2
        Me.lname.HeaderText = "Sirname"
        Me.lname.Name = "lname"
        '
        'age
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.age.DefaultCellStyle = DataGridViewCellStyle3
        Me.age.HeaderText = "age"
        Me.age.Name = "age"
        Me.age.Width = 40
        '
        'sex
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.sex.DefaultCellStyle = DataGridViewCellStyle4
        Me.sex.HeaderText = "sex"
        Me.sex.Name = "sex"
        Me.sex.Width = 40
        '
        'phone
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.phone.DefaultCellStyle = DataGridViewCellStyle5
        Me.phone.HeaderText = "Contact"
        Me.phone.Name = "phone"
        '
        'med_history
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.med_history.DefaultCellStyle = DataGridViewCellStyle6
        Me.med_history.HeaderText = "Medical History"
        Me.med_history.Name = "med_history"
        Me.med_history.Width = 250
        '
        'uniquepatientid
        '
        Me.uniquepatientid.HeaderText = "UniqueID"
        Me.uniquepatientid.Name = "uniquepatientid"
        Me.uniquepatientid.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(197, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(355, 39)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "InPatient Processing"
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btn_delete.FlatAppearance.BorderSize = 6
        Me.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_delete.Location = New System.Drawing.Point(547, 117)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(150, 56)
        Me.btn_delete.TabIndex = 43
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Red
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btn_clear.FlatAppearance.BorderSize = 6
        Me.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_clear.Location = New System.Drawing.Point(547, 55)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(150, 56)
        Me.btn_clear.TabIndex = 44
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_clear.UseVisualStyleBackColor = False
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
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(711, 559)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_editpatient)
        Me.Controls.Add(Me.rich_history)
        Me.Controls.Add(Me.btn_savepatient)
        Me.Controls.Add(Me.txt_sirname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_age)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rich_history As RichTextBox
    Friend WithEvents btn_savepatient As Button
    Friend WithEvents txt_sirname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_contact As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_age As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_print As Button
    Friend WithEvents btn_editpatient As Button
    Friend WithEvents btn_end As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rd_male As RadioButton
    Friend WithEvents rd_female As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents lname As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents sex As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents med_history As DataGridViewTextBoxColumn
    Friend WithEvents uniquepatientid As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class

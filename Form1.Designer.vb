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
        Me.btn_end = New System.Windows.Forms.Button()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_seepassword = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.btn_end.Font = New System.Drawing.Font("Modern No. 20", 39.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_end.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_end.Location = New System.Drawing.Point(12, 198)
        Me.btn_end.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(173, 73)
        Me.btn_end.TabIndex = 8
        Me.btn_end.Text = "Exit"
        Me.btn_end.UseVisualStyleBackColor = False
        '
        'txt_pass
        '
        Me.txt_pass.BackColor = System.Drawing.Color.White
        Me.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(198, 124)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(292, 33)
        Me.txt_pass.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 125)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 40)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Password"
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.White
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(198, 78)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(358, 33)
        Me.txt_username.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 40)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Username"
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Navy
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_login.FlatAppearance.BorderSize = 6
        Me.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Modern No. 20", 39.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_login.Location = New System.Drawing.Point(320, 198)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(236, 73)
        Me.btn_login.TabIndex = 25
        Me.btn_login.Text = "Log In"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'btn_seepassword
        '
        Me.btn_seepassword.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_seepassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_seepassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_seepassword.FlatAppearance.BorderSize = 0
        Me.btn_seepassword.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_seepassword.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_seepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_seepassword.Font = New System.Drawing.Font("Modern No. 20", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_seepassword.ForeColor = System.Drawing.Color.White
        Me.btn_seepassword.Location = New System.Drawing.Point(482, 122)
        Me.btn_seepassword.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_seepassword.Name = "btn_seepassword"
        Me.btn_seepassword.Size = New System.Drawing.Size(58, 43)
        Me.btn_seepassword.TabIndex = 26
        Me.btn_seepassword.Text = "👁" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_seepassword.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_seepassword.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(416, 40)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Enter Login Details"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(569, 290)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.btn_seepassword)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InPatient Login System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_end As Button
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_seepassword As Button
    Friend WithEvents Label2 As Label
End Class

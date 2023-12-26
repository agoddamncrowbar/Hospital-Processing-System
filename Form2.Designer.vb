<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btn_patientform = New System.Windows.Forms.Button()
        Me.btn_addstaff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_end
        '
        Me.btn_end.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_end.AutoSize = True
        Me.btn_end.BackColor = System.Drawing.Color.Maroon
        Me.btn_end.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_end.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_end.FlatAppearance.BorderSize = 6
        Me.btn_end.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_end.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_end.Font = New System.Drawing.Font("Modern No. 20", 39.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_end.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_end.Location = New System.Drawing.Point(51, 197)
        Me.btn_end.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(465, 75)
        Me.btn_end.TabIndex = 26
        Me.btn_end.Text = "Exit"
        Me.btn_end.UseVisualStyleBackColor = False
        '
        'btn_patientform
        '
        Me.btn_patientform.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_patientform.AutoSize = True
        Me.btn_patientform.BackColor = System.Drawing.Color.Navy
        Me.btn_patientform.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_patientform.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_patientform.FlatAppearance.BorderSize = 6
        Me.btn_patientform.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btn_patientform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_patientform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_patientform.Font = New System.Drawing.Font("Modern No. 20", 39.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patientform.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_patientform.Location = New System.Drawing.Point(51, 106)
        Me.btn_patientform.Name = "btn_patientform"
        Me.btn_patientform.Size = New System.Drawing.Size(465, 75)
        Me.btn_patientform.TabIndex = 27
        Me.btn_patientform.Text = "Process Patient"
        Me.btn_patientform.UseVisualStyleBackColor = False
        '
        'btn_addstaff
        '
        Me.btn_addstaff.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_addstaff.AutoSize = True
        Me.btn_addstaff.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_addstaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addstaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_addstaff.FlatAppearance.BorderSize = 6
        Me.btn_addstaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btn_addstaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_addstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addstaff.Font = New System.Drawing.Font("Modern No. 20", 39.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addstaff.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_addstaff.Location = New System.Drawing.Point(51, 12)
        Me.btn_addstaff.Name = "btn_addstaff"
        Me.btn_addstaff.Size = New System.Drawing.Size(465, 75)
        Me.btn_addstaff.TabIndex = 28
        Me.btn_addstaff.Text = "Add Staff"
        Me.btn_addstaff.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(569, 290)
        Me.Controls.Add(Me.btn_addstaff)
        Me.Controls.Add(Me.btn_patientform)
        Me.Controls.Add(Me.btn_end)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lobby"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_end As Button
    Friend WithEvents btn_patientform As Button
    Friend WithEvents btn_addstaff As Button
End Class

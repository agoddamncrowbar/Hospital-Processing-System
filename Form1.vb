Imports System.Data.OleDb

Public Class Form1
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataSet
    Dim result As Integer
    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        End
    End Sub

    Private Sub btn_seepassword_Click(sender As Object, e As EventArgs) Handles btn_seepassword.Click
        If txt_pass.PasswordChar = "*" Then
            txt_pass.PasswordChar = ""
            btn_seepassword.BackColor = Color.Blue
        Else
            txt_pass.PasswordChar = "*"
            btn_seepassword.BackColor = SystemColors.ActiveCaption

        End If
    End Sub
    Private Function ValidateLogin() As Boolean
        ' Check if text fields are blank
        If txt_username.Text = "" Or txt_pass.Text = "" Then
            MessageBox.Show("Text fields cannot be blank", "Inpatient System", MessageBoxButtons.OK)
            Return False
        End If

        ' Check if the username and password match a record in the database
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SlickBack\Documents\inpatientappointment.accdb"
        conn.Open()
        cmd = New OleDbCommand("SELECT * FROM stafftable WHERE uniqueid = @username AND pword = @pass", conn)
        cmd.Parameters.AddWithValue("@username", txt_username.Text)
        cmd.Parameters.AddWithValue("@pass", txt_pass.Text)
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then ' Login successful
            conn.Close()
            Return True
        Else ' Login failed
            conn.Close()
            MessageBox.Show("Invalid username or password", "Inpatient System", MessageBoxButtons.OK)
            Return False
        End If
    End Function

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        If (ValidateLogin() = True) Then
            Me.Hide()
            Form2.ShowDialog()

        End If
    End Sub
End Class

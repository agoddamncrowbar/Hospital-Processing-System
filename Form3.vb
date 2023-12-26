Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class Form3
    Dim gender As String
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataSet
    Dim da As New OleDbDataAdapter(cmd)
    Dim uniquerecord As String
    Private bitmap As Bitmap

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SlickBack\Documents\inpatientappointment.accdb"
        conn.Open()
        viewer()
        conn.Close()

    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        Me.Close()
    End Sub

    Private Sub btn_savestaff_Click(sender As Object, e As EventArgs) Handles btn_savestaff.Click
        Dim uniquerecord As String
        uniquerecord = Microsoft.VisualBasic.Left(txt_fname.Text, 1) + txt_sirname.Text
        Dim gender As String
        If rd_female.Checked Then
            gender = "F"
        ElseIf rd_male.Checked Then
            gender = "M"
        End If
        If txt_pass.Text = txt_pass1.Text Then
            Try
                conn.Open()
                cmd = conn.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO stafftable (lname, fname, role, phone, sex, pword, uniqueid) VALUES ('" + txt_sirname.Text + "', '" + txt_fname.Text + "','" + txt_role.Text + "', '" + txt_contact.Text + "', '" + gender + "', '" + txt_pass.Text + "','" + uniquerecord + "')"
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Record Saved to InPatient database", "Inpatient System", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Inpatient System", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        Else
            MessageBox.Show("Passwords must match", "Inpatient System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        conn.Open()
        viewer()
        conn.Close()
    End Sub
    Private Sub viewer()
        Try
            Dim sql As String
            Dim dr As OleDbDataReader
            sql = " Select * from stafftable "
            cmd = New OleDbCommand(sql, conn)
            dr = cmd.ExecuteReader()
            DataGridView1.Rows.Clear()
            Do While dr.Read = True
                DataGridView1.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_fname.Clear()
        txt_contact.Clear()
        txt_pass.Clear()
        txt_pass1.Clear()
        txt_sirname.Clear()
        txt_role.Clear()
        rd_female.Checked = False
        rd_male.Checked = False
    End Sub

    Private Sub btn_editstaff_Click(sender As Object, e As EventArgs) Handles btn_editstaff.Click
        uniquerecord = Microsoft.VisualBasic.Left(txt_fname.Text, 1) + txt_sirname.Text
        Dim sex As String
        If rd_female.Checked Then
            sex = "F"
        ElseIf rd_male.Checked Then
            sex = "M"
        End If

        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE stafftable SET lname = '" + txt_sirname.Text + "', fname = '" + txt_fname.Text + "', sex = '" + sex + "', phone = '" + txt_contact.Text + "', role = '" + txt_role.Text + "', pword = '" + txt_pass.Text + "',  WHERE uniqueid ='" + uniquerecord + "'"
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Staff Record Updated", "Inpatient System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conn.Open()
        viewer()
        conn.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        uniquerecord = Microsoft.VisualBasic.Left(txt_fname.Text, 1) + txt_sirname.Text

        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE * FROM stafftable WHERE uniqueid ='" + uniquerecord + "'"
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Staff Record Deleted", "Inpatient System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conn.Open()
        viewer()
        conn.Close()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim gender As String
        Dim rowIndex As Integer = e.RowIndex

        If rowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)
            Try
                txt_fname.Text = row.Cells(0).Value.ToString
                txt_sirname.Text = row.Cells(1).Value.ToString
                txt_role.Text = row.Cells(2).Value.ToString
                gender = row.Cells(3).Value.ToString
                txt_contact.Text = row.Cells(4).Value.ToString
                txt_pass.Text = row.Cells(5).Value.ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If gender = "M" Then
            rd_male.Checked = True
        ElseIf gender = "F" Then
            rd_female.Checked = True
        End If
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Form6.ShowDialog()
        ''Try
        ''Dim height As Integer = DataGridView1.Height
        ''DataGridView1.RowCount = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        ''    bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        ''DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        ''PrintPreviewDialog1.Document = PrintDocument1
        ''PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        ''PrintPreviewDialog1.ShowDialog()
        ''DataGridView1.Height = height
        ''Catch ex As Exception
        ''MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ''End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            e.Graphics.DrawImage(Bitmap, 0, 0)
            Dim recP As RectangleF = e.PageSettings.PrintableArea
            If Me.DataGridView1.Height - recP.Height > 0 Then
                e.HasMorePages = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
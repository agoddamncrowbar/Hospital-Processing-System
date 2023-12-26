Public Class Form2
    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        End
    End Sub

    Private Sub btn_patientform_Click(sender As Object, e As EventArgs) Handles btn_patientform.Click
        Form4.ShowDialog()
    End Sub

    Private Sub btn_addstaff_Click(sender As Object, e As EventArgs) Handles btn_addstaff.Click
        Form3.ShowDialog()
    End Sub
End Class
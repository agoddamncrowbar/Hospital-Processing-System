Imports CrystalDecisions.CrystalReports.Engine

Public Class Form5
    Private Sub btn_rpt_Click(sender As Object, e As EventArgs) Handles btn_rpt.Click
        Dim crystal As New ReportDocument
        crystal.Load("C:\Users\SlickBack\Documents\CrystalReport1.rpt")
        CrystalReportViewer1.ReportSource = crystal
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        CrystalReportViewer1.Refresh()
    End Sub
End Class
Imports Satellite

Public Class Form1
    Private _sat As SatelliteConsole

    Sub New()
        InitializeComponent()

        _sat = New SatelliteConsole(True)
    End Sub

    Private Sub btnAttach_Click(sender As Object, e As EventArgs) Handles btnAttach.Click
        _sat.Attach()
    End Sub

    Private Sub btnDetatch_Click(sender As Object, e As EventArgs) Handles btnDetatch.Click
        _sat.Detatch()
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        _sat.Write(txtOutput.Text)
    End Sub

    Private Sub btnWriteLine_Click(sender As Object, e As EventArgs) Handles btnWriteLine.Click
        _sat.WriteLine(txtOutput.Text)
    End Sub

    Private Sub btnReadLine_Click(sender As Object, e As EventArgs) Handles btnReadLine.Click
        txtInput.Text = _sat.ReadLine()
    End Sub

    Private Sub btnTitle_Click(sender As Object, e As EventArgs) Handles btnTitle.Click
        _sat.Title = txtTitle.Text
    End Sub
End Class

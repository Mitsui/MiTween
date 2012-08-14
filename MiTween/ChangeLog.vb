Public Class ChangeLog

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ChangeLogText.Text = My.Resources.ChangeLog
    End Sub
End Class
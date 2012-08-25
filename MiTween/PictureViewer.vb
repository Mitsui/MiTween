Imports System.Text.RegularExpressions


Public Class PictureViewer

    Private Sub PictureViewer_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub 画像を保存ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 画像を保存ToolStripMenuItem.Click
        'MessageBox.Show(PictureBox1.Image.RawFormat.ToString)


        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then


            'Dim format As String
            'Regex.Match(SaveFileDialog1.FileName, "^http://.*(\.jpg|\.jpeg|\.gif|\.png|\.bmp)$", RegexOptions.IgnoreCase)
            'If  Then


            'End If






            PictureBox1.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)


        End If
    End Sub
End Class
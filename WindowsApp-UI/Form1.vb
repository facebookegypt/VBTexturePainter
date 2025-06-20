Imports ClassLibrary1
Public Class MainForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leftsidePanel.GetType().InvokeMember("DoubleBuffered",
    Reflection.BindingFlags.SetProperty Or
    Reflection.BindingFlags.Instance Or
    Reflection.BindingFlags.NonPublic,
    Nothing, leftsidePanel, New Object() {True})
        TexturePainter.ApplyDotTexture(leftsidePanel, Color.Green, 3)
        TexturePainter.ApplyDotTexture(MenuStrip1, Color.Red, 4)
        TexturePainter.ApplyDashGridTexture(Me, Color.Blue, 10)

    End Sub

    Private Sub FormToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class

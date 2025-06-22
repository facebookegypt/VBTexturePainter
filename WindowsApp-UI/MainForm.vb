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
        Label1.BackColor = Color.Blue
        Dim tp As New transparentControl.MyCustomControls.transparentCtrl(50, 40, 10, 40) With {
            .Bounds = New Rectangle(10, 10, 200, 100),
            .Dock = DockStyle.Right
        }
        Controls.Add(tp)
        Dim tp1 As New transparentControl.MyCustomControls.transparentCtrl1(70, 100, 16, 90) With {
            .Bounds = New Rectangle(210, 50, 200, 100),
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Times", 12, FontStyle.Bold),
            .ForeColor = Color.DarkGreen,
            .Text = "New Label Created"
        }
        Controls.Add(tp1)
    End Sub
End Class

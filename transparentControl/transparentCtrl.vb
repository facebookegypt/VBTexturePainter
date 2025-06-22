Imports System.Drawing
Imports System.Windows.Forms
Namespace MyCustomControls
    Public Class transparentCtrl
        Inherits Panel
        Public Sub New(xyz As Integer, x As Integer, y As Integer, z As Integer)
            Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            Me.BackColor = Color.FromArgb(xyz, x, y, z) ' Semi-transparent blue
        End Sub
    End Class
    Public Class transparentCtrl1
        Inherits Label
        Public Sub New(xyz As Integer, x As Integer, y As Integer, z As Integer)
            Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            Me.BackColor = Color.FromArgb(xyz, x, y, z) ' Semi-transparent blue
        End Sub
    End Class
End Namespace

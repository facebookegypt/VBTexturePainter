Imports System.Drawing
Imports System.Windows.Forms

Public Class TexturePainter

    ''' <summary>
    ''' Applies a dotted background texture to a control.
    ''' </summary>
    Public Shared Sub ApplyDotTexture(ctrl As Control, Optional dotColor As Color = Nothing, Optional spacing As Integer = 10)
        If dotColor = Nothing Then dotColor = Color.LightGray
        AddHandler ctrl.Paint, Sub(sender, e)
                                   ' Clear manually to prevent background flicker
                                   e.Graphics.Clear(ctrl.BackColor)
                                   ' Enable anti-flicker settings
                                   e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                                   For x As Integer = 0 To ctrl.Width Step spacing
                                       For y As Integer = 0 To ctrl.Height Step spacing
                                           e.Graphics.FillEllipse(New SolidBrush(dotColor), x, y, 2, 2)
                                       Next
                                   Next
                               End Sub
        ctrl.Invalidate() ' Force repaint
    End Sub
    ''' <summary>
    ''' Applies a dashed-line grid background to a control.
    ''' </summary>
    Public Shared Sub ApplyDashGridTexture(ctrl As Control, Optional lineColor As Color = Nothing, Optional spacing As Integer = 20)
        If lineColor = Nothing Then lineColor = Color.Silver
        AddHandler ctrl.Paint, Sub(sender, e)
                                   Dim g As Graphics = e.Graphics
                                   Using pen As New Pen(lineColor)
                                       pen.DashStyle = Drawing2D.DashStyle.Dash
                                       For x As Integer = 0 To ctrl.Width Step spacing
                                           g.DrawLine(pen, x, 0, x, ctrl.Height)
                                       Next
                                       For y As Integer = 0 To ctrl.Height Step spacing
                                           g.DrawLine(pen, 0, y, ctrl.Width, y)
                                       Next
                                   End Using
                               End Sub
        ctrl.Invalidate()
    End Sub
End Class
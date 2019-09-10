Public Class Graph

    Private ii = 0

    Public Sub Graph()
        InitializeComponent()

    End Sub

    Private Sub frmName_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Try
            If (ii = 10) Then
                Return
            End If

            Dim lineGraphcs As Graphics = e.Graphics
            Dim whitePen As New Pen(Color.White, 3)
            Dim bluePen As New Pen(Color.Blue, 2)
            Dim orangePen As New Pen(Color.Orange, 5)

            Dim br As New SolidBrush(Color.Pink)
            Dim rect As New Rectangle()

            rect.X = 0
            rect.Y = 100
            rect.Width = Me.Width
            rect.Height = Me.Height
            lineGraphcs.FillRectangle(br, rect)

            'horizontal graph lin
            For i = 0 To 700
                lineGraphcs.DrawLine(bluePen, i, 100, i, Me.Height)
                i = i + 20
            Next
            'vertical graph line
            For i = 100 To 500
                lineGraphcs.DrawLine(bluePen, 0, i, Me.Width, i)
                i = i + 20
            Next
            lineGraphcs.DrawLine(whitePen, 293, 100, 293, Me.Height)
            lineGraphcs.DrawLine(whitePen, 0, 288, Me.Width, 288)

            Dim curvePoints As New List(Of PointF)


            If TextBox1.Text.Contains("x2") Then
                Dim y As Double = 0
                For x As Integer = -53 To 53
                    y = -Math.Pow((0.25 + 0) * x, 2)
                    Dim np As New PointF(x + 293, y + 288)
                    curvePoints.Add(np)
                Next
                lineGraphcs.DrawCurve(orangePen, curvePoints.ToArray)


            ElseIf TextBox1.Text.Contains("x3") Then
                Dim y As Double = 0
                For x As Integer = -53 To 53
                    y = -Math.Pow((0.25 + 0) * x, 3)
                    Dim np As New PointF(x + 293, y + 288)
                    curvePoints.Add(np)
                Next
                lineGraphcs.DrawCurve(orangePen, curvePoints.ToArray)
            ElseIf TextBox1.Text.Contains("x4") Then
                Dim y As Double = 0
                For x As Integer = -53 To 53
                    y = -Math.Pow((0.25 + 0) * x, 4)
                    Dim np As New PointF(x + 293, y + 288)
                    curvePoints.Add(np)
                Next
                lineGraphcs.DrawCurve(orangePen, curvePoints.ToArray)
            ElseIf TextBox1.Text.Contains("x5") Then
                Dim y As Double = 0
                For x As Integer = -53 To 53
                    y = -Math.Pow((0.25 + 0) * x, 5)
                    Dim np As New PointF(x + 293, y + 288)
                    curvePoints.Add(np)
                Next
                lineGraphcs.DrawCurve(orangePen, curvePoints.ToArray)
            ElseIf TextBox1.Text.Contains("x6") Then
                Dim y As Double = 0
                For x As Integer = -53 To 53
                    y = -Math.Pow((0.25 + 0) * x, 6)
                    Dim np As New PointF(x + 293, y + 288)
                    curvePoints.Add(np)
                Next
                lineGraphcs.DrawCurve(orangePen, curvePoints.ToArray)

            End If

            lineGraphcs.Dispose()
            whitePen.Dispose()
            bluePen.Dispose()
            orangePen.Dispose()

        Catch ex As Exception


            MessageBox.Show(ex.StackTrace
                            )


        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Me.Click

        Me.Invalidate()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Invalidate()

    End Sub
End Class

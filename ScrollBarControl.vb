Public Class frmMain1
    Private Const MIN_TEXT_SIZE As Integer = 8
    Private Const MAX_TEXT_SIZE As Integer = 24

    Private Const COLOR_MIN As Integer = 0
    Private Const COLOR_MAX As Integer = 255

    Private Sub frmMain1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hScrBarTextSize.Minimum = 0
        hScrBarTextSize.Maximum = 100
        hScrBarTextSize.Value = 50

        vScrBarTextColor.Minimum = 0
        vScrBarTextColor.Maximum = 100
        vScrBarTextColor.Value = 0

        UpdateTextSize()
        UpdateTextColor()

        lblTextSize.Text = "텍스트 크기: " & btContent.Font.Size.ToString("0.0")
    End Sub

    Private Sub hScrBarTextSize_Scroll(sender As Object, e As ScrollEventArgs) Handles hScrBarTextSize.Scroll
        UpdateTextSize()
    End Sub

    Private Sub vScrBarTextColor_Scroll(sender As Object, e As ScrollEventArgs) Handles vScrBarTextColor.Scroll
        UpdateTextColor()
    End Sub

    Private Sub UpdateTextSize()
        ' 텍스트 크기 조정 위한 Linear Interpolation 방법 사용
        ' 스크롤바 값을 0~100에서 8~24(MIN_TEXT_SIZE ~ MAX_TEXT_SIZE) 범위로 비례적으로 변환
        ' Double 타입과 Single 타입을 사용하여 부동소수점 정밀도 유지
        Dim ratio As Double = hScrBarTextSize.Value / 100.0
        Dim newSize As Single = MIN_TEXT_SIZE + (MAX_TEXT_SIZE - MIN_TEXT_SIZE) * ratio

        btContent.Font = New Font(btContent.Font.FontFamily, newSize, btContent.Font.Style)

        lblTextSize.Text = "텍스트 크기: " & newSize.ToString("0.0")
    End Sub

    Private Sub UpdateTextColor()
        ' 스크롤바 값(0-100)을 0-1 사이의 비율로 변환
        Dim ratio As Double = vScrBarTextColor.Value / 100.0
        Dim r, g, b As Integer

        ' 비율에 따라 RGB 색상 계산
        ' 0.0-0.5 구간: 빨강(255,0,0)에서 초록(0,255,0)으로 그라데이션
        ' 0.5-1.0 구간: 초록(0,255,0)에서 파랑(0,0,255)으로 그라데이션
        If ratio <= 0.5 Then
            r = COLOR_MAX * (1 - ratio * 2)  ' 빨강에서 초록으로 감소
            g = COLOR_MAX * (ratio * 2)  ' 초록에서 빨강으로 증가
            b = 0
        Else
            r = 0
            g = COLOR_MAX * (1 - (ratio - 0.5) * 2)  ' 초록에서 파랑으로 감소
            b = COLOR_MAX * ((ratio - 0.5) * 2)  ' 파랑에서 초록으로 증가
        End If

        ' 계산된 RGB 값으로 버튼 텍스트 색상 설정
        btContent.ForeColor = Color.FromArgb(r, g, b)
        ' 현재 색상 정보를 레이블에 표시
        lblTextColor.Text = $"텍스트 색상: R:{r} G:{g} B:{b}"
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        btContent.ForeColor = Color.Red
        lblTextColor.Text = "텍스트 색상: 빨강"
    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        btContent.ForeColor = Color.Green
        lblTextColor.Text = "텍스트 색상: 초록"
    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        btContent.ForeColor = Color.Blue
        lblTextColor.Text = "텍스트 색상: 파랑"
    End Sub
End Class

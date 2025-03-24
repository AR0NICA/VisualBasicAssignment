Public Class frmRadioButtonMain
    Private Sub frmRadioButtonMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 라디오 버튼에 이벤트 핸들러 추가
        AddHandler btnLightCoral.CheckedChanged, AddressOf UpdateColorRecommendation
        AddHandler btnDarkOrange.CheckedChanged, AddressOf UpdateColorRecommendation
        AddHandler btnGold.CheckedChanged, AddressOf UpdateColorRecommendation
        AddHandler btnPaleGreen.CheckedChanged, AddressOf UpdateColorRecommendation
        AddHandler btnCornflowerBlue.CheckedChanged, AddressOf UpdateColorRecommendation
        AddHandler btnBlueViolet.CheckedChanged, AddressOf UpdateColorRecommendation

        AddHandler btnAge10th.CheckedChanged, AddressOf UpdateColorRecommendation
        AddHandler btnAge20th.CheckedChanged, AddressOf UpdateColorRecommendation
        AddHandler btnAge30th.CheckedChanged, AddressOf UpdateColorRecommendation
        AddHandler btnAge40th.CheckedChanged, AddressOf UpdateColorRecommendation
        AddHandler btnAge50th.CheckedChanged, AddressOf UpdateColorRecommendation
        AddHandler btnAge60thOver.CheckedChanged, AddressOf UpdateColorRecommendation

        ' 초기화
        btnLightCoral.Checked = False
        btnDarkOrange.Checked = False
        btnGold.Checked = False
        btnPaleGreen.Checked = False
        btnCornflowerBlue.Checked = False
        btnBlueViolet.Checked = False

        btnAge10th.Checked = False
        btnAge20th.Checked = False
        btnAge30th.Checked = False
        btnAge40th.Checked = False
        btnAge50th.Checked = False
        btnAge60thOver.Checked = False

        ColorShowBox.Text = ""
        ColorShowBox.BackColor = Color.White
    End Sub

    Private Sub UpdateColorRecommendation()
        Dim selectedColor As String = ""
        If btnLightCoral.Checked Then
            selectedColor = "LightCoral"
        ElseIf btnDarkOrange.Checked Then
            selectedColor = "DarkOrange"
        ElseIf btnGold.Checked Then
            selectedColor = "Gold"
        ElseIf btnPaleGreen.Checked Then
            selectedColor = "PaleGreen"
        ElseIf btnCornflowerBlue.Checked Then
            selectedColor = "CornflowerBlue"
        ElseIf btnBlueViolet.Checked Then
            selectedColor = "BlueViolet"
        End If

        Dim selectedAge As String = ""
        If btnAge10th.Checked Then
            selectedAge = "10th"
        ElseIf btnAge20th.Checked Then
            selectedAge = "20th"
        ElseIf btnAge30th.Checked Then
            selectedAge = "30th"
        ElseIf btnAge40th.Checked Then
            selectedAge = "40th"
        ElseIf btnAge50th.Checked Then
            selectedAge = "50th"
        ElseIf btnAge60thOver.Checked Then
            selectedAge = "60thOver"
        End If

        ' 색상과 나이대가 모두 선택된 경우에만 추천 색상 설정
        If Not String.IsNullOrEmpty(selectedColor) AndAlso Not String.IsNullOrEmpty(selectedAge) Then
            Select Case selectedAge
                Case "10th"
                    ' 10대: 밝고 활기찬 색상
                    Select Case selectedColor
                        Case "LightCoral"
                            SetColorRecommendation(Color.Red, "Red")
                        Case "DarkOrange"
                            SetColorRecommendation(Color.OrangeRed, "Orange Red")
                        Case "Gold"
                            SetColorRecommendation(Color.Yellow, "Yellow")
                        Case "PaleGreen"
                            SetColorRecommendation(Color.Lime, "Lime")
                        Case "CornflowerBlue"
                            SetColorRecommendation(Color.DodgerBlue, "Dodger Blue")
                        Case "BlueViolet"
                            SetColorRecommendation(Color.Fuchsia, "Fuchsia")
                    End Select
                Case "20th"
                    ' 20대: 트렌디하고 생동감 있는 색상
                    Select Case selectedColor
                        Case "LightCoral"
                            SetColorRecommendation(Color.Coral, "Coral")
                        Case "DarkOrange"
                            SetColorRecommendation(Color.Orange, "Orange")
                        Case "Gold"
                            SetColorRecommendation(Color.Goldenrod, "Goldenrod")
                        Case "PaleGreen"
                            SetColorRecommendation(Color.SpringGreen, "Spring Green")
                        Case "CornflowerBlue"
                            SetColorRecommendation(Color.SkyBlue, "Sky Blue")
                        Case "BlueViolet"
                            SetColorRecommendation(Color.Indigo, "Indigo")
                    End Select
                Case "30th"
                    ' 30대: 세련되고 안정적인 색상
                    Select Case selectedColor
                        Case "LightCoral"
                            SetColorRecommendation(Color.IndianRed, "Indian Red")
                        Case "DarkOrange"
                            SetColorRecommendation(Color.Peru, "Peru")
                        Case "Gold"
                            SetColorRecommendation(Color.DarkGoldenrod, "Dark Goldenrod")
                        Case "PaleGreen"
                            SetColorRecommendation(Color.MediumSeaGreen, "Medium Sea Green")
                        Case "CornflowerBlue"
                            SetColorRecommendation(Color.SteelBlue, "Steel Blue")
                        Case "BlueViolet"
                            SetColorRecommendation(Color.DarkSlateBlue, "Dark Slate Blue")
                    End Select
                Case "40th"
                    ' 40대: 고급스럽고 차분한 색상
                    Select Case selectedColor
                        Case "LightCoral"
                            SetColorRecommendation(Color.RosyBrown, "Rosy Brown")
                        Case "DarkOrange"
                            SetColorRecommendation(Color.Sienna, "Sienna")
                        Case "Gold"
                            SetColorRecommendation(Color.DarkKhaki, "DarkKhaki")
                        Case "PaleGreen"
                            SetColorRecommendation(Color.OliveDrab, "Olive Drab")
                        Case "CornflowerBlue"
                            SetColorRecommendation(Color.SlateGray, "Slate Gray")
                        Case "BlueViolet"
                            SetColorRecommendation(Color.DarkOrchid, "Dark Orchid")
                    End Select
                Case "50th"
                    ' 50대: 클래식하고 우아한 색상
                    Select Case selectedColor
                        Case "LightCoral"
                            SetColorRecommendation(Color.MistyRose, "Misty Rose")
                        Case "DarkOrange"
                            SetColorRecommendation(Color.BurlyWood, "Burly Wood")
                        Case "Gold"
                            SetColorRecommendation(Color.Tan, "Tan")
                        Case "PaleGreen"
                            SetColorRecommendation(Color.DarkSeaGreen, "Dark Sea Green")
                        Case "CornflowerBlue"
                            SetColorRecommendation(Color.LightSteelBlue, "Light Steel Blue")
                        Case "BlueViolet"
                            SetColorRecommendation(Color.MediumSlateBlue, "Medium Slate Blue")
                    End Select
                Case "60thOver"
                    ' 60대 이상: 부드럽고 편안한 색상
                    Select Case selectedColor
                        Case "LightCoral"
                            SetColorRecommendation(Color.PeachPuff, "Peach Puff")
                        Case "DarkOrange"
                            SetColorRecommendation(Color.Wheat, "Wheat")
                        Case "Gold"
                            SetColorRecommendation(Color.LemonChiffon, "Lemon Chiffon")
                        Case "PaleGreen"
                            SetColorRecommendation(Color.Honeydew, "Honeydew")
                        Case "CornflowerBlue"
                            SetColorRecommendation(Color.AliceBlue, "Alice Blue")
                        Case "BlueViolet"
                            SetColorRecommendation(Color.Lavender, "Lavender")
                    End Select
            End Select
        End If
    End Sub

    Private Function ColorToHex(color As Color) As String
        Return "#" & color.R.ToString("X2") & color.G.ToString("X2") & color.B.ToString("X2")
    End Function

    ' 추천 색상 설정 헬퍼 메서드  
    Private Sub SetColorRecommendation(color As Color, colorName As String)
        ColorShowBox.Text = colorName + " : " + ColorToHex(color)
        ColorShowBox.BackColor = color
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnLightCoral.Checked = False
        btnDarkOrange.Checked = False
        btnGold.Checked = False
        btnPaleGreen.Checked = False
        btnCornflowerBlue.Checked = False
        btnBlueViolet.Checked = False

        btnAge10th.Checked = False
        btnAge20th.Checked = False
        btnAge30th.Checked = False
        btnAge40th.Checked = False
        btnAge50th.Checked = False
        btnAge60thOver.Checked = False

        ColorShowBox.Text = ""
        ColorShowBox.BackColor = Color.White
    End Sub
End Class

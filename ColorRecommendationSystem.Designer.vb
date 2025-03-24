<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRadioButtonMain
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnLightCoral = New RadioButton()
        btnDarkOrange = New RadioButton()
        btnGold = New RadioButton()
        btnPaleGreen = New RadioButton()
        btnCornflowerBlue = New RadioButton()
        btnBlueViolet = New RadioButton()
        lblColor = New Label()
        ColorShowBox = New TextBox()
        btnClear = New Button()
        lblAge = New Label()
        btnAge10th = New RadioButton()
        btnAge20th = New RadioButton()
        btnAge30th = New RadioButton()
        btnAge40th = New RadioButton()
        btnAge50th = New RadioButton()
        btnAge60thOver = New RadioButton()
        lblMatchColor = New Label()
        grpbxColor = New GroupBox()
        grpbxAge = New GroupBox()
        grpbxColor.SuspendLayout()
        grpbxAge.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLightCoral
        ' 
        btnLightCoral.AutoSize = True
        btnLightCoral.BackColor = Color.LightCoral
        btnLightCoral.Font = New Font("에스코어 드림 5 Medium", 12F, FontStyle.Bold)
        btnLightCoral.Location = New Point(66, 66)
        btnLightCoral.Name = "btnLightCoral"
        btnLightCoral.Size = New Size(111, 26)
        btnLightCoral.TabIndex = 0
        btnLightCoral.Text = "LightCoral"
        btnLightCoral.UseVisualStyleBackColor = False
        ' 
        ' btnDarkOrange
        ' 
        btnDarkOrange.AutoSize = True
        btnDarkOrange.BackColor = Color.DarkOrange
        btnDarkOrange.Font = New Font("에스코어 드림 5 Medium", 12F, FontStyle.Bold)
        btnDarkOrange.Location = New Point(224, 66)
        btnDarkOrange.Name = "btnDarkOrange"
        btnDarkOrange.Size = New Size(125, 26)
        btnDarkOrange.TabIndex = 0
        btnDarkOrange.Text = "DarkOrange"
        btnDarkOrange.UseVisualStyleBackColor = False
        ' 
        ' btnGold
        ' 
        btnGold.AutoSize = True
        btnGold.BackColor = Color.Gold
        btnGold.Font = New Font("에스코어 드림 5 Medium", 12F, FontStyle.Bold)
        btnGold.Location = New Point(401, 66)
        btnGold.Name = "btnGold"
        btnGold.Size = New Size(64, 26)
        btnGold.TabIndex = 0
        btnGold.Text = "Gold"
        btnGold.UseVisualStyleBackColor = False
        ' 
        ' btnPaleGreen
        ' 
        btnPaleGreen.AutoSize = True
        btnPaleGreen.BackColor = Color.PaleGreen
        btnPaleGreen.Font = New Font("에스코어 드림 5 Medium", 12F, FontStyle.Bold)
        btnPaleGreen.Location = New Point(66, 116)
        btnPaleGreen.Name = "btnPaleGreen"
        btnPaleGreen.Size = New Size(112, 26)
        btnPaleGreen.TabIndex = 0
        btnPaleGreen.Text = "PaleGreen"
        btnPaleGreen.UseVisualStyleBackColor = False
        ' 
        ' btnCornflowerBlue
        ' 
        btnCornflowerBlue.AutoSize = True
        btnCornflowerBlue.BackColor = Color.CornflowerBlue
        btnCornflowerBlue.Font = New Font("에스코어 드림 5 Medium", 12F, FontStyle.Bold)
        btnCornflowerBlue.Location = New Point(224, 116)
        btnCornflowerBlue.Name = "btnCornflowerBlue"
        btnCornflowerBlue.Size = New Size(155, 26)
        btnCornflowerBlue.TabIndex = 0
        btnCornflowerBlue.Text = "CornflowerBlue"
        btnCornflowerBlue.UseVisualStyleBackColor = False
        ' 
        ' btnBlueViolet
        ' 
        btnBlueViolet.AutoSize = True
        btnBlueViolet.BackColor = Color.BlueViolet
        btnBlueViolet.Font = New Font("에스코어 드림 5 Medium", 12F, FontStyle.Bold)
        btnBlueViolet.Location = New Point(401, 116)
        btnBlueViolet.Name = "btnBlueViolet"
        btnBlueViolet.Size = New Size(109, 26)
        btnBlueViolet.TabIndex = 0
        btnBlueViolet.Text = "BlueViolet"
        btnBlueViolet.UseVisualStyleBackColor = False
        ' 
        ' lblColor
        ' 
        lblColor.AutoSize = True
        lblColor.Font = New Font("비트로 인스파이어 TTF", 24.7499962F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        lblColor.Location = New Point(233, 13)
        lblColor.Name = "lblColor"
        lblColor.Size = New Size(339, 44)
        lblColor.TabIndex = 1
        lblColor.Text = "Select UR Favorite Color"
        ' 
        ' ColorShowBox
        ' 
        ColorShowBox.Location = New Point(196, 443)
        ColorShowBox.Name = "ColorShowBox"
        ColorShowBox.ReadOnly = True
        ColorShowBox.Size = New Size(278, 24)
        ColorShowBox.TabIndex = 2
        ColorShowBox.TabStop = False
        ColorShowBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(529, 443)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 3
        btnClear.TabStop = False
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("비트로 인스파이어 TTF", 24.7499962F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        lblAge.Location = New Point(186, -3)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(205, 44)
        lblAge.TabIndex = 1
        lblAge.Text = "Select UR Age"
        ' 
        ' btnAge10th
        ' 
        btnAge10th.AutoSize = True
        btnAge10th.Font = New Font("에스코어 드림 5 Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnAge10th.Location = New Point(52, 65)
        btnAge10th.Name = "btnAge10th"
        btnAge10th.Size = New Size(64, 26)
        btnAge10th.TabIndex = 4
        btnAge10th.TabStop = True
        btnAge10th.Text = "10대"
        btnAge10th.UseVisualStyleBackColor = True
        ' 
        ' btnAge20th
        ' 
        btnAge20th.AutoSize = True
        btnAge20th.Font = New Font("에스코어 드림 5 Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnAge20th.Location = New Point(125, 65)
        btnAge20th.Name = "btnAge20th"
        btnAge20th.Size = New Size(64, 26)
        btnAge20th.TabIndex = 4
        btnAge20th.TabStop = True
        btnAge20th.Text = "20대"
        btnAge20th.UseVisualStyleBackColor = True
        ' 
        ' btnAge30th
        ' 
        btnAge30th.AutoSize = True
        btnAge30th.Font = New Font("에스코어 드림 5 Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnAge30th.Location = New Point(198, 65)
        btnAge30th.Name = "btnAge30th"
        btnAge30th.Size = New Size(64, 26)
        btnAge30th.TabIndex = 4
        btnAge30th.TabStop = True
        btnAge30th.Text = "30대"
        btnAge30th.UseVisualStyleBackColor = True
        ' 
        ' btnAge40th
        ' 
        btnAge40th.AutoSize = True
        btnAge40th.Font = New Font("에스코어 드림 5 Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnAge40th.Location = New Point(271, 65)
        btnAge40th.Name = "btnAge40th"
        btnAge40th.Size = New Size(64, 26)
        btnAge40th.TabIndex = 4
        btnAge40th.TabStop = True
        btnAge40th.Text = "40대"
        btnAge40th.UseVisualStyleBackColor = True
        ' 
        ' btnAge50th
        ' 
        btnAge50th.AutoSize = True
        btnAge50th.Font = New Font("에스코어 드림 5 Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnAge50th.Location = New Point(344, 65)
        btnAge50th.Name = "btnAge50th"
        btnAge50th.Size = New Size(64, 26)
        btnAge50th.TabIndex = 4
        btnAge50th.TabStop = True
        btnAge50th.Text = "50대"
        btnAge50th.UseVisualStyleBackColor = True
        ' 
        ' btnAge60thOver
        ' 
        btnAge60thOver.AutoSize = True
        btnAge60thOver.Font = New Font("에스코어 드림 5 Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        btnAge60thOver.Location = New Point(417, 65)
        btnAge60thOver.Name = "btnAge60thOver"
        btnAge60thOver.Size = New Size(101, 26)
        btnAge60thOver.TabIndex = 4
        btnAge60thOver.TabStop = True
        btnAge60thOver.Text = "60대 이상"
        btnAge60thOver.UseVisualStyleBackColor = True
        ' 
        ' lblMatchColor
        ' 
        lblMatchColor.AutoSize = True
        lblMatchColor.Font = New Font("비트로 인스파이어 TTF", 24.7499962F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        lblMatchColor.Location = New Point(248, 381)
        lblMatchColor.Name = "lblMatchColor"
        lblMatchColor.Size = New Size(310, 44)
        lblMatchColor.TabIndex = 1
        lblMatchColor.Text = "UR Personal Color is..."
        ' 
        ' grpbxColor
        ' 
        grpbxColor.Controls.Add(btnBlueViolet)
        grpbxColor.Controls.Add(btnLightCoral)
        grpbxColor.Controls.Add(btnDarkOrange)
        grpbxColor.Controls.Add(btnPaleGreen)
        grpbxColor.Controls.Add(btnGold)
        grpbxColor.Controls.Add(btnCornflowerBlue)
        grpbxColor.Location = New Point(112, 13)
        grpbxColor.Name = "grpbxColor"
        grpbxColor.Size = New Size(576, 194)
        grpbxColor.TabIndex = 5
        grpbxColor.TabStop = False
        grpbxColor.Text = "Color Group Box"
        ' 
        ' grpbxAge
        ' 
        grpbxAge.Controls.Add(btnAge60thOver)
        grpbxAge.Controls.Add(btnAge10th)
        grpbxAge.Controls.Add(btnAge50th)
        grpbxAge.Controls.Add(lblAge)
        grpbxAge.Controls.Add(btnAge20th)
        grpbxAge.Controls.Add(btnAge40th)
        grpbxAge.Controls.Add(btnAge30th)
        grpbxAge.Location = New Point(112, 213)
        grpbxAge.Name = "grpbxAge"
        grpbxAge.Size = New Size(576, 132)
        grpbxAge.TabIndex = 5
        grpbxAge.TabStop = False
        grpbxAge.Text = "Age Group Box"
        ' 
        ' frmRadioButtonMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 510)
        Controls.Add(btnClear)
        Controls.Add(ColorShowBox)
        Controls.Add(lblMatchColor)
        Controls.Add(lblColor)
        Controls.Add(grpbxAge)
        Controls.Add(grpbxColor)
        Font = New Font("에스코어 드림 5 Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(129))
        Name = "frmRadioButtonMain"
        Text = "Radio Button Main Form"
        TransparencyKey = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        grpbxColor.ResumeLayout(False)
        grpbxColor.PerformLayout()
        grpbxAge.ResumeLayout(False)
        grpbxAge.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLightCoral As RadioButton
    Friend WithEvents btnDarkOrange As RadioButton
    Friend WithEvents btnGold As RadioButton
    Friend WithEvents btnPaleGreen As RadioButton
    Friend WithEvents btnCornflowerBlue As RadioButton
    Friend WithEvents btnBlueViolet As RadioButton
    Friend WithEvents lblColor As Label
    Friend WithEvents ColorShowBox As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lblAge As Label
    Friend WithEvents btnAge10th As RadioButton
    Friend WithEvents btnAge20th As RadioButton
    Friend WithEvents btnAge30th As RadioButton
    Friend WithEvents btnAge40th As RadioButton
    Friend WithEvents btnAge50th As RadioButton
    Friend WithEvents btnAge60thOver As RadioButton
    Friend WithEvents lblMatchColor As Label
    Friend WithEvents grpbxColor As GroupBox
    Friend WithEvents grpbxAge As GroupBox
End Class

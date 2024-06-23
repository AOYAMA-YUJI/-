<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5_Shiseisyo
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnSave = New Button()
        BtnClose = New Button()
        BoxTeam = New TextBox()
        BoxID = New TextBox()
        BoxName = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        BoxPatten = New TextBox()
        BoxStartScheH = New ComboBox()
        BoxStartScheM = New ComboBox()
        BoxStartM = New ComboBox()
        BoxStartH = New ComboBox()
        BoxEndScheM = New ComboBox()
        BoxEndScheH = New ComboBox()
        BoxEndM = New ComboBox()
        BoxEndH = New ComboBox()
        BoxMonth = New ComboBox()
        BoxYear = New ComboBox()
        BoxDay = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        BoxRiyuu = New TextBox()
        Label20 = New Label()
        BtnState1 = New Button()
        BtnState2 = New Button()
        Label21 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        SuspendLayout()
        ' 
        ' BtnSave
        ' 
        BtnSave.Location = New Point(350, 12)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(91, 59)
        BtnSave.TabIndex = 10
        BtnSave.Text = "保存して" & vbCrLf & "閉じる"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' BtnClose
        ' 
        BtnClose.Location = New Point(448, 12)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(95, 59)
        BtnClose.TabIndex = 11
        BtnClose.Text = "保存せずに" & vbCrLf & "閉じる"
        BtnClose.UseVisualStyleBackColor = True
        ' 
        ' BoxTeam
        ' 
        BoxTeam.Enabled = False
        BoxTeam.Font = New Font("Yu Gothic UI", 14F)
        BoxTeam.Location = New Point(137, 88)
        BoxTeam.Name = "BoxTeam"
        BoxTeam.Size = New Size(402, 39)
        BoxTeam.TabIndex = 12
        ' 
        ' BoxID
        ' 
        BoxID.Enabled = False
        BoxID.Font = New Font("Yu Gothic UI", 14F)
        BoxID.Location = New Point(137, 147)
        BoxID.Name = "BoxID"
        BoxID.Size = New Size(124, 39)
        BoxID.TabIndex = 13
        ' 
        ' BoxName
        ' 
        BoxName.Enabled = False
        BoxName.Font = New Font("Yu Gothic UI", 14F)
        BoxName.Location = New Point(335, 151)
        BoxName.Name = "BoxName"
        BoxName.Size = New Size(204, 39)
        BoxName.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 14F)
        Label3.Location = New Point(21, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 32)
        Label3.TabIndex = 15
        Label3.Text = "部署"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 14F)
        Label1.Location = New Point(21, 154)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 32)
        Label1.TabIndex = 16
        Label1.Text = "社員番号"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 14F)
        Label2.Location = New Point(267, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 32)
        Label2.TabIndex = 17
        Label2.Text = "氏名"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI", 12F)
        Label4.Location = New Point(21, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 28)
        Label4.TabIndex = 19
        Label4.Text = "勤務パターン"
        ' 
        ' BoxPatten
        ' 
        BoxPatten.Enabled = False
        BoxPatten.Font = New Font("Yu Gothic UI", 14F)
        BoxPatten.Location = New Point(137, 206)
        BoxPatten.Name = "BoxPatten"
        BoxPatten.Size = New Size(402, 39)
        BoxPatten.TabIndex = 18
        ' 
        ' BoxStartScheH
        ' 
        BoxStartScheH.DropDownStyle = ComboBoxStyle.DropDownList
        BoxStartScheH.FormattingEnabled = True
        BoxStartScheH.Items.AddRange(New Object() {"", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        BoxStartScheH.Location = New Point(78, 363)
        BoxStartScheH.Name = "BoxStartScheH"
        BoxStartScheH.Size = New Size(44, 28)
        BoxStartScheH.TabIndex = 20
        ' 
        ' BoxStartScheM
        ' 
        BoxStartScheM.DropDownStyle = ComboBoxStyle.DropDownList
        BoxStartScheM.FormattingEnabled = True
        BoxStartScheM.Items.AddRange(New Object() {"", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        BoxStartScheM.Location = New Point(165, 363)
        BoxStartScheM.Name = "BoxStartScheM"
        BoxStartScheM.Size = New Size(44, 28)
        BoxStartScheM.TabIndex = 21
        ' 
        ' BoxStartM
        ' 
        BoxStartM.DropDownStyle = ComboBoxStyle.DropDownList
        BoxStartM.Enabled = False
        BoxStartM.FormattingEnabled = True
        BoxStartM.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        BoxStartM.Location = New Point(391, 363)
        BoxStartM.Name = "BoxStartM"
        BoxStartM.Size = New Size(44, 28)
        BoxStartM.TabIndex = 23
        ' 
        ' BoxStartH
        ' 
        BoxStartH.DropDownStyle = ComboBoxStyle.DropDownList
        BoxStartH.Enabled = False
        BoxStartH.FormattingEnabled = True
        BoxStartH.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        BoxStartH.Location = New Point(301, 363)
        BoxStartH.Name = "BoxStartH"
        BoxStartH.Size = New Size(44, 28)
        BoxStartH.TabIndex = 22
        ' 
        ' BoxEndScheM
        ' 
        BoxEndScheM.DropDownStyle = ComboBoxStyle.DropDownList
        BoxEndScheM.FormattingEnabled = True
        BoxEndScheM.Items.AddRange(New Object() {"", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        BoxEndScheM.Location = New Point(391, 452)
        BoxEndScheM.Name = "BoxEndScheM"
        BoxEndScheM.Size = New Size(44, 28)
        BoxEndScheM.TabIndex = 27
        ' 
        ' BoxEndScheH
        ' 
        BoxEndScheH.DropDownStyle = ComboBoxStyle.DropDownList
        BoxEndScheH.FormattingEnabled = True
        BoxEndScheH.Items.AddRange(New Object() {"", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        BoxEndScheH.Location = New Point(301, 452)
        BoxEndScheH.Name = "BoxEndScheH"
        BoxEndScheH.Size = New Size(44, 28)
        BoxEndScheH.TabIndex = 26
        ' 
        ' BoxEndM
        ' 
        BoxEndM.DropDownStyle = ComboBoxStyle.DropDownList
        BoxEndM.Enabled = False
        BoxEndM.FormattingEnabled = True
        BoxEndM.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        BoxEndM.Location = New Point(165, 452)
        BoxEndM.Name = "BoxEndM"
        BoxEndM.Size = New Size(44, 28)
        BoxEndM.TabIndex = 25
        ' 
        ' BoxEndH
        ' 
        BoxEndH.DropDownStyle = ComboBoxStyle.DropDownList
        BoxEndH.Enabled = False
        BoxEndH.FormattingEnabled = True
        BoxEndH.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        BoxEndH.Location = New Point(78, 452)
        BoxEndH.Name = "BoxEndH"
        BoxEndH.Size = New Size(44, 28)
        BoxEndH.TabIndex = 24
        ' 
        ' BoxMonth
        ' 
        BoxMonth.DropDownStyle = ComboBoxStyle.DropDownList
        BoxMonth.FormattingEnabled = True
        BoxMonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        BoxMonth.Location = New Point(263, 269)
        BoxMonth.Name = "BoxMonth"
        BoxMonth.Size = New Size(44, 28)
        BoxMonth.TabIndex = 29
        ' 
        ' BoxYear
        ' 
        BoxYear.DropDownStyle = ComboBoxStyle.DropDownList
        BoxYear.FormattingEnabled = True
        BoxYear.Location = New Point(137, 269)
        BoxYear.Name = "BoxYear"
        BoxYear.Size = New Size(78, 28)
        BoxYear.TabIndex = 28
        ' 
        ' BoxDay
        ' 
        BoxDay.DropDownStyle = ComboBoxStyle.DropDownList
        BoxDay.FormattingEnabled = True
        BoxDay.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        BoxDay.Location = New Point(351, 269)
        BoxDay.Name = "BoxDay"
        BoxDay.Size = New Size(44, 28)
        BoxDay.TabIndex = 30
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Yu Gothic UI", 12F)
        Label5.Location = New Point(21, 269)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 28)
        Label5.TabIndex = 31
        Label5.Text = "残業申請日"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Yu Gothic UI", 12F)
        Label6.Location = New Point(21, 319)
        Label6.Name = "Label6"
        Label6.Size = New Size(192, 28)
        Label6.TabIndex = 32
        Label6.Text = "前残業開始予定時間"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Yu Gothic UI", 12F)
        Label7.Location = New Point(260, 319)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 28)
        Label7.TabIndex = 33
        Label7.Text = "始業時間"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Yu Gothic UI", 12F)
        Label8.Location = New Point(260, 408)
        Label8.Name = "Label8"
        Label8.Size = New Size(192, 28)
        Label8.TabIndex = 35
        Label8.Text = "後残業終了予定時間"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Yu Gothic UI", 12F)
        Label9.Location = New Point(21, 408)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 28)
        Label9.TabIndex = 34
        Label9.Text = "終業時間"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Yu Gothic UI", 12F)
        Label10.Location = New Point(251, 363)
        Label10.Name = "Label10"
        Label10.Size = New Size(32, 28)
        Label10.TabIndex = 36
        Label10.Text = "～"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Yu Gothic UI", 12F)
        Label11.Location = New Point(251, 452)
        Label11.Name = "Label11"
        Label11.Size = New Size(32, 28)
        Label11.TabIndex = 37
        Label11.Text = "～"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Yu Gothic UI", 12F)
        Label12.Location = New Point(132, 363)
        Label12.Name = "Label12"
        Label12.Size = New Size(32, 28)
        Label12.TabIndex = 38
        Label12.Text = "時"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Yu Gothic UI", 12F)
        Label13.Location = New Point(213, 363)
        Label13.Name = "Label13"
        Label13.Size = New Size(32, 28)
        Label13.TabIndex = 39
        Label13.Text = "分"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Yu Gothic UI", 12F)
        Label14.Location = New Point(213, 452)
        Label14.Name = "Label14"
        Label14.Size = New Size(32, 28)
        Label14.TabIndex = 41
        Label14.Text = "分"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Yu Gothic UI", 12F)
        Label15.Location = New Point(132, 452)
        Label15.Name = "Label15"
        Label15.Size = New Size(32, 28)
        Label15.TabIndex = 40
        Label15.Text = "時"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Yu Gothic UI", 12F)
        Label16.Location = New Point(444, 363)
        Label16.Name = "Label16"
        Label16.Size = New Size(32, 28)
        Label16.TabIndex = 43
        Label16.Text = "分"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Yu Gothic UI", 12F)
        Label17.Location = New Point(353, 363)
        Label17.Name = "Label17"
        Label17.Size = New Size(32, 28)
        Label17.TabIndex = 42
        Label17.Text = "時"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Yu Gothic UI", 12F)
        Label18.Location = New Point(441, 452)
        Label18.Name = "Label18"
        Label18.Size = New Size(32, 28)
        Label18.TabIndex = 45
        Label18.Text = "分"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Yu Gothic UI", 12F)
        Label19.Location = New Point(350, 452)
        Label19.Name = "Label19"
        Label19.Size = New Size(32, 28)
        Label19.TabIndex = 44
        Label19.Text = "時"
        ' 
        ' BoxRiyuu
        ' 
        BoxRiyuu.Font = New Font("Yu Gothic UI", 14F)
        BoxRiyuu.Location = New Point(21, 525)
        BoxRiyuu.MaxLength = 50
        BoxRiyuu.Multiline = True
        BoxRiyuu.Name = "BoxRiyuu"
        BoxRiyuu.Size = New Size(518, 107)
        BoxRiyuu.TabIndex = 46
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Yu Gothic UI", 12F)
        Label20.Location = New Point(21, 494)
        Label20.Name = "Label20"
        Label20.Size = New Size(214, 28)
        Label20.TabIndex = 47
        Label20.Text = "残業理由（50字以内）"
        ' 
        ' BtnState1
        ' 
        BtnState1.Location = New Point(344, 638)
        BtnState1.Name = "BtnState1"
        BtnState1.Size = New Size(91, 38)
        BtnState1.TabIndex = 48
        BtnState1.Text = "ステート1"
        BtnState1.UseVisualStyleBackColor = True
        ' 
        ' BtnState2
        ' 
        BtnState2.Location = New Point(448, 638)
        BtnState2.Name = "BtnState2"
        BtnState2.Size = New Size(91, 38)
        BtnState2.TabIndex = 49
        BtnState2.Text = "ステート2"
        BtnState2.UseVisualStyleBackColor = True
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Yu Gothic UI", 12F)
        Label21.Location = New Point(221, 269)
        Label21.Name = "Label21"
        Label21.Size = New Size(32, 28)
        Label21.TabIndex = 50
        Label21.Text = "年"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Yu Gothic UI", 12F)
        Label22.Location = New Point(313, 269)
        Label22.Name = "Label22"
        Label22.Size = New Size(32, 28)
        Label22.TabIndex = 51
        Label22.Text = "月"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Yu Gothic UI", 12F)
        Label23.Location = New Point(401, 269)
        Label23.Name = "Label23"
        Label23.Size = New Size(32, 28)
        Label23.TabIndex = 52
        Label23.Text = "日"
        ' 
        ' Form5_Shiseisyo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 688)
        ControlBox = False
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(BtnState2)
        Controls.Add(BtnState1)
        Controls.Add(Label20)
        Controls.Add(BoxRiyuu)
        Controls.Add(Label18)
        Controls.Add(Label19)
        Controls.Add(Label16)
        Controls.Add(Label17)
        Controls.Add(Label14)
        Controls.Add(Label15)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(BoxDay)
        Controls.Add(BoxMonth)
        Controls.Add(BoxYear)
        Controls.Add(BoxEndScheM)
        Controls.Add(BoxEndScheH)
        Controls.Add(BoxEndM)
        Controls.Add(BoxEndH)
        Controls.Add(BoxStartM)
        Controls.Add(BoxStartH)
        Controls.Add(BoxStartScheM)
        Controls.Add(BoxStartScheH)
        Controls.Add(Label4)
        Controls.Add(BoxPatten)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(BoxName)
        Controls.Add(BoxID)
        Controls.Add(BoxTeam)
        Controls.Add(BtnClose)
        Controls.Add(BtnSave)
        Name = "Form5_Shiseisyo"
        Text = "残業申請フォーム"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BoxTeam As TextBox
    Friend WithEvents BoxID As TextBox
    Friend WithEvents BoxName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BoxPatten As TextBox
    Friend WithEvents BoxStartScheH As ComboBox
    Friend WithEvents BoxStartScheM As ComboBox
    Friend WithEvents BoxStartM As ComboBox
    Friend WithEvents BoxStartH As ComboBox
    Friend WithEvents BoxEndScheM As ComboBox
    Friend WithEvents BoxEndScheH As ComboBox
    Friend WithEvents BoxEndM As ComboBox
    Friend WithEvents BoxEndH As ComboBox
    Friend WithEvents BoxMonth As ComboBox
    Friend WithEvents BoxYear As ComboBox
    Friend WithEvents BoxDay As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BoxRiyuu As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnState1 As Button
    Friend WithEvents BtnState2 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
End Class

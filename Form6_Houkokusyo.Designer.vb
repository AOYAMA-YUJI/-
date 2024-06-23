<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6_Houkokusyo
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
        BtnClose = New Button()
        Label18 = New Label()
        Label19 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        BoxEndZanM = New ComboBox()
        BoxEndZanH = New ComboBox()
        BoxEndM = New ComboBox()
        BoxEndH = New ComboBox()
        BoxStartM = New ComboBox()
        BoxStartH = New ComboBox()
        BoxStartZanM = New ComboBox()
        BoxStartZanH = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        BoxRestM = New ComboBox()
        BoxRestH = New ComboBox()
        BoxZanH = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        BoxZanM = New TextBox()
        Label20 = New Label()
        BtnHokoku = New Button()
        Label21 = New Label()
        BoxHokoku = New TextBox()
        SuspendLayout()
        ' 
        ' BtnClose
        ' 
        BtnClose.Location = New Point(414, 12)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(128, 38)
        BtnClose.TabIndex = 12
        BtnClose.Text = "閉じる"
        BtnClose.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Yu Gothic UI", 12F)
        Label18.Location = New Point(464, 192)
        Label18.Name = "Label18"
        Label18.Size = New Size(32, 28)
        Label18.TabIndex = 67
        Label18.Text = "分"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Yu Gothic UI", 12F)
        Label19.Location = New Point(373, 192)
        Label19.Name = "Label19"
        Label19.Size = New Size(32, 28)
        Label19.TabIndex = 66
        Label19.Text = "時"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Yu Gothic UI", 12F)
        Label16.Location = New Point(467, 103)
        Label16.Name = "Label16"
        Label16.Size = New Size(32, 28)
        Label16.TabIndex = 65
        Label16.Text = "分"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Yu Gothic UI", 12F)
        Label17.Location = New Point(376, 103)
        Label17.Name = "Label17"
        Label17.Size = New Size(32, 28)
        Label17.TabIndex = 64
        Label17.Text = "時"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Yu Gothic UI", 12F)
        Label14.Location = New Point(236, 192)
        Label14.Name = "Label14"
        Label14.Size = New Size(32, 28)
        Label14.TabIndex = 63
        Label14.Text = "分"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Yu Gothic UI", 12F)
        Label15.Location = New Point(155, 192)
        Label15.Name = "Label15"
        Label15.Size = New Size(32, 28)
        Label15.TabIndex = 62
        Label15.Text = "時"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Yu Gothic UI", 12F)
        Label13.Location = New Point(236, 103)
        Label13.Name = "Label13"
        Label13.Size = New Size(32, 28)
        Label13.TabIndex = 61
        Label13.Text = "分"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Yu Gothic UI", 12F)
        Label12.Location = New Point(155, 103)
        Label12.Name = "Label12"
        Label12.Size = New Size(32, 28)
        Label12.TabIndex = 60
        Label12.Text = "時"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Yu Gothic UI", 12F)
        Label11.Location = New Point(274, 192)
        Label11.Name = "Label11"
        Label11.Size = New Size(32, 28)
        Label11.TabIndex = 59
        Label11.Text = "～"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Yu Gothic UI", 12F)
        Label10.Location = New Point(274, 103)
        Label10.Name = "Label10"
        Label10.Size = New Size(32, 28)
        Label10.TabIndex = 58
        Label10.Text = "～"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Yu Gothic UI", 12F)
        Label8.Location = New Point(283, 148)
        Label8.Name = "Label8"
        Label8.Size = New Size(152, 28)
        Label8.TabIndex = 57
        Label8.Text = "後残業終了時間"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Yu Gothic UI", 12F)
        Label9.Location = New Point(44, 148)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 28)
        Label9.TabIndex = 56
        Label9.Text = "終業時間"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Yu Gothic UI", 12F)
        Label7.Location = New Point(283, 59)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 28)
        Label7.TabIndex = 55
        Label7.Text = "始業時間"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Yu Gothic UI", 12F)
        Label6.Location = New Point(44, 59)
        Label6.Name = "Label6"
        Label6.Size = New Size(152, 28)
        Label6.TabIndex = 54
        Label6.Text = "前残業開始時間"
        ' 
        ' BoxEndZanM
        ' 
        BoxEndZanM.DropDownStyle = ComboBoxStyle.DropDownList
        BoxEndZanM.FormattingEnabled = True
        BoxEndZanM.Items.AddRange(New Object() {"", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        BoxEndZanM.Location = New Point(414, 192)
        BoxEndZanM.Name = "BoxEndZanM"
        BoxEndZanM.Size = New Size(44, 28)
        BoxEndZanM.TabIndex = 53
        ' 
        ' BoxEndZanH
        ' 
        BoxEndZanH.DropDownStyle = ComboBoxStyle.DropDownList
        BoxEndZanH.FormattingEnabled = True
        BoxEndZanH.Items.AddRange(New Object() {"", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        BoxEndZanH.Location = New Point(324, 192)
        BoxEndZanH.Name = "BoxEndZanH"
        BoxEndZanH.Size = New Size(44, 28)
        BoxEndZanH.TabIndex = 52
        ' 
        ' BoxEndM
        ' 
        BoxEndM.DropDownStyle = ComboBoxStyle.DropDownList
        BoxEndM.Enabled = False
        BoxEndM.FormattingEnabled = True
        BoxEndM.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        BoxEndM.Location = New Point(188, 192)
        BoxEndM.Name = "BoxEndM"
        BoxEndM.Size = New Size(44, 28)
        BoxEndM.TabIndex = 51
        ' 
        ' BoxEndH
        ' 
        BoxEndH.DropDownStyle = ComboBoxStyle.DropDownList
        BoxEndH.Enabled = False
        BoxEndH.FormattingEnabled = True
        BoxEndH.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        BoxEndH.Location = New Point(101, 192)
        BoxEndH.Name = "BoxEndH"
        BoxEndH.Size = New Size(44, 28)
        BoxEndH.TabIndex = 50
        ' 
        ' BoxStartM
        ' 
        BoxStartM.DropDownStyle = ComboBoxStyle.DropDownList
        BoxStartM.Enabled = False
        BoxStartM.FormattingEnabled = True
        BoxStartM.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        BoxStartM.Location = New Point(414, 103)
        BoxStartM.Name = "BoxStartM"
        BoxStartM.Size = New Size(44, 28)
        BoxStartM.TabIndex = 49
        ' 
        ' BoxStartH
        ' 
        BoxStartH.DropDownStyle = ComboBoxStyle.DropDownList
        BoxStartH.Enabled = False
        BoxStartH.FormattingEnabled = True
        BoxStartH.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        BoxStartH.Location = New Point(324, 103)
        BoxStartH.Name = "BoxStartH"
        BoxStartH.Size = New Size(44, 28)
        BoxStartH.TabIndex = 48
        ' 
        ' BoxStartZanM
        ' 
        BoxStartZanM.DropDownStyle = ComboBoxStyle.DropDownList
        BoxStartZanM.FormattingEnabled = True
        BoxStartZanM.Items.AddRange(New Object() {"", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        BoxStartZanM.Location = New Point(188, 103)
        BoxStartZanM.Name = "BoxStartZanM"
        BoxStartZanM.Size = New Size(44, 28)
        BoxStartZanM.TabIndex = 47
        ' 
        ' BoxStartZanH
        ' 
        BoxStartZanH.DropDownStyle = ComboBoxStyle.DropDownList
        BoxStartZanH.FormattingEnabled = True
        BoxStartZanH.Items.AddRange(New Object() {"", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        BoxStartZanH.Location = New Point(101, 103)
        BoxStartZanH.Name = "BoxStartZanH"
        BoxStartZanH.Size = New Size(44, 28)
        BoxStartZanH.TabIndex = 46
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 12F)
        Label1.Location = New Point(359, 245)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 28)
        Label1.TabIndex = 72
        Label1.Text = "分"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 12F)
        Label2.Location = New Point(249, 245)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 28)
        Label2.TabIndex = 71
        Label2.Text = "時間"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 12F)
        Label3.Location = New Point(95, 245)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 28)
        Label3.TabIndex = 70
        Label3.Text = "休憩時間"
        ' 
        ' BoxRestM
        ' 
        BoxRestM.DropDownStyle = ComboBoxStyle.DropDownList
        BoxRestM.FormattingEnabled = True
        BoxRestM.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        BoxRestM.Location = New Point(311, 245)
        BoxRestM.Name = "BoxRestM"
        BoxRestM.Size = New Size(44, 28)
        BoxRestM.TabIndex = 69
        ' 
        ' BoxRestH
        ' 
        BoxRestH.DropDownStyle = ComboBoxStyle.DropDownList
        BoxRestH.FormattingEnabled = True
        BoxRestH.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        BoxRestH.Location = New Point(195, 245)
        BoxRestH.Name = "BoxRestH"
        BoxRestH.Size = New Size(44, 28)
        BoxRestH.TabIndex = 68
        ' 
        ' BoxZanH
        ' 
        BoxZanH.Enabled = False
        BoxZanH.Location = New Point(177, 304)
        BoxZanH.Name = "BoxZanH"
        BoxZanH.Size = New Size(62, 27)
        BoxZanH.TabIndex = 73
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI", 12F)
        Label4.Location = New Point(376, 304)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 28)
        Label4.TabIndex = 75
        Label4.Text = "分"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Yu Gothic UI", 12F)
        Label5.Location = New Point(245, 304)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 28)
        Label5.TabIndex = 74
        Label5.Text = "時間"
        ' 
        ' BoxZanM
        ' 
        BoxZanM.Enabled = False
        BoxZanM.Location = New Point(306, 304)
        BoxZanM.Name = "BoxZanM"
        BoxZanM.Size = New Size(62, 27)
        BoxZanM.TabIndex = 76
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Yu Gothic UI", 12F)
        Label20.Location = New Point(67, 304)
        Label20.Name = "Label20"
        Label20.Size = New Size(112, 28)
        Label20.TabIndex = 77
        Label20.Text = "実残業時間"
        ' 
        ' BtnHokoku
        ' 
        BtnHokoku.Location = New Point(457, 484)
        BtnHokoku.Name = "BtnHokoku"
        BtnHokoku.Size = New Size(91, 38)
        BtnHokoku.TabIndex = 80
        BtnHokoku.Text = "報告"
        BtnHokoku.UseVisualStyleBackColor = True
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Yu Gothic UI", 12F)
        Label21.Location = New Point(30, 340)
        Label21.Name = "Label21"
        Label21.Size = New Size(214, 28)
        Label21.TabIndex = 79
        Label21.Text = "残業報告（50字以内）"
        ' 
        ' BoxHokoku
        ' 
        BoxHokoku.Font = New Font("Yu Gothic UI", 14F)
        BoxHokoku.Location = New Point(30, 371)
        BoxHokoku.MaxLength = 50
        BoxHokoku.Multiline = True
        BoxHokoku.Name = "BoxHokoku"
        BoxHokoku.Size = New Size(518, 107)
        BoxHokoku.TabIndex = 78
        ' 
        ' Form6_Houkokusyo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 533)
        ControlBox = False
        Controls.Add(BtnHokoku)
        Controls.Add(Label21)
        Controls.Add(BoxHokoku)
        Controls.Add(Label20)
        Controls.Add(BoxZanM)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(BoxZanH)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(BoxRestM)
        Controls.Add(BoxRestH)
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
        Controls.Add(BoxEndZanM)
        Controls.Add(BoxEndZanH)
        Controls.Add(BoxEndM)
        Controls.Add(BoxEndH)
        Controls.Add(BoxStartM)
        Controls.Add(BoxStartH)
        Controls.Add(BoxStartZanM)
        Controls.Add(BoxStartZanH)
        Controls.Add(BtnClose)
        Name = "Form6_Houkokusyo"
        Text = "残業報告フォーム"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BoxEndZanM As ComboBox
    Friend WithEvents BoxEndZanH As ComboBox
    Friend WithEvents BoxEndM As ComboBox
    Friend WithEvents BoxEndH As ComboBox
    Friend WithEvents BoxStartM As ComboBox
    Friend WithEvents BoxStartH As ComboBox
    Friend WithEvents BoxStartZanM As ComboBox
    Friend WithEvents BoxStartZanH As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BoxRestM As ComboBox
    Friend WithEvents BoxRestH As ComboBox
    Friend WithEvents BoxZanH As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BoxZanM As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnHokoku As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents BoxHokoku As TextBox
End Class

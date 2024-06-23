Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form6_Houkokusyo
    Private Sub Form6_Houkokusyo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BoxZanH.Enabled = False
        BoxZanM.Enabled = False
    End Sub

    Private Sub Form6_Houkokusyo_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim iMinS As Integer = 0
        Dim iMinE As Integer = 0
        '残業開始/終了時間を予定時間から自動入力（申請書で申請していない箇所は入力不可）
        If (Form1_Login.clsDocument.strStartSchedule(0) <> "") Then
            BoxStartZanH.SelectedIndex = Form1_Login.clsDocument.strStartSchedule(0) + 1
            BoxStartZanM.SelectedIndex = Form1_Login.clsDocument.strStartSchedule(1) + 1
        Else
            BoxStartZanH.Enabled = False
            BoxStartZanM.Enabled = False
        End If
        If (Form1_Login.clsDocument.strEndSchedule(0) <> "") Then
            BoxEndZanH.SelectedIndex = Form1_Login.clsDocument.strEndSchedule(0) + 1
            BoxEndZanM.SelectedIndex = Form1_Login.clsDocument.strEndSchedule(1) + 1
        Else
            BoxEndZanH.Enabled = False
            BoxEndZanM.Enabled = False
        End If

        '始業時間、終業時間を自動入力
        BoxStartH.SelectedIndex = Form1_Login.clsDocument.strStart(0) + 1
        BoxStartM.SelectedIndex = Form1_Login.clsDocument.strStart(1) + 1
        BoxEndH.SelectedIndex = Form1_Login.clsDocument.strEnd(0) + 1
        BoxEndM.SelectedIndex = Form1_Login.clsDocument.strEnd(1) + 1

        BoxStartH.Enabled = False
        BoxStartM.Enabled = False
        BoxEndH.Enabled = False
        BoxEndM.Enabled = False

        '残業時間を計算
        If (Form1_Login.clsDocument.strStartSchedule(0) <> "") Then
            iMinS = (BoxStartH.SelectedIndex * 60 + BoxStartM.SelectedIndex) _
                - (BoxStartZanH.SelectedIndex * 60 + BoxStartZanM.SelectedIndex)
        End If
        If (Form1_Login.clsDocument.strEndSchedule(0) <> "") Then
            iMinE = (BoxEndZanH.SelectedIndex * 60 + BoxEndZanM.SelectedIndex) _
                - (BoxEndH.SelectedIndex * 60 + BoxEndM.SelectedIndex)
        End If

        '休憩時間を計算
        If ((iMinS + iMinE) >= 480) Then
            '8時間以上なら1時間を設定する
            BoxRestH.SelectedIndex = 1
            BoxRestM.SelectedIndex = 0
        Else
            '8時間以内なら0時間を設定する
            BoxRestH.SelectedIndex = 0
            BoxRestM.SelectedIndex = 0
        End If

        '実残業時間を計算
        BoxZanH.Text = ((iMinS + iMinE) / 60) - BoxRestH.SelectedIndex
        BoxZanM.Text = ((iMinS + iMinE) Mod 60) - BoxRestM.SelectedIndex
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        '閉じる（残業報告は途中保存しない）
        Me.Dispose()
    End Sub

    Private Sub BtnHokoku_Click(sender As Object, e As EventArgs) Handles BtnHokoku.Click
        '報告ボタン
        If (BoxStartZanH.Text <> "" And BoxStartZanM.Text <> "") Then
            '残業開始予定時間が空白セルでないなら始業時間と比較
            If (CDate(BoxStartZanH.Text & ":" & BoxStartZanM.Text) > CDate(BoxStartH.Text & ":" & BoxStartM.Text)) Then
                Exit Sub
            Else
                Form5_Shiseisyo.stHokoku.strStartZan = BoxStartZanH.Text & ":" & BoxStartZanM.Text
            End If
        End If
        If (BoxEndZanH.Text <> "" And BoxEndZanM.Text <> "") Then
            '残業終了予定時間が空白セルでないなら終業時間と比較
            If (CDate(BoxEndZanH.Text & ":" & BoxEndZanM.Text) < CDate(BoxEndH.Text & ":" & BoxEndM.Text)) Then
                Exit Sub
            Else
                Form5_Shiseisyo.stHokoku.strEndZan = BoxEndZanH.Text & ":" & BoxEndZanM.Text
            End If
        End If
        If (BoxStartZanH.Text = "" And BoxEndZanH.Text = "" And BoxStartZanM.Text = "" And BoxEndZanM.Text = "") Then
            '残業開始時間、残業終了時間が空白セルなら報告不可能
            Exit Sub
        End If

        Form5_Shiseisyo.stHokoku.iRest = CInt(BoxRestH.Text) * 60 + CInt(BoxRestH.Text)
        Form5_Shiseisyo.stHokoku.iZan = CInt(BoxZanH.Text) * 60 + CInt(BoxZanH.Text)
        Form5_Shiseisyo.stHokoku.strHokoku = BoxHokoku.Text

        If (Form5_Shiseisyo.strState = "新規作成" Or Form5_Shiseisyo.strState.Contains("差し戻し")) Then
            '申請と報告を同時に行う場合
            Form5_Shiseisyo.strState = "申請（事後）"
            Form1_Login.clsDocument.SaveDoc(Form5_Shiseisyo)
            Form1_Login.clsDocument.NextState(Form5_Shiseisyo, Form5_Shiseisyo.strBossID)
        ElseIf (Form5_Shiseisyo.strState.Contains("承認") And (Not (Form5_Shiseisyo.strState.Contains("依頼")))) Then
            '承認済なら完了、次長課長のステート更新
            Form5_Shiseisyo.strState = "完了"
            Form1_Login.clsDocument.SaveDoc(Form5_Shiseisyo)
            'Form1_Login.clsDocument.ChangeState(Form5_Shiseisyo, Form5_Shiseisyo.strBossID)
            'Form1_Login.clsDocument.ChangeState(Form5_Shiseisyo, Form5_Shiseisyo.strBossID2)
            Form1_Login.clsDocument.HokokuState(Me, Form5_Shiseisyo.strBossID, Form5_Shiseisyo.strState, Form5_Shiseisyo.BoxYear.Text, Form5_Shiseisyo.BoxMonth.Text, Form5_Shiseisyo.BoxDay.Text)
            Form1_Login.clsDocument.HokokuState(Me, Form5_Shiseisyo.strBossID2, Form5_Shiseisyo.strState, Form5_Shiseisyo.BoxYear.Text, Form5_Shiseisyo.BoxMonth.Text, Form5_Shiseisyo.BoxDay.Text)
            Form1_Login.clsLocaclTest.GetIchiran(Form2_Shinsei.DataGridShinsei, Form2_Shinsei.DataGridGetsuji, Form2_Shinsei.iIndex)
        Else
            'それ以外は未承認を付ける、次長のステート更新
            Form5_Shiseisyo.strState = Form5_Shiseisyo.strState & "（未承認）"
            Form1_Login.clsDocument.ChangeState(Form5_Shiseisyo, Form5_Shiseisyo.strBossID)
            If (Form5_Shiseisyo.strState.Contains("承認依頼")) Then
                '承認依頼なら課長のステートも更新
                Form1_Login.clsDocument.ChangeState(Form5_Shiseisyo, Form5_Shiseisyo.strBossID2)
            End If
        End If
        Me.Dispose()
    End Sub
End Class
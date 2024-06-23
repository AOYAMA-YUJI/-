Imports System.Configuration
Imports System.DirectoryServices.ActiveDirectory
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form5_Shiseisyo
    Structure Hokoku
        Dim strStartZan As String
        Dim strEndZan As String
        Dim iRest As Integer
        Dim iZan As Integer
        Dim strHokoku As String
    End Structure

    Friend iFlg As Integer
    Friend strState As String
    Friend strBossID As String
    Friend strBossID2 As String
    Friend stHokoku As Hokoku

    Private Sub Form5_Shiseisyo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iFlg = Form1_Login.clsDocument.iFlg
        strState = Form1_Login.clsDocument.strState

        If (strState <> "完了") Then
            Select Case Form1_Login.clsDocument.strRoll
                Case "一般"
                    If (strState = "新規作成" Or strState.Contains("差し戻し")) Then
                        BtnState1.Text = "申請"
                    Else
                        BtnState1.Text = "報告"
                    End If

                    If (iFlg = 1) Then
                        '新規作成の場合、取り下げボタンを使用不可能にする
                        BtnState2.Enabled = False
                    End If

                    BtnState2.Text = "取り下げ"
                Case "次長"
                    BtnState1.Text = "差し戻し"
                    BtnState2.Text = "承認依頼"
                    BtnClose.Text = "閉じる"
                    BtnSave.Visible = False

                    If Not (strState.Contains("申請")) Then
                        BtnState1.Enabled = False
                        BtnState2.Enabled = False
                    End If

                Case "課長", "部長"
                    BtnState1.Visible = False
                    BtnState2.Text = "承認"
                    BtnClose.Text = "閉じる"
                    BtnSave.Visible = False

                    If Not (strState.Contains("承認依頼")) Then
                        BtnState1.Enabled = False
                        BtnState2.Enabled = False
                    End If

                Case Else
            End Select
        Else
            BtnState1.Enabled = False
            BtnState2.Enabled = False
            BtnSave.Visible = False
            BtnClose.Text = "閉じる"
        End If
    End Sub

    Private Sub Form5_Shiseisyo_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        '自動入力（編集不可能にする）
        BoxID.Text = Form1_Login.clsDocument.strID
        BoxName.Text = Form1_Login.clsDocument.strName
        BoxTeam.Text = Form1_Login.clsDocument.strTeam
        BoxPatten.Text = Form1_Login.clsDocument.strPattern
        BoxStartH.SelectedIndex = Form1_Login.clsDocument.strStart(0)
        BoxStartM.SelectedIndex = Form1_Login.clsDocument.strStart(1)
        BoxEndH.SelectedIndex = Form1_Login.clsDocument.strEnd(0)
        BoxEndM.SelectedIndex = Form1_Login.clsDocument.strEnd(1)

        BoxID.Enabled = False
        BoxName.Enabled = False
        BoxTeam.Enabled = False
        BoxPatten.Enabled = False
        BoxStartH.Enabled = False
        BoxStartM.Enabled = False
        BoxEndH.Enabled = False
        BoxEndM.Enabled = False

        '残業申請日のデフォルトは申請フォームを立ち上げた日にする
        BoxYear.Items.AddRange(New Object() {DateTime.Today.Year(), (DateTime.Today.Year()) - 1})
        If (Strings.Left(Form1_Login.clsDocument.strDate, 4) = DateTime.Today.Year().ToString()) Then
            BoxYear.SelectedIndex = 0
        Else
            BoxYear.SelectedIndex = 1
        End If
        BoxMonth.SelectedIndex = CInt(Strings.Mid(Form1_Login.clsDocument.strDate, 5, 2)) - 1
        BoxDay.SelectedIndex = CInt(Strings.Right(Form1_Login.clsDocument.strDate, 2)) - 1

        '残業予定時間（編集中のフォームを立ち上げた場合）
        If (Form1_Login.clsDocument.strStartSchedule(0) <> "") Then
            BoxStartScheH.SelectedIndex = Form1_Login.clsDocument.strStartSchedule(0) + 1
            BoxStartScheM.SelectedIndex = Form1_Login.clsDocument.strStartSchedule(1) + 1
        End If
        If (Form1_Login.clsDocument.strEndSchedule(0) <> "") Then
            BoxEndScheH.SelectedIndex = Form1_Login.clsDocument.strEndSchedule(0) + 1
            BoxEndScheM.SelectedIndex = Form1_Login.clsDocument.strEndSchedule(1) + 1
        End If

        '残業理由
        BoxRiyuu.Text = Form1_Login.clsDocument.strRiyuu

        '新規作成、差し戻し以外は編集不可能
        If Not (Form1_Login.clsDocument.strState = "新規作成" Or Form1_Login.clsDocument.strState.Contains("差し戻し")) Then
            BoxYear.Enabled = False
            BoxMonth.Enabled = False
            BoxDay.Enabled = False
            BoxStartScheH.Enabled = False
            BoxStartScheM.Enabled = False
            BoxEndScheH.Enabled = False
            BoxEndScheM.Enabled = False
            BoxRiyuu.Enabled = False
        End If

        '編集中の申請書を立ち上げた場合、残業申請日の変更不可能
        If (iFlg = 0) Then
            BoxYear.Enabled = False
            BoxMonth.Enabled = False
            BoxDay.Enabled = False
        End If

        '次長、課長のIDを格納
        'If (Form1_Login.clsDocument.strRoll = "一般") Then
        '    strBossID = Form1_Login.clsDocument.strBossID
        '    strBossID2 = Form1_Login.clsDocument.strBossID2
        'ElseIf (Form1_Login.clsDocument.strRoll = "次長") Then
        '    strBossID = Form1_Login.clsDocument.strID
        '    strBossID2 = Form1_Login.clsDocument.strBossID
        'ElseIf (Form1_Login.clsDocument.strRoll = "課長" Or Form1_Login.clsDocument.strRoll = "部長") Then
        '    strBossID = Form1_Login.clsDocument.strID
        '    strBossID2 = Form1_Login.clsDocument.strBossID
        'End If
        strBossID = Form1_Login.clsDocument.strBossID
        strBossID2 = Form1_Login.clsDocument.strBossID2


        'stHokoku.strStartZan = ""
        'stHokoku.strEndZan = ""
        'stHokoku.iRest = 0
        'stHokoku.iZan = 0
        'stHokoku.strHokoku = ""
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        '保存せずに閉じる
        Me.Dispose()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        '保存して閉じる
        Form1_Login.clsDocument.SaveDoc(Me)
        Form1_Login.clsLocaclTest.GetIchiran(Form2_Shinsei.DataGridShinsei, Form2_Shinsei.iIndex)
        Me.Dispose()
    End Sub

    Private Sub BtnState1_Click(sender As Object, e As EventArgs) Handles BtnState1.Click
        'ステート1ボタン
        Dim dShisei As Date

        If (False = IsDate((BoxYear.Text & "/" & BoxMonth.Text & "/" & BoxDay.Text))) Then
            Exit Sub
        Else
            dShisei = CDate(BoxYear.Text & "/" & BoxMonth.Text & "/" & BoxDay.Text)

            If (BtnState1.Text = "申請") Then
                '申請者が申請ボタンを押した
                If (BoxStartScheH.Text <> "" And BoxStartScheM.Text <> "") Then
                    '残業開始予定時間が空白セルでないなら始業時間と比較
                    If (CDate(BoxStartScheH.Text & ":" & BoxStartScheM.Text) > CDate(BoxStartH.Text & ":" & BoxStartM.Text)) Then
                        Exit Sub
                    End If
                End If
                If (BoxEndScheH.Text <> "" And BoxEndScheM.Text <> "") Then
                    '残業終了予定時間が空白セルでないなら終業時間と比較
                    If (CDate(BoxEndScheH.Text & ":" & BoxEndScheM.Text) < CDate(BoxEndH.Text & ":" & BoxEndM.Text)) Then
                        Exit Sub
                    End If
                End If
                If (BoxStartScheH.Text = "" And BoxEndScheH.Text = "" And BoxStartScheM.Text = "" And BoxEndScheM.Text = "") Then
                    '残業開始予定時間残業終了予定時間が空白セルなら申請、報告不可能
                    Exit Sub
                End If

                If (DateTime.Today > dShisei) Then
                    'If (strState = "新規作成" Or strState.contains("差し戻し")) Then
                    '今日の日付が申請日より後ろなら報告書フォーム立ち上げ
                    Form6_Houkokusyo.ShowDialog()
                Else
                    strState = "申請"
                    Form1_Login.clsDocument.SaveDoc(Me)
                    Form1_Login.clsDocument.NextState(Me, strBossID)
                    Form1_Login.clsLocaclTest.GetIchiran(Form2_Shinsei.DataGridShinsei, Form2_Shinsei.iIndex)
                End If
            ElseIf (BtnState1.Text = "報告") Then
                '申請者が報告ボタンを押した
                Form6_Houkokusyo.ShowDialog()
            ElseIf (BtnState1.Text = "差し戻し") Then
                '次長が差し戻しを押した
                strState = "差し戻し"
                Form1_Login.clsDocument.ChangeState(Me, BoxID.Text)
                Form1_Login.clsDocument.DelShiseiInfo(Me, strBossID)
                Form3_Jityou.DataGridShinsei.Rows(Form3_Jityou.iRowstate).Cells(18).Value = strState
            Else
                'NOP
            End If
        End If
        Me.Dispose()
    End Sub

    Private Sub BtnState2_Click(sender As Object, e As EventArgs) Handles BtnState2.Click
        'ステート2
        If (BtnState2.Text = "取り下げ") Then
            '申請者が取り下げボタンを押した
            Form1_Login.clsDocument.DelShiseiInfo(Me, BoxID.Text)
            If Not (strState = "新規作成" Or strState.Contains("差し戻し")) Then
                '次長の一覧表から削除
                Form1_Login.clsDocument.DelShiseiInfo(Me, strBossID)
                If (strState.Contains("承認")) Then
                    '課長の一覧表から削除
                    Form1_Login.clsDocument.DelShiseiInfo(Me, strBossID2)
                End If
                Form2_Shinsei.DataGridShinsei.Rows.RemoveAt(Form2_Shinsei.iRowdel)
                'Form1_Login.clsLocaclTest.GetIchiran(Form2_Shinsei.DataGridShinsei, Form2_Shinsei.iIndex)
            End If
        ElseIf (BtnState2.Text = "承認依頼") Then
            '次長が承認依頼ボタンを押した
            strState = strState.Replace("申請", "承認依頼")
            Form1_Login.clsDocument.SaveDoc(Me)
            Form1_Login.clsDocument.NextState(Me, strBossID2)
            Form1_Login.clsDocument.ChangeState(Me, BoxID.Text)
            Form3_Jityou.DataGridShinsei.Rows(Form3_Jityou.iRowstate).Cells(18).Value = strState
            'Form1_Login.clsLocaclTest.GetIchiran(Form3_Jityou.DataGridShinsei, Form3_Jityou.iIndex)
        ElseIf (BtnState2.Text = "承認") Then
            '課長が承認ボタンを押した
            If (strState = "承認依頼") Then
                '報告前
                strState = strState.Replace("承認依頼", "承認")
            Else
                '報告済み
                strState = "完了"
            End If
            Form1_Login.clsDocument.SaveDoc(Me)
            Form1_Login.clsDocument.ChangeState(Me, BoxID.Text)
            Form1_Login.clsDocument.ChangeState(Me, strBossID)
            Form4_katyou.DataGridShinsei.Rows(Form4_katyou.iRowstate).Cells(18).Value = strState
            'Form1_Login.clsLocaclTest.GetIchiran(Form4_katyou.DataGridShinsei, Form4_katyou.iIndex)
        Else
            'NOP
        End If
        Me.Dispose()
    End Sub
End Class
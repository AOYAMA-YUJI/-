Public Class Document
    Public strFolder As String              '残業申請書/報告書の保存先

    '残業申請書作成（自動入力）のテーブル
    Public strID As String                  '社員ID
    Public strName As String                '氏名
    Public strTeam As String                '部署
    Public strPattern As String             '勤務パターン
    Public strStart(1) As String             '始業時間
    Public strEnd(1) As String               '終業時間
    Public strDate As String                '申請日

    Public strRoll As String                '役職

    '残業申請書作成（手動入力）のテーブル
    Public strStartSchedule(1) As String     '前残業開始予定時間
    Public strEndSchedule(1) As String       '後残業終了予定時間
    Public strRiyuu As String                '残業理由

    '残業申請書作成（報告）のテーブル
    Public strStartZangyo(1) As String       '前残業開始時間
    Public strEndZangyo(1) As String         '後残業終了時間
    Public strRest As String                '休憩時間
    Public strZangyo As String              '実残業時間
    Public strHokoku As String               '残業報告
    Public strHokokuData As String           '残業報告日

    Public strBossName As String            '承認者氏名
    Public strBossDate As String            '承認日

    Public strState As String               'ステート
    Public strBossID As String              'ステート先ID
    Public strBossID2 As String             'ステート先ID2
    Public strStateDay As String            'ステート更新日

    Public iFlg As Integer                  '新規作成フラグ

    Public Sub GetRoll(ShiseiData As LocalTest)
        strRoll = ShiseiData.strRoll
    End Sub

    Public Sub NewDoc(ShiseiData As LocalTest)
        strDate = DateTime.Today.ToString("yyyyMMdd")
        strID = ShiseiData.strID
        strName = ShiseiData.strName
        strTeam = ShiseiData.strTeam
        strBossID = ShiseiData.strBossID
        strBossID2 = ShiseiData.strBossID2
        strPattern = ShiseiData.strPattern
        strFolder = ShiseiData.strFolder
        strStart = ShiseiData.strStart
        strEnd = ShiseiData.strEnd
        strStartSchedule(0) = ""
        strStartSchedule(1) = ""
        strEndSchedule(0) = ""
        strEndSchedule(1) = ""
        strRiyuu = ""
        strState = "新規作成"

        iFlg = 1
    End Sub

    Public Sub EditDoc(Ichiran As DataGridView, iRowDisp As Integer)
        strDate = Ichiran.Rows(iRowDisp).Cells(0).Value
        strID = Ichiran.Rows(iRowDisp).Cells(1).Value
        strName = Ichiran.Rows(iRowDisp).Cells(2).Value
        strTeam = Ichiran.Rows(iRowDisp).Cells(3).Value
        strPattern = Ichiran.Rows(iRowDisp).Cells(4).Value
        strStart = Ichiran.Rows(iRowDisp).Cells(5).Value.split(":")
        strEnd = Ichiran.Rows(iRowDisp).Cells(6).Value.split(":")
        strRiyuu = Ichiran.Rows(iRowDisp).Cells(9).Value
        strRest = Ichiran.Rows(iRowDisp).Cells(12).Value
        strZangyo = Ichiran.Rows(iRowDisp).Cells(13).Value
        strHokoku = Ichiran.Rows(iRowDisp).Cells(14).Value
        strHokokuData = Ichiran.Rows(iRowDisp).Cells(15).Value
        strBossName = Ichiran.Rows(iRowDisp).Cells(16).Value
        strBossDate = Ichiran.Rows(iRowDisp).Cells(17).Value
        strState = Ichiran.Rows(iRowDisp).Cells(18).Value
        strBossID = Ichiran.Rows(iRowDisp).Cells(19).Value
        strBossID2 = Ichiran.Rows(iRowDisp).Cells(20).Value
        strStateDay = Ichiran.Rows(iRowDisp).Cells(21).Value

        If (Ichiran.Rows(iRowDisp).Cells(7).Value <> "") Then
            strStartSchedule = Ichiran.Rows(iRowDisp).Cells(7).Value.split(":")
        Else
            strStartSchedule(0) = ""
            strStartSchedule(1) = ""
        End If
        If (Ichiran.Rows(iRowDisp).Cells(8).Value <> "") Then
            strEndSchedule = Ichiran.Rows(iRowDisp).Cells(8).Value.split(":")
        Else
            strEndSchedule(0) = ""
            strEndSchedule(1) = ""
        End If
        If (Ichiran.Rows(iRowDisp).Cells(10).Value <> "") Then
            strStartZangyo = Ichiran.Rows(iRowDisp).Cells(10).Value.split(":")
        Else
            strStartZangyo(0) = ""
            strStartZangyo(1) = ""
        End If
        If (Ichiran.Rows(iRowDisp).Cells(11).Value <> "") Then
            strEndZangyo = Ichiran.Rows(iRowDisp).Cells(11).Value.split(":")
        Else
            strEndZangyo(0) = ""
            strEndZangyo(1) = ""
        End If

        iFlg = 0
    End Sub

    Public Sub SaveDoc(ShiseiData As Form5_Shiseisyo)
        Form1_Login.clsLocaclTest.SaveShiseiInfo(ShiseiData)
    End Sub

    Public Sub NextState(ShiseiData As Form5_Shiseisyo, strID As String)
        Form1_Login.clsLocaclTest.NextState(ShiseiData, strID)
    End Sub

    Public Sub ChangeState(ShiseiData As Form5_Shiseisyo, strID As String)
        Form1_Login.clsLocaclTest.ChangeState(ShiseiData, strID)
    End Sub

    Public Sub HokokuState(ShiseiData As Form6_Houkokusyo, strHokokuID As String, strState As String, strYear As String, strMonth As String, strDay As String)
        Form1_Login.clsLocaclTest.HokokuState(ShiseiData, strHokokuID, strState, strYear, strMonth, strDay)
    End Sub

    Public Sub DelShiseiInfo(ShiseiData As Form5_Shiseisyo, strID As String)
        Form1_Login.clsLocaclTest.DelShiseiInfo(ShiseiData, strID)
    End Sub
End Class

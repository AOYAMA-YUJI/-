Imports System.Runtime.InteropServices.JavaScript.JSType
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

''' <summary></summary>
''' <param name=""></param>
''' <returns></returns>
Public Class LocalTest
    'ディレクトリはひとまず固定
    Const strDir As String = "C:\Users\GuestUser\source\repos\ProtoType\resources\"
    Const strDirDoc As String = "C:\Users\GuestUser\source\repos\ProtoType\resources\残業申請\"
    Const strMeibo As String = "Meibo.xlsx"
    Const strKinmu As String = "Kinmu.xlsx"
    Const strIchiran As String = "Ichiran.xlsx"
    Const strGetsuji As String = "Getsuji.xlsx"
    Const iRowStart As Integer = 2

    '社員名簿から取得する
    Public strID As String = ""          '社員ID
    Public strName As String = ""        '氏名
    Public strTeam As String = ""        '部署
    Public strRoll As String = ""        '役職
    Public strBossID As String = ""      '上司ID1（一般、次長のみ）
    Public strBossID2 As String = ""     '上司ID2（一般のみ）
    Public strPattern As String = ""     '勤務パターン
    Public strFolder As String = ""      '残業申請書/報告書の保存先

    '勤務パターンを基に取得する
    Public strStart(1) As String         '始業時間
    Public strEnd(1) As String           '終業時間

    Public Function GetMeiboInfo() As Boolean
        Dim iRow As Integer = iRowStart
        Dim iLoop As Integer = 0
        Dim bFlg As Boolean = False

        Dim strDate As String
        Dim strFolderID As String
        Dim strFolderDate As String

        Dim excelApp As New Excel.Application()
        Dim excelBooks As Excel.Workbooks
        Dim excelBook As Excel.Workbook
        Dim sheet As Excel.Worksheet

        GetMeiboInfo = False

        excelBooks = excelApp.Workbooks
        excelBook = excelBooks.Open(strDir & strMeibo)
        sheet = excelApp.Worksheets("sheet1")
        excelApp.Visible = False

        While (sheet.Cells(iRow, "A").value <> "")
            If (Form1_Login.TextBoxID.Text = sheet.Cells(iRow, "A").value) Then
                If (Form1_Login.TextBoxPass.Text = sheet.Cells(iRow, "K").value) Then
                    'パスワード一致
                    strID = sheet.Cells(iRow, "A").value
                    strName = sheet.Cells(iRow, "B").value
                    strTeam = sheet.Cells(iRow, "D").value
                    strRoll = sheet.Cells(iRow, "E").value
                    strPattern = sheet.Cells(iRow, "F").value
                    strBossID = sheet.Cells(iRow, "G").value
                    strBossID2 = sheet.Cells(iRow, "I").value

                    'IDを基に保存先フォルダのパス取得
                    strDate = DateTime.Today.ToString("yyyyMMdd")
                    strFolderID = (CInt(strID) / 100).ToString("000") & "01"
                    strFolderDate = Strings.Left(strDate, 4) & "\" & Strings.Mid(strDate, 5, 2)

                    strFolder = strDirDoc & strFolderID & "\" & strID & "\" & strFolderDate

                    If (False = System.IO.Directory.Exists(strFolder)) Then
                        System.IO.Directory.CreateDirectory(strFolder)
                    End If

                    For iLoop = 0 To 2
                        If (strRoll = "一般") Then
                            MakeTsukiJityo(strBossID, sheet, iLoop)
                        ElseIf (strRoll = "次長") Then
                            MakeTsukiJityo(strID, sheet, iLoop)
                        End If
                    Next

                    GetMeiboInfo = True
                Else
                    'パスワード不一致
                    MsgBox("パスワードが一致しませんでした", vbCritical)
                End If
                bFlg = True
                Exit While
            End If
            iRow += 1
        End While

        excelApp.Quit()

        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)

        If (False = bFlg) Then
            'ID無し
            MsgBox("IDが見つかりませんでした", vbCritical)
        Else
            '勤務パターンを基に始業時間，終業時間を取得
            GetKinmuInfo()
        End If
    End Function

    Public Sub GetKinmuInfo()
        Dim iRow As Integer = iRowStart

        Dim excelApp As New Excel.Application()
        Dim excelBooks As Excel.Workbooks
        Dim excelBook As Excel.Workbook
        Dim sheet As Excel.Worksheet

        excelBooks = excelApp.Workbooks
        excelBook = excelBooks.Open(strDir & strKinmu)
        sheet = excelApp.Worksheets("sheet1")
        excelApp.Visible = False

        '勤務パターンを基に始業時間，終業時間を取得
        While (sheet.Cells(iRow, "A").value <> "")
            If (strPattern = sheet.Cells(iRow, 1).value) Then
                strStart = (sheet.Cells(iRow, 2).text).split(":")
                strEnd = sheet.Cells(iRow, 3).text.split(":")
                Exit While
            End If
            iRow += 1
        End While

        excelApp.Quit()

        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    End Sub

    Public Sub GetIchiran(Ichiran As DataGridView, IchiranTsuki As DataGridView, iMon As Integer)
        Dim iRow As Integer = iRowStart
        Dim iRowDisp As Integer = 0
        Dim iRuiseki As Integer = 0
        Dim iLoop As Integer = 0

        Dim strDate As String
        Dim strFolderID As String
        Dim strFolderDate As String
        Dim strFileName As String

        Dim excelApp As New Excel.Application()
        Dim excelBooks As Excel.Workbooks
        Dim excelBook As Excel.Workbook
        Dim sheet As Excel.Worksheet

        'ディレクトリ、ファイル名を作成
        strDate = DateTime.Today.AddMonths(-(iMon)).ToString("yyyyMM")
        strFolderID = (CInt(strID) / 100).ToString("000") & "01"
        strFolderDate = Strings.Left(strDate, 4) & "\" & Strings.Mid(strDate, 5, 2)
        strFileName = strID & "-" & Strings.Left(strDate, 4) & Strings.Mid(strDate, 5, 2) & ".xlsx"
        strFolder = strDirDoc & strFolderID & "\" & strID & "\" & strFolderDate

        If (False = System.IO.File.Exists(strFolder & "\" & strFileName)) Then
            '申請書一覧が無ければ作成
            System.IO.Directory.CreateDirectory(strFolder)
            System.IO.File.Copy(strDir & strIchiran, strFolder & "\" & strFileName)
            'IchiranTsuki.Rows.Add()
            'IchiranTsuki.Rows(iMon).Cells(0).Value = strDate
            'IchiranTsuki.Rows(iMon).Cells(1).Value = 0
            'IchiranTsuki.Rows(iMon).Cells(2).Value = "未提出"
            Exit Sub
        Else
            '申請書一覧があればデータ取得
            excelBooks = excelApp.Workbooks
            excelBook = excelBooks.Open(strFolder & "\" & strFileName)
            sheet = excelApp.Worksheets("sheet1")
            excelApp.Visible = False

            While (sheet.Cells(iRow, "A").value <> "")
                Ichiran.Rows.Add()
                Ichiran.Rows(iRowDisp).Cells(0).Value = sheet.Cells(iRow, "A").value
                Ichiran.Rows(iRowDisp).Cells(1).Value = sheet.Cells(iRow, "B").value
                Ichiran.Rows(iRowDisp).Cells(2).Value = sheet.Cells(iRow, "C").value
                Ichiran.Rows(iRowDisp).Cells(3).Value = sheet.Cells(iRow, "D").value
                Ichiran.Rows(iRowDisp).Cells(4).Value = sheet.Cells(iRow, "E").value
                Ichiran.Rows(iRowDisp).Cells(5).Value = sheet.Cells(iRow, "F").value
                Ichiran.Rows(iRowDisp).Cells(6).Value = sheet.Cells(iRow, "G").value
                Ichiran.Rows(iRowDisp).Cells(7).Value = sheet.Cells(iRow, "H").value
                Ichiran.Rows(iRowDisp).Cells(8).Value = sheet.Cells(iRow, "I").value
                Ichiran.Rows(iRowDisp).Cells(9).Value = sheet.Cells(iRow, "J").value
                Ichiran.Rows(iRowDisp).Cells(10).Value = sheet.Cells(iRow, "K").value
                Ichiran.Rows(iRowDisp).Cells(11).Value = sheet.Cells(iRow, "L").value
                Ichiran.Rows(iRowDisp).Cells(12).Value = sheet.Cells(iRow, "M").value
                Ichiran.Rows(iRowDisp).Cells(13).Value = sheet.Cells(iRow, "N").value
                Ichiran.Rows(iRowDisp).Cells(14).Value = sheet.Cells(iRow, "O").value
                Ichiran.Rows(iRowDisp).Cells(15).Value = sheet.Cells(iRow, "P").value
                Ichiran.Rows(iRowDisp).Cells(16).Value = sheet.Cells(iRow, "Q").value
                Ichiran.Rows(iRowDisp).Cells(17).Value = sheet.Cells(iRow, "R").value
                Ichiran.Rows(iRowDisp).Cells(18).Value = sheet.Cells(iRow, "S").value
                Ichiran.Rows(iRowDisp).Cells(19).Value = sheet.Cells(iRow, "T").value
                Ichiran.Rows(iRowDisp).Cells(20).Value = sheet.Cells(iRow, "U").value
                Ichiran.Rows(iRowDisp).Cells(21).Value = sheet.Cells(iRow, "V").value

                If (sheet.Cells(iRow, "S").value = "完了") Then
                    iRuiseki += CInt(Ichiran.Rows(iRowDisp).Cells(13).Value)
                End If

                iRow += 1
                iRowDisp += 1
            End While

            IchiranTsuki.Rows.Add()
            IchiranTsuki.Rows(iMon).Cells(0).Value = strDate
            IchiranTsuki.Rows(iMon).Cells(1).Value = iRuiseki

            If (sheet.Cells(2, "W").value = "提出済") Then
                IchiranTsuki.Rows(iMon).Cells(2).Value = "提出済"
            Else
                IchiranTsuki.Rows(iMon).Cells(2).Value = "未提出"
            End If

            excelApp.Quit()

            Call System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
            Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook)
            Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
        End If
    End Sub

    Public Sub GetIchiran(Ichiran As DataGridView, iMon As Integer)
        Dim iRow As Integer = iRowStart
        Dim iRowDisp As Integer = 0

        Dim strDate As String
        Dim strFolderID As String
        Dim strFolderDate As String
        Dim strFileName As String

        Dim excelApp As New Excel.Application()
        Dim excelBooks As Excel.Workbooks
        Dim excelBook As Excel.Workbook
        Dim sheet As Excel.Worksheet

        'ディレクトリ、ファイル名を作成
        strDate = DateTime.Today.AddMonths(-(iMon)).ToString("yyyyMM")
        strFolderID = (CInt(strID) / 100).ToString("000") & "01"
        strFolderDate = Strings.Left(strDate, 4) & "\" & Strings.Mid(strDate, 5, 2)
        strFileName = strID & "-" & Strings.Left(strDate, 4) & Strings.Mid(strDate, 5, 2) & ".xlsx"
        strFolder = strDirDoc & strFolderID & "\" & strID & "\" & strFolderDate

        If (False = System.IO.File.Exists(strFolder & "\" & strFileName)) Then
            '申請書一覧が無ければ作成
            System.IO.Directory.CreateDirectory(strFolder)
            System.IO.File.Copy(strDir & strIchiran, strFolder & "\" & strFileName)
            Exit Sub
        Else
            '申請書一覧があればデータ取得
            excelBooks = excelApp.Workbooks
            excelBook = excelBooks.Open(strFolder & "\" & strFileName)
            sheet = excelApp.Worksheets("sheet1")
            excelApp.Visible = False

            While (sheet.Cells(iRow, "A").value <> "")

                Ichiran.Rows.Add()
                Ichiran.Rows(iRowDisp).Cells(0).Value = sheet.Cells(iRow, "A").value
                Ichiran.Rows(iRowDisp).Cells(1).Value = sheet.Cells(iRow, "B").value
                Ichiran.Rows(iRowDisp).Cells(2).Value = sheet.Cells(iRow, "C").value
                Ichiran.Rows(iRowDisp).Cells(3).Value = sheet.Cells(iRow, "D").value
                Ichiran.Rows(iRowDisp).Cells(4).Value = sheet.Cells(iRow, "E").value
                Ichiran.Rows(iRowDisp).Cells(5).Value = sheet.Cells(iRow, "F").value
                Ichiran.Rows(iRowDisp).Cells(6).Value = sheet.Cells(iRow, "G").value
                Ichiran.Rows(iRowDisp).Cells(7).Value = sheet.Cells(iRow, "H").value
                Ichiran.Rows(iRowDisp).Cells(8).Value = sheet.Cells(iRow, "I").value
                Ichiran.Rows(iRowDisp).Cells(9).Value = sheet.Cells(iRow, "J").value
                Ichiran.Rows(iRowDisp).Cells(10).Value = sheet.Cells(iRow, "K").value
                Ichiran.Rows(iRowDisp).Cells(11).Value = sheet.Cells(iRow, "L").value
                Ichiran.Rows(iRowDisp).Cells(12).Value = sheet.Cells(iRow, "M").value
                Ichiran.Rows(iRowDisp).Cells(13).Value = sheet.Cells(iRow, "N").value
                Ichiran.Rows(iRowDisp).Cells(14).Value = sheet.Cells(iRow, "O").value
                Ichiran.Rows(iRowDisp).Cells(15).Value = sheet.Cells(iRow, "P").value
                Ichiran.Rows(iRowDisp).Cells(16).Value = sheet.Cells(iRow, "Q").value
                Ichiran.Rows(iRowDisp).Cells(17).Value = sheet.Cells(iRow, "R").value
                Ichiran.Rows(iRowDisp).Cells(18).Value = sheet.Cells(iRow, "S").value
                Ichiran.Rows(iRowDisp).Cells(19).Value = sheet.Cells(iRow, "T").value
                Ichiran.Rows(iRowDisp).Cells(20).Value = sheet.Cells(iRow, "U").value
                Ichiran.Rows(iRowDisp).Cells(21).Value = sheet.Cells(iRow, "V").value

                iRow += 1
                iRowDisp += 1
            End While

            excelApp.Quit()

            Call System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
            Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook)
            Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
        End If
    End Sub

    Public Sub MakeTsukiJityo(strID As String, sheetMeibo As Excel.Worksheet, iMon As Integer)
        Dim iRow As Integer = iRowStart
        Dim strDate As String
        Dim strFolderID As String
        Dim strFolderDate As String
        Dim strFileName As String

        Dim excelApp As New Excel.Application()
        Dim excelBooks As Excel.Workbooks
        Dim excelBook As Excel.Workbook
        Dim sheet As Excel.Worksheet

        strDate = DateTime.Today.AddMonths(-(iMon)).ToString("yyyyMM")
        strFolderID = (CInt(strID) / 100).ToString("000") & "01"
        strFolderDate = Strings.Left(strDate, 4) & "\" & Strings.Mid(strDate, 5, 2)
        strFileName = Strings.Left(strDate, 4) & "-" & Strings.Mid(strDate, 5, 2) & "-" & strTeam & "_月次報告.xlsx"
        strFolder = strDirDoc & strFolderID & "\" & strID & "\" & strFolderDate

        If (False = System.IO.File.Exists(strFolder & "\" & strFileName)) Then
            System.IO.Directory.CreateDirectory(strFolder)
            System.IO.File.Copy(strDir & strGetsuji, strFolder & "\" & strFileName)

            excelBooks = excelApp.Workbooks
            excelBook = excelBooks.Open(strFolder & "\" & strFileName)
            sheet = excelApp.Worksheets("sheet1")
            excelApp.Visible = False

            While (sheetMeibo.Cells(iRow, "A").value <> "")
                If (strID = sheetMeibo.Cells(iRow, "G").value) Then
                    sheet.Cells(iRow, "A").value = sheetMeibo.Cells(iRow, "A").value
                    sheet.Cells(iRow, "B").value = sheetMeibo.Cells(iRow, "B").value
                    sheet.Cells(iRow, "C").value = sheetMeibo.Cells(iRow, "F").value
                End If
                iRow += 1
            End While

            excelBook.Save()
            excelApp.Quit()

            Call System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
            Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook)
            Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
        End If
    End Sub


    Public Sub SaveShiseiInfo(ShiseiData As Form5_Shiseisyo)
        Dim iRow As Integer = iRowStart
        Dim strFolderID As String
        Dim strFolderDate As String
        Dim strFileName As String

        Dim excelApp As New Excel.Application()
        Dim excelBooks As Excel.Workbooks
        Dim excelBook As Excel.Workbook
        Dim sheet As Excel.Worksheet

        strFolderID = (CInt(strID) / 100).ToString("000") & "01"
        strFolderDate = ShiseiData.BoxYear.Text & "\" & ShiseiData.BoxMonth.Text
        strFileName = strFolderID & "-" & ShiseiData.BoxYear.Text & ShiseiData.BoxMonth.Text & ".xlsx"
        strFolder = strDirDoc & strFolderID & "\" & strID & "\" & strFolderDate

        If (False = System.IO.File.Exists(strFolder & "\" & strFileName)) Then
            '申請書一覧が無ければ作成
            System.IO.Directory.CreateDirectory(strFolder)
            System.IO.File.Copy(strDir & strIchiran, strFolder & "\" & strFileName)
        End If

        excelBooks = excelApp.Workbooks
        excelBook = excelBooks.Open(strFolder & "\" & strFileName)
        sheet = excelApp.Worksheets("sheet1")
        excelApp.Visible = False

        '自分の残業申請一覧に保存する
        While (sheet.Cells(iRow, "A").value <> "")
            If (sheet.Cells(iRow, "A").value = ShiseiData.BoxYear.Text & ShiseiData.BoxMonth.Text & ShiseiData.BoxDay.Text) Then
                Exit While
            End If
            iRow += 1
        End While

        sheet.Cells(iRow, "A").value = ShiseiData.BoxYear.Text & ShiseiData.BoxMonth.Text & ShiseiData.BoxDay.Text
        sheet.Cells(iRow, "B").value = ShiseiData.BoxID.Text
        sheet.Cells(iRow, "C").value = ShiseiData.BoxName.Text
        sheet.Cells(iRow, "D").value = ShiseiData.BoxTeam.Text
        sheet.Cells(iRow, "E").value = ShiseiData.BoxPatten.Text
        sheet.Cells(iRow, "F").value = ShiseiData.BoxStartH.Text & ":" & ShiseiData.BoxStartM.Text
        sheet.Cells(iRow, "G").value = ShiseiData.BoxEndH.Text & ":" & ShiseiData.BoxEndM.Text
        sheet.Cells(iRow, "J").value = ShiseiData.BoxRiyuu.Text

        If (ShiseiData.BoxStartScheH.Text <> "" And ShiseiData.BoxStartScheM.Text <> "") Then
            sheet.Cells(iRow, "H").value = ShiseiData.BoxStartScheH.Text & ":" & ShiseiData.BoxStartScheM.Text
        End If
        If (ShiseiData.BoxEndScheH.Text <> "" And ShiseiData.BoxEndScheM.Text <> "") Then
            sheet.Cells(iRow, "I").value = ShiseiData.BoxEndScheH.Text & ":" & ShiseiData.BoxEndScheM.Text
        End If

        'ステート
        sheet.Cells(iRow, "S").value = ShiseiData.strState
        sheet.Cells(iRow, "T").value = strBossID
        sheet.Cells(iRow, "U").value = strBossID2
        sheet.Cells(iRow, "V").value = DateTime.Today.ToString("yyyyMMdd")


        '承認者氏名、承認日
        If (strRoll = "部長" Or strRoll = "課長") Then
            sheet.Cells(iRow, "Q").value = strName
            sheet.Cells(iRow, "R").value = DateTime.Today.ToString("yyyyMMdd")
        End If

        excelBook.Save()
        excelApp.Quit()

        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    End Sub


    Public Sub NextState(ShiseiData As Form5_Shiseisyo, strNextID As String)
        Dim iRow As Integer = iRowStart
        Dim strFolderID As String
        Dim strFolderDate As String
        Dim strFileName As String

        Dim excelApp As New Excel.Application()
        Dim excelBooks As Excel.Workbooks
        Dim excelBook As Excel.Workbook
        Dim sheet As Excel.Worksheet

        strFolderID = (CInt(strNextID) / 100).ToString("000") & "01"
        strFolderDate = ShiseiData.BoxYear.Text & "\" & ShiseiData.BoxMonth.Text
        strFileName = strFolderID & "-" & ShiseiData.BoxYear.Text & ShiseiData.BoxMonth.Text & ".xlsx"
        strFolder = strDirDoc & strFolderID & "\" & strNextID & "\" & strFolderDate

        If (False = System.IO.File.Exists(strFolder & "\" & strFileName)) Then
            '申請書一覧が無ければ作成
            System.IO.Directory.CreateDirectory(strFolder)
            System.IO.File.Copy(strDir & strIchiran, strFolder & "\" & strFileName)
        End If

        excelBooks = excelApp.Workbooks
        excelBook = excelBooks.Open(strFolder & "\" & strFileName)
        sheet = excelApp.Worksheets("sheet1")
        excelApp.Visible = False

        '残業申請一覧に保存する
        While (sheet.Cells(iRow, "A").value <> "")
            If (sheet.Cells(iRow, "A").value = ShiseiData.BoxYear.Text & ShiseiData.BoxMonth.Text & ShiseiData.BoxDay.Text And
                sheet.Cells(iRow, "B").value = "") Then
                Exit While
            End If
            iRow += 1
        End While

        sheet.Cells(iRow, "A").value = ShiseiData.BoxYear.Text & ShiseiData.BoxMonth.Text & ShiseiData.BoxDay.Text
        sheet.Cells(iRow, "B").value = ShiseiData.BoxID.Text
        sheet.Cells(iRow, "C").value = ShiseiData.BoxName.Text
        sheet.Cells(iRow, "D").value = ShiseiData.BoxTeam.Text
        sheet.Cells(iRow, "E").value = ShiseiData.BoxPatten.Text
        sheet.Cells(iRow, "F").value = ShiseiData.BoxStartH.Text & ":" & ShiseiData.BoxStartM.Text
        sheet.Cells(iRow, "G").value = ShiseiData.BoxEndH.Text & ":" & ShiseiData.BoxEndM.Text
        sheet.Cells(iRow, "J").value = ShiseiData.BoxRiyuu.Text

        If (ShiseiData.BoxStartScheH.Text <> "" And ShiseiData.BoxStartScheM.Text <> "") Then
            sheet.Cells(iRow, "H").value = ShiseiData.BoxStartScheH.Text & ":" & ShiseiData.BoxStartScheM.Text
        End If
        If (ShiseiData.BoxEndScheH.Text <> "" And ShiseiData.BoxEndScheM.Text <> "") Then
            sheet.Cells(iRow, "I").value = ShiseiData.BoxEndScheH.Text & ":" & ShiseiData.BoxEndScheM.Text
        End If

        'ステート
        sheet.Cells(iRow, "S").value = ShiseiData.strState
        'sheet.Cells(iRow, "T").value = ShiseiData.strBossID
        'sheet.Cells(iRow, "U").value = ShiseiData.strBossID2
        sheet.Cells(iRow, "V").value = DateTime.Today.ToString("yyyyMMdd")

        '承認者氏名、承認日
        If (strRoll = "部長" Or strRoll = "課長") Then
            sheet.Cells(iRow, "Q").value = strName
            sheet.Cells(iRow, "R").value = DateTime.Today.ToString("yyyyMMdd")
        End If

        excelBook.Save()
        excelApp.Quit()

        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    End Sub

    Public Sub ChangeState(ShiseiData As Form5_Shiseisyo, strChangeID As String)
        Dim iRow As Integer = iRowStart
        Dim strFolderID As String
        Dim strFolderDate As String
        Dim strFileName As String

        Dim excelApp As New Excel.Application()
        Dim excelBooks As Excel.Workbooks
        Dim excelBook As Excel.Workbook
        Dim sheet As Excel.Worksheet

        strFolderID = (CInt(strChangeID) / 100).ToString("000") & "01"
        strFolderDate = ShiseiData.BoxYear.Text & "\" & ShiseiData.BoxMonth.Text
        strFileName = strFolderID & "-" & ShiseiData.BoxYear.Text & ShiseiData.BoxMonth.Text & ".xlsx"
        strFolder = strDirDoc & strFolderID & "\" & strChangeID & "\" & strFolderDate

        If (False = System.IO.File.Exists(strFolder & "\" & strFileName)) Then
            '申請書一覧が無ければ作成（ここには来ないはず）
            System.IO.Directory.CreateDirectory(strFolder)
            System.IO.File.Copy(strDir & strIchiran, strFolder & "\" & strFileName)
        End If

        excelBooks = excelApp.Workbooks
        excelBook = excelBooks.Open(strFolder & "\" & strFileName)
        sheet = excelApp.Worksheets("sheet1")
        excelApp.Visible = False

        While (sheet.Cells(iRow, "A").value <> "")
            If (sheet.Cells(iRow, "A").value = ShiseiData.BoxYear.Text & ShiseiData.BoxMonth.Text & ShiseiData.BoxDay.Text) Then
                Exit While
            End If
            iRow += 1
        End While

        'ステート更新
        sheet.Cells(iRow, "S").value = ShiseiData.strState
        sheet.Cells(iRow, "V").value = DateTime.Today.ToString("yyyyMMdd")

        excelBook.Save()
        excelApp.Quit()

        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    End Sub

    Public Sub HokokuState(ShiseiData As Form6_Houkokusyo, strHokokuID As String, strState As String, strYear As String, strMonth As String, strDay As String)
        Dim iRow As Integer = iRowStart
        Dim strFolderID As String
        Dim strFolderDate As String
        Dim strFileName As String

        Dim excelApp As New Excel.Application()
        Dim excelBooks As Excel.Workbooks
        Dim excelBook As Excel.Workbook
        Dim sheet As Excel.Worksheet

        strFolderID = (CInt(strHokokuID) / 100).ToString("000") & "01"
        strFolderDate = strYear & "\" & strMonth
        strFileName = strFolderID & "-" & strYear & strMonth & ".xlsx"
        strFolder = strDirDoc & strFolderID & "\" & strHokokuID & "\" & strFolderDate

        If (False = System.IO.File.Exists(strFolder & "\" & strFileName)) Then
            '申請書一覧が無ければ作成（ここには来ないはず）
            System.IO.Directory.CreateDirectory(strFolder)
            System.IO.File.Copy(strDir & strIchiran, strFolder & "\" & strFileName)
        End If

        excelBooks = excelApp.Workbooks
        excelBook = excelBooks.Open(strFolder & "\" & strFileName)
        sheet = excelApp.Worksheets("sheet1")
        excelApp.Visible = False

        '残業申請一覧に保存する
        While (sheet.Cells(iRow, "A").value <> "")
            If (sheet.Cells(iRow, "A").value = strYear & strMonth & strDay And
                sheet.Cells(iRow, "B").value = "") Then
                Exit While
            End If
            iRow += 1
        End While

        'ステート更新
        sheet.Cells(iRow, "S").value = strState
        sheet.Cells(iRow, "V").value = DateTime.Today.ToString("yyyyMMdd")

        '報告
        sheet.Cells(iRow, "K").value = ShiseiData.BoxStartZanH.Text & ":" & ShiseiData.BoxStartZanM.Text
        sheet.Cells(iRow, "L").value = ShiseiData.BoxEndZanH.Text & ":" & ShiseiData.BoxEndZanM.Text
        sheet.Cells(iRow, "M").value = CInt(ShiseiData.BoxRestH.SelectedIndex) * 60 + CInt(ShiseiData.BoxRestM.SelectedIndex)
        sheet.Cells(iRow, "N").value = CInt(ShiseiData.BoxZanH.Text) * 60 + CInt(ShiseiData.BoxZanM.Text)
        sheet.Cells(iRow, "O").value = ShiseiData.BoxHokoku.Text
        sheet.Cells(iRow, "P").value = DateTime.Today.ToString("yyyyMMdd")

        excelBook.Save()
        excelApp.Quit()

        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    End Sub



    Public Sub DelShiseiInfo(ShiseiData As Form5_Shiseisyo, strDelID As String)
        Dim iRow As Integer = iRowStart
        Dim strRow As String
        Dim strFolderID As String
        Dim strFolderDate As String
        Dim strFileName As String

        Dim excelApp As New Excel.Application()
        Dim excelBooks As Excel.Workbooks
        Dim excelBook As Excel.Workbook
        Dim sheet As Excel.Worksheet

        strFolderID = (CInt(strDelID) / 100).ToString("000") & "01"
        strFolderDate = ShiseiData.BoxYear.Text & "\" & ShiseiData.BoxMonth.Text
        strFileName = strFolderID & "-" & ShiseiData.BoxYear.Text & ShiseiData.BoxMonth.Text & ".xlsx"
        strFolder = strDirDoc & strFolderID & "\" & strDelID & "\" & strFolderDate

        If (False = System.IO.File.Exists(strFolder & "\" & strFileName)) Then
            '申請書一覧が無ければ作成（ここには来ないはず）
            System.IO.Directory.CreateDirectory(strFolder)
            System.IO.File.Copy(strDir & strIchiran, strFolder & "\" & strFileName)
        End If

        excelBooks = excelApp.Workbooks
        excelBook = excelBooks.Open(strFolder & "\" & strFileName)
        sheet = excelApp.Worksheets("sheet1")
        excelApp.Visible = False

        While (sheet.Cells(iRow, "A").value <> ShiseiData.BoxYear.Text & ShiseiData.BoxMonth.Text & ShiseiData.BoxDay.Text)
            iRow += 1
        End While

        strRow = CStr(iRow) & ":" & CStr(iRow)
        sheet.Range(strRow).EntireRow.Delete(Shift:=Excel.XlDirection.xlUp)

        excelBook.Save()
        excelApp.Quit()

        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    End Sub

    Public Sub SendGetsuji(Ichiran As DataGridView, iMon As Integer, strBossID As String)
        Dim strDate As String = Ichiran.Rows(iMon).Cells(0).Value
        Dim iTime As Integer = Ichiran.Rows(iMon).Cells(1).Value
        Dim iRow As Integer = iRowStart

        Dim strFolderID As String
        Dim strFolderDate As String
        Dim strFileName As String

        Dim excelApp As New Excel.Application()
        Dim excelBooks As Excel.Workbooks
        Dim excelBook As Excel.Workbook
        Dim sheet As Excel.Worksheet

        strFolderID = (CInt(strBossID) / 100).ToString("000") & "01"
        strFolderDate = Strings.Left(strDate, 4) & "\" & Strings.Mid(strDate, 5, 2)
        strFileName = Strings.Left(strDate, 4) & "-" & Strings.Mid(strDate, 5, 2) & "-" & strTeam & "_月次報告.xlsx"
        strFolder = strDirDoc & strFolderID & "\" & strBossID & "\" & strFolderDate

        If (False = System.IO.File.Exists(strFolder & "\" & strFileName)) Then
            '申請書一覧が無ければ作成（ここには来ないはず）
            System.IO.Directory.CreateDirectory(strFolder)
            System.IO.File.Copy(strDir & strGetsuji, strFolder & "\" & strFileName)
        End If

        excelBooks = excelApp.Workbooks
        excelBook = excelBooks.Open(strFolder & "\" & strFileName)
        sheet = excelApp.Worksheets("sheet1")
        excelApp.Visible = False

        While (sheet.Cells(iRow, "A").value <> "")
            If (strID = sheet.Cells(iRow, "A").value) Then
                sheet.Cells(iRow, "D").value = iTime
                sheet.Cells(iRow, "E").value = DateTime.Today().ToString("yyyyMMdd")
            End If
            iRow += 1
        End While

        excelBook.Save()
        excelApp.Quit()

        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    End Sub

    'Public Sub SaveShiseiInfoKatyo(ShiseiData As Form5_Shiseisyo)
    '    Dim iRow As Integer = iRowStart
    '    Dim strFolderID As String
    '    Dim strFolderDate As String
    '    Dim strFileName As String

    '    Dim excelApp As New Excel.Application()
    '    Dim excelBooks As Excel.Workbooks
    '    Dim excelBook As Excel.Workbook
    '    Dim sheet As Excel.Worksheet

    '    strFolderID = (CInt(ShiseiData.BoxID.Text) / 100).ToString("000") & "01"
    '    strFolderDate = Form5_Shiseisyo.BoxYear.Text & "\" & Form5_Shiseisyo.BoxMonth.Text
    '    strFileName = strFolderID & "-" & Form5_Shiseisyo.BoxYear.Text & Form5_Shiseisyo.BoxMonth.Text & ".xlsx"

    '    strFolder = strDirDoc & strFolderID & "\" & ShiseiData.BoxID.Text & "\" & strFolderDate
    '    If (False = System.IO.File.Exists(strFolder & "\" & strFileName)) Then
    '        System.IO.Directory.CreateDirectory(strFolder)
    '        System.IO.File.Copy(strDir & strIchiran, strFolder & "\" & strFileName)
    '    End If

    '    excelBooks = excelApp.Workbooks
    '    excelBook = excelBooks.Open(strFolder & "\" & strFileName)
    '    sheet = excelApp.Worksheets("sheet1")
    '    excelApp.Visible = False

    '    '保存する
    '    While (sheet.Cells(iRow, "A").value <> ShiseiData.BoxYear.Text & ShiseiData.BoxMonth.Text & ShiseiData.BoxDay.Text)
    '        iRow += 1
    '    End While

    '    'ステート更新
    '    If (0) Then
    '        '差し戻し
    '        sheet.Cells(iRow, "S").value = ShiseiData.strState.Replace("申請", "差し戻し")
    '        sheet.Cells(iRow, "T").value = strID
    '    Else
    '        '承認依頼、承認
    '        sheet.Cells(iRow, "S").value = ShiseiData.strState.Replace("申請", "承認依頼")
    '        sheet.Cells(iRow, "T").value = strBossID
    '    End If
    '    sheet.Cells(iRow, "U").value = DateTime.Today.ToString("yyyyMMdd")

    '    excelBook.Save()
    '    excelApp.Quit()

    '    Call System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
    '    Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook)
    '    Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    'End Sub

    'Sub ins()
    '    Dim xlRows As Excel.Range
    '    Dim xlRow As Excel.Range
    '    Dim xlSheet As Excel.Worksheet

    '    xlRows = xlSheet.Rows
    '    xlRow = DirectCast(xlRows.Item(5), Excel.Range)
    '    xlRow.Insert()
    'End Sub
    'Sub del()
    '    sheet.Range("2:2").EntireRow.Delete(Shift:=Excel.XlDirection.xlUp)
    '    excelBook.Save()
    '    excelApp.Quit()
    'End Sub
End Class

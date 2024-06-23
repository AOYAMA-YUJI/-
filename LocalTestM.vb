Imports Microsoft.Office.Interop

Module LocalTestM
    Const strMeibo As String = "C:\Users\GuestUser\source\repos\ProtoType\resources\Meibo.xlsx"
    Const iRowStart As Integer = 2

    Public strID As String          '社員番号
    Public strName As String        '氏名
    Public strTeam As String        '部署
    Public strRoll As String        '役職
    Public strBossID As String      '上司ID
    Public strPattern As String     '勤務パターン

    Public Sub funcTest1()
        Dim strPath As String = System.Windows.Forms.Application.StartupPath
    End Sub

    Public Sub funcTest2()
        Dim iRow As Integer = iRowStart
        Dim excelApp As New Excel.Application()
        Dim excelBooks As Excel.Workbooks
        Dim excelBook As Excel.Workbook
        Dim sheet As Excel.Worksheet

        excelBooks = excelApp.Workbooks
        excelBook = excelBooks.Open(strMeibo)
        sheet = excelApp.Worksheets("sheet1")
        excelApp.Visible = False

        strName = sheet.Cells(iRow, 1).value

        excelApp.Quit()

        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook)
        Call System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    End Sub

End Module

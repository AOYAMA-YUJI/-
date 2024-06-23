Imports Microsoft.Office.Interop.Excel

Public Class Form2_Shinsei
    Friend iIndex As Integer
    Friend iRowdel As Integer

    Private Sub Form2_Shinsei_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblName.Text = Form1_Login.clsLocaclTest.strName
        ComboBoxMonth.SelectedIndex = 0
        iIndex = ComboBoxMonth.SelectedIndex
    End Sub

    Private Sub Form2_Shinsei_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim iLoop As Integer

        '当月～2ヶ月前の残業申請書、月次報告書を取得
        For iLoop = 0 To 2
            Form1_Login.clsLocaclTest.GetIchiran(DataGridShinsei, DataGridGetsuji, iLoop)
        Next
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        'ログイン画面に戻る。
        Me.Dispose()
        Form1_Login.Show()
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        '残業申請フォームを立ち上げて新規作成。
        Form1_Login.clsDocument.NewDoc(Form1_Login.clsLocaclTest)
        Form5_Shiseisyo.ShowDialog()
    End Sub

    '一覧表の表示月を変更
    Private Sub ComboBoxMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMonth.SelectedIndexChanged
        If iIndex <> ComboBoxMonth.SelectedIndex Then
            '表示変更処理
            iIndex = ComboBoxMonth.SelectedIndex
            Form1_Login.clsLocaclTest.GetIchiran(DataGridShinsei, iIndex)
        End If
    End Sub

    Private Sub DataGridShinsei_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridShinsei.CellContentClick
        '一覧表から申請書を表示
        Dim iRow As Integer = DataGridShinsei.CurrentCell.RowIndex
        Dim iClm As Integer = DataGridShinsei.CurrentCell.ColumnIndex

        If (iClm = 0) Then
            iRowdel = iRow
            Form1_Login.clsDocument.EditDoc(DataGridShinsei, iRow)
            Form5_Shiseisyo.ShowDialog()
        End If
    End Sub

    Private Sub DataGridGetsuji_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridGetsuji.CellContentClick
        Dim iRow As Integer = DataGridGetsuji.CurrentCell.RowIndex
        Dim iClm As Integer = DataGridGetsuji.CurrentCell.ColumnIndex
        If (iClm = 0) Then
            Form1_Login.clsLocaclTest.SendGetsuji(DataGridGetsuji, iRow, Form1_Login.clsLocaclTest.strBossID)
        End If
    End Sub
End Class
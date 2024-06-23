Public Class Form3_Jityou
    Friend iIndex As Integer
    Friend iRowstate As Integer

    Private Sub Form3_Jityou_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelName.Text = Form1_Login.clsLocaclTest.strName
        ComboBoxMonth.SelectedIndex = 0
        iIndex = ComboBoxMonth.SelectedIndex
    End Sub

    Private Sub Form3_Jityou_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        '当月の残業申請書の一覧を取得
        Form1_Login.clsLocaclTest.GetIchiran(DataGridShinsei, 0)
    End Sub

    '一覧表の表示月を変更
    Private Sub ComboBoxMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMonth.SelectedIndexChanged
        If iIndex <> ComboBoxMonth.SelectedIndex Then
            '表示変更処理
            iIndex = ComboBoxMonth.SelectedIndex
            Form1_Login.clsLocaclTest.GetIchiran(DataGridShinsei, iIndex)
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        'ログイン画面に戻る。
        Me.Dispose()
        Form1_Login.Show()
    End Sub

    Private Sub DataGridShinsei_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridShinsei.CellContentClick
        '一覧表から申請書を表示
        Dim iRow As Integer = DataGridShinsei.CurrentCell.RowIndex
        Dim iClm As Integer = DataGridShinsei.CurrentCell.ColumnIndex

        If (iClm = 0) Then
            iRowstate = iRow
            Form1_Login.clsDocument.EditDoc(DataGridShinsei, iRow)
            Form5_Shiseisyo.ShowDialog()
        End If
    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2_Shinsei
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
        Label4 = New Label()
        LblName = New Label()
        ComboBoxMonth = New ComboBox()
        DataGridShinsei = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        Column17 = New DataGridViewTextBoxColumn()
        Column18 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column19 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column21 = New DataGridViewTextBoxColumn()
        Column22 = New DataGridViewTextBoxColumn()
        Column23 = New DataGridViewTextBoxColumn()
        Column24 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column20 = New DataGridViewTextBoxColumn()
        Column25 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        BtnLogout = New Button()
        BtnNew = New Button()
        DataGridGetsuji = New DataGridView()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        CType(DataGridShinsei, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridGetsuji, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI", 32F)
        Label4.Location = New Point(21, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(246, 72)
        Label4.TabIndex = 6
        Label4.Text = "残業申請"
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.Font = New Font("Yu Gothic UI", 14F)
        LblName.Location = New Point(574, 19)
        LblName.Name = "LblName"
        LblName.Size = New Size(168, 32)
        LblName.TabIndex = 5
        LblName.Text = "申請者_社員名"
        ' 
        ' ComboBoxMonth
        ' 
        ComboBoxMonth.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxMonth.FormattingEnabled = True
        ComboBoxMonth.Items.AddRange(New Object() {"当月", "1か月前", "2か月前"})
        ComboBoxMonth.Location = New Point(589, 139)
        ComboBoxMonth.Name = "ComboBoxMonth"
        ComboBoxMonth.Size = New Size(153, 28)
        ComboBoxMonth.TabIndex = 7
        ' 
        ' DataGridShinsei
        ' 
        DataGridShinsei.AllowUserToAddRows = False
        DataGridShinsei.AllowUserToDeleteRows = False
        DataGridShinsei.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridShinsei.Columns.AddRange(New DataGridViewColumn() {Column1, Column11, Column12, Column13, Column2, Column14, Column15, Column16, Column17, Column18, Column3, Column4, Column19, Column5, Column21, Column22, Column23, Column24, Column6, Column20, Column25, Column7})
        DataGridShinsei.Location = New Point(31, 182)
        DataGridShinsei.Name = "DataGridShinsei"
        DataGridShinsei.ReadOnly = True
        DataGridShinsei.RowHeadersWidth = 51
        DataGridShinsei.Size = New Size(711, 114)
        DataGridShinsei.TabIndex = 8
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "２"
        Column1.HeaderText = "残業申請日"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Resizable = DataGridViewTriState.False
        Column1.Width = 125
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "申請者ID"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Visible = False
        Column11.Width = 125
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "申請者氏名"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        Column12.Visible = False
        Column12.Width = 125
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "申請者部署名"
        Column13.MinimumWidth = 6
        Column13.Name = "Column13"
        Column13.ReadOnly = True
        Column13.Visible = False
        Column13.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "勤務パターン"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Resizable = DataGridViewTriState.False
        Column2.Width = 125
        ' 
        ' Column14
        ' 
        Column14.HeaderText = "始業時間"
        Column14.MinimumWidth = 6
        Column14.Name = "Column14"
        Column14.ReadOnly = True
        Column14.Visible = False
        Column14.Width = 125
        ' 
        ' Column15
        ' 
        Column15.HeaderText = "終業時間"
        Column15.MinimumWidth = 6
        Column15.Name = "Column15"
        Column15.ReadOnly = True
        Column15.Visible = False
        Column15.Width = 125
        ' 
        ' Column16
        ' 
        Column16.HeaderText = "前残業開始予定時間"
        Column16.MinimumWidth = 6
        Column16.Name = "Column16"
        Column16.ReadOnly = True
        Column16.Visible = False
        Column16.Width = 125
        ' 
        ' Column17
        ' 
        Column17.HeaderText = "後残業終了予定時間"
        Column17.MinimumWidth = 6
        Column17.Name = "Column17"
        Column17.ReadOnly = True
        Column17.Visible = False
        Column17.Width = 125
        ' 
        ' Column18
        ' 
        Column18.HeaderText = "残業理由"
        Column18.MinimumWidth = 6
        Column18.Name = "Column18"
        Column18.ReadOnly = True
        Column18.Visible = False
        Column18.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "前残業開始時間"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Resizable = DataGridViewTriState.False
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "後残業終了時間"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Resizable = DataGridViewTriState.False
        Column4.Width = 125
        ' 
        ' Column19
        ' 
        Column19.HeaderText = "休憩時間"
        Column19.MinimumWidth = 6
        Column19.Name = "Column19"
        Column19.ReadOnly = True
        Column19.Visible = False
        Column19.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "実残業時間"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Resizable = DataGridViewTriState.False
        Column5.Width = 125
        ' 
        ' Column21
        ' 
        Column21.HeaderText = "残業報告"
        Column21.MinimumWidth = 6
        Column21.Name = "Column21"
        Column21.ReadOnly = True
        Column21.Visible = False
        Column21.Width = 125
        ' 
        ' Column22
        ' 
        Column22.HeaderText = "残業報告日"
        Column22.MinimumWidth = 6
        Column22.Name = "Column22"
        Column22.ReadOnly = True
        Column22.Visible = False
        Column22.Width = 125
        ' 
        ' Column23
        ' 
        Column23.HeaderText = "承認者氏名"
        Column23.MinimumWidth = 6
        Column23.Name = "Column23"
        Column23.ReadOnly = True
        Column23.Visible = False
        Column23.Width = 125
        ' 
        ' Column24
        ' 
        Column24.HeaderText = "承認日"
        Column24.MinimumWidth = 6
        Column24.Name = "Column24"
        Column24.ReadOnly = True
        Column24.Visible = False
        Column24.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "ステート"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Resizable = DataGridViewTriState.False
        Column6.Width = 125
        ' 
        ' Column20
        ' 
        Column20.HeaderText = "ステート先ID1"
        Column20.MinimumWidth = 6
        Column20.Name = "Column20"
        Column20.ReadOnly = True
        Column20.Visible = False
        Column20.Width = 125
        ' 
        ' Column25
        ' 
        Column25.HeaderText = "ステート先ID2"
        Column25.MinimumWidth = 6
        Column25.Name = "Column25"
        Column25.ReadOnly = True
        Column25.Visible = False
        Column25.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "ステート更新日"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Resizable = DataGridViewTriState.False
        Column7.Width = 125
        ' 
        ' BtnLogout
        ' 
        BtnLogout.Location = New Point(593, 71)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(149, 35)
        BtnLogout.TabIndex = 9
        BtnLogout.Text = "ログアウト"
        BtnLogout.UseVisualStyleBackColor = True
        ' 
        ' BtnNew
        ' 
        BtnNew.Location = New Point(31, 141)
        BtnNew.Name = "BtnNew"
        BtnNew.Size = New Size(149, 35)
        BtnNew.TabIndex = 10
        BtnNew.Text = "新規作成"
        BtnNew.UseVisualStyleBackColor = True
        ' 
        ' DataGridGetsuji
        ' 
        DataGridGetsuji.AllowUserToAddRows = False
        DataGridGetsuji.AllowUserToDeleteRows = False
        DataGridGetsuji.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridGetsuji.Columns.AddRange(New DataGridViewColumn() {Column8, Column9, Column10})
        DataGridGetsuji.Location = New Point(31, 325)
        DataGridGetsuji.Name = "DataGridGetsuji"
        DataGridGetsuji.ReadOnly = True
        DataGridGetsuji.RowHeadersWidth = 51
        DataGridGetsuji.Size = New Size(429, 114)
        DataGridGetsuji.TabIndex = 11
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "年月"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "累積残業時間"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 125
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "提出状況"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 125
        ' 
        ' Form2_Shinsei
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(776, 479)
        ControlBox = False
        Controls.Add(DataGridGetsuji)
        Controls.Add(BtnNew)
        Controls.Add(BtnLogout)
        Controls.Add(DataGridShinsei)
        Controls.Add(ComboBoxMonth)
        Controls.Add(Label4)
        Controls.Add(LblName)
        Name = "Form2_Shinsei"
        Text = "残業管理システム"
        CType(DataGridShinsei, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridGetsuji, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents LblName As Label
    Friend WithEvents ComboBoxMonth As ComboBox
    Friend WithEvents DataGridShinsei As DataGridView
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents DataGridGetsuji As DataGridView
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
    Friend WithEvents Column24 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column25 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class

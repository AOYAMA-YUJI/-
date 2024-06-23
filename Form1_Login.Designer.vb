<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnLogin = New Button()
        TextBoxID = New TextBox()
        TextBoxPass = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(280, 212)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(149, 35)
        BtnLogin.TabIndex = 0
        BtnLogin.Text = "ログイン"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Location = New Point(223, 118)
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(287, 27)
        TextBoxID.TabIndex = 1
        ' 
        ' TextBoxPass
        ' 
        TextBoxPass.Location = New Point(223, 161)
        TextBoxPass.Name = "TextBoxPass"
        TextBoxPass.Size = New Size(287, 27)
        TextBoxPass.TabIndex = 2
        TextBoxPass.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(148, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 20)
        Label1.TabIndex = 3
        Label1.Text = "社員番号"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(148, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 4
        Label2.Text = "パスワード"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(143, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 3
        Label3.Text = "社員番号"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(143, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 20)
        Label4.TabIndex = 4
        Label4.Text = "パスワード"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Yu Gothic UI", 32F)
        Label5.Location = New Point(143, 23)
        Label5.Name = "Label5"
        Label5.Size = New Size(413, 72)
        Label5.TabIndex = 14
        Label5.Text = "残業管理システム"
        ' 
        ' Form1_Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(695, 299)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(TextBoxPass)
        Controls.Add(TextBoxID)
        Controls.Add(BtnLogin)
        Name = "Form1_Login"
        Text = "残業管理システム"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class

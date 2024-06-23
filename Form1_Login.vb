Public Class Form1_Login
    Public clsLocaclTest As New LocalTest
    Public clsDocument As New Document

    Private Sub Form1_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            If (True = clsLocaclTest.GetMeiboInfo()) Then
                clsDocument.GetRoll(clsLocaclTest)
                Select Case clsDocument.strRoll
                    Case "一般"
                        Me.Hide()
                        Form2_Shinsei.ShowDialog()
                    Case "次長"
                        Me.Hide()
                        Form3_Jityou.ShowDialog()
                    Case "課長", "部長"
                        Me.Hide()
                        Form4_katyou.ShowDialog()
                    Case Else
                        MsgBox("残業管理システムにアクセスできません", vbCritical)
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class

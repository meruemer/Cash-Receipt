Public Class frm_login

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' connection()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not validateForm() Then Exit Sub 'check empty fields
        Dim login As New cls_login 'initialize class
        Dim usr As String = Trim(txtusername.Text)
        Dim pwd As String = Trim(txtpassword.Text)
        login.userLog(usr, pwd)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
    Public Function validateForm()
        validateForm = False

        If txtpassword.Text = "" Then
            MsgBox("Please enter Username", vbInformation)
            txtusername.Focus()
            Exit Function
        End If

        If txtusername.Text = "" Then
            MsgBox("Please enter Password", vbInformation)
            txtpassword.Focus()
            Exit Function
        End If

        validateForm = True
    End Function
End Class

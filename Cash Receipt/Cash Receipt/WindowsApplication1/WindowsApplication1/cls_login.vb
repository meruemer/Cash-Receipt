Imports System.Data.OleDb
Public Class cls_login
    Public Function userLog(ByVal user As String, ByVal pass As String) As Boolean
        connection()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        sql = "SELECT * from tbl_user WHERE username = @user and password=@pwd"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@user", user)
        cmd.Parameters.AddWithValue("@pwd", pass)

        Dim dr As OleDbDataReader = cmd.ExecuteReader

        If dr.Read() Then
            userLog = True
            MsgBox("Access Granted!", vbExclamation)
            logger = dr("fullName").ToString()
            frm_numberRange.Show()
            frm_login.Hide()
        Else
            userLog = False
            MsgBox("Access Denied!", vbCritical)
            conn.Close()
            Exit Function
        End If

        conn.Close()
    End Function
End Class

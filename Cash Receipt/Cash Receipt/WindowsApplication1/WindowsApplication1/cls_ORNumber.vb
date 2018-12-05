Imports System.Data.OleDb

Public Class cls_ORNumber
    Public lastnum As Double
    Public newnum As Double
    Public Function OR_Number() As Double
        'connection()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        sql = "SELECT MAX(ornumber) as ornumber FROM tbl_receipt"
        cmd = New OleDbCommand(sql, conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        newnum = 0
        If dr.Read Then
            lastnum = CDbl(dr("ornumber").ToString)
            OR_Number = CDbl(lastnum) + 1
        Else
            OR_Number = Double.Parse(newnum) + 1
        End If
        conn.Close()
    End Function
    Public Function isDuplicate(ByVal orn As Double) As Boolean
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        sql = "SELECT ornumber FROM tbl_receipt WHERE ornumber = @orn"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@orn", orn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        If dr.HasRows Then
            isDuplicate = True
        Else
            isDuplicate = False
        End If
    End Function
End Class

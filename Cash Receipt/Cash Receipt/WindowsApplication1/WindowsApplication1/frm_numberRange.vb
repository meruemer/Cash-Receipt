Public Class frm_numberRange
    Dim orn As New cls_ORNumber
    Private Sub frm_numberRange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'connection()

        txtprev.Text = orn.OR_Number()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_receipt.txtor.Text = orn.OR_Number
        frm_receipt.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ornum As Double = Trim(txtnew.Text)

        If orn.isDuplicate(ornum) = True Then
            MsgBox(ornum & " is already in used. Please enter unused OR Number.", vbInformation)
        Else
            frm_receipt.txtor.Text = ornum
            frm_receipt.Show()
            Me.Hide()
        End If
       
    End Sub
End Class
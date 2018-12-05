Public Class frm_receipt
    Dim insert As New cls_receipt
    Dim pm As String
    Dim n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15 As Double
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub frm_receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtofficer.Text = logger
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insert.saveRecord(txtor.Text, txtpayor.Text, lbltime.Text, txtpcode.Text, txtlcode.Text,
                          txtxcode.Text, txtecode.Text, txtocode.Text, txtrcode.Text,
                          txtdcode.Text, txticode.Text, txtopcode.Text, txthcode.Text,
                          txtbcode.Text, txtphcode.Text, txtmcode.Text, txtpfcode.Text,
                          txtotcode.Text, txtpamt.Text, txtlamt.Text,
                          txtxamt.Text, txteamt.Text, txtoamt.Text, txtramt.Text,
                          txtdamt.Text, txtiamt.Text, txtopamt.Text, txthamt.Text,
                          txtbamt.Text, txtphamt.Text, txtmamt.Text, txtpfamt.Text,
                          txtotamt.Text, txttotalamt.Text, txtamtwords.Text, pm, txtbank.Text,
                          txttreasury.Text, txtofficer.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            pm = CheckBox1.Text
        End If
        
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            pm = CheckBox2.Text
        End If
        
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            pm = CheckBox3.Text
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            pm = CheckBox4.Text
        End If
    End Sub
    Private Function NumberToText(ByVal n As Long) As String
        Select Case n
            Case 0
                Return ""
            Case 1 To 19
                Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", _
                                       "Eigth", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", _
                                       "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Return arr(n - 1) & " "
            Case 20 To 99
                Dim arr() As String = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Return arr(n \ 10 - 2) & " " & NumberToText(n Mod 10)
            Case 100 To 199
                Return "One Hundred " & NumberToText(n Mod 100)
            Case 200 To 999
                Return NumberToText(n \ 100) & "Hundred " & NumberToText(n Mod 100)
            Case 1000 To 1999
                Return "One Thousand " & NumberToText(n Mod 1000)
            Case 2000 To 999999
                Return NumberToText(n \ 1000) & "Thousand " & NumberToText(n Mod 1000)
            Case 1000000 To 1999999
                Return "One Million " & NumberToText(n Mod 1000000)
            Case 1000000000 To 1999999999
                Return "One Billion " & NumberToText(n Mod 1000000000)

            Case Else
                Return NumberToText(n \ 1000000000) & "Billion " & NumberToText(n Mod 1000000000)
        End Select


    End Function

    Private Sub txttotalamt_TextChanged(sender As Object, e As EventArgs) Handles txttotalamt.TextChanged
        txtamtwords.Text = NumberToText(txttotalamt.Text) & "Pesos Only"
    End Sub
    Private Sub getTotal()
        txttotalamt.Text = (n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10 + n11 + n12 + n13 + n14 + n15)
    End Sub
  
    Private Sub txtpamt_TextChanged(sender As Object, e As EventArgs) Handles txtpamt.TextChanged
        If txtpamt.Text = "" Then
            n1 = 0
        Else
            n1 = CDbl(txtpamt.Text)
        End If
        getTotal()
    End Sub

    Private Sub txtlamt_TextChanged(sender As Object, e As EventArgs) Handles txtlamt.TextChanged
        If txtlamt.Text = "" Then
            n2 = 0
        Else
            n2 = CDbl(txtlamt.Text)
        End If
        getTotal()
    End Sub

    Private Sub txtxamt_TextChanged(sender As Object, e As EventArgs) Handles txtxamt.TextChanged
        If txtxamt.Text = "" Then
            n3 = 0
        Else
            n3 = CDbl(txtxamt.Text)
        End If
        getTotal()
    End Sub

    Private Sub txteamt_TextChanged(sender As Object, e As EventArgs) Handles txteamt.TextChanged
        If txteamt.Text = "" Then
            n4 = 0
        Else
            n4 = CDbl(txteamt.Text)
        End If
        getTotal()
    End Sub

    Private Sub txtoamt_TextChanged(sender As Object, e As EventArgs) Handles txtoamt.TextChanged
        If txtoamt.Text = "" Then
            n5 = 0
        Else
            n5 = CDbl(txtoamt.Text)
        End If
        getTotal()
    End Sub

    Private Sub txtramt_TextChanged(sender As Object, e As EventArgs) Handles txtramt.TextChanged
        If txtramt.Text = "" Then
            n6 = 0
        Else
            n6 = CDbl(txtramt.Text)
        End If

        getTotal()
    End Sub

    Private Sub txtdamt_TextChanged(sender As Object, e As EventArgs) Handles txtdamt.TextChanged
        If txtdamt.Text = "" Then
            n7 = 0
        Else
            n7 = CDbl(txtdamt.Text)
        End If
        getTotal()
    End Sub

    Private Sub txtiamt_TextChanged(sender As Object, e As EventArgs) Handles txtiamt.TextChanged
        If txtiamt.Text = "" Then
            n8 = 0
        Else
            n8 = CDbl(txtiamt.Text)
        End If
        getTotal()
    End Sub

    Private Sub txtopamt_TextChanged(sender As Object, e As EventArgs) Handles txtopamt.TextChanged
        If txtopamt.Text = "" Then
            n9 = 0
        Else
            n9 = CDbl(txtopamt.Text)
        End If

        getTotal()
    End Sub

    Private Sub txthamt_TextChanged(sender As Object, e As EventArgs) Handles txthamt.TextChanged
        If txthamt.Text = "" Then
            n10 = 0
        Else
            n10 = CDbl(txthamt.Text)
        End If

        getTotal()
    End Sub

    Private Sub txtbamt_TextChanged(sender As Object, e As EventArgs) Handles txtbamt.TextChanged
        If txtbamt.Text = "" Then
            n11 = 0
        Else
            n11 = CDbl(txtbamt.Text)
        End If
        getTotal()
    End Sub

    Private Sub txtphamt_TextChanged(sender As Object, e As EventArgs) Handles txtphamt.TextChanged
        If txtphamt.Text = "" Then
            n12 = 0
        Else
            n12 = CDbl(txtphamt.Text)
        End If
        getTotal()
    End Sub

    Private Sub txtmamt_TextChanged(sender As Object, e As EventArgs) Handles txtmamt.TextChanged
        If txtmamt.Text = "" Then
            n13 = 0
        Else
            n13 = CDbl(txtmamt.Text)
        End If
        getTotal()
    End Sub

    Private Sub txtpfamt_TextChanged(sender As Object, e As EventArgs) Handles txtpfamt.TextChanged
        If txtpfamt.Text = "" Then
            n14 = 0
        Else
            n14 = CDbl(txtpfamt.Text)
        End If
        getTotal()
    End Sub

    Private Sub txtotamt_TextChanged(sender As Object, e As EventArgs) Handles txtotamt.TextChanged
        If txtotamt.Text = "" Then
            n15 = 0
        Else
            n15 = CDbl(txtotamt.Text)
        End If
        getTotal()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click

    End Sub
End Class
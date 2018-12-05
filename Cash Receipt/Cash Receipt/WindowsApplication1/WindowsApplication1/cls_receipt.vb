Imports System.Data.OleDb
Public Class cls_receipt
    Public Function saveRecord(ByVal orno As String, ByVal payor As String, ByVal paydate As String,
                               ByVal pharmacy_code As String, ByVal lab_code As String, ByVal xray_code As String,
                               ByVal ecg_code As String, ByVal ob_code As String, ByVal rehab_code As String,
                               ByVal dent_code As String, ByVal inpat_code As String, ByVal opd_code As String,
                               ByVal healt_code As String, ByVal bac_code As String, ByVal phic_code As String, ByVal main_code As String,
                               ByVal pf_code As String, ByVal oth_code As String,
                               ByVal pharmacy_amt As String, ByVal lab_amt As String, ByVal xray_amt As String,
                               ByVal ecg_amt As String, ByVal ob_amt As String, ByVal rehab_amt As String,
                               ByVal dent_amt As String, ByVal inpat_amt As String, ByVal opd_amt As String,
                               ByVal healt_amt As String, ByVal bac_amt As String, ByVal phic_amt As String, ByVal main_amt As String,
                               ByVal pf_amt As String, ByVal oth_amt As String, ByVal total_amt As String,
                               ByVal amt_in_words As String, ByVal recv_pay As String, ByVal draw_bank As String,
                               ByVal pay_no As String, ByVal col_officer As String) As Boolean

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        sql = "INSERT INTO tbl_receipt (ornumber,payorname,paydate,pharmacy,laboratory,XrayCTScanMRI,ECG,ObUtzOtherUtz,RehabOptha, " & _
                                        "dental ,inpatient, opder, HealthInfoMgnt, bac, phic, maintenance, PF_Withholding, " & _
                                        "OthersSpecify, Pharmacy_Amt,Laboratory_Amt,XrayCTScanMRI_Amt,ECG_Amt,OBUTZOtherUTZ_Amt, " & _
                                        "RehabOptha_Amt, Dental_Amt, InPatient_Amt,OPDER_Amt,HealthInfoMgnt_Amt,BAC_Amt,PHIC_Amt, " & _
                                        "Maintenace_Amt,PFWithholdingTax_Amt,Other_Specify_Amt,Total_Amount,Amt_in_words,Received_Payment, " & _
                                        "Payment_Number,Drawee_Bank,Collecting_Officer) " & _
                                        "VALUES " & _
                                        "(@or,@pn,@pd,@pm,@lab,@xra,@ecg,@obu,@reh,@den,@inp,@opd,@hif,@bac,@phi,@mai,@pfw,@osf, " & _
                                        "@pm_amt,@lab_amt,@xra_amt,@ecg_amt,@obu_amt,@reh_amt,@den_amt,@inp_amt,@opd_amt,@hif_amt,@bac_amt,@phi_amt,@mai_amt,@pfw_amt,@osf_amt, " & _
                                        "@tot_amt,@aiw,@rp,@pno,@dbnk,@clo)"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@or", orno)
        cmd.Parameters.AddWithValue("@pn", payor)
        cmd.Parameters.AddWithValue("@pd", paydate)
        cmd.Parameters.AddWithValue("@pm", pharmacy_code)
        cmd.Parameters.AddWithValue("@lab", lab_code)
        cmd.Parameters.AddWithValue("@xra", xray_code)
        cmd.Parameters.AddWithValue("@ecg", ecg_code)
        cmd.Parameters.AddWithValue("@obu", ob_code)
        cmd.Parameters.AddWithValue("@reh", rehab_code)
        cmd.Parameters.AddWithValue("@den", dent_code)
        cmd.Parameters.AddWithValue("@inp", inpat_code)
        cmd.Parameters.AddWithValue("@opd", opd_code)
        cmd.Parameters.AddWithValue("@hif", healt_code)
        cmd.Parameters.AddWithValue("@bac", bac_code)
        cmd.Parameters.AddWithValue("@phi", phic_code)
        cmd.Parameters.AddWithValue("@mai", main_code)
        cmd.Parameters.AddWithValue("@pfw", pf_code)
        cmd.Parameters.AddWithValue("@osf", oth_code)
        cmd.Parameters.AddWithValue("@pm_amt", pharmacy_amt)
        cmd.Parameters.AddWithValue("@lab_amt", lab_amt)
        cmd.Parameters.AddWithValue("@xra_amt", xray_amt)
        cmd.Parameters.AddWithValue("@ecg_amt", ecg_amt)
        cmd.Parameters.AddWithValue("@obu_amt", ob_amt)
        cmd.Parameters.AddWithValue("@reh_amt", rehab_amt)
        cmd.Parameters.AddWithValue("@den_amt", dent_amt)
        cmd.Parameters.AddWithValue("@inp_amt", inpat_amt)
        cmd.Parameters.AddWithValue("@opd_amt", opd_amt)
        cmd.Parameters.AddWithValue("@hif_amt", healt_amt)
        cmd.Parameters.AddWithValue("@bac_amt", bac_amt)
        cmd.Parameters.AddWithValue("@phi_amt", phic_amt)
        cmd.Parameters.AddWithValue("@mai_amt", main_amt)
        cmd.Parameters.AddWithValue("@pfw_amt", pf_amt)
        cmd.Parameters.AddWithValue("@osf_amt", oth_amt)
        cmd.Parameters.AddWithValue("@tot_amt", total_amt)
        cmd.Parameters.AddWithValue("@aiw", amt_in_words)
        cmd.Parameters.AddWithValue("@rp", recv_pay)
        cmd.Parameters.AddWithValue("@pno", pay_no)
        cmd.Parameters.AddWithValue("@dbnk", draw_bank)
        cmd.Parameters.AddWithValue("@clo", col_officer)

        If cmd.ExecuteNonQuery > 0 Then
            saveRecord = True
            MsgBox("Payment has been saved!", vbExclamation)
        Else
            saveRecord = False
            MsgBox("Payment failed!", vbExclamation)
        End If

    End Function
End Class

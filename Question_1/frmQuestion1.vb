REM EXAMINATION MARKING GUIDELINE
REM EXAMINATION NUMBER:____________
REM WORKSTATION NUMBER:____________
REM EXAMINATION   DATE:____________

Option Explicit On
Option Strict On


Public Class frmQuestion1
    'Global Variable(s)
    Dim strIdentityNumber As String
    Dim strMembershipNumber As String
    Dim intPoints As Integer

    Private Sub txtIdNumber_TextChanged(sender As Object, e As EventArgs) Handles txtIdNumber.TextChanged
        txtIdNumber.BackColor = Color.White
    End Sub
	
    Private Sub btnQuestion1_1_Click(sender As Object, e As EventArgs) Handles btnQuestion1_1.Click
        If txtIdNumber.Text = "" Then
            txtIdNumber.BackColor = Color.Red
            txtIdNumber.Focus()
            Exit Sub
        End If
        If IsNumeric(txtIdNumber.Text) = True Then
            If txtIdNumber.TextLength <> 13 Then


                MsgBox("That identity number is incorrect")
                txtIdNumber.Clear()
                txtIdNumber.Focus()
            Else
                strIdentityNumber = txtIdNumber.Text
                If txtFirstName.TextLength <= 1 And txtSurname.TextLength <= 1 Then
                    MsgBox("Either your name or surname does not contain enough charecters")
                End If
        End If
       
        End If
        lblDisplayCustInfo.Text = "Dear " & txtFirstName.Text & " " & txtSurname.Text & vbCrLf & "Welcome to mzansi Superstore's loyalty programme"
    End Sub

    Private Sub grpQuestion1_2_Enter(sender As Object, e As EventArgs) Handles grpQuestion1_2.Enter

    End Sub

    Private Sub radStandAlone_CheckedChanged(sender As Object, e As EventArgs) Handles radStandAlone.CheckedChanged

        If radStandAlone.Checked = True Then
            intPoints = 1000
        End If
    End Sub

    Private Sub radMultiPartner_CheckedChanged(sender As Object, e As EventArgs) Handles radMultiPartner.CheckedChanged
        If radMultiPartner.Checked = True Then
            intPoints = 500
        End If
    End Sub

    Private Sub btnQuestion1_3_Click(sender As Object, e As EventArgs) Handles btnQuestion1_3.Click
       
        lblDisplayPoints.Text = "Dear customer, you have accumulated " & ((CInt(txtTotalAmount.Text) / 5) + intPoints).ToString & "Points"


        End Sub

    Private Sub frmQuestion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnQuestion1_4_Click(sender As Object, e As EventArgs) Handles btnQuestion1_4.Click
        Dim strLoyaltytype As String = " "
        'start with the fist part
        If chkLoyaltyCard.Checked = True Then
            If radStandAlone.Checked = True Then
                strLoyaltytype = "S"
            ElseIf radMultiPartner.Checked = True Then
                strLoyaltytype = "M"
            End If
        End If
        ' strIdentityNumber.Substring(0, 6)
        'second part
        Dim strCurrentdate As String = Now.ToString("dd/mmy/yyyy")
        'output
        lblDisplayMembershipNumber.Text = strLoyaltytype & strIdentityNumber.Substring(0, 6) & strCurrentdate
    End Sub
End Class

Imports System.Data.OleDb
Imports System.Data
Imports System.ComponentModel

Public Class change_pass
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB Project\database\School_Management_System.mdb")
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim j As Integer = 0
        con.Open()
        If txt_cpass.Text = "" Then
            MessageBox.Show("Enter Details First !!")
        Else
            da = New OleDbDataAdapter("select * from tbl_s_reg where enrollment_no = " + Login.ids.ToString() + "", con)
            ds = New DataSet
            da.Fill(ds)

            If j <> ds.Tables(0).Rows(0)(0).ToString() Then
                If ValidateChildren(ValidationConstraints.Enabled) Then
                    If txt_pass.Text = txt_cpass.Text Then
                        txt_en.Text = ds.Tables(0).Rows(0)(0).ToString()
                        cmd = New OleDbCommand("update tbl_s_reg set pass = '" + txt_pass.Text + "' where enrollment_no = " + txt_en.Text + "", con)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Password Changed...")
                        Login.Show()
                        Me.Close()
                    Else
                        MessageBox.Show("Password Does Not Matched !!")
                        txt_cpass.Focus()
                    End If
                End If
            Else
                MessageBox.Show("Enrollment Not Correct !!")
            End If
        End If
        con.Close()
    End Sub

    Private Sub Logout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        da = New OleDbDataAdapter("select * from tbl_s_reg where enrollment_no = " + Login.ids.ToString() + "", con)
        ds = New DataSet
        da.Fill(ds)

        txt_en.Text = ds.Tables(0).Rows(0)(0).ToString()
        con.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are You Sure Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txt_cpass_TextChanged(sender As Object, e As EventArgs) Handles txt_cpass.TextChanged
        If txt_pass.Text <> "" And txt_pass.Text = txt_cpass.Text Then
            ep_cpass.SetError(txt_cpass, "")
        Else
            ep_cpass.SetError(txt_cpass, "Password Does Not Matched !")
            txt_cpass.Focus()
        End If
    End Sub
End Class
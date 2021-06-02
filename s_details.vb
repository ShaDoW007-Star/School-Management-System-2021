Imports System.Data.OleDb
Imports System.Data
Imports System.ComponentModel
Public Class s_details
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB Project\database\School_Management_System.mdb")
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MessageBox.Show("Are You Sure Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Admin_Panel.result = 0
            Staff_Panel.result = 0
            Me.Close()
            clr()
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim gen As String = ""
        If rb_male.Checked = True Then
            gen = "Male"
        ElseIf rb_female.Checked = True Then
            gen = "Female"
        End If

        con.Open()
        If txt_lname.Text = "" Then
            MessageBox.Show("Enter Details First...")
        Else
            cmd = New OleDbCommand("update tbl_s_reg set first_name = '" + txt_fname.Text + "' ,last_name = '" + txt_lname.Text + "',address = '" + txt_add.Text + "',standard = '" + cb_standard.Text + "',gender = '" + gen + "',dob = '" + txt_dob.Text + "',contact_no = '" + txt_cn.Text + "',addmission_date = '" + txt_ad.Text + "' where enrollment_no = " + txt_en.Text + "", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update Successfully....")
            clr()
            val()
        End If
        con.Close()
    End Sub

    Private Sub s_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Staff_Panel.result = 1
        da = New OleDbDataAdapter("select * from tbl_standard", con)
        ds = New DataSet
        da.Fill(ds)

        cb_standard.DataSource = ds.Tables(0)
        cb_standard.DisplayMember = "name"
        cb_standard.ValueMember = "id"

        Admin_Panel.result = 1
        txt_fname.Enabled = False
        txt_lname.Enabled = False
        txt_add.Enabled = False
        cb_standard.Enabled = False
        txt_dob.Enabled = False
        txt_cn.Enabled = False
        txt_ad.Enabled = False
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim gender As String = ""
        Dim j As Integer = 0
        If txt_en.Text = "" Then
            MessageBox.Show("Enter Enrollment No !")
        Else
            con.Open()
            da = New OleDbDataAdapter("select * from tbl_s_reg where enrollment_no = " + txt_en.Text + "", con)
            ds = New DataSet
            da.Fill(ds)

            If j <> ds.Tables(0).Rows.Count.ToString() Then

                txt_fname.Text = ds.Tables(0).Rows(0)(1).ToString()
                txt_lname.Text = ds.Tables(0).Rows(0)(2).ToString()
                txt_add.Text = ds.Tables(0).Rows(0)(3).ToString()
                cb_standard.Text = ds.Tables(0).Rows(0)(4).ToString()
                gender = ds.Tables(0).Rows(0)(5).ToString()
                txt_dob.Text = ds.Tables(0).Rows(0)(6).ToString()
                txt_cn.Text = ds.Tables(0).Rows(0)(7).ToString()
                txt_ad.Text = ds.Tables(0).Rows(0)(8).ToString()

                txt_en.Enabled = False
                txt_fname.Enabled = True
                txt_lname.Enabled = True
                txt_add.Enabled = True
                cb_standard.Enabled = True
                txt_dob.Enabled = True
                txt_cn.Enabled = True
                txt_ad.Enabled = True
            Else
                MessageBox.Show("No data Found !")
                txt_en.Focus()
            End If
        End If
            If gender = "Male" Then
            rb_male.Checked = True
        ElseIf gender = "Female" Then
            rb_female.Checked = True
        End If

        con.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        con.Open()
        If txt_lname.Text = "" Then
            MessageBox.Show("Enter Detail First !")
        Else
            cmd = New OleDbCommand("delete from tbl_s_reg where enrollment_no = " + txt_en.Text + "", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Delete Successfully....")
            clr()
            val()
        End If
        con.Close()
    End Sub

    Public Sub clr()
        'Dim g As String = ""
        txt_en.Clear()
        txt_fname.Clear()
        txt_lname.Clear()
        txt_add.Clear()
        rb_male.Checked = False
        rb_female.Checked = False
        cb_standard.Text = "--Please Select--"
        cb_standard.Enabled = False
        txt_dob.Clear()
        txt_cn.Clear()
        txt_ad.Clear()
        'If rb_male.Text = "Male" Then
        'rb_male.Checked = False
        ' ElseIf rb_female.Text = "Female" Then
        'rb_female.Checked = False
        ' End If
    End Sub

    Public Sub val()
        txt_en.Enabled = True
        txt_en.Focus()
        txt_fname.Enabled = False
        txt_lname.Enabled = False
        txt_add.Enabled = False
        txt_dob.Enabled = False
        txt_cn.Enabled = False
        txt_ad.Enabled = False
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        clr()
        val()
    End Sub
End Class
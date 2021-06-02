Imports System.Data.OleDb
Imports System.Data
Public Class st_details
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB Project\database\School_Management_System.mdb")
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Public work As String
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MessageBox.Show("Are You Sure Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            Admin_Panel.result = 0
        End If
    End Sub

    Private Sub st_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Admin_Panel.result = 1
        da = New OleDbDataAdapter("select * from tbl_work", con)
        ds = New DataSet
        da.Fill(ds)

        cb_work.DataSource = ds.Tables(0)
        cb_work.DisplayMember = "name"
        cb_work.ValueMember = "id"

        'If cb_work.Text = "--Please Select--" Then
        'txt_salary.Text = ""
        ' End If

        ' If cb_work.Text = "Teacher / Sir" Then
        'txt_salary.Text = "50000"
        'End If

        'If cb_work.Text = "Supervisor" Then
        'txt_salary.Text = "20000"
        ' End If

        txt_fname.Enabled = False
        txt_lname.Enabled = False
        txt_add.Enabled = False
        txt_dob.Enabled = False
        txt_cn.Enabled = False
        txt_qualification.Enabled = False
        cb_work.Enabled = False
        txt_salary.Enabled = False
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim gender As String = ""

        Dim j As Integer = 0
        If txt_rgn.Text = "" Then
            MessageBox.Show("Enter Register No !")
        Else
            con.Open()
            da = New OleDbDataAdapter("select * from tbl_st_reg where register_no =  " + txt_rgn.Text + "", con)
            ds = New DataSet
            da.Fill(ds)

            If j <> ds.Tables(0).Rows.Count.ToString() Then

                txt_fname.Text = ds.Tables(0).Rows(0)(1).ToString()
                txt_lname.Text = ds.Tables(0).Rows(0)(2).ToString()
                txt_add.Text = ds.Tables(0).Rows(0)(3).ToString()
                gender = ds.Tables(0).Rows(0)(4).ToString()
                txt_dob.Text = ds.Tables(0).Rows(0)(5).ToString()
                txt_cn.Text = ds.Tables(0).Rows(0)(6).ToString()
                txt_qualification.Text = ds.Tables(0).Rows(0)(7).ToString()
                cb_work.Text = ds.Tables(0).Rows(0)(8).ToString()
                txt_salary.Text = ds.Tables(0).Rows(0)(9).ToString()

                txt_rgn.Enabled = False
                txt_fname.Enabled = True
                txt_lname.Enabled = True
                txt_add.Enabled = True
                txt_dob.Enabled = True
                txt_cn.Enabled = True
                txt_qualification.Enabled = True
                cb_work.Enabled = True
                txt_salary.Enabled = True
                txt_fname.Focus()
            Else
                MessageBox.Show("No data Found !")
                txt_rgn.Focus()
            End If
        End If
        If gender = "Male" Then
            rb_male.Checked = True
        ElseIf gender = "Female" Then
            rb_female.Checked = True
        End If

        con.Close()
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
            cmd = New OleDbCommand("update tbl_st_reg set first_name = '" + txt_fname.Text + "' ,last_name = '" + txt_lname.Text + "',address = '" + txt_add.Text + "',gender = '" + gen + "',dob = '" + txt_dob.Text + "',contact_no = '" + txt_cn.Text + "',qualification = '" + txt_qualification.Text + "',type_of_work = '" + cb_work.Text + "',salary = " + txt_salary.Text + " where register_no = " + txt_rgn.Text + "", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update Successfully....")
            clr()
            val()
        End If
        con.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        con.Open()
        If txt_lname.Text = "" Then
            MessageBox.Show("Enter Detail First !")
        Else
            cmd = New OleDbCommand("delete from tbl_st_reg where register_no = " + txt_rgn.Text + "", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Delete Successfully....")
            clr()
            val()
        End If
        con.Close()
    End Sub

    Public Sub clr()
        ' Dim g As String = ""
        txt_rgn.Clear()
        txt_fname.Clear()
        txt_lname.Clear()
        txt_add.Clear()
        rb_male.Checked = False
        rb_female.Checked = False
        txt_dob.Clear()
        txt_cn.Clear()
        txt_qualification.Clear()
        cb_work.Text = "--Please Select--"
        txt_salary.Clear()
        'If rb_male.Text = "Male" Then
        ' rb_male.Checked = False
        ' ElseIf rb_female.Text = "Female" Then
        '    rb_female.Checked = False
        ' End If
    End Sub

    Public Sub val()
        txt_rgn.Enabled = True
        txt_rgn.Focus()
        txt_fname.Enabled = False
        txt_lname.Enabled = False
        txt_add.Enabled = False
        txt_dob.Enabled = False
        txt_cn.Enabled = False
        txt_qualification.Enabled = False
        cb_work.Enabled = False
        txt_salary.Enabled = False
    End Sub

    Private Sub cb_work_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_work.SelectedIndexChanged

        If cb_work.Text = "--Please Select--" Then
            txt_salary.Text = ""
        End If

        If cb_work.Text = "Teacher / Sir" Then
            txt_salary.Text = "50000"
        End If

        If cb_work.Text = "Supervisor" Then
            txt_salary.Text = "20000"
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        clr()
        val()
    End Sub
End Class
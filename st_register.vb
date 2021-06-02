Imports System.Data.OleDb
Imports System.Data
Imports System.ComponentModel
Public Class st_register
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB Project\database\School_Management_System.mdb")
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MessageBox.Show("Are You Sure Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            Admin_Panel.result = 0
        End If
    End Sub

    Private Sub st_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        da = New OleDbDataAdapter("select * from tbl_work", con)
        ds = New DataSet
        da.Fill(ds)

        cb_work.DataSource = ds.Tables(0)
        cb_work.DisplayMember = "name"
        cb_work.ValueMember = "id"
        con.Close()
        Admin_Panel.result = 1
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gender As String = ""
        Dim d As Integer
        Dim j As Integer = 1
        If rb_male.Checked = True Then
            gender = "Male"
        ElseIf rb_female.Checked = True Then
            gender = "Female"
        End If
        con.Open()

        If ValidateChildren(ValidationConstraints.Enabled) Then
            If IsNumeric(txt_rgn.Text) Then
                ep_rgn.SetError(txt_rgn, "")
                If IsNumeric(txt_cn.Text) Then
                    ep_cn.SetError(txt_cn, "")
                    da = New OleDbDataAdapter("select * from tbl_st_reg where register_no = " + txt_rgn.Text + "", con)
                    ds = New DataSet
                    da.Fill(ds)
                    d = ds.Tables(0).Rows.Count.ToString()

                    If d <> j Then
                        cmd = New OleDbCommand("insert into tbl_st_reg (register_no,first_name,last_name,address,gender,dob,contact_no,qualification,type_of_work,salary,pass) values(" + txt_rgn.Text + ",'" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_add.Text + "','" + gender + "','" + dtp_dob.Text + "'," + txt_cn.Text + ",'" + txt_qualification.Text + "','" + cb_work.Text + "'," + txt_salary.Text + ",'" + txt_cn.Text + "')", con)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Insert SuccessFully....")
                        clr()
                    Else
                        MessageBox.Show("Data Already Filled...!!! Please Use Diffrent Enrollment...", "Data")
                    End If
                Else
                    ep_cn.SetError(txt_cn, "Enter Numeric Value !")
                    'Admin_Panel.result = 0
                End If
            Else
                ep_rgn.SetError(txt_rgn, "Enter Numeric Value !")
            End If
        End If
        con.Close()
    End Sub

    Private Sub txt_rgn_Validating(sender As Object, e As CancelEventArgs) Handles txt_rgn.Validating
        If String.IsNullOrEmpty(txt_rgn.Text) Then
            e.Cancel = True
            txt_rgn.Focus()
            ep_rgn.SetError(txt_rgn, "Enter Register No !")
        Else
            e.Cancel = False
            ep_rgn.SetError(txt_rgn, "")
        End If
    End Sub

    Private Sub txt_fname_Validating(sender As Object, e As CancelEventArgs) Handles txt_fname.Validating
        If String.IsNullOrEmpty(txt_fname.Text) Then
            e.Cancel = True
            txt_fname.Focus()
            ep_fname.SetError(txt_fname, "Enter First Name !")
        Else
            e.Cancel = False
            ep_fname.SetError(txt_fname, "")
        End If
    End Sub

    Private Sub txt_lname_Validating(sender As Object, e As CancelEventArgs) Handles txt_lname.Validating
        If String.IsNullOrEmpty(txt_lname.Text) Then
            e.Cancel = True
            txt_lname.Focus()
            ep_lname.SetError(txt_lname, "Enter Last Name !")
        Else
            e.Cancel = False
            ep_lname.SetError(txt_lname, "")
        End If
    End Sub

    Private Sub txt_add_Validating(sender As Object, e As CancelEventArgs) Handles txt_add.Validating
        If String.IsNullOrEmpty(txt_add.Text) Then
            e.Cancel = True
            txt_add.Focus()
            ep_add.SetError(txt_add, "Enter Address !")
        Else
            e.Cancel = False
            ep_add.SetError(txt_add, "")
        End If
    End Sub

    Private Sub txt_cn_Validating(sender As Object, e As CancelEventArgs) Handles txt_cn.Validating
        If String.IsNullOrEmpty(txt_cn.Text) Then
            e.Cancel = True
            txt_cn.Focus()
            ep_cn.SetError(txt_cn, "Enter Contact No")
        Else
            e.Cancel = False
            ep_cn.SetError(txt_cn, "")
        End If
    End Sub

    Private Sub txt_qualification_Validating(sender As Object, e As CancelEventArgs) Handles txt_qualification.Validating
        If String.IsNullOrEmpty(txt_qualification.Text) Then
            e.Cancel = True
            txt_qualification.Focus()
            ep_qualification.SetError(txt_qualification, "Enter Qualification !")
        Else
            e.Cancel = False
            ep_qualification.SetError(txt_qualification, "")
        End If
    End Sub
    Public Sub clr()
        ' Dim g As String = ""
        txt_rgn.Clear()
        txt_fname.Clear()
        txt_lname.Clear()
        txt_add.Clear()
        rb_female.Checked = False
        rb_male.Checked = False
        txt_cn.Clear()
        txt_qualification.Clear()
        txt_salary.Clear()
        cb_work.Text = "--Please Select--"
        'If rb_male.Text = "Male" Then
        'rb_male.Checked = False
        ' ElseIf rb_female.Text = "Female" Then
        'rb_female.Checked = False
        ' End If
    End Sub
End Class
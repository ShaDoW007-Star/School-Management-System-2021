Imports System.Data.OleDb
Imports System.Data
Imports System.ComponentModel
Public Class S_Register
    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB Project\database\School_Management_System.mdb")
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim gender As String = ""
        Dim d As Integer
        Dim j As Integer = 1

        If rb_male.Checked = True Then
            gender = "Male"
        ElseIf rb_female.Checked = True Then
            gender = "Female"
        End If

        If ValidateChildren(ValidationConstraints.Enabled) Then
            If IsNumeric(txt_en.Text) Then
                ep_en.SetError(txt_en, "")
                If IsNumeric(txt_cn.Text) Then
                    ep_cn.SetError(txt_cn, "")
                    da = New OleDbDataAdapter("select * from tbl_s_reg where enrollment_no = " + txt_en.Text + "", con)
                    ds = New DataSet
                    da.Fill(ds)

                    d = ds.Tables(0).Rows.Count.ToString()

                    If j <> d Then

                        con.Open()
                        cmd = New OleDbCommand("insert into tbl_s_reg values(" + txt_en.Text + ",'" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_add.Text + "','" + cb_standard.Text + "','" + gender + "','" + dtp_dob.Text + "'," + txt_cn.Text + ",'" + dtp_ad.Text + "','" + txt_cn.Text + "')", con)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Insert Successfully....")
                        clr()

                    Else
                        MessageBox.Show("Data Already Filled...!!! Please Use Diffrent Enrollment...", "Data")
                    End If
                Else
                    ep_cn.SetError(txt_cn, "Enter Numeric Value !")
                    con.Close()
                End If
            Else
                ep_en.SetError(txt_en, "Enter Numeric Value !")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are You Sure Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Admin_Panel.result = 0
            Me.Close()
        End If
    End Sub

    Private Sub S_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()

        da = New OleDbDataAdapter("select * from tbl_standard", con)
        ds = New DataSet
        da.Fill(ds)

        cb_standard.DataSource = ds.Tables(0)
        cb_standard.DisplayMember = "name"
        cb_standard.ValueMember = "id"

        con.Close()


        Admin_Panel.result = 1
    End Sub

    Private Sub txt_en_Validating(sender As Object, e As CancelEventArgs) Handles txt_en.Validating
        If String.IsNullOrEmpty(txt_en.Text) Then
            e.Cancel = True
            txt_en.Focus()
            ep_en.SetError(txt_en, "Enter Enrollment No !")
        Else
            e.Cancel = False
            ep_en.SetError(txt_en, "")
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
            ep_cn.SetError(txt_cn, "Enter Contact No !")
        Else
            e.Cancel = False
            ep_cn.SetError(txt_cn, "")
        End If
    End Sub

    Public Sub clr()
        ' Dim g As String = ""
        txt_en.Clear()
        txt_fname.Clear()
        txt_lname.Clear()
        txt_add.Clear()
        rb_female.Checked = False
        rb_male.Checked = False
        txt_cn.Clear()
        cb_standard.Text = "--Please Select--"
        'If rb_male.Text = "Male" Then
        'rb_male.Checked = False
        ' ElseIf rb_female.Text = "Female" Then
        'rb_female.Checked = False
        ' End If
    End Sub
End Class
Imports System.Data.OleDb
Imports System.Data
Imports System.ComponentModel
Public Class s_s_details
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB Project\database\School_Management_System.mdb")
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand

    Private Sub s_s_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gender As String = ""
        Dim j As Integer = 0
        da = New OleDbDataAdapter("select * from tbl_standard", con)
        ds = New DataSet
        da.Fill(ds)

        cb_standard.DataSource = ds.Tables(0)
        cb_standard.DisplayMember = "name"
        cb_standard.ValueMember = "id"

        txt_en.Enabled = False
        Student_Panel.result = 1
        con.Open()
        da = New OleDbDataAdapter("select * from tbl_s_reg where enrollment_no = " + Login.ids.ToString() + "", con)
        ds = New DataSet
            da.Fill(ds)

        If j <> ds.Tables(0).Rows.Count.ToString() Then
            txt_en.Text = ds.Tables(0).Rows(0)(0).ToString()
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
            txt_dob.Enabled = True
            txt_cn.Enabled = True
            txt_ad.Enabled = True
        Else
            MessageBox.Show("No data Found !")
            txt_en.Focus()
        End If
        If gender = "Male" Then
            rb_male.Checked = True
        ElseIf gender = "Female" Then
            rb_female.Checked = True
        End If

        con.Close()
    End Sub

    Public Sub clr()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are You Sure Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Student_Panel.result = 0
            Me.Close()
        End If
    End Sub
End Class
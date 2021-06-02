Imports System.Data.OleDb
Imports System.Data
Public Class Login
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB Project\database\School_Management_System.mdb")
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Public ids As Integer
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        '---------------------------------------------------------ADMIN------------------------------------------------------------------

        If cb_user.Text = "Admin" Then
            val()
            If txt_username.Text = "admin" Then
                If txt_pass.Text = "admin" Then
                    Me.Hide()
                    Admin_Panel.Show()
                Else
                    MessageBox.Show("Wrong Password !")
                End If
            Else
                MessageBox.Show("Wrong Username !")
            End If
        End If

        '---------------------------------------------------------STAFF------------------------------------------------------------------

        If cb_user.Text = "Staff" Then
            Dim j As Integer = 0
            con.Open()
            da = New OleDbDataAdapter("select * from tbl_st_reg where register_no = " + txt_username.Text + " and contact_no = " + txt_pass.Text + "", con)
            ds = New DataSet
            da.Fill(ds)

            If j <> ds.Tables(0).Rows.Count.ToString() Then
                Staff_Panel.Show()
            Else
                MessageBox.Show("Incorrect Username And Password !!")
            End If
            con.Close()
            End If

        '---------------------------------------------------------STUDENT------------------------------------------------------------------

        If cb_user.Text = "Student" Then
            Dim j As Integer = 0
            con.Open()
                da = New OleDbDataAdapter("select * from tbl_s_reg where enrollment_no = " + txt_username.Text + " and pass = '" + txt_pass.Text + "'", con)
                ds = New DataSet
                da.Fill(ds)

            If j <> ds.Tables(0).Rows.Count.ToString() Then
                ids = Convert.ToInt32(ds.Tables(0).Rows(0)(0).ToString())
                ids = ds.Tables(0).Rows(0)(0).ToString()
                Student_Panel.Show()
            Else
                MessageBox.Show("Incorrect Username And Password !!")
            End If
            con.Close()
        End If

    End Sub
    Public Sub val()
        If txt_username.Text = "" Then
            MessageBox.Show("Empty Username !")
            If txt_pass.Text = "" Then
                MessageBox.Show("Empty Password !")
            End If
        End If
    End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        da = New OleDbDataAdapter("select * from tbl_user", con)
        ds = New DataSet
        da.Fill(ds)

        cb_user.DataSource = ds.Tables(0)
        cb_user.DisplayMember = "Name"
        cb_user.ValueMember = "id"
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are You Sure Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Admin_Panel.result = 0
            Me.Close()
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        change_pass.Show()
    End Sub
End Class

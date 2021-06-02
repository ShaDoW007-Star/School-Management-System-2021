Imports System.Data
Imports System.Data.OleDb
Public Class marks_show
    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB Project\database\School_Management_System.mdb")
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Private Sub marks_show_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_en.Enabled = True
        txt_en.Focus()
        txt_guj.Enabled = False
        txt_hindi.Enabled = False
        txt_maths.Enabled = False
        txt_san.Enabled = False
        txt_science.Enabled = False
        txt_ss.Enabled = False
        txt_eng.Enabled = False
        txt_per.Enabled = False
        txt_tm.Enabled = False
        Staff_Panel.result = 1
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        con.Open()
        If txt_hindi.Text = "" Then
            MessageBox.Show("Enter Details First...")
        Else
            cmd = New OleDbCommand("update tbl_marks set gujarati = '" + txt_guj.Text + "',hindi = '" + txt_hindi.Text + "',maths = '" + txt_maths.Text + "',english = '" + txt_eng.Text + "',science = '" + txt_science.Text + "',ss = '" + txt_ss.Text + "',sanskrit = '" + txt_san.Text + "' where enrollment_no = " + txt_en.Text + "", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Update SuccessFully....")
            clr()
            val()
        End If
        con.Close()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim j As Integer = 0
        Dim tot As Integer
        Dim en As Integer
        Dim g As Integer
        Dim m As Integer
        Dim s As Integer
        Dim ss As Integer
        Dim san As Integer
        Dim h As Integer
        Dim per As String
        con.Open()
        If txt_en.Text = "" Then
            MessageBox.Show("Enter Enrollment No !")
        Else
            da = New OleDbDataAdapter("select * from tbl_marks where enrollment_no = " + txt_en.Text + "", con)
            ds = New DataSet
            da.Fill(ds)

            If j <> ds.Tables(0).Rows.Count.ToString() Then
                txt_guj.Text = ds.Tables(0).Rows(0)(1).ToString()
                txt_hindi.Text = ds.Tables(0).Rows(0)(2).ToString()
                txt_maths.Text = ds.Tables(0).Rows(0)(3).ToString()
                txt_eng.Text = ds.Tables(0).Rows(0)(4).ToString()
                txt_science.Text = ds.Tables(0).Rows(0)(5).ToString()
                txt_ss.Text = ds.Tables(0).Rows(0)(6).ToString()
                txt_san.Text = ds.Tables(0).Rows(0)(7).ToString()

                en = txt_eng.Text
                g = txt_guj.Text
                h = txt_hindi.Text
                s = txt_science.Text
                ss = txt_ss.Text
                san = txt_san.Text
                m = txt_maths.Text


                tot = en + g + h + s + ss + san + m
                txt_tm.Text = tot

                per = (tot * 100) / 700
                txt_per.Text = per + "%"


                txt_en.Enabled = False
                txt_guj.Enabled = True
                txt_hindi.Enabled = True
                txt_maths.Enabled = True
                txt_san.Enabled = True
                txt_science.Enabled = True
                txt_ss.Enabled = True
                txt_eng.Enabled = True
                txt_tm.Enabled = True
                txt_per.Enabled = True
            Else
                MessageBox.Show("No data Found !")
                txt_en.Focus()
            End If
        End If
        con.Close()

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        clr()
        val()
    End Sub

    Public Sub clr()
        txt_en.Clear()
        txt_eng.Clear()
        txt_guj.Clear()
        txt_hindi.Clear()
        txt_maths.Clear()
        txt_san.Clear()
        txt_science.Clear()
        txt_ss.Clear()
        txt_tm.Clear()
        txt_per.Clear()
    End Sub

    Public Sub val()
        txt_en.Enabled = True
        txt_en.Focus()
        txt_guj.Enabled = False
        txt_hindi.Enabled = False
        txt_maths.Enabled = False
        txt_san.Enabled = False
        txt_science.Enabled = False
        txt_ss.Enabled = False
        txt_eng.Enabled = False
        txt_tm.Enabled = False
        txt_per.Enabled = False
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MessageBox.Show("Are You Sure Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            Staff_Panel.result = 0
        End If
    End Sub
End Class
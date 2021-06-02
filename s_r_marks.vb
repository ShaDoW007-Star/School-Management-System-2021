Imports System.Data.OleDb
Imports System.Data
Imports System.ComponentModel
Public Class s_r_marks
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB Project\database\School_Management_System.mdb")
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand

    Private Sub s_r_marks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_pass.Visible = False
        lbl_failed.Visible = False
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
        Staff_Panel.result = 1

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

        da = New OleDbDataAdapter("select * from tbl_marks where enrollment_no = " + Login.ids.ToString() + "", con)
        ds = New DataSet
        da.Fill(ds)

        txt_en.Text = ds.Tables(0).Rows(0)(0).ToString()
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

        If per >= 33 Then
            lbl_pass.Visible = True
            lbl_failed.Visible = False
        ElseIf per < 33 Then
            lbl_pass.Visible = False
            lbl_failed.Visible = True
        End If

        txt_en.Enabled = False
        txt_guj.Enabled = True
        txt_hindi.Enabled = True
        txt_maths.Enabled = True
        txt_san.Enabled = True
        txt_science.Enabled = True
        txt_ss.Enabled = True
        txt_eng.Enabled = True
        txt_per.Enabled = True
        txt_tm.Enabled = True
        con.Close()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are You Sure Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Student_Panel.result = 0
            Me.Close()
        End If
    End Sub
End Class
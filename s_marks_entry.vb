Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Public Class s_marks_entry
    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\VB Project\database\School_Management_System.mdb")
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim daa As OleDbDataAdapter
    Dim dss As DataSet

    Private Sub s_marks_entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_en.Enabled = True
        txt_nm.Enabled = False
        txt_cn.Enabled = False
        txt_standard.Enabled = False
        txt_guj.Enabled = False
        txt_eng.Enabled = False
        txt_hindi.Enabled = False
        txt_maths.Enabled = False
        txt_science.Enabled = False
        txt_ss.Enabled = False
        txt_san.Enabled = False
        txt_per.Enabled = False
        txt_tm.Enabled = False
        Staff_Panel.result = 1
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim a As String
        Dim b As String
        Dim c As String
        Dim j As Integer = 0
        con.Open()
        If txt_en.Text = "" Then
            MessageBox.Show("Enter Enrollment No !")
        Else
            da = New OleDbDataAdapter("select * from tbl_s_reg where enrollment_no = " + txt_en.Text + "", con)
            ds = New DataSet
            da.Fill(ds)

            If j <> ds.Tables(0).Rows.Count.ToString() Then

                daa = New OleDbDataAdapter("select * from tbl_marks where enrollment_no = " + txt_en.Text + "", con)
                dss = New DataSet
                daa.Fill(dss)

                If j = dss.Tables(0).Rows.Count.ToString() Then

                    a = ds.Tables(0).Rows(0)(1).ToString()
                    b = ds.Tables(0).Rows(0)(2).ToString()
                    c = a + " " + b
                    txt_nm.Text = c
                    txt_cn.Text = ds.Tables(0).Rows(0)(7).ToString()
                    txt_standard.Text = ds.Tables(0).Rows(0)(4).ToString()


                    txt_en.Enabled = False
                    txt_nm.Enabled = True
                    txt_cn.Enabled = True
                    txt_standard.Enabled = True
                    txt_guj.Enabled = True
                    txt_guj.Focus()
                    txt_eng.Enabled = True
                    txt_hindi.Enabled = True
                    txt_maths.Enabled = True
                    txt_science.Enabled = True
                    txt_ss.Enabled = True
                    txt_san.Enabled = True
                Else
                    MessageBox.Show("Marks Already Entered !!", "Data")
                End If
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
        txt_cn.Clear()
        txt_nm.Clear()
        txt_standard.Clear()

    End Sub

    Public Sub val()
        txt_en.Enabled = True
        txt_en.Focus()
        txt_nm.Enabled = False
        txt_cn.Enabled = False
        txt_standard.Enabled = False
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim d As Integer
        Dim j As Integer = 1
        con.Open()
        If ValidateChildren(ValidationConstraints.Enabled) Then
            If txt_nm.Text = "" Then
                MessageBox.Show("First Search Student Enrollment No !!")
            ElseIf txt_per.Text = "" Then
                MessageBox.Show("First Click ADD Button !!")
            Else
                cmd = New OleDbCommand("insert into tbl_marks values (" + txt_en.Text + ",'" + txt_guj.Text + "','" + txt_hindi.Text + "' , '" + txt_maths.Text + "' , '" + txt_eng.Text + "','" + txt_science.Text + "','" + txt_ss.Text + "','" + txt_san.Text + "'," + txt_tm.Text + ",'" + txt_per.Text + "') ", con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Insert SuccessFully.....")
            End If
        End If
        con.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim tot As Integer
        Dim en As Integer
        Dim g As Integer
        Dim m As Integer
        Dim s As Integer
        Dim ss As Integer
        Dim san As Integer
        Dim h As Integer
        Dim per As String

        If txt_san.Text = "" Then
            MessageBox.Show("First Enter Marks !!")
        Else

            If IsNumeric(txt_guj.Text) Then
                ep_guj.SetError(txt_guj, "")


                If IsNumeric(txt_hindi.Text) Then
                    ep_hin.SetError(txt_hindi, "")


                    If IsNumeric(txt_maths.Text) Then
                        ep_mths.SetError(txt_maths, "")


                        If IsNumeric(txt_eng.Text) Then
                            ep_eng.SetError(txt_eng, "")


                            If IsNumeric(txt_science.Text) Then
                                ep_sci.SetError(txt_science, "")


                                If IsNumeric(txt_ss.Text) Then
                                    ep_ss.SetError(txt_ss, "")


                                    If IsNumeric(txt_san.Text) Then
                                        ep_san.SetError(txt_san, "")

                                        en = txt_eng.Text
                                        g = txt_guj.Text
                                        h = txt_hindi.Text
                                        s = txt_science.Text
                                        ss = txt_ss.Text
                                        san = txt_san.Text
                                        m = txt_maths.Text

                                        txt_tm.Enabled = True
                                        txt_per.Enabled = True
                                        tot = en + g + h + s + ss + san + m
                                        txt_tm.Text = tot

                                        per = (tot * 100) / 700
                                        txt_per.Text = (per + "%")
                                    Else
                                        ep_san.SetError(txt_san, "Enter Numeric Value !!")
                                    End If
                                Else
                                    ep_ss.SetError(txt_ss, "Enter Numeric Value !!")
                                End If
                            Else
                                ep_sci.SetError(txt_science, "Enter Numeric Value !!")
                            End If
                        Else
                            ep_eng.SetError(txt_eng, "Enter Numeric Value !!")
                        End If
                    Else
                        ep_mths.SetError(txt_maths, "Enter Numeric Value !!")
                    End If
                Else
                    ep_hin.SetError(txt_hindi, "Enter Numeric Value !!")
                End If
            Else
                ep_guj.SetError(txt_guj, "Enter Numeric Value !!")
            End If
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MessageBox.Show("Are You Sure Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            Staff_Panel.result = 0
        End If
    End Sub

    Private Sub txt_guj_Validating(sender As Object, e As CancelEventArgs) Handles txt_guj.Validating
        If String.IsNullOrEmpty(txt_guj.Text) Then
            e.Cancel = True
            txt_guj.Focus()
            ep_guj.SetError(txt_guj, "Enter Marks !!")
        Else
            e.Cancel = False
            ep_guj.SetError(txt_guj, "")
        End If
    End Sub

    Private Sub txt_hindi_Validating(sender As Object, e As CancelEventArgs) Handles txt_hindi.Validating
        If String.IsNullOrEmpty(txt_hindi.Text) Then
            e.Cancel = True
            txt_hindi.Focus()
            ep_hin.SetError(txt_hindi, "Enter Marks !!")
        Else
            e.Cancel = False
            ep_hin.SetError(txt_hindi, "")
        End If
    End Sub

    Private Sub txt_maths_Validating(sender As Object, e As CancelEventArgs) Handles txt_maths.Validating
        If String.IsNullOrEmpty(txt_maths.Text) Then
            e.Cancel = True
            txt_maths.Focus()
            ep_mths.SetError(txt_maths, "Enter Marks !!")
        Else
            e.Cancel = False
            ep_mths.SetError(txt_maths, "")
        End If
    End Sub

    Private Sub txt_eng_Validating(sender As Object, e As CancelEventArgs) Handles txt_eng.Validating
        If String.IsNullOrEmpty(txt_eng.Text) Then
            e.Cancel = True
            txt_eng.Focus()
            ep_eng.SetError(txt_eng, "Enter Marks !!")
        Else
            e.Cancel = False
            ep_eng.SetError(txt_eng, "")
        End If
    End Sub

    Private Sub txt_science_Validating(sender As Object, e As CancelEventArgs) Handles txt_science.Validating
        If String.IsNullOrEmpty(txt_science.Text) Then
            e.Cancel = True
            txt_science.Focus()
            ep_sci.SetError(txt_science, "Enter Marks !!")
        Else
            e.Cancel = False
            ep_sci.SetError(txt_science, "")
        End If
    End Sub

    Private Sub txt_ss_Validating(sender As Object, e As CancelEventArgs) Handles txt_ss.Validating
        If String.IsNullOrEmpty(txt_ss.Text) Then
            e.Cancel = True
            txt_ss.Focus()
            ep_ss.SetError(txt_ss, "Enter Marks !!")
        Else
            e.Cancel = False
            ep_ss.SetError(txt_ss, "")
        End If
    End Sub

    Private Sub txt_san_Validating(sender As Object, e As CancelEventArgs) Handles txt_san.Validating
        If String.IsNullOrEmpty(txt_san.Text) Then
            e.Cancel = True
            txt_san.Focus()
            ep_san.SetError(txt_san, "Enter Marks !!")
        Else
            e.Cancel = False
            ep_san.SetError(txt_san, "")
        End If
    End Sub
End Class
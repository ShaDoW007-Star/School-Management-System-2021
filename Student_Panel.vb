Public Class Student_Panel
    Public result As Integer = 0
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If result = 0 Then
            change_pass.MdiParent = Me
            change_pass.Show()
        Else
            MessageBox.Show("Form Already OPEN...")
            Me.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If result = 0 Then
            s_r_marks.MdiParent = Me
            s_r_marks.Show()
        Else
            MessageBox.Show("Form Already OPEN...")
            Me.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If result = 0 Then
            s_s_details.MdiParent = Me
            s_s_details.Show()
        Else
            MessageBox.Show("Form Already OPEN...")
            Me.Show()
        End If
    End Sub

    Private Sub Student_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is MdiClient Then
                ctrl.BackColor = Color.Black
            End If
        Next ctrl
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        If MessageBox.Show("Are You Sure Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If
    End Sub
End Class
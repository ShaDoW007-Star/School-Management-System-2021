Public Class Admin_Panel
    Public result As Integer = 0
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If result = 0 Then
            S_Register.MdiParent = Me
            S_Register.Show()
        Else
            MessageBox.Show("Form Already OPEN....")
        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If result = 0 Then
            s_details.MdiParent = Me
            s_details.Show()
        Else
            MessageBox.Show("Form Already OPEN...")
            Me.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If result = 0 Then
            st_register.MdiParent = Me
            st_register.Show()
        Else
            MessageBox.Show("Form Already OPEN...")
            Me.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        If result = 0 Then
            st_details.MdiParent = Me
            st_details.Show()
        Else
            MessageBox.Show("Form Already OPEN...")
            Me.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        If MessageBox.Show("Are You Sure Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Admin_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is MdiClient Then
                ctrl.BackColor = Color.Black
            End If
        Next ctrl
    End Sub
End Class
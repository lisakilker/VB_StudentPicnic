Public Class frmStudentPicnicApplication

    Private Sub lblSpringFlingPicnic_Click(sender As Object, e As EventArgs) Handles lblSpringFlingPicnic.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picPicnic.Click

    End Sub

    Private Sub frmStudentPicnicApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnViewPicnicInformation_Click(sender As Object, e As EventArgs) Handles btnViewPicnicInformation.Click
        lblPicnicDate.Visible = True
        lblPicnicLocation.Visible = True
        btnViewPicnicInformation.Enabled = False


    End Sub

    Private Sub btnExitWindow_Click(sender As Object, e As EventArgs) Handles btnExitWindow.Click
        Close()
    End Sub
End Class

Public Class Form1
    Private Sub Bfor_Click(sender As Object, e As EventArgs) Handles Bfor.Click
        Listbox1.Items.Clear()
        For i = 1 To 10
            Listbox1.Items.Add("For Next : " & i)
        Next
    End Sub

    Private Sub Bwhile_Click(sender As Object, e As EventArgs) Handles Bwhile.Click
        Listbox1.Items.Clear()
        Dim i As Integer = 0
        Do While i <= 10
            Listbox1.Items.Add("Do While : " & i)
            i = i + 1
        Loop
    End Sub

    Private Sub Buntil_Click(sender As Object, e As EventArgs) Handles Buntil.Click
        Listbox1.Items.Clear()
        Dim i As Integer = 0
        Do While i > 10
            Listbox1.Items.Add("Do Until : " & i)
            i = i + 1
        Loop
    End Sub

    Private Sub Bkeluar_Click(sender As Object, e As EventArgs) Handles Bkeluar.Click
        End
    End Sub
End Class

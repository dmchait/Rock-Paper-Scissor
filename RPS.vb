Public Class RPS
    Dim playCount As Integer
    Dim tieCount As Integer
    Dim compCount As Integer

    Private Sub Play_Click(sender As Object, e As EventArgs) Handles play.Click
        Dim r As Random = New Random
        Dim rr As Integer = r.Next(3)
        Dim player_Choice As Integer = Playermove.SelectedIndex
        Dim c_Choice As Integer = rr

        Dim comp_Choice As String = "Rock"
        If (c_Choice = 1) Then comp_Choice = "Paper"
        If (c_Choice = 2) Then comp_Choice = "Scissors"
        Label3.Text = comp_Choice

        If (c_Choice = player_Choice) Then
            results.Text = "It's A Draw!"
            tieCount += 1
        ElseIf (c_Choice = 0 And player_Choice = 1) Then
            results.Text = "Paper covers Rock" & vbNewLine & "Player Wins!"
            playCount += 1
        ElseIf (c_Choice = 0 And player_Choice = 2) Then
            results.Text = "Rock blunts Scissors" & vbNewLine & "Computer Wins!"
            compCount += 1
        ElseIf (c_Choice = 1 And player_Choice = 0) Then
            results.Text = "Paper covers Rock" & vbNewLine & "Computer Wins!"
            compCount += 1
        ElseIf (c_Choice = 1 And player_Choice = 2) Then
            results.Text = "Scissors cuts Paper" & vbNewLine & "Player Wins!"
            playCount += 1
        ElseIf (c_Choice = 2 And player_Choice = 0) Then
            results.Text = "Rock blunts Scissors" & vbNewLine & "Player Wins!"
            playCount += 1
        ElseIf (c_Choice = 2 And player_Choice = 1) Then
            results.Text = "Scissors cuts Paper" & vbNewLine & "Computer Wins!"
            compCount += 1
        End If
    End Sub

    Private Sub Stats_Click(sender As Object, e As EventArgs) Handles Stats.Click
        MsgBox("Computer Wins:" & compCount & vbNewLine &
               "Player Wins:" & playCount & vbNewLine &
               "Total Ties:" & tieCount)
    End Sub
End Class

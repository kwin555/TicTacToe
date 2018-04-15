
'Kevin Nguyen
Imports TheBrain


Public Class MainForm

    Private _ticTacToeGame As TicTacToeGame = New TicTacToeGame()

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPlayerName.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim aboutBox As New Form
        aboutBox = New AboutBoxTicTacToe()
        aboutBox.ShowDialog()
    End Sub

    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        _ticTacToeGAme.ResetGrid()

        MessageBox.Show("The Start Game button was clicked",
                        "Tic Tac Toe",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub btnStartComputer_Click(sender As Object, e As EventArgs) Handles btnStartComputer.Click
        MessageBox.Show("The GO Computer button was clicked",
                "Tic Tac Toe",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
    End Sub

    Private Sub btnSquare00_Click(sender As Object, e As EventArgs) Handles btnSquare00.Click
        _ticTacToeGame.PlaceMarker(0, 0, CellOwners.Human)
    End Sub

    Private Sub btnSquare01_Click(sender As Object, e As EventArgs) Handles btnSquare01.Click
        _ticTacToeGame.PlaceMarker(0, 1, CellOwners.Human)
    End Sub

    Private Sub btnSquare02_Click(sender As Object, e As EventArgs) Handles btnSquare02.Click
        _ticTacToeGame.PlaceMarker(0, 2, CellOwners.Human)
    End Sub

    Private Sub btnSquare10_Click(sender As Object, e As EventArgs) Handles btnSquare10.Click
        _ticTacToeGame.PlaceMarker(1, 0, CellOwners.Human)
    End Sub

    Private Sub btnSquare11_Click(sender As Object, e As EventArgs) Handles btnSquare11.Click
        _ticTacToeGame.PlaceMarker(1, 1, CellOwners.Human)
    End Sub

    Private Sub btnSquare12_Click(sender As Object, e As EventArgs) Handles btnSquare12.Click
        _ticTacToeGame.PlaceMarker(1, 2, CellOwners.Human)
    End Sub

    Private Sub btnSquare20_Click(sender As Object, e As EventArgs) Handles btnSquare20.Click
        _ticTacToeGame.PlaceMarker(2, 0, CellOwners.Human)
    End Sub

    Private Sub btnSquare21_Click(sender As Object, e As EventArgs) Handles btnSquare21.Click
        _ticTacToeGame.PlaceMarker(2, 1, CellOwners.Human)
    End Sub

    Private Sub btnSquare22_Click(sender As Object, e As EventArgs) Handles btnSquare22.Click
        _ticTacToeGame.PlaceMarker(2, 2, CellOwners.Human)
    End Sub
End Class

using TicTacToe.Game;

namespace TicTacToe.Logic;

public static class WinChecker
{
    /// <summary>
    /// Returns true if the given symbol occupies a complete row, column, or diagonal.
    /// </summary>
    public static bool HasWon(GameBoard board, char symbol)
    {
        int n = GameBoard.Size;

        // Check rows and columns
        for (int i = 0; i < n; i++)
        {
            if (AllMatch(symbol, board.GetCell(i, 0), board.GetCell(i, 1), board.GetCell(i, 2)))
                return true;

            if (AllMatch(symbol, board.GetCell(0, i), board.GetCell(1, i), board.GetCell(2, i)))
                return true;
        }

        // Check main diagonal (top-left → bottom-right)
        if (AllMatch(symbol, board.GetCell(0, 0), board.GetCell(1, 1), board.GetCell(2, 2)))
            return true;

        // Check anti-diagonal (top-right → bottom-left)
        if (AllMatch(symbol, board.GetCell(0, 2), board.GetCell(1, 1), board.GetCell(2, 0)))
            return true;

        return false;
    }

    private static bool AllMatch(char symbol, params char[] cells)
        => cells.All(c => c == symbol);
}

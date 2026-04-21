namespace TicTacToe.Game;

/// <summary>
/// Represents the 3x3 TicTacToe board.
/// Positions are numbered 1-9 in reading order (left-to-right, top-to-bottom):
///   1 | 2 | 3
///   ---------
///   4 | 5 | 6
///   ---------
///   7 | 8 | 9
/// </summary>
public class GameBoard
{
    public const int Size = 3;
    private readonly char[,] _cells;

    public GameBoard()
    {
        _cells = new char[Size, Size];
        Reset();
    }

    public void Reset()
    {
        for (int row = 0; row < Size; row++)
            for (int col = 0; col < Size; col++)
                _cells[row, col] = ' ';
    }

    /// <summary>Returns the symbol at the given 1-based position (1–9).</summary>
    public char GetCell(int position)
    {
        (int row, int col) = PositionToCoords(position);
        return _cells[row, col];
    }

    /// <summary>Returns the symbol at the given row and column (0-based).</summary>
    public char GetCell(int row, int col) => _cells[row, col];

    /// <summary>
    /// Attempts to place the player's symbol at the given 1-based position.
    /// Returns false if the position is already occupied.
    /// </summary>
    public bool TryPlaceSymbol(int position, char symbol)
    {
        (int row, int col) = PositionToCoords(position);
        if (_cells[row, col] != ' ')
            return false;

        _cells[row, col] = symbol;
        return true;
    }

    /// <summary>Returns true when all 9 cells are filled.</summary>
    public bool IsFull()
    {
        for (int row = 0; row < Size; row++)
            for (int col = 0; col < Size; col++)
                if (_cells[row, col] == ' ')
                    return false;
        return true;
    }

    private static (int row, int col) PositionToCoords(int position)
    {
        // position 1-9  →  0-based (row, col)
        int index = position - 1;
        return (index / Size, index % Size);
    }
}

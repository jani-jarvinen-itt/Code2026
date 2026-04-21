using TicTacToe.Game;

namespace TicTacToe.UI;

public static class ConsoleRenderer
{
    private const string Separator = "---+---+---";

    public static void DrawBoard(GameBoard board)
    {
        Console.WriteLine();
        for (int row = 0; row < GameBoard.Size; row++)
        {
            Console.Write(" ");
            for (int col = 0; col < GameBoard.Size; col++)
            {
                char cell = board.GetCell(row, col);
                Console.Write($" {cell} ");
                if (col < GameBoard.Size - 1)
                    Console.Write("|");
            }
            Console.WriteLine();

            if (row < GameBoard.Size - 1)
                Console.WriteLine(" " + Separator);
        }
        Console.WriteLine();
    }

    /// <summary>Draws the position reference grid so players know which number maps where.</summary>
    public static void DrawPositionGuide()
    {
        Console.WriteLine("  Position guide:");
        Console.WriteLine();
        Console.WriteLine("   1 | 2 | 3");
        Console.WriteLine("  ---+---+---");
        Console.WriteLine("   4 | 5 | 6");
        Console.WriteLine("  ---+---+---");
        Console.WriteLine("   7 | 8 | 9");
        Console.WriteLine();
    }

    public static void PrintWelcome()
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("       TIC-TAC-TOE GAME        ");
        Console.WriteLine("================================");
        Console.WriteLine();
    }

    public static void PrintTurnPrompt(Player player)
    {
        Console.WriteLine($"{player}'s turn. Enter a position (1-9):");
    }

    public static void PrintInvalidInput()
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
    }

    public static void PrintCellOccupied()
    {
        Console.WriteLine("That cell is already taken. Choose another position.");
    }

    public static void PrintWinner(Player winner)
    {
        Console.WriteLine($"Congratulations! {winner} wins!");
    }

    public static void PrintDraw()
    {
        Console.WriteLine("It's a draw! No more moves available.");
    }

    public static bool AskPlayAgain()
    {
        Console.Write("Play again? (y/n): ");
        string? input = Console.ReadLine();
        return string.Equals(input?.Trim(), "y", StringComparison.OrdinalIgnoreCase);
    }
}

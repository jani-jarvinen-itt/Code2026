using TicTacToe.Logic;
using TicTacToe.UI;

namespace TicTacToe.Game;

public class GameController
{
    private readonly GameBoard _board;
    private readonly Player[] _players;
    private int _currentPlayerIndex;
    private GameState _state;

    public GameController()
    {
        _board = new GameBoard();
        _players =
        [
            new Player("Player 1", 'X'),
            new Player("Player 2", 'O')
        ];
        _currentPlayerIndex = 0;
        _state = GameState.NotStarted;
    }

    public void Run()
    {
        ConsoleRenderer.PrintWelcome();
        ConsoleRenderer.DrawPositionGuide();

        bool playAgain = true;
        while (playAgain)
        {
            StartNewGame();
            PlayGame();
            playAgain = ConsoleRenderer.AskPlayAgain();

            if (playAgain)
                Console.Clear();
        }

        Console.WriteLine("Thanks for playing!");
    }

    private void StartNewGame()
    {
        _board.Reset();
        _currentPlayerIndex = 0;
        _state = GameState.Running;
    }

    private void PlayGame()
    {
        while (_state == GameState.Running)
        {
            Player current = _players[_currentPlayerIndex];
            ConsoleRenderer.DrawBoard(_board);
            ConsoleRenderer.PrintTurnPrompt(current);

            int position = ReadValidPosition();

            if (!_board.TryPlaceSymbol(position, current.Symbol))
            {
                ConsoleRenderer.PrintCellOccupied();
                continue;
            }

            if (WinChecker.HasWon(_board, current.Symbol))
            {
                _state = GameState.Win;
                ConsoleRenderer.DrawBoard(_board);
                ConsoleRenderer.PrintWinner(current);
            }
            else if (_board.IsFull())
            {
                _state = GameState.Draw;
                ConsoleRenderer.DrawBoard(_board);
                ConsoleRenderer.PrintDraw();
            }
            else
            {
                // Switch to the other player
                _currentPlayerIndex = 1 - _currentPlayerIndex;
            }
        }
    }

    /// <summary>
    /// Reads console input until a valid integer in [1,9] is entered.
    /// </summary>
    private static int ReadValidPosition()
    {
        while (true)
        {
            string? raw = Console.ReadLine();
            if (int.TryParse(raw?.Trim(), out int position) && position >= 1 && position <= 9)
                return position;

            ConsoleRenderer.PrintInvalidInput();
        }
    }
}

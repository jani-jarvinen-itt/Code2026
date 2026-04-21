namespace TicTacToe.Game;

public class Player
{
    public string Name { get; }
    public char Symbol { get; }

    public Player(string name, char symbol)
    {
        Name = name;
        Symbol = symbol;
    }

    public override string ToString() => $"{Name} ({Symbol})";
}

using DominoGameInterface;

namespace DominoGameClasses;

class Game : IGame
{
    public List<IPlayer> Players { get; set; } = [];
    public Deck deck = new(); 
    public event EventHandler? GameEvent;
    public Game(List<IPlayer> players)
    {
        Players = players;
    }

    public void StartGame()
    {
        GameEvent?.Invoke(this, EventArgs.Empty);
        GenerateDominoTile();
    }

    public void HandleGameStart(object sender, EventArgs e)
    {
        Console.WriteLine("Game Dimulai");
    }

    public void ShuffleDominoTile()
    {
        
    }
    private void GenerateDominoTile()
    {
        for (byte i = 0; i <= 6; i++)
        {
            for (byte j = i; j <= 6; j++)
            {
                deck.dominoTiles.Add(new DominoTile(i, j));
            }
        }
    }

}
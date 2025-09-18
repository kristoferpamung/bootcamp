using System.Reflection.Metadata;

namespace Classes;

class Game
{
    public List<Player> players = new();
    public readonly List<Card> cards = new()
    {
        new Card(6,6),
        new Card(6,5),
        new Card(6,4),
        new Card(6,3),
        new Card(6,2),
        new Card(6,1),
        new Card(6,0),
        new Card(5,5),
        new Card(5,4),
        new Card(5,3),
        new Card(5,2),
        new Card(5,1),
        new Card(5,0),
        new Card(4,4),
        new Card(4,3),
        new Card(4,2),
        new Card(4,1),
        new Card(4,0),
        new Card(3,3),
        new Card(3,2),
        new Card(3,1),
        new Card(3,0),
        new Card(2,2),
        new Card(2,1),
        new Card(2,0),
        new Card(1,1),
        new Card(1,0),
        new Card(0,0)
    };
    private List<int> _board = new();

    public Game(Player player1, Player player2)
    {
        players.Add(player1);
        players.Add(player2);
    }

    public Game(Player player1, Player player2, Player player3, Player player4) : this(player1, player2)
    {
        players.Add(player3);
        players.Add(player4);
    }

    public void removeCard(int index)
    {
        cards.RemoveAt(index);
    }

    public void start()
    {
        Console.WriteLine("Game Start!");
    }

}
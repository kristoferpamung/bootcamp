using System.Reflection.Metadata;

namespace Classes;

class Game
{
    public List<Player> Players = new();
    public readonly List<Domino> Dominos = new()
    {
        new Domino(6,6),
        new Domino(6,5),
        new Domino(6,4),
        new Domino(6,3),
        new Domino(6,2),
        new Domino(6,1),
        new Domino(6,0),
        new Domino(5,5),
        new Domino(5,4),
        new Domino(5,3),
        new Domino(5,2),
        new Domino(5,1),
        new Domino(5,0),
        new Domino(4,4),
        new Domino(4,3),
        new Domino(4,2),
        new Domino(4,1),
        new Domino(4,0),
        new Domino(3,3),
        new Domino(3,2),
        new Domino(3,1),
        new Domino(3,0),
        new Domino(2,2),
        new Domino(2,1),
        new Domino(2,0),
        new Domino(1,1),
        new Domino(1,0),
        new Domino(0,0)
    };

    public Game(Player player1, Player player2)
    {
        Players.Add(player1);
        Players.Add(player2);
    }

    public Game(Player player1, Player player2, Player player3, Player player4) : this(player1, player2)
    {
        Players.Add(player3);
        Players.Add(player4);
    }

    public void ShuffleDomino()
    {
        List<Domino> tempDomino = [];
        Random rd = new();
        for (int i = 0; i < 7; i++)
        {
            tempDomino.Add(Dominos[rd.Next(0, 27)]);
        }

        foreach (Player player in Players)
        {
            player.TakeDomino(dominos: tempDomino);
        }
    }
}
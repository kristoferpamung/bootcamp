using DominoGameInterface;

namespace DominoGameClasses;

class Player : IPlayer
{
    public string Name { get; set; } = "";
    public int Score { get; set; }
    public List<IDominoTile> Hand { get; set; } = [];

    public Player(string name)
    {
        Name = name;
    }
}
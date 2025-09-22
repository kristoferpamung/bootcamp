namespace DominoGameInterface;

interface IPlayer
{
    string Name { get; set; }
    int Score { get; set; }
    List<IDominoTile> Hand { get; set; }
}
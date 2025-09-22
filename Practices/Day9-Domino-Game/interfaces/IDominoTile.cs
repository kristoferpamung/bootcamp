namespace DominoGameInterface;

interface IDominoTile
{
    byte PipLeft { get; set; }
    byte PipRight { get; set; }
    bool IsDouble { get; }
}
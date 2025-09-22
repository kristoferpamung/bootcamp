namespace DominoGameInterface;

interface IDeck
{
    List<IDominoTile> dominoTiles { get; set; }
}
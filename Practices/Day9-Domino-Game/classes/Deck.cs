using DominoGameInterface;

namespace DominoGameClasses;

class Deck : IDeck
{
    public List<IDominoTile> dominoTiles { get; set; } = [];
}
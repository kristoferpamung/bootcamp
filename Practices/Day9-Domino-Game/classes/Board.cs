using DominoGameInterface;

namespace DominoGameClasses;

class Board : IBoard
{
    public List<IDominoTile> DominoTiles { get; set; } = [];
}
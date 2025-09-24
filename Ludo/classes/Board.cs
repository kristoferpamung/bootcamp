using LudoGameInterfaces;

namespace LudoGameClasses;

public class Board : IBoard
{
    public Square[,] Grid { get; set; } = new Square[15,15];
    public List<IArea> HomeAreas { get; set; } = [];
    public List<IArea> GoalAreas { get; set; } = [];

    public ISquare GetNextSquare(IPiece piece, int steps)
    {
        throw new NotImplementedException();
    }

    public ISquare GetSquareByPosition(int x, int y)
    {
        throw new NotImplementedException();
    }
}
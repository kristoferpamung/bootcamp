using LudoGameClasses;

namespace LudoGameInterfaces;

public interface IBoard
{
    public Square[,] Grid { get; set; }
    public List<IArea> HomeAreas { get; set; }
    public List<IArea> GoalAreas { get; set; }
    public ISquare GetNextSquare(IPiece piece, int steps);
    public ISquare GetSquareByPosition(int x, int y);
}
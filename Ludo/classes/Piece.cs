using LudoGameEnums;
using LudoGameInterfaces;

namespace LudoGameClasses;

public class Piece : IPiece
{
    public readonly ColorState color;
    public int position;
    public PieceState state;
    public bool CanMove(int steps)
    {
        throw new NotImplementedException();
    }

    public bool IsGoalReached()
    {
        throw new NotImplementedException();
    }

    public void MoveTo(Position position)
    {
        throw new NotImplementedException();
    }

    public void SendHome()
    {
        throw new NotImplementedException();
    }
}
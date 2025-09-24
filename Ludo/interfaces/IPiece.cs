using LudoGameEnums;
namespace LudoGameInterfaces;

public interface IPiece
{
    public void MoveTo(Position position);
    public void SendHome();
    public bool IsGoalReached();
    public bool CanMove(int steps);
}
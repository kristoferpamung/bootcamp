using LudoGameClasses;

namespace LudoGameInterfaces;

public interface IArea
{
    public void AddPiece(IPiece piece);
    public void RemovePiece(IPiece piece);
    public bool IsGoalComplate();

}
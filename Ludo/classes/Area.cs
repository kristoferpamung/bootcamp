using LudoGameInterfaces;

namespace LudoGameClasses;

public class Area : IArea
{
    public readonly Player owner = new();
    public List<IPiece> pieces = [];
    public readonly List<int> goalPath = [];

    public void AddPiece(IPiece piece)
    {
        throw new NotImplementedException();
    }
    public void RemovePiece(IPiece piece)
    {
        throw new NotImplementedException();
    }
    public bool IsGoalComplate()
    {
        throw new NotImplementedException();
    }
}
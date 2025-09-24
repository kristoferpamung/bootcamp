using LudoGameEnums;
using LudoGameInterfaces;

namespace LudoGameClasses;

public class Square : ISquare
{
    public Position Position { get; set; }
    public bool IsSafeZone { get; set; }
    public bool IsArrowEmpty { get; set; }
    public ColorState Color { get; set; }
    public List<IPiece> Pieces { get; set; } = [];

    public void AddPiece(IPiece piece)
    {
        throw new NotImplementedException();
    }

    public int HasEnemyPiece()
    {
        throw new NotImplementedException();
    }

    public void RemovePiece(IPiece piece)
    {
        throw new NotImplementedException();
    }
}
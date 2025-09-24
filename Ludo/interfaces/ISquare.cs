using LudoGameEnums;
namespace LudoGameInterfaces;

public interface ISquare
{
    public Position Position { get; set; }
    public bool IsSafeZone { get; set; }
    public bool IsArrowEmpty { get; set; }
    public ColorState Color { get; set; }
    public List<IPiece> Pieces { get; set; }
    public void AddPiece(IPiece piece);
    public void RemovePiece(IPiece piece);
    public int HasEnemyPiece();
}
using LudoGameEnums;

namespace LudoGameInterfaces;

public interface IPlayer
{
    public string Name { get; set; }
    public ColorState Color { get; set; }
    public int ConsecutiveSixes { get; set; }
    public List<IPiece> Pieces { get; set; }
    public PlayerStatus Status { get; set; }
}
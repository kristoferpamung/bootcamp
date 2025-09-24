using LudoGameEnums;
using LudoGameInterfaces;

namespace LudoGameClasses;

public class Player : IPlayer
{
    public string Name { get; set; } = "";
    public ColorState Color { get; set; }
    public int ConsecutiveSixes { get; set; }
    public List<IPiece> Pieces { get; set; } = [];
    public PlayerStatus Status { get; set; }
}
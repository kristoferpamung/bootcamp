using DominoGameClasses;

namespace DominoGameInterface;

interface IGame
{
    List<IPlayer> Players { get; set; }
}
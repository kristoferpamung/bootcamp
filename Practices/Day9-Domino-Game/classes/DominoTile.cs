using DominoGameInterface;

namespace DominoGameClasses;

class DominoTile : IDominoTile
{
    public byte PipLeft { get; set; }

    public byte PipRight { get; set; }

    public bool IsDouble
    {
        get
        {
            return PipLeft == PipRight;
        }
    }

    public DominoTile(byte pipLeft, byte pipRight) {
        PipLeft = pipLeft;
        PipRight = pipRight;
    }
}
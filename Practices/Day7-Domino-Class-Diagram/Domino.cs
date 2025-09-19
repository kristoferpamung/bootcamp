namespace Classes;

public struct Domino
{
    public byte PipTop { get; private set; }
    public byte PipBottom { get; private set; }

    public Domino(byte pipTop, byte pipBottom)
    {
        PipTop = pipTop;
        PipBottom = pipBottom;
    }
}
namespace Classes;

public struct Card
{
    public byte NumberTop
    {
        get;
        private set;
    }
    public byte NumberBottom
    {
        get;
        private set;
    }

    public Card(byte numberTop, byte numberBottom)
    {
        NumberTop = numberTop;
        NumberBottom = numberBottom;
    }
}
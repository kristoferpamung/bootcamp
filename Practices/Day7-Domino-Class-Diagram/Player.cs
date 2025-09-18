using Classes;

class Player
{
    private string? _name;
    public int _points;
    readonly List<Card> _cards = [];

    public string? Name
    {
        set
        {
            _name = value;
        }
        get
        {
            return _name;
        }
    }

    public int Points
    {
        get
        {
            return _points;
        }
    }
    public Player(string name)
    {
        Name = name;
    }

    public void AddScore(int point)
    {
        _points += point;
    }

    public void AddCard(Card card)
    {
        _cards.Add(card);
    }

    public void RemoveCard(Card card)
    {
        _cards.Add(card);
    }

    public void RandomIndex()
    {
        
    }
}
using Classes;

class Player
{
    public string? Name { set; get; }
    public int Score { set; get; }
    public List<Domino> Hand = [];

    public Player(string name)
    {
        Name = name;
    }
    public void Draw(Domino newDomino)
    {
        Hand.Add(newDomino);
    }

    public void TakeDomino(List<Domino> dominos)
    {
        Hand = dominos;
    }
}
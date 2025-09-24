
namespace LudoGameClasses;

public class Dice : IDice
{
    public int Value { get; set; }
    public int Roll()
    {
        throw new NotImplementedException();
    }
    public List<int> RollMultiple(int times)
    {
        throw new NotImplementedException();
    }
    public void SetValue(int value)
    {
        throw new NotImplementedException();
    }
    public bool IsSix()
    {
        throw new NotImplementedException();
    }
    public int GetLastRoll()
    {
        throw new NotImplementedException();
    }
    public void Reset()
    {
        
    }
}
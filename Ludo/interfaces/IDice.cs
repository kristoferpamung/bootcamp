public interface IDice
{
    public int Value { get; set; }
    public int Roll();
    public List<int> RollMultiple(int times);
    public void SetValue(int value);
    public bool IsSix();
    public int GetLastRoll();
}
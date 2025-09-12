namespace Asset;

public class Asset // Base Class
{
    public string Name = "";

    public static void Display(Asset asset)
    {
        Console.WriteLine(asset.Name);
    }
}

// Stock inherits from Asset
public class Stock : Asset // The colon (:) signifies inheritance
{
    public long SharesOwned;
}

// House also inherits from Asset
public class House : Asset
{
    public decimal Mortgage;
}
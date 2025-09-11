using System;
					
public class Program
{
	public static void Main()
	{
		Stock s = new();
		s.Name = "MSFT";
		s.SharedOwned = 1000L;
		
		House h = new();
		h.Name = "Mansion";
		s.SharedOwned = 250_000L;

        var g = Gender.Female;

        Console.Write(g);

        Console.WriteLine(h.GetType());
		
		Console.WriteLine(s.Name + " " + s.SharedOwned);
		Console.WriteLine(h.Name + " " + h.Mortgage);
	}
}

public class Assets {
	public string Name = "";
}

public class Stock : Assets
{
    public long SharedOwned;
}

public class House : Assets
{
    public decimal Mortgage;
}

public enum Gender
{
    Male,
    Female
}
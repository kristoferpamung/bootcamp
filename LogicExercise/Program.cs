
int n;
string? numberString;

Console.Write("input n number: ");
numberString = Console.ReadLine();

if (numberString == null || numberString == "")
{
    Console.WriteLine("Invalid input format");
    return;
}

try
{
    n = int.Parse(numberString);
}
catch (Exception e)
{
    Console.WriteLine($"Invalid input format : {e}");
    return;
}

for (int i = 1; i <= n; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("foobar");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("foo");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("bar");
    }
    else
    {
        Console.WriteLine(i);
    }
}
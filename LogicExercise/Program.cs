
string? numberString;

Console.Write("input n number: ");
numberString = Console.ReadLine();

if (numberString == null || numberString == "")
{
    Console.WriteLine("Invalid input format");
    return;
}

if (int.TryParse(numberString, out int n))
{
    for (int i = 1; i <= n; i++)
    {
        if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
        {
            Console.Write("foobarjazz");
        }
        else if (i % 3 == 0 && i % 5 == 0) {
            Console.Write("foobar");
        }
        else if (i % 3 == 0 && i % 7 == 0) {
            Console.Write("foojazz");
        }
        else if (i % 5 == 0 && i % 7 == 0) {
            Console.Write("barjazz");
        }
        else if (i % 3 == 0)
        {
            Console.Write("foo");
        }
        else if (i % 5 == 0)
        {
            Console.Write("bar");
        }
        else if (i % 7 == 0)
        {
            Console.Write("jazz");
        }
        else
        {
            Console.Write(i);
        }
        Console.Write(", ");
    }
}
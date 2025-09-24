using System.Text;

string? numberString;

Console.Write("input n number: ");
numberString = Console.ReadLine();

if (string.IsNullOrEmpty(numberString))
{
    Console.WriteLine("Input can't empty or null");
    return;
}

StringBuilder outputString = new();

if (int.TryParse(numberString, out int n))
{
    for (int i = 1; i <= n; i++)
    {
        if (i % 3 == 0)
        {
            outputString.Append("foo");
        }
        if (i % 4 == 0)
        {
            outputString.Append("baz");
        }
        if (i % 5 == 0)
        {
            outputString.Append("bar");
        }
        if (i % 7 == 0)
        {
            outputString.Append("jazz");
        }
        if (i % 9 == 0)
        {
            outputString.Append("huzz");
        }
        if (i % 3 != 0 && i % 4 != 0 && i % 5 != 0 && i % 7 != 0 && i % 9 != 0)
        {
            outputString.Append(i);
        }
        if (i < n)
        {
            outputString.Append(", ");
        }
        if (i == n)
        {
            outputString.Append('.');
        }
    }
}

Console.WriteLine(outputString);

/* MY OLD LOGIC */
/*
if (int.TryParse(numberString, out int n))
{
    for (int i = 1; i <= n; i++)
    {
        if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
        {
            Console.Write("foobarjazz");
        }
        else if (i % 3 == 0 && i % 5 == 0)
        {
            Console.Write("foobar");
        }
        else if (i % 3 == 0 && i % 7 == 0)
        {
            Console.Write("foojazz");
        }
        else if (i % 5 == 0 && i % 7 == 0)
        {
            Console.Write("barjazz");
        }
        else if (i % 3 == 0)
        {
            Console.Write("foo");
        }
        else if (i % 4 == 0)
        {
            Console.Write("baz");
        }
        else if (i % 5 == 0)
        {
            Console.Write("bar");
        }
        else if (i % 7 == 0)
        {
            Console.Write("jazz");
        }
        else if (i % 9 == 0)
        {
            Console.Write("huzz");
        }
        else
        {
            Console.Write(i);
        }
        if (i == n)
        {
            Console.Write(".");
        }
        else
        {
            Console.Write(", ");
        }   
    }
}
*/

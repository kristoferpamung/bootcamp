using BelajarDelegate;

Transformer t = Square;
Console.WriteLine("===== Square ===");
int answer = t(4);
Console.WriteLine(answer);

int[] values = { 1, 2, 3, 4 };

Console.WriteLine("\n===== Cube Plug in =====");
Transform(values, Cube);
foreach (int i in values)
{
    Console.WriteLine(i + " ");
}

Console.WriteLine("\n===== Square Plug in =====");


Transform(values, Square);
foreach (int i in values)
{
    Console.WriteLine(i + " ");
}

int Square(int x)
{
    return x * x;
}

int Cube(int x)
{
    return x * x * x;
}

// Plug in methods
void Transform(int[] values, Transformer t)
{
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = t(values[i]);
    }
}


// Intance and Static Method
Console.WriteLine("\n===== Static & Instance Method =====");
Test test = new();
Transformer t2 = test.Cube;
Transformer t3 = Test.Square;

Console.WriteLine(t2(2));
Console.WriteLine(t3(4));


/* Mutlicast Delegates */
void SomeMethod1()
{
    Console.WriteLine("Method 1");
}
void SomeMethod2()
{
    Console.WriteLine("Method 2");
}

Console.WriteLine("\n===== Multicast Delegate =====");
SomeDelegate sd = SomeMethod1;
sd += SomeMethod2;

sd();


/* Multicast Delegates Example */
Console.WriteLine("\n===== Multicast Delegate Example =====");
void WriteProgressToConsole(int percentComplete)
{
    Console.WriteLine($"Console: {percentComplete}");
}

void WriteProgressToFile(int percentComplete)
{
    File.WriteAllText("progress.txt", percentComplete.ToString());
}

ProgressReporter pr = WriteProgressToConsole;
pr += WriteProgressToFile;

Util.HardWork(pr);


/* Delegate Generic */
Console.WriteLine("\n===== Delegate Generic =====");
TransformerGeneric<int, int> tg = Square;
Console.WriteLine(tg(8));
TransformerGeneric<string, int> tg2 = LengthOfString;
Console.WriteLine(tg2("Kristofer"));

int LengthOfString(string name)
{
    return name.Length;
}

/* Menggunakan Func<TArgs, TResult> */
Util2.Transform<int>(values, Cube);
foreach (int i in values)
{
    Console.WriteLine(i + " Func");
}
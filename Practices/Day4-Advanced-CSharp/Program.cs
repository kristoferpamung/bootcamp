using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BelajarDelegate;
using BelajarEventHandler;
using TryCatchKu;

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


Console.WriteLine("\n===== Event Handler =====");
Stock stock = new("THPW");
stock.Price = 27.10M;

stock.PriceChanged += stock_PriceChanged;
stock.Price = 31.59M;

void stock_PriceChanged(object? sender, PriceChangedEventArgs e)
{
    if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
    {
        Console.WriteLine("Alert, 10% stok price increase!");
    }
}


/* Event Handler dari ChatGPT */
Processor proc = new();
proc.OnDataProcessed += (sender, e) =>
{
    Console.WriteLine("Data selesai diproses");
};

proc.Process();

Notifier n = new();
n.OnNotify += (s, e) => Console.WriteLine("Pesan: " + e.Message);
n.Notify("Hello Dunia");


Console.WriteLine("\n===== Try Catch =====");
TryCatch tc = new();
try
{
    int y = tc.Calc(2);
    Console.WriteLine(y);
}
catch (DivideByZeroException de)
{
    Console.WriteLine("Message: " + de.Message);
}
finally
{
    Console.WriteLine("Ini tetap dieksekusi");
}

try
{
    int x = int.Parse(null!);
    Console.WriteLine(x);
}
catch (FormatException fe)
{
    Console.WriteLine("Error: " + fe.Message);
}
catch (Exception e)
{
    Console.WriteLine("Error Null: " + e.Message);
}
finally
{
    Console.WriteLine("Ini tetap dieksekusi");
}

/* Iterator */
/* Collection Initializers */
var list = new List<int> { 1, 2, 3 };
/* Compailer akan mengeksekusi */
List<int> listEksekusi = new List<int>();
listEksekusi.Add(1);
listEksekusi.Add(2);
listEksekusi.Add(3);

/*foreach adalah bagian dari enumerator dan iterator */
foreach (int i in listEksekusi)
{
    Console.Write(i + ", ");
}

/*key-value pair dictionary */
var dic = new Dictionary<int, string>()
{
    {1, "One"},
    {2, "Two"},
    {3, "Three"}
};
/*indexer pair dictionary */
var dicIndexer = new Dictionary<int, string>()
{
    [1] = "one",
    [2] = "two",
    [3] = "three"
};

/* Nullable */
string? s = null;
int? u = null;

Console.WriteLine(s == null);
Console.WriteLine(u == null);

int? a = 5;
int? b = 10;
bool c = a < b;
Console.WriteLine(c);

/* Operator Lifting */
bool d = (a.HasValue && b.HasValue) ? (a.Value < b.Value) : false;
Console.WriteLine(c);

StringBuilder? sb = null;
int length = sb?.ToString().Length ?? 0;
Console.WriteLine(length);

/* IEnumerable */
IEnumerable<int> angka = new List<int> { 1, 2, 3, 4, 5 };

static IEnumerable<int> getOddNumber()
{
    for (int i = 0; i <= 10; i++)
    {
        if (i % 2 == 0)
        {
            yield return i;
        }
    }
}

foreach (var number in getOddNumber())
{
    Console.WriteLine(number);
}
using BasicDelegate;
using Events;

MyDelegate md = new();

/* delegate is immutable */
DelegateWriteLine de = md.DelegateMethod1;

 /*single delegate instance can reference multiple target methods (new delegate instance is created) */
de += md.DelegateMethod2;

de();

/* delegate with return type and argument */
DelegateConvertStringToInt dcsti = md.ConvertStringToInt;
/* Invoke */
dcsti += md.ConvertStringToBooleanNumber;
int a = dcsti("4") ?? 0;
/* non-void return type. the return value only from the last method invoked */
Console.WriteLine(a);

/* calling delegate in argument */
ShowMessageDelegate smd = md.Show;

md.ShowMessage(smd);

/* calling generic delegate */
Operation<int> o = Tambah;

int Tambah(int a, int b)
{
    return a + b;
}

Console.WriteLine(o(5, 10));

/* Events */
Thermostat ts = new();
AlarmSystem al = new();

ts.OverheadEvent += al.OnOverheatDetection;

ts.Temperature = 25;
ts.Temperature = 32;

Stock stock = new("MSFT");
stock.Price = 27.10M;
stock.PriceChanged += stock_PriceChanged!;

stock.Price = 34.20M;

void stock_PriceChanged(object sender, PriceChangedEventArgs e) // Subscriber method
{
    if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
        Console.WriteLine("Alert, 10% stock price increase!");
}

/* operator overloading */
Note B = new Note(2);
Note CSHarp = B + 2;
CSHarp = CSHarp + 2;
List<string> nameList = new List<string>
{
    "Joko",
    "Hendra",
    "Tompi"
};

var enumerator = nameList.GetEnumerator();
// enumerator.MoveNext();
string current = enumerator.Current;
Console.WriteLine(current);

using DisposalDemo;

using FileManager fm = new(@"C:\Users\Kristofer\Documents\bootcamp\BlockDominoRules.txt");
fm.ReadContent();

using MyClass mc = new();
MyClass mc1 = new();
// mc.Hey();
// mc1.Hey();


class MyClass : IDisposable
{
    public void Hey()
    {
        Console.WriteLine("Hi");
    }
    public void Dispose()
    {
        Console.Write("Akan dijalankan ketika intantiate object. ketika dijalankan 2 kali hanya muncul 1x");
    }
}
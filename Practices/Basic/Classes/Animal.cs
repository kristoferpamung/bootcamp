namespace Classes;

class Animal(string name, int age)
{
    public static string Welcome = "== Hewan Peliharaan ==";
    public void Print()
    {
        Console.WriteLine($"name : {name}, age : {age}");
    }

    // Selalu dijalankan ketika object diinstatiate
    static Animal()
    {
        Console.WriteLine("Hello .....");
    }
}
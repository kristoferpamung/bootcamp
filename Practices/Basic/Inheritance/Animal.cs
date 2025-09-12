namespace Classes;

class Animal
{
    public string Name
    {
        get;
        private set;
    }

    public Animal(string name)
    {
        Name = name;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} eating.");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public void Mengeong()
    {
        Console.WriteLine($"{Name} sedang mengeong");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public void Menggonggong()
    {
        Console.WriteLine($"{Name} sedang mengeong");
    }
}
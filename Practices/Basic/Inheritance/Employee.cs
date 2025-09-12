namespace Classes;

class Employee
{
    public string Name { get; private set; }
    public double BaseSalary { get; private set; }

    public Employee(string name, double baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }


    // Virtual supaya dapat di override
    public virtual double CalculateBonus()
    {
        return BaseSalary * 0.1;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name} receives a bonus of: {CalculateBonus()}");
    }
}

class Manager : Employee
{
    public Manager(string name, double baseSalary) : base(name, baseSalary)
    {

    }

    public override double CalculateBonus()
    {
        return BaseSalary * 0.3;
    }
}

class Staff : Employee
{
    public Staff(string name, double baseSalary) : base(name, baseSalary)
    {

    }

    public override double CalculateBonus()
    {
        return BaseSalary * 0.15;
    }
}
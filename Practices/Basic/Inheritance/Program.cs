using Asset;
using Classes;

/*----- Inheritance -----*/
Console.WriteLine("===== Menggunakan Base Constructor =====");
Animal harimau = new(name: "Haurimau");
Cat kuciang = new(name: "Kuciang");
Dog doggy = new(name: "doggy");
doggy.Eat();

Console.WriteLine(harimau.Name);
Console.WriteLine(kuciang.Name);
Console.WriteLine(doggy.Name);

kuciang.Mengeong();
doggy.Menggonggong();

Console.WriteLine("\n===== Tanpa Base Constructor =====");
Stock MSFT = new Stock
{
    Name = "MSFT",
    SharesOwned = 10_000L
};

House kos = new House
{
    Name = "Kos Pak Kumis",
    Mortgage = 1_000L
};

Console.WriteLine(MSFT.Name + " - " + MSFT.SharesOwned);
Console.WriteLine(kos.Name + " - " + kos.Mortgage);
Asset.Asset.Display(kos);

/*----- End Inheritance -----*/

/*----- Polymorphism -----*/
Console.WriteLine("\n\n===== Polymorphism =====");
List<Employee> employeeList = new List<Employee> { new Manager(name: "Jone", baseSalary: 10_000_000), new Staff(name: "Jane", baseSalary: 8_000_000), new Employee(name: "June", baseSalary: 6_000_000) };

foreach (Employee employee in employeeList)
{
    employee.PrintInfo();
}
/*----- End Polymorphism -----*/
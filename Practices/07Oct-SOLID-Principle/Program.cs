
using Oct_Solid_Principle.Interfaces;
using Oct_Solid_Principle.Logs;
using Oct_Solid_Principle.Models;
using Oct_Solid_Principle.Repositories;
using Oct_Solid_Principle.Services;

// SRP Single Responsibility Principle
/*  */
Console.ForegroundColor = ConsoleColor.DarkCyan; 
Console.WriteLine("SRP Single Responsibility Principle");
Console.WriteLine(new string('-', 20));
Console.ResetColor();
ILogger logger = new ConsoleLogger();
IEmailService emailService = new EmailService(logger);
IUserRepository userRepository = new UserRepository(logger);

UserService userService = new(emailService, userRepository, logger);

userService.RegisterUser("kristofer@gmail.com", "password");
emailService.SendOrderConfirmation("kristofer", 1);

// OCP Open CLose Principle
Console.ForegroundColor = ConsoleColor.DarkCyan; 
Console.WriteLine("\nOCP Open Close Principle");
Console.WriteLine(new string('-', 20));
Console.ResetColor();
IShape rectangle = new Rectangle(20.0D, 30.0D);
IShape circle = new Circle(7);
IShape triangle = new Triangle(8,16);

AreaCalculator areaCalculator = new(logger);
areaCalculator.CalculateTotalArea([rectangle, circle, triangle]);

// LSP Liskov Substitution Principle
Console.ForegroundColor = ConsoleColor.DarkCyan; 
Console.WriteLine("\nLSP Liskov Substitution Principle");
Console.WriteLine(new string('-', 20));
Console.ResetColor();
Sparrow sparrow = new();
Duck duck = new();
Penguin penguin = new();

sparrow.Eat();
sparrow.MakeSound();
sparrow.Fly();

penguin.Eat();
penguin.Swim();
penguin.MakeSound();

duck.Eat();
duck.Fly();
duck.Swim();
duck.MakeSound();
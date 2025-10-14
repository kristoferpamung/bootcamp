
using PrototypeDesignPattern.Interfaces;

namespace PrototypeDesignPattern.Models;

public class Car : IPrototype<Car>
{
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public string Engine { get; set; } = string.Empty;
    public List<string> Features { get; set; } = [];

    public Car(string brand, string model, string color, string engine, List<string> features)
    
    {
        Brand = brand; Model = model; Color = color; Engine = engine; Features = features;
    }

    public Car Clone()
    {
        return new Car(Brand, Model, Color, Engine,new List<string>(Features));
    }
    public void ShowInfo()
    {
        Console.WriteLine($"{Brand} {Model} - Color: {Color}, Engine: {Engine}, Features: {string.Join(", ", Features)}");
    }
}
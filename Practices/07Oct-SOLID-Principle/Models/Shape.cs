using Oct_Solid_Principle.Interfaces;

namespace Oct_Solid_Principle.Models;

public class Rectangle : IShape
{
    public double Height { get; set; }
    public double Width { get; set; }
    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }
    public double Area()
    {
        return Height * Width;
    }

    public string GetShapeInfo()
    {
        return $"Rectangle: {Height} x {Width}, Area: {Area()}";
    }
}

public class Circle : IShape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public string GetShapeInfo()
    {
        return $"Circle: {Radius}, Area: {Area():F2}";
    }
}

public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public Triangle(double baseLength, double height)
    {
        Base = baseLength;
        Height = height;
    }

    public double Area()
    {
        return 0.5 * Base * Height;
    }

    public string GetShapeInfo()
    {
        return $"Triangle: {Base}, Height: {Height}, Area: {Area():F2}";
    }
}
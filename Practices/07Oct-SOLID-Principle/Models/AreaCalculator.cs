using Oct_Solid_Principle.Interfaces;

namespace Oct_Solid_Principle.Models;

public class AreaCalculator
{
    private readonly ILogger _logger;
    public AreaCalculator(ILogger logger)
    {
        _logger = logger;
    }
    public double CalculateTotalArea(IShape[] shapes)
    {
        double totalArea = 0;

        foreach (IShape shape in shapes)
        {
            double area = shape.Area();
            totalArea += area;
            _logger.LogInfo($"Calculated area for {shape.GetShapeInfo()}");
        }
        _logger.LogInfo($"Total area of all shapes: {totalArea:F2}");
        return totalArea;
    }
}
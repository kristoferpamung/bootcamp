using PrototypeDesignPattern.Models;

namespace PrototypeDesignPattern.PrototypeRegistry;

public class PrototypeRegistry
{
    private Dictionary<string, Car> _prototypes = new Dictionary<string, Car>();
    public void Add(string key, Car car)
    {
        _prototypes[key] = car;
    }
    public Car Create(string key)
    {
        return _prototypes[key].Clone();
    }
}
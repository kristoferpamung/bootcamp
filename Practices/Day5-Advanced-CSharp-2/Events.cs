namespace Events;

public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

public class Broadcaster
{
    public event PriceChangedHandler? priceChanged;
}

/* Learning by CHATGPT */
public delegate void OverheatEventHandler(object sender, EventArgs args);
public class Thermostat
{
    public event OverheatEventHandler? OverheadEvent;

    private int _temperature;
    public int Temperature
    {
        get
        {
            return _temperature;
        }
        set
        {
            _temperature = value;
            Console.WriteLine($"Suhu sekarang: {_temperature}°C");
            if (_temperature > 30)
            {
                OnOverheat(EventArgs.Empty);
            }
        }
    }
    protected virtual void OnOverheat(EventArgs e)
    {
        OverheadEvent?.Invoke(this, e);
    }
}

public class AlarmSystem
{
    public void OnOverheatDetection(object sender, EventArgs e)
    {
        Console.WriteLine("🚨 Alarm: Suhu terlalu tinggi! Aktifkan pendingin");
    }
}

public class PriceChangedEventArgs : EventArgs
{
    public readonly decimal LastPrice;
    public readonly decimal NewPrice;
    public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
    {
        LastPrice = lastPrice;
        NewPrice = newPrice;
    }
}

public class Stock
{
    string symbol;
    decimal price;

    public Stock(string symbol)
    {
        this.symbol = symbol;
    }

    public event EventHandler<PriceChangedEventArgs>? PriceChanged;

    public virtual void OnPriceChanged(PriceChangedEventArgs e)
    {
        PriceChanged?.Invoke(this, e);
    }

    public decimal Price
    {
        get => price;
        set
        {
            if (price == value) return;
            decimal oldPrice = price;
            price = value;
            OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
        }
    }
}
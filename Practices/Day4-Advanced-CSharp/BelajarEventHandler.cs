namespace BelajarEventHandler;

public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

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

    public Stock(string symbol) => this.symbol = symbol;
    public event EventHandler<PriceChangedEventArgs> PriceChanged;

    protected virtual void OnPriceChanged(PriceChangedEventArgs e)
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

/* Learning by ChatGPT */
public class Processor
{
    public event EventHandler OnDataProcessed;

    public void Process()
    {
        Console.WriteLine("Memproses Data....");
        OnDataProcessed?.Invoke(this, EventArgs.Empty);
    }
}

public class MyEventArgs : EventArgs
{
    public string Message { get; set; }
}

public class Notifier
{
    public event EventHandler<MyEventArgs> OnNotify;

    public void Notify(string message)
    {
        OnNotify?.Invoke(this, new MyEventArgs { Message = message });
    }
}
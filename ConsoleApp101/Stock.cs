namespace ConsoleApp101;

public class Stock
{
    private string symbol;
    private decimal price;

    public Stock(string symbol)
    {
        this.symbol = symbol;
    }

    public event EventHandler<PriceChangeEventArgs>? PriceChanged;

    protected virtual void OnPriceChange(PriceChangeEventArgs e)
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
            OnPriceChange(new PriceChangeEventArgs(oldPrice, price));
        }
    }
}

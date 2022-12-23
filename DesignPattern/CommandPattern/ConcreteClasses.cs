public class BuyStock : Order
{
    private Stock abcStock;

    public BuyStock(Stock abcStock)
    {
        this.abcStock = abcStock;
    }
    void Order.Execute()
    {
        abcStock.Buy();
    }
}

public class SellStock : Order
{
    private Stock abcStock;

    public SellStock(Stock abcStock)
    {
        this.abcStock = abcStock;
    }
    void Order.Execute()
    {
        abcStock.Sell();
    }
}
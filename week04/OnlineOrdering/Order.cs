


public class Order
{
    private List<string> _products;
    private Customer _customer;
    private double _orderTotal;

    public Order(string product, Customer customer)
    {
        //  need to figure out how to add multiple products to the same customers list.
    }

    public string ShippingLabel()
    {
        return "";
    }

    public string PackingLabel()
    {
        return "";
    }

    public bool IsInUSA()
    {
        return true;
    }
}
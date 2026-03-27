


public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _orderTotal;

    public Order(List<Product> product, Customer customer)
    {
        //  need to figure out how to add multiple products to the same customers list.
        _customer = customer;
        
        foreach (var i in product)
        {
            _products.Add(i);
        }
    }

    // to note. I changed both the ShippingLabel and PackingLabel methods to not return anything. I found it to be more straightforward
    // for both to be the same.
    // And I have no idea how to print the list of products other then through a foreach loop, and I didn't know how to keep carrying
    // the variables forward past this point. I guess at some point I may have figured it out but I do not know if I did or not right now.
    // If I was supposed to keep it going all the way to the program file, please let me know.
    public void ShippingLabel()
    {
        Console.WriteLine(_customer.DisplayCustomer());
    }

    public void PackingLabel()
    {
        foreach (var i in _products)
        {
            Console.WriteLine(i.DisplayProducts());
        }
    }

    public double GetOrderTotal()
    {
        _orderTotal = 0.00;
        if (_customer.InUSA() == true)
        {
            _orderTotal += 5;
        }
        else
        {
            _orderTotal += 35;
        }

        foreach (var i in _products)
        {
            _orderTotal += i.CalculateProductTotal();
        }

        return _orderTotal;
    }

    // initially put this in when doing the group set up, but Order doesn't need a method to find if it is in the usa or not.
    // public bool IsInUSA()
    // {
    //     return true;
    // }
}
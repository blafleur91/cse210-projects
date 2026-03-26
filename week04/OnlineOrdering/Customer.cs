


using System.Net.Sockets;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;
    private bool _isInUSA;

    public Customer(string customerName)
    {
        _customerName = customerName;
    }

    public bool InUSA()
    {
        // need to add logic to determine if the customer is in the usa or not and return that, not just return true.
        return true;
    }
}
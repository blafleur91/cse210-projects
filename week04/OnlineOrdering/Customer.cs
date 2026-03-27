


using System.Net.Sockets;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;
    private bool _isInUSA;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _customerAddress = address;
    }

    public bool InUSA()
    {
        // need to add logic to determine if the customer is in the usa or not and return that, not just return true.
        _isInUSA = _customerAddress.InUSA();
        return _isInUSA;
    }

    public string DisplayCustomer()
    {
        return _customerName + Environment.NewLine + _customerAddress.DisplayAddress();
    }
}
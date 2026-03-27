


using System.Runtime;
using System.Xml;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string country)
    {
        _street = street;
        _city = city;
        _state = "";
        _country = country;
    }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool InUSA()
    {
        // add logic to make it true or false if in us or not
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string DisplayAddress()
    {
        // add logic to return with and without state depending on country
        if (_state == "")
        {
            return _street + Environment.NewLine + $"{_city}, {_country}";
        }
        else
        {
            return _street + Environment.NewLine + $"{_city}, {_state}, {_country}";
        }
    }
}
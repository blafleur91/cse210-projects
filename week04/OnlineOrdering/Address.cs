


using System.Runtime;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string country)
    {
        
    }

    public Address(string street, string city, string state, string country)
    {
        
    }

    public bool InUSA()
    {
        // add logic to make it true or false if in us or not
        return true;
    }

    public string DisplayAddress()
    {
        // add logic to return with and without state depending on country
        return $"{_street} {_city} {_state} {_country}";
    }
}


public class Product 
{
    private string _productName;
    private string _productID;
    private double _productPrice;
    private int _productQuantity;
    // private double _productTotal;

    public Product(string productName, string productID, double productPrice, int productQuantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public double CalculateProductTotal()
    {
        return _productPrice * _productQuantity;
    }

    
}
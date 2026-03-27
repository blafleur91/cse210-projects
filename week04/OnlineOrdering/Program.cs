using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        List<Product> productListOne = new List<Product>();
        List<Product> productListTwo = new List<Product>();
        

        var productOne = new Product("Milk", "M01", 5.00, 3);
        var productTwo = new Product("Eggs", "E01", 3.00, 2);
        var productThree = new Product("Beef", "B01", 12.50, 1);
        var productFour = new Product("Chicken", "C01", 7.50, 4);
        var productFive = new Product("Bread", "B02", 3.50, 7);
        var productSix = new Product("Flour", "F01", 9.25, 2);

        productListOne.Add(productOne);
        productListOne.Add(productTwo);
        productListOne.Add(productThree);

        productListTwo.Add(productFour);
        productListTwo.Add(productFive);
        productListTwo.Add(productSix);

        var addressOne = new Address("1234 South 5678 West", "Booleard", "Zarahemla");
        var addressTwo = new Address("123 North 456 East", "Layton", "Utah", "USA");

        var customerOne = new Customer("John Doe", addressOne);
        var customerTwo = new Customer("Jane Wayne", addressTwo);

        var orderOne = new Order(productListOne, customerOne);
        var orderTwo = new Order(productListTwo, customerTwo);

        orderOne.PackingLabel();
        Console.WriteLine($"Total price: ${orderOne.GetOrderTotal()}");
        Console.WriteLine();
        orderOne.ShippingLabel();
        
        Console.WriteLine();
        Console.WriteLine();

        orderTwo.PackingLabel();
        Console.WriteLine($"Total price: ${orderTwo.GetOrderTotal()}");
        Console.WriteLine();
        orderTwo.ShippingLabel();
        

    }
}
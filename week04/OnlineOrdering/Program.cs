using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Create products
        var product1 = new Product("Bike", 101, 150.99, 10);
        var product2 = new Product("Clothes", 102, 19.99, 4);
        var product3 = new Product("", 103, 49.99, 1);
        

        // Create an address
        var address1 = new Address("142 NE 163 St", "Miami Beach", "FL", "USA");
        var address2 = new Address("123 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        var customer1 = new Customer("Sara Johnson", address1);
        var customer2 = new Customer("James Smith", address2);

        // Create orders
        var order1 = new Order(new List<Product> { product1, product2 }, customer1);
        var order2 = new Order(new List<Product> { product3 }, customer2);

        // Display the packing label, shipping label, and total price for order1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price for Order 1: ${order1.CalculateTotalPrice():F2}\n");

        // Display the packing label, shipping label, and total price for order2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price for Order 2: ${order2.CalculateTotalPrice():F2}");
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products1 = new List<Product>
        {
            new Product { Name = "Product 1", ProductId = 1, Price = 10.5m, Quantity = 2 },
            new Product { Name = "Product 2", ProductId = 2, Price = 15.25m, Quantity = 1 }
        };

        Customer customer1 = new Customer
        {
            Name = "John Smith",
            Address = new Address { Street = "123 Main St", City = "New York", State = "NY", Country = "USA" }
        };

        Order order1 = new Order(products1, customer1);

        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());

        Console.WriteLine();

        List<Product> products2 = new List<Product>
        {
            new Product { Name = "Product 3", ProductId = 3, Price = 5.99m, Quantity = 3 },
            new Product { Name = "Product 4", ProductId = 4, Price = 8.75m, Quantity = 2 }
        };

        Customer customer2 = new Customer
        {
            Name = "Jane Doe",
            Address = new Address { Street = "456 Elm St", City = "London", State = "", Country = "UK" }
        };

        Order order2 = new Order(products2, customer2);

        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());

        Console.ReadLine();
    }
}
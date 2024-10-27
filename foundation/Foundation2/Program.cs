using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Back Street", "Place", "ID", "USA");
        Address address2 = new Address("999 Park Place", "York", "ID", "USA");

        // Create customers with addresses
        Customer customer1 = new Customer("Truth", address1);
        Customer customer2 = new Customer("Carl", address2);

        // Create products
        Product product1 = new Product("P001", "Laptop", 999.99, 1);
        Product product2 = new Product("P002", "Mouse", 25.99, 2);
        Product product3 = new Product("P003", "Keyboard", 49.99, 1);

        // Create orders and add products to them
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}

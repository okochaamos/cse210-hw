using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Aba Owerri Road", "Aba", "Abia", "Nigeria");
        Address address2 = new Address("350 Ikwerre Road", "PortHarcourt", "Rivers", "Nigeria");

        // Create customers
        Customer customer1 = new Customer("Chimaobi Okoro", address1);
        Customer customer2 = new Customer("Chime Felix", address2);

        // Create products
        Product product1 = new Product("Laptop", "L144", 999.99m, 1);
        Product product2 = new Product("Mouse", "M321", 25.50m, 2);
        Product product3 = new Product("Keyboard", "K667", 49.99m, 1);
        Product product4 = new Product("Monitor", "MN224", 200.00m, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: #{order1.CalculateTotalCost():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: #{order2.CalculateTotalCost():F2}");
    }
}

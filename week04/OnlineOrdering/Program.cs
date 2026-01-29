using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER 1 (USA)
        Address address1 = new Address("123 Main St", "Miami", "FL", "USA");
        Customer customer1 = new Customer("John Carter", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "CH101", 19.99m, 2));
        order1.AddProduct(new Product("USB-C Cable", "CH202", 7.50m, 3));
        order1.AddProduct(new Product("Keyboard", "CH303", 27.90m, 1));

        // ORDER 2 (International)
        Address address2 = new Address("Rua do Sol, 45", "Recife", "PE", "Brazil");
        Customer customer2 = new Customer("Francisco de Paula Barros", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook Stand", "CH404", 37.80m, 1));
        order2.AddProduct(new Product("Bluetooth Headset", "CH505", 43.99m, 1));

        // DISPLAY
        DisplayOrder(order1);
        Console.WriteLine("\n========================================\n");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order.GetTotalPrice():0.00}");
    }
}

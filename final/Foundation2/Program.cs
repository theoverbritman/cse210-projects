using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Main St", "Dallas", "TX", "USA");
        Customer c1 = new Customer("John Smith", a1);
        Order order1 = new Order(c1);

        order1.AddProduct(new Product("Laptop", "L100", 900, 1));
        order1.AddProduct(new Product("Mouse", "M200", 25, 2));

        Address a2 = new Address("55 Queen St", "Toronto", "ON", "Canada");
        Customer c2 = new Customer("Sarah Lee", a2);
        Order order2 = new Order(c2);

        order2.AddProduct(new Product("Phone", "P300", 700, 1));
        order2.AddProduct(new Product("Case", "C400", 20, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.WriteLine("Encapsulation with Online Ordering");
        Console.WriteLine();

        // I decided to create objects through a Constructor rather than through Setters.
        
        // Creating 3 adresses
        Address address1 = new Address("USA", "Utah", "Dover", "100 LAKESHORE");
        Address address2 = new Address("Russia", "Moscow Obl", "Moscow", "Lenina 35");
        Address address3 = new Address("Germany", "Siegfried", "Schulte", "Gasse 6 59678 Karben");

        // Creating 3 customeres
        Customer customer1 = new Customer("Alvin Rios", address1);
        Customer customer2 = new Customer("Ivan Pupkin", address2);
        Customer customer3 = new Customer("Michael Ballard", address3);

        // 3 Lists of products
        List<Product> products1 = new List<Product>()
        {
            new Product("Phone case for IPhone 13", 123, 20, 2),
            new Product("IPhone 13", 234, 700, 1),
            new Product("Protection glass for IPhone 15", 345, 10, 2),
        };

        List<Product> products2 = new List<Product>()
        {
            new Product("Phone case for IPhone 15", 127, 30, 1),
            new Product("IPhone 15", 237, 900, 1),
            new Product("Protection glass for IPhone 15", 347, 15, 2),
        };

        List<Product> products3 = new List<Product>()
        {
            new Product("Phone case for Pixel7", 123, 20, 1),
            new Product("Pixel7", 239, 500, 1),
            new Product("Protection glass for Pixel7", 345, 10, 1),
        };

        // Creating 3 orders with a 3 products each
        Order order1 = new Order(customer1, products1);
        Order order2 = new Order(customer2, products2);
        Order order3 = new Order(customer3, products3);
        
        Console.WriteLine("Orders:");

        Console.WriteLine("Order 1");
        order1.GetPackingLabel();
        order1.GetShippingLabel();
        order1.CalculateAndPrintTotalCost();

        Console.WriteLine("Order 2");
        order2.GetPackingLabel();
        order2.GetShippingLabel();
        order2.CalculateAndPrintTotalCost();

        Console.WriteLine("Order 3");
        order3.GetPackingLabel();
        order3.GetShippingLabel();
        order3.CalculateAndPrintTotalCost();
    }
}
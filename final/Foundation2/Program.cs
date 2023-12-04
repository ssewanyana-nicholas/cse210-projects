using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // products for Order 1
        Product product1Order1 = new Product("Perfume", "P001", 1200.00, 2);
        Product product2Order1 = new Product("Sunsreen", "P002", 25.00, 5);
        Product product3Order1 = new Product("Lotion", "P003", 50.00, 3);

        //  products for Order 2
        Product product1Order2 = new Product("Fragrance", "P101", 800.00, 1);
        Product product2Order2 = new Product("Lip Balm", "P102", 40.00, 2);
        Product product3Order2 = new Product("Deodorant", "P103", 60.00, 1);

        // addresses
        Address usaAddress = new Address("2501 California St", "San Francisco", "CA", "USA");
        Address nonUsaAddress = new Address("82 Ave - 87 St", "Admonton", "Alberta", "Canada");

        //  customers
        Customer customer1 = new Customer("Chris Hamba", usaAddress);
        Customer customer2 = new Customer("Jane Jills", nonUsaAddress);

        //  orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1Order1);
        order1.AddProduct(product2Order1);
        order1.AddProduct(product3Order1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1Order2);
        order2.AddProduct(product2Order2);
        order2.AddProduct(product3Order2);

        // Display Order 1
        Console.WriteLine("=====================================");
        Console.WriteLine("               Order 1");
        Console.WriteLine("=====================================");
        
        Console.WriteLine(order1.GetPackingLabel());
       
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        // Display  Order 2
        Console.WriteLine("=====================================");
        Console.WriteLine("               Order 2");
        Console.WriteLine("=====================================");
        
        Console.WriteLine(order2.GetPackingLabel());
        
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + order2.GetTotalPrice());
    }
}

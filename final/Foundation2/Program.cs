using System;

namespace OrderProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the products
            Product product1 = new Product("Mechanical keyboard", 1, 40.000, 2);
            Product product2 = new Product("Wireless mouse", 2, 34.000, 1);
            Product product3 = new Product("Headphones with mic", 3, 25.000, 3);

            // Create the Clients
            Address address1 = new Address("Cra. 19 # 10N-43", "Quindio", "Colombia", "Pending");
            Client client1 = new Client("Diana Osorio", address1);

            Address address2 = new Address("1959 NE 153 ST", "Florida", "United States", "Send");
            Client client2 = new Client("George Platters", address2);

            // Create the Orders
            Order order1 = new Order(client1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(client2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            // Get the packing label, the shipping label and the total price of the order fot the order 1
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"The total price of the order is: COP{order1.GetFinalPrice():00.000}\n");

            // Get the packing label, the shipping label and the total price of the order fot the order 2
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"The total price of the order is: COP{order2.GetFinalPrice():00.000}");

            // Wait for the user press any key to exit the program
            Console.ReadKey();
        }
    }
}

    
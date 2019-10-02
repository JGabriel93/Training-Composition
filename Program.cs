using System;
using System.Collections.Generic;
using Training_Composition.Entities;
using Training_Composition.Entities.Enums;

namespace Training_Composition
{
    class Program
    {
        static void Main(string[] args) 
        {
            /* Reads the client's data;
               Reads a N number of orders;
               Reads the order's data
               Informs the order's summary at the end. */

            Console.WriteLine("Enter Client's Data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine();
            Console.WriteLine("Enter Order Data: ");
            Console.WriteLine();

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime moment = DateTime.Now;

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            List<OrderItem> new_order = new List<OrderItem>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter item #{i} data: ");
                Console.WriteLine();

                Console.Write("Product Name: ");
                string product_name = Console.ReadLine();
    
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                
                Product product = new Product(product_name, price);
                OrderItem item = new OrderItem(quantity, price, product);
                order.AddItem(item);             
            }
            
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
            

        }
    }
}

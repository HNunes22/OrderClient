using OrderClient.Entities;
using OrderClient.Entities.Enums;

namespace OrderClient
{
    class Program
    {
        static void Main(string[] args)
        {

            // Client

            Console.WriteLine("Enter Cliente Data: ");

            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, clientBirthDate);

            Console.WriteLine();

            // Order 
            
            Console.WriteLine("Enter order data: ");

            Console.Write("Status (Peding_Payent/Processing/Shipped/Deliverd): ");

            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, os, client);

            Console.Write("How many items to this order: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                string productName;
                double productPrice;
                int quantity;

                Console.WriteLine($"Enter #{i} item data:");

                Console.Write("Product name: ");
                productName = Console.ReadLine();

                Console.Write("Product Price: ");
                productPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);

                OrderItem item = new OrderItem(quantity, productPrice, product);

                order.addItem(item);

            }

            Console.WriteLine("---- ORDER SUMMARY -----");

            Console.WriteLine(order);

        }
    }
}
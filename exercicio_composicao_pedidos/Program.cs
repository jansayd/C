using System;
using exercicio_composicao_pedidos.Entities.Enums;
using exercicio_composicao_pedidos.Entities;
using System.Globalization;

namespace exercicio_composicao_pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data: ");
            Console.Write("Name: ");
            string varname = Console.ReadLine();
            Console.Write("E-mail: ");
            string varemail = Console.ReadLine();
            Console.Write("Birth Date(DD/MM/YYYY): ");
            DateTime varbirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter Order Data:");
            Console.Write("Status(Pending_Payment / Processing / Shipped / Delivered): ");
            OrderStstus varstatus = Enum.Parse<OrderStstus>(Console.ReadLine());
            
            Client client = new Client(varname, varemail, varbirth);
            Order order = new Order(DateTime.Now, varstatus, client);

            Console.Write("How Many items to this order? ");
            int varitemsorder = int.Parse(Console.ReadLine());
            for(int i = 1; i <= varitemsorder; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product Name: ");
                string varprodname = Console.ReadLine();
                Console.Write("Product Price: ");
                double varprice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int varquantity = int.Parse(Console.ReadLine());
                Product prod = new Product(varprodname, varprice);
                OrderItem orderitem = new OrderItem(varquantity, varprice, prod);
                order.AddItem(orderitem);
            }
                       
            Console.WriteLine(order);
        }
    }
}

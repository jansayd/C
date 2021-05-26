using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using exercicio_composicao_pedidos.Entities.Enums;


namespace exercicio_composicao_pedidos.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStstus Status { get; set; }
        public List<OrderItem> OrderItens { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStstus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItens.Remove(item);
        }

        public double Total()
        {
            double totalorder = 0;
            foreach(OrderItem o in OrderItens)
            {
                totalorder += o.SubTotal();
            }
            return totalorder;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-------------------------------------------------------");
            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine("Order Momente: " + Moment);
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine($"Cliente: {Client.Name}({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine("Order Items:");
            foreach(OrderItem o in OrderItens)
            {
                sb.AppendLine(o.Product.Name +" , $"+o.Price +" , Quantity: " + o.Quantity + " , Subtotal: $" + o.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.AppendLine();
            sb.AppendLine("Total Price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();

        }
    }
}

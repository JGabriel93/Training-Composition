using System;
using System.Collections.Generic;
using System.Text;
using Training_Composition.Entities.Enums;
using System.Globalization;

namespace Training_Composition.Entities
{
    class Order
    {
        // Stores and returns the entire data from multiple orders.

        public DateTime Moment;
        public OrderStatus Status;
        public Client Client { get; set; }
        public List<OrderItem> Orders { get; private set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem (OrderItem item)
        {
            Orders.Add(item);
        }

        public void RemoveItem (OrderItem item)
        {
            Orders.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem value in Orders)
            {
                sum += value.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Items: ");
            foreach (OrderItem item in Orders)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}

using OrderClient.Entities.Enums;
using System.Text;

namespace OrderClient.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client {  get; set; }
        public List<OrderItem> Items { get ; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item) { 
            Items.Add(item);
        }

        public void removeItem(OrderItem item) { 
            Items.Remove(item); 
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items) {
                sum += item.subTotal();
            
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy hh:mm:ss"));

            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());

            sb.Append("Client: ");
            sb.AppendLine($"{Client.ClientName} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");

            sb.AppendLine("Order Items");
            foreach (OrderItem item in Items) {

                sb.AppendLine($"{item.Product.ProductName} / ${item.PriceItem.ToString("F2")} / Quantity: {item.QuantityItem} / SubTotal: {item.subTotal().ToString("F2")}");
            }

            sb.Append($"Total Price: ${Total().ToString("F2")}");

            return sb.ToString();
        }
    }
}

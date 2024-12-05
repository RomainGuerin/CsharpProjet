using System;
using System.Diagnostics;
using System.Text;
using domain.entities;

namespace domain.repositories
{
    public class Order
    {
        public Guid IdOrder { get; set; }
        public Cart Cart { get; set; }
        public OrderStatus Status { get; set; }

        public Order()
        {
            this.IdOrder = Guid.NewGuid();
            this.Cart = new Cart();
            this.Status = OrderStatus.Pending;
        }

        public void ValidateOrder()
        {
            if (Cart.GetTotalItems() == 0)
            {
                throw new InvalidOperationException("Impossible de valider une commande avec un panier vide.");
            }
            this.Status = OrderStatus.Approved;
            Console.WriteLine(GenerateSummary());
        }

        public string GenerateSummary()
        {
            StringBuilder summary = new StringBuilder();
            summary.AppendLine($"Order ID: {IdOrder}");
            summary.AppendLine($"Status: {Status}");
            summary.AppendLine("Articles:");
            foreach (var item in Cart.GetItems())
            {
                summary.AppendLine($"- {item.Name}: {item.Quantity} @ {item.Price:C} (Type: {item.Type})");
            }
            summary.AppendLine($"Total Price: {Cart.CalculateTotal():C}");
            return summary.ToString();
        }

        internal void CancelOrder()
        {
            this.Status = OrderStatus.Cancelled;
        }

        internal void ApproveOrder()
        {
            this.Status = OrderStatus.Approved;
            Debug.WriteLine($"Approved Order : {this.IdOrder}");
        }
    }
}


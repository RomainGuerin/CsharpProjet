using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using domain.entities;
using domain.repositories;

namespace UseCases
{
    public class OrderService
    {
        private BindingList<Order> orders;

        public OrderService()
        {
            orders = new BindingList<Order>();
        }

        public void ValidateLastOrder()
        {
            Order lastOrder = orders.Last();
            if (lastOrder.Cart.GetTotalItems() == 0)
                throw new InvalidOperationException("Impossible de valider une commande avec un panier vide.");

            lastOrder.ApproveOrder();
            Debug.WriteLine($"Commande validée. {GenerateLastOrderSummary()}");
        }

        public void CancelLastOrder()
        {
            Order lastOrder = orders.Last();
            lastOrder.CancelOrder();
            Console.WriteLine($"Commande annulée. {GenerateLastOrderSummary()}");
        }

        public string GenerateLastOrderSummary()
        {
            Order lastOrder = orders.Last();
            StringBuilder summary = new StringBuilder();
            summary.AppendLine($"Id de la commande: {lastOrder.IdOrder}");
            summary.AppendLine($"État de la commande: {lastOrder.Status}");
            summary.AppendLine("Articles de la commande:");
            foreach (var item in lastOrder.Cart.GetItems())
            {
                summary.AppendLine($"- {item.Name}: {item.Quantity} x {item.Price:C} (Type: {item.Type})");
            }
            summary.AppendLine($"Total de la commande: {lastOrder.Cart.CalculateTotal():C}");
            return summary.ToString();
        }

        public Order GetLastOrder()
        {
            Order lastOrder = orders.Last();
            return lastOrder;
        }
        public BindingList<Order> GetAll() => orders;
        public void Add(Order item)
        {
            this.orders.Add(item);
        }
    }
}

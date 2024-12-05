using domain.entities;

namespace domain.repositories
{
    public class Order
    {
        public string IdOrder { get; set; }
        public Cart Cart { get; set; }
        public OrderStatus Status { get; set; }

        public Order(string idOrder)
        {
            this.IdOrder = idOrder;
            this.Cart = new Cart();
            this.Status = OrderStatus.Pending;
        }

        public void addCart(Cart cart)
        {
            this.Cart = cart;
        }

        public void approvedOrder()
        {
            this.Status = OrderStatus.Approved;
        }

        public void cancelOrder()
        {
            this.Status = OrderStatus.Cancelled;
        }
    }
}

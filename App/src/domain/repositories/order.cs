using domain.entities;

namespace domain.repositories
{
    public class Order
    {
        public string idOrder { get; set; }
        public List<Cart> cart { get; set; }
        public OrderStatus status { get; set; }

        public Order(string idOrder, List<Cart> cart, OrderStatus status)
        {
            this.idOrder = idOrder;
            this.cart = cart;
            this.status = status;
        }

        public void addCart(Cart cart)
        {
            this.cart.Add(cart);
        }

        public void approvedOrder()
        {
            this.status = OrderStatus.Approved;
        }

        public void cancelOrder()
        {
            this.status = OrderStatus.Cancelled;
        }
    }
}

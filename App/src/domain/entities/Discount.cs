namespace domain.entities
{
    public delegate double DiscountStrategy(Cart cart);
    public class DiscountStrategyProvider
    {
        public DiscountType DiscountType { get; set; }
        public int DiscountValue { get; set; }

        public DiscountStrategy GetDiscountStrategy()
        {
            return cart => { 
                switch (DiscountType)
                {
                    case DiscountType.Percentage:
                        double discountPercentage = cart.CalculateTotal() * DiscountValue / 100;
                        double discountTotal = cart.CalculateTotal() - discountPercentage;
                        return discountTotal < 1 ? 1 : discountTotal;
                    case DiscountType.FixedAmount:
                        double discountFixed = cart.CalculateTotal() - DiscountValue;
                        return discountFixed < 1 ? 1 : discountFixed; 
                    default:
                        return cart.CalculateTotal(); 
                } 
            };
        }
    }
}

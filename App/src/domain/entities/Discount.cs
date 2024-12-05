namespace domain.entities
{
    public delegate decimal DiscountStrategy(Cart cart);
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
                        decimal discountPercentage = cart.CalculateTotal() * DiscountValue / 100m;
                        decimal discountTotal = cart.CalculateTotal() - discountPercentage;
                        return discountTotal < 1 ? 1 : discountTotal;
                    case DiscountType.FixedAmount:
                        decimal discountFixed = cart.CalculateTotal() - DiscountValue;
                        return discountFixed < 1 ? 1 : discountFixed; 
                    default:
                        return cart.CalculateTotal(); 
                } 
            };
        }
    }
}

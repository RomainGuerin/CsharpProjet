namespace domain.entities
{
    public enum ArticleType
    {
        Food,
        Drugstore,
        Clothing,
        Leisure,
        Other
    }

    public class Article
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public ArticleType type { get; set; }

        public Article(string name, decimal price, int quantity, ArticleType type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }

        public void showArticle()
        {
            Console.WriteLine($"Article : {name}, Price : {price}, Quantity : {quantity}, Type : {type}");
        }

        public void addQuantity(int newQuantity)
        {
            if (newQuantity > 0)
            {
                quantity += newQuantity;
            }
            else
            {
                throw new System.Exception("The quantity to add must be a positive integer.");
            }
        }

        public void removeQuantity(int quantity)
        {
            if (quantity > 0 && quantity <= this.quantity)
            {
                this.quantity -= quantity;
            }
            else
            {
                throw new System.Exception("Invalid quantity.");
            }
        }
    }
}

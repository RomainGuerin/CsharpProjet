using System;

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
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public ArticleType Type { get; set; }

        public Article()
        {
            this.Id = 0;
            this.Name = "";
            this.Price = 0.0;
            this.Quantity = 0;
            //this.Type = null;
        }
        public Article(string name, double price, int quantity, ArticleType type)
        {
            this.Id = 0;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Type = type;
        }

        public void showArticle() //temporaire
        {
            Console.WriteLine("Article : Name {0}, Price : {1}, Quantity : {2}, Type : {3}", Name, Price, Quantity, Type.ToString());
        }

        public void addQuantity(int newQuantity)
        {
            if (newQuantity > 0)
            {
                Quantity += newQuantity;
            }
            else
            {
                throw new System.Exception("The quantity to add must be a positive integer.");
            }
        }

        public void removeQuantity(int quantity)
        {
            if (quantity > 0 && quantity <= this.Quantity)
            {
                this.Quantity -= quantity;
                if (this.Quantity == 0)
                {
                    Console.WriteLine("La quantit� est maintenant z�ro.");
                }
            }
            else
            {
                throw new System.Exception("Quantit� invalide.");
            }
        }

    }
}

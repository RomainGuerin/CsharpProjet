using domain.entities;
using System.Collections.Generic;
using System;

namespace Domain.Entities
{
    public class Cart
    {
        private Dictionary<string, Article> items; // Key: Article name

        public Cart()
        {
            items = new Dictionary<string, Article>();
        }

        public void AddItem(Article article)
        {
            if (items.ContainsKey(article.name))
            {
                items[article.name].addQuantity(article.quantity);
            }
            else
            {
                items.Add(article.name, new Article(
                    article.name,
                    article.price,
                    article.quantity,
                    article.type
                ));
            }
        }

        public void RemoveItem(string name, int quantity)
        {
            if (items.ContainsKey(name))
            {
                var item = items[name];
                item.removeQuantity(quantity);

                if (item.quantity == 0)
                {
                    items.Remove(name);
                }
            }
            else
            {
                throw new Exception($"Item '{name}' is not in the cart.");
            }
        }

        public decimal CalculateTotal()
        {
            return items.Values.Sum(item => item.price * item.quantity);
        }

        public Dictionary<ArticleType, decimal> CalculateTotalByCategory()
        {
            var totalsByCategory = new Dictionary<ArticleType, decimal>();

            foreach (var article in items.Values)
            {
                if (!totalsByCategory.ContainsKey(article.type))
                {
                    totalsByCategory[article.type] = 0;
                }
                totalsByCategory[article.type] += article.price * article.quantity;
            }

            return totalsByCategory;
        }

        public void ShowCart()
        {
            if (!items.Any())
            {
                Console.WriteLine("The cart is empty.");
                return;
            }

            foreach (var article in items.Values)
            {
                article.showArticle();
            }

            Console.WriteLine($"Total Price: {CalculateTotal():C}");
        }

        public void ClearCart()
        {
            items.Clear();
        }
    }
}

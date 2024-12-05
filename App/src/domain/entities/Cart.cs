using domain.entities;
using System.Collections.Generic;
using System;
using System.Linq;

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
            if (items.ContainsKey(article.Name))
            {
                items[article.Name].addQuantity(article.Quantity);
            }
            else
            {
                items.Add(article.Name, new Article(
                    article.Name,
                    article.Price,
                    article.Quantity,
                    article.Type
                ));
            }
        }

        public void RemoveItem(string name, int quantity)
        {
            if (items.ContainsKey(name))
            {
                var item = items[name];
                item.removeQuantity(quantity);

                if (item.Quantity == 0)
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
            return items.Values.Sum(item => item.Price * item.Quantity);
        }

        public Dictionary<ArticleType, decimal> CalculateTotalByCategory()
        {
            var totalsByCategory = new Dictionary<ArticleType, decimal>();

            foreach (var article in items.Values)
            {
                if (!totalsByCategory.ContainsKey(article.Type))
                {
                    totalsByCategory[article.Type] = 0;
                }
                totalsByCategory[article.Type] += article.Price * article.Quantity;
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

            // foreach (var article in items.Values)
            // {
            //     article.showArticle();
            // }

            Console.WriteLine($"Total Price: {CalculateTotal():C}");
        }

        public void ClearCart()
        {
            items.Clear();
        }
    }
}

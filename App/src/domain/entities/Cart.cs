﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace domain.entities
{
    public class Cart
    {
        private Dictionary<string, Article> items;

        public Cart()
        {
            items = new Dictionary<string, Article>();
        }

        public Dictionary<string, Article> getAll()
        {
            return items;
        }

        public void AddItem(Article article, int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.");
            }

            if (items.ContainsKey(article.Name))
            {
                items[article.Name].addQuantity(quantity);
            }
            else
            {
                items.Add(article.Name, new Article(
                    article.Name,
                    article.Price,
                    quantity,
                    article.Type
                ));
            }
        }

        public void RemoveItem(Article article, int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.");
            }

            if (items.ContainsKey(article.Name))
            {
                var item = items[article.Name]; 
                if (quantity >= item.Quantity) 
                { 
                    items.Remove(article.Name); 
                    Console.WriteLine($"{article.Name} removed from the cart."); 
                } 
                else 
                { 
                    item.removeQuantity(quantity); 
                    Console.WriteLine($"{quantity} x {article.Name} removed from the cart. Remaining quantity: {item.Quantity}");
                }
            }
            else
            {
                throw new Exception($"Item '{article.Name}' is not in the cart.");
            }
        }

        public double CalculateTotal()
        {
            return items.Values.Sum(item => item.Price * item.Quantity);
        }

        public Dictionary<ArticleType, double> CalculateTotalByCategory()
        {
            var totalsByCategory = new Dictionary<ArticleType, double>();

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
        public void ShowCart() //temporaire
        {
            if (!items.Any())
            {
                Console.WriteLine("The cart is empty.");
                return;
            }

            Console.WriteLine("Cart contents:");
            foreach (var article in items.Values)
            {
                Console.WriteLine($"- {article.Name}: {article.Quantity} @ {article.Price:C} each (Type: {article.Type})");
            }

            Console.WriteLine($"Total Price: {CalculateTotal():C}");
        }

        public void ClearCart()
        {
            items.Clear();
        }
        public int GetTotalItems()
        {
            return items.Values.Sum(article => article.Quantity);
        }

        public List<Article> GetItems()
        {
            return items.Values.ToList();
        }

    }
}

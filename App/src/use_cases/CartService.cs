using System;
using System.Collections.Generic;
using System.Text;
using domain.entities;

namespace UseCases
{
    public class CartService
    {
        private Cart _cart;

        public CartService()
        {
            _cart = new Cart(); // Création d'un panier vide
        }

        // Ajouter un article au panier
        public void AddArticleToCart(Article article, int quantity)
        {
            if (article == null)
                throw new ArgumentNullException(nameof(article), "L'article ne peut pas être nul.");

            if (quantity <= 0)
                throw new ArgumentException("La quantité doit être supérieure à zéro.");

            _cart.AddItem(article, quantity);
        }

        // Supprimer un article du panier
        public void RemoveArticleFromCart(Article article, int quantity)
        {
            if (article == null)
                throw new ArgumentNullException(nameof(article), "L'article ne peut pas être nul.");

            if (quantity <= 0)
                throw new ArgumentException("La quantité doit être supérieure à zéro.");

            _cart.RemoveItem(article, quantity);
        }

        // Afficher le récapitulatif du panier
        public string GetCartSummary()
        {
            if (_cart.GetTotalItems() == 0)
                return "Le panier est vide.";

            StringBuilder summary = new StringBuilder();
            summary.AppendLine("Récapitulatif du panier:");
            foreach (var item in _cart.GetItems())
            {
                summary.AppendLine($"- {item.Name}: {item.Quantity} x {item.Price:C} (Type: {item.Type})");
            }
            summary.AppendLine($"Total: {_cart.CalculateTotal():C}");
            return summary.ToString();
        }

        // Vider le panier
        public void ClearCart()
        {
            _cart.ClearCart();
        }

        // Obtenir le panier actuel
        public Cart GetCart()
        {
            return _cart;
        }
    }
}


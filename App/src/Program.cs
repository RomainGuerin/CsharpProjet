using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using domain.repositories;

namespace App
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<Article> articles = JsonHelper.LoadArticles();
            Application.ApplicationExit += (sender, e) => JsonHelper.SaveArticles(articles);
            Application.Run(new MainWindow());

            //// création de la liste d'article
            //List<Article> list = new List<Article>()
            //{
            //    new Article("test", 2, 3, ArticleType.Other),
            //    new Article("test2", 3, 5, ArticleType.Other),
            //    new Article("test3", 7, 2, ArticleType.Other)
            //};
            //foreach (var item in list)
            //{
            //    item.showArticle();
            //}

            //// modification d'un attribut et changement des quantités
            //list[0].Name = "TEST";
            //list[0].addQuantity(1);
            //list[2].removeQuantity(1);

            //// suppression d'un article
            //list.Remove(list[1]);

            //foreach (var item in list)
            //{
            //    item.showArticle();
            //}

            //// gestion du panier
            //Cart cart = new Cart();
            //list[0].removeQuantity(2);
            //cart.AddItem(list[0], 2);
            //cart.AddItem(list[1], 1);
            //list[1].removeQuantity(1);
            //cart.ShowCart();
            //cart.RemoveItem(list[0], 1);
            //list[0].addQuantity(1);
            //cart.ShowCart();

            //foreach (var item in list)
            //{
            //    item.showArticle();
            //}

            //// gestion des promotions
            //DiscountStrategyProvider discountProvider = new DiscountStrategyProvider
            //{
            //    DiscountType = DiscountType.Percentage,
            //    DiscountValue = 10
            //};
            //DiscountStrategy discountStrategy = discountProvider.GetDiscountStrategy();
            //decimal discountedTotal = discountStrategy(cart);
            //Console.WriteLine($"Discounted Percentage Total: {discountedTotal}");

            //discountProvider.DiscountType = DiscountType.FixedAmount;
            //discountedTotal = discountStrategy(cart);
            //Console.WriteLine($"Discounted FixedAmount Total: {discountedTotal}");

            //// gestion de la commande
            //Order order = new Order("fzegferjog");
            //order.addCart(cart);
            //order.showOrder();
            //order.approvedOrder();
            //order.showOrder();
            //order.cancelOrder();
            //order.showOrder();
        }
    }
}

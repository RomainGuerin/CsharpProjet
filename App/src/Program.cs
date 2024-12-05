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
            Application.Run(new MainWindow());

            //List<Article> list = new List<Article>()
            //{
            //    new Article("test", 2, 3, ArticleType.Other),
            //    new Article("test2", 3, 5, ArticleType.Other),
            //    new Article("test3", 7, 2, ArticleType.Other)
            //};

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Cart cart = new Cart();
            //cart.AddItem(list[0]);
            //Console.WriteLine(cart.CalculateTotal());
            //cart.ShowCart();

            //Order order = new Order("fzegferjog");
            //order.addCart(cart);
            //Console.WriteLine(order.ToString());
            //order.approvedOrder();
            //Console.WriteLine(order.ToString());
        }
    }
}

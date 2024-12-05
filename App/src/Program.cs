using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using domain.entities;
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
        }
    }
}

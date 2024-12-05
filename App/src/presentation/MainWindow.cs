using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.src.presentation;
using domain.entities;
using UseCases; 

namespace App
{
    public partial class MainWindow : Form
    {
        private ArticleService articlesService;

        public MainWindow(ArticleService articleService)
        {
            InitializeComponent();
            dataGridViewArticles.AutoGenerateColumns = true;
            this.articlesService = articleService;
            this.LoadArticles();
        }

        private void LoadArticles()
        {
            Debug.WriteLine($"Load Articles {articlesService.GetAll().Count}");
            dataGridViewArticles.DataSource = null;
            dataGridViewArticles.DataSource = articlesService.GetAll();
            dataGridViewArticles.Update();
            dataGridViewArticles.Refresh();
        }

        private void buttonAddArticle_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Click Articles");
            //this.articlesService.Add(new Article("New Article", 12.3, 14, domain.entities.ArticleType.Food));
            using (AddArticleForm form = new AddArticleForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Article newArticle = form.article;
                    articlesService.Add(newArticle);
                    MessageBox.Show("New article add");
                }
            }
            this.LoadArticles();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Article selectedArticle = new Article("Article To Update", 12.3, 154, ArticleType.Clothing);
            using (AddArticleForm form = new AddArticleForm(selectedArticle))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Article newArticle = form.article;
                    articlesService.Add(newArticle);
                    MessageBox.Show("Article Updated");
                }
            }
        }
    }
}

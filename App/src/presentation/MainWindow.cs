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
        private Cart cart;
        private string LastValidCode = "";

        public MainWindow(ArticleService articleService)
        {
            InitializeComponent();
            dataGridViewArticles.AutoGenerateColumns = true;
            dataGridViewArticles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewArticles.MultiSelect = false;
            this.articlesService = articleService;
            this.LoadArticles();
            this.UpdateTotalLabel();
        }

        private void LoadArticles()
        {
            Debug.WriteLine($"Load Articles {articlesService.GetAll().Count}");
            dataGridViewArticles.DataSource = null;
            dataGridViewArticles.DataSource = articlesService.GetAll();
            dataGridViewArticles.Update();
            dataGridViewArticles.Refresh();
            if (dataGridViewArticles.Columns["Delete"] == null) { 
                this.AddDeleteButton(); 
            }
            dataGridViewArticles.Columns["Delete"].DisplayIndex = dataGridViewArticles.Columns.Count - 1;
        }

        private void AddDeleteButton()
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Width = 80;
            dataGridViewArticles.Columns.Add(deleteButtonColumn);
            dataGridViewArticles.CellContentClick += new DataGridViewCellEventHandler(buttonDeleteArticle_Click);
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
            this.UpdateTotalLabel();
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            //Article selectedArticle = new Article("Article To Update", 12.3, 154, ArticleType.Clothing);
            Article selectedArticle = (Article)dataGridViewArticles.SelectedRows[0].DataBoundItem;
            using (AddArticleForm form = new AddArticleForm(selectedArticle))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Article newArticle = form.article;
                    articlesService.Update(newArticle);
                    MessageBox.Show("Article Updated");
                    LoadArticles();
                }
            }
        }
        private void buttonDeleteArticle_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewArticles.Columns["Delete"].Index && e.RowIndex >= 0)
            { 
                Article selectedArticle = (Article)dataGridViewArticles.Rows[e.RowIndex].DataBoundItem;
                articlesService.Delete(selectedArticle.Id);
                MessageBox.Show("Article deleted");
                this.LoadArticles();
                this.UpdateTotalLabel();
            }
        }

        private void UpdateTotalLabel()
        {
            //only for test
            this.cart = new Cart();
            foreach (var article in articlesService.articles)
                this.cart.AddItem(article, 1);
            double total = GetTotalAmount(false, LastValidCode);
            Debug.WriteLine($"Updating label2 with total: {total}");
            this.label2.Text = $"{total:C}";
            this.label2.Refresh();
        }

        private void OkCodePromo_Click(object sender, EventArgs e)
        {
            string promoCode = textBoxCodePromo.Text;
            this.GetTotalAmount(true, promoCode);
            this.UpdateTotalLabel();
        }

        private double GetTotalAmount(bool check, string promoCode)
        {
            DiscountStrategyProvider discountProvider = new DiscountStrategyProvider
            {
                DiscountType = DiscountType.Percentage,
                DiscountValue = 10
            };

            if (promoCode == "1234")
            {
                LastValidCode = "1234";
                DiscountStrategy discountStrategy = discountProvider.GetDiscountStrategy();
                double discountedTotal = discountStrategy(cart);
                if (check)
                {
                    MessageBox.Show($"Valid promo code!");
                }
                this.label3.Text = $"Last reduction code {LastValidCode} (-{discountProvider.DiscountValue}%)";
                this.label3.Refresh();
                return discountedTotal;
            }
            else if (promoCode == "12345")
            {
                LastValidCode = "12345";
                DiscountStrategy discountStrategy = discountProvider.GetDiscountStrategy();
                discountProvider.DiscountType = DiscountType.FixedAmount;
                double discountedTotal = discountStrategy(cart);
                if (check)
                {
                    MessageBox.Show($"Valid promo code!");
                }
                this.label3.Text = $"Last reduction code {LastValidCode} (-{discountProvider.DiscountValue:C})";
                this.label3.Refresh();
                return discountedTotal;
            }
            else
            {
                if (check)
                {
                    MessageBox.Show("Invalid promo code.");
                }
                return cart.CalculateTotal();
            }
        }
    }
}

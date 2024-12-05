using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using App.src.presentation;
using domain.entities;
using domain.repositories;
using UseCases;

namespace App
{
    public partial class MainWindow : Form
    {
        private ArticleService articlesService;
        private CartService cartService;
        private OrderService orderService;

        public MainWindow(ArticleService articleService, CartService cartService, OrderService orderService)
        {
            InitializeComponent();
            dataGridViewArticles.AutoGenerateColumns = true;
            dataGridViewArticles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewArticles.MultiSelect = false;
            this.articlesService = articleService;
            this.cartService = cartService;
            this.orderService = orderService;
            this.LoadArticles();
        }

        private void LoadArticles()
        {
            Debug.WriteLine($"Load Articles {articlesService.GetAll().Count}");
            dataGridViewArticles.DataSource = null;
            dataGridViewArticles.DataSource = articlesService.GetAll();
            dataGridViewArticles.Update();
            dataGridViewArticles.Refresh();
            if (dataGridViewArticles.Columns["Delete"] == null)
            {
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
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Cart cart = cartService.GetCart();
                Order order = new Order();
                order.Cart = cart;
                orderService.Add(order);
                
                MessageBox.Show(orderService.GenerateLastOrderSummary(), "Order Summary");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}

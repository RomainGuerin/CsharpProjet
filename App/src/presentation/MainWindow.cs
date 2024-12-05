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
            this.cart = new Cart();

            InitializeComponent();
            dataGridViewArticles.AutoGenerateColumns = true;
            dataGridViewArticles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewArticles.MultiSelect = false;
            this.articlesService = articleService;
            this.LoadArticles();
            this.UpdateCart();
            this.UpdateTotalLabel();

            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.DataSource = null;

            this.dataGridView2.Columns.Add("Name", "Name");
            this.dataGridView2.Columns.Add("Quantity", "Quantity");
            this.dataGridView2.Columns.Add("Price", "Price");
            this.dataGridView2.Columns.Add("Total", "Total");

            DataGridViewButtonColumn decrementButtonColumn = new DataGridViewButtonColumn 
            {
                Name = "Decrement", 
                HeaderText = "-1", 
                Text = "-1", 
                UseColumnTextForButtonValue = true,
                Width = 40 
            }; 
            this.dataGridView2.Columns.Add(decrementButtonColumn); 
            this.dataGridView2.CellContentClick += dataGridView2_CellContentClick;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        { 
            if (e.RowIndex >= 0 && this.dataGridView2.Columns[e.ColumnIndex].Name == "Decrement") 
            { 
                var item = this.cart.getAll().ElementAt(e.RowIndex).Value; 
                if (item.Quantity > 0) 
                { 
                    item.Quantity--; 
                    if (item.Quantity == 0) 
                    { 
                        this.cart.RemoveItem(item, 1); 
                    } 
                    this.UpdateCart(); 
                    this.UpdateTotalLabel(); 
                } 
            } 
        }
        private void UpdateCart()
        {
            this.dataGridView2.Rows.Clear();
            foreach (var item in this.cart.getAll())
            {
                this.dataGridView2.Rows.Add(item.Value.Name, item.Value.Quantity, item.Value.Price, item.Value.Price * item.Value.Quantity);
            }
            this.dataGridView2.Update();
            this.dataGridView2.Refresh();
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

            if (dataGridViewArticles.Columns["AddToCart"] == null)
            {
                this.AddQuantityControl();
            }
            dataGridViewArticles.Columns["Quantity"].DisplayIndex = dataGridViewArticles.Columns.Count - 1;
            dataGridViewArticles.Columns["Add"].DisplayIndex = dataGridViewArticles.Columns.Count - 1;
            dataGridViewArticles.Columns["Subtract"].DisplayIndex = dataGridViewArticles.Columns.Count - 1;
            dataGridViewArticles.Columns["AddToCart"].DisplayIndex = dataGridViewArticles.Columns.Count - 1;
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
            this.UpdateCart();
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
                    this.LoadArticles();
                    this.UpdateCart();
                    this.UpdateTotalLabel();
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
                this.UpdateCart();
                this.UpdateTotalLabel();
            }
        }

        private void UpdateTotalLabel()
        {
            //only for test
            //this.cart = new Cart();
            //foreach (var article in articlesService.articles)
            //    this.cart.AddItem(article, 1);
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

        private void AddQuantityControl()
        {
            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "Quantity",
                Width = 60,
                ValueType = typeof(int),
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };
            dataGridViewArticles.Columns.Add(quantityColumn);

            DataGridViewButtonColumn addButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Add",
                HeaderText = "+",
                Text = "+",
                UseColumnTextForButtonValue = true,
                Width = 40
            };
            dataGridViewArticles.Columns.Add(addButtonColumn);

            DataGridViewButtonColumn subtractButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Subtract",
                HeaderText = "-",
                Text = "-",
                UseColumnTextForButtonValue = true,
                Width = 40
            };
            dataGridViewArticles.Columns.Add(subtractButtonColumn);

            DataGridViewButtonColumn addToCartButtonColumn = new DataGridViewButtonColumn
            {
                Name = "AddToCart",
                HeaderText = "Add to Cart",
                Text = "Add to Cart",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dataGridViewArticles.Columns.Add(addToCartButtonColumn);

            dataGridViewArticles.CellContentClick += DataGridViewArticles_CellContentClick;
        }

        private void DataGridViewArticles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewArticles.Columns[e.ColumnIndex].Name == "Add")
                {
                    AdjustQuantity(e.RowIndex, 1);
                }
                else if (dataGridViewArticles.Columns[e.ColumnIndex].Name == "Subtract")
                {
                    AdjustQuantity(e.RowIndex, -1);
                }
                else if (dataGridViewArticles.Columns[e.ColumnIndex].Name == "AddToCart")
                {
                    AddArticleToCart(e.RowIndex);
                }
            }
        }
        private void AdjustQuantity(int rowIndex, int adjustment)
        {
            var quantityCell = dataGridViewArticles.Rows[rowIndex].Cells["Quantity"];
            if (quantityCell.Value == null || !(quantityCell.Value is int))
            {
                quantityCell.Value = 0;
            }

            int currentQuantity = (int)quantityCell.Value;
            int newQuantity = currentQuantity + adjustment;

            if (newQuantity >= 0)
            {
                quantityCell.Value = newQuantity;
            }
        }
        private void AddArticleToCart(int rowIndex)
        {
            var article = (Article)dataGridViewArticles.Rows[rowIndex].DataBoundItem;

            var quantityCell = dataGridViewArticles.Rows[rowIndex].Cells["Quantity"];
            if (quantityCell.Value == null || !(quantityCell.Value is int))
            {
                MessageBox.Show("Veuillez spécifier une quantité valide.");
                return;
            }

            int quantity = (int)quantityCell.Value;

            AddToCart(article, quantity);
        }

        private void AddToCart(Article article, int quantity)
        {
            try
            {
                cart.AddItem(article, quantity);
                MessageBox.Show($"{quantity} x {article.Name} ajouté(s) au panier !");
                Debug.WriteLine(ShowCartContents());
                this.UpdateCart();
                this.UpdateTotalLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout au panier : {ex.Message}");
            }
        }

        private string ShowCartContents()
        {
            var cartContents = new System.Text.StringBuilder("Contenu du panier :\n");

            foreach (var item in cart.getAll().Values)
            {
                cartContents.AppendLine($"{item.Name} - {item.Quantity} x {item.Price:C}");
            }

            cartContents.AppendLine($"Total: {cart.CalculateTotal():C}");
            return cartContents.ToString();
        }
    }
}

namespace App
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonCart = new System.Windows.Forms.Button();
            this.buttonShop = new System.Windows.Forms.Button();
            this.dataGridViewArticles = new System.Windows.Forms.DataGridView();
            this.buttonAddNewArticle = new System.Windows.Forms.Button();
            this.TextListOfArticle = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.buttonCart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonShop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddNewArticle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonOrder, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextListOfArticle, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1012, 104);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonOrder.ForeColor = System.Drawing.Color.White;
            this.buttonOrder.Location = new System.Drawing.Point(681, 2);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(329, 46);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonCommande_Click);
            // 
            // buttonCart
            // 
            this.buttonCart.AutoSize = true;
            this.buttonCart.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonCart.ForeColor = System.Drawing.Color.White;
            this.buttonCart.Location = new System.Drawing.Point(338, 2);
            this.buttonCart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Size = new System.Drawing.Size(339, 46);
            this.buttonCart.TabIndex = 1;
            this.buttonCart.Text = "Cart";
            this.buttonCart.UseVisualStyleBackColor = false;
            this.buttonCart.Click += new System.EventHandler(this.buttonPanier_Click);
            // 
            // buttonShop
            // 
            this.buttonShop.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonShop.ForeColor = System.Drawing.Color.White;
            this.buttonShop.Location = new System.Drawing.Point(2, 2);
            this.buttonShop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(332, 46);
            this.buttonShop.TabIndex = 0;
            this.buttonShop.Text = "Shop";
            this.buttonShop.UseVisualStyleBackColor = false;
            this.buttonShop.Click += new System.EventHandler(this.buttonMagasin_Click);
            // 
            // dataGridViewArticles
            // 
            this.dataGridViewArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Type,
            this.Price,
            this.Quantity,
            this.Delete});
            this.dataGridViewArticles.Location = new System.Drawing.Point(14, 116);
            this.dataGridViewArticles.Name = "dataGridViewArticles";
            this.dataGridViewArticles.Size = new System.Drawing.Size(1008, 322);
            this.dataGridViewArticles.TabIndex = 6;
            // 
            // buttonAddNewArticle
            // 
            this.buttonAddNewArticle.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonAddNewArticle.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewArticle.Location = new System.Drawing.Point(3, 70);
            this.buttonAddNewArticle.Name = "buttonAddNewArticle";
            this.buttonAddNewArticle.Size = new System.Drawing.Size(128, 29);
            this.buttonAddNewArticle.TabIndex = 3;
            this.buttonAddNewArticle.Text = "Add an Article";
            this.buttonAddNewArticle.UseVisualStyleBackColor = false;
            this.buttonAddNewArticle.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextListOfArticle
            // 
            this.TextListOfArticle.AutoSize = true;
            this.TextListOfArticle.Location = new System.Drawing.Point(339, 67);
            this.TextListOfArticle.Name = "TextListOfArticle";
            this.TextListOfArticle.Padding = new System.Windows.Forms.Padding(130, 10, 130, 0);
            this.TextListOfArticle.Size = new System.Drawing.Size(327, 23);
            this.TextListOfArticle.TabIndex = 4;
            this.TextListOfArticle.Text = "List of Article";
            this.TextListOfArticle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.dataGridViewArticles);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonCart;
        private System.Windows.Forms.Button buttonShop;
        private System.Windows.Forms.DataGridView dataGridViewArticles;
        private System.Windows.Forms.Button buttonAddNewArticle;
        private System.Windows.Forms.Label TextListOfArticle;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
    }
}


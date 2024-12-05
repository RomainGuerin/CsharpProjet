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
            this.buttonAddArticle = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ListOfArticle = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cart = new System.Windows.Forms.Label();
            this.OkCodePromo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodePromo = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.SummaryOrder = new System.Windows.Forms.Label();
            this.IdOfOrder = new System.Windows.Forms.Label();
            this.StateOfOrder = new System.Windows.Forms.Label();
            this.NameForOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeForOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceForOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityForOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOrder = new System.Windows.Forms.Label();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddArticle
            // 
            this.buttonAddArticle.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonAddArticle.ForeColor = System.Drawing.Color.White;
            this.buttonAddArticle.Location = new System.Drawing.Point(0, 2);
            this.buttonAddArticle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddArticle.Name = "buttonAddArticle";
            this.buttonAddArticle.Size = new System.Drawing.Size(212, 29);
            this.buttonAddArticle.TabIndex = 0;
            this.buttonAddArticle.Text = "Add An Article";
            this.buttonAddArticle.UseVisualStyleBackColor = false;
            this.buttonAddArticle.Click += new System.EventHandler(this.buttonMagasin_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Location = new System.Drawing.Point(1, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1041, 451);
            this.TabControl.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ListOfArticle);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.buttonAddArticle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1033, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shop";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonConfirm);
            this.tabPage2.Controls.Add(this.Total);
            this.tabPage2.Controls.Add(this.textBoxCodePromo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.OkCodePromo);
            this.tabPage2.Controls.Add(this.Cart);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1033, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Location = new System.Drawing.Point(0, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1033, 391);
            this.dataGridView1.TabIndex = 9;
            // 
            // ListOfArticle
            // 
            this.ListOfArticle.AutoSize = true;
            this.ListOfArticle.Location = new System.Drawing.Point(491, 10);
            this.ListOfArticle.Name = "ListOfArticle";
            this.ListOfArticle.Size = new System.Drawing.Size(67, 13);
            this.ListOfArticle.TabIndex = 10;
            this.ListOfArticle.Text = "List of Article";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CancelOrder);
            this.tabPage3.Controls.Add(this.TotalOrder);
            this.tabPage3.Controls.Add(this.StateOfOrder);
            this.tabPage3.Controls.Add(this.IdOfOrder);
            this.tabPage3.Controls.Add(this.SummaryOrder);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1033, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Order";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Type,
            this.Price,
            this.Quantity});
            this.dataGridView2.Location = new System.Drawing.Point(83, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(857, 272);
            this.dataGridView2.TabIndex = 0;
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
            // Cart
            // 
            this.Cart.AutoSize = true;
            this.Cart.Location = new System.Drawing.Point(495, 3);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(26, 13);
            this.Cart.TabIndex = 1;
            this.Cart.Text = "Cart";
            // 
            // OkCodePromo
            // 
            this.OkCodePromo.Location = new System.Drawing.Point(394, 311);
            this.OkCodePromo.Name = "OkCodePromo";
            this.OkCodePromo.Size = new System.Drawing.Size(75, 23);
            this.OkCodePromo.TabIndex = 2;
            this.OkCodePromo.Text = "OK";
            this.OkCodePromo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Code Promo";
            // 
            // textBoxCodePromo
            // 
            this.textBoxCodePromo.Location = new System.Drawing.Point(152, 311);
            this.textBoxCodePromo.Name = "textBoxCodePromo";
            this.textBoxCodePromo.Size = new System.Drawing.Size(236, 20);
            this.textBoxCodePromo.TabIndex = 4;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(663, 316);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 5;
            this.Total.Text = "Total";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(865, 311);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameForOrder,
            this.TypeForOrder,
            this.PriceForOrder,
            this.QuantityForOrder});
            this.dataGridView3.Location = new System.Drawing.Point(106, 102);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(820, 218);
            this.dataGridView3.TabIndex = 0;
            // 
            // SummaryOrder
            // 
            this.SummaryOrder.AutoSize = true;
            this.SummaryOrder.Location = new System.Drawing.Point(455, 3);
            this.SummaryOrder.Name = "SummaryOrder";
            this.SummaryOrder.Size = new System.Drawing.Size(50, 13);
            this.SummaryOrder.TabIndex = 1;
            this.SummaryOrder.Text = "Summary";
            // 
            // IdOfOrder
            // 
            this.IdOfOrder.AutoSize = true;
            this.IdOfOrder.Location = new System.Drawing.Point(103, 44);
            this.IdOfOrder.Name = "IdOfOrder";
            this.IdOfOrder.Size = new System.Drawing.Size(57, 13);
            this.IdOfOrder.TabIndex = 2;
            this.IdOfOrder.Text = "ID of order";
            // 
            // StateOfOrder
            // 
            this.StateOfOrder.AutoSize = true;
            this.StateOfOrder.Location = new System.Drawing.Point(103, 76);
            this.StateOfOrder.Name = "StateOfOrder";
            this.StateOfOrder.Size = new System.Drawing.Size(71, 13);
            this.StateOfOrder.TabIndex = 3;
            this.StateOfOrder.Text = "State of order";
            // 
            // NameForOrder
            // 
            this.NameForOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameForOrder.HeaderText = "Name";
            this.NameForOrder.Name = "NameForOrder";
            this.NameForOrder.ReadOnly = true;
            // 
            // TypeForOrder
            // 
            this.TypeForOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeForOrder.HeaderText = "Type";
            this.TypeForOrder.Name = "TypeForOrder";
            this.TypeForOrder.ReadOnly = true;
            // 
            // PriceForOrder
            // 
            this.PriceForOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceForOrder.HeaderText = "Price";
            this.PriceForOrder.Name = "PriceForOrder";
            this.PriceForOrder.ReadOnly = true;
            // 
            // QuantityForOrder
            // 
            this.QuantityForOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuantityForOrder.HeaderText = "Quantity";
            this.QuantityForOrder.Name = "QuantityForOrder";
            this.QuantityForOrder.ReadOnly = true;
            // 
            // TotalOrder
            // 
            this.TotalOrder.AutoSize = true;
            this.TotalOrder.Location = new System.Drawing.Point(396, 327);
            this.TotalOrder.Name = "TotalOrder";
            this.TotalOrder.Size = new System.Drawing.Size(31, 13);
            this.TotalOrder.TabIndex = 4;
            this.TotalOrder.Text = "Total";
            // 
            // CancelOrder
            // 
            this.CancelOrder.BackColor = System.Drawing.Color.DarkRed;
            this.CancelOrder.ForeColor = System.Drawing.Color.White;
            this.CancelOrder.Location = new System.Drawing.Point(851, 327);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(75, 23);
            this.CancelOrder.TabIndex = 5;
            this.CancelOrder.Text = "Cancel";
            this.CancelOrder.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.TabControl);
            this.Name = "MainWindow";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddArticle;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ListOfArticle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox textBoxCodePromo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkCodePromo;
        private System.Windows.Forms.Label Cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Label SummaryOrder;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label StateOfOrder;
        private System.Windows.Forms.Label IdOfOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameForOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeForOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceForOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityForOrder;
        private System.Windows.Forms.Button CancelOrder;
        private System.Windows.Forms.Label TotalOrder;
    }
}


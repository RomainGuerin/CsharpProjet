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
            this.buttonMagasin = new System.Windows.Forms.Button();
            this.buttonPanier = new System.Windows.Forms.Button();
            this.buttonCommande = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewArticles = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCommande, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPanier, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMagasin, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1012, 50);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // buttonMagasin
            // 
            this.buttonMagasin.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonMagasin.ForeColor = System.Drawing.Color.White;
            this.buttonMagasin.Location = new System.Drawing.Point(2, 2);
            this.buttonMagasin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMagasin.Name = "buttonMagasin";
            this.buttonMagasin.Size = new System.Drawing.Size(249, 46);
            this.buttonMagasin.TabIndex = 0;
            this.buttonMagasin.Text = "Magasin";
            this.buttonMagasin.UseVisualStyleBackColor = false;
            // 
            // buttonPanier
            // 
            this.buttonPanier.AutoSize = true;
            this.buttonPanier.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonPanier.ForeColor = System.Drawing.Color.White;
            this.buttonPanier.Location = new System.Drawing.Point(255, 2);
            this.buttonPanier.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPanier.Name = "buttonPanier";
            this.buttonPanier.Size = new System.Drawing.Size(249, 46);
            this.buttonPanier.TabIndex = 1;
            this.buttonPanier.Text = "Panier";
            this.buttonPanier.UseVisualStyleBackColor = false;
            // 
            // buttonCommande
            // 
            this.buttonCommande.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonCommande.ForeColor = System.Drawing.Color.White;
            this.buttonCommande.Location = new System.Drawing.Point(508, 2);
            this.buttonCommande.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCommande.Name = "buttonCommande";
            this.buttonCommande.Size = new System.Drawing.Size(249, 46);
            this.buttonCommande.TabIndex = 2;
            this.buttonCommande.Text = "Commande";
            this.buttonCommande.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(761, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Magasin";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewArticles
            // 
            this.dataGridViewArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticles.Location = new System.Drawing.Point(14, 68);
            this.dataGridViewArticles.Name = "dataGridViewArticles";
            this.dataGridViewArticles.Size = new System.Drawing.Size(1008, 370);
            this.dataGridViewArticles.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.dataGridViewArticles);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCommande;
        private System.Windows.Forms.Button buttonPanier;
        private System.Windows.Forms.Button buttonMagasin;
        private System.Windows.Forms.DataGridView dataGridViewArticles;
    }
}


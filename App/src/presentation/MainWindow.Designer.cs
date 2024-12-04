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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonMagasin = new System.Windows.Forms.Button();
            this.buttonPanier = new System.Windows.Forms.Button();
            this.buttonCommande = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonMagasin);
            this.flowLayoutPanel1.Controls.Add(this.buttonPanier);
            this.flowLayoutPanel1.Controls.Add(this.buttonCommande);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(69, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1328, 747);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // buttonMagasin
            // 
            this.buttonMagasin.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonMagasin.ForeColor = System.Drawing.Color.White;
            this.buttonMagasin.Location = new System.Drawing.Point(3, 3);
            this.buttonMagasin.Name = "buttonMagasin";
            this.buttonMagasin.Size = new System.Drawing.Size(435, 69);
            this.buttonMagasin.TabIndex = 0;
            this.buttonMagasin.Text = "Magasin";
            this.buttonMagasin.UseVisualStyleBackColor = false;
            this.buttonMagasin.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPanier
            // 
            this.buttonPanier.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonPanier.ForeColor = System.Drawing.Color.White;
            this.buttonPanier.Location = new System.Drawing.Point(444, 3);
            this.buttonPanier.Name = "buttonPanier";
            this.buttonPanier.Size = new System.Drawing.Size(435, 69);
            this.buttonPanier.TabIndex = 1;
            this.buttonPanier.Text = "Panier";
            this.buttonPanier.UseVisualStyleBackColor = false;
            // 
            // buttonCommande
            // 
            this.buttonCommande.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonCommande.ForeColor = System.Drawing.Color.White;
            this.buttonCommande.Location = new System.Drawing.Point(885, 3);
            this.buttonCommande.Name = "buttonCommande";
            this.buttonCommande.Size = new System.Drawing.Size(435, 69);
            this.buttonCommande.TabIndex = 2;
            this.buttonCommande.Text = "Commande";
            this.buttonCommande.UseVisualStyleBackColor = false;
            this.buttonCommande.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Magasin";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainWindow";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonMagasin;
        private System.Windows.Forms.Button buttonPanier;
        private System.Windows.Forms.Button buttonCommande;
        private System.Windows.Forms.Button button1;
    }
}


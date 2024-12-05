namespace App.src.presentation
{
    partial class AddArticleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.nupPrice = new System.Windows.Forms.NumericUpDown();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(469, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(260, 85);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(325, 82);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 3;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(260, 136);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Price";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(260, 204);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(31, 13);
            this.lbType.TabIndex = 5;
            this.lbType.Text = "Type";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(260, 169);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(46, 13);
            this.lbQuantity.TabIndex = 6;
            this.lbQuantity.Text = "Quantity";
            // 
            // nupPrice
            // 
            this.nupPrice.DecimalPlaces = 2;
            this.nupPrice.Location = new System.Drawing.Point(325, 134);
            this.nupPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupPrice.Name = "nupPrice";
            this.nupPrice.Size = new System.Drawing.Size(120, 20);
            this.nupPrice.TabIndex = 7;
            // 
            // nupQuantity
            // 
            this.nupQuantity.Location = new System.Drawing.Point(325, 169);
            this.nupQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(120, 20);
            this.nupQuantity.TabIndex = 8;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(325, 204);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 9;
            // 
            // AddArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.nupQuantity);
            this.Controls.Add(this.nupPrice);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddArticleForm";
            this.Text = "AddArticleForm";
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.NumericUpDown nupPrice;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.ComboBox cbType;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using domain.entities;

namespace App.src.presentation
{
    public partial class AddArticleForm : Form
    {
        public Article article { get; set; }
        public AddArticleForm()
        {
            InitializeComponent();
            cbType.DataSource = Enum.GetValues(typeof(ArticleType));
            article = new Article();
        }
        public AddArticleForm(Article articleToUpdate)
        {
            InitializeComponent();
            tbName.Text = articleToUpdate.Name;
            nupPrice.Value = (decimal)articleToUpdate.Price;
            nupQuantity.Value = articleToUpdate.Quantity;
            cbType.DataSource = Enum.GetValues(typeof(ArticleType));
            cbType.ValueMember = "";
            cbType.SelectedItem = articleToUpdate.Type;
            article = articleToUpdate;
            btnAdd.Text = "Modify";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Le nom est requis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbType.SelectedItem == null || !Enum.TryParse<ArticleType>(cbType.SelectedItem.ToString(), out _))
            {
                MessageBox.Show("Le type n'est pas correct", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            article.Name = tbName.Text;
            article.Price = (double)nupPrice.Value;
            article.Quantity = (int)nupQuantity.Value;
            article.Type = (ArticleType)cbType.SelectedItem;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

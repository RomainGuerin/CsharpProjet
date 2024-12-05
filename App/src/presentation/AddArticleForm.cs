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
        }
        public AddArticleForm(Article articleToUpdate)
        {
            InitializeComponent();
            tbName.Text = articleToUpdate.Name;
            nupPrice.Value = (decimal)articleToUpdate.Price;
            nupQuantity.Value = articleToUpdate.Quantity;
            cbType.DataSource = Enum.GetValues(typeof(ArticleType));
            cbType.SelectedValue = articleToUpdate.Type;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Le nom est requis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            article = new Article(
                tbName.Text,
                (double)nupPrice.Value,
                (int)nupQuantity.Value,
                (ArticleType)cbType.SelectedItem
            );
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

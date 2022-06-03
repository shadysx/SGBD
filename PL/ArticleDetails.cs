using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace PL
{
    public partial class ArticleDetails : Form
    {
        public ArticleDetails(string articleName)
        {
            InitializeComponent();
            this.BackColor = CustomColor.DarkBlue;
            this.panel1.BackColor = CustomColor.DarkBlue;
            this.labelTop.Text = "Produit Selectionné :";
            this.labelNom.Text = articleName;
            List<Stock> stock = StockAccess.GetStock(articleName);
            DisplayProducts(stock);

        }

        public void AddProduct(string nom, string vendeur, decimal prix, int quantite, string pays)
        {
            ShopArticle article = new ShopArticle(nom, vendeur, prix, quantite, pays);
            article.TopLevel = false;
            this.flowLayoutPanel1.Controls.Add(article);
            article.Show();
        }

        public void DisplayProducts(List<Stock> stock)
        {
            foreach (Stock s in stock)
            {
                AddProduct(s.PRODUCT_NAME, s.SHOP_NAME, s.SELLING_PRICE_EXCL_VAT, s.STOCK_QUANTITY, s.SHOP_COUNTRY);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelNom_Click(object sender, EventArgs e)
        {

        }
    }
}

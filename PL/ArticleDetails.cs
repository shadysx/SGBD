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
            this.label1.Text = articleName;
            List<Stock> stock = StockAccess.GetStock(articleName);
            DisplayProducts(stock);

        }

        public void AddProduct(string vendeur, decimal prix, int quantite, string pays)
        {
            ShopArticle article = new ShopArticle(vendeur, prix, quantite, pays);
            article.TopLevel = false;
            this.flowLayoutPanel1.Controls.Add(article);
            article.Show();
        }

        public void DisplayProducts(List<Stock> stock)
        {
            foreach (Stock s in stock)
            {
                AddProduct(s.SHOP_NAME, s.SELLING_PRICE_EXCL_VAT, s.STOCK_QUANTITY, s.SHOP_COUNTRY);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

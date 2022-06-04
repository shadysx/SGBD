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
    public partial class DetailsTab : Form
    {
        public DetailsTab(string articleName)
        {
            InitializeComponent();
            this.BackColor = CustomColor.DarkBlue;
            this.panel1.BackColor = CustomColor.DarkBlue;            
            this.labelNom.Text = articleName;
            this.iconButton1.IconColor = CustomColor.Orange;
            List<Stock> stock = StockAccess.GetStock(articleName);
            DisplayProducts(stock);

        }

        public void AddProduct(string nom, string vendeur, decimal prix, int quantite, string pays)
        {
            Product article = new Product(nom, vendeur, prix, quantite, pays);
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

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        public DetailsTab(string productName, Image image)
        {
            InitializeComponent();
            this.BackColor = CustomColor.DarkBlue;
            this.panel1.BackColor = CustomColor.DarkBlue;            
            this.labelNom.Text = productName;
            this.iconButton1.IconColor = CustomColor.Orange;
            List<Stock> stocks = StockAccess.GetStock(productName);
            this.pictureBox1.Image = image;            
            DisplayProducts(stocks);

        }

        public void AddProduct(string name, string seller, decimal price, int quantity, string country)
        {
            Product article = new Product(name, seller, price, quantity, country);
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
            Main.mainInstance.OpenChildForm(new ShopTab());
            this.Dispose();
        }
    }
}

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
        public DetailsTab(string productName, string description , Image image)
        {
            InitializeComponent();
            this.BackColor = CustomColor.DarkBlue;
            this.panelTop.BackColor = CustomColor.DarkBlue;            
            this.labelNom.Text = productName;
            this.iconButton1.IconColor = CustomColor.Orange;
            
            this.pictureBox.Image = image;
            this.labelAvailable.ForeColor = CustomColor.Orange;
            this.labelProductDesctiption.ForeColor = CustomColor.Orange;

            this.labelDescription.Text = description;
            this.labelDescription.ForeColor = CustomColor.White;
            this.labelDescription.AutoSize = false;
            this.labelDescription.Size = new System.Drawing.Size(this.panelRight.Size.Width - 150, this.panelRight.Size.Height);

            List<Stock> stocks = StockAccess.GetStock(productName);
            DisplayProducts(stocks);


        }

        public void AddProduct(string name, string seller, decimal price, int quantity, string country, int idShop, int idProduct)
        {
            Article article = new Article(name, seller, price, quantity, country, idShop, idProduct);
            article.TopLevel = false;
            this.flowLayoutPanel1.Controls.Add(article);
            article.Show();
            
        }

        public void DisplayProducts(List<Stock> stock)
        {
            foreach (Stock s in stock)
            {
                AddProduct(s.PRODUCT_NAME, s.SHOP_NAME, s.SELLING_PRICE_EXCL_VAT, s.STOCK_QUANTITY, s.SHOP_COUNTRY, s.ID_SHOP, s.ID_PRODUCT);
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

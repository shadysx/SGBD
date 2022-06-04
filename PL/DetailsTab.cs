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
        public DetailsTab(string productName,string description , Image image)
        {
            InitializeComponent();
            this.BackColor = CustomColor.DarkBlue;
            this.panelTop.BackColor = CustomColor.DarkBlue;            
            this.labelNom.Text = productName;
            this.iconButton1.IconColor = CustomColor.Orange;
            List<Stock> stocks = StockAccess.GetStock(productName);
            this.pictureBox.Image = image;
            this.labelAvailable.ForeColor = CustomColor.Orange;
            this.labelProductDesctiption.ForeColor = CustomColor.Orange;

            // this.labelDescription.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus a suscipit nibh. Donec justo metus, luctus nec dignissim sit amet, lobortis vitae est. Nam congue pulvinar turpis ac cursus. Vestibulum luctus a quam quis accumsan. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin pretium elit vel elit sollicitudin, in luctus odio hendrerit. Aliquam pellentesque diam pellentesque ligula venenatis ultrices. Sed mauris nulla, gravida nec imperdiet et, tristique eu ex.Quisque blandit dolor nec dignissim finibus. Ut elementum nisl leo, sed porttitor magna pretium a. Ut ac lacus rhoncus, gravida lectus sit amet, molestie diam. Sed vitae turpis quis erat tempor consectetur.Mauris facilisis dui eget est maximus, id vulputate neque bibendum.Donec malesuada eu turpis quis convallis. Donec vestibulum mattis ultricies. Suspendisse dapibus laoreet ipsum. Maecenas id ullamcorper erat. Nunc tincidunt nulla dolor, in convallis sem sagittis ac. Ut magna justo, interdum at eros ac, pulvinar aliquam sapien.Sed eu fermentum nulla. Cras malesuada lacinia sem, dapibus pretium purus malesuada vel.";
            this.labelDescription.Text = description;
            this.labelDescription.ForeColor = CustomColor.White;

            this.labelDescription.AutoSize = false;
            this.labelDescription.Size = new System.Drawing.Size(this.panelRight.Size.Width - 150, this.panelRight.Size.Height);
            
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

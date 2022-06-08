using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using System.Diagnostics;
using System.Threading;

namespace PL
{
    public partial class ShopTab : Form
    {
        public ShopTab()
        {
            InitializeComponent();
            this.BackColor = CustomColor.DarkBlue;
            this.panelFilter.BackColor = CustomColor.DarkBlue;
            List<DTO.Product> products = ProductsAccess.Select20RandomProducts();           
            DisplayProducts(products);

            
            
        }


        private void ShopTab_Load(object sender, EventArgs e)
        {
            
        }

        public void AddProduct(string productName, string productType, string description, Image productImage, decimal productBestPrice)
        {
            ShopTabProduct article = new ShopTabProduct(productName, productType, description, productImage, productBestPrice);
            article.TopLevel = false;
            this.flowLayoutPanel1.Controls.Add(article);
            article.Show();
        }

        public void DisplayProducts(List<DTO.Product> products)
        {            
            foreach (DTO.Product p in products)
            {
                AddProduct(p.PRODUCT_NAME, p.PRODUCT_TYPE,p.PRODUCT_DESCRIPTION, p.PRODUCT_IMAGE, p.PRODUCT_BEST_PRICE);
            }
        }
    }
}

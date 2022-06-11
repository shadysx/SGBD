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
using BLL;
using System.Diagnostics;
using System.Threading;

namespace PL
{
    public partial class ShopTab : Form
    {
        private List<Product> products;
        
        public ShopTab()
        {
            InitializeComponent();
            this.BackColor = CustomColor.DarkBlue;
            this.panelFilter.BackColor = CustomColor.DarkBlue;

            List<string> orderByWhat = new List<string>() {"Prix Croissant", "Prix Décroissant", "A-Z", "Z-A"};
            List<string> types = new List<string>();
            types.Add("Tous");

            foreach (string type in BLLShopTab.SelectAllProductTypes())
                types.Add(type);

            this.comboBoxSearchByType.DataSource = types;
            this.comboBoxOrderBy.DataSource = orderByWhat;
            this.rjButton1.BackColor = CustomColor.Orange;            
            
            List<DTO.Product> products = BLLShopTab.Select20RandomProducts();
            DisplayProducts(products);

        }

        private void filterButtonClick(object sender, EventArgs e)
        {
            while (flowLayoutPanel1.Controls.Count > 0) 
                flowLayoutPanel1.Controls.RemoveAt(0);
            DisplayProducts(FilteredProducts(this.textBoxSearchByName.Text, this.comboBoxSearchByType.SelectedValue.ToString(), this.comboBoxOrderBy.SelectedValue.ToString()));
            this.products = BLLShopTab.Select20RandomProducts();           
        }

        private List<Product> FilteredProducts(string productName, string productType, string orderBy)
        {
            List<Product> filteredProducts = new List<Product>();
            string searchByName = "";
            string searchByType = "";
            productName = productName.ToLower();

            if (productName != "")
                searchByName += $"{productName}";
            if (productType != "Tous")
                searchByType += $"{productType}";
            if (orderBy == "Prix Croissant")
                orderBy = "PRODUCT_BEST_PRICE";
            else if (orderBy == "Prix Décroissant")
                orderBy = "PRODUCT_BEST_PRICE DESC";
            else if (orderBy == "A-Z")
                orderBy = "PRODUCT_NAME";
            else if (orderBy == "Z-A")
                orderBy = "PRODUCT_NAME DESC";

            /*string query = "SELECT PRODUCT_NAME, PRODUCT_TYPE, PRODUCT_DESCRIPTION, PICTURE, min(SELLING_PRICE_EXCL_VAT) as PRODUCT_BEST_PRICE " +
                           "from PRODUCT inner join PICTURE on PICTURE.ID_PRODUCT = PRODUCT.ID_PRODUCT inner join stock on stock.ID_PRODUCT = PRODUCT.ID_PRODUCT " +
                           $"WHERE lower(PRODUCT_NAME) LIKE '%{searchByName}%' " + $"AND PRODUCT_TYPE LIKE '%{searchByType}%' " +
                           "group by PRODUCT_NAME, PRODUCT_TYPE, PRODUCT_DESCRIPTION, ID_PICTURE, PICTURE_URL, PICTURE " +
                           $"ORDER BY {orderBy}";*/

            
            filteredProducts = BLLShopTab.SelectFilteredProducts(searchByName, searchByType, orderBy) ;

            return filteredProducts;
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

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
using BLL;

namespace PL
{
    public partial class CardItem : Form
    {
        /*public CardItem()
        {
            InitializeComponent();

            List<OrderLine> items = OrderLineAccess.SelectAllOrderLine(Auth.CurrentUser.ACCOUNT_CURRENT_CARD.ID_ORDERED);
            DisplayProducts(items);
            


        }

        public void AddProduct(string name, string seller, decimal price, int quantity, string country, int idShop, int idProduct)
        {
            Product article = new Product(name, seller, price, quantity, country, idShop, idProduct);
            article.TopLevel = false;
            this.flowLayoutPanel1.Controls.Add(article);
            article.Show();

        }

        public void DisplayProducts(List<CardItem> items)
        {
            foreach (CardItem c in items)
            {
                AddProduct(s.PRODUCT_NAME, s.SHOP_NAME, s.SELLING_PRICE_EXCL_VAT, s.STOCK_QUANTITY, s.SHOP_COUNTRY, s.ID_SHOP, s.ID_PRODUCT);
            }
        }


        private void DisplayProduct()
        {
            
        }*/
    }
}

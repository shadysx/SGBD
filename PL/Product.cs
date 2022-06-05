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
using BLL;
using System.Diagnostics;

namespace PL
{
    public partial class Product : Form
    {
        string name;
        decimal price;
        int quantity;
        int idShop;
        int idProduct;
        public Product(string name, string seller, decimal price, int quantity, string country, int idShop, int idProduct)
        {
            InitializeComponent();
            this.labelPrix.Text = "€ " + price.ToString();
            this.labelVendeur.Text = seller;
            this.labelQuantite.Text = "Available quantity : " + quantity.ToString();
            this.labelPays.Text = country;
            this.iconButton1.IconColor = CustomColor.Orange;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.idShop = idShop;
            this.idProduct = idProduct;
            this.labelPriceSelected.Text = "€ " + price.ToString();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OrderLine orderLine = new OrderLine
            {
                ORDER_LINE_QUANTITY = Convert.ToInt32(this.numericUpDown1.Value),
                ORDER_LINE_BUYING_PRICE = this.price * this.numericUpDown1.Value,
                ID_SHOP = this.idShop,
                ID_PRODUCT = this.idProduct,
                ID_ORDERED = Auth.CurrentUser.ACCOUNT_CURRENT_CARD.ID_ORDERED
            };            

            if (Auth.CurrentUser.ACCOUNT_CURRENT_CARD == null)
            {
                OrderedAccess.InsertNewOrdered(Auth.CurrentUser.ID_ACCOUNT);
                Auth.CurrentUser.ACCOUNT_CURRENT_CARD = OrderedAccess.SelectOrdered(Auth.CurrentUser.ID_ACCOUNT);
            }            
           
            OrderLineAccess.AddProductToCard(orderLine);

            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(this.numericUpDown1.Value > quantity)
            {
                MessageBox.Show("Cannot select more than the available stock");
                this.numericUpDown1.Value = quantity;
            }                         
            else
                this.labelPriceSelected.Text = "€ " + (numericUpDown1.Value * this.price).ToString();

        }
    }
}

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
    public partial class Basket : Form
    {
        private decimal totalPrice;
        private int totalNumberArticle;
        private List<Item> items;
        public Basket()
        {
            InitializeComponent();
            

            this.BackColor = CustomColor.DarkBlue;            
            this.labelTotalPrice.ForeColor = CustomColor.White;
            this.labelTotalNumberArticle.ForeColor = CustomColor.White;
            this.label2.ForeColor = CustomColor.White;
            this.labelNumber.ForeColor = CustomColor.Orange;
            this.labelPrice.ForeColor = CustomColor.Orange;
            this.iconButton1.IconColor = CustomColor.Orange;
            this.iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, CustomColor.White);
            

            items = ItemAccess.SelectAllItem(Auth.CurrentUser.ACCOUNT_CURRENT_BASKET.ID_ORDERED);
            DisplayProducts(items);

            this.labelTotalNumberArticle.Text = "" + this.totalNumberArticle;
            this.labelTotalPrice.Text = "" + this.totalPrice + " €";
            
        }
       

        private void AddProduct(int iD_ORDERED, int iD_ORDER_LINE, int oRDER_LINE_QUANTITY, decimal oRDER_LINE_BUYING_PRICE, int iD_SHOP, 
                                string sHOP_NAME, string sHOP_ADDRESS, string sHOP_CITY, string sHOP_COUNTRY, int iD_PRODUCT, string pRODUCT_NAME, 
                                string pRODUCT_TYPE, string pRODUCT_DESCRIPTION, string pICTURE_URL, string pICTURE_PATH)
        {
            BasketItem basketItem = new BasketItem(iD_ORDERED, iD_ORDER_LINE, oRDER_LINE_QUANTITY, oRDER_LINE_BUYING_PRICE, iD_SHOP, sHOP_NAME, sHOP_ADDRESS, sHOP_CITY, sHOP_COUNTRY, iD_PRODUCT, pRODUCT_NAME, pRODUCT_TYPE, pRODUCT_DESCRIPTION, pICTURE_URL, pICTURE_PATH, this);
            basketItem.TopLevel = false;
            this.flowLayoutPanel1.Controls.Add(basketItem);
            basketItem.Show();
        }               

        public void DisplayProducts(List<Item> itemsList)
        {            
            foreach (Item i in itemsList)
            {
                AddProduct(i.ID_ORDERED, i.ID_ORDER_LINE, i.ORDER_LINE_QUANTITY, i.ORDER_LINE_BUYING_PRICE, i.ID_SHOP, i.SHOP_NAME, i.SHOP_ADDRESS, i.SHOP_CITY, i.SHOP_COUNTRY, i.ID_PRODUCT, i.PRODUCT_NAME, i.PRODUCT_TYPE, i.PRODUCT_DESCRIPTION, i.PICTURE_URL, i.PICTURE_PATH);
                this.totalNumberArticle += i.ORDER_LINE_QUANTITY;
                this.totalPrice += i.ORDER_LINE_BUYING_PRICE;                
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(items.Count >= 1)
            {
                DialogResult result = MessageBox.Show("Confirm purchase ?", "Validation", MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK)
                {
                    OrderedAccess.UpdateOrderer(Auth.CurrentUser.ID_ACCOUNT);
                    StockAccess.UpdateStockAfterBuy(items);

                    Auth.CurrentUser.ACCOUNT_CURRENT_BASKET = null;
                    OrderedAccess.InsertNewOrdered(Auth.CurrentUser.ID_ACCOUNT);
                    Auth.CurrentUser.ACCOUNT_CURRENT_BASKET = OrderedAccess.SelectActualOrdered(Auth.CurrentUser.ID_ACCOUNT);

                    this.Dispose();
                }                
            }           

        }
    }
}

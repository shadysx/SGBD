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
    public partial class BasketItem : Form
    {
        private string description;
        public int idOrderLine;
        private int idProduct;
        private int idShop;
        private int orderLineQuantity;

        private Stock itemStock;        

        private Basket basketParent;

        public BasketItem(int iD_ORDERED, int iD_ORDER_LINE, int oRDER_LINE_QUANTITY, decimal oRDER_LINE_BUYING_PRICE, int iD_SHOP, 
                        string sHOP_NAME, string sHOP_ADDRESS, string sHOP_CITY, string sHOP_COUNTRY, int iD_PRODUCT, string pRODUCT_NAME, 
                        string pRODUCT_TYPE, string pRODUCT_DESCRIPTION, Image productImage, Basket basketParent)
        {
            InitializeComponent();
            
            this.BackColor = Color.White;
            this.labelQuantityInstant.ForeColor = CustomColor.Orange;
            this.iconButtonInfo.IconColor = CustomColor.Orange;            
            this.labelTypeArticle.ForeColor = CustomColor.Orange;

            this.labelTypeArticle.Text = pRODUCT_TYPE;            
            this.labelNameArticle.Text = pRODUCT_NAME;
            this.labelCountry.Text = sHOP_COUNTRY;
            this.labelShopName.Text = sHOP_NAME;
            this.labelShopAddress.Text = sHOP_ADDRESS;
            this.labelShopCity.Text = sHOP_CITY;
            this.labelQuantity.Text = "Quantity : ";
            this.labelPrice.Text = "€ " + oRDER_LINE_BUYING_PRICE;            
            this.pictureBox1.Image = productImage;
            this.labelQuantityInstant.Text = oRDER_LINE_QUANTITY + "";

            this.description = pRODUCT_DESCRIPTION;
            this.idOrderLine = iD_ORDER_LINE;
            this.idShop = iD_SHOP;
            this.idProduct = iD_PRODUCT;
            this.orderLineQuantity = oRDER_LINE_QUANTITY;

            this.itemStock = StockAccess.GetStockOf1Article(this.idShop, idProduct);
            this.itemStock.STOCK_QUANTITY -= oRDER_LINE_QUANTITY;
            this.basketParent = basketParent;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Main.mainInstance.OpenChildForm(new DetailsTab(this.labelNameArticle.Text, this.description, this.pictureBox1.Image, "BasketItem"));
        }

        private void iconButtonPlus_Click(object sender, EventArgs e)
        {
            // On recharge le stock de l'article juste avant un changement 
            this.itemStock = StockAccess.GetStockOf1Article(this.idShop, idProduct);
            this.itemStock.STOCK_QUANTITY -= this.orderLineQuantity;
            this.labelQuantityChanged.Visible = false;

            if (itemStock.STOCK_QUANTITY > 0)
            {
                this.labelQuantityInstant.Text = Convert.ToInt32(this.labelQuantityInstant.Text) + 1 + "";
                OrderLineAccess.ModifyOrderline(Convert.ToInt32(this.labelQuantityInstant.Text), Convert.ToDecimal(Convert.ToInt32(this.labelQuantityInstant.Text) * this.itemStock.SELLING_PRICE_EXCL_VAT), this.idOrderLine);
                this.itemStock.STOCK_QUANTITY--;
                this.orderLineQuantity++;

                this.labelPrice.Text = "€ " + Convert.ToDecimal(Convert.ToInt32(this.labelQuantityInstant.Text) * this.itemStock.SELLING_PRICE_EXCL_VAT);

                
                decimal d = Convert.ToDecimal(this.basketParent.labelTotalPrice.Text.Replace("€", " ").Trim());
                this.basketParent.labelTotalPrice.Text = (d + this.itemStock.SELLING_PRICE_EXCL_VAT) + " €";
                this.basketParent.labelTotalNumberArticle.Text = Convert.ToInt32(this.basketParent.labelTotalNumberArticle.Text) + 1 + "";
            }
            else
            {
                MessageBox.Show($"No more {this.labelNameArticle.Text} available in this shop");
            }
            
        }

        private void iconButtonMinus_Click(object sender, EventArgs e)
        {
            // On recharge le stock de l'article juste avant un changement 
            this.itemStock = StockAccess.GetStockOf1Article(this.idShop, idProduct);
            this.itemStock.STOCK_QUANTITY -= this.orderLineQuantity;
            this.labelQuantityChanged.Visible = false;

            if (Convert.ToInt32(this.labelQuantityInstant.Text) - 1 == 0)
            {
                DialogResult r = MessageBox.Show( "Are you sure you want to delete this product from your basket ?", "Validation", MessageBoxButtons.OKCancel);
                if(r == DialogResult.OK)
                {
                    decimal d = Convert.ToDecimal(this.basketParent.labelTotalPrice.Text.Replace("€", " ").Trim());
                    this.basketParent.labelTotalPrice.Text = (d - this.itemStock.SELLING_PRICE_EXCL_VAT) + " €";                    
                    this.basketParent.labelTotalNumberArticle.Text = Convert.ToInt32(this.basketParent.labelTotalNumberArticle.Text) - 1 + "";
                    OrderLineAccess.DeleteOrderLine(idOrderLine);
                    this.Dispose();
                }                               
                
            }
            else
            {
                
                this.labelQuantityInstant.Text = Convert.ToInt32(this.labelQuantityInstant.Text) - 1 + "";                
                OrderLineAccess.ModifyOrderline(Convert.ToInt32(this.labelQuantityInstant.Text), Convert.ToDecimal(Convert.ToInt32(this.labelQuantityInstant.Text) * this.itemStock.SELLING_PRICE_EXCL_VAT), this.idOrderLine);
                itemStock.STOCK_QUANTITY++;
                this.orderLineQuantity--;

                this.labelPrice.Text = "€ " + Convert.ToDecimal(Convert.ToInt32(this.labelQuantityInstant.Text) * this.itemStock.SELLING_PRICE_EXCL_VAT);

                decimal d = Convert.ToDecimal(this.basketParent.labelTotalPrice.Text.Replace("€", " ").Trim());
                this.basketParent.labelTotalPrice.Text = (d - this.itemStock.SELLING_PRICE_EXCL_VAT) + " €";
                this.basketParent.labelTotalNumberArticle.Text = Convert.ToInt32(this.basketParent.labelTotalNumberArticle.Text) - 1 + "";
            }         

            
           
        }
    }
}

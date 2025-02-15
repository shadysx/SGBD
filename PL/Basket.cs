﻿using System;
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


            try
            {
                items = BLLBasket.SelectAllItem(Auth.CurrentUser.ACCOUNT_CURRENT_BASKET.ID_ORDERED);
                DisplayProducts(items);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           
            this.labelTotalNumberArticle.Text = "" + this.totalNumberArticle;
            this.labelTotalPrice.Text = "" + this.totalPrice + " €";
            
        }
       

        private void AddProduct(int iD_ORDERED, int iD_ORDER_LINE, int oRDER_LINE_QUANTITY, decimal oRDER_LINE_BUYING_PRICE, int iD_SHOP, 
                                string sHOP_NAME, string sHOP_ADDRESS, string sHOP_CITY, string sHOP_COUNTRY, int iD_PRODUCT, string pRODUCT_NAME, 
                                string pRODUCT_TYPE, string pRODUCT_DESCRIPTION, Image productImage)
        {
            BasketItem basketItem = new BasketItem(iD_ORDERED, iD_ORDER_LINE, oRDER_LINE_QUANTITY, oRDER_LINE_BUYING_PRICE, iD_SHOP, sHOP_NAME, sHOP_ADDRESS, sHOP_CITY, sHOP_COUNTRY, iD_PRODUCT, pRODUCT_NAME, pRODUCT_TYPE, pRODUCT_DESCRIPTION, productImage, this);
            basketItem.TopLevel = false;
            this.flowLayoutPanel1.Controls.Add(basketItem);
            basketItem.Show();
        }               

        public void DisplayProducts(List<Item> itemsList)
        {            
            foreach (Item i in itemsList)
            {
                AddProduct(i.ID_ORDERED, i.ID_ORDER_LINE, i.ORDER_LINE_QUANTITY, i.ORDER_LINE_BUYING_PRICE, i.ID_SHOP, i.SHOP_NAME, i.SHOP_ADDRESS, i.SHOP_CITY, i.SHOP_COUNTRY, i.ID_PRODUCT, i.PRODUCT_NAME, i.PRODUCT_TYPE, i.PRODUCT_DESCRIPTION, i.PRODUCT_IMAGE);
                this.totalNumberArticle += i.ORDER_LINE_QUANTITY;
                this.totalPrice += i.ORDER_LINE_BUYING_PRICE;                
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                items = BLLBasket.SelectAllItem(Auth.CurrentUser.ACCOUNT_CURRENT_BASKET.ID_ORDERED);

                Stock stock = null;
                bool isError = false;

                // On vérifie si qqun d'autre n'a pas epuisé le stock avant de valider l'achat
                foreach (Item i in items)
                {
                    stock = BLLBasket.GetStockOf1Article(i.ID_SHOP, i.ID_PRODUCT);
                    if (i.ORDER_LINE_QUANTITY > stock.STOCK_QUANTITY)
                    {
                        foreach(BasketItem b in this.flowLayoutPanel1.Controls.OfType<BasketItem>())
                        {                        
                            if(b.idOrderLine == i.ID_ORDER_LINE)
                            {
                                this.labelTotalNumberArticle.Text = (Convert.ToInt32(this.labelTotalNumberArticle.Text) - (i.ORDER_LINE_QUANTITY - stock.STOCK_QUANTITY)) + "";
                                this.labelTotalPrice.Text = (Convert.ToDecimal(this.labelTotalPrice.Text.Replace("€","").Trim()) - ((i.ORDER_LINE_QUANTITY - stock.STOCK_QUANTITY) * stock.SELLING_PRICE_EXCL_VAT)) + " €";

                                BLLBasket.ModifyOrderline(stock.STOCK_QUANTITY, stock.SELLING_PRICE_EXCL_VAT * stock.STOCK_QUANTITY, i.ID_ORDER_LINE);

                                b.labelQuantityInstant.Text = stock.STOCK_QUANTITY + "";
                                b.labelPrice.Text = stock.STOCK_QUANTITY * stock.SELLING_PRICE_EXCL_VAT + "";
                                b.labelQuantityChanged.Visible = true;                            
                            }                        
                        }
                        isError = true;
                    }                                             
                }

                if(!isError)
                {
                    if (items.Count >= 1)
                    {
                        DialogResult result = MessageBox.Show("Confirm purchase ?", "Validation", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            BLLBasket.UpdateOrderer(Auth.CurrentUser.ID_ACCOUNT);
                            BLLBasket.UpdateStockAfterBuy(items);

                            Auth.CurrentUser.ACCOUNT_CURRENT_BASKET = null;
                            BLLBasket.InsertNewOrdered(Auth.CurrentUser.ID_ACCOUNT);
                            Auth.CurrentUser.ACCOUNT_CURRENT_BASKET = BLLBasket.SelectActualOrdered(Auth.CurrentUser.ID_ACCOUNT);

                            this.Dispose();
                        }
                    }
                }                  
                else
                {
                    MessageBox.Show("Some of selected products weren't available anymore !\nWe've ajust your order based on our available stock.\nPlease check the changed before buying !");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           

        }
    }
}

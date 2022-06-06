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
    public partial class Article : Form
    {
        string name;
        decimal price;
        int quantity;
        int idShop;
        int idProduct;
        public Article(string name, string seller, decimal price, int quantity, string country, int idShop, int idProduct)
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
                   
            // On regarde si le compte User dispose 
            if (Auth.CurrentUser.ACCOUNT_CURRENT_CARD == null)
            {
                OrderedAccess.InsertNewOrdered(Auth.CurrentUser.ID_ACCOUNT);
                Auth.CurrentUser.ACCOUNT_CURRENT_CARD = OrderedAccess.SelectOrdered(Auth.CurrentUser.ID_ACCOUNT);
            }

            OrderLine orderLine = new OrderLine
            {
                ORDER_LINE_QUANTITY = Convert.ToInt32(this.numericUpDown1.Value),
                ORDER_LINE_BUYING_PRICE = this.price * this.numericUpDown1.Value,
                ID_SHOP = this.idShop,
                ID_PRODUCT = this.idProduct,
                ID_ORDERED = Auth.CurrentUser.ACCOUNT_CURRENT_CARD.ID_ORDERED
            };


            // Charge la liste d'oderline qui partage le meme ID_ORDERRED
            List<OrderLine> list = OrderLineAccess.SelectAllOrderLine(Auth.CurrentUser.ACCOUNT_CURRENT_CARD.ID_ORDERED);

            // On compare cette liste avec ID_PRODUCT et ID_SHOP pour pouvoir modifier l'insert dans la DB
            bool isModified = false;
            bool isValide = true;
            int idOrderLine = 0;
            int quantityLeft = 1;
            
            foreach(OrderLine ol in list)
            {
                if(ol.ID_SHOP == orderLine.ID_SHOP && ol.ID_PRODUCT == orderLine.ID_PRODUCT)
                {                                 
                    if(orderLine.ORDER_LINE_QUANTITY + ol.ORDER_LINE_QUANTITY > this.quantity)
                    {                       
                        quantityLeft = this.quantity - ol.ORDER_LINE_QUANTITY;
                        isValide = false;
                        break;
                    }
                    else
                    {
                        orderLine.ORDER_LINE_QUANTITY += ol.ORDER_LINE_QUANTITY;
                        orderLine.ORDER_LINE_BUYING_PRICE += ol.ORDER_LINE_QUANTITY * ol.ORDER_LINE_BUYING_PRICE;
                        idOrderLine = ol.ID_ORDER_LINE;
                        isModified = true;
                        break;
                    }                    
                }
            }




            // Suivant s'il faut Insert ou Update la table 
            if (!isModified && isValide)
            {
                if (this.quantity > 0)
                    OrderLineAccess.AddProductToCard(orderLine);
                else
                    MessageBox.Show("The product " + this.name + " is sold out in this shop");
            }           
            
            else if (isModified && isValide)            
                OrderLineAccess.ModifyOrderline(orderLine, idOrderLine);            
            else if(!isModified && !isValide)
                MessageBox.Show("Cannot Add " + this.numericUpDown1.Value + " x " + this.name + "\nOnly " + quantityLeft + " still available in this shop");





        }    
            
            
                



        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(this.numericUpDown1.Value > quantity)
            {
                if(quantity <= 0)
                {
                    this.numericUpDown1.Value = quantity;
                    MessageBox.Show("The product " + this.name + " is sold out in this shop");
                }
                else
                {
                    this.numericUpDown1.Value = quantity;
                    MessageBox.Show("Cannot select more than the available stock");
                }
                            
            }                         
            else
                this.labelPriceSelected.Text = "€ " + (numericUpDown1.Value * this.price).ToString();

        }
    }
}

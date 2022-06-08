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
using System.Threading;
using Tulpep.NotificationWindow;

namespace PL
{
    public partial class Article : Form
    {
        private string name;
        private decimal price;
        private int availableStock;
        private int availableStockForClient;
        private int idShop;
        private int idProduct;
        private OrderLine actualOrderLine;
        private Image image;
        private PopupNotifier popUp;

        public Article(string name, string seller, string shopAddress, string shopCity, decimal price, int availableStock, string country, int idShop, int idProduct, Image imageProduct)
        {
            InitializeComponent();
            InitializePopup();
            this.iconButton1.IconColor = CustomColor.Orange;
            this.iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, CustomColor.White);
            this.labelAddress.Text = shopAddress;
            this.labelCity.Text = shopCity;
            this.labelVendeur.Text = seller;
            this.labelPays.Text = country;

            this.image = imageProduct;            
            this.name = name;
            this.price = price;
            this.idShop = idShop;
            this.idProduct = idProduct;

            this.actualOrderLine = OrderLineAccess.Select1OrderLine(idProduct, idShop, Auth.CurrentUser.ACCOUNT_CURRENT_BASKET.ID_ORDERED);
            this.availableStock = availableStock;

            if (this.actualOrderLine != null)
                this.availableStockForClient = availableStock - this.actualOrderLine.ORDER_LINE_QUANTITY;
            else
                this.availableStockForClient = availableStock;



            this.timer1.Stop();

            if (this.availableStockForClient <= 0)
            {
                ProductSoldOut();
            }
            else
            {
                this.labelQuantite.Text = "Available quantity : " + availableStockForClient.ToString();
                this.labelPrix.Text = "Price : " + price.ToString() + " €" ;
                this.labelPriceSelected.Text = "Total : " + price.ToString() + " €";
            }
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {            
            this.actualOrderLine = OrderLineAccess.Select1OrderLine(idProduct, idShop, Auth.CurrentUser.ACCOUNT_CURRENT_BASKET.ID_ORDERED);
            this.availableStock = StockAccess.GetStockOf1Article(this.idShop, this.idProduct).STOCK_QUANTITY;
            if (this.actualOrderLine != null)
                this.availableStockForClient = availableStock - this.actualOrderLine.ORDER_LINE_QUANTITY;
            else
                this.availableStockForClient = availableStock;



            if (this.numericUpDown1.Value <= this.availableStockForClient && this.numericUpDown1.Value > 0)
            {
                OrderLine newOrderLine = new OrderLine
                {
                    ID_SHOP = this.idShop,
                    ID_PRODUCT = this.idProduct,
                    ID_ORDERED = Auth.CurrentUser.ACCOUNT_CURRENT_BASKET.ID_ORDERED,
                    ORDER_LINE_QUANTITY = Convert.ToInt32(this.numericUpDown1.Value),
                    ORDER_LINE_BUYING_PRICE = this.price * this.numericUpDown1.Value

                    
                };

                Debug.Print("Creation " + newOrderLine.ORDER_LINE_BUYING_PRICE + "");

                if (actualOrderLine != null)
                {
                    if (actualOrderLine.ID_SHOP == this.idShop && actualOrderLine.ID_PRODUCT == this.idProduct && actualOrderLine.ID_ORDERED == Auth.CurrentUser.ACCOUNT_CURRENT_BASKET.ID_ORDERED)
                    {
                        newOrderLine.ORDER_LINE_QUANTITY += actualOrderLine.ORDER_LINE_QUANTITY;
                        newOrderLine.ORDER_LINE_BUYING_PRICE += (actualOrderLine.ORDER_LINE_QUANTITY * this.price);                        

                        OrderLineAccess.ModifyOrderline(newOrderLine.ORDER_LINE_QUANTITY, newOrderLine.ORDER_LINE_BUYING_PRICE, actualOrderLine.ID_ORDER_LINE);
                        GreenCheck();
                        PlayPopUp(newOrderLine.ORDER_LINE_BUYING_PRICE);                        
                    }

                    Debug.Print("Modifier " + newOrderLine.ORDER_LINE_BUYING_PRICE + "");
                }
                else
                {                   
                    OrderLineAccess.InsertNewOrderLine(newOrderLine);
                    GreenCheck();
                    PlayPopUp(newOrderLine.ORDER_LINE_BUYING_PRICE);

                    Debug.Print("Insert " + newOrderLine.ORDER_LINE_BUYING_PRICE + "");
                }

                this.availableStockForClient -= Convert.ToInt32(this.numericUpDown1.Value);
                this.labelQuantite.Text = "Available quantity : " + availableStockForClient.ToString(); 
                               

            }
            else if (this.numericUpDown1.Value > this.availableStockForClient)
            {                
                MessageBox.Show("Cannot Add " + this.numericUpDown1.Value + " x " + this.name + "\nOnly " + this.availableStockForClient + " still available in this shop");
                this.numericUpDown1.Value = this.availableStockForClient;
            }

            if (this.availableStockForClient <= 0)
            {
                ProductSoldOut();                           
            }


            /*
                        OrderLine orderLine = new OrderLine
                        {
                            ORDER_LINE_QUANTITY = Convert.ToInt32(this.numericUpDown1.Value),
                            ORDER_LINE_BUYING_PRICE = this.price * this.numericUpDown1.Value,
                            ID_SHOP = this.idShop,
                            ID_PRODUCT = this.idProduct,
                            ID_ORDERED = Auth.CurrentUser.ACCOUNT_CURRENT_BASKET.ID_ORDERED
                        };

                        // Charge la liste d'oderline qui partage le meme ID_ORDERRED (lié au compte)
                        List<OrderLine> list = OrderLineAccess.SelectAllOrderLine(Auth.CurrentUser.ACCOUNT_CURRENT_BASKET.ID_ORDERED);

                        // On compare cette liste avec ID_PRODUCT et ID_SHOP pour pouvoir modifier l'insert dans la DB
                        bool isModified = false;
                        bool isValide = true;
                        int idOrderLine = 0;
                        int quantityLeft = 0;
                        OrderLine orderLineQuantity = null;

                        foreach(OrderLine ol in list)
                        {
                            if(ol.ID_SHOP == orderLine.ID_SHOP && ol.ID_PRODUCT == orderLine.ID_PRODUCT)
                            {                                 
                                if(orderLine.ORDER_LINE_QUANTITY + ol.ORDER_LINE_QUANTITY > this.availableStock)
                                {                       
                                    quantityLeft = this.availableStock - ol.ORDER_LINE_QUANTITY;
                                    isValide = false;
                                    break;
                                }
                                else
                                {
                                    orderLine.ORDER_LINE_QUANTITY += ol.ORDER_LINE_QUANTITY;
                                    orderLine.ORDER_LINE_BUYING_PRICE += ol.ORDER_LINE_QUANTITY * ol.ORDER_LINE_BUYING_PRICE;
                                    idOrderLine = ol.ID_ORDER_LINE;
                                    isModified = true;
                                    orderLineQuantity = ol;
                                    break;
                                }                    
                            }
                        }

                        // Suivant s'il faut Insert ou Update la table 

                        if (!isModified && isValide)
                        {
                            if (this.availableStock > 0)
                            {                  
                                OrderLineAccess.InsertNewOrderLine(orderLine);
                                GreenCheck();
                                PlayPopUp(orderLine.ORDER_LINE_BUYING_PRICE);
                            }                    
                            else
                                MessageBox.Show("The product " + this.name + " is sold out in this shop");
                        }         
                        else if (isModified && isValide)
                        {                
                            OrderLineAccess.ModifyOrderline(orderLine.ORDER_LINE_QUANTITY, orderLine.ORDER_LINE_BUYING_PRICE, idOrderLine);
                            GreenCheck();
                            PlayPopUp(orderLine.ORDER_LINE_BUYING_PRICE);
                        }

                        else if(!isModified && !isValide)
                            MessageBox.Show("Cannot Add " + this.numericUpDown1.Value + " x " + this.name + "\nOnly " + quantityLeft + " still available in this shop");
                                */
        }

        private void ProductSoldOut()
        {
            this.labelQuantite.Text = "This Product is Sold Out !";
            this.labelQuantite.Font = new Font("Poppins", 13, FontStyle.Bold);
            this.labelQuantite.Location = new Point(this.labelQuantite.Location.X, this.labelQuantite.Location.Y - 15);
            this.labelQuantite.ForeColor = CustomColor.Orange;
            this.labelPrix.Visible = false;
            this.labelPriceSelected.Visible = false;
            this.iconButton1.Visible = false;
            this.numericUpDown1.Visible = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            /*if (this.numericUpDown1.Value > availableStock)
            {
                if (availableStock <= 0)
                {
                    this.numericUpDown1.Value = availableStock;
                    MessageBox.Show("The product " + this.name + " is sold out in this shop");
                }
                else
                {
                    this.numericUpDown1.Value = availableStock;
                    MessageBox.Show("Cannot select more than the available stock");
                }
            }
            else
                this.labelPriceSelected.Text = "Total : " + (numericUpDown1.Value * this.price).ToString() + " €"; ;
*/

            if (this.numericUpDown1.Value < 0)
            {
                this.numericUpDown1.Value = 0;
                this.labelPriceSelected.Text = "Total : " + 0 + " €";
            }                
            else
            {
                this.labelPriceSelected.Text = "Total : " + (numericUpDown1.Value * this.price).ToString() + " €"; ;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = CustomColor.Orange;
            timer1.Stop();
        }

        private void GreenCheck()
        {
            this.timer1.Start();
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton1.IconColor = Color.Green;
        }
        private void PlayPopUp(decimal d)
        {
            this.popUp.Image = this.image;
            this.popUp.ContentText = $"{this.numericUpDown1.Value} x {this.name} added to card\nTotal added : {d} €";
            this.popUp.Popup();
        }

        private void InitializePopup()
        {
            popUp = new PopupNotifier();
            this.popUp.ImageSize = new Size(110, 110);
            this.popUp.ImagePadding = new Padding(5, 5, 5, 5);
            this.popUp.TitleText = "Thanks for your purchase";
            this.popUp.HeaderColor = Color.Transparent;
            this.popUp.BodyColor = CustomColor.DarkBlue;
            this.popUp.BorderColor = CustomColor.Orange;
            this.popUp.Size = new Size(400, 120);
            this.popUp.HeaderHeight = 1;
            this.popUp.TitleColor = Color.White;
            this.popUp.ContentColor = CustomColor.Orange;
            this.popUp.ContentHoverColor = CustomColor.Orange;
            this.popUp.ButtonHoverColor = CustomColor.Orange;
            this.popUp.TitlePadding = new Padding(5, 5, 5, 5);
            this.popUp.ContentPadding = new Padding(5, 5, 5, 5);
            this.popUp.ContentFont = new Font("Poppins", 10, FontStyle.Bold);
            this.popUp.TitleFont = new Font("Poppins", 9, FontStyle.Bold);
            this.popUp.GradientPower = 0;
        }
    }
}

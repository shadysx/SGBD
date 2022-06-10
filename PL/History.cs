using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class History : Form
    {
        List<HistoryPurchaseDTO> listHistory;
        private DateTime actualDate;
        private Label labelThisMonth;
        private Label labelPreviousPurchase;
        bool isThisMonth;
        bool isPrevious;

        public History()
        {
            InitializeComponent();
            this.actualDate = DateTime.Now;

            this.isThisMonth = false;
            this.isPrevious = false;

            this.labelThisMonth = new Label();
            this.labelThisMonth.Text = "Purchase of this Month :";
            this.labelThisMonth.Font = new Font("Poppins", 20, FontStyle.Bold);
            this.labelThisMonth.ForeColor = CustomColor.Orange;
            this.labelThisMonth.Size = new Size(500, 50);
            this.labelPreviousPurchase = new Label();
            this.labelPreviousPurchase.Text = "Previous Purchase :";
            this.labelPreviousPurchase.Font = new Font("Poppins", 20, FontStyle.Bold);
            this.labelPreviousPurchase.ForeColor = CustomColor.Orange;
            this.labelPreviousPurchase.Size = new Size(500, 50);

            
            this.BackColor = CustomColor.DarkBlue;

            this.flowLayoutPanel1.BackColor = CustomColor.DarkBlue;

            this.listHistory = DLLHistory.SelectAllHistoryPurchaseDTO(Auth.CurrentUser.ID_ACCOUNT);
            DisplayProducts(listHistory);
        }

        public void AddProduct(int idAccount, int idOrdered, DateTime date, decimal totalPrice, int totalQuantity)
        {
            
            if(idOrdered != Auth.CurrentUser.ACCOUNT_CURRENT_BASKET.ID_ORDERED)
            {
                HistoryPurchase historyPurchase = new HistoryPurchase(idAccount, idOrdered, date, totalPrice, totalQuantity);

                if (date.Month == DateTime.Now.Month && date.Year == DateTime.Now.Year)
                {
                    if (!this.isThisMonth)
                    {
                        this.flowLayoutPanel1.Controls.Add(labelThisMonth);
                        this.isThisMonth = true;
                    }
                }
                else
                {
                    if (!this.isPrevious)
                    {
                        this.flowLayoutPanel1.Controls.Add(labelPreviousPurchase);
                        this.isPrevious = true;
                    }                   
                }

                historyPurchase.TopLevel = false;
                this.flowLayoutPanel1.Controls.Add(historyPurchase);



                List<Item> items = DLLHistory.SelectAllItem(idOrdered);
                DisplaySubProducts(items);


                historyPurchase.Show();
            }
            



        }

        private void AddProduct(int iD_ORDERED, int iD_ORDER_LINE, int oRDER_LINE_QUANTITY, decimal oRDER_LINE_BUYING_PRICE, int iD_SHOP,
                                string sHOP_NAME, string sHOP_ADDRESS, string sHOP_CITY, string sHOP_COUNTRY, int iD_PRODUCT, string pRODUCT_NAME,
                                string pRODUCT_TYPE, string pRODUCT_DESCRIPTION, Image productImage)
        {
            HistoryPurchaseItem basketItem = new HistoryPurchaseItem(iD_ORDERED, iD_ORDER_LINE, oRDER_LINE_QUANTITY, oRDER_LINE_BUYING_PRICE, iD_SHOP, sHOP_NAME, sHOP_ADDRESS, sHOP_CITY, sHOP_COUNTRY, iD_PRODUCT, pRODUCT_NAME, pRODUCT_TYPE, pRODUCT_DESCRIPTION, productImage);
            basketItem.TopLevel = false;           
            
            this.flowLayoutPanel1.Controls.Add(basketItem);
            basketItem.Show();
        }

        public void DisplaySubProducts(List<Item> itemsList)
        {
            foreach (Item i in itemsList)
            {
                AddProduct(i.ID_ORDERED, i.ID_ORDER_LINE, i.ORDER_LINE_QUANTITY, i.ORDER_LINE_BUYING_PRICE, i.ID_SHOP, i.SHOP_NAME, i.SHOP_ADDRESS, i.SHOP_CITY, i.SHOP_COUNTRY, i.ID_PRODUCT, i.PRODUCT_NAME, i.PRODUCT_TYPE, i.PRODUCT_DESCRIPTION, i.PRODUCT_IMAGE);
                
            }
        }


        public void DisplayProducts(List<HistoryPurchaseDTO> listHistory)
        {
            foreach (HistoryPurchaseDTO h in listHistory)
            {                
                AddProduct(h.ID_ACCOUNT, h.ID_ORDERED, h.ORDERED_DATE, h.TOTAL_PRICE, h.TOTAL_QUANTITY);
            }
        }


    }
}

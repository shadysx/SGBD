using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class HistoryPurchaseItem : Form
    {
        private string description;
        public HistoryPurchaseItem(int iD_ORDERED, int iD_ORDER_LINE, int oRDER_LINE_QUANTITY, decimal oRDER_LINE_BUYING_PRICE, int iD_SHOP,
                        string sHOP_NAME, string sHOP_ADDRESS, string sHOP_CITY, string sHOP_COUNTRY, int iD_PRODUCT, string pRODUCT_NAME,
                        string pRODUCT_TYPE, string pRODUCT_DESCRIPTION, string pICTURE_URL, string pICTURE_PATH)
        {
            InitializeComponent();

            this.panelInside.BackColor = Color.White;
            this.BackColor = CustomColor.DarkBlue;
            this.panelOutSide.BackColor = CustomColor.DarkBlue;
            this.labelTypeArticle.Text = pRODUCT_TYPE;
            this.labelTypeArticle.ForeColor = CustomColor.Orange;
            this.labelNameArticle.Text = pRODUCT_NAME;
            this.labelCountry.Text = sHOP_COUNTRY;
            this.labelShopName.Text = sHOP_NAME;
            this.labelShopAddress.Text = sHOP_ADDRESS;
            this.labelShopCity.Text = sHOP_CITY;
            this.labelQuantity.Text = "Quantity : " + oRDER_LINE_QUANTITY;
            this.labelPrice.Text = "€ " + oRDER_LINE_BUYING_PRICE;
            this.description = pRODUCT_DESCRIPTION;
            this.pictureBox1.ImageLocation = pICTURE_PATH;            
        }
    }
}

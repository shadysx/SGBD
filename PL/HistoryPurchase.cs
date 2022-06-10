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
    public partial class HistoryPurchase : Form
    {
        public HistoryPurchase(int idAccount, int idOrdered, DateTime date, decimal totalPrice, int totalQuantity)
        {
            InitializeComponent();
            this.labelIdOrdered.Text = "N° :    " + idOrdered + "#";
            this.labelIdOrdered.ForeColor = CustomColor.Orange;
            
            this.labelDate.Text = "Order date : " + date.ToString("dd-MM-yyyy"); 
            this.labelTotalQuantity.Text = "Total Items : " + totalQuantity;
            this.labelTotalPrice.Text = "Total Price : " + totalPrice + " €";            

            this.BackColor = Color.White;
        }
    }
}

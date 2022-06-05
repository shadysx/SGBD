using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace PL
{
    public partial class EmployeePanel : Form
    {
        public EmployeePanel()
        {
            InitializeComponent();
            this.iconButton1.BackColor = Color.White;
            this.iconButton2.BackColor = Color.White;
            this.BackColor = CustomColor.DarkBlue;
            this.labelShop.Text = $"Vous êtes employé chez : {Auth.CurrentUser.ACCOUNT_SHOP_INFO.SHOP_NAME}";
            this.labelShop.ForeColor = Color.White;
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Main.mainInstance.OpenChildForm(new EmployeeInsertNewProductPanel());
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Main.mainInstance.OpenChildForm(new EmployeeAddStockPanel()); 
        }
    }
}

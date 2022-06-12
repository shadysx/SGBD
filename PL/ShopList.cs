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
    public partial class ShopList : Form
    {
        int idShop; 
        public ShopList(int idShop, string shopAddress, string shopCity, string postalCode, string shopName, string country)
        {
            InitializeComponent();

            this.idShop = idShop;
            this.labelID.Text = "#" + idShop;
            this.labelShopAddress.Text = shopAddress;
            this.labelShopCity.Text = shopCity;
            this.labelShopPostalCode.Text = postalCode;
            this.labelShopName.Text = shopName;
            this.labelShopCountry.Text = country;

            this.labelID.ForeColor = CustomColor.Orange;
            this.iconButton1.IconColor = CustomColor.Orange;
            this.iconButton2.IconColor = CustomColor.Orange;
            this.iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, CustomColor.Orange);
            this.iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, CustomColor.Orange);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Dispose();
            Main.mainInstance.OpenChildForm(new ModifyShop(idShop));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to delete this shop ?", "Validation", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                BLLShopList.DeleteShop(this.idShop);
                this.Dispose();
                Main.mainInstance.OpenChildForm(new AdminPanel());
            }

        }
    }
}

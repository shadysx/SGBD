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
using System.Diagnostics;

namespace PL
{
    public partial class ModifyUser : Form
    {
        Account account;
        public ModifyUser(int accountID)
        {
            InitializeComponent();
            this.BackColor = CustomColor.DarkBlue;
            Account acc = BLL.BLLAdminPanel.GetAccountByID(accountID);
            this.account = acc;


            this.textBoxEmail.Text = acc.ACCOUNT_EMAIL;
            this.textBoxUserName.Text = acc.ACCOUNT_USERNAME;
            this.textBoxName.Text = acc.ACCOUNT_FIRST_NAME;
            this.textBoxLastName.Text = acc.ACCOUNT_LAST_NAME;
            this.comboBoxRole.Text = acc.ACCOUNT_ROLE;
            this.datePicker.Value = acc.ACCOUNT_BIRTH_DATE;
            this.textBoxAddress.Text = acc.ACCOUNT_ADDRESS; 
            this.textBoxCity.Text = acc.ACCOUNT_CITY;
            this.textBoxPostal.Text = acc.ACCOUNT_POSTAL_CODE;
            this.textBoxCountry.Text = acc.ACCOUNT_COUNTRY;
            this.comboBoxRole.DataSource = new List<string>() { "ADMIN", "EMPLOYEE", "CLIENT" };
            


            if (acc.ID_SHOP > 0)
            {
                Debug.WriteLine(acc.ID_SHOP);
                this.comboBoxShop.Visible = true;
                Shop shop = BLL.BLLAdminPanel.GetShopInfo(acc.ID_SHOP);
                this.comboBoxShop.Text = shop.SHOP_NAME;
                this.comboBoxShop.DataSource = BLL.BLLAdminPanel.GetShopNameList();
            }

            CheckIfEmployee();


        }

        private void comboBoxRole_SelectedValueChanged(object sender, EventArgs e)
        {
            CheckIfEmployee();
        }
        private void CheckIfEmployee()
        {
            if (comboBoxRole.SelectedValue.ToString() == "EMPLOYEE")
            {
                this.comboBoxShop.Visible = true;
            }
            else
            {
                this.comboBoxShop.Visible = false;
            }
        }
    }
}

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
using BLL;
using DAL;

namespace PL
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            this.BackColor = CustomColor.DarkBlue;
            this.comboBoxShop.DataSource = BLLAdminPanel.GetShopNameList();
        }

        private void buttonCreateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                int id = BLLAdminPanel.GetShopIDByName(this.comboBoxShop.SelectedItem.ToString());

                Account acc = new Account()
                {
                    ACCOUNT_EMAIL = this.textBoxEmail.Text,
                    ACCOUNT_USERNAME = this.textBoxUserName.Text,
                    ACCOUNT_PASSWORD = this.textBoxPassword.Text,
                    ACCOUNT_LAST_NAME = this.textBoxLastName.Text,
                    ACCOUNT_FIRST_NAME = this.textBoxLastName.Text,
                    ACCOUNT_BIRTH_DATE = this.datePickerBirth.Value,
                    ACCOUNT_COUNTRY = this.textBoxCountry.Text,
                    ACCOUNT_ROLE = "EMPLOYEE",
                    ID_SHOP = id
                };

                BLL.Auth.SignUp(acc);
                MessageBox.Show("Employé créé avec succès");
                Main.mainInstance.OpenChildForm(new AdminPanel());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCreateShop_Click(object sender, EventArgs e)
        {

            try
            {
                ShopInfo newShop = new ShopInfo()
                {
                    SHOP_NAME = this.textBoxShopName.Text,
                    SHOP_ADDRESS = this.textBoxShopAddress.Text,
                    SHOP_POSTAL_CODE = this.textBoxShopPostal.Text,
                    SHOP_CITY = this.textBoxShopCity.Text,
                    SHOP_COUNTRY = this.textBoxShopCountry.Text
                };

                ShopInfoAccess.InsertNewShop(newShop);

                MessageBox.Show("Création du nouveau magasin avec succès");
                Dispose();
                Main.mainInstance.OpenChildForm(new AdminPanel());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}

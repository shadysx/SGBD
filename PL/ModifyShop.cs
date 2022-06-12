using BLL;
using DTO;
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
    public partial class ModifyShop : Form
    {
        private int idShop;
        public ModifyShop(int idShop)
        {
            InitializeComponent();

            this.BackColor = CustomColor.DarkBlue;
            Shop shop = BLLModifyShop.GetShopInfo(idShop);

            this.textBoxShopAddress.Text = shop.SHOP_ADDRESS;
            this.textBoxShopCity.Text = shop.SHOP_CITY;
            this.textBoxShopName.Text = shop.SHOP_NAME;
            this.textBoxShopPostal.Text = shop.SHOP_POSTAL_CODE;
            this.textBoxShopCountry.Text = shop.SHOP_COUNTRY;
            this.labelShopName.Text = shop.SHOP_NAME;

            this.labelShopName.ForeColor = CustomColor.Orange;

            this.iconButton1.IconColor = CustomColor.Orange;

            this.idShop = idShop;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.mainInstance.OpenChildForm(new AdminPanel());
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            bool isBookUnvalidate = false;

            ResetErrorProvider();

            foreach (ComponentFactory.Krypton.Toolkit.KryptonTextBox tb in this.Controls.OfType<ComponentFactory.Krypton.Toolkit.KryptonTextBox>())
                tb.StateCommon.Border.Color1 = Color.Black;

            Shop newShop = new Shop()
            {
                ID_SHOP = this.idShop,
                SHOP_NAME = this.textBoxShopName.Text,
                SHOP_ADDRESS = this.textBoxShopAddress.Text,
                SHOP_POSTAL_CODE = this.textBoxShopPostal.Text,
                SHOP_CITY = this.textBoxShopCity.Text,
                SHOP_COUNTRY = this.textBoxShopCountry.Text
            };

            RulesBookShop rbShop = new RulesBookShop();
            var result = rbShop.Validate(newShop);

            if (!result.IsValid)
            {

                foreach (var failure in result.Errors)
                {
                    string s = failure.ErrorMessage;

                    if (failure.PropertyName.Contains("NAME"))
                    {
                        this.textBoxShopName.StateCommon.Border.Color1 = Color.Red;
                        errorProviderShopName.SetError(textBoxShopName, "Must contains at least between 1 and 149 char");
                    }
                    else if (failure.PropertyName.Contains("ADDRESS"))
                    {
                        this.textBoxShopAddress.StateCommon.Border.Color1 = Color.Red;
                        errorProviderShopAddress.SetError(textBoxShopAddress, "Must contains at least between 1 and 149 char");
                    }
                    else if (failure.PropertyName.Contains("CITY"))
                    {
                        this.textBoxShopCity.StateCommon.Border.Color1 = Color.Red;
                        errorProviderShopCity.SetError(textBoxShopCity, "Must contains at least between 1 and 49 char");
                    }
                    else if (failure.PropertyName.Contains("POSTAL_CODE") && s.Contains("format"))
                    {
                        this.textBoxShopPostal.StateCommon.Border.Color1 = Color.Red;
                        errorProviderShopPostalCode.SetError(textBoxShopPostal, "Unvalid Format");
                    }
                    else if (failure.PropertyName.Contains("POSTAL_CODE") && s.Contains("caract"))
                    {
                        this.textBoxShopPostal.StateCommon.Border.Color1 = Color.Red;
                        errorProviderShopPostalCode.SetError(textBoxShopPostal, "Must contains at least between 1 and 14 char");
                    }
                    else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("format"))
                    {
                        this.textBoxShopCountry.StateCommon.Border.Color1 = Color.Red;
                        errorProviderShopCountry.SetError(textBoxShopCountry, "Unvalid Format");
                    }

                    else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("caract"))
                    {
                        this.textBoxShopCountry.StateCommon.Border.Color1 = Color.Red;
                        errorProviderShopCountry.SetError(textBoxShopCountry, "Must contains at least between 1 and 49 char");
                    }
                    isBookUnvalidate = true;
                }
            }

            // Lance l'INSERT
            if (!isBookUnvalidate)
            {
                try
                {
                    BLLModifyShop.UpdateShop(newShop);

                    MessageBox.Show("Modification du magasin avec succès");
                    foreach (ComponentFactory.Krypton.Toolkit.KryptonTextBox tb in this.Controls.OfType<ComponentFactory.Krypton.Toolkit.KryptonTextBox>())
                        tb.Text = "";
                    Dispose();

                    Main.mainInstance.OpenChildForm(new AdminPanel());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ResetErrorProvider()
        {
            this.errorProviderShopName.SetError(textBoxShopName, null);
            this.errorProviderShopAddress.SetError(textBoxShopAddress, null);
            this.errorProviderShopCity.SetError(textBoxShopCity, null);
            this.errorProviderShopPostalCode.SetError(textBoxShopPostal, null);
            this.errorProviderShopCountry.SetError(textBoxShopCountry, null);
        }
    }
}

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
using BLL;

namespace PL
{
    public partial class ModifyUser : Form
    {
        Account editingAccount;
        public ModifyUser(int accountID)
        {
            InitializeComponent();
            this.BackColor = CustomColor.DarkBlue;
            try
            {
                this.editingAccount = BLL.BLLAdminPanel.GetAccountByID(accountID);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


            this.labelEditing.ForeColor = Color.White;
            this.labelAccountUsername.ForeColor = CustomColor.Orange;
            this.iconButton1.IconColor = CustomColor.Orange;
            this.iconButton1.FlatAppearance.MouseOverBackColor = CustomColor.White;
            this.labelAccountUsername.Text = editingAccount.ACCOUNT_USERNAME;


            this.textBoxEmail.Text = editingAccount.ACCOUNT_EMAIL;
            this.textBoxUsername.Text = editingAccount.ACCOUNT_USERNAME;
            this.textBoxFirstName.Text = editingAccount.ACCOUNT_FIRST_NAME;
            this.textBoxLastName.Text = editingAccount.ACCOUNT_LAST_NAME;
            this.datePicker.Value = editingAccount.ACCOUNT_BIRTH_DATE;
            this.textBoxAddress.Text = editingAccount.ACCOUNT_ADDRESS;
            this.textBoxCity.Text = editingAccount.ACCOUNT_CITY;
            this.textBoxPostalCode.Text = editingAccount.ACCOUNT_POSTAL_CODE;
            this.textBoxCountry.Text = editingAccount.ACCOUNT_COUNTRY;

            this.comboBoxRole.DataSource = new List<string>() { "ADMIN", "EMPLOYEE", "CLIENT" };

            if (editingAccount.ACCOUNT_ROLE == "EMPLOYEE")
                this.comboBoxRole.SelectedIndex = 1;
            else if (editingAccount.ACCOUNT_ROLE == "CLIENT")
                this.comboBoxRole.SelectedIndex = 2;


            if (this.editingAccount.ID_SHOP > 0)
            {
                try
                {
                    this.comboBoxShop.Visible = true;
                    Shop shop = BLL.BLLAdminPanel.GetShopInfo(this.editingAccount.ID_SHOP);
                    List<string> shopNames = BLL.BLLAdminPanel.GetShopNameList();

                    this.comboBoxShop.DataSource = shopNames;
                    this.comboBoxShop.SelectedIndex = shopNames.IndexOf(shop.SHOP_NAME);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void comboBoxRole_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRole.SelectedValue.ToString() == "EMPLOYEE")
                {
                    this.comboBoxShop.Visible = true;
                    this.comboBoxShop.DataSource = BLLModifyUser.GetShopNameList();
                }
                else
                {
                    this.comboBoxShop.Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.mainInstance.OpenChildForm(new AdminPanel());
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            // FONCTION POUR L'ENREGISTREMENT D'UN USER

            List<Account> accounts = BLLModifyUser.SelectAllAccounts();

            // Reset de valeurs

            bool isDuplicated = false;
            bool isBookUnvalidate = false;
            bool isPasswordDifferent = false;

            //Reset des erreurs
            ResetErrorProvider();

            // Reset la couleur de la Bordure des textbox en noir
            foreach (ComponentFactory.Krypton.Toolkit.KryptonTextBox tb in this.Controls.OfType<ComponentFactory.Krypton.Toolkit.KryptonTextBox>())
                tb.StateCommon.Border.Color1 = Color.Black;

            this.datePicker.StateCommon.Border.Color1 = Color.Black;


            // Creation d'un account DTO avec les textBox
            Account newAccount = new Account
            {
                ID_ACCOUNT = this.editingAccount.ID_ACCOUNT,
                ACCOUNT_EMAIL = this.textBoxEmail.Text.Trim(),
                ACCOUNT_USERNAME = this.textBoxUsername.Text.Trim(),
                ACCOUNT_PASSWORD = this.textBoxPassword.Text,
                ACCOUNT_LAST_NAME = this.textBoxLastName.Text.Trim(),
                ACCOUNT_FIRST_NAME = this.textBoxFirstName.Text.Trim(),
                ACCOUNT_BIRTH_DATE = this.datePicker.Value.Date,
                ACCOUNT_ADDRESS = this.textBoxAddress.Text.Trim(),
                ACCOUNT_CITY = this.textBoxCity.Text.Trim(),
                ACCOUNT_POSTAL_CODE = this.textBoxPostalCode.Text.Trim(),
                ACCOUNT_COUNTRY = this.textBoxCountry.Text.Trim(),
                ACCOUNT_ROLE = this.comboBoxRole.SelectedValue.ToString()
            };

            int idShop = 0;

            if (newAccount.ACCOUNT_ROLE == "EMPLOYEE")
                idShop = BLLAdminPanel.GetShopIDByName(this.comboBoxShop.SelectedItem.ToString());

            if (idShop != 0)
                newAccount.ID_SHOP = idShop;


            // Check des doublons
            foreach (Account a in accounts)
            {
                if (editingAccount.ACCOUNT_USERNAME != newAccount.ACCOUNT_USERNAME)
                {
                    if (a.ACCOUNT_USERNAME.ToLower() == newAccount.ACCOUNT_USERNAME.ToLower())
                    {
                        errorProviderUsername.SetError(textBoxUsername, "This username already exist");
                        this.textBoxUsername.StateCommon.Border.Color1 = Color.Red;
                        isDuplicated = true;
                    }
                }

                if (editingAccount.ACCOUNT_EMAIL != newAccount.ACCOUNT_EMAIL)
                {
                    if (a.ACCOUNT_EMAIL.ToLower() == newAccount.ACCOUNT_EMAIL.ToLower())
                    {
                        errorProviderEmail.SetError(textBoxEmail, "This Email already exist");
                        this.textBoxEmail.StateCommon.Border.Color1 = Color.Red;
                        isDuplicated = true;
                    }
                }

            }




            // Check à l'aide du RulesBook
            RulesBookAccount rbAccount = new RulesBookAccount();
            var result = rbAccount.Validate(newAccount);

            if (!result.IsValid)
            {

                foreach (var failure in result.Errors)
                {
                    string s = failure.ErrorMessage;

                    if (failure.PropertyName.Contains("EMAIL"))
                    {
                        this.textBoxEmail.StateCommon.Border.Color1 = Color.Red;
                        errorProviderEmail.SetError(textBoxEmail, "Email unvalid");

                    }
                    else if (failure.PropertyName.Contains("USERNAME") && s.Contains("format"))
                    {
                        this.textBoxUsername.StateCommon.Border.Color1 = Color.Red;
                        errorProviderUsername.SetError(textBoxUsername, "Unvalid Format");
                    }
                    else if (failure.PropertyName.Contains("USERNAME") && s.Contains("caract"))
                    {
                        this.textBoxUsername.StateCommon.Border.Color1 = Color.Red;
                        errorProviderUsername.SetError(textBoxUsername, "Must contains at least between 4 and 25 char");
                    }
                    else if (failure.PropertyName.Contains("PASSWORD"))
                    {
                        this.textBoxPassword.StateCommon.Border.Color1 = Color.Red;
                        errorProviderPassword.SetError(textBoxPassword, "Must contains at least between 8 and 49 char");
                    }
                    else if (failure.PropertyName.Contains("LAST_NAME") && s.Contains("format"))
                    {
                        this.textBoxLastName.StateCommon.Border.Color1 = Color.Red;
                        errorProviderLastName.SetError(textBoxLastName, "Unvalid Format");
                    }
                    else if (failure.PropertyName.Contains("LAST_NAME") && s.Contains("caract"))
                    {
                        this.textBoxLastName.StateCommon.Border.Color1 = Color.Red;
                        errorProviderLastName.SetError(textBoxLastName, "Must contains at least between 1 and 99 char");
                    }
                    else if (failure.PropertyName.Contains("FIRST_NAME") && s.Contains("format"))
                    {
                        this.textBoxFirstName.StateCommon.Border.Color1 = Color.Red;
                        errorProviderFirstName.SetError(textBoxFirstName, "Unvalid Format");
                    }
                    else if (failure.PropertyName.Contains("FIRST_NAME") && s.Contains("caract"))
                    {
                        this.textBoxFirstName.StateCommon.Border.Color1 = Color.Red;
                        errorProviderFirstName.SetError(textBoxFirstName, "Must contains at least between 1 and 99 char");
                    }
                    else if (failure.PropertyName.Contains("BIRTH"))
                    {
                        this.datePicker.StateCommon.Border.Color1 = Color.Red;
                        errorProviderBirthDate.SetError(datePicker, "Impossible Birth Date");
                    }
                    else if (failure.PropertyName.Contains("ADDRESS"))
                    {
                        this.textBoxAddress.StateCommon.Border.Color1 = Color.Red;
                        errorProviderAddress.SetError(textBoxAddress, "Must contains at least between 1 and 249 char");
                    }
                    else if (failure.PropertyName.Contains("CITY"))
                    {
                        this.textBoxCity.StateCommon.Border.Color1 = Color.Red;
                        errorProviderCity.SetError(textBoxCity, "Must contains at least between 1 and 49 char");
                    }
                    else if (failure.PropertyName.Contains("POSTAL_CODE") && s.Contains("format"))
                    {
                        this.textBoxPostalCode.StateCommon.Border.Color1 = Color.Red;
                        errorProviderPostalCode.SetError(textBoxPostalCode, "Unvalid Format");
                    }
                    else if (failure.PropertyName.Contains("POSTAL_CODE") && s.Contains("caract"))
                    {
                        this.textBoxPostalCode.StateCommon.Border.Color1 = Color.Red;
                        errorProviderPostalCode.SetError(textBoxPostalCode, "Must contains at least between 1 and 49 char");
                    }
                    else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("format"))
                    {
                        this.textBoxCountry.StateCommon.Border.Color1 = Color.Red;
                        errorProviderCountry.SetError(textBoxCountry, "Unvalid Format");
                    }

                    else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("caract"))
                    {
                        this.textBoxCountry.StateCommon.Border.Color1 = Color.Red;
                        errorProviderCountry.SetError(textBoxCountry, "Must contains at least between 1 and 49 char");
                    }
                }
                isBookUnvalidate = true;
            }


            // Check if Confirm Password is same than Password
            if (this.textBoxConfirmPassword.Text != this.textBoxPassword.Text)
            {
                this.textBoxConfirmPassword.StateCommon.Border.Color1 = Color.Red; ;
                errorProviderConfirmPassword.SetError(this.textBoxConfirmPassword, "Passwords are different !");
                isPasswordDifferent = true;
            }

            // Lance l'INSERT
            if (!isDuplicated && !isBookUnvalidate && !isPasswordDifferent)
            {

                try
                {
                    newAccount.ACCOUNT_PASSWORD = Auth.ComputeSha256Hash(newAccount.ACCOUNT_PASSWORD);
                    Debug.Print(newAccount.ToString());
                    BLLModifyUser.UpdateAccount(newAccount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                foreach (ComponentFactory.Krypton.Toolkit.KryptonTextBox tb in this.Controls.OfType<ComponentFactory.Krypton.Toolkit.KryptonTextBox>())
                    tb.Text = "";

                MessageBox.Show("Modification de l'utilisateur effectuée avec succès");
                Dispose();
                Main.mainInstance.OpenChildForm(new AdminPanel());
            }
        }

        private void ResetErrorProvider()
        {
            this.errorProviderEmail.SetError(textBoxEmail, null);
            this.errorProviderUsername.SetError(textBoxUsername, null);
            this.errorProviderPassword.SetError(textBoxPassword, null);
            this.errorProviderConfirmPassword.SetError(textBoxConfirmPassword, null);
            this.errorProviderBirthDate.SetError(datePicker, null);
            this.errorProviderLastName.SetError(textBoxLastName, null);
            this.errorProviderFirstName.SetError(textBoxFirstName, null);
            this.errorProviderAddress.SetError(textBoxAddress, null);
            this.errorProviderCity.SetError(textBoxCity, null);
            this.errorProviderPostalCode.SetError(textBoxPostalCode, null);
            this.errorProviderCountry.SetError(textBoxCountry, null);
        }
    }
}

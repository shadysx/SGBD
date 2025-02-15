﻿using System;
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
using CustomControls.RJControls;

namespace PL
{
    public partial class AdminPanel : Form
    {
        List<Account> accounts;
        public AdminPanel()
        {
            InitializeComponent();
            this.BackColor = CustomColor.DarkBlue;            
            this.labelTittleCreateEmployee.ForeColor = CustomColor.Orange;
            this.labelTitleCreateShop.ForeColor = CustomColor.Orange;
            this.labelTitleModifyUser.ForeColor = CustomColor.Orange;
            this.labelID.ForeColor = CustomColor.Orange;
            this.labelTitleModifyShop.ForeColor = CustomColor.Orange;
            this.label7.ForeColor = CustomColor.Orange;

            try
            {
                this.comboBoxShop.DataSource = BLLAdminPanel.GetShopNameList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.kryptonComboBox1.DataSource = new List<string>() { "Prénom", "Utilisateur", "Email", "Nom", "Role" };
            this.kryptonComboBox2.DataSource = new List<string>() { "Nom", "Ville", "Pays" };

            try
            {
                List<Account> accounts = BLLAdminPanel.SelectAllAccounts();
                List<Shop> shops = BLLAdminPanel.SelectAllShop();
                this.DisplayUsers(accounts);
                this.DisplayShop(shops);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayShop(List<Shop> shops)
        {
            foreach (Shop s in shops)
            {
                ShopList sl = new ShopList(s.ID_SHOP, s.SHOP_ADDRESS, s.SHOP_CITY, s.SHOP_POSTAL_CODE, s.SHOP_NAME, s.SHOP_COUNTRY);
                sl.TopLevel = false;
                this.flowLayoutPanel3.Controls.Add(sl);
                sl.Show();
            }
        }

        private void DisplayUsers(List<Account> accounts)
        {
            

            foreach (Account account in accounts)
            {
                User user = new User(account.ID_ACCOUNT, account.ACCOUNT_USERNAME, account.ACCOUNT_EMAIL, account.ACCOUNT_FIRST_NAME, account.ACCOUNT_LAST_NAME, account.ACCOUNT_ROLE);
                user.TopLevel = false;
                this.flowLayoutPanel2.Controls.Add(user);
                user.Show();
            }


        }

        private void buttonCreateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                accounts = BLLRegistration.SelectAllAccounts(); // CHANGER
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            bool isDuplicated = false;
            bool isBookUnvalidate = false;
            bool isPasswordDifferent = false;


            ResetErrorProviderEmployee();


            // Reset la couleur de la Bordure des textbox en noir
            foreach (ComponentFactory.Krypton.Toolkit.KryptonTextBox tb in this.panelCreateEmployee.Controls.OfType<ComponentFactory.Krypton.Toolkit.KryptonTextBox>())
                tb.StateCommon.Border.Color1 = Color.Black;
            

            this.datePicker.StateCommon.Border.Color1 = Color.Black;

            int id = BLLAdminPanel.GetShopIDByName(this.comboBoxShop.SelectedItem.ToString());

            Account newAccount = new Account()
            {
                ACCOUNT_EMAIL = this.textBoxEmail.Text,
                ACCOUNT_USERNAME = this.textBoxUsername.Text,
                ACCOUNT_PASSWORD = this.textBoxPassword.Text,
                ACCOUNT_LAST_NAME = this.textBoxLastName.Text,
                ACCOUNT_FIRST_NAME = this.textBoxFirstName.Text,
                ACCOUNT_BIRTH_DATE = this.datePicker.Value,
                ACCOUNT_COUNTRY = this.textBoxCountry.Text,
                ACCOUNT_ROLE = "EMPLOYEE",
                ID_SHOP = id
            };

            foreach (Account a in accounts)
            {
                if (a.ACCOUNT_USERNAME.ToLower() == newAccount.ACCOUNT_USERNAME.ToLower())
                {
                    errorProviderUsername.SetError(textBoxUsername, "This username already exist");
                    this.textBoxUsername.StateCommon.Border.Color1 = Color.Red;
                    isDuplicated = true;
                }

                if (a.ACCOUNT_EMAIL.ToLower() == newAccount.ACCOUNT_EMAIL.ToLower())
                {
                    errorProviderEmail.SetError(textBoxEmail, "This Email already exist");
                    this.textBoxEmail.StateCommon.Border.Color1 = Color.Red;
                    isDuplicated = true;
                }
            }


            RulesBookAccount rbAccount = new RulesBookAccount();
            var result = rbAccount.Validate(newAccount);

            if (!result.IsValid)
            {

                foreach (var failure in result.Errors)
                {
                    string s = failure.ErrorMessage;

                    if (!(failure.PropertyName.Contains("ADDRESS") || failure.PropertyName.Contains("CITY") || failure.PropertyName.Contains("POSTAL")))
                    {
                        if (failure.PropertyName.Contains("EMAIL"))
                        {
                            this.textBoxEmail.StateCommon.Border.Color1 = Color.Red;
                            errorProviderEmail.SetError(textBoxEmail, "Email unvalid");
                            isBookUnvalidate = true;

                        }
                        else if (failure.PropertyName.Contains("USERNAME") && s.Contains("format"))
                        {
                            this.textBoxUsername.StateCommon.Border.Color1 = Color.Red;
                            errorProviderUsername.SetError(textBoxUsername, "Unvalid Format");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("USERNAME") && s.Contains("caract"))
                        {
                            this.textBoxUsername.StateCommon.Border.Color1 = Color.Red;
                            errorProviderUsername.SetError(textBoxUsername, "Must contains at least between 4 and 25 char");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("PASSWORD"))
                        {
                            this.textBoxPassword.StateCommon.Border.Color1 = Color.Red;
                            errorProviderPassword.SetError(textBoxPassword, "Must contains at least between 8 and 49 char");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("LAST_NAME") && s.Contains("format"))
                        {
                            this.textBoxLastName.StateCommon.Border.Color1 = Color.Red;
                            errorProviderLastName.SetError(textBoxLastName, "Unvalid Format");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("LAST_NAME") && s.Contains("caract"))
                        {
                            this.textBoxLastName.StateCommon.Border.Color1 = Color.Red;
                            errorProviderLastName.SetError(textBoxLastName, "Must contains at least between 1 and 99 char");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("FIRST_NAME") && s.Contains("format"))
                        {
                            this.textBoxFirstName.StateCommon.Border.Color1 = Color.Red;
                            errorProviderFirstName.SetError(textBoxFirstName, "Unvalid Format");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("FIRST_NAME") && s.Contains("caract"))
                        {
                            this.textBoxFirstName.StateCommon.Border.Color1 = Color.Red;
                            errorProviderFirstName.SetError(textBoxFirstName, "Must contains at least between 1 and 99 char");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("BIRTH"))
                        {
                            this.datePicker.StateCommon.Border.Color1 = Color.Red;
                            errorProviderBirthDate.SetError(datePicker, "Impossible Birth Date");
                            isBookUnvalidate = true;
                        }

                        else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("format"))
                        {
                            this.textBoxCountry.StateCommon.Border.Color1 = Color.Red;
                            errorProviderCountry.SetError(textBoxCountry, "Unvalid Format");
                            isBookUnvalidate = true;
                        }

                        else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("caract"))
                        {
                            this.textBoxCountry.StateCommon.Border.Color1 = Color.Red;
                            errorProviderCountry.SetError(textBoxCountry, "Must contains at least between 1 and 49 char");
                            isBookUnvalidate = true;
                        }
                    }
                }
            }

            if (this.textBoxConfirmPassword.Text != this.textBoxPassword.Text)
            {
                this.textBoxConfirmPassword.StateCommon.Border.Color1 = Color.Red;
                errorProviderConfirmPassword.SetError(this.textBoxConfirmPassword, "Passwords are different !");
                isPasswordDifferent = true;
            }


            // Lance l'INSERT
            if (!isDuplicated && !isBookUnvalidate && !isPasswordDifferent)
            {
                try
                {
                    if (Auth.SignUp(newAccount))
                    {
                        foreach (ComponentFactory.Krypton.Toolkit.KryptonTextBox tb in this.panelCreateEmployee.Controls.OfType<ComponentFactory.Krypton.Toolkit.KryptonTextBox>())
                            tb.Text = "";
                        MessageBox.Show("Employé créé avec succès");
                        this.Dispose();
                        Main.mainInstance.OpenChildForm(new AdminPanel());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ResetErrorProviderEmployee()
        {
            this.errorProviderEmail.SetError(textBoxEmail, null);
            this.errorProviderUsername.SetError(textBoxUsername, null);
            this.errorProviderPassword.SetError(textBoxPassword, null);
            this.errorProviderConfirmPassword.SetError(textBoxConfirmPassword, null);
            this.errorProviderBirthDate.SetError(datePicker, null);
            this.errorProviderLastName.SetError(textBoxLastName, null);
            this.errorProviderFirstName.SetError(textBoxFirstName, null);
            this.errorProviderCountry.SetError(textBoxCountry, null);
        }

        private void ResetErrorProviderShop()
        {
            this.errorProviderShopName.SetError(textBoxShopName, null);
            this.errorProviderShopAddress.SetError(textBoxShopAddress, null);
            this.errorProviderShopCity.SetError(textBoxShopCity, null);
            this.errorProviderShopPostalCode.SetError(textBoxShopPostal, null);
            this.errorProviderShopCountry.SetError(textBoxShopCountry, null);
        }

        private void buttonCreateShop_Click(object sender, EventArgs e)
        {

            bool isBookUnvalidate = false;

            ResetErrorProviderShop();

            foreach (ComponentFactory.Krypton.Toolkit.KryptonTextBox tb in this.panelCreateShop.Controls.OfType<ComponentFactory.Krypton.Toolkit.KryptonTextBox>())
                tb.StateCommon.Border.Color1 = Color.Black;

            Shop newShop = new Shop()
            {
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
                    BLL.BLLEmployeePanel.InsertNewShop(newShop);

                    MessageBox.Show("Création du nouveau magasin avec succès");
                    foreach (ComponentFactory.Krypton.Toolkit.KryptonTextBox tb in this.panelCreateShop.Controls.OfType<ComponentFactory.Krypton.Toolkit.KryptonTextBox>())
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

        private void FilterAccounts()
        {
            while (flowLayoutPanel2.Controls.Count > 0)
                flowLayoutPanel2.Controls.RemoveAt(0);

            string selectedItem = this.kryptonComboBox1.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Email": 
                    selectedItem = "ACCOUNT_EMAIL";
                    break;
                case "Utilisateur":
                    selectedItem = "ACCOUNT_USERNAME";
                    break;
                case "Nom":
                    selectedItem = "ACCOUNT_LAST_NAME";
                    break;
                case "Prénom":
                    selectedItem = "ACCOUNT_FIRST_NAME";
                    break;
                case "Role":
                    selectedItem = "ACCOUNT_ROLE";
                    break;
            }

            try
            {
                DisplayUsers(BLLAdminPanel.SelectAllAccountsBy(selectedItem, this.kryptonTextBox1.Text));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void FilterShops()
        {
            while (flowLayoutPanel3.Controls.Count > 0)
                flowLayoutPanel3.Controls.RemoveAt(0);

            string selectedItem = this.kryptonComboBox2.SelectedValue.ToString();

            switch (selectedItem)
            {
                case "Nom":
                    selectedItem = "SHOP_NAME";
                    break;
                case "Pays":
                    selectedItem = "SHOP_COUNTRY";
                    break;
                case "Ville":
                    selectedItem = "SHOP_CITY";
                    break;
            }

            try
            {
                DisplayShop(BLLAdminPanel.SelectAllShopsBy(selectedItem, this.kryptonTextBox2.Text));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            FilterAccounts();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            FilterShops();
        }
    }
}


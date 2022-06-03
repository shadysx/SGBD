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
using BLL;
using DTO;


namespace PL
{
    public partial class AccountSettings : Form
    {
        public AccountSettings()
        {
            InitializeComponent();
            LoadCurrentUserInfo();
        }

        private void LoadCurrentUserInfo()
        {
            this.labelUsername.Text = Auth.CurrentUser.ACCOUNT_USERNAME;
            this.labelLastNameInfo.Text = Auth.CurrentUser.ACCOUNT_LAST_NAME;
            this.labelFirstNameInfo.Text = Auth.CurrentUser.ACCOUNT_FIRST_NAME;
            this.labelEmailInfo.Text = Auth.CurrentUser.ACCOUNT_EMAIL;
            this.labelAddressInfo.Text = Auth.CurrentUser.ACCOUNT_ADDRESS;
            this.labelCityInfo.Text = Auth.CurrentUser.ACCOUNT_CITY;
            this.labelPostalCodeInfo.Text = Auth.CurrentUser.ACCOUNT_POSTAL_CODE;
            this.labelCountryInfo.Text = Auth.CurrentUser.ACCOUNT_COUNTRY;
        }

        private void buttonConfirmAccountSettings_Click(object sender, EventArgs e)
        {
            this.panelAccountUpdated.Visible = false;
            this.panelPasswordChange.Visible = false;

            bool isBookUnvalidate = false;
            bool isAddressNull = false;
            bool isCityNull = false;
            bool isCountryNull = false;
            bool isPostalCodeNull = false;

            ResetErrorProviderLeft();

            // Create Account with modify infos
            Account modifyAccount = Auth.CurrentUser;

            if (this.textBoxAddress.Text.Trim() != "")
                modifyAccount.ACCOUNT_ADDRESS = this.textBoxAddress.Text.Trim();
            else
                isAddressNull = true;

            if (this.textBoxCity.Text.Trim() != "")
                modifyAccount.ACCOUNT_CITY = this.textBoxCity.Text.Trim();
            else
                isCityNull = true;

            if (this.textBoxPostalCode.Text != "")
                modifyAccount.ACCOUNT_POSTAL_CODE = this.textBoxPostalCode.Text.Trim();
            else
                isPostalCodeNull = true;

            if (this.textBoxCountry.Text.Trim() != "")
                modifyAccount.ACCOUNT_COUNTRY = this.textBoxCountry.Text.Trim();
            else
                isCountryNull = true;



            // Use Rules Book Account
            RulesBookAccount rbAccount = new RulesBookAccount();

            var result = rbAccount.Validate(modifyAccount);

            if (!result.IsValid)
            {

                foreach (var failure in result.Errors)
                {
                    string s = failure.ErrorMessage;                    

                    if (!(failure.PropertyName.Contains("PASSWORD") || failure.PropertyName.Contains("EMAIL")))
                    {
                        if (failure.PropertyName.Contains("ADDRESS") && !isAddressNull)
                        {
                            this.errorProviderAddress.SetError(this.textBoxAddress, "Must contain at least between 1 and 249 char");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("CITY") && !isCityNull)
                        {
                            this.errorProviderCity.SetError(this.textBoxCity, "Must contain at least between 1 and 49 char");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("POSTAL_CODE") && s.Contains("format") & !isPostalCodeNull)
                        {
                            this.errorProviderPostalCode.SetError(this.textBoxPostalCode, "Unvalid Format");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("POSTAL_CODE") && s.Contains("caract") && isPostalCodeNull)
                        {
                            this.errorProviderPostalCode.SetError(this.textBoxPostalCode, "Must contain at least between 1 and 49 char");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("format") && !isCountryNull)
                        {
                            this.errorProviderCountry.SetError(this.textBoxCountry, "Unvalid Format");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("caract") && !isCountryNull)
                        {
                            this.errorProviderCountry.SetError(this.textBoxCountry, "Must contain at least between 1 and 49 char");
                            isBookUnvalidate = true;
                        }
                    }
                }
            }

            // Insert
            try
            {
                if (!isBookUnvalidate && !(isCountryNull && isCityNull && isAddressNull && isPostalCodeNull))
                {
                    BLL.DALRequest.InsertModifyAccount(modifyAccount);

                    foreach (TextBox tb in this.Controls.OfType<TextBox>())
                        tb.Text = null;

                    this.panelAccountUpdated.Visible = true;

                    BLL.Auth.CurrentUser = modifyAccount;

                    LoadCurrentUserInfo();
                }

            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }



        }

        private void buttonConfirmNewPassword_Click(object sender, EventArgs e)
        {
            bool error = false;
            this.panelPasswordChange.Visible = false;
            this.panelAccountUpdated.Visible = false;

            ResetErrorProviderRight();

            if (textBoxNewPassword.Text.Length < 8 || textBoxNewPassword.Text.Length > 49)
            {
                error = true;
                this.errorProviderNewPassword.SetError(textBoxNewPassword, "Must contain at least between 8 and 49 char !");
            }

            if (textBoxNewPassword.Text != textBoxNewConfirmPassword.Text)
            {
                error = true;
                this.errorProviderNewConfirmPassword.SetError(textBoxNewConfirmPassword, "Passwords are different !");
            }

            if (textBoxNewPassword.Text == textBoxOldPassword.Text)
            {
                error = true;
                this.errorProviderNewPassword.SetError(textBoxNewPassword, "Same as old password !");
            }


            if (Auth.ComputeSha256Hash(this.textBoxOldPassword.Text) != Auth.CurrentUser.ACCOUNT_PASSWORD)
            {
                error = true;
                this.errorProviderOldPassword.SetError(textBoxOldPassword, "Wrong password !");
            }

            try
            {
                if (!error)
                {
                    BLL.DALRequest.UpdatePassword(Auth.ComputeSha256Hash(this.textBoxNewPassword.Text), Auth.CurrentUser.ACCOUNT_USERNAME);
                    this.panelPasswordChange.Visible = true;

                    BLL.Auth.CurrentUser.ACCOUNT_PASSWORD = Auth.ComputeSha256Hash(this.textBoxNewPassword.Text);

                    foreach (TextBox tb in this.Controls.OfType<TextBox>())
                        tb.Text = null;
                }

            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }


        }

        private void ResetErrorProviderLeft()
        {
            this.errorProviderAddress.SetError(textBoxAddress, null);
            this.errorProviderCity.SetError(textBoxCity, null);
            this.errorProviderPostalCode.SetError(textBoxPostalCode, null);
            this.errorProviderCountry.SetError(textBoxCountry, null);
        }

        private void ResetErrorProviderRight()
        {
            this.errorProviderOldPassword.SetError(textBoxOldPassword, null);
            this.errorProviderNewPassword.SetError(textBoxNewPassword, null);
            this.errorProviderNewConfirmPassword.SetError(textBoxNewConfirmPassword, null);
        }
    }
}

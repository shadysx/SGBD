using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BLL;

namespace Test
{
    internal class MEmo
    {

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // FONCTION POUR L'ENREGISTREMENT D'UN USER
            accounts = null;
            accounts = BLL.BLLRegistration.SelectAllAccounts();

            // Reset de valeurs

            bool isDuplicated = false;
            bool isBookUnvalidate = false;
            bool isPasswordDifferent = false;
            this.panelSuccess.Visible = false;

            //Reset des erreurs

            ResetErrorProvider();


            // Reset la couleur de la Bordure des textbox en noir
            foreach (RJTextBox tb in this.Controls.OfType<RJTextBox>())
            {
                tb.BorderColor = Color.Black;
            }

            this.datePicker.BorderColor = Color.Black;


            // Creation d'un account DTO avec les textBox
            Account newAccount = new Account
            {
                ACCOUNT_EMAIL = this.textBoxEmail.Texts.Trim(),
                ACCOUNT_USERNAME = this.textBoxUsername.Texts.Trim(),
                ACCOUNT_PASSWORD = this.textBoxPassword.Texts,
                ACCOUNT_LAST_NAME = this.textBoxLastName.Texts.Trim(),
                ACCOUNT_FIRST_NAME = this.textBoxFirstName.Texts.Trim(),
                ACCOUNT_BIRTH_DATE = this.datePicker.Value.Date,
                ACCOUNT_ADDRESS = this.textBoxAddress.Texts.Trim(),
                ACCOUNT_CITY = this.textBoxCity.Texts.Trim(),
                ACCOUNT_POSTAL_CODE = this.textBoxPostalCode.Texts.Trim(),
                ACCOUNT_COUNTRY = this.textBoxCountry.Texts.Trim(),
                ACCOUNT_ROLE = "CLIENT",
                ID_SHOP = 0
            };



            // Check des doublons
            foreach (Account a in accounts)
            {
                if (a.ACCOUNT_USERNAME.ToLower() == newAccount.ACCOUNT_USERNAME.ToLower())
                {
                    errorProviderUsername.SetError(textBoxUsername, "This username already exist");
                    this.textBoxUsername.BorderColor = Color.Red;
                    isDuplicated = true;
                }

                if (a.ACCOUNT_EMAIL.ToLower() == newAccount.ACCOUNT_EMAIL.ToLower())
                {
                    errorProviderEmail.SetError(textBoxEmail, "This Email already exist");
                    this.textBoxEmail.BorderColor = Color.Red;
                    isDuplicated = true;
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
                        this.textBoxEmail.BorderColor = Color.Red;
                        errorProviderEmail.SetError(textBoxEmail, "Email unvalid");

                    }
                    else if (failure.PropertyName.Contains("USERNAME") && s.Contains("format"))
                    {
                        this.textBoxUsername.BorderColor = Color.Red;
                        errorProviderUsername.SetError(textBoxUsername, "Unvalid Format");
                    }
                    else if (failure.PropertyName.Contains("USERNAME") && s.Contains("caract"))
                    {
                        this.textBoxUsername.BorderColor = Color.Red;
                        errorProviderUsername.SetError(textBoxUsername, "Must contains at least between 4 and 25 char");
                    }
                    else if (failure.PropertyName.Contains("PASSWORD"))
                    {
                        this.textBoxPassword.BorderColor = Color.Red;
                        errorProviderPassword.SetError(textBoxPassword, "Must contains at least between 8 and 49 char");
                    }
                    else if (failure.PropertyName.Contains("LAST_NAME") && s.Contains("format"))
                    {
                        this.textBoxLastName.BorderColor = Color.Red;
                        errorProviderLastName.SetError(textBoxLastName, "Unvalid Format");
                    }
                    else if (failure.PropertyName.Contains("LAST_NAME") && s.Contains("caract"))
                    {
                        this.textBoxLastName.BorderColor = Color.Red;
                        errorProviderLastName.SetError(textBoxLastName, "Must contains at least between 1 and 99 char");
                    }
                    else if (failure.PropertyName.Contains("FIRST_NAME") && s.Contains("format"))
                    {
                        this.textBoxFirstName.BorderColor = Color.Red;
                        errorProviderFirstName.SetError(textBoxFirstName, "Unvalid Format");
                    }
                    else if (failure.PropertyName.Contains("FIRST_NAME") && s.Contains("caract"))
                    {
                        this.textBoxFirstName.BorderColor = Color.Red;
                        errorProviderFirstName.SetError(textBoxFirstName, "Must contains at least between 1 and 99 char");
                    }
                    else if (failure.PropertyName.Contains("BIRTH"))
                    {
                        this.datePicker.BorderColor = Color.Red;
                        errorProviderBirthDate.SetError(datePicker, "Impossible Birth Date");
                    }
                    else if (failure.PropertyName.Contains("ADDRESS"))
                    {
                        this.textBoxAddress.BorderColor = Color.Red;
                        errorProviderAddress.SetError(textBoxAddress, "Must contains at least between 1 and 249 char");
                    }
                    else if (failure.PropertyName.Contains("CITY"))
                    {
                        this.textBoxCity.BorderColor = Color.Red;
                        errorProviderCity.SetError(textBoxCity, "Must contains at least between 1 and 49 char");
                    }
                    else if (failure.PropertyName.Contains("POSTAL_CODE") && s.Contains("format"))
                    {
                        this.textBoxPostalCode.BorderColor = Color.Red;
                        errorProviderPostalCode.SetError(textBoxPostalCode, "Unvalid Format");
                    }
                    else if (failure.PropertyName.Contains("POSTAL_CODE") && s.Contains("caract"))
                    {
                        this.textBoxPostalCode.BorderColor = Color.Red;
                        errorProviderPostalCode.SetError(textBoxPostalCode, "Must contains at least between 1 and 49 char");
                    }
                    else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("format"))
                    {
                        this.textBoxCountry.BorderColor = Color.Red;
                        errorProviderCountry.SetError(textBoxCountry, "Unvalid Format");
                    }

                    else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("caract"))
                    {
                        this.textBoxCountry.BorderColor = Color.Red;
                        errorProviderCountry.SetError(textBoxCountry, "Must contains at least between 1 and 49 char");
                    }
                }
                isBookUnvalidate = true;
            }


            // Check if Confirm Password is same than Password
            if (this.textBoxConfirmPassword.Texts != this.textBoxPassword.Texts)
            {
                this.textBoxConfirmPassword.BorderColor = Color.Red;
                errorProviderConfirmPassword.SetError(this.textBoxConfirmPassword, "Passwords are different !");
                isPasswordDifferent = true;
            }

            // Lance l'INSERT
            if (!isDuplicated && !isBookUnvalidate && !isPasswordDifferent)
            {
                if (Auth.SignUp(newAccount))
                {
                    this.panelSuccess.Visible = true;
                    foreach (RJTextBox tb in this.Controls.OfType<RJTextBox>())
                        tb.Texts = "";

                    if (this.pictureBox.Image != null)
                    {
                        //Convert picture box image to byte array
                        MemoryStream ms = new MemoryStream();
                        pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] buff = ms.GetBuffer();
                        try
                        {
                            BLLRegistration.InsertProfileImage(this.fileName, BLLRegistration.GetLastCreatedAccount(), buff);
                            this.pictureBox.Image = null;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }
    }
}

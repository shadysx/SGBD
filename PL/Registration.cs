using ComponentFactory.Krypton.Toolkit;
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
using System.Text.RegularExpressions;
using System.Collections;
using System.Diagnostics;
using CustomControls.RJControls;

namespace PL
{
    public partial class Registration : KryptonForm
    {
        private List<Account> accounts;       

        public Registration()
        {
            InitializeComponent();
            FormStyles();
            InitializeValue();
        }

        private void FormStyles()
        {
            this.BackColor = Color.White;
            this.panelLeft.BackColor = CustomColor.DarkBlue;
            this.panelRight.BackColor = CustomColor.LightBlue;
            this.buttonCancel.BackColor = CustomColor.Orange;
            this.buttonSubmit.BackColor = CustomColor.DarkBlue;
            this.buttonSubmit.FlatAppearance.MouseOverBackColor = CustomColor.LightBlue;
            this.labelSuccess.ForeColor = CustomColor.White;
        }

        private void InitializeValue()
        {

            // TEMPORAIRE
            this.textBoxEmail.Texts = "vroomz.lol@gmail.com";
            this.textBoxUsername.Texts = "Irwin";
            this.textBoxPassword.Texts = "UN Mot de passe";
            this.textBoxConfirmPassword.Texts = "UN Mot de passe";
            this.textBoxLastName.Texts = "Gourou";
            this.textBoxFirstName.Texts = "Legende";
            this.datePicker.Value = new DateTime(2015, 2, 2);
            this.textBoxAddress.Texts = "Rue Straat 47";
            this.textBoxCity.Texts = "Verviers";
            this.textBoxPostalCode.Texts = "4800";
            this.textBoxCountry.Texts = "Belgium";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            accounts = null;
            accounts = BLL.DALRequest.SelectAllAccounts();

            // Reset de valeurs

            bool isDuplicated = false;
            bool isBookChecked = false;
            bool isPasswordConfirm = false;
            this.panelSuccess.Visible = false;

            //Reset des erreurs

            errorProviderEmail.SetError(textBoxEmail, null);
            errorProviderUsername.SetError(textBoxUsername, null);
            errorProviderPassword.SetError(textBoxPassword, null);
            errorProviderConfirmPassword.SetError(textBoxConfirmPassword, null);
            errorProviderBirthDate.SetError(datePicker, null);
            errorProviderLastName.SetError(textBoxLastName, null);
            errorProviderFirstName.SetError(textBoxFirstName, null);
            errorProviderAddress.SetError(textBoxAddress, null);
            errorProviderCity.SetError(textBoxCity, null);
            errorProviderPostalCode.SetError(textBoxPostalCode, null);
            errorProviderCountry.SetError(textBoxCountry, null);

            // Reset la couleur de la Bordure des textbox en noir
            foreach (RJTextBox tb in this.Controls.OfType<RJTextBox>())
            {
                tb.BorderColor = Color.Black;
            }

            RulesBookAccount rbAccount = new RulesBookAccount();

            Account newAccount = new Account
            {
                ACCOUNT_EMAIL = this.textBoxEmail.Texts,
                ACCOUNT_USERNAME = this.textBoxUsername.Texts.Trim(),
                ACCOUNT_PASSWORD = this.textBoxPassword.Texts,
                ACCOUNT_LAST_NAME = this.textBoxLastName.Texts.Trim(),
                ACCOUNT_FIRST_NAME = this.textBoxFirstName.Texts.Trim(),
                ACCOUNT_BIRTH_DATE = this.datePicker.Value.Date,
                ACCOUNT_ADDRESS = this.textBoxAddress.Texts.Trim(),
                ACCOUNT_CITY = this.textBoxCity.Texts.Trim(),
                ACCOUNT_POSTAL_CODE = this.textBoxPostalCode.Texts,
                ACCOUNT_COUNTRY = this.textBoxCountry.Texts.Trim(),
                ACCOUNT_ROLE = "CLIENT"
            };

            // Check des doublons
            foreach (Account a in accounts)
            {
                if (a.ACCOUNT_USERNAME == newAccount.ACCOUNT_USERNAME)
                {
                    errorProviderUsername.SetError(textBoxUsername, "This username already exist");
                    this.textBoxUsername.BorderColor = Color.Red;
                    isDuplicated = true;
                }

                if (a.ACCOUNT_EMAIL == newAccount.ACCOUNT_EMAIL)
                {
                    errorProviderEmail.SetError(textBoxEmail, "This Email already exist");
                    this.textBoxEmail.BorderColor = Color.Red;
                    isDuplicated = true;
                }
            }                        

            // Check à l'aide du RulesBook

            var result = rbAccount.Validate(newAccount);            

            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    string s = failure.ErrorMessage;                    

                    if (failure.PropertyName.Contains("EMAIL"))
                    {
                        errorProviderEmail.SetError(textBoxEmail, "Email unvalid");
                        this.textBoxEmail.BorderColor = Color.Red;
                    }                        
                    else if (failure.PropertyName.Contains("USERNAME") && s.Contains("format"))
                    {
                        errorProviderUsername.SetError(textBoxUsername, "Unvalid Format");
                        this.textBoxUsername.BorderColor = Color.Red;
                    }                       
                    else if (failure.PropertyName.Contains("USERNAME") && s.Contains("caract"))
                    {
                        errorProviderUsername.SetError(textBoxUsername, "Must contains at least between 4 and 99 char");
                        this.textBoxUsername.BorderColor = Color.Red;
                    }
                    else if (failure.PropertyName.Contains("PASSWORD"))
                    {
                        this.textBoxPassword.BorderColor = Color.Red;
                        errorProviderUsername.SetError(textBoxPassword, "Must contains at least between 4 and 49 char");
                    }
                    else if (failure.PropertyName.Contains("LAST_NAME") && s.Contains("format"))
                    {
                        this.textBoxLastName.BorderColor = Color.Red;
                        errorProviderUsername.SetError(textBoxLastName, "Unvalid Format");
                    }
                    else if (failure.PropertyName.Contains("LAST_NAME") && s.Contains("caract"))
                    {
                        this.textBoxLastName.BorderColor = Color.Red;
                        errorProviderUsername.SetError(textBoxLastName, "Must contains at least between 1 and 99 char");
                    }
                    else if (failure.PropertyName.Contains("FIRST_NAME") && s.Contains("format"))
                    {
                        this.textBoxFirstName.BorderColor = Color.Red;
                        errorProviderUsername.SetError(textBoxFirstName, "Unvalid Format");
                    }
                    else if (failure.PropertyName.Contains("FIRST_NAME") && s.Contains("caract"))
                    {
                        this.textBoxFirstName.BorderColor = Color.Red;
                        errorProviderUsername.SetError(textBoxFirstName, "Must contains at least between 1 and 99 char");
                    }
                    else if (failure.PropertyName.Contains("BIRTH"))
                    {
                        this.datePicker.BorderColor = Color.Red;
                        errorProviderUsername.SetError(datePicker, "Impossible Birth Date");
                    }
                    else if (failure.PropertyName.Contains("ADDRESS"))
                    {
                        this.textBoxAddress.BorderColor = Color.Red;
                        errorProviderUsername.SetError(textBoxAddress, "Must contains at least between 1 and 249 char");
                    }
                    else if (failure.PropertyName.Contains("CITY"))
                    {
                        this.textBoxCity.BorderColor = Color.Red;
                        errorProviderUsername.SetError(textBoxCity, "Must contains at least between 1 and 49 char");
                    }
                    else if (failure.PropertyName.Contains("POSTAL_CODE") && s.Contains("format"))
                    {
                        this.textBoxPostalCode.BorderColor = Color.Red;
                        errorProviderUsername.SetError(textBoxPostalCode, "Unvalid Format");
                    }
                    else if (failure.PropertyName.Contains("POSTAL_CODE") && s.Contains("caract"))
                    {
                        this.textBoxPostalCode.BorderColor = Color.Red;
                        errorProviderUsername.SetError(textBoxPostalCode, "Must contains at least between 1 and 49 char");
                    }
                    else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("format"))
                    {
                        this.textBoxCountry.BorderColor = Color.Red;
                        errorProviderUsername.SetError(textBoxCountry, "Unvalid Format");
                    }
                        
                    else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("caract"))
                    {
                        this.textBoxCountry.BorderColor = Color.Red;
                        errorProviderUsername.SetError(textBoxCountry, "Must contains at least between 1 and 49 char");
                    }                        
                }
                isBookChecked = true;
            }

            // Check if Confirm Password is same than Password
            if (textBoxPassword.Texts != textBoxConfirmPassword.Texts)
            {
                errorProviderUsername.SetError(textBoxConfirmPassword, "Passwords are different !");
                this.textBoxConfirmPassword.BorderColor = Color.Red;
                isPasswordConfirm = true;
            }             

            // INSERT

            if (!isDuplicated && !isBookChecked && !isPasswordConfirm)
            {
                if (Auth.SignUp(newAccount))
                {                    
                    this.panelSuccess.Visible = true;                    
                }
            }             
        }




        private void buttonSelectProfileImage_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {

        }
    }
}

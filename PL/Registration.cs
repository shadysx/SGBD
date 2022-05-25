﻿using ComponentFactory.Krypton.Toolkit;
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
        private Login loginForm; 

        public Registration(Form f)
        {
            InitializeComponent();
            FormStyles();
            InitializeValue();
            this.loginForm = (Login)f;
        }

        private void FormStyles()
        {
            this.BackColor = CustomColor.White;
            this.panelLeft.BackColor = CustomColor.DarkBlue;
            this.panelRight.BackColor = CustomColor.LightBlue;
            this.buttonCancel.BackColor = CustomColor.Orange;
            this.buttonSubmit.BackColor = CustomColor.DarkBlue;
            this.buttonSubmit.FlatAppearance.MouseOverBackColor = CustomColor.LightBlue;
            this.labelSuccess.ForeColor = CustomColor.White;
        }

        private void InitializeValue()
        {
                                   
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registration_Activated(object sender, EventArgs e)
        {
            this.textBoxEmail.Texts = (string)this.textBoxEmail.Tag;
            this.textBoxUsername.Texts = (string)this.textBoxUsername.Tag;
            this.textBoxPassword.Texts = (string)this.textBoxPassword.Tag;
            this.textBoxConfirmPassword.Texts = (string)this.textBoxConfirmPassword.Tag;
            this.textBoxLastName.Texts = (string)this.textBoxLastName.Tag;
            this.textBoxFirstName.Texts = (string)this.textBoxFirstName.Tag;
            if (datePicker.Tag != null)
                this.datePicker.Value = Convert.ToDateTime(datePicker.Tag);
            this.textBoxAddress.Texts = (string)this.textBoxAddress.Tag;
            this.textBoxCity.Texts = (string)this.textBoxCity.Tag;
            this.textBoxPostalCode.Texts = (string)this.textBoxPostalCode.Tag;
            this.textBoxCountry.Texts = (string)this.textBoxCountry.Tag;


            foreach (RJTextBox tb in this.Controls.OfType<RJTextBox>())
            {
                tb.BorderColor = Color.Black;
            }

            ResetErrorProvider();

            this.datePicker.BorderColor = Color.Black;

            this.panelSuccess.Visible = false;
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {            
            this.textBoxEmail.Tag = this.textBoxEmail.Texts;
            this.textBoxUsername.Tag = this.textBoxUsername.Texts;
            this.textBoxPassword.Tag = this.textBoxPassword.Texts;
            this.textBoxConfirmPassword.Tag = this.textBoxConfirmPassword.Texts;
            this.textBoxLastName.Tag = this.textBoxLastName.Texts;
            this.textBoxFirstName.Tag = this.textBoxFirstName.Texts;
            this.datePicker.Tag = this.datePicker.Value.ToString();
            this.textBoxAddress.Tag = this.textBoxAddress.Texts;
            this.textBoxCity.Tag = this.textBoxCity.Texts;
            this.textBoxPostalCode.Tag = this.textBoxPostalCode.Texts;
            this.textBoxCountry.Tag = this.textBoxCountry.Texts;

            this.loginForm.Show();
            this.Hide();
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            accounts = null;
            accounts = BLL.DALRequest.SelectAllAccounts();

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
                        errorProviderUsername.SetError(textBoxUsername, "Must contains at least between 4 and 99 char");
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

            // INSERT
            if (!isDuplicated && !isBookUnvalidate && !isPasswordDifferent)
            {
                if (Auth.SignUp(newAccount))
                {                    
                    this.panelSuccess.Visible = true;
                    foreach (RJTextBox tb in this.Controls.OfType<RJTextBox>())
                        tb.Texts = "";                    
                }
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

        private void buttonSelectProfileImage_Click(object sender, EventArgs e)
        {

        }
        
        
    }
}

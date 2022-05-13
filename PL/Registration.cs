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

namespace PL
{
    public partial class Registration : KryptonForm
    {
        private List<Account> accounts;
        private bool[] tabErros;

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

        }

        private void InitializeValue()
        {
            tabErros = new bool[17];

            // Charge de la liste des comptes dans la BD //
            if (accounts == null)
            {
                accounts = BLL.DALRequest.SelectAllAccounts();
            }



            // TEMPORAIRE
            this.textBoxEmail.Texts = "vroomz.lol@gmail.com";
            this.textBoxUsername.Texts = "UnUSER";
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
            // Réinitialise TabErrors to false
            for(int i = 0; i < tabErros.Length; i++)
                tabErros[i] = false;

            try
            {
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

                tabErros = LogicLayer.CheckValidityNewAccount(newAccount, accounts, this.tabErros);

                if (tabErros.Contains(true))
                {
                    for (int i = 0; i < tabErros.Length; i++)
                    {
                        if (tabErros[i] == true)
                        {
                            Debug.Print("tabErrors : " + i + "");
                        }
                    }
                    Debug.Print("\n");                     
                }
                else
                {

                    if (Auth.SignUp(newAccount))
                    {
                        MessageBox.Show("Registration Success, Redirect to Log In");
                        this.Close();
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

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
             tabErros = new bool[11];         

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }        

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if(accounts == null)
                {
                    accounts = BLL.DALRequest.SelectAllAccounts();
                }

                Account newAccount = new Account
                {
                    ACCOUNT_EMAIL = this.textBoxEmail.Texts,
                    ACCOUNT_USERNAME = this.textBoxUsername.Texts.Trim(),
                    ACCOUNT_PASSWORD = this.textBoxPassword.Texts,
                    ACCOUNT_LAST_NAME = this.textBoxLastName.Texts.Trim(),
                    ACCOUNT_FIRST_NAME = this.textBoxFirstName.Texts.Trim(),
                    ACCOUNT_BIRTH_DATE = this.datePicker.Value,
                    ACCOUNT_ADDRESS = this.textBoxAddress.Texts.Trim(),
                    ACCOUNT_CITY = this.textBoxCity.Texts.Trim(),
                    ACCOUNT_POSTAL_CODE = this.textBoxPostalCode.Texts,
                    ACCOUNT_COUNTRY = this.textBoxCountry.Texts.Trim(),
                    ACCOUNT_ROLE = "CLIENT"
                };



                CheckValidityNewAccount(newAccount, accounts);
                

                
                


                if(!Auth.SignUp(newAccount))
                {

                }


                else
                {
                    //Auth.SignUp(Email, username, ...)
                    MessageBox.Show("Registration Success, Redirect to Log In");
                    this.Close();
                }


                

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckValidityNewAccount(Account newAccount, List<Account> accounts)
        {          

            /* CHECK IF USERNAME ALREADY EXIST  (ERROR [0])  */

            foreach (Account a in accounts)
            {
                if (a.ACCOUNT_USERNAME == newAccount.ACCOUNT_USERNAME)
                    tabErros[0] = true;
            }

            /* CHECK IF USERNAME HAVE AN "ESPACE"  (ERROR [1])  */

            if (!Regex.Match(newAccount.ACCOUNT_USERNAME, "^\\S+$").Success)
                tabErros[1] = true;

            /* CHECK USERNAME LENGTH (minimum 4, maximum 99)  (ERROR [2])  */

            foreach (Account a in accounts)
            {
                if (a.ACCOUNT_USERNAME.Length > 99)
                    tabErros[2] = true;
            }

            /* CHECK IF EMAIL PATTERN IS OK (ERROR[3]) */

            if (!Regex.Match(newAccount.ACCOUNT_EMAIL.ToLower(), @"^((.{4,50})([@])([a-z]{2,10})[.]([a-z]{2,3}))$").Success)
                tabErros[3] = true;
            

            /* CHECK IF EMAIL ALREADY EXIST (ERROR[4]) */

            foreach (Account a in accounts)
            {
                if (a.ACCOUNT_EMAIL == newAccount.ACCOUNT_EMAIL)
                    tabErros[4] = true;                             
            }

            /* CHECK PASSWORD SIZE (ERROR[5])*/

            if (!Regex.Match(newAccount.ACCOUNT_PASSWORD, @"^(.{8, 50})$").Success)
                tabErros[5] = true;


            /* CHECK LAST NAME PATTERN (ERROR[6]) */

            if (!Regex.Match(newAccount.ACCOUNT_LAST_NAME, "^((([A-Z]{1})([a-z]+))(((\\s[A-Z]{1})([a-z]+))+))$").Success)
                tabErros[6] = true;

            /* CHECK LAST NAME LENGTH */

            if (newAccount.ACCOUNT_LAST_NAME.Length > 99)
                tabErros[5] = true;

           /*                                  
            
            ACCOUNT_FIRST_NAME = this.textBoxFirstName.Texts,
            ACCOUNT_BIRTH_DATE = this.datePicker.Value,
            ACCOUNT_ADDRESS = this.textBoxAddress.Texts,
            ACCOUNT_CITY = this.textBoxCity.Texts,
            ACCOUNT_POSTAL_CODE = this.textBoxPostalCode.Texts,
            ACCOUNT_COUNTRY = this.textBoxCountry.Texts,
            ACCOUNT_ROLE = "CLIENT"
           */

            
        }
        

        private void buttonSelectProfileImage_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
                       
        }
    }
}

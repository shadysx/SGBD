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

namespace PL
{
    public partial class Registration : KryptonForm
    {
        public Registration()
        {
            InitializeComponent();
            FormStyles();
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }        

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Account newAccount = new Account
                {
                    ACCOUNT_EMAIL = this.textBoxEmail.Texts,
                    ACCOUNT_USERNAME = this.textBoxUsername.Texts,
                    ACCOUNT_PASSWORD = this.textBoxPassword.Texts,
                    ACCOUNT_LAST_NAME = this.textBoxLastName.Texts,
                    ACCOUNT_FIRST_NAME = this.textBoxFirstName.Texts,
                    ACCOUNT_BIRTH_DATE = this.datePicker.Value,
                    ACCOUNT_ADDRESS = this.textBoxAddress.Texts,
                    ACCOUNT_CITY = this.textBoxCity.Texts,
                    ACCOUNT_POSTAL_CODE = this.textBoxPostalCode.Texts,
                    ACCOUNT_COUNTRY = this.textBoxCountry.Texts,
                    ACCOUNT_ROLE = "CLIENT"
                };

                if(!Auth.SignUp(newAccount))
                {

                }


                

                //Auth.SignUp(Email, username, ...)
                MessageBox.Show("Registration Success, Redirect to Log In");
                this.Close();
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

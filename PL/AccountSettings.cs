using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }
        public AccountSettings(string username)
        {
            InitializeComponent();
            this.labelUsername.Text = username;
        }

        private void buttonConfirmAccountSettings_Click(object sender, EventArgs e)
        {
            
            Account modifyAccount = Auth.CurrentUser;

            modifyAccount.ACCOUNT_ADDRESS = this.textBoxAddress.Text; 
            modifyAccount.ACCOUNT_CITY = this.textBoxCity.Text;
            modifyAccount.ACCOUNT_POSTAL_CODE = this.textBoxPostalCode.Text;
            modifyAccount.ACCOUNT_COUNTRY = this.textBoxCountry.Text;

            RulesBookAccount rbAccount = new RulesBookAccount();

            var result = rbAccount.Validate(modifyAccount);

            /*if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    string s = failure.ErrorMessage;

                    
                    if (failure.PropertyName.Contains("ADDRESS"))
                    {
                        errorProviderAddress.SetError(textBoxAddress, "Must contains at least between 1 and 249 char");
                    }
                    else if (failure.PropertyName.Contains("CITY"))
                    {
                        errorProviderCity.SetError(textBoxCity, "Must contains at least between 1 and 49 char");
                    }
                    else if (failure.PropertyName.Contains("POSTAL_CODE") && s.Contains("format"))
                    {
                        errorProviderPostalCode.SetError(textBoxPostalCode, "Unvalid Format");
                    }
                    else if (failure.PropertyName.Contains("POSTAL_CODE") && s.Contains("caract"))
                    {
                        errorProviderPostalCode.SetError(textBoxPostalCode, "Must contains at least between 1 and 49 char");
                    }
                    else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("format"))
                    {
                        errorProviderCountry.SetError(textBoxCountry, "Unvalid Format");
                    }
                    else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("caract"))
                    {
                        errorProviderCountry.SetError(textBoxCountry, "Must contains at least between 1 and 49 char");
                    }
                }                
            }   */        
            
        }
    }
}

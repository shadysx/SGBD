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
            string address, city, postalCode, country;
            address = this.textBoxAddress.Text;
            city = this.textBoxCity.Text;
            postalCode = this.textBoxPostalCode.Text;
            country =  this.textBoxCountry.Text;

            if(LogicLayer.ModifyAccountSetting(address, city, postalCode, country))
            {

            }
            else
            {

            }
            
        }
    }
}

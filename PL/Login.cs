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

namespace PL
{
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
            FormStyles();
        }

        public void FormStyles()
        {

            this.BackColor = CustomColor.DarkBlue;
            this.buttonLogin.BackColor = Color.DarkOrange;
            this.buttonRegister.BorderColor = Color.DarkOrange;
            this.textBoxUserName.BorderFocusColor = CustomColor.DarkBlue;
            this.textBoxPassWord.BorderFocusColor = CustomColor.DarkBlue;
            this.buttonRegister.TextColor = Color.DarkOrange;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = Color.DarkOrange;

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

        }
    }
}

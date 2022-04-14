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

            this.BackColor = CustomColor.Custom1;
            this.buttonLogin.BackColor = Color.DarkOrange;
            this.buttonRegister.BorderColor = Color.DarkOrange;
            this.textBoxUserName.BorderFocusColor = CustomColor.Custom1;
            this.textBoxPassWord.BorderFocusColor = CustomColor.Custom1;
            this.buttonRegister.TextColor = Color.DarkOrange;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = Color.DarkOrange;

        }
    }
}

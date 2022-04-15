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
            this.buttonLogin.BackColor = CustomColor.Orange;
            this.buttonRegister.BorderColor = CustomColor.Orange;
            this.textBoxUserName.BorderFocusColor = CustomColor.DarkBlue;
            this.textBoxPassWord.BorderFocusColor = CustomColor.DarkBlue;
            this.buttonRegister.TextColor = CustomColor.Orange;
            this.ActiveControl = this.pictureBox1;
            this.panelRight.BackColor = CustomColor.White;
        }

        private void buttonRegister_MouseLeave(object sender, EventArgs e)
        {
            this.buttonRegister.BackColor = CustomColor.White;
            this.buttonRegister.TextColor = CustomColor.Orange;
        }

        private void buttonRegister_MouseEnter(object sender, EventArgs e)
        {
            this.buttonRegister.BackColor = CustomColor.Orange;
            this.buttonRegister.TextColor = CustomColor.White;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration r = new Registration();
            DialogResult result = r.ShowDialog();

            //if cancel
            if (result == DialogResult.Cancel)
            {
                r.Close();
                this.Show();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Auth.Login(this.textBoxUserName.Text, this.textBoxPassWord.Text);
                this.Hide();
                new Main().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

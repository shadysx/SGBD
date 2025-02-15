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
using BLL;

namespace PL
{
    public partial class Login : KryptonForm
    {
        private Registration registrationForm;
        public Login()
        {
            InitializeComponent();
            FormStyles();
            registrationForm = new Registration(this);
            this.textBoxUserName.Focus();
        }

        public void FormStyles()
        {
            this.BackColor = CustomColor.DarkBlue;
            this.buttonLogin.BackColor = CustomColor.Orange;
            this.buttonRegister.BorderColor = CustomColor.Orange;
            this.textBoxUserName.BorderFocusColor = CustomColor.DarkBlue;
            this.textBoxPassWord.BorderFocusColor = CustomColor.DarkBlue;
            this.buttonRegister.TextColor = CustomColor.Orange;
            this.panelRight.BackColor = CustomColor.White;
            this.ActiveControl = this.pictureBox1;
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
            this.registrationForm.Show();

            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Auth.Login(this.textBoxUserName.Texts, this.textBoxPassWord.Texts);
                new Main(this).Show();
                this.Hide();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
                buttonLogin_Click(sender, e);
        }

        private void textBoxPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                buttonLogin_Click(sender, e);
        }
    }
}

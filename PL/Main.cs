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
using BLL;
using System.IO;

namespace PL
{
    public partial class Main : KryptonForm
    {
        public static Main mainInstance;

        private Login loginForm;        
       
        public Main(Form f)
        {
            Main.mainInstance = this;

            InitializeComponent();
            this.loginForm = (Login)f;
            this.iconButtonProfile.Text = Auth.CurrentUser.ACCOUNT_USERNAME;
            this.panel1.BackColor = CustomColor.Orange;
            this.panelTop.BackColor = CustomColor.DarkBlue;
            this.panelLeft.BackColor = CustomColor.DarkBlue;
            if (Auth.CurrentUser.ACCOUNT_ROLE == "ADMIN")
            {
                this.iconButtonAdminPanel.Visible = true;
            }
        }


        public void OpenChildForm(Form f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panelRight.Controls.Add(f);
            f.BringToFront();
            f.Show();
            
        }
        private void Main_Load(object sender, EventArgs e)
        {
            /*Auth.Login("Irwin", "password");*/

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonHome_Click(object sender, EventArgs e)
        {
            
        }
         
        private void iconButtonShop_Click(object sender, EventArgs e)
        {            
            this.OpenChildForm(new ShopTab());
        }        

        private void iconButtonProfile_MouseEnter(object sender, EventArgs e)
        {

        }

        private void iconButtonProfile_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            this.panel1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new AccountSettings());
            this.panel1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();            
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.BackColor = CustomColor.DarkBlue;
            //label1.BringToFront();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.BackColor = CustomColor.Orange;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.label2.BackColor = CustomColor.Orange;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.label2.BackColor = CustomColor.DarkBlue;
        }

        private void panelRight_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.panel1.Visible)
                this.panel1.Visible = false;
        }

        private void iconButtonAdminPanel_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new AdminPanel());

        }
    }
}

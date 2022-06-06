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
using System.Diagnostics;

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
            this.panelProfileSubMenu.BackColor = CustomColor.Orange;
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


        // Icon Button Panel Left
        private void iconButtonHome_Click(object sender, EventArgs e)
        {
            RefreshUI();
            this.iconButtonHome.IconColor = CustomColor.Orange;
            this.iconButtonHome.ForeColor = CustomColor.Orange;
        }
       
        private void iconButtonShop_Click(object sender, EventArgs e)
        {
            RefreshUI();
            this.iconButtonShop.IconColor = CustomColor.Orange;
            this.iconButtonShop.ForeColor = CustomColor.Orange;
            this.iconButtonShop.IconSize = 55;
            this.iconButtonShop.Font = new Font("Poppins", 20, FontStyle.Bold);

            
            
            this.OpenChildForm(new ShopTab());
        }        
        private void iconButtonBasket_Click(object sender, EventArgs e)
        {
            RefreshUI();
            this.iconButtonBasket.IconColor = CustomColor.Orange;
            this.iconButtonBasket.ForeColor = CustomColor.Orange;
            this.OpenChildForm(new Basket());
        }
        private void iconButtonAdminPanel_Click(object sender, EventArgs e)
        {
            RefreshUI();
            this.iconButtonAdminPanel.IconColor = CustomColor.Orange;
            this.iconButtonAdminPanel.ForeColor = CustomColor.Orange;
            this.OpenChildForm(new EmployeePanel());
        }


        // Concern Profile Icon and Profile's sub menu
        private void iconButtonProfile_Click(object sender, EventArgs e)
        {
            this.panelProfileSubMenu.Visible = true;
            this.panelProfileSubMenu.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new AccountSettings());
            this.panelProfileSubMenu.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.BackColor = CustomColor.DarkBlue;
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




        public void RefreshUI()
        {

            // Redéfini la couleur de tous les Icon Button en Blanc
            foreach (FontAwesome.Sharp.IconButton i in this.panelLeft.Controls.OfType<FontAwesome.Sharp.IconButton>())
            {
                i.IconColor = Color.White;
                i.ForeColor = Color.White;
            }
            this.iconButtonProfile.IconColor = Color.White;


            // Clear Tous les controles du Right Panel
            this.panelRight.Controls.Clear();


            // Redessine le Profile sub Menu (car tous les controles viennent d'être supprimé
            this.panelProfileSubMenu = new System.Windows.Forms.Panel();
            this.panelProfileSubMenu.SuspendLayout();
            this.panelProfileSubMenu.BackColor = CustomColor.Orange;
            this.panelProfileSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfileSubMenu.Controls.Add(this.label2);
            this.panelProfileSubMenu.Controls.Add(this.label1);
            this.panelProfileSubMenu.Location = new System.Drawing.Point(921, 0);
            this.panelProfileSubMenu.Name = "panelProfileSubMenu";
            this.panelProfileSubMenu.Size = new System.Drawing.Size(137, 66);
            this.panelProfileSubMenu.TabIndex = 10;
            this.panelProfileSubMenu.Visible = false;
            this.panelRight.Controls.Add(this.panelProfileSubMenu);
            this.panelProfileSubMenu.ResumeLayout(false);
            this.panelProfileSubMenu.PerformLayout();

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}

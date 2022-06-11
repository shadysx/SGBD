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
using FontAwesome.Sharp;

namespace PL
{
    public partial class Main : KryptonForm
    {
        public static Main mainInstance;

        private Login loginForm;

        private IconButton iconArrow;       

        private bool isProfileSubMenuTrigger;

        public Main(Form f)
        {
            Main.mainInstance = this;

            InitializeComponent();
            this.panelRight.BackColor = Color.White;
            
            this.BackColor = CustomColor.DarkBlue;
            
            

            this.loginForm = (Login)f;
            this.labelProfileUsername.Text = Auth.CurrentUser.ACCOUNT_USERNAME;
            this.panelProfileSubMenu.BackColor = CustomColor.Orange;
            this.panelTop.BackColor = CustomColor.DarkBlue;
            this.panelLeft.BackColor = CustomColor.DarkBlue;            

            if (Auth.CurrentUser.ACCOUNT_ROLE == "ADMIN")
            {
                this.iconButtonAdminPanel.Visible = true;
            }

            InitializeArrow();
            
            foreach (FontAwesome.Sharp.IconButton i in this.panelLeft.Controls.OfType<FontAwesome.Sharp.IconButton>())
            {
                i.Tag = i.Text;                
                i.FlatAppearance.MouseOverBackColor = Color.FromArgb(180,CustomColor.Orange);
                i.IconColor = CustomColor.Orange;
            }
                       
            this.iconButtonProfile.IconColor = CustomColor.Orange;

            this.isProfileSubMenuTrigger = false;
            DrawSelectedIcon(this.iconButtonHome);
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
            DrawSelectedIcon(this.iconButtonHome);
            this.isProfileSubMenuTrigger = false;
        }

        private void iconButtonShop_Click(object sender, EventArgs e)
        {
            RefreshUI();
            DrawSelectedIcon(this.iconButtonShop);
            this.OpenChildForm(new ShopTab());
            this.isProfileSubMenuTrigger = false;
        }
        private void iconButtonBasket_Click(object sender, EventArgs e)
        {
            RefreshUI();
            DrawSelectedIcon(this.iconButtonBasket);
            this.OpenChildForm(new Basket());
            this.isProfileSubMenuTrigger = false;
        }

        private void iconButtonHistory_Click(object sender, EventArgs e)
        {
            RefreshUI();
            DrawSelectedIcon(this.iconButtonHistory);
            this.OpenChildForm(new History());
            this.isProfileSubMenuTrigger = false;
        }

        private void iconButtonAdminPanel_Click(object sender, EventArgs e)
        {
            RefreshUI();
            DrawSelectedIcon(this.iconButtonAdminPanel);
            this.OpenChildForm(new EmployeeAddStockPanel());
            this.isProfileSubMenuTrigger = false;
        }


        private void DrawSelectedIcon(IconButton icon)
        {            
            icon.IconSize = 52;
            icon.ForeColor = CustomColor.Orange;            
            icon.Text = "";
            icon.IconColor = CustomColor.Orange;
            icon.Size = new System.Drawing.Size(61, 47);
            icon.Location = new System.Drawing.Point(121, icon.Location.Y);            
            icon.FlatAppearance.MouseOverBackColor = Color.Transparent;

            this.iconArrow.IconColor = CustomColor.Orange;
            this.iconArrow.Visible = true;

            this.iconArrow.Location = new System.Drawing.Point(61, icon.Location.Y);
            this.iconArrow.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }

        // Concern Profile Icon and Profile's sub menu

        private void panelProfile_Click(object sender, EventArgs e)
        {
            this.isProfileSubMenuTrigger = !this.isProfileSubMenuTrigger;

            if(isProfileSubMenuTrigger)
            {
                this.panelProfileSubMenu.Visible = true;
                this.panelProfileSubMenu.BringToFront();                
            }                    
            else
            {
                this.panelProfileSubMenu.Visible = false;               
                this.panelRight.BringToFront();                
            }

            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            RefreshUI();
            this.OpenChildForm(new AccountSettings());
            this.panelProfileSubMenu.Visible = false;
            this.isProfileSubMenuTrigger = false;           
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

            // Rend l'arrow invisble 
            this.iconArrow.Visible = false;           
            


            // Redéfini la couleur de tous les Icon Button en Blanc
            foreach (FontAwesome.Sharp.IconButton i in this.panelLeft.Controls.OfType<FontAwesome.Sharp.IconButton>())
            {
                i.Size = new System.Drawing.Size(197, 47);
                i.Location = new System.Drawing.Point(0, i.Location.Y);
                i.Text = i.Tag.ToString();
                i.IconColor = CustomColor.Orange;
                i.ForeColor = Color.White;
                i.IconSize = 48;
                i.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, CustomColor.Orange);

            }
            


            // Clear Tous les controles du Right Panel
            this.panelRight.Controls.Clear();


            // Redessine le Profile sub Menu (car tous les controles viennent d'être supprimé
            DrawProfileSubMenu();        

        }

        private void DrawProfileSubMenu()
        {
            this.panelProfileSubMenu = new System.Windows.Forms.Panel();
            this.panelProfileSubMenu.SuspendLayout();
            this.panelProfileSubMenu.BackColor = CustomColor.Orange;
            this.panelProfileSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfileSubMenu.Controls.Add(this.label2);
            this.panelProfileSubMenu.Controls.Add(this.label1);
            this.panelProfileSubMenu.Controls.Add(this.iconButton1);
            this.panelProfileSubMenu.Controls.Add(this.iconButton3);
            this.panelProfileSubMenu.Location = new System.Drawing.Point(858, -2);
            this.panelProfileSubMenu.Name = "panelProfileSubMenu";
            this.panelProfileSubMenu.Size = new System.Drawing.Size(174, 66);            
            this.panelProfileSubMenu.Visible = false;
            this.panelRight.Controls.Add(this.panelProfileSubMenu);
            this.panelProfileSubMenu.ResumeLayout(false);
            this.panelProfileSubMenu.PerformLayout();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeArrow()
        {
            this.iconArrow = new FontAwesome.Sharp.IconButton();
            this.panelLeft.Controls.Add(this.iconArrow);
            this.iconArrow.BackColor = System.Drawing.Color.Transparent;
            this.iconArrow.FlatAppearance.BorderSize = 0;
            this.iconArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconArrow.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconArrow.ForeColor = System.Drawing.Color.White;
            this.iconArrow.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.iconArrow.IconColor = CustomColor.Orange;
            this.iconArrow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconArrow.IconSize = 43;
            this.iconArrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconArrow.Location = new System.Drawing.Point(76, 125);
            this.iconArrow.Name = "iconArrow";
            this.iconArrow.Size = new System.Drawing.Size(54, 47);
            this.iconArrow.TabIndex = 4;
            this.iconArrow.FlatAppearance.MouseOverBackColor = Color.Transparent;    
            this.iconArrow.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.iconArrow.Visible = false;
            this.iconArrow.TabStop = false;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            this.panelProfile.BackColor = Color.FromArgb(255, CustomColor.Orange);
            this.iconButtonProfile.Enabled = false;
            this.labelProfileUsername.BackColor = Color.FromArgb(255, CustomColor.Orange);
            this.labelProfileUsername.Enabled = false;

        }        

        private void panelProfile_MouseLeave(object sender, EventArgs e)
        {
            this.panelProfile.BackColor = CustomColor.DarkBlue; ;
            this.iconButtonProfile.Enabled = true;
            this.labelProfileUsername.Enabled = true;
            this.labelProfileUsername.BackColor = CustomColor.DarkBlue;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}

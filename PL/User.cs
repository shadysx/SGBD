using BLL;
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
    public partial class User : Form
    {
        int id;
        public User(int accountID, string username, string email, string name, string lastName, string role)
        {
            InitializeComponent();
            this.id = accountID;
            this.labelUsername.Text = username;
            this.labelEmail.Text = email;
            this.labelName.Text = name;
            this.labelLastName.Text = lastName;
            this.labelRole.Text = role;
            this.labelID.Text = "#" + accountID;

            this.labelID.ForeColor = CustomColor.Orange;
            this.iconButton1.IconColor = CustomColor.Orange;
            this.iconButton2.IconColor = CustomColor.Orange;
            this.iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(180,CustomColor.Orange);
            this.iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, CustomColor.Orange);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Dispose();
            Main.mainInstance.OpenChildForm(new ModifyUser(id));
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelRole_Click(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to delete this account ?", "Validation", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                BLLUser.DeleteAccount(this.id);
                this.Dispose(); 
                Main.mainInstance.OpenChildForm(new AdminPanel());
            }
        }
    }
}

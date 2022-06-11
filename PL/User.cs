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
            this.labelUsername.Text = username;
            this.labelEmail.Text = email;
            this.labelName.Text = name;
            this.labelLastName.Text = lastName;
            this.labelRole.Text = role;
            this.id = accountID;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Dispose();
            Main.mainInstance.OpenChildForm(new ModifyUser(id));
        }
    }
}

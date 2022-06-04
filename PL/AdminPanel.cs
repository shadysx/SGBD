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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            this.iconButton1.BackColor = Color.White;
            this.iconButton2.BackColor = Color.White;
            this.BackColor = CustomColor.DarkBlue;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Main.mainInstance.OpenChildForm(new AdminPanelInsert());
        }
    }
}

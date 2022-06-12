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
    public partial class ModifyShop : Form
    {
        public ModifyShop(int idShop)
        {
            InitializeComponent();

            this.ForeColor = CustomColor.DarkBlue;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.mainInstance.OpenChildForm(new AdminPanel());
        }
    }
}

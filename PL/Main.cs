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
    public partial class Main : KryptonForm
    {
        public Main()
        {
            InitializeComponent();
            this.pnTop.BackColor = CustomColor.DarkBlue;
            this.pnLeft.BackColor = CustomColor.DarkBlue;
        }


        private void OpenChildForm(Form f)
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
    }
}

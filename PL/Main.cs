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
        }


        private void OpenChildForm(Form f, Button btnSender)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Controls.Add(f);
            f.Show();
            
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new ShopTab(), new Button());
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

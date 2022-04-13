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
            this.pnRight.Controls.Add(f);
            f.Show();
            
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new ShopTab(), new Button());
        }
    }
}

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
    public partial class Registration : KryptonForm
    {
        public Registration()
        {
            InitializeComponent();
            FormStyles();
        }

        private void FormStyles()
        {
            this.BackColor = CustomColor.LightBlue;
            this.panelLeft.BackColor = CustomColor.DarkBlue;
            this.panelRight.BackColor = CustomColor.LightBlue;
            this.buttonCancel.BackColor = CustomColor.Orange;
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}

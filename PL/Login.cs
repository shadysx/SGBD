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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            FormStyles();
        }

        public void FormStyles()
        {
            this.BackColor = CustomColor.Custom1;
        }
    }
}

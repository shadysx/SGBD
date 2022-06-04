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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            this.pictureBox1.ImageLocation = Environment.CurrentDirectory + @"\test.jpeg";
            this.pictureBox1.Dock = DockStyle.Fill;
        }
    }
}

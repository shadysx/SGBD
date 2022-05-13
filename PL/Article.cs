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
    public partial class Article : Form
    {
        public Article(string productName, string productType, Image productImage)
        {
            InitializeComponent();
            this.labelNomArticle.Text = productName;
            this.labelTypeArticle.Text = productType;
            this.pictureBox1.Image = productImage;
        }
    }
}

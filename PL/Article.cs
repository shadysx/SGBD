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
        public Article(Form parent, string productName, string productType, Image productImage)
        {
            InitializeComponent();
            this.labelNomArticle.Text = productName;
            this.labelTypeArticle.Text = productType;
            this.pictureBox1.Image = productImage;
            this.iconButton1.IconColor = CustomColor.Orange;
        }

        private void Article_Load(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Main.mainInstance.OpenChildForm(new ArticleDetails(this.labelNomArticle.Text));
        }
    }
}

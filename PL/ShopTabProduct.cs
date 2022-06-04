﻿using System;
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
    public partial class ShopTabProduct : Form
    {
        private string description;
        public ShopTabProduct(string productName, string productType, string description, string productImagePath, decimal bestPrice)
        {
            InitializeComponent();
            this.labelNameArticle.Text = productName;
            this.labelPrix.Text = $"From {bestPrice} €";
            this.labelTypeArticle.Text = productType;
            this.pictureBox1.ImageLocation = productImagePath;
            this.iconButton1.IconColor = CustomColor.Orange;
            this.description = description;
        }

        private void Article_Load(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Main.mainInstance.OpenChildForm(new DetailsTab(this.labelNameArticle.Text, this.description, this.pictureBox1.Image));
        }
    }
}

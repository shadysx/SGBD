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
    public partial class Product : Form
    {
        string name;
        public Product(string name, string seller, decimal price, int quantity, string country)
        {
            InitializeComponent();
            this.labelPrix.Text = "€ " + price.ToString();
            this.labelVendeur.Text = seller;
            this.labelQuantite.Text = "Quantité en stock : " + quantity.ToString();
            this.labelPays.Text = country;
            this.iconButton1.IconColor = CustomColor.Orange;
            this.name = name;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"{this.name} A bien été ajouté au panier");
        }
    }
}

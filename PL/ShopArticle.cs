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
    public partial class ShopArticle : Form
    {
        string nom;
        public ShopArticle(string nom, string vendeur, decimal prix, int quantite, string pays)
        {
            InitializeComponent();
            this.labelPrix.Text = "€ " + prix.ToString();
            this.labelVendeur.Text = vendeur;
            this.labelQuantite.Text = "Quantité en stock : " + quantite.ToString();
            this.labelPays.Text = pays;
            this.iconButton1.IconColor = CustomColor.Orange;
            this.nom = nom;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"{this.nom} A bien été ajouté au panier");
        }
    }
}

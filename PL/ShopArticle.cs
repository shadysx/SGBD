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
        public ShopArticle(string vendeur, decimal prix, int quantite, string pays)
        {
            InitializeComponent();
            this.labelPrix.Text = "€ " + prix.ToString();
            this.labelVendeur.Text = vendeur;
            this.labelQuantite.Text = "Quantité en stock : " + quantite.ToString();
            this.labelPays.Text = pays;
        }
    }
}

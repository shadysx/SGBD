using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace PL
{
    public partial class ArticleDetails : Form
    {
        public ArticleDetails(string articleName)
        {
            InitializeComponent();
            this.label1.Text = articleName;
            this.dataGridView1.DataSource = StockAccess.GetStock(articleName);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

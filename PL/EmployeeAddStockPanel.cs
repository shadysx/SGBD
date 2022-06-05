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
using DTO;
using System.Diagnostics;

namespace PL
{
    public partial class EmployeeAddStockPanel : Form
    {
        List<string> articleTypes = new List<string>();
        public EmployeeAddStockPanel()
        {
            InitializeComponent();
            this.articleTypes = ProductsAccess.SelectAllProductTypes();
            this.comboBox1.DataSource = articleTypes;
            this.comboBox2.DataSource = ProductsAccess.SelectProductsNamesByType(comboBox1.SelectedItem.ToString());
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.comboBox2.DataSource = ProductsAccess.SelectProductsNamesByType(comboBox1.SelectedItem.ToString());
        }
    }
}

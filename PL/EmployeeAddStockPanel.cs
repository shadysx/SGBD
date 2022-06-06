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
using BLL;

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

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown1.Value = StockAccess.GetStockByShopIDAndProductName(Auth.CurrentUser.ID_SHOP, this.comboBox2.SelectedValue.ToString());
            decimal price = StockAccess.GetProductPriceFromSpecificShop(this.comboBox2.SelectedValue.ToString(), Auth.CurrentUser.ID_SHOP);
            this.textBox1.Text = price.ToString();
        }

        private void ButtonConfirmStock_Click(object sender, EventArgs e)
        {

            StockAccess.UpdateStock(ProductsAccess.SelectProductIDByName(this.comboBox2.SelectedValue.ToString()) ,Auth.CurrentUser.ID_SHOP, Convert.ToInt32(this.numericUpDown1.Value) , Convert.ToDecimal(this.textBox1.Text));
            MessageBox.Show("Mise a jour effectuée");
            Main.mainInstance.OpenChildForm(new EmployeeAddStockPanel());
        }
    }
}

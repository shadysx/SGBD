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
using System.IO;

namespace PL
{
    public partial class EmployeeAddStockPanel : Form
    {
        List<string> articleTypes = new List<string>();
        string imagePath = ""; 
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

    
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    this.pictureBox1.ImageLocation = dialog.FileName.ToString();
                    string path = Path.Combine(@"\image\");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var fileName = System.IO.Path.GetFileName(dialog.FileName);
                    path = path + fileName;
                    File.Copy(dialog.FileName, path);
                    this.imagePath = fileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmployeeAddStockPanel_Click(object sender, EventArgs e)
        {
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsAccess.InsertProduct(this.textBoxProductName.Text, this.textBoxProductType.Text, this.textBoxProductDescription.Text);
                ProductsAccess.InsertImageForLastProduct(this.imagePath);
                MessageBox.Show("Référence ajoutée, vous pouvez maintenant gerer le stock");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

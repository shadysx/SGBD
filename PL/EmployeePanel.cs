using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Diagnostics;
using BLL;
using System.IO;
using System.Data.Linq;


namespace PL
{
    public partial class EmployeePanel : Form
    {
        List<string> articleTypes = new List<string>();
        string fileName; 
        public EmployeePanel()
        {
            InitializeComponent();
            this.BackColor = CustomColor.DarkBlue;
            try
            {
                this.articleTypes = BLLEmployeePanel.SelectAllProductTypes();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            this.comboBox1.DataSource = articleTypes;
            this.rjButton1.BackColor = CustomColor.Orange;
            this.rjButton3.BackColor = Color.White;
            this.rjButton2.BackColor = CustomColor.Orange;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.comboBox2.DataSource = BLLEmployeePanel.SelectProductsNamesByType(comboBox1.SelectedItem.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.numericUpDown1.Value = BLLEmployeePanel.GetStockByShopIDAndProductName(Auth.CurrentUser.ID_SHOP, this.comboBox2.SelectedValue.ToString());
                decimal price = BLLEmployeePanel.GetProductPriceFromSpecificShop(this.comboBox2.SelectedValue.ToString(), Auth.CurrentUser.ID_SHOP);
                byte[] bytes = BLLEmployeePanel.SelectImageByProductName(this.comboBox2.SelectedValue.ToString());
                Image image = ConvertToImage(bytes);
                this.pictureBox2.Image = image;
                this.textBox1.Text = price.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ButtonConfirmStock_Click(object sender, EventArgs e)
        {
            try
            {
                BLLEmployeePanel.UpdateStock(BLLEmployeePanel.SelectProductIDByName(this.comboBox2.SelectedValue.ToString()) ,Auth.CurrentUser.ID_SHOP, Convert.ToInt32(this.numericUpDown1.Value) , this.textBox1.Text);
                MessageBox.Show("Mise a jour effectuée");
                Main.mainInstance.OpenChildForm(new EmployeePanel());

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBoxProductName.Text == "")
                {
                    throw new Exception("Veuillez entrez un Nom de produit!");
                }
                if (this.textBoxProductType.Text == "")
                {
                    throw new Exception("Veuillez entrez un type de produit");
                }
                if (this.textBoxProductDescription.Text == "")
                {
                    throw new Exception("Veuillez entrez une description");
                }
                if (this.pictureBox1.Image == null)
                {
                    throw new Exception("Veuillez ajouter une image au produit");
                }

                //Convert picture box image to byte array
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] buff = ms.GetBuffer();

                BLLEmployeePanel.InsertProduct(this.textBoxProductName.Text, this.textBoxProductType.Text, this.textBoxProductDescription.Text);
                BLLEmployeePanel.InsertProductImage(this.fileName, BLLEmployeePanel.SelectLastProductID(), buff);
        
                MessageBox.Show("Référence ajoutée, vous pouvez maintenant gerer le stock");
                Main.mainInstance.OpenChildForm(new EmployeePanel());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                //Import image from pc to picturebox
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.pictureBox1.ImageLocation = dialog.FileName.ToString();
                    var file = System.IO.Path.GetFileName(dialog.FileName);
                    this.fileName = file;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static Image ConvertToImage(Binary iBinary)
        {
            var arrayBinary = iBinary.ToArray();
            Image rImage = null;

            using (MemoryStream ms = new MemoryStream(arrayBinary))
            {
                rImage = Image.FromStream(ms);
            }
            return rImage;
        }
    }
}

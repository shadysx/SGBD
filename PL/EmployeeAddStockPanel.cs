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
using System.Data.Linq;


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


                //Convert picture box image to byte array
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] buff = ms.GetBuffer();

                //Working, need to pass the picturebox image (buff is not used yet)
                //Insert image                
                ProductsAccess.InsertImage("wallpaper.jpg", 24, buff);
                

                //Working, Fetch image
                byte[] bytes = ProductsAccess.FetchImageTest();
                Image image = ConvertToImage(bytes);
                pictureBox2.Image = image;
                MessageBox.Show("Done");


                //Use part of this to load a file into the picturebox
                /*             OpenFileDialog dialog = new OpenFileDialog();
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
                               }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
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


        private void EmployeeAddStockPanel_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsAccess.InsertProduct(this.textBoxProductName.Text, this.textBoxProductType.Text, this.textBoxProductDescription.Text);
        
                MessageBox.Show("Référence ajoutée, vous pouvez maintenant gerer le stock");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

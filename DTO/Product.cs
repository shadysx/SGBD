using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public int ID_PRODUCT { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public string PRODUCT_DESCRIPTION { get; set; }
        public int ID_PICTURE { get; set; }
        public string PICTURE_URL { get; set; }
        public string PICTURE_PATH
        {
            get
            {
                return Environment.CurrentDirectory + $@"\..\..\..\Assets\Image\ProductImages\{PICTURE_URL}";
            }
        }
/*        public Image PRODUCT_PICTURE
        {
            get
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(PICTURE_URL);
                MemoryStream ms = new MemoryStream(bytes);
                return Image.FromStream(ms);
            }
        }*/

        public decimal PRODUCT_BEST_PRICE { get; set; }


        public override string ToString()
        {
            return "ID_PRODUCT" + ID_PRODUCT + "\n" +
                   "PRODUCT_NAME : " + PRODUCT_NAME + "\n" +
                   "PRODUCT_TYPE : " + PRODUCT_TYPE + "\n" +
                   "PRODUCT_DESCRIPTION : " + PRODUCT_DESCRIPTION + "\n" +
                   "PRODUCT_BEST_PRICE : " + PRODUCT_BEST_PRICE + "\n" +
                   "ID_PICTURE : " + ID_PICTURE + "\n" +
                   "PICTURE_PATH : " + PICTURE_PATH + "\n";
        }
    }
}

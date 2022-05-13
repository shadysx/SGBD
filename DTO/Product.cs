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
        public Image PRODUCT_PICTURE
        {
            get
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(PICTURE_URL);
                MemoryStream ms = new MemoryStream(bytes);
                return Image.FromStream(ms);
            }
        }


        public override string ToString()
        {
            return "ID_PRODUCT" + ID_PRODUCT + "\n" +
                   "PRODUCT_NAME : " + PRODUCT_NAME + "\n" +
                   "PRODUCT_TYPE : " + PRODUCT_TYPE + "\n" +
                   "PRODUCT_DESCRIPTION : " + PRODUCT_DESCRIPTION + "\n" +
                   "ID_PICTURE : " + ID_PICTURE + "\n" +
                   "PICTURE_URL : " + PICTURE_URL + "\n";
        }
    }
}

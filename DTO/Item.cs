using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Item
    {
        // ORDERED
        public int ID_ORDERED { get; set; }

        // OrderLine        
        public int ID_ORDER_LINE { get; set; }
        public int ORDER_LINE_QUANTITY { get; set; }
        public decimal ORDER_LINE_BUYING_PRICE { get; set; }

        // SHOP
        public int ID_SHOP { get; set; }
        public string SHOP_NAME { get; set; }
        public string  SHOP_ADDRESS { get; set; }
        public string SHOP_CITY { get; set; }
        public string SHOP_COUNTRY { get; set; }

        // PRODUCT
        public int ID_PRODUCT { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public string PRODUCT_DESCRIPTION { get; set; }

        // Picture
        public string PICTURE_URL { get; set; }
        public string PICTURE_PATH
        {
            get
            {
                return Environment.CurrentDirectory + $@"\..\..\..\Assets\Image\ProductImages\{PICTURE_URL}";
            }
        }

    }
}

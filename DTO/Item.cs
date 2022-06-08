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

        public override string ToString()
        {
            return $"ID_ORDERED : {ID_ORDERED}\n" +
                    $"ID_ORDER_LINE : {ID_ORDER_LINE}\n" +
                    $"ORDER_LINE_QUANTITY : {ORDER_LINE_QUANTITY}\n" +
                    $"ORDER_LINE_BUYING_PRICE : {ORDER_LINE_BUYING_PRICE}\n" +
                    $"ID_SHOP : {ID_SHOP}\n" +
                    $"SHOP_NAME : {SHOP_NAME}\n" +
                    $"SHOP_ADDRESS : {SHOP_ADDRESS}\n" +
                    $"SHOP_CITY : {SHOP_CITY}\n" +
                    $"SHOP_COUNTRY : {SHOP_COUNTRY}\n" +
                    $"ID_PRODUCT : {ID_PRODUCT}\n" +
                    $"PRODUCT_NAME : {PRODUCT_NAME}\n" +
                    $"PRODUCT_TYPE : {PRODUCT_TYPE}\n" +
                    $"PRODUCT_DESCRIPTION : {PRODUCT_DESCRIPTION}\n" +
                    $"PICTURE_URL : {PICTURE_URL}\n" +
                    $"PICTURE_PATH : {PICTURE_PATH}\n";
        

        
        }

    }
}

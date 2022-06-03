using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Stock
    {
        public int ID_PRODUCT { get; set; }
        public int ID_SHOP { get; set; }
        public string SHOP_NAME { get; set; }
        public int STOCK_QUANTITY { get; set; }
        public decimal SELLING_PRICE_EXCL_VAT { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public string PRODUCT_DESCRIPTION { get; set; }
        public string SHOP_ADDRESS { get; set; }
        public string SHOP_POSTAL_CODE { get; set; }
        public string SHOP_CITY { get; set; }
        public string SHOP_COUNTRY { get; set; }

        public override string ToString()
        {
            return "ID_PRODUCT : " + ID_PRODUCT + "\n" +
                   "ID_SHOP : " + ID_SHOP + "\n" +
                   "SHOP_NAME : " + SHOP_NAME + "\n" +
                   "STOCK_QUANTITY : " + STOCK_QUANTITY + "\n" +
                   "SELLING_PRICE_EXCL_VAT : " + SELLING_PRICE_EXCL_VAT + "\n" +
                   "PRODUCT_NAME : " + PRODUCT_NAME + "\n" +
                   "PRODUCT_TYPE : " + PRODUCT_TYPE + "\n" +
                   "PRODUCT_DESCRIPTION : " + PRODUCT_DESCRIPTION + "\n" +
                   "SHOP_ADDRESS : " + SHOP_ADDRESS + "\n" +
                   "SHOP_POSTAL_CODE : " + SHOP_POSTAL_CODE + "\n" +
                   "SHOP_CITY : " + SHOP_CITY + "\n" +
                   "SHOP_COUNTRY : " + SHOP_COUNTRY + "\n";
        }
    }


}

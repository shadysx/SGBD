using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLEmployeePanel
    {
        public static void InsertProduct(string productName, string productType, string productDescription) { ProductsAccess.InsertProduct(productName, productType, productDescription); }
        public static List<string> SelectAllProductTypes() {  return ProductsAccess.SelectAllProductTypes(); }
        public static List<string> SelectProductsNamesByType(string type) { return ProductsAccess.SelectProductsNamesByType(type); }
        public static int GetStockByShopIDAndProductName(int shopID, string productName) { return StockAccess.GetStockByShopIDAndProductName(shopID, productName); }
        public static Byte[] SelectImageByProductName(string productName) { return ProductsAccess.SelectImageByProductName(productName); }
        public static void UpdateStock(int productID, int shopID, int newStock, string sellingPrice) { StockAccess.UpdateStock(productID, shopID, newStock, sellingPrice); }
        public static void InsertNewShop(Shop shop) { ShopInfoAccess.InsertNewShop(shop); }
        public static void InsertProductImage(string pictureName, int productID, byte[] image) { ProductsAccess.InsertProductImage(pictureName, productID, image); }
        public static int SelectLastProductID() { return ProductsAccess.SelectLastProductID(); }
        public static decimal GetProductPriceFromSpecificShop(string productName, int shopID) { return StockAccess.GetProductPriceFromSpecificShop(productName, shopID); }
        public static int SelectProductIDByName(string productName) { return ProductsAccess.SelectProductIDByName(productName); }
    }
}

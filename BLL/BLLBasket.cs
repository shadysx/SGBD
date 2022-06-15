using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLBasket
    {
        public static List<Item> SelectAllItem(int idOrdered) { return ItemAccess.SelectAllItem(idOrdered); }
        public static void UpdateOrderer(int idAccount) { OrderedAccess.UpdateOrderer(idAccount); }
        public static void UpdateStockAfterBuy(List<Item> items) { StockAccess.UpdateStockAfterBuy(items); }
        public static void InsertNewOrdered(int idAccount) { OrderedAccess.InsertNewOrdered(idAccount); }
        public static Ordered SelectActualOrdered(int idAccount) { return OrderedAccess.SelectActualOrdered(idAccount); }
        public static Stock GetStockOf1Article(int shopID, int idProduct) { return StockAccess.GetStockOf1Article(shopID, idProduct); }
        public static void ModifyOrderline(int quantity, decimal buyingPrice, int idOrderLine) { OrderLineAccess.ModifyOrderline(quantity, buyingPrice, idOrderLine); }
        public static decimal GetProductPriceFromSpecificShop(string productName, int shopID) { return StockAccess.GetProductPriceFromSpecificShop(productName, shopID);}
        public static void DeleteOrderLine(int idOrderLine) { OrderLineAccess.DeleteOrderLine(idOrderLine); }
    }
}

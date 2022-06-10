using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLArticle
    {
        public static OrderLine Select1OrderLine(int idProduct, int idShop, int idOrdered) { return OrderLineAccess.Select1OrderLine(idProduct, idShop, Auth.CurrentUser.ACCOUNT_CURRENT_BASKET.ID_ORDERED); }
        public static Stock GetStockOf1Article(int shopID, int idProduct) { return StockAccess.GetStockOf1Article(shopID, idProduct); }
        public static void ModifyOrderline(int quantity, decimal buyingPrice, int idOrderLine) { OrderLineAccess.ModifyOrderline(quantity, buyingPrice, idOrderLine); }
        public static int InsertNewOrderLine(OrderLine orderline) { return OrderLineAccess.InsertNewOrderLine(orderline); }
    }
}

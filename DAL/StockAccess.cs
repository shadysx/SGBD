using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;

namespace DAL
{
    public class StockAccess
    {
        public static List<Stock> GetStock (string productName)
        {

            List<Stock> stock = new List<Stock>();

            string query = $"select * from stock inner join product on product.ID_PRODUCT = stock.ID_PRODUCT inner join shop on shop.ID_SHOP = stock.ID_SHOP where PRODUCT_NAME = '{productName}'";

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    stock = connexion.Query<Stock>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return stock;
        }

        public static void UpdateStockAfterBuy(List<Item> items)
        {           
            foreach(Item i in items)
            {
                using (var connexion = CON_MGR.Connection())
                    ////= SQL directe
                    try
                    {
                        connexion.Execute($"update Stock set STOCK_QUANTITY = STOCK_QUANTITY-{i.ORDER_LINE_QUANTITY} where ID_PRODUCT = {i.ID_PRODUCT} and ID_SHOP = {i.ID_SHOP}");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }                
            }

            

           
        }
    }
}

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
        // PROCEDURE 28
        public static List<Stock> GetStock(string productName)
        {
            List<Stock> stock = new List<Stock>();

            string query = $"execute GetStock '{productName.Replace("'","''")}'";

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
        
        // PROCEDURE 29
        public static decimal GetProductPriceFromSpecificShop(string productName, int shopID)
        {
            Stock stock = new Stock();
            decimal price = 0;

            string query = $"execute GetProductPriceFromSpecificShop '{productName.Replace("'", "''")}' , {shopID}";

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    stock = connexion.QuerySingleOrDefault<Stock>(query);

                    if (stock != null)
                        price = stock.SELLING_PRICE_EXCL_VAT;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return price;
        }
        
        // PROCEDURE 30
        public static void UpdateStockAfterBuy(List<Item> items)
        {
            foreach (Item i in items)
            {
                using (var connexion = CON_MGR.Connection())
                    ////= SQL directe
                    try
                    {
                        connexion.Execute($"execute	UpdateStockAfterBuy @ORDER_LINE_QUANTITY, @ID_PRODUCT, @ID_SHOP",i);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
            }
        }
        
        // PROCEDURE 31 et 32
        public static void UpdateStock(int productID, int shopID, int newStock, string sellingPrice)
        {
            int res;
            // La Ligne ci-bas est juste parce que mon Visual Studio est en Français

            string s = sellingPrice.Replace(",", ".");
            string query = $"execute UpdateStock1 {newStock},{productID},{shopID},{s}";
            string query2 = $"execute UpdateStock2 {newStock},{productID},{shopID},{s}";

            
            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    res = connexion.Execute(query);                    

                    if (res == 0)
                    {
                        res = connexion.Execute(query2);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }               

        // PROCEDURE 33
        public static int GetStockByShopIDAndProductName(int shopID, string productName)
        {
            string query = $"Execute GetStockByShopIDAndProductName {shopID}, '{productName.Replace("'", "''")}'";
            Stock res;
            int stock;

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    res = connexion.QuerySingleOrDefault<Stock>(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            if (res == null)
            {
                stock = 0;
            }
            else
            {
                stock = res.STOCK_QUANTITY;
            }

            return stock;

        }        

        // PROCEDURE 34
        public static Stock GetStockOf1Article(int shopID, int idProduct)
        {
            string query = $"execute GetStockOf1Article {idProduct}, {shopID}";
            Stock s = new Stock();

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    s = connexion.QuerySingleOrDefault<Stock>(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return s;
        }
    }
}

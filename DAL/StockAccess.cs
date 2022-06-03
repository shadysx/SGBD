using System;
using System.Collections.Generic;
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
    }
}

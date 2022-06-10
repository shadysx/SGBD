using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;

namespace DAL
{
    public class ItemAccess
    {

        // PROCEDURE 9

        /*public static List<Item> SelectAllItem(int idOrdered)
        {
            List<Item> retVal = null;
            string query = $"select distinct o.ID_ORDERED, o.ID_PRODUCT, o.ID_ORDER_LINE, o.ORDER_LINE_QUANTITY, o.ORDER_LINE_BUYING_PRICE, s.ID_SHOP, s.SHOP_NAME, s.SHOP_ADDRESS, s.SHOP_CITY, s.SHOP_COUNTRY, p.PRODUCT_NAME, p.PRODUCT_TYPE, p.PRODUCT_DESCRIPTION, pic.Picture from ORDER_LINE o inner join product p on p.id_product = o.id_product inner join picture pic on pic.id_product = p.id_product inner join shop s on s.ID_SHOP = o.ID_SHOP where o.ID_ORDERED = {idOrdered}";

            using (var connection = CON_MGR.Connection())
                try
                {
                    retVal = connection.Query<Item>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            return retVal;
        }*/

        public static List<Item> SelectAllItem(int idOrdered)
        {
            List<Item> retVal = null;
            string query = $"execute SelectAllItem {idOrdered}";

            using (var connection = CON_MGR.Connection())
                try
                {
                    retVal = connection.Query<Item>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            return retVal;
        }
    }
}

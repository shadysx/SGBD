using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;

namespace DAL
{
    public class OrderLineAccess
    {
        public static int AddProductToCard(OrderLine orderline)
        {
            int retVal;

            using (var connection = CON_MGR.Connection())
                try
                {
                    retVal = connection.Query<int>("INSERT INTO ORDER_LINE (ORDER_LINE_QUANTITY ,  ORDER_LINE_BUYING_PRICE ,  ID_SHOP ,  ID_PRODUCT , ID_ORDERED)  " +
                                                   "       VALUES   (@ORDER_LINE_QUANTITY,  @ORDER_LINE_BUYING_PRICE,  @ID_SHOP,  @ID_PRODUCT, @ID_ORDERED)" +
                                                  "SELECT CAST(SCOPE_IDENTITY() AS INT)",
                                                   orderline).Single();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            return retVal;
        }
    }
}

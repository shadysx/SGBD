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

        public static void ModifyOrderline(OrderLine orderLine, int idOrderLine)
        {
            // La Ligne ci-bas est juste parce que mon Visual Studio est en Français
            string s = Convert.ToInt32(orderLine.ORDER_LINE_BUYING_PRICE).ToString() + "." + orderLine.ORDER_LINE_BUYING_PRICE.ToString().Substring(orderLine.ORDER_LINE_BUYING_PRICE.ToString().Length - 2);

            using (var connection = CON_MGR.Connection())
                try
                {
                    connection.Execute($"update ORDER_LINE set ORDER_LINE_QUANTITY = {orderLine.ORDER_LINE_QUANTITY}, order_line_buying_price = {s} where id_order_line = {idOrderLine}");
                }
                catch (Exception ex)
                {
                    throw (ex);
                }           
            
        }




        public static List<OrderLine> SelectAllOrderLine(int idOrdered)
        {
            List<OrderLine> retVal;

            using (var connection = CON_MGR.Connection())
                try
                {
                    retVal = connection.Query<OrderLine>($"select * from order_line where ID_ORDERED = {idOrdered}").ToList();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            return retVal;
        }


    }
}

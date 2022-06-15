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
        // PROCEDURE 14
        public static int InsertNewOrderLine(OrderLine orderline)
        {
            int retVal;

            using (var connection = CON_MGR.Connection())
                try
                {
                    retVal = connection.Query<int>("execute InsertNewOrderLine @ORDER_LINE_QUANTITY,  @ORDER_LINE_BUYING_PRICE,  @ID_SHOP,  @ID_PRODUCT, @ID_ORDERED", orderline).Single();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            return retVal;
        }

        // PROCEDURE 15
        public static void ModifyOrderline(int quantity, decimal buyingPrice, int idOrderLine)
        {
            // La Ligne ci-bas est juste parce que mon Visual Studio est en Français
            string s = (int)(buyingPrice) + "." + buyingPrice.ToString().Substring(buyingPrice.ToString().Length - 2);

            using (var connection = CON_MGR.Connection())
                try
                {
                    connection.Execute($"execute ModifyOrderline {quantity}, {s}, {idOrderLine}");
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
        }

        // PROCEDURE 16
        public static OrderLine Select1OrderLine(int idProduct, int idShop, int idOrdered)
        {
            OrderLine retVal;

            using (var connection = CON_MGR.Connection())
                try
                {
                    retVal = connection.QuerySingleOrDefault<OrderLine>($"execute Select1OrderLine {idProduct}, {idShop} ,{idOrdered}");
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            return retVal;
        }

        // PROCEDURE 17
        public static void DeleteOrderLine(int idOrderLine)
        {
            using (var connection = CON_MGR.Connection())
                try
                {
                    connection.Execute($"execute DeleteOrderLine {idOrderLine}");
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
        }
    }
}

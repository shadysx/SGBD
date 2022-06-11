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






        // OLD REQUEST (without stored procedure)
        // PROCEDURE 14
        /*public static int InsertNewOrderLine(OrderLine orderline)
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
        }*/

        // PROCEDURE 15
        /*public static void ModifyOrderline(int quantity,decimal buyingPrice,  int idOrderLine)
        {
            // La Ligne ci-bas est juste parce que mon Visual Studio est en Français

            string s = (int)(buyingPrice) + "." + buyingPrice.ToString().Substring(buyingPrice.ToString().Length - 2);
            
            using (var connection = CON_MGR.Connection())
                try
                {
                    connection.Execute($"update ORDER_LINE set ORDER_LINE_QUANTITY = {quantity}, order_line_buying_price = {s} where id_order_line = {idOrderLine}");
                }
                catch (Exception ex)
                {
                    throw (ex);
                }           
            
        }*/

        // PROCEDURE 16

        /*public static OrderLine Select1OrderLine(int idProduct, int idShop, int idOrdered)
        {
            OrderLine retVal;

            using (var connection = CON_MGR.Connection())
                try
                {
                    retVal = connection.QuerySingleOrDefault<OrderLine>($"select * from order_line where ID_ORDERED = {idOrdered} and id_product = {idProduct} and id_shop = {idShop}");
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            return retVal;
        }*/

        // PROCEDURE 17

        /*public static void DeleteOrderLine(int idOrderLine)
        {
           

            using (var connection = CON_MGR.Connection())
                try
                {
                    connection.Execute($"delete from order_line where ID_ORDER_LINE = {idOrderLine}");
                }
                catch (Exception ex)
                {
                    throw (ex);
                }            
        }*/





        // ===============================================================
        // APPAREMENT PAS UTILISER A VERIFIER
        /*public static List<OrderLine> SelectAllOrderLine(int idOrdered)
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
        }*/
        // ===============================================================



    }
}

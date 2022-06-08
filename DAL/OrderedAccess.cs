using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Diagnostics;

namespace DAL
{
    public class OrderedAccess
    {
        public static Ordered SelectActualOrdered(int idAccount)
        {
            Ordered retval = null;

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    retval = connexion.QuerySingleOrDefault<Ordered>($"select top 1 ID_ACCOUNT, MAX(ID_ORDERED) AS ID_ORDERED, ORDERED_DATE from Ordered where id_account = {idAccount} group by ID_ACCOUNT, ORDERED_DATE");
                }
                catch (Exception ex)
                {
                    throw ex;
                }            

            return retval;
        }

        
        public static List<HistoryPurchaseDTO> SelectAllHistoryPurchaseDTO(int idAccount)
        {
            List<HistoryPurchaseDTO> retval = null;

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    retval = connexion.Query<HistoryPurchaseDTO>($"select sum(ol.ORDER_LINE_BUYING_PRICE) as TOTAL_PRICE, sum(ol.ORDER_LINE_QUANTITY) as TOTAL_QUANTITY, o.ID_ORDERED, o.ID_ACCOUNT , o.ORDERED_DATE from ORDER_LINE ol inner join ORDERED o on o.ID_ORDERED = ol.ID_ORDERED where o.ID_ACCOUNT = {idAccount} group by o.ID_ORDERED, o.ID_ACCOUNT, o.ORDERED_DATE order by o.ID_ORDERED desc").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return retval;

        }


        public static void InsertNewOrdered(int idAccount)
        {            
            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    connexion.Execute($"insert into Ordered values(null, {idAccount})");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            
        }

        public static void UpdateOrderer(int idAccount)
        {
            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    connexion.Execute($"update ORDERED set ORDERED_DATE = '{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}' where(select MAX(ID_ORDERED) AS ID_ORDERED from Ordered where id_account = {idAccount}) = ID_ORDERED");
                }
                catch (Exception ex)
                {
                    throw ex;
                }

        }


    }
}

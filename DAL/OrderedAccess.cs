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
        // PROCEDURE 10
        public static Ordered SelectActualOrdered(int idAccount)
        {
            Ordered retval = null;

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    retval = connexion.QuerySingleOrDefault<Ordered>($"execute SelectActualOrdered {idAccount}");
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return retval;
        }              

        // PROCEDURE 11
        public static List<HistoryPurchaseDTO> SelectAllHistoryPurchaseDTO(int idAccount)
        {
            List<HistoryPurchaseDTO> retval = null;

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    retval = connexion.Query<HistoryPurchaseDTO>($"Execute SelectAllHistoryPurchaseDTO {idAccount}").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return retval;

        }
        
        // PROCEDURE 12
        public static void InsertNewOrdered(int idAccount)
        {
            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    connexion.Execute($"execute InsertNewOrdered {idAccount}");
                }
                catch (Exception ex)
                {
                    throw ex;
                }

        }

        // PROCEDURE 13
        public static void UpdateOrderer(int idAccount)
        {
            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    connexion.Execute($"Execute UpdateOrderer {idAccount}, '{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}'");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }
    }
}

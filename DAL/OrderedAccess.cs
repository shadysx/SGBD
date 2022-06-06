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
        public static Ordered SelectOrdered(int idAccount)
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

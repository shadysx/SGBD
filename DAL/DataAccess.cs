using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using Dapper;

namespace DAL
{
    public static class DataAccess
    {
        public static List<Account> SelectAllAccounts()
        {
            List<Account> retVal = null;

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    retVal = connexion.Query<Account>("select * from ACCOUNT").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return retVal;
        }
    }
}

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

        public static int InsertNewAccount(Account newAccount)
        {
            int retVal;

            using (var connection = CON_MGR.Connection())
                try
                {
                    retVal = connection.Query<int>("INSERT INTO ACCOUNT (ACCOUNT_EMAIL,  ACCOUNT_USERNAME,  ACCOUNT_PASSWORD,  ACCOUNT_LAST_NAME, ACCOUNT_FIRST_NAME, ACCOUNT_BIRTH_DATE, ACCOUNT_ADDRESS, ACCOUNT_CITY, ACCOUNT_POSTAL_CODE, ACCOUNT_COUNTRY, ACCOUNT_ROLE)  " +
                                                   "       VALUES   (@ACCOUNT_EMAIL,  @ACCOUNT_USERNAME,  @ACCOUNT_PASSWORD,  @ACCOUNT_LAST_NAME, @ACCOUNT_FIRST_NAME, @ACCOUNT_BIRTH_DATE, @ACCOUNT_ADDRESS, @ACCOUNT_CITY, @ACCOUNT_POSTAL_CODE, @ACCOUNT_COUNTRY, @ACCOUNT_ROLE)" +
                                                   "SELECT CAST(SCOPE_IDENTITY() AS INT)",
                                                   newAccount).Single();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            return retVal;
        }
    }
}

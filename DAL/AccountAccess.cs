using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using DTO;
using Dapper;
using System.IO;

namespace DAL
{
    public static class AccountAccess
    {
        // Procédure 1 
        public static List<Account> SelectAllAccounts()
        {
            List<Account> retVal = null;

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    retVal = connexion.Query<Account>("execute SelectAllAccount").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return retVal;
        }

        public static List<Account> SelectAllAccountsBy(string by, string value)
        {
            string query = $"SELECT * FROM ACCOUNT WHERE {by} LIKE lower('%{value}%')";

            value = value.ToLower();

            List<Account> retVal = null;

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    retVal = connexion.Query<Account>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return retVal;
        }

        // Procédure 2
        public static int InsertNewAccount(Account newAccount)
        {
            int retVal;

            using (var connection = CON_MGR.Connection())
                try
                {
                    retVal = connection.Query<int>("Execute InsertNewAccount @ACCOUNT_EMAIL , @ACCOUNT_USERNAME , @ACCOUNT_PASSWORD , @ACCOUNT_LAST_NAME , @ACCOUNT_FIRST_NAME , @ACCOUNT_BIRTH_DATE , @ACCOUNT_ADDRESS , @ACCOUNT_CITY , @ACCOUNT_POSTAL_CODE , @ACCOUNT_COUNTRY , @ACCOUNT_ROLE, @ID_SHOP", newAccount).Single();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            return retVal;
        }

        // Procedure 3
        public static void InsertModifyAccount(Account modifyAccount)
        {

            using (var connection = CON_MGR.Connection())
                try
                {
                    connection.Execute("Execute InsertModifyAccount @ACCOUNT_ADDRESS, @ACCOUNT_CITY, @ACCOUNT_POSTAL_CODE, @ACCOUNT_COUNTRY, @ACCOUNT_USERNAME ", modifyAccount);
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
        }

        // PROCEDURE 4 
        public static void UpdatePassword(string newPassword, string username)
        {

            using (var connection = CON_MGR.Connection())
                try
                {

                    connection.Execute($"Execute UpdatePassword '{newPassword.Replace("'", "''")}','{username.Replace("'", "''")}'");
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
        }

        // PROCEDURE 5
        public static void InsertProfileImage(string pictureName, int idAccount, byte[] image)
        {
            string query = "execute InsertProfileImage @PICTURE, @ID_ACCOUNT, @PICTURE_URL ";

            var parameters = new DynamicParameters();
            parameters.Add("@PICTURE_URL", pictureName);
            parameters.Add("@ID_ACCOUNT", idAccount);
            parameters.Add("@PICTURE", image);

            using (var connexion = CON_MGR.Connection())
            {
                try
                {
                    connexion.Execute(query, parameters);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        // Procedure 6
        public static int GetLastCreatedAccount()
        {
            int retval = 0;

            using (var connexion = CON_MGR.Connection())
            {
                try
                {
                    retval = connexion.Query<int>("execute GetLastCreatedAccount").Single();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return retval;
        }

        // PROCEDURE 7
        public static void ModifyProfileImage(string pictureName, int idAccount, byte[] image)
        {
            string query = $"execute ModifyProfileImage @PICTURE, @ID_ACCOUNT, @PICTURE_URL";

            var parameters = new DynamicParameters();
            parameters.Add("@PICTURE_URL", pictureName);
            parameters.Add("@ID_ACCOUNT", idAccount);
            parameters.Add("@PICTURE", image);

            using (var connexion = CON_MGR.Connection())
            {
                try
                {
                    connexion.Execute(query, parameters);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        // PROCEDURE 8
        public static Byte[] SelectProfileImage(int idAccount)
        {
            string query = $"execute SelectProfileImage {idAccount}";
            Byte[] bytes = null;

            using (var connexion = CON_MGR.Connection())
            {
                try
                {
                    bytes = connexion.QuerySingleOrDefault<Byte[]>(query);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            return bytes;
        }

        // PROCEDURE 35
        
        static public Account GetAccoundByID(int accountID)
        {
            Account acc = null;

            string query = $"Execute GetAccoundByID {accountID}";

            using (var connexion = CON_MGR.Connection())
                try
                {
                    acc = connexion.Query<Account>(query).Single();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            return acc;

        }

        //Procedure 36

        static public void DeleteAccount(int accountID)
        {
            string query = $"Execute DeleteAccount {accountID}";

            using (var connexion = CON_MGR.Connection())
                try
                {
                    connexion.Execute(query);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }           
        }

        // PROCEDURE 37
        public static void UpdateAccount(Account newAccount)
        {
            string idShopnull = "null";
            if(newAccount.ID_SHOP > 0)
                idShopnull = "" + newAccount.ID_SHOP;

            string query = $"execute UpdateAccount @ACCOUNT_EMAIL, @ACCOUNT_USERNAME,@ACCOUNT_PASSWORD, @ACCOUNT_LAST_NAME, @ACCOUNT_FIRST_NAME, @ACCOUNT_BIRTH_DATE, @ACCOUNT_ADDRESS, @ACCOUNT_CITY, @ACCOUNT_POSTAL_CODE, @ACCOUNT_COUNTRY, @ACCOUNT_ROLE, {idShopnull}, @ID_ACCOUNT";

            using (var connexion = CON_MGR.Connection())
                try
                {
                    connexion.Execute(query, newAccount);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
        }
    }
}

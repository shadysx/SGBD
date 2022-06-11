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



        static public Account GetAccoundByID(int accountID)
        {
            Account acc = null;

            string query = $"SELECT * FROM ACCOUNT WHERE ID_ACCOUNT = {accountID}";

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


        // OLD REQUEST (without stored procedure)

        // Procédure 1 

        /*public static List<Account> SelectAllAccounts()
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
        }*/


        // Procédure 2

        /*public static int InsertNewAccount(Account newAccount)
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
        }*/

        // Procedure 3
        /*public static void InsertModifyAccount(Account modifyAccount)
        {
           
            using (var connection = CON_MGR.Connection())
                try
                {                    
                    connection.Execute("UPDATE ACCOUNT " +
                                          "SET ACCOUNT_ADDRESS = @ACCOUNT_ADDRESS, ACCOUNT_CITY = @ACCOUNT_CITY, " +
                                          "ACCOUNT_POSTAL_CODE = @ACCOUNT_POSTAL_CODE, ACCOUNT_COUNTRY = @ACCOUNT_COUNTRY " +
                                          "WHERE ACCOUNT_USERNAME LIKE @ACCOUNT_USERNAME ", modifyAccount);
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
        }*/

        // PROCEDURE 4 
        /*public static void UpdatePassword(string newPassword, string username)
        {

            using (var connection = CON_MGR.Connection())
                try
                {
                    
                    connection.Execute(String.Format("UPDATE ACCOUNT " +
                                        "SET ACCOUNT_PASSWORD = '{0}' " +
                                        "WHERE ACCOUNT_USERNAME = '{1}'", newPassword, username));
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
        }*/

        // PROCEDURE 5

        /*public static void InsertProfileImage(string pictureName, int idAccount, byte[] image)
        {
            string query = "insert into picture (PICTURE_URL, ID_ACCOUNT, PICTURE) values (@PICTURE_URL, @ID_ACCOUNT, @PICTURE)";

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
        }*/

        // Procedure 6

        /*public static int GetLastCreatedAccount()
        {
            int retval = 0;

            using (var connexion = CON_MGR.Connection())
            {
                try
                {
                    retval = connexion.Query<int>("Select Max(ID_Account) from account").Single();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return retval;
        }*/

        // PROCEDURE 7

        /*public static void ModifyProfileImage(string pictureName, int idAccount, byte[] image)
        {
            string query = $"update PICTURE set PICTURE_URL = @PICTURE_URL, PICTURE = @PICTURE where id_account = @ID_ACCOUNT";

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
        }*/

        // PROCEDURE 8

        /*public static Byte[] SelectProfileImage(int idAccount)
        {
            string query = $"select picture from picture inner join ACCOUNT on picture.ID_ACCOUNT = account.ID_ACCOUNT where account.ID_ACCOUNT = {idAccount}";
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
        }*/
    }
}

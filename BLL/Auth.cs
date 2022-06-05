using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Security.Cryptography;
using System.Diagnostics;

namespace BLL
{
    public static class Auth
    {
        public static Account CurrentUser { get; set; }
        public static void Login(string username, string password)
        {
            Auth.CurrentUser = null;

            List<Account> accounts = AccountAccess.SelectAllAccounts();

            foreach (Account account in accounts)
            {
                if (account.ACCOUNT_USERNAME == username && account.ACCOUNT_PASSWORD == Auth.ComputeSha256Hash(password))
                {

                    LoadCard(account);
                    Auth.CurrentUser = account;
                    
                    break;
                }
            }

            if (CurrentUser is null)
                throw new Exception($"Username or password does not match");
        }

        private static void LoadCard(Account account)
        {
            Ordered ordered = OrderedAccess.SelectOrdered(account.ID_ACCOUNT);

            if (ordered != null)
            {
                Debug.Print("C'est pas null");
                Debug.Print(ordered.ID_ORDERED + "");
            }
            else
                Debug.Print("C'est null a fou");

            if (ordered != null && ordered.ORDERED_DATE < new DateTime (1880,1,1))
            {
                account.ACCOUNT_CURRENT_CARD = ordered;
            }
            
            

            if (account.ACCOUNT_CURRENT_CARD != null)
            {
                Debug.Print("account ordered n'est pas null");
                Debug.Print(ordered.ID_ORDERED + "");
            }
            else
                Debug.Print("account ordered en null");


            /*if (ordered != null && ordered.ORDERED_DATE == null)
                account.ACCOUNT_CURRENT_CARD = ordered;
            else
                account.ACCOUNT_CURRENT_CARD = null;*/

            

        }

        public static bool SignUp(Account newAccount)
        {
            bool result = false;

            try
            {
                newAccount.ACCOUNT_PASSWORD = ComputeSha256Hash(newAccount.ACCOUNT_PASSWORD);
                AccountAccess.InsertNewAccount(newAccount);
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


    }
}


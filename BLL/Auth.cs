using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Drawing;
using System.Security.Cryptography;


namespace BLL
{
    public static class Auth
    {
        public static Account CurrentUser { get; set; }
        public static void Login(string username, string password)
        {
            List<Account> accounts = DataAccess.SelectAllAccounts();

            foreach (Account account in accounts)
            {
                if (account.ACCOUNT_USERNAME == username && account.ACCOUNT_PASSWORD == Auth.ComputeSha256Hash(password))
                {
                    CurrentUser = account;
                }
            }

            if (CurrentUser is null)
                throw new Exception($"Username or password does not match");
        }

        public static bool SignUp(Account newAccount)
        {
            bool result = false;



            try
            {
                newAccount.ACCOUNT_PASSWORD = ComputeSha256Hash(newAccount.ACCOUNT_PASSWORD);
                DataAccess.InsertNewAccount(newAccount);
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


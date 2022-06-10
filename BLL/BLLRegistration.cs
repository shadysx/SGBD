using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLRegistration
    {
        public static List<Account> SelectAllAccounts() { return AccountAccess.SelectAllAccounts(); }

        public static void InsertProfileImage(string pictureName, int idAccount, byte[] image) { AccountAccess.InsertProfileImage(pictureName, idAccount, image); }

        public static int GetLastCreatedAccount() { return AccountAccess.GetLastCreatedAccount(); }
    }
}

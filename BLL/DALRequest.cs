using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public static class DALRequest
    {
        public static List<Account> SelectAllAccounts() { return AccountAccess.SelectAllAccounts();}
        public static void InsertModifyAccount(Account modifyAccount) { AccountAccess.InsertModifyAccount(modifyAccount);}
        public static void UpdatePassword(string newPassword, string username) { AccountAccess.UpdatePassword(newPassword, username);}

        
    }
}

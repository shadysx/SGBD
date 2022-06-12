using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLModifyUser
    {
        public static List<Account> SelectAllAccounts() { return AccountAccess.SelectAllAccounts(); }
        public static void UpdateAccount(Account newAccount) { AccountAccess.UpdateAccount(newAccount); }
        public static List<string> GetShopNameList() { return ShopInfoAccess.GetShopNameList(); }
    }
}

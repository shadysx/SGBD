using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLAdminPanel
    {
        public static int GetShopIDByName(string shopName) { return DAL.ShopInfoAccess.GetShopIDByName(shopName); }

        public static List<string> GetShopNameList() { return DAL.ShopInfoAccess.GetShopNameList(); }

        public static List<Account> SelectAllAccounts() { return AccountAccess.SelectAllAccounts(); }
        public static Account GetAccountByID(int accountID) { return AccountAccess.GetAccoundByID(accountID); }

        public static Shop GetShopInfo(int shopID) { return DAL.ShopInfoAccess.GetShopInfo(shopID); }

    }
}

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
        public static List<Shop> SelectAllShop() { return ShopInfoAccess.SelectAllShop(); }        
        public static Account GetAccountByID(int accountID) { return AccountAccess.GetAccoundByID(accountID); }
        public static Shop GetShopInfo(int shopID) { return DAL.ShopInfoAccess.GetShopInfo(shopID); }
        public static List<Account> SelectAllAccountsBy(string by, string value) { return AccountAccess.SelectAllAccountsBy(by, value); }
        public static List<Shop> SelectAllShopsBy(string by, string value) { return ShopInfoAccess.SelectAllShopsBy(by, value); }
        public static int SelectProductIDByName(string productName) { return ProductsAccess.SelectProductIDByName(productName); }

    }
}

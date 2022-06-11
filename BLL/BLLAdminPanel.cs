using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLAdminPanel
    {
        public static int GetShopIDByName(string shopName) { return DAL.ShopInfoAccess.GetShopIDByName(shopName); }

        public static List<string> GetShopNameList() { return DAL.ShopInfoAccess.GetShopNameList(); }
    }
}

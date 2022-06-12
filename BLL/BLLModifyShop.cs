using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLModifyShop
    {
        public static Shop GetShopInfo(int shopID) { return ShopInfoAccess.GetShopInfo(shopID); }
        public static void UpdateShop(Shop shop) { ShopInfoAccess.UpdateShop(shop); }
        
    }
}

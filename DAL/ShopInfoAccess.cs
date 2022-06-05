using DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ShopInfoAccess
    {
        public static ShopInfo GetShopInfo(int shopID)
        {
            ShopInfo shopInfo = new ShopInfo();

            string query = $"select * from SHOP where ID_SHOP = {shopID}";

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    shopInfo = connexion.Query<ShopInfo>(query).Single();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return shopInfo;
        }
    }
}

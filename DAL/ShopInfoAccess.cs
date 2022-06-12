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
        // PROCEDURE 27       
        public static Shop GetShopInfo(int shopID)
        {
            Shop shopInfo = new Shop();

            string query = $"execute GetShopInfo {shopID}";

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    shopInfo = connexion.Query<Shop>(query).Single();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return shopInfo;
        }
        public static List<string> GetShopNameList()
        {
            List<string> list = new List<string>();

            string query = $"select SHOP_NAME from SHOP";

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    list = connexion.Query<string>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return list;

        }

        public static int GetShopIDByName(string shopName)
        {
            int id = 0;

            string query = $"select ID_SHOP from SHOP where SHOP_NAME = '{shopName}'";

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    id = connexion.Query<int>(query).Single();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return id;

        }

        public static void InsertNewShop(Shop shop)
        {
            string query = $"INSERT INTO SHOP  VALUES(@SHOP_NAME, @SHOP_ADDRESS, @SHOP_POSTAL_CODE, @SHOP_CITY, @SHOP_COUNTRY)";
            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    connexion.Execute(query, shop);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }

        public static List<Shop> SelectAllShop()
        {
            List<Shop> retval = new List<Shop>();
            using (var connexion = CON_MGR.Connection())                
                try
                {
                    retval = connexion.Query<Shop>("Select * from shop").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return retval;
        }

        public static void DeleteShop(int idShop)
        {
            using (var connexion = CON_MGR.Connection())
            try
            {
                connexion.Execute($"delete from shop where ID_SHOP = {idShop}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        // PROCEDURE 27
        // 
        /*public static ShopInfo GetShopInfo(int shopID)
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
        }*/

    }
}

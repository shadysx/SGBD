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




        // PROCEDURE 38

        public static List<string> GetShopNameList()
        {
            List<string> list = new List<string>();

            string query = $"execute GetShopNameList";

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

        // PROCEDURE 39

        public static int GetShopIDByName(string shopName)
        {
            int id = 0;

            string query = $"Execute GetShopIDByName '{shopName}'";

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

        // PROCEDURE 40

        public static void InsertNewShop(Shop shop)
        {
            string query = $"EXECUTE InsertNewShop @SHOP_NAME, @SHOP_ADDRESS, @SHOP_POSTAL_CODE, @SHOP_CITY, @SHOP_COUNTRY";
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

        // PROCEDURE 41

        public static List<Shop> SelectAllShop()
        {
            List<Shop> retval = new List<Shop>();
            using (var connexion = CON_MGR.Connection())                
                try
                {
                    retval = connexion.Query<Shop>("Execute SelectAllShop").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return retval;
        }

        // PROCEDURE 42
        public static List<Shop> SelectAllShopsBy(string by, string value)
        {
            string query = $"Execute SelectAllShopsBy '{by}', '{value}'";

            value = value.ToLower();

            List<Shop> retVal = null;

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    retVal = connexion.Query<Shop>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return retVal;
        }

        // PROCEDURE 43

        public static void DeleteShop(int idShop)
        {
            using (var connexion = CON_MGR.Connection())
            try
            {
                connexion.Execute($"Execute DeleteShop {idShop}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PROCEDURE 44

        public static void UpdateShop(Shop shop)
        {
            using (var connexion = CON_MGR.Connection())
                try
                {
                    connexion.Execute($"Execute UpdateShop @SHOP_NAME, @SHOP_ADDRESS, @SHOP_POSTAL_CODE, @SHOP_CITY, @SHOP_COUNTRY, @ID_SHOP",shop);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BLL;
using DAL;
using DTO;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                Console.WriteLine("Hello world");
                Console.Read();
                //Auth.Login("ShadySX", "password");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(Auth.CurrentUser);
            */

            ShopInfo shopInfo = ShopInfoAccess.GetShopInfo(1);

            Console.WriteLine(shopInfo.SHOP_NAME);

            ProductsAccess.InsertDecimal(420.20m);


            Console.Read();
        }
    }
}

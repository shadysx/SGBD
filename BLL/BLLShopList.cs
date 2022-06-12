using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLShopList
    {
        public static void DeleteShop(int idShop) { ShopInfoAccess.DeleteShop(idShop); }
    }
}

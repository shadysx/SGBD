using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLShopTab
    {
        public static List<Product> Select20RandomProducts() { return ProductsAccess.Select20RandomProducts(); }
        public static List<Product> SelectFilteredProducts(string searchByName, string searchByType, string orderBy) { return ProductsAccess.SelectFilteredProducts(searchByName, searchByType, orderBy); }
        public static List<string> SelectAllProductTypes() { return ProductsAccess.SelectAllProductTypes(); }
    }
}

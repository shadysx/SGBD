using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;

namespace DAL
{
    public class ProductsAccess
    {
        public static List<Product> Select20RandomProducts()
        {

            List<Product> products = new List<Product>();

            string query = "select top 20 PRODUCT.ID_PRODUCT ,PRODUCT_NAME, PRODUCT_TYPE, PRODUCT_DESCRIPTION, ID_PICTURE, PICTURE_URL, min(SELLING_PRICE_EXCL_VAT) as PRODUCT_BEST_PRICE from PRODUCT inner join PICTURE on PICTURE.ID_PRODUCT = PRODUCT.ID_PRODUCT inner join stock on stock.ID_PRODUCT = PRODUCT.ID_PRODUCT group by product.ID_PRODUCT, PRODUCT_NAME, PRODUCT_TYPE, PRODUCT_DESCRIPTION, ID_PICTURE, PICTURE_URL order by newid()";


            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    products = connexion.Query<Product>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return products;
        }

        public static List<Product> SelectProductImage(string productName)
        {

            List<Product> products = new List<Product>();

            string query = $"select PRODUCT_NAME, ID_PICTURE, PICTURE_URL from PRODUCT p  inner join PICTURE pic on pic.ID_PRODUCT = p.ID_PRODUCT where p.PRODUCT_NAME = '{productName}'";


            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    products = connexion.Query<Product>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return products;
        }
    }
}

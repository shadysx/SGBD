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
        public static List<string> SelectAllProductTypes()
        {

            List<Product> products = new List<Product>();
            List<string> productsTypes = new List<string>();

            string query = "select distinct PRODUCT.PRODUCT_TYPE from PRODUCT";


            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    products = connexion.Query<Product>(query).ToList();
                    foreach (Product product in products)
                    {
                        productsTypes.Add(product.PRODUCT_TYPE);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return productsTypes;
        }

        public static List<string> SelectProductsNamesByType(string type)
        {

            List<Product> products = new List<Product>();
            List<string> productsNames = new List<string>();

            string query = $"select * from product where PRODUCT_TYPE = '{type}'";


            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    products = connexion.Query<Product>(query).ToList();
                    foreach (Product product in products)
                    {
                        productsNames.Add(product.PRODUCT_NAME);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return productsNames;
        }


        /* public static List<Product> SelectProductImage(string productName)
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
         }*/

        public static void InsertProduct(string productName, string productType, string productDescription )
        {
            string query = $"INSERT INTO PRODUCT VALUES('{productName}', 'Processeur', 'Le processeur AMD Ryzen 5 3600 Wraith Stealth (3.6 GHz / 4.2 GHz) fait partie des premiers processeurs pour PC gravés en 7 nm.')";
        }
    }
}

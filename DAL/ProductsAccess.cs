using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;
using System.Diagnostics;

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
        public static int SelectProductIDByName(string productName)
        {

            Product product =  new Product();
            int productID;

            string query = $"select ID_PRODUCT from product where PRODUCT_NAME = '{productName}'";


            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    product = connexion.Query<Product>(query).Single();
                    productID = product.ID_PRODUCT;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return productID;
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

        public static void InsertProduct(string productName, string productType, string productDescription )
        {
            string query = $"INSERT INTO PRODUCT VALUES('{productName.Replace("'", "''")}', '{productType.Replace("'", "''")}', '{productDescription.Replace("'", "''")}')";

            using (var connexion = CON_MGR.Connection())
                try
                {
                    Debug.WriteLine(query);
                    connexion.Query(query);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
        }

        public static void InsertImageForLastProduct(string filePath)
        {
            string lastProductIDQuery = "select top 1 ID_PRODUCT from PRODUCT order by ID_PRODUCT desc";
            int lastProductID;

            using (var connexion = CON_MGR.Connection())
                try
                {
                    lastProductID = connexion.Query<int>(lastProductIDQuery).Single();
                    connexion.Query($"INSERT INTO PICTURE VALUES('{filePath}', {lastProductID})");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
        }
    }
}

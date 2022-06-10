using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;
using System.Diagnostics;
using System.Drawing;

namespace DAL
{
    public class ProductsAccess
    {

        //PROCEDURE 18

        /*public static List<Product> Select20RandomProducts()
        {

            List<Product> products = new List<Product>();

            string query = "select top 20 PRODUCT.ID_PRODUCT ,PRODUCT_NAME, PRODUCT_TYPE, PRODUCT_DESCRIPTION, ID_PICTURE, PICTURE_URL, PICTURE, min(SELLING_PRICE_EXCL_VAT) as PRODUCT_BEST_PRICE from PRODUCT inner join PICTURE on PICTURE.ID_PRODUCT = PRODUCT.ID_PRODUCT inner join stock on stock.ID_PRODUCT = PRODUCT.ID_PRODUCT group by product.ID_PRODUCT, PRODUCT_NAME, PRODUCT_TYPE, PRODUCT_DESCRIPTION, ID_PICTURE, PICTURE_URL, PICTURE order by newid()";


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


        public static List<Product> Select20RandomProducts()
        {

            List<Product> products = new List<Product>();

            string query = "execute Select20RandomProducts";


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
               

        // PROCEDURE 19

        /*public static List<string> SelectAllProductTypes()
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
        }*/
        public static List<string> SelectAllProductTypes()
        {

            List<Product> products = new List<Product>();
            List<string> productsTypes = new List<string>();

            string query = "execute SelectAllProductTypes";


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


        //PROCEDURE 20

        /*public static int SelectProductIDByName(string productName)
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
        }*/
        public static int SelectProductIDByName(string productName)
        {

            Product product = new Product();
            int productID;

            string query = $"execute SelectProductIDByName '{productName.Replace("'", "''")}'";


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


        // PROCEDURE 21

        /*public static List<string> SelectProductsNamesByType(string type)
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
        }*/
        public static List<string> SelectProductsNamesByType(string type)
        {

            List<Product> products = new List<Product>();
            List<string> productsNames = new List<string>();

            string query = $"execute SelectProductsNamesByType '{type.Replace("'", "''")}'";


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

        //PROCEDURE 22
        /*public static void InsertProduct(string productName, string productType, string productDescription )
        {
            string query = $"INSERT INTO PRODUCT VALUES('{productName.Replace("'", "''")}', '{productType.Replace("'", "''")}', '{productDescription.Replace("'", "''")}')";

            using (var connexion = CON_MGR.Connection())
                try
                {
                    connexion.Query(query);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
        }*/
        public static void InsertProduct(string productName, string productType, string productDescription)
        {
            string query = $"execute InsertProduct '{productName.Replace("'", "''")}', '{productType.Replace("'", "''")}', '{productDescription.Replace("'", "''")}'";

            using (var connexion = CON_MGR.Connection())
                try
                {
                    connexion.Query(query);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
        }

        // PROCEDURE 23

        /*public static int SelectLastProductID()
        {
            string query = "select max(ID_PRODUCT) from product";
            int lastProductID = 0;

            using (var connexion = CON_MGR.Connection())
            {
                try
                {
                    lastProductID = connexion.Query<int>(query).Single();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            return lastProductID;
        }*/
        public static int SelectLastProductID()
        {
            string query = "execute SelectLastProductID";
            int lastProductID = 0;

            using (var connexion = CON_MGR.Connection())
            {
                try
                {
                    lastProductID = connexion.Query<int>(query).Single();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            return lastProductID;
        }


        // PROCEDURE 24
        /*public static Byte[] SelectImageByProductName(string productName)
        {
            string query = $"select picture from product inner join picture on picture.ID_PRODUCT = product.ID_PRODUCT where PRODUCT_NAME = '{productName.Replace("'","''")}'";
            Byte[] bytes = null;

            using (var connexion = CON_MGR.Connection())
            {
                try
                {
                    bytes = connexion.Query<Byte[]>(query).Single();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            return bytes;
        }*/
        public static Byte[] SelectImageByProductName(string productName)
        {
            string query = $"execute SelectImageByProductName '{productName.Replace("'","''")}'";
            Byte[] bytes = null;

            using (var connexion = CON_MGR.Connection())
            {
                try
                {
                    bytes = connexion.Query<Byte[]>(query).Single();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            return bytes;
        }

        // PROCEDURE 25

        /*public static void InsertProductImage(string pictureName, int productID ,byte[] image)
        {
            string query = "insert into  picture (PICTURE_URL, ID_PRODUCT, PICTURE) values (@PICTURE_URL,@ID_PRODUCT, @PICTURE)";
            var parameters = new DynamicParameters();
            parameters.Add("@PICTURE_URL", pictureName);
            parameters.Add("@ID_PRODUCT", productID);
            parameters.Add("@PICTURE", image);

            using (var connexion = CON_MGR.Connection())
            {
                try
                {
                    connexion.Execute(query, parameters);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }*/
        public static void InsertProductImage(string pictureName, int productID, byte[] image)
        {
            string query = "execute InsertProductImage @PICTURE_URL, @ID_PRODUCT, @PICTURE";
            var parameters = new DynamicParameters();
            parameters.Add("@PICTURE_URL", pictureName);
            parameters.Add("@ID_PRODUCT", productID);
            parameters.Add("@PICTURE", image);

            using (var connexion = CON_MGR.Connection())
            {
                try
                {
                    connexion.Execute(query, parameters);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }


        // PROCEDURE 34
        /*public static List<Product> SelectFilteredProducts(string query)
        {
            List<Product> products = new List<Product>();

            using (var connexion = CON_MGR.Connection())
                try { products = connexion.Query<Product>(query).ToList(); }
                catch (Exception ex) { throw ex; }

            return products;
        }*/
        public static List<Product> SelectFilteredProducts(string query)
        {
            List<Product> products = new List<Product>();

            using (var connexion = CON_MGR.Connection())
                try { products = connexion.Query<Product>(query).ToList(); }
                catch (Exception ex) { throw ex; }

            return products;
        }
    }
}

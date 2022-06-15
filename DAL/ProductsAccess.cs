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
        public static Byte[] SelectImageByProductName(string productName)
        {
            string query = $"execute SelectImageByProductName '{productName.Replace("'", "''")}'";
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

        // PROCEDURE 26
        public static List<Product> SelectFilteredProducts(string searchByName, string searchByType, string orderBy)
        {
            List<Product> products = new List<Product>();
            using (var connexion = CON_MGR.Connection())
                try { products = connexion.Query<Product>($"execute SelectFilteredProducts '{searchByName.Replace("'", "''")}', '{searchByType.Replace("'", "''")}', '{orderBy.Replace("'", "''")}'").ToList(); }
                catch (Exception ex) { throw ex; }

            return products;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;


namespace DAL
{
    public class StockAccess
    {

        // PROCEDURE 27

        /*public static List<Stock> GetStock (string productName)
        {

            List<Stock> stock = new List<Stock>();

            string query = $"select * from stock inner join product on product.ID_PRODUCT = stock.ID_PRODUCT inner join shop on shop.ID_SHOP = stock.ID_SHOP where PRODUCT_NAME = '{productName}'";

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    stock = connexion.Query<Stock>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return stock;
        }*/

        public static List<Stock> GetStock(string productName)
        {

            List<Stock> stock = new List<Stock>();

            string query = $"execute GetStock '{productName.Replace("'","''")}'";

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    stock = connexion.Query<Stock>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return stock;
        }


        // PROCEDURE 28
        /*public static decimal GetProductPriceFromSpecificShop(string productName, int shopID)
        {

            Stock stock = new Stock();
            decimal price = 0;

            string query = $"select SELLING_PRICE_EXCL_VAT from stock  inner join shop on shop.ID_SHOP = stock.ID_SHOP inner join product on product.ID_PRODUCT = stock.ID_PRODUCT where PRODUCT_NAME = '{productName}' and shop.ID_SHOP = {shopID}";

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    stock = connexion.QuerySingleOrDefault<Stock>(query);

                    if (stock != null)
                        price = stock.SELLING_PRICE_EXCL_VAT;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return price;
        }*/
        public static decimal GetProductPriceFromSpecificShop(string productName, int shopID)
        {

            Stock stock = new Stock();
            decimal price = 0;

            string query = $"execute GetProductPriceFromSpecificShop '{productName.Replace("'", "''")}' , {shopID}";

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    stock = connexion.QuerySingleOrDefault<Stock>(query);

                    if (stock != null)
                        price = stock.SELLING_PRICE_EXCL_VAT;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return price;
        }

        // PROCEDURE 29

        /*public static void UpdateStockAfterBuy(List<Item> items)
        {           
            foreach(Item i in items)
            {
                using (var connexion = CON_MGR.Connection())
                    ////= SQL directe
                    try
                    {
                        connexion.Execute($"update Stock set STOCK_QUANTITY = STOCK_QUANTITY-{i.ORDER_LINE_QUANTITY} where ID_PRODUCT = {i.ID_PRODUCT} and ID_SHOP = {i.ID_SHOP}");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }                
            }
        }*/

        public static void UpdateStockAfterBuy(List<Item> items)
        {
            foreach (Item i in items)
            {
                using (var connexion = CON_MGR.Connection())
                    ////= SQL directe
                    try
                    {
                        connexion.Execute($"execute	UpdateStockAfterBuy @ORDER_LINE_QUANTITY, @ID_PRODUCT, @ID_SHOP",i);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
            }
        }

        // PROCEDURE 30 et 31

        /*public static void UpdateStock(int productID, int shopID, int newStock, decimal sellingPrice)
        {
            int res;
            // La Ligne ci-bas est juste parce que mon Visual Studio est en Français
            string s = (int)(sellingPrice) + "." + sellingPrice.ToString().Substring(sellingPrice.ToString().Length - 2);
            string query = $"update stock  set STOCK_QUANTITY = {newStock}, SELLING_PRICE_EXCL_VAT = {s}  where ID_PRODUCT = {productID} and ID_SHOP = {shopID}";
            string query2 = $"insert into stock values({productID},{shopID},{newStock}, {sellingPrice})";
            

            
            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    res = connexion.Execute(query);
                    

                    if (res == 0)
                    {
                        res = connexion.Execute(query2);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }*/
        public static void UpdateStock(int productID, int shopID, int newStock, string sellingPrice)
        {
            int res;
            // La Ligne ci-bas est juste parce que mon Visual Studio est en Français

            string s = sellingPrice.Replace(",", ".");
            string query = $"execute UpdateStock1 {newStock},{productID},{shopID},{s}";
            string query2 = $"execute UpdateStock2 {newStock},{productID},{shopID},{s}";

            
            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    res = connexion.Execute(query);                    

                    if (res == 0)
                    {
                        res = connexion.Execute(query2);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }



        // PROCEDURE 32
        /*public static int GetStockByShopIDAndProductName(int shopID, string productName)
        {
            string query = $"select STOCK_QUANTITY from dbo.stock inner join shop on stock.ID_SHOP = shop.ID_SHOP inner join product on product.ID_PRODUCT = stock.ID_PRODUCT where shop.ID_SHOP = {shopID}  and product.PRODUCT_NAME = '{productName}'";
            Stock res;
            int stock;
            
            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    res = connexion.QuerySingleOrDefault<Stock>(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            if (res == null)
            {
                stock = 0;
            }
            else
            {
                stock = res.STOCK_QUANTITY;
            }

            return stock;

        }*/

        public static int GetStockByShopIDAndProductName(int shopID, string productName)
        {
            string query = $"Execute GetStockByShopIDAndProductName {shopID}, '{productName.Replace("'", "''")}'";
            Stock res;
            int stock;

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    res = connexion.QuerySingleOrDefault<Stock>(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            if (res == null)
            {
                stock = 0;
            }
            else
            {
                stock = res.STOCK_QUANTITY;
            }

            return stock;

        }

        // PROCEDURE 33
        /*public static Stock GetStockOf1Article(int shopID, int idProduct)
        {
            string query = $"select * from stock where ID_PRODUCT = {idProduct} and ID_SHOP = {shopID}";
            Stock s = new Stock();

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    s = connexion.QuerySingleOrDefault<Stock>(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }            

            return s;

        }*/
        public static Stock GetStockOf1Article(int shopID, int idProduct)
        {
            string query = $"execute GetStockOf1Article {idProduct}, {shopID}";
            Stock s = new Stock();

            using (var connexion = CON_MGR.Connection())
                ////= SQL directe
                try
                {
                    s = connexion.QuerySingleOrDefault<Stock>(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return s;

        }
    }
}

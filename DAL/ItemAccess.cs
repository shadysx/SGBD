using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;

namespace DAL
{
    public class ItemAccess
    {        
        // PROCEDURE 9
        public static List<Item> SelectAllItem(int idOrdered)
        {
            List<Item> retVal = null;
            string query = $"execute SelectAllItem {idOrdered}";

            using (var connection = CON_MGR.Connection())
                try
                {
                    retVal = connection.Query<Item>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            return retVal;
        }
    }
}

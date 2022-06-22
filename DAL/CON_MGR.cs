using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public static class CON_MGR
    {
        public static IDbConnection Connection()
        {
            return new SqlConnection(@"Data Source = (local)\SQLEXPRESS; Initial Catalog = DB_SGB_PROJECT_V2-1; Integrated Security = True");
        }
        
    }
}

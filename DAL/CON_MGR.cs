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
            return new SqlConnection(@"Data Source=shady.ddns.net;Initial Catalog=DB_SGB_PROJECT_V2-1;Persist Security Info=True;User ID=sa;Password=this=Password**");
        }
        
    }
}

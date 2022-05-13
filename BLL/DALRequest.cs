using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public static class DALRequest
    {
        public static List<Account> SelectAllAccounts() { return AccountAccess.SelectAllAccounts(); } 

    }
}

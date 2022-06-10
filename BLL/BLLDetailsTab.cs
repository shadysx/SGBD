using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLDetailsTab
    {
        public static List<Stock> GetStock(string productName) { return StockAccess.GetStock(productName); }
    }
}

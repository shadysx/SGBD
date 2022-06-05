using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderLine
    {
        public int ID_ORDER_LINE { get; set; }
        public int ORDER_LINE_QUANTITY { get; set; }
        public decimal ORDER_LINE_BUYING_PRICE { get; set; }
        public int ID_SHOP { get; set; }
        public int ID_PRODUCT { get; set; }
        public int ID_ORDERED { get; set; }
    }
}

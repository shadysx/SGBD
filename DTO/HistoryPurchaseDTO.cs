using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HistoryPurchaseDTO
    {
        public decimal TOTAL_PRICE { get; set; }

        public int TOTAL_QUANTITY { get; set; }

        public int ID_ORDERED { get; set; }

        public int ID_ACCOUNT { get; set; }

        public DateTime ORDERED_DATE { get; set; }
    }
}

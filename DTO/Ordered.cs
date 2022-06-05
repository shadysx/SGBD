using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ordered
    {
        public int ID_ORDERED { get; set; }
        public DateTime ORDERED_DATE { get; set; }
        public int ID_ACCOUNT { get; set; }

        public override string ToString()
        {
            return $"{ID_ORDERED} : ID ORDERED \n{ORDERED_DATE} : DATE\n {ID_ACCOUNT} : ID ACCOUNT";
        }
    }
}

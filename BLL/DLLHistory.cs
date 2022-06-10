using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DLLHistory
    {
        public static List<HistoryPurchaseDTO> SelectAllHistoryPurchaseDTO(int idAccount) { return OrderedAccess.SelectAllHistoryPurchaseDTO(Auth.CurrentUser.ID_ACCOUNT); }

        public static List<Item> SelectAllItem(int idOrdered) {return ItemAccess.SelectAllItem(idOrdered); }



    }
}

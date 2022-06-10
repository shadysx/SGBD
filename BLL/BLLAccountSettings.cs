using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class BLLAccountSettings
    {
        public static Byte[] SelectProfileImage(int idAccount) { return AccountAccess.SelectProfileImage(Auth.CurrentUser.ID_ACCOUNT); }

        public static void InsertProfileImage(string pictureName, int idAccount, byte[] image) { AccountAccess.InsertProfileImage(pictureName, idAccount, image); }

        public static void ModifyProfileImage(string pictureName, int idAccount, byte[] image) { AccountAccess.ModifyProfileImage(pictureName, idAccount, image); }
    }
}
